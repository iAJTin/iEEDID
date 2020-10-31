
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

        #region [public] ColorimetryDataBlock(ReadOnlyCollection<byte>): Initializes a new instance of the structure
        /// <summary>
        /// Initializes a new instance of the <see cref="ColorimetryDataBlock"/> structure specifying the data of this audio block.
        /// </summary>
        /// <param name="colorimetryDataBlock">Data of this audio block.</param>
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

        #region [public] (bool) AdobeRGB: Gets a value that indicates whether it conforms to the IEC 61966-2-5 standard
        /// <summary>
        /// Gets a value that indicates whether it conforms to the IEC 61966-2-5 standard.
        /// </summary>
        /// <value>
        /// <b>true</b> if it conforms to the IEC 61966-2-5 standard; otherwise <b>false</b>.
        /// </value>
        public bool AdobeRGB { get; }
        #endregion

        #region [public] (bool) AdobeYCC601: Gets a value that indicates whether it complies with the IEC 61966-2-5 Annex A standard
        /// <summary>
        /// Gets a value that indicates whether it complies with the IEC 61966-2-5 Annex A standard.
        /// </summary>
        /// <value>
        /// <b>true</b> if it complies with the IEC 61966-2-5 Annex A standard; otherwise <b>false</b>.
        /// </value>
        public bool AdobeYCC601 { get; }
        #endregion

        #region [public] (bool) SYCC601: Gets a value that indicates whether it complies with the IEC 61966-2-1/Amendment 1 standard
        /// <summary>
        /// Gets a value that indicates whether it complies with the IEC 61966-2-1/Amendment 1 standard.
        /// </summary>
        /// <value>
        /// <b>true</b> if it complies with the IEC 61966-2-1/Amendment 1 standard; otherwise <b>false</b>.
        /// </value>
        public bool SYCC601 { get; }
        #endregion

        #region [public] (bool) XVYCC709: Gets a value that indicates whether it conforms to the IEC 61966-2-4 (High Definition Colorimetry) standard
        /// <summary>
        /// Gets a value that indicates whether it conforms to the IEC 61966-2-4 (High Definition Colorimetry) standard.
        /// </summary>
        /// <value>
        /// <b>true</b> if it complies with the IEC 61966-2-4 (High Definition Colorimetry) standard; otherwise <b>false</b>.
        /// </value>
        public bool XVYCC709 { get; }
        #endregion

        #region [public] (bool) XVYCC601: Gets a value that indicates whether it conforms to the IEC 61966-2-4 (Standard Definition Colorimetry) standard
        /// <summary>
        /// Gets a value that indicates whether it conforms to the IEC 61966-2-4 (Standard Definition Colorimetry) standard.
        /// </summary>
        /// <value>
        /// <b>true</b> if it complies with the IEC 61966-2-4 (Standard Definition Colorimetry) standard; otherwise <b>false</b>.
        /// </value>
        public bool XVYCC601 { get; }
        #endregion

        #region [public] (bool) MD0: Gets a value that indicates whether it conforms to future metadata
        /// <summary>
        /// Gets a value that indicates whether it conforms to future metadata.
        /// </summary>
        /// <value>
        /// <b>true</b> if it conforms to future metadata; otherwise <b>false</b>.
        /// </value>
        public bool MD0 => _md0;
        #endregion

        #region [public] (bool) MD1: Gets a value that indicates whether it conforms to future metadata
        /// <summary>
        /// Gets a value that indicates whether it conforms to future metadata.
        /// </summary>
        /// <value>
        /// <b>true</b> if it conforms to future metadata; otherwise <b>false</b>.
        /// </value>
        public bool MD1 => _md1;
        #endregion

        #region [public] (bool) MD2: Gets a value that indicates whether it conforms to future metadata
        /// <summary>
        /// Gets a value that indicates whether it conforms to future metadata.
        /// </summary>
        /// <value>
        /// <b>true</b> if it conforms to future metadata; otherwise <b>false</b>.
        /// </value>
        public bool MD2 => _md2;
        #endregion

        #region [public] (bool) MD3: Gets a value that indicates whether it conforms to future metadata
        /// <summary>
        /// Gets a value that indicates whether it conforms to future metadata.
        /// </summary>
        /// <value>
        /// <b>true</b> if it conforms to future metadata; otherwise <b>false</b>.
        /// </value>
        public bool MD3 => _md3;
        #endregion

        #endregion
    }
}
