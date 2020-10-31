
namespace iTin.Hardware.Specification.Eedid
{
    /* •—————————————————————————————————————————————•
       |  0x00 - Reserved                            |
       |  0x01 - Linear Pulse Code Modulation (LPCM) |
       |  0x02 - AC-3                                |
       |  0x03 - MPEG-1 (Layers 1 & 2)               |
       |  0x04 - MP3 (MPEG1 Layer 3)                 |
       |  0x05 - MPEG2 (Multichannel)                |
       |  0x06 - AAC                                 |
       |  0x07 - DTS                                 |
       |  0x08 - ATRAC                               |
       |  0x09 - One-bit audio aka SACD              |
       |  0x0a - DD+                                 | 
       |  0x0b - DTS-HD                              | 
       |  0x0c - MLP/Dolby TrueHD                    | 
       |  0x0d - DTS                                 |
       |  0x0e - Microsoft WMA Pro                   |
       |  0x0f - Reserved                            |
       •—————————————————————————————————————————————• */

    /// <summary>
    /// Audio format codes available for type <see cref="AudioDataBlock"/>.
    /// </summary>
    internal enum KnownAudioFormatCode
    {
        /// <summary>
        /// Analyze header of audio stream to determine format.
        /// </summary>
        StreamHeader = 0x00,

        /// <summary>
        /// Linear Pulse Code Modulation (LPCM), para más información ver estandard IEC 60958-3.
        /// </summary>
        PCM = 0x01,

        /// <summary>
        /// ATSC A/52B, excluding Annex E IEC 61937-3
        /// </summary>
        AC3 = 0x02,

        /// <summary>
        /// 
        /// </summary>
        MPEG1 = 0x03,

        /// <summary>
        /// 
        /// </summary>
        MP3 = 0x04,

        /// <summary>
        /// 
        /// </summary>
        MPEG2 = 0x05,

        /// <summary>
        /// 
        /// </summary>
        AAC = 0x06,

        /// <summary>
        /// 
        /// </summary>
        DTS = 0x07,

        /// <summary>
        /// 
        /// </summary>
        ATRAC = 0x08,

        /// <summary>
        /// 
        /// </summary>
        DSD = 0x09,

        /// <summary>
        /// 
        /// </summary>
        EAC3 = 0x0a,

        /// <summary>
        /// 
        /// </summary>
        DTSHD = 0x0b,

        /// <summary>
        /// 
        /// </summary>
        MLP = 0x0c,

        /// <summary>
        /// For more information see ISO / IEC 14496-3 2005, Information Technology - Coding of audio-visual objects subpart 10.
        /// </summary>
        DST = 0x0d,

        /// <summary>
        /// For more information see Microsoft WMA Pro Decoder Specification: An Overview of Windows Media Audio Professional decoder.
        /// </summary>
        WMAPro = 0x0e,

        /// <summary>
        /// 
        /// </summary>
        Reserved = 0x0f,
    }
}
