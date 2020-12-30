
namespace iTin.Hardware.Specification.Eedid.Blocks
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using iTin.Core;

    using DisplayId;
    using DisplayId.Sections;

    // DisplayID: VESA Display Identification Data 
    // •————————————————————————————————————————————•
    // | Bytes    Section                           |
    // •————————————————————————————————————————————•
    // |     4    General Information               |
    // •————————————————————————————————————————————•
    // |     N    Extension Blocks                  |
    // •————————————————————————————————————————————•
    // |     1    Miscellaneous Items               |
    // •————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataBlock"/> class.<br/>
    /// Representing the block <see cref="KnownDataBlock.DisplayID"/> of the specification <see cref="EEDID"/>.
    /// </summary> 
    internal class DisplayIdBlock : BaseDataBlock
    {
        #region constructor/s

        #region [public] DisplayIdBlock(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="DisplayIdBlock"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="dataBlock">Raw data of this block.</param>
        /// <remarks>
        /// Create a <see cref="KnownDataBlock.DisplayID"/> block which belongs to the <see cref="EEDID"/> specification.
        /// </remarks>
        public DisplayIdBlock(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
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
            var rawBlockArray = RawData.Extract(0x01).ToArray();

            PopulatesVersionBlock(rawBlockArray);

            var displayStructureArray = new byte[0x04];
            Array.Copy(rawBlockArray, 0x00, displayStructureArray, 0x00, 0x04);
            dataSectionDictionary.Add(DisplayIdSection.General, new ReadOnlyCollection<byte>(displayStructureArray));

            var sectionBytes = rawBlockArray[01];
            dataSectionDictionary.Add(DisplayIdSection.DataBlocks, new ReadOnlyCollection<byte>(new List<byte>()));
            if (sectionBytes != 0x00)
            {
                var dataBlocksStructureArray = new byte[sectionBytes];
                Array.Copy(rawBlockArray, 0x04, dataBlocksStructureArray, 0x00, sectionBytes);
                dataSectionDictionary[DisplayIdSection.DataBlocks] = new ReadOnlyCollection<byte>(dataBlocksStructureArray);
            }
            
            dataSectionDictionary.Add(DisplayIdSection.Miscellaneous, RawData);
        }
        #endregion

        #region [protected] {override} (void) InitSectionTable(Dictionary<Enum, BaseDataSection>): Initialize dictionary with the available data for the sections of this block
        /// <summary>
        /// Initialize dictionary with the available data for the sections of this block.
        /// </summary>
        /// <param name="sectionDictionary">Dictionary that contains the available data for the sections of this block</param>
        protected override void InitSectionTable(Dictionary<Enum, BaseDataSection> sectionDictionary)
        {
            sectionDictionary.Add(DisplayIdSection.General, new GeneralSection(DataSectionTable[DisplayIdSection.General]));
            sectionDictionary.Add(DisplayIdSection.DataBlocks, new DataBlocksSection(DataSectionTable[DisplayIdSection.DataBlocks], BlockVersion));
            sectionDictionary.Add(DisplayIdSection.Miscellaneous, new MiscellaneousSection(DataSectionTable[DisplayIdSection.Miscellaneous]));
        }
        #endregion

        #endregion

        #region private methods

        private void PopulatesVersionBlock(byte[] data)
        {
            var rawVersion = data[0x00].ToNibbles();
            var version = rawVersion[0x00];
            var revision = rawVersion[0x01];
            BlockVersion = int.Parse($"{version}{revision}");
        }

        #endregion
    }
}
