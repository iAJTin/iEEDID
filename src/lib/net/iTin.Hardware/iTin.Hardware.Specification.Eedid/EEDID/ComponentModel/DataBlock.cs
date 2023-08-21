
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

using iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections;
using iTin.Hardware.Specification.Eedid.Blocks.DI.Sections;
using iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections;
using iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections;

namespace iTin.Hardware.Specification.Eedid;

/// <summary>
/// Represents a data block
/// </summary>
public sealed class DataBlock
{
    #region private members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private DataBlockCollection _parent;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private BaseDataSectionCollection _sections;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the class <see cref="DataBlockCollection"/> by specifying the key and data associated to the raw block.
    /// </summary>
    /// <param name="blockDictionaryEntry">Data associated with this block</param>
    internal DataBlock(KeyValuePair<KnownDataBlock, BaseDataBlock> blockDictionaryEntry)
    {
        Key = blockDictionaryEntry.Key;

        var targetBlock = blockDictionaryEntry.Value;
        RawData = new ReadOnlyCollection<byte>(targetBlock.GetRawData().ToList().Take(128).ToList());
        SectionTable = targetBlock.SectionTable;
    }

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets a value that indicates if there are available sections.
    /// </summary>
    /// <value>
    /// <b>true</b> if there are sections; otherwise, it is <b>false</b>.
    /// </value>
    public bool HasSections => SectionTable.Count > 0;

    /// <summary>
    /// Gets a value that represents the key of this <see cref="DataBlock" />.
    /// </summary>
    /// <value>
    /// One of the values in the enumeration <see cref="KnownDataBlock" /> that represents the key of this <see cref="DataBlock" />.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public KnownDataBlock Key { get; }

    /// <summary>
    /// Gets a value that represents the collection <see cref="DataBlockCollection"/> to which this <see cref="DataBlock"/> belongs.
    /// </summary>
    /// <value>
    /// Collection <see cref="DataBlockCollection" /> to which this <see cref="DataBlock" /> belongs.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public DataBlockCollection Parent => _parent;

    /// <summary>
    /// Gets current raw data block data.
    /// </summary>
    /// <returns>
    /// Raw data block data.
    /// </returns>
    public ReadOnlyCollection<byte> RawData { get; }

    /// <summary>
    /// Gets the collection of sections available for this <see cref="DataBlock" />.
    /// </summary>
    /// <value>
    /// Object <see cref="BaseDataSectionCollection" /> that contains the object collection <see cref="DataSection" /> for this <see cref="DataBlock" />.
    /// If there is no <see cref="DataSection" /> object, <b>null</b> is returned.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public BaseDataSectionCollection Sections
    {
        get
        {
            if (!HasSections)
            {
                return _sections;
            }

            if (_sections != null)
            {
                return _sections;
            }

            _sections = Key switch
            {
                KnownDataBlock.CEA => new CeaDataSectionCollection(this),
                KnownDataBlock.DI => new DiDataSectionCollection(this),
                KnownDataBlock.DisplayID => new DisplayIdDataSectionCollection(this),
                KnownDataBlock.EDID => new EdidDataSectionCollection(this),
                KnownDataBlock.LS => new CeaDataSectionCollection(this),
                KnownDataBlock.VTB => new CeaDataSectionCollection(this),
                _ => throw new ArgumentOutOfRangeException()
            };

            return _sections;
        }
    }

    #endregion

    #region internal readonly properties

    /// <summary>
    /// Gets a value that contains the available sections.
    /// </summary>
    /// <value>
    /// Dictionary that contains Section / Value of the section.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    internal Dictionary<Enum, BaseDataSection> SectionTable { get; }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a string representing the current <see cref="DataBlock" /> object.
    /// </summary>
    /// <returns>
    /// <see cref="T:System.String"/> representing the current <see cref="DataBlock" /> object.
    /// </returns>
    /// <remarks>
    /// The method <see cref="DataBlock.ToString ()" /> returns a string that includes the key of the current block.
    /// </remarks>   
    public override string ToString() => $"Key=\"{Key}\"";

    #endregion

    #region internal methods

    /// <summary>
    /// Sets the object <see cref="DataBlockCollection" /> to which this <see cref="DataBlock" /> belongs.
    /// </summary>
    /// <param name="parent">Object <see cref="DataBlockCollection" /> to which this <see cref="DataBlock" /> belongs.</param>
    internal void SetParent(DataBlockCollection parent)
    {
        _parent = parent;
    }

    #endregion
}
