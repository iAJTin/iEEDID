
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

using iTin.Core;
using iTin.Core.Hardware.MacOS.Device.Desktop;
using iTin.Core.Hardware.Windows.Device.Desktop.Monitor;

using iTin.Hardware.Specification.Eedid;
using iTin.Hardware.Specification.Eedid.Blocks;
using iTin.Hardware.Specification.Eedid.Blocks.EDID;

namespace iTin.Hardware.Specification
{
    /// <summary>
    /// Implementation of the <b>E-EDID</b> (Extended Display Identification Data) specification.
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

        #region [private] EEDID(IEnumerable<byte>): Initializes a new instance of the E-EDID class by specifying the data matrix
        /// <summary>
        /// Initializes a new instance of the <see cref="EEDID"/> class by specifying the data matrix.
        /// </summary>
        /// <param name="rawData">Data</param>
        /// <remarks>
        /// Returns the <b>E-EDID</b> information available.
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

        #endregion

        #region public static readonly properties

        #region [public] {static} (EEDID[]) Instance: Returns a new instance containing all available EEDID structures for this machine
        /// <summary>
        /// Returns a new instance containing all available <see cref="EEDID"/> structures for this machine.
        /// </summary>
        /// <returns>
        /// A <see cref="EEDID"/> array that contains <b>Extended Display Identification Data</b> information for this machine.
        /// </returns>
        public static EEDID[] Instance => PlatformResolverStrategy();
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (EEDID) Parse(byte[]): Parses 'EEDID' raw data
        /// <summary>
        /// Parses <see cref="EEDID" /> raw data.
        /// </summary>
        /// <param name="data">Raw data to parse</param>
        /// <returns>
        /// A <see cref="EEDID"/> reference that contains <b>Extended Display Identification Data</b> information.
        /// </returns>
        public static EEDID Parse(byte[] data) => new EEDID(data);
        #endregion

        #endregion

        #region public properties

        #region [public] (DataBlockCollection) Blocks: Gets the collection of blocks available for this EEDID
        /// <summary>
        /// Gets the collection of blocks available for this <see cref="EEDID" />.
        /// </summary>
        /// <value>
        /// Object <see cref="DataBlockCollection" /> that contains the object collection <see cref="DataBlock" /> for this <see cref="EEDID" />.
        /// If there is no object <see cref="DataBlock" />, <b>null</b> is returned.
        /// </value>
        public DataBlockCollection Blocks
        {
            get
            {
                if (HasBlocks)
                {
                    if (_blockCollection == null)
                    {
                        _blockCollection = new DataBlockCollection(this, true);
                    }
                }

                return _blockCollection;
            }        
        }
        #endregion

        #region [public] (bool) HasBlocks: Gets a value that indicates if there are available blocks
        /// <summary>
        /// Gets a value that indicates if there are available blocks.
        /// </summary>
        /// <value>
        /// <b>true</b> if there are blocks; otherwise, it is <b>false</b>.
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

        #endregion

        #region internal properties

        #region [internal] (Dictionary<KnownDataBlock, BaseDataBlock>) BlockTable: Gets a value that represents the available blocks
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

        #endregion

        #region public methods

        #region [public] (ReadOnlyCollection<byte>) GetRawData(): Returns the raw data for current EEDID instance
        /// <summary>
        /// Returns the raw data for current <see cref="EEDID"/> instance.
        /// </summary>
        /// <returns>
        /// The raw data for current <see cref="EEDID"/> instance.
        /// </returns>
        public ReadOnlyCollection<byte> GetRawData() => new ReadOnlyCollection<byte>(Blocks.SelectMany(b => b.RawData).ToList());
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (String) ToString: Returns a string that represents the current object
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

        #endregion

        #region private static methods

        #region [private] {static} (IEnumerable<ReadOnlyCollection<byte>>) GetExtensionDataBlocks(ReadOnlyCollection<byte>): Returns a list with the information of the available extension blocks untreated
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

        #region [private] {static} (EEDID[]) PlatformResolverStrategy(): Returns a new instance containing all available EEDID structures for this machine
        /// <summary>
        /// Returns a new instance containing all available <see cref="EEDID"/> structures for this machine.
        /// </summary>
        /// <returns>
        /// A <see cref="EEDID"/> array that contains <b>Extended Display Identification Data</b> information for this machine.
        /// </returns>
        private static EEDID[] PlatformResolverStrategy()
        {
            List<EEDID> result = new List<EEDID>();
            List<byte[]> rawEdidCollection = new List<byte[]>();

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // Nothing to do
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                rawEdidCollection = Monitor.GetEdidDataCollection().ToList();
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                IEnumerable<MonitorDeviceInfo> deviceMonitors = SafeMonitorNativeMethods.EnumerateMonitorDevices();
                foreach (var device in deviceMonitors)
                {
                    rawEdidCollection.Add(device.Edid);
                }
            }

            foreach (var rawEdidItem in rawEdidCollection)
            {
                result.Add(new EEDID((byte[])rawEdidItem.Clone()));
            }

            return (EEDID[])result.ToArray().Clone();
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (void) InitBlockTable(IDictionary<KnownDataBlock, BaseDataBlock>): Initialize dictionary with the available blocks
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

        #endregion
    }
}
