
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> que representa la sección Short Audio Descriptor del bloque Data Block Collection.
    /// </summary> 
    sealed class ShortExtendedTagDescriptorCeaSection : BaseDataSection
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

        #region [protected] {override} (void) Parse(Hashtable): Obtiene la colección de items de esta sección.
        /// <inheritdoc />
        /// <summary>
        /// Obtiene la colección de items de esta sección.
        /// </summary>
        /// <param name="items">Colección de items de esta sección.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        protected override void Parse(Hashtable items)
        {
            #region Comprobar parámetro/s.
            base.Parse(items);
            #endregion

            #region Diccionario de propiedades (PropertyKey / Value).
            var extendedTag = (KnownExtendedTag)RawData[0x01];

            switch (extendedTag)
            {
                case KnownExtendedTag.Colorimetry:
                    var colorimetryDataBlock = new ColorimetryDataBlock(RawData);

                    items.Add("Adobe RGB", colorimetryDataBlock.AdobeRGB ? "Supported" : "Not Supported");
                    items.Add("Adobe YCC601", colorimetryDataBlock.AdobeYCC601 ? "Supported" : "Not Supported");
                    items.Add("sYCC601", colorimetryDataBlock.SYCC601 ? "Supported" : "Not Supported");
                    items.Add("xvYCC709", colorimetryDataBlock.XVYCC709 ? "Supported" : "Not Supported");
                    items.Add("xvYCC601", colorimetryDataBlock.XVYCC601 ? "Supported" : "Not Supported");
                    break;

                case KnownExtendedTag.MiscellaneousAudioFields:
                    break;

                case KnownExtendedTag.VendorSpecificAudio:
                    break;

                case KnownExtendedTag.VendorSpecificVideo:
                    break;

                case KnownExtendedTag.VideoCapability:
                    var videoCapabilityDataBlock = new VideoCapabilityDataBlock(RawData);

                    items.Add("CE Overscan/Underscan", GetCEOverUnderscan(videoCapabilityDataBlock.CEOverscan));
                    items.Add("IT Overscan/Underscan", GetITOverUnderscan(videoCapabilityDataBlock.ITOverscan));
                    items.Add("PT Overscan/Underscan", GetPTOverUnderscan(videoCapabilityDataBlock.PTOverscan));
                    items.Add("Quantization Range RGB", videoCapabilityDataBlock.QuantizationRangeRGB ? "Selectable" : "No Data");
                    items.Add("Quantization Range YCC", videoCapabilityDataBlock.QuantizationRangeYCC ? "Selectable" : "No Data");
                    break;
            }
            #endregion
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
