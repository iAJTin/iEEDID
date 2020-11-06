
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using iTin.Core;

    // •——————————————————————————————————————————•
    // | BLOCK 0 (EDID)                           |
    // |   · Header                               |
    // |   · Vendor & Product Information         |
    // |   · EDID Version & Revision              |
    // |   · Basic Display Information & Features |
    // |     · Video Input Definition             |
    // |     · Sizes                              |
    // |     · Display Transfer Characteristic    |
    // |     · Feature supports (DPMS)            |
    // |   · Color Characteristics                |
    // |   · Established Timings                  |
    // |   · Standard Timing Identification       |
    // |     · Timing 1                           |
    // |     ·   ...                              |
    // |     ·   ...                              |
    // |     · Timing 8                           |
    // |   · 18 Byte Data Blocks                  |
    // |     Detailed Timing Descriptors          |
    // |       · Monitor Name                     |
    // |       · ASCII String                     |
    // |       · Monitor Range Limits             |
    // |       · Timing Descriptor                |
    // |   · Extension Block Count N              |
    // |   · Checksum                             |
    // •——————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataBlock"/> class.<br/>
    /// Representing the block <see cref="KnownDataBlock.EDID"/> of the specification <see cref="EEDID"/>.
    /// </summary> 
    internal sealed class EdidBlock : BaseDataBlock
    {
        #region constructor/s

        #region [public] EdidBlock(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="EdidBlock"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="dataBlock">Raw data of this block.</param>
        /// <remarks>
        /// Create a <see cref="KnownDataBlock.EDID"/> block (block 0) which belongs to the <see cref="EEDID"/> specification.
        /// </remarks>
        public EdidBlock(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
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
            dataSectionDictionary.Add(KnownEdidSection.Header, RawData.Extract((byte)0x00, (byte)0x08).ToList().AsReadOnly());
            dataSectionDictionary.Add(KnownEdidSection.Vendor, RawData.Extract((byte)0x08, (byte)0x0a).ToList().AsReadOnly());
            dataSectionDictionary.Add(KnownEdidSection.Version, RawData.Extract((byte)0x12, (byte)0x02).ToList().AsReadOnly());
            dataSectionDictionary.Add(KnownEdidSection.BasicDisplay, RawData.Extract((byte)0x14, (byte)0x05).ToList().AsReadOnly());
            dataSectionDictionary.Add(KnownEdidSection.ColorCharacteristics, RawData.Extract((byte)0x19, (byte)0x0a).ToList().AsReadOnly());
            dataSectionDictionary.Add(KnownEdidSection.EstablishedTimings, RawData.Extract((byte)0x23, (byte)0x03).ToList().AsReadOnly());
            dataSectionDictionary.Add(KnownEdidSection.StandardTimings, RawData.Extract((byte)0x26, (byte)0x10).ToList().AsReadOnly());
            dataSectionDictionary.Add(KnownEdidSection.DataBlocks, RawData.Extract((byte)0x36, (byte)0x48).ToList().AsReadOnly());
            dataSectionDictionary.Add(KnownEdidSection.ExtensionBlocks, RawData.Extract((byte)0x7e, (byte)0x01).ToList().AsReadOnly());
            dataSectionDictionary.Add(KnownEdidSection.CheckSum, RawData);
        }
        #endregion

        #region [protected] {override} (void) InitSectionTable(Dictionary<Enum, BaseEEDIDSection>): Initialize dictionary with the sections available for this block
        /// <summary>
        /// Initialize dictionary with the sections available for this block.
        /// </summary>
        /// <param name="sectionDictionary">Dictionary containing the sections available for this block</param>
        protected override void InitSectionTable(Dictionary<Enum, BaseDataSection> sectionDictionary)
        {
            if (DataSectionTable.ContainsKey(KnownEdidSection.Header))
            {
                sectionDictionary.Add(KnownEdidSection.Header, new HeaderEdidSection(DataSectionTable[KnownEdidSection.Header]));
            }

            if (DataSectionTable.ContainsKey(KnownEdidSection.Vendor))
            {
                sectionDictionary.Add(KnownEdidSection.Vendor, new VendorEdidSection(DataSectionTable[KnownEdidSection.Vendor]));
            }

            if (DataSectionTable.ContainsKey(KnownEdidSection.Version))
            {
                sectionDictionary.Add(KnownEdidSection.Version, new VersionEdidSection(DataSectionTable[KnownEdidSection.Version]));
            }

            if (DataSectionTable.ContainsKey(KnownEdidSection.BasicDisplay))
            {
                sectionDictionary.Add(KnownEdidSection.BasicDisplay, new BasicDisplayEdidSection(DataSectionTable[KnownEdidSection.BasicDisplay]));
            }

            if (DataSectionTable.ContainsKey(KnownEdidSection.ColorCharacteristics))
            {
                sectionDictionary.Add(KnownEdidSection.ColorCharacteristics, new ColorCharacteristicsEdidSection(DataSectionTable[KnownEdidSection.ColorCharacteristics]));
            }

            if (DataSectionTable.ContainsKey(KnownEdidSection.EstablishedTimings))
            {
                sectionDictionary.Add(KnownEdidSection.EstablishedTimings, new EstablishedTimingsEdidSection(DataSectionTable[KnownEdidSection.EstablishedTimings]));
            }

            if (DataSectionTable.ContainsKey(KnownEdidSection.StandardTimings))
            {
                sectionDictionary.Add(KnownEdidSection.StandardTimings, new StandardTimingsEdidSection(DataSectionTable[KnownEdidSection.StandardTimings]));
            }

            if (DataSectionTable.ContainsKey(KnownEdidSection.DataBlocks))
            {
                sectionDictionary.Add(KnownEdidSection.DataBlocks, new DataBlocksEdidSection(DataSectionTable[KnownEdidSection.DataBlocks]));
            }

            if (DataSectionTable.ContainsKey(KnownEdidSection.ExtensionBlocks))
            {
                sectionDictionary.Add(KnownEdidSection.ExtensionBlocks, new ExtensionBlocksEdidSection(DataSectionTable[KnownEdidSection.ExtensionBlocks]));
            }

            if (DataSectionTable.ContainsKey(KnownEdidSection.CheckSum))
            {
                sectionDictionary.Add(KnownEdidSection.CheckSum, new CheckSumEdidSection(DataSectionTable[KnownEdidSection.CheckSum]));
            }
        }
        #endregion

        #endregion
    }
}
