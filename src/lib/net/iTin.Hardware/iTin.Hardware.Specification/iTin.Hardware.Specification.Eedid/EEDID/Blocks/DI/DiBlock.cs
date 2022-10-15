
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Hardware.Specification.Eedid.Blocks.DI;
using iTin.Hardware.Specification.Eedid.Blocks.DI.Sections;

namespace iTin.Hardware.Specification.Eedid.Blocks
{
    // DI: VESA Display Information Extension Block Standard
    // •—————————————————————————————————————————————————————•
    // | Bytes    Section                                    |
    // •—————————————————————————————————————————————————————•
    // |     2    General Information                        |
    // •—————————————————————————————————————————————————————•
    // |    12    Digital Interface                          |
    // •—————————————————————————————————————————————————————•
    // |     6    Display Device                             |
    // •—————————————————————————————————————————————————————•
    // |    35    Display Capabilities & Feature Support Set |
    // •—————————————————————————————————————————————————————•
    // |    17    Unused Bytes (Reserved)                    |
    // •—————————————————————————————————————————————————————•
    // |     9    Audio Support (Reserved)                   |
    // •—————————————————————————————————————————————————————•
    // |    46    Display Transfer Characteristic – Gamma    |
    // •—————————————————————————————————————————————————————•
    // |     1    Miscellaneous Items                        |
    // •—————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataBlock"/> class.<br/>
    /// Representing the block <see cref="KnownDataBlock.DI"/> of the specification <see cref="EEDID"/>.
    /// </summary> 
    internal class DiBlock : BaseDataBlock
    {
        #region constructor/s

        #region [public] DiBlock(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="DiBlock"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="dataBlock">Raw data of this block.</param>
        /// <remarks>
        /// Create a <see cref="KnownDataBlock.DI"/> block which belongs to the <see cref="EEDID"/> specification.
        /// </remarks>
        public DiBlock(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
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
            var dataArray = RawData.ToArray();

            var informationSectionArray = new byte[0x02];
            Array.Copy(dataArray, 0x00, informationSectionArray, 0x00, 0x02);
            dataSectionDictionary.Add(DiSection.Information, new ReadOnlyCollection<byte>(informationSectionArray));

            var digitalInterfaceSectionArray = new byte[0x0c];
            Array.Copy(dataArray, 0x02, digitalInterfaceSectionArray, 0x00, 0x0c);
            dataSectionDictionary.Add(DiSection.DigitalInterface, new ReadOnlyCollection<byte>(digitalInterfaceSectionArray));

            var displayDeviceSectionArray = new byte[0x06];
            Array.Copy(dataArray, 0x0e, displayDeviceSectionArray, 0x00, 0x06);
            dataSectionDictionary.Add(DiSection.DisplayDevice, new ReadOnlyCollection<byte>(displayDeviceSectionArray));

            var displayCapabilitiesAndFeatureSupportSetSectionArray = new byte[0x23];
            Array.Copy(dataArray, 0x14, displayCapabilitiesAndFeatureSupportSetSectionArray, 0x00, 0x23);
            dataSectionDictionary.Add(DiSection.DisplayCapabilitiesAndFeatureSupportSet, new ReadOnlyCollection<byte>(displayCapabilitiesAndFeatureSupportSetSectionArray));
            
            var unusedBytesSectionArray = new byte[0x11];
            Array.Copy(dataArray, 0x37, unusedBytesSectionArray, 0x00, 0x11);
            dataSectionDictionary.Add(DiSection.UnusedBytes, new ReadOnlyCollection<byte>(unusedBytesSectionArray));

            var audioSupportSectionArray = new byte[0x09];
            Array.Copy(dataArray, 0x48, audioSupportSectionArray, 0x00, 0x09);
            dataSectionDictionary.Add(DiSection.AudioSupport, new ReadOnlyCollection<byte>(audioSupportSectionArray));

            var displayTransferCharacteristicSectionArray = new byte[0x2e];
            Array.Copy(dataArray, 0x51, displayTransferCharacteristicSectionArray, 0x00, 0x2e);
            dataSectionDictionary.Add(DiSection.DisplayTransferCharacteristic, new ReadOnlyCollection<byte>(displayTransferCharacteristicSectionArray));

            dataSectionDictionary.Add(DiSection.Miscellaneous, RawData);
        }
        #endregion

        #region [protected] {override} (void) InitSectionTable(Dictionary<Enum, BaseDataSection>): Initialize dictionary with the available data for the sections of this block
        /// <summary>
        /// Initialize dictionary with the available data for the sections of this block.
        /// </summary>
        /// <param name="sectionDictionary">Dictionary that contains the available data for the sections of this block</param>
        protected override void InitSectionTable(Dictionary<Enum, BaseDataSection> sectionDictionary)
        {
            sectionDictionary.Add(DiSection.Information, new InformationSection(DataSectionTable[DiSection.Information]));
            sectionDictionary.Add(DiSection.DigitalInterface, new DigitalInterfaceSection(DataSectionTable[DiSection.DigitalInterface]));
            sectionDictionary.Add(DiSection.DisplayDevice, new DisplayDeviceSection(DataSectionTable[DiSection.DisplayDevice]));
            sectionDictionary.Add(DiSection.DisplayCapabilitiesAndFeatureSupportSet, new DisplayCapabilitiesAndFeatureSupportSetSection(DataSectionTable[DiSection.DisplayCapabilitiesAndFeatureSupportSet]));
            sectionDictionary.Add(DiSection.UnusedBytes, new UnusedBytesSection(DataSectionTable[DiSection.UnusedBytes]));
            sectionDictionary.Add(DiSection.AudioSupport, new AudioSupportSection(DataSectionTable[DiSection.AudioSupport]));
            sectionDictionary.Add(DiSection.DisplayTransferCharacteristic, new DisplayTransferCharacteristicSection(DataSectionTable[DiSection.DisplayTransferCharacteristic]));
            sectionDictionary.Add(DiSection.Miscellaneous, new MiscellaneousSection(DataSectionTable[DiSection.Miscellaneous]));
        }
        #endregion

        #endregion
    }
}
