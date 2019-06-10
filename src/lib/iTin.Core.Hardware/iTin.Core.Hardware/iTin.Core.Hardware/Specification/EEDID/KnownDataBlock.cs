
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Tipos de bloques conocidos.
    /// </summary>
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EEDID")]
    public enum KnownDataBlock
    {
        /// <summary>
        /// Extended display identification data
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "EDID")]
        EDID,

        /// <summary>
        /// Implements CEA-EXT: Data Block Collection (CEA 861/A/B Extension)
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "CEA")]
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
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "VTB")]
        VTB,
    }
}
