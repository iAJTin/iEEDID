
namespace iTin.Core.Hardware.Specification.Eedid
{
    /// <summary>
    /// Types of known blocks.
    /// </summary>
    public enum KnownDataBlock
    {
        /// <summary>
        /// Extended display identification data
        /// </summary>
        EDID,

        /// <summary>
        /// Implements CEA-EXT: Data Block Collection (CEA 861/A/B Extension)
        /// </summary>
        CEA,

        /// <summary>
        /// Implements DI-EXT: Display Information Extension
        /// </summary>
        DI,

        /// <summary>
        /// Implements LS-EXT: Localizated String Extension
        /// </summary>
        LS,

        /// <summary>
        /// Implements VTS-EXT: Vesa Video Timing Block Extension Data Standard
        /// </summary>
        VTB
    }
}
