
namespace iTin.Core.Hardware.Specification.Eedid
{
    /// <summary>
    /// Tipo de bloques de la extensión CEA
    /// </summary>
    internal enum KnownShortDataBlockTag
    {
        /// <summary>
        /// 
        /// </summary>
        Reserved = 0x00,

        /// <summary>
        /// Audio Data Block
        /// </summary>
        Audio = 0x01,

        /// <summary>
        /// Video Data Block
        /// </summary>
        Video = 0x02,

        /// <summary>
        /// Vendor Specific Data Block
        /// </summary>
        Vendor = 0x03,

        /// <summary>
        /// Speaker Allocation Data Block
        /// </summary>
        Speaker = 0x04,

        /// <summary>
        /// VESA DTC Data Block
        /// </summary>
        VESA = 0x05,

        /// <summary>
        /// Use Extended Tag
        /// </summary>
        ExtendedTag = 0x07,
    }
}
