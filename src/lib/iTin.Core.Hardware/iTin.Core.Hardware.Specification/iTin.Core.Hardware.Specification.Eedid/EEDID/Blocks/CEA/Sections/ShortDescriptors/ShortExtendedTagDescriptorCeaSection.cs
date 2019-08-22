
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> que representa la sección Short Audio Descriptor del bloque Data Block Collection.
    /// </summary> 
    internal sealed class ShortExtendedTagDescriptorCeaSection : BaseDataSection
    {
        #region constructor/s

        #region [public] ShortExtendedTagDescriptorCeaSection(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase.
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.ShortExtendedTagDescriptorCeaSection" />.
        /// </summary>
        /// <param name="sectionData">Datos de esta sección.</param>
        public ShortExtendedTagDescriptorCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
            //KnownExtendedTag extendedTag = (KnownExtendedTag)RawData[0x01];
            //switch (extendedTag)
            //{
            //    case KnownExtendedTag.Colorimetry:
            //        ColorimetryDataBlock colorimetryDataBlock = new ColorimetryDataBlock(RawData);
            //        properties.Add("Adobe RGB", colorimetryDataBlock.AdobeRGB ? "Supported" : "Not Supported");
            //        properties.Add("Adobe YCC601", colorimetryDataBlock.AdobeYCC601 ? "Supported" : "Not Supported");
            //        properties.Add("sYCC601", colorimetryDataBlock.SYCC601 ? "Supported" : "Not Supported");
            //        properties.Add("xvYCC709", colorimetryDataBlock.XVYCC709 ? "Supported" : "Not Supported");
            //        properties.Add("xvYCC601", colorimetryDataBlock.XVYCC601 ? "Supported" : "Not Supported");
            //        break;

            //    case KnownExtendedTag.MiscellaneousAudioFields:
            //        break;

            //    case KnownExtendedTag.VendorSpecificAudio:
            //        break;

            //    case KnownExtendedTag.VendorSpecificVideo:
            //        break;

            //    case KnownExtendedTag.VideoCapability:
            //        VideoCapabilityDataBlock videoCapabilityDataBlock = new VideoCapabilityDataBlock(RawData);
            //        properties.Add("CE Overscan/Underscan", GetCEOverUnderscan(videoCapabilityDataBlock.CEOverscan));
            //        properties.Add("IT Overscan/Underscan", GetITOverUnderscan(videoCapabilityDataBlock.ITOverscan));
            //        properties.Add("PT Overscan/Underscan", GetPTOverUnderscan(videoCapabilityDataBlock.PTOverscan));
            //        properties.Add("Quantization Range RGB", videoCapabilityDataBlock.QuantizationRangeRGB ? "Selectable" : "No Data");
            //        properties.Add("Quantization Range YCC", videoCapabilityDataBlock.QuantizationRangeYCC ? "Selectable" : "No Data");
            //        break;
            //}
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
