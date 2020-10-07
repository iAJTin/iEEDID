
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    /// <summary>
    /// Structure <see cref="ColorimetryDataBlock"/> that contains the logic to decode the data of a block of type <see cref="KnownExtendedTag.Colorimetry"/>.
    /// </summary> 
    internal struct ColorimetryDataBlock
    {
        #region private readonly members
        private readonly bool _md0;
        private readonly bool _md1;
        private readonly bool _md2;
        private readonly bool _md3;

        #endregion

        #region constructor/s

        #region [public] ColorimetryDataBlock(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la estructura.
        /// <summary>
        /// Inicializa una nueva instancia de la estructura <see cref="ColorimetryDataBlock"/> especificando los datos de este bloque de audio.
        /// </summary>
        /// <param name="colorimetryDataBlock">Datos de este bloque de audio.</param>
        public ColorimetryDataBlock(ReadOnlyCollection<byte> colorimetryDataBlock)
        {                
            XVYCC601 = colorimetryDataBlock[0x02].CheckBit(Bits.Bit00);
            XVYCC709 = colorimetryDataBlock[0x02].CheckBit(Bits.Bit01);
            SYCC601 = colorimetryDataBlock[0x02].CheckBit(Bits.Bit02);
            AdobeYCC601 = colorimetryDataBlock[0x02].CheckBit(Bits.Bit03);
            AdobeRGB = colorimetryDataBlock[0x02].CheckBit(Bits.Bit04);

            _md0 = colorimetryDataBlock[0x03].CheckBit(Bits.Bit00);
            _md1 = colorimetryDataBlock[0x03].CheckBit(Bits.Bit01);
            _md2 = colorimetryDataBlock[0x03].CheckBit(Bits.Bit02);
            _md3 = colorimetryDataBlock[0x03].CheckBit(Bits.Bit03);
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (bool) AdobeRGB: Obtiene un valor que indica si cumple con el estandard IEC 61966-2-5.
        /// <summary>
        /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-5.
        /// </summary>
        /// <value>
        /// Es <b>true</b> si cumple con el estandard IEC 61966-2-5; en caso contrario, es <b>false</b>.
        /// </value>
        public bool AdobeRGB { get; }
        #endregion

        #region [public] (bool) AdobeYCC601: Obtiene un valor que indica si cumple con el estandard IEC 61966-2-5 Annex A.
        /// <summary>
        /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-5 Annex A.
        /// </summary>
        /// <value>
        /// <b>true</b> si cumple con el estandard IEC 61966-2-5 Annex A; en caso contrario, es <b>false</b>.
        /// </value>
        public bool AdobeYCC601 { get; }
        #endregion

        #region [public] (bool) SYCC601: Obtiene un valor que indica si cumple con el estandard IEC 61966-2-1/Amendment 1.
        /// <summary>
        /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-1/Amendment 1.
        /// </summary>
        /// <value>
        /// Es <b>true</b> si cumple con el estandard IEC 61966-2-1/Amendment 1; en caso contrario, es <b>false</b>.
        /// </value>
        public bool SYCC601 { get; }
        #endregion

        #region [public] (bool) XVYCC709: Obtiene un valor que indica si cumple con el estandard IEC 61966-2-4 (High Definition Colorimetry).
        /// <summary>
        /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-4 (High Definition Colorimetry).
        /// </summary>
        /// <value>
        /// Es <b>true</b> si cumple con el estandard IEC 61966-2-4 (High Definition Colorimetry), es <b>false</b>.
        /// </value>
        public bool XVYCC709 { get; }
        #endregion

        #region [public] (bool) XVYCC601: Obtiene un valor que indica si cumple con el estandard IEC 61966-2-4 (Standard Definition Colorimetry).
        /// <summary>
        /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-4 (Standard Definition Colorimetry).
        /// </summary>
        /// <value>
        /// Es <b>true</b> si cumple con el estandard IEC 61966-2-4 (Standard Definition Colorimetry); en caso contrario, es <b>false</b>.
        /// </value>
        public bool XVYCC601 { get; }
        #endregion

        #region [public] (bool) MD0: Obtiene un valor que indica si cumple con future metadata.
        /// <summary>
        /// Obtiene un valor que indica si cumple con future metadata.
        /// </summary>
        /// <value>
        /// Es <b>true</b> si cumple con future metadata.; en caso contrario, es <b>false</b>.
        /// </value>
        public bool MD0 => _md0;
        #endregion

        #region [public] (bool) MD1: Obtiene un valor que indica si cumple con future metadata.
        /// <summary>
        /// Obtiene un valor que indica si cumple con future metadata.
        /// </summary>
        /// <value>
        /// Es <b>true</b> si cumple con future metadata.; en caso contrario, es <b>false</b>.
        /// </value>
        public bool MD1 => _md1;
        #endregion

        #region [public] (bool) MD2: Obtiene un valor que indica si cumple con future metadata.
        /// <summary>
        /// Obtiene un valor que indica si cumple con future metadata.
        /// </summary>
        /// <value>
        /// Es <b>true</b> si cumple con future metadata.; en caso contrario, es <b>false</b>.
        /// </value>
        public bool MD2 => _md2;
        #endregion

        #region [public] (bool) MD3: Obtiene un valor que indica si cumple con future metadata.
        /// <summary>
        /// Obtiene un valor que indica si cumple con future metadata.
        /// </summary>
        /// <value>
        /// Es <b>true</b> si cumple con future metadata.; en caso contrario, es <b>false</b>.
        /// </value>
        public bool MD3 => _md3;
        #endregion

        #endregion
    }
}
