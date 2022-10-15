
using System.Collections.ObjectModel;

using iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors.DataBlocks;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors
{
    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the Short Audio Descriptor section of the Data Block Collection block.
    /// </summary> 
    internal sealed class ShortExtendedTagDescriptorSection : BaseDataSection
    {
        #region constructor/s

        #region [public] ShortExtendedTagDescriptorSection(ReadOnlyCollection<byte>): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the <see cref="ShortExtendedTagDescriptorSection"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Raw data of this section.</param>
        public ShortExtendedTagDescriptorSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
            ExtendedTag extendedTag = (ExtendedTag)RawData[0x01];
            switch (extendedTag)
            {
                case ExtendedTag.Colorimetry:
                    ColorimetryDataBlock colorimetryDataBlock = new ColorimetryDataBlock(RawData);
                    properties.Add(EedidProperty.Cea.DataBlock.Extended.Colorimetry.AdobeRGB, colorimetryDataBlock.AdobeRGB);
                    properties.Add(EedidProperty.Cea.DataBlock.Extended.Colorimetry.AdobeYCC601, colorimetryDataBlock.AdobeYCC601);
                    properties.Add(EedidProperty.Cea.DataBlock.Extended.Colorimetry.sYCC601, colorimetryDataBlock.SYCC601);
                    properties.Add(EedidProperty.Cea.DataBlock.Extended.Colorimetry.xvYCC709, colorimetryDataBlock.XVYCC709);
                    properties.Add(EedidProperty.Cea.DataBlock.Extended.Colorimetry.xvYCC601, colorimetryDataBlock.XVYCC601);
                    break;

                case ExtendedTag.MiscellaneousAudioFields:
                    break;

                case ExtendedTag.VendorSpecificAudio:
                    break;

                case ExtendedTag.VendorSpecificVideo:
                    break;

                case ExtendedTag.VideoCapability:
                    VideoCapabilityDataBlock videoCapabilityDataBlock = new VideoCapabilityDataBlock(RawData);
                    properties.Add(EedidProperty.Cea.DataBlock.Extended.VideoCapability.CEOverscan, GetCEOverUnderscan(videoCapabilityDataBlock.CEOverscan));
                    properties.Add(EedidProperty.Cea.DataBlock.Extended.VideoCapability.ITOverscan, GetITOverUnderscan(videoCapabilityDataBlock.ITOverscan));
                    properties.Add(EedidProperty.Cea.DataBlock.Extended.VideoCapability.PTOverscan, GetPTOverUnderscan(videoCapabilityDataBlock.PTOverscan));
                    properties.Add(EedidProperty.Cea.DataBlock.Extended.VideoCapability.QuantizationRangeRGB, videoCapabilityDataBlock.QuantizationRangeRGB ? "Selectable" : "No Data");
                    properties.Add(EedidProperty.Cea.DataBlock.Extended.VideoCapability.QuantizationRangeYCC, videoCapabilityDataBlock.QuantizationRangeYCC ? "Selectable" : "No Data");
                    break;
            }
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (string) GetCEOverUnderscan(int):
        private static string GetCEOverUnderscan(int value)
        {
            string ret = "CE Video formats not supported";

            switch (value)
            {
                case 0x01:
                    ret = "Always Overscanned"; 
                    break;

                case 0x02:
                    ret = "Always Underscanned"; 
                    break;

                case 0x03:
                    ret = "Supports both over and underscan"; 
                    break;
            }

            return ret;
        }
        #endregion

        #region [private] {static} (string) GetITOverUnderscan(int):
        private static string GetITOverUnderscan(int value)
        {
            string ret = "IT Video formats not supported";

            switch (value)
            {
                case 0x01:
                    ret = "Always Overscanned";
                    break;

                case 0x02:
                    ret = "Always Underscanned";
                    break;

                case 0x03:
                    ret = "Supports both over and underscan";
                    break;
            }

            return ret;
        }
        #endregion

        #region [private] {static} (string) GetPTOverUnderscan(int):
        private static string GetPTOverUnderscan(int value)
        {
            string ret = "No data";

            switch (value)
            {
                case 0x01:
                    ret = "Always Overscanned";
                    break;

                case 0x02:
                    ret = "Always Underscanned";
                    break;

                case 0x03:
                    ret = "Supports both over and underscan";
                    break;
            }

            return ret;
        }
        #endregion

        #endregion
    }
}
