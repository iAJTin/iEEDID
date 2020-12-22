
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    // DisplayID: VESA Display Identification Data (DisplayID)
    // •—————————————————————————————————————————————————————•
    // | Bytes    Section                                    |
    // •—————————————————————————————————————————————————————•
    // |    12                                               |
    // •—————————————————————————————————————————————————————•
    // |    12                                               |
    // •—————————————————————————————————————————————————————•
    // |    12                                               |
    // •—————————————————————————————————————————————————————•
    // |    12                                               |
    // •—————————————————————————————————————————————————————•
    // |    12                                               |
    // •—————————————————————————————————————————————————————•
    // |    12                                               |
    // •—————————————————————————————————————————————————————•
    // |    12                                               |
    // •—————————————————————————————————————————————————————•
    // |    12                                               |
    // •—————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataBlock"/> class.<br/>
    /// Representing the block <see cref="KnownDataBlock.DisplayID"/> of the specification <see cref="EEDID"/>.
    /// </summary> 
    internal class DisplayIDBlock : BaseDataBlock
    {
        #region constructor/s

        #region [public] DisplayIDBlock(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="DisplayIDBlock"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="dataBlock">Raw data of this block.</param>
        /// <remarks>
        /// Create a <see cref="KnownDataBlock.DisplayID"/> block which belongs to the <see cref="EEDID"/> specification.
        /// </remarks>
        public DisplayIDBlock(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
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

            //var informationSectionArray = new byte[0x02];
            //Array.Copy(dataArray, 0x00, informationSectionArray, 0x00, 0x02);
            //dataSectionDictionary.Add(KnownDiSection.Information, new ReadOnlyCollection<byte>(informationSectionArray));

            //var digitalInterfaceSectionArray = new byte[0x0c];
            //Array.Copy(dataArray, 0x02, digitalInterfaceSectionArray, 0x00, 0x0c);
            //dataSectionDictionary.Add(KnownDiSection.DigitalInterface, new ReadOnlyCollection<byte>(digitalInterfaceSectionArray));

            //var displayDeviceSectionArray = new byte[0x06];
            //Array.Copy(dataArray, 0x0e, displayDeviceSectionArray, 0x00, 0x06);
            //dataSectionDictionary.Add(KnownDiSection.DisplayDevice, new ReadOnlyCollection<byte>(displayDeviceSectionArray));

            //var displayCapabilitiesAndFeatureSupportSetSectionArray = new byte[0x23];
            //Array.Copy(dataArray, 0x14, displayCapabilitiesAndFeatureSupportSetSectionArray, 0x00, 0x23);
            //dataSectionDictionary.Add(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, new ReadOnlyCollection<byte>(displayCapabilitiesAndFeatureSupportSetSectionArray));
            
            //var unusedBytesSectionArray = new byte[0x11];
            //Array.Copy(dataArray, 0x37, unusedBytesSectionArray, 0x00, 0x11);
            //dataSectionDictionary.Add(KnownDiSection.UnusedBytes, new ReadOnlyCollection<byte>(unusedBytesSectionArray));

            //var audioSupportSectionArray = new byte[0x09];
            //Array.Copy(dataArray, 0x48, audioSupportSectionArray, 0x00, 0x09);
            //dataSectionDictionary.Add(KnownDiSection.AudioSupport, new ReadOnlyCollection<byte>(audioSupportSectionArray));

            //var displayTransferCharacteristicSectionArray = new byte[0x2e];
            //Array.Copy(dataArray, 0x51, displayTransferCharacteristicSectionArray, 0x00, 0x2e);
            //dataSectionDictionary.Add(KnownDiSection.DisplayTransferCharacteristic, new ReadOnlyCollection<byte>(displayTransferCharacteristicSectionArray));

            //dataSectionDictionary.Add(KnownDiSection.Miscellaneous, RawData);
        }
        #endregion

        #region [protected] {override} (void) InitSectionTable(Dictionary<Enum, BaseDataSection>): Initialize dictionary with the available data for the sections of this block
        /// <summary>
        /// Initialize dictionary with the available data for the sections of this block.
        /// </summary>
        /// <param name="sectionDictionary">Dictionary that contains the available data for the sections of this block</param>
        protected override void InitSectionTable(Dictionary<Enum, BaseDataSection> sectionDictionary)
        {
            //sectionDictionary.Add(KnownDiSection.Information, new InformationDiSection(DataSectionTable[KnownDiSection.Information]));
            //sectionDictionary.Add(KnownDiSection.DigitalInterface, new DigitalInterfaceDiSection(DataSectionTable[KnownDiSection.DigitalInterface]));
            //sectionDictionary.Add(KnownDiSection.DisplayDevice, new DisplayDeviceDiSection(DataSectionTable[KnownDiSection.DisplayDevice]));
            //sectionDictionary.Add(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, new DisplayCapabilitiesAndFeatureSupportSetDiSection(DataSectionTable[KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet]));
            //sectionDictionary.Add(KnownDiSection.UnusedBytes, new UnusedBytesDiSection(DataSectionTable[KnownDiSection.UnusedBytes]));
            //sectionDictionary.Add(KnownDiSection.AudioSupport, new AudioSupportDiSection(DataSectionTable[KnownDiSection.AudioSupport]));
            //sectionDictionary.Add(KnownDiSection.DisplayTransferCharacteristic, new DisplayTransferCharacteristicDiSection(DataSectionTable[KnownDiSection.DisplayTransferCharacteristic]));
            //sectionDictionary.Add(KnownDiSection.Miscellaneous, new MiscellaneousDiSection(DataSectionTable[KnownDiSection.Miscellaneous]));
        }
        #endregion

        #endregion
    }
}
