
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;

    using Helpers.Enumerations;

    /// <summary>
    /// Estructura <see cref="VideoCapabilityDataBlock"/> que contiene la lógica para decodificar los datos de un bloque del tipo <see cref="KnownExtendedTag.VideoCapability"/>.
    /// </summary> 
    struct VideoCapabilityDataBlock
    {
        #region constructor/s

        #region [public] VideoCapabilityDataBlock(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la estructura.
        /// <summary>
        /// Inicializa una nueva instancia de la estructura <see cref="VideoCapabilityDataBlock"/> especificando los datos de este bloque de video.
        /// </summary>
        /// <param name="videoCapabilityDataBlock">Datos de este bloque de video.</param>
        public VideoCapabilityDataBlock(ReadOnlyCollection<byte> videoCapabilityDataBlock)
        {
            CEOverscan = videoCapabilityDataBlock[0x02] & 0x03;
            ITOverscan = videoCapabilityDataBlock[0x02] & 0x0c >> 2;
            PTOverscan = videoCapabilityDataBlock[0x02] & 0x30 >> 4;
            QuantizationRangeRGB = videoCapabilityDataBlock[0x02].CheckBit(Bits.Bit06);
            QuantizationRangeYCC = videoCapabilityDataBlock[0x02].CheckBit(Bits.Bit07);
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (int) CEOverscan: 
        /// <summary>
        /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-5.
        /// </summary>
        /// <value>
        ///   <para>Es <b>true</b> si cumple con el estandard IEC 61966-2-5; en caso contrario, es <b>false</b>.</para>
        /// </value>
        public int CEOverscan { get; }
        #endregion

        #region [public] (int) ITOverscan: 
        /// <summary>
        /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-5 Annex A.
        /// </summary>
        /// <value>
        ///   <para>Es <b>true</b> si cumple con el estandard IEC 61966-2-5 Annex A; en caso contrario, es <b>false</b>.</para>
        /// </value>
        public int ITOverscan { get; }
        #endregion

        #region [public] (int) PTOverscan: 
        /// <summary>
        /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-1/Amendment 1.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Es <b>true</b> si cumple con el estandard IEC 61966-2-1/Amendment 1; en caso contrario, es <b>false</b>.</para>
        /// </value>
        public int PTOverscan { get; }
        #endregion

        #region [public] (bool) QuantizationRangeRGB: 
        /// <summary>
        /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-4 (High Definition Colorimetry).
        /// </summary>
        /// <value>
        ///   <para>Es <b>true</b> si cumple con el estandard IEC 61966-2-4 (High Definition Colorimetry), es <b>false</b>.</para>
        /// </value>
        public bool QuantizationRangeRGB { get; }
        #endregion

        #region [public] (bool) QuantizationRangeYCC: 
        /// <summary>
        /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-4 (Standard Definition Colorimetry).
        /// </summary>
        /// <value>
        ///   <para>Es <b>true</b> si cumple con el estandard IEC 61966-2-4 (Standard Definition Colorimetry); en caso contrario, es <b>false</b>.</para>
        /// </value>
        public bool QuantizationRangeYCC { get; }
        #endregion

        #endregion
    }
}
