
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

using iTin.Core;

using iTin.Hardware.Abstractions.Devices.Desktop;
using iTin.Hardware.Specification.Eedid;
using iTin.Hardware.Specification.Eedid.Blocks;
using iTin.Hardware.Specification.Eedid.Blocks.EDID;

namespace iTin.Hardware.Specification;

/// <summary>
/// Implementation of the <strong>E-EDID</strong> (Extended Display Identification Data) specification.
/// </summary> 
public sealed class EEDID
{
    #region private members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)] 
    private DataBlockCollection _blockCollection;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly ReadOnlyCollection<byte> _rawData;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Dictionary<KnownDataBlock, BaseDataBlock> _blockTable;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="EEDID"/> class by specifying the data matrix.
    /// </summary>
    /// <param name="rawData">Data</param>
    /// <remarks>
    /// Returns the <strong>E-EDID</strong> information available.
    /// </remarks>
    private EEDID(IEnumerable<byte> rawData)
    {
        _rawData = null;
        if (rawData != null)
        {
            _rawData = rawData.ToList().AsReadOnly();
        }
    }

    #endregion

    #region public static readonly properties

    /// <summary>
    /// Returns a new instance containing all available <see cref="EEDID"/> structures for this machine.
    /// </summary>
    /// <returns>
    /// A <see cref="EEDID"/> array that contains <strong>Extended Display Identification Data</strong> information for this machine.
    /// </returns>
    public static EEDID[] Instance => (EEDID[])MonitorOperations.Instance
        .GetEdidDataCollection()
        .Select(rawEdidItem => new EEDID(rawEdidItem))
        .ToArray()
        .Clone();

    #endregion

    #region public static methods

    /// <summary>
    /// Parses <see cref="EEDID" /> raw data.
    /// </summary>
    /// <param name="data">Raw data to parse</param>
    /// <returns>
    /// A <see cref="EEDID"/> reference that contains <strong>Extended Display Identification Data</strong> information.
    /// </returns>
    public static EEDID Parse(byte[] data) => new(data);

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets the collection of blocks available for this <see cref="EEDID" />.
    /// </summary>
    /// <value>
    /// Object <see cref="DataBlockCollection"/> that contains the object collection <see cref="DataBlock"/> for this <see cref="EEDID"/>.
    /// If there is no object <see cref="DataBlock"/>, <see langword="null"/> is returned.
    /// </value>
    public DataBlockCollection Blocks
    {
        get
        {
            if (HasBlocks)
            {
                _blockCollection ??= new DataBlockCollection(this, true);
            }

            return _blockCollection;
        }        
    }

    /// <summary>
    /// Gets a value that indicates if there are available blocks.
    /// </summary>
    /// <value>
    /// <see langword="true"/> if there are blocks;  otherwise <see langword="false"/>.
    /// </value>
    public bool HasBlocks
    {
        get
        {
            if (_rawData == null)
            {
                return false;
            }

            return BlockTable.Count > 0;
        }
    }

    #endregion

    #region internal readonly properties

    /// <summary>
    /// Gets a value that represents the available blocks.
    /// </summary>
    /// <value>
    /// Dictionary containing block type / block value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    internal Dictionary<KnownDataBlock, BaseDataBlock> BlockTable
    {
        get
        {
            if (_blockTable != null)
            {
                return _blockTable;
            }

            _blockTable = new Dictionary<KnownDataBlock, BaseDataBlock>();
            InitBlockTable(_blockTable);

            return _blockTable;
        }
    }

    #endregion

    #region public methods

    /// <summary>
    /// Returns the raw data for current <see cref="EEDID"/> instance.
    /// </summary>
    /// <returns>
    /// The raw data for current <see cref="EEDID"/> instance.
    /// </returns>
    public ReadOnlyCollection<byte> GetRawData() => new(Blocks.SelectMany(b => b.RawData).ToList());

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>
    /// <see cref="T:System.String" /> that represents the current object.
    /// </returns>
    /// <remarks>
    /// The <see cref="EEDID.ToString()" /> method returns a string that includes the number of available blocks.
    /// </remarks>   
    public override string ToString() => HasBlocks ? $"Blocks = {Blocks.Count}" : "Blocks = 0";

    #endregion

    #region private static methods

    /// <summary>
    /// Returns a list with the information of the available extension blocks untreated.
    /// </summary>
    /// <param name="edidData">Array containing the raw data from block 0 (<see cref = "KnownDataBlock.EDID" />)</param>
    /// <returns>
    /// List of read-only byte arrays that contains the data of each available extension block untreated.
    /// </returns>
    private static IEnumerable<ReadOnlyCollection<byte>> GetExtensionDataBlocks(ReadOnlyCollection<byte> edidData)
    {
        var extensionBlockCount = edidData[0x7e];
        var dataBlocks = new List<ReadOnlyCollection<byte>>();

        if (extensionBlockCount == 0)
        {
            for (int n = 0x01, i = 0x00; i < extensionBlockCount; i++, n++)
            {
                dataBlocks.Add(edidData.Extract((byte)(n * 0x80), (byte)0x80));
            }
        }
        else
        {
            if (edidData.Count > 0x80)
            {
                for (int n = 0x01, i = 0x00; i < extensionBlockCount; i++, n++)
                {
                    dataBlocks.Add(edidData.Extract((byte)(n * 0x80), (byte)0x80));
                }
            }
        }

        return dataBlocks;
    }

    #endregion

    #region private methods

    /// <summary>
    /// Initialize dictionary with the available blocks.
    /// </summary>
    /// <param name="blockDictionary">Dictionary with available blocks</param>
    private void InitBlockTable(IDictionary<KnownDataBlock, BaseDataBlock> blockDictionary)
    {
        blockDictionary.Add(KnownDataBlock.EDID, new EdidBlock(_rawData));

        var extensionDataBlocks = GetExtensionDataBlocks(_rawData);
        foreach (var extensionDataBlock in extensionDataBlocks)
        {
            switch ((EdidProperty.EdidExtensionBlockTag)extensionDataBlock[0x00])                    
            {
                case EdidProperty.EdidExtensionBlockTag.CEA:
                    blockDictionary.Add(KnownDataBlock.CEA, new CeaBlock(extensionDataBlock));
                    break;

                case EdidProperty.EdidExtensionBlockTag.VTB:
                    blockDictionary.Add(KnownDataBlock.VTB, new VtbBlock(extensionDataBlock));
                    break;

                case EdidProperty.EdidExtensionBlockTag.DI:
                    blockDictionary.Add(KnownDataBlock.DI, new DiBlock(extensionDataBlock));
                    break;

                case EdidProperty.EdidExtensionBlockTag.LS:
                    blockDictionary.Add(KnownDataBlock.LS, new LsBlock(extensionDataBlock));
                    break;

                case EdidProperty.EdidExtensionBlockTag.DisplayID:
                    blockDictionary.Add(KnownDataBlock.DisplayID, new DisplayIdBlock(extensionDataBlock));
                    break;

                case EdidProperty.EdidExtensionBlockTag.DPVL:
                    //blockDictionary.Add(KnownDataBlock.DPVL, new DpvlLBlock(extensionDataBlock));
                    break;

                case EdidProperty.EdidExtensionBlockTag.BlockMap:
                    //blockDictionary.Add(KnownDataBlock.BlockMap, new BlockMapBlock(extensionDataBlock));
                    break;

                case EdidProperty.EdidExtensionBlockTag.ByManufacturer:
                    //blockDictionary.Add(KnownDataBlock.ByManufacturer, new ByManufacturerBlock(extensionDataBlock));
                    break;
            }                        
        }
    }

    #endregion
}
