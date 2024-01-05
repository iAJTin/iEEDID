
using System.Collections.ObjectModel;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors.DataBlocks;

/// <summary>
/// Structure <see cref="ColorimetryDataBlock"/> that contains the logic to decode the data of a block of type <see cref="ExtendedTag.Colorimetry"/>.
/// </summary> 
internal readonly struct ColorimetryDataBlock
{
    #region private readonly members

    private readonly bool _md0;
    private readonly bool _md1;
    private readonly bool _md2;
    private readonly bool _md3;

    #endregion

    #region constructor/s

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

    #region public readonly properties

    /// <summary>
    /// Gets a value that indicates whether it conforms to the IEC 61966-2-5 standard.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if it conforms to the IEC 61966-2-5 standard; otherwise <strong>false</strong>.
    /// </value>
    public bool AdobeRGB { get; }

    /// <summary>
    /// Gets a value that indicates whether it complies with the IEC 61966-2-5 Annex A standard.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if it complies with the IEC 61966-2-5 Annex A standard; otherwise <strong>false</strong>.
    /// </value>
    public bool AdobeYCC601 { get; }

    /// <summary>
    /// Gets a value that indicates whether it complies with the IEC 61966-2-1/Amendment 1 standard.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if it complies with the IEC 61966-2-1/Amendment 1 standard; otherwise <strong>false</strong>.
    /// </value>
    public bool SYCC601 { get; }

    /// <summary>
    /// Gets a value that indicates whether it conforms to the IEC 61966-2-4 (High Definition Colorimetry) standard.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if it complies with the IEC 61966-2-4 (High Definition Colorimetry) standard; otherwise <strong>false</strong>.
    /// </value>
    public bool XVYCC709 { get; }

    /// <summary>
    /// Gets a value that indicates whether it conforms to the IEC 61966-2-4 (Standard Definition Colorimetry) standard.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if it complies with the IEC 61966-2-4 (Standard Definition Colorimetry) standard; otherwise <strong>false</strong>.
    /// </value>
    public bool XVYCC601 { get; }

    /// <summary>
    /// Gets a value that indicates whether it conforms to future metadata.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if it conforms to future metadata; otherwise <strong>false</strong>.
    /// </value>
    public bool MD0 => _md0;

    /// <summary>
    /// Gets a value that indicates whether it conforms to future metadata.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if it conforms to future metadata; otherwise <strong>false</strong>.
    /// </value>
    public bool MD1 => _md1;

    /// <summary>
    /// Gets a value that indicates whether it conforms to future metadata.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if it conforms to future metadata; otherwise <strong>false</strong>.
    /// </value>
    public bool MD2 => _md2;

    /// <summary>
    /// Gets a value that indicates whether it conforms to future metadata.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if it conforms to future metadata; otherwise <strong>false</strong>.
    /// </value>
    public bool MD3 => _md3;

    #endregion
}
