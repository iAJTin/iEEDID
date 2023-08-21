
using System.Collections.ObjectModel;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors.DataBlocks;

/// <summary>
/// Structure <see cref="VideoCapabilityDataBlock"/> that contains the logic to decode the data of a block of type <see cref="ExtendedTag.VideoCapability"/>.
/// </summary> 
internal readonly struct VideoCapabilityDataBlock
{
    #region constructor/s

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

    #region public readonly properties

    /// <summary>
    /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-5.
    /// </summary>
    /// <value>
    /// Es <b>true</b> si cumple con el estandard IEC 61966-2-5; en caso contrario, es <b>false</b>.
    /// </value>
    public int CEOverscan { get; }

    /// <summary>
    /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-5 Annex A.
    /// </summary>
    /// <value>
    /// Es <b>true</b> si cumple con el estandard IEC 61966-2-5 Annex A; en caso contrario, es <b>false</b>.
    /// </value>
    public int ITOverscan { get; }

    /// <summary>
    /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-1/Amendment 1.
    /// </summary>
    /// <value>
    /// Es <b>true</b> si cumple con el estandard IEC 61966-2-1/Amendment 1; en caso contrario, es <b>false</b>.
    /// </value>
    public int PTOverscan { get; }

    /// <summary>
    /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-4 (High Definition Colorimetry).
    /// </summary>
    /// <value>
    /// Es <b>true</b> si cumple con el estandard IEC 61966-2-4 (High Definition Colorimetry), es <b>false</b>.
    /// </value>
    public bool QuantizationRangeRGB { get; }

    /// <summary>
    /// Obtiene un valor que indica si cumple con el estandard IEC 61966-2-4 (Standard Definition Colorimetry).
    /// </summary>
    /// <value>
    /// Es <b>true</b> si cumple con el estandard IEC 61966-2-4 (Standard Definition Colorimetry); en caso contrario, es <b>false</b>.
    /// </value>
    public bool QuantizationRangeYCC { get; }

    #endregion
}
