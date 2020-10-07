
namespace iTin.Hardware.Specification.Eedid
{
    /* •————————————————————————————————————————————————————————————————————————————•
       |       0x00 - Video Capability Data Block                                   |
       |       0x01 - Vendor-Specific Video Data Block                              |
       |       0x02 - Reserved for VESA Video Display Device Information Data Block |
       |       0x03 - Reserved for VESA Video Data Block                            |
       |       0x04 - Reserved for HDMI Video Data Block                            |
       |       0x05 - Colorimetry Data Block                                        |
       |  0x06…0x0f - Reserved for video-related blocks                             |
       |       0x10 - Reserved for HDMI Video Data Block                            |
       |       0x11 - Vendor-Specific Audio Data Block                              |
       |       0x12 - Reserved for HDMI Audio Data Block                            |
       |  0x13…0x1f - Reserved for audio-related blocks                             |
       |  0x20…0xff - Reserved for general                                          |
       •————————————————————————————————————————————————————————————————————————————• */

    /// <summary>
    /// Type of extension of a Data Block of the CEA extension.
    /// </summary>
    internal enum KnownExtendedTag
    {
        /// <summary>
        /// Video Capability
        /// </summary>
        VideoCapability = 0x00,

        /// <summary>
        /// Vendor Specific Video
        /// </summary>
        VendorSpecificVideo = 0x01,

        /// <summary>
        /// Colorimetry
        /// </summary>
        Colorimetry = 0x05,

        /// <summary>
        /// Miscellaneous Audio Fields
        /// </summary>
        MiscellaneousAudioFields = 0x10,

        /// <summary>
        /// Vendor Specific Audio
        /// </summary>
        VendorSpecificAudio = 0x11,
    }
}
