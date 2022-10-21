
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Core;

using iTin.Hardware.Specification.Eedid.Blocks.EDID;
using iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections;

namespace iTin.Hardware.Specification.Eedid.Blocks
{
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
            dataSectionDictionary.Add(EdidSection.Header, RawData.Extract((byte)0x00, (byte)0x08).ToList().AsReadOnly());
            dataSectionDictionary.Add(EdidSection.Vendor, RawData.Extract((byte)0x08, (byte)0x0a).ToList().AsReadOnly());
            dataSectionDictionary.Add(EdidSection.Version, RawData.Extract((byte)0x12, (byte)0x02).ToList().AsReadOnly());
            dataSectionDictionary.Add(EdidSection.BasicDisplay, RawData.Extract((byte)0x14, (byte)0x05).ToList().AsReadOnly());
            dataSectionDictionary.Add(EdidSection.ColorCharacteristics, RawData.Extract((byte)0x19, (byte)0x0a).ToList().AsReadOnly());
            dataSectionDictionary.Add(EdidSection.EstablishedTimings, RawData.Extract((byte)0x23, (byte)0x03).ToList().AsReadOnly());
            dataSectionDictionary.Add(EdidSection.StandardTimings, RawData.Extract((byte)0x26, (byte)0x10).ToList().AsReadOnly());
            dataSectionDictionary.Add(EdidSection.DataBlocks, RawData.Extract((byte)0x36, (byte)0x48).ToList().AsReadOnly());
            dataSectionDictionary.Add(EdidSection.ExtensionBlocks, RawData.Extract((byte)0x7e, (byte)0x01).ToList().AsReadOnly());
            dataSectionDictionary.Add(EdidSection.Checksum, RawData);
        }
        #endregion

        #region [protected] {override} (void) InitSectionTable(Dictionary<Enum, BaseEEDIDSection>): Initialize dictionary with the sections available for this block
        /// <summary>
        /// Initialize dictionary with the sections available for this block.
        /// </summary>
        /// <param name="sectionDictionary">Dictionary containing the sections available for this block</param>
        protected override void InitSectionTable(Dictionary<Enum, BaseDataSection> sectionDictionary)
        {
            if (DataSectionTable.ContainsKey(EdidSection.Header))
            {
                sectionDictionary.Add(EdidSection.Header, new HeaderSection(DataSectionTable[EdidSection.Header]));
            }

            if (DataSectionTable.ContainsKey(EdidSection.Vendor))
            {
                sectionDictionary.Add(EdidSection.Vendor, new VendorSection(DataSectionTable[EdidSection.Vendor]));
            }

            if (DataSectionTable.ContainsKey(EdidSection.Version))
            {
                sectionDictionary.Add(EdidSection.Version, new VersionSection(DataSectionTable[EdidSection.Version]));
            }

            if (DataSectionTable.ContainsKey(EdidSection.BasicDisplay))
            {
                sectionDictionary.Add(EdidSection.BasicDisplay, new BasicDisplaySection(DataSectionTable[EdidSection.BasicDisplay]));
            }

            if (DataSectionTable.ContainsKey(EdidSection.ColorCharacteristics))
            {
                sectionDictionary.Add(EdidSection.ColorCharacteristics, new ColorCharacteristicsSection(DataSectionTable[EdidSection.ColorCharacteristics]));
            }

            if (DataSectionTable.ContainsKey(EdidSection.EstablishedTimings))
            {
                sectionDictionary.Add(EdidSection.EstablishedTimings, new EstablishedTimingsSection(DataSectionTable[EdidSection.EstablishedTimings]));
            }

            if (DataSectionTable.ContainsKey(EdidSection.StandardTimings))
            {
                sectionDictionary.Add(EdidSection.StandardTimings, new StandardTimingsSection(DataSectionTable[EdidSection.StandardTimings]));
            }

            if (DataSectionTable.ContainsKey(EdidSection.DataBlocks))
            {
                sectionDictionary.Add(EdidSection.DataBlocks, new DataBlocksSection(DataSectionTable[EdidSection.DataBlocks]));
            }

            if (DataSectionTable.ContainsKey(EdidSection.ExtensionBlocks))
            {
                sectionDictionary.Add(EdidSection.ExtensionBlocks, new ExtensionBlocksSection(DataSectionTable[EdidSection.ExtensionBlocks]));
            }

            if (DataSectionTable.ContainsKey(EdidSection.Checksum))
            {
                sectionDictionary.Add(EdidSection.Checksum, new ChecksumSection(DataSectionTable[EdidSection.Checksum]));
            }
        }
        #endregion

        #endregion
    }
}
