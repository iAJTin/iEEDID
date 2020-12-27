
namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors.DataBlocks
{
    using System.Collections.ObjectModel;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    /// <summary>
    /// Structure <see cref="VideoCapabilityDataBlock"/> that contains the logic to decode the data of a block of type <see cref="ExtendedTag.VideoCapability"/>.
    /// </summary> 
    internal struct VideoCapabilityDataBlock
    {
        #region constructor/s

        #region [public] VideoCapabilityDataBlock(ReadOnlyCollection<byte>): Initializes a new instance of the structure
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoCapabilityDataBlock"/> structure specifying the data of this video block.
        /// </summary>
        /// <param name="videoCapabilityDataBlock">Data of this video block.</param>
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
        /// Es <b>true</b> si cumple con el estandard IEC 61966-2-5; en caso contrario, es <b>false</b>.
        /// </value>
        public int CEOverscan { get; }
        #endregion

        #region [public] (int) ITOverscan: 
        /// <summary>
        /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-5 Annex A.
        /// </summary>
        /// <value>
        /// Es <b>true</b> si cumple con el estandard IEC 61966-2-5 Annex A; en caso contrario, es <b>false</b>.
        /// </value>
        public int ITOverscan { get; }
        #endregion

        #region [public] (int) PTOverscan: 
        /// <summary>
        /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-1/Amendment 1.
        /// </summary>
        /// <value>
        /// Es <b>true</b> si cumple con el estandard IEC 61966-2-1/Amendment 1; en caso contrario, es <b>false</b>.
        /// </value>
        public int PTOverscan { get; }
        #endregion

        #region [public] (bool) QuantizationRangeRGB: 
        /// <summary>
        /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-4 (High Definition Colorimetry).
        /// </summary>
        /// <value>
        /// Es <b>true</b> si cumple con el estandard IEC 61966-2-4 (High Definition Colorimetry), es <b>false</b>.
        /// </value>
        public bool QuantizationRangeRGB { get; }
        #endregion

        #region [public] (bool) QuantizationRangeYCC: 
        /// <summary>
        /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-4 (Standard Definition Colorimetry).
        /// </summary>
        /// <value>
        /// Es <b>true</b> si cumple con el estandard IEC 61966-2-4 (Standard Definition Colorimetry); en caso contrario, es <b>false</b>.
        /// </value>
        public bool QuantizationRangeYCC { get; }
        #endregion

        #endregion
    }
}
