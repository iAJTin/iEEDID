
using iTin.Core.Hardware.Common;

namespace iTin.Hardware.Specification.Eedid;

/// <summary>
/// Types of known blocks.
/// </summary>
public enum KnownDataBlock
{
    /// <summary>
    /// Extended display identification data
    /// </summary>
    [PropertyName("EDID")]
    [PropertyDescription("Extended display identification data")]
    EDID,

    /// <summary>
    /// Implements CEA-EXT: Data Block Collection (CEA 861/A/B Extension)
    /// </summary>
    [PropertyName("CEA")]
    [PropertyDescription("CTA-861 Extension Block")]
    CEA,

    /// <summary>
    /// Implements DI-EXT: Display Information Extension Block
    /// </summary>
    [PropertyName("DI")]
    [PropertyDescription("Display Information Extension Block")]
    DI,

    /// <summary>
    /// Implements LS-EXT: Localizated String Extension
    /// </summary>
    [PropertyName("LS")]
    [PropertyDescription("LS-EXT: Localizated String Extension")]
    LS,

    /// <summary>
    /// Implements VTS-EXT: Vesa Video Timing Block Extension Data Standard
    /// </summary>
    [PropertyName("VTB")]
    [PropertyDescription("VTS-EXT: Vesa Video Timing Block Extension Data Standard")]
    VTB,

    /// <summary>
    /// Implements DisplayID: VESA Display Identification Data (DisplayID)
    /// </summary>
    [PropertyName("DisplayID")]
    [PropertyDescription("DisplayID Extension Block")]
    DisplayID,
}
