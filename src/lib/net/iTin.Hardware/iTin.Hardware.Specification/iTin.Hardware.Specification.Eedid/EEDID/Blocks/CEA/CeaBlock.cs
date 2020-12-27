
namespace iTin.Hardware.Specification.Eedid.Blocks
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using CEA;
    using CEA.Sections;

    // •——————————————————————————————————————————————•
    // | CEA BLOCK                                    |
    // |   · Extension Tag                            |
    // |   · Revision Number                          |
    // |   · Detailed Timming data begins (DTD)       |
    // |   · DTV Monitor supports / Preferred formats |
    // |   · CEA Data Blocks                          |
    // |     · CEA Short Video Data Block (SVDB)      |
    // |     · CEA Short Audio Data Block (SADB)      |
    // |     · CEA Short Speaker Data Block (SKDB)    |
    // |     · CEA Short Vendor Data Block (SRDB)     |
    // |   · CEA Data Timming Descriptors (DTD)       |
    // |     · Timing Descriptor 1                    |
    // |     ·   ...                                  |
    // |     ·   ...                                  |
    // |     · Timing Descriptor 4                    |
    // |   · Checksum                                 |
    // •——————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataBlock"/> class.<br/>
    /// Representing the block <see cref="KnownDataBlock.CEA"/> of the specification <see cref="EEDID"/>.
    /// </summary> 
    internal class CeaBlock : BaseDataBlock
    {
        #region constructor/s

        #region [public] CeaBlock(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="CeaBlock"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="dataBlock">Raw data of this block.</param>
        /// <remarks>
        /// Create a <see cref="KnownDataBlock.CEA"/> block (block 0) which belongs to the <see cref="EEDID"/> specification.
        /// </remarks>
        public CeaBlock(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) InitDataSectionTable(Dictionary<Enum, ReadOnlyCollection<byte>>): Initialize dictionary with the available data for the sections of this block
        /// <summary>
        /// Initialize dictionary with the available data for the sections of this block.
        /// </summary>
        /// <param name="dataSectionDictionary">Dictionary that contains the available data for the sections of this block</param>
        protected override void InitDataSectionTable(Dictionary<Enum, ReadOnlyCollection<byte>> dataSectionDictionary)
        {
            var ceaDataArray = RawData.ToArray(); 

            var dataSectionArray = new byte[0x01];
            Array.Copy(ceaDataArray, 0x01, dataSectionArray, 0x00, 0x01);
            dataSectionDictionary.Add(CeaSection.Information, new ReadOnlyCollection<byte>(dataSectionArray));

            if (ceaDataArray[0x01] != 0x01)
            {
                dataSectionArray = new byte[0x01];
                Array.Copy(ceaDataArray, 0x03, dataSectionArray, 0x00, 0x01);
                dataSectionDictionary.Add(CeaSection.MonitorSupport, new ReadOnlyCollection<byte>(dataSectionArray));
            }

            var dataBlocks = GetDataBlocks(RawData);
            if (dataBlocks != null)
            {
                dataSectionDictionary.Add(CeaSection.DataBlockCollection, dataBlocks);
            }

            var dataTimmings = GetDetailedTimingData(RawData);
            if (dataTimmings != null)
            {
                dataSectionDictionary.Add(CeaSection.DetailedTiming, dataTimmings);
            }

            dataSectionDictionary.Add(CeaSection.Checksum, RawData);
        }
        #endregion

        #region [protected] {override} (void) InitSectionTable(Dictionary<Enum, BaseDataSection>): Initialize dictionary with the sections available for this block
        /// <summary>
        /// Initialize dictionary with the sections available for this block.
        /// </summary>
        /// <param name="sectionDictionary">Dictionary containing the sections available for this block</param>
        protected override void InitSectionTable(Dictionary<Enum, BaseDataSection> sectionDictionary)
        {
            sectionDictionary.Add(CeaSection.Information, new InformationSection(DataSectionTable[CeaSection.Information]));

            if (DataSectionTable.ContainsKey(CeaSection.MonitorSupport))
            {
                sectionDictionary.Add(CeaSection.MonitorSupport, new MonitorSupportSection(DataSectionTable[CeaSection.MonitorSupport]));
            }

            if (DataSectionTable.ContainsKey(CeaSection.DataBlockCollection))
            {
                sectionDictionary.Add(CeaSection.DataBlockCollection, new DataBlockCollectionSection(DataSectionTable[CeaSection.DataBlockCollection]));
            }

            if (DataSectionTable.ContainsKey(CeaSection.DetailedTiming))
            {
                sectionDictionary.Add(CeaSection.DetailedTiming, new DetailedTimingsSection(DataSectionTable[CeaSection.DetailedTiming]));
            }

            if (DataSectionTable.ContainsKey(CeaSection.Checksum))
            {
                sectionDictionary.Add(CeaSection.Checksum, new ChecksumSection(DataSectionTable[CeaSection.Checksum]));
            }
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (ReadOnlyCollection<byte>) GetDataBlocks(ReadOnlyCollection<byte>): Gets an array that contains the Data Block Collection structure of a raw 'CEA' block
        /// <summary>
        /// Gets an array that contains the Data Block Collection structure of a raw <b>CEA</b> block.
        /// </summary>
        /// <param name="ceaData">Array containing the structures of the CEA block.</param>
        /// <returns>
        /// Array containing the Data Block Collection structure of this unprocessed CEA block.
        /// </returns>
        private static ReadOnlyCollection<byte> GetDataBlocks(ReadOnlyCollection<byte> ceaData)
        {
            byte d = ceaData[0x02];
            if (d == 0x04)
            {
                return null;
            }

            var ceaDataArray = ceaData.ToArray();
            var dataBlocks = new byte[d - 4];
            Array.Copy(ceaDataArray, 0x04, dataBlocks, 0x00, d - 4);

            return new ReadOnlyCollection<byte>(dataBlocks);
        }
        #endregion

        #region [private] {static} (ReadOnlyCollection<byte>) GetDetailedTimingData(int, ReadOnlyCollection<byte>): Gets an array that contains the Detailed Timings Descriptors structure of an unprocessed CEA block
        /// <summary>
        /// Gets an array that contains the <see cref="CeaSection.DetailedTiming"/> structure of an unprocessed <see cref="KnownDataBlock.CEA"/> block.
        /// </summary>
        /// <param name="ceaData">Array containing the structures <see cref="CeaSection.DetailedTiming"/> of the block <see cref="KnownDataBlock.CEA"/>.</param>
        /// <returns>
        /// Array containing the structure <see cref="CeaSection.DetailedTiming"/> of this block <see cref="KnownDataBlock.CEA"/> unprocessed.
        /// </returns>
        private static ReadOnlyCollection<byte> GetDetailedTimingData(ReadOnlyCollection<byte> ceaData)
        {
            byte d = ceaData[0x02];

            if (d == 0)
            {
                return null;
            }

            int begin = d;
            var ceaDataArray = ceaData.ToArray();
            var detailedTimingData = new List<byte>();
            while (true)
            {
                if (ceaDataArray[begin] == 0x00 && (ceaDataArray[begin + 1] == 0x00))
                {
                    break;
                }

                byte[] data = new byte[0x12];
                Array.Copy(ceaDataArray, begin, data, 0x00, 0x12);
                detailedTimingData.AddRange(data);
                begin += 0x12;
            }

            return new ReadOnlyCollection<byte>(detailedTimingData);
        }
        #endregion

        #endregion
    }
}
