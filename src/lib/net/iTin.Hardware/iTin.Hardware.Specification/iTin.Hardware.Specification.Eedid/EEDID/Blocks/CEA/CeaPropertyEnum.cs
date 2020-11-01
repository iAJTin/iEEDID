
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using iTin.Core.Hardware.Common;

    #region EEDID -> CEA

    #region [internal] (enum) CeaInformation: Definition of properties for a section of type 'Information'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.Information"/>.
    /// </summary>
    internal enum CeaInformation
    {
        [PropertyName("Revision")]
        [PropertyDescription("Revision")]
        [PropertyType(typeof(byte))]
        Revision,

        [PropertyName("Implemented")]
        [PropertyDescription("Implemented")]
        [PropertyType(typeof(string))]
        Implemented,
    }
    #endregion

    #region [internal] (enum) CeaMonitorSupport: Definition of properties for a section of type 'MonitorSupport'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.MonitorSupport"/>.
    /// </summary>
    internal enum CeaMonitorSupport
    {
        [PropertyName("Is Dvt Underscan")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        IsDvtUnderscan,

        [PropertyName("Basic Audio Supported")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        BasicAudioSupported,

        [PropertyName("YCbCr4:4:4 Supported")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        YCbCr444Supported,

        [PropertyName("YCbCr4:2:2 Supported")]
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        YCbCr422Supported,
    }
    #endregion

    #region [internal] (enum) CeaCheckSum: Definition of properties for a section of type 'CheckSum'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.CheckSum"/>.
    /// </summary>
    internal enum CeaCheckSum
    {
        [PropertyName("Status")]
        [PropertyDescription("Status")]
        [PropertyType(typeof(bool))]
        Ok,
    }
    #endregion

    #region [internal] (enum) CeaDetailedTiming: Definition of properties for a section of type 'DetailedTimings'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DetailedTiming"/>.
    /// </summary>
    internal enum CeaDetailedTiming
    {
        [PropertyName("Timings")]
        [PropertyDescription("Timings")]
        [PropertyType(typeof(List<SectionPropertiesTable>))]
        Timings,
    }
    #endregion

    #region [internal] (enum) CeaDetailedTimingDescriptor: Definition of properties for a section of type 'DetailedTimings'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DetailedTiming"/>.
    /// </summary>
    internal enum CeaDetailedTimingDescriptor
    {
        [PropertyName("Pixel Clock")]
        [PropertyDescription("Pixel Clock")]
        [PropertyType(typeof(int))]
        PixelClock,

        [PropertyName("Horizontal Resolution")]
        [PropertyDescription("Horizontal Resolution")]
        [PropertyType(typeof(int))]
        HorizontalResolution,

        [PropertyName("Horizontal Blanking")]
        [PropertyDescription("Horizontal Blanking")]
        [PropertyType(typeof(int))]
        HorizontalBlanking,

        [PropertyName("Vertical Lines")]
        [PropertyDescription("Vertical Lines")]
        [PropertyType(typeof(int))]
        VerticalLines,

        [PropertyName("Vertical Blanking")]
        [PropertyDescription("Vertical Blanking")]
        [PropertyType(typeof(int))]
        VerticalBlanking,

        [PropertyName("Horizontal Front Porch")]
        [PropertyDescription("Horizontal Front Porch")]
        [PropertyType(typeof(int))]
        HorizontalFrontPorch,

        [PropertyName("Horizontal Sync Pulse Width")]
        [PropertyDescription("Horizontal Sync Pulse Width")]
        [PropertyType(typeof(int))]
        HorizontalSyncPulseWidth,

        [PropertyName("Vertical Front Porch")]
        [PropertyDescription("Vertical Front Porch")]
        [PropertyType(typeof(int))]
        VerticalFrontPorch,

        [PropertyName("Vertical Sync Pulse Width")]
        [PropertyDescription("Vertical Sync Pulse Width")]
        [PropertyType(typeof(int))]
        VerticalSyncPulseWidth,

        [PropertyName("Horizontal Image Size")]
        [PropertyDescription("Horizontal Image Size")]
        [PropertyType(typeof(int))]
        HorizontalImageSize,

        [PropertyName("Vertical Image Size")]
        [PropertyDescription("Vertical Image Size")]
        [PropertyType(typeof(int))]
        VerticalImageSize,

        [PropertyName("Interlaced")]
        [PropertyDescription("Interlaced")]
        [PropertyType(typeof(int))]
        HorizontalBorder,

        [PropertyName("Vertical Border")]
        [PropertyDescription("Vertical Border")]
        [PropertyType(typeof(int))]
        VerticalBorder,

        [PropertyName("Interlaced")]
        [PropertyDescription("Interlaced")]
        [PropertyType(typeof(bool))]
        Interlaced,

        [PropertyName("Stereo Viewing Support")]
        [PropertyDescription("Stereo Viewing Support")]
        [PropertyType(typeof(string))]
        StereoViewingSupport,

        [PropertyName("Sync Signal Type")]
        [PropertyDescription("Sync Signal Type")]
        [PropertyType(typeof(string))]
        SyncSignalType,
    }
    #endregion

    #region [internal] (enum) CeaDataBlockTags: Definition of sections for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaDataBlockTags
    {
        [PropertyName("Audio")]
        [PropertyDescription("Audio DataBlock Tag")]
        [PropertyType(typeof(SectionPropertiesTable))]
        Audio,

        [PropertyName("Extended")]
        [PropertyDescription("Extended DataBlock Tag")]
        [PropertyType(typeof(SectionPropertiesTable))]
        Extended,

        [PropertyName("Reserved")]
        [PropertyDescription("Reserved DataBlock Tag")]
        [PropertyType(typeof(SectionPropertiesTable))]
        Reserved,

        [PropertyName("Speaker")]
        [PropertyDescription("Speaker DataBlock Tag")]
        [PropertyType(typeof(SectionPropertiesTable))]
        Speaker,

        [PropertyName("Video")]
        [PropertyDescription("Video DataBlock Tag")]
        [PropertyType(typeof(SectionPropertiesTable))]
        Video,

        [PropertyName("Vendor")]
        [PropertyDescription("Vendor DataBlock Tag")]
        [PropertyType(typeof(SectionPropertiesTable))]
        Vendor,

        [PropertyName("VESA")]
        [PropertyDescription("VESA DataBlock Tag")]
        [PropertyType(typeof(SectionPropertiesTable))]
        VESA,
    }
    #endregion

    #region [internal] (enum) CeaAudioDataBlock: Definition of properties for 'Audio' datablock section of 'DataBlockCollection' section
    /// <summary>
    /// Definition of properties for <b>Audio</b> datablock section of <see cref="KnownCeaSection.DataBlockCollection"/> section.
    /// </summary>
    internal enum CeaAudioDataBlock
    {
        [PropertyName("Audio Descriptor")]
        [PropertyDescription("Audio Descriptor Index")]
        [PropertyType(typeof(byte))]
        Descriptor,

        [PropertyName("Audio Bit Depth")]
        [PropertyDescription("Audio Bit Depth")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        BitDepth,

        [PropertyName("Audio Channels")]
        [PropertyDescription("Audio Channels")]
        [PropertyType(typeof(ushort))]
        Channels,

        [PropertyName("Audio Format")]
        [PropertyDescription("Audio Format")]
        [PropertyType(typeof(string))]
        Format,

        [PropertyName("Audio Max Bitrate")]
        [PropertyDescription("Audio Max Bitrate")]
        [PropertyType(typeof(int))]
        MaxBitrate,

        [PropertyName("Audio Sampling Frequencies")]
        [PropertyDescription("Audio Sampling Frequencies")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        SamplingFrequencies
    }
    #endregion

    #region [internal] (enum) CeaExtendedColorimetryDataBlock: Definition of properties for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaExtendedColorimetryDataBlock
    {
        [PropertyName("Adobe RGB")]
        [PropertyDescription("Adobe RGB")]
        [PropertyType(typeof(bool))]
        AdobeRGB,

        [PropertyName("Adobe YCC601")]
        [PropertyDescription("Adobe YCC601")]
        [PropertyType(typeof(bool))]
        AdobeYCC601,

        [PropertyName("sYCC601")]
        [PropertyDescription("sYCC601")]
        [PropertyType(typeof(bool))]
        sYCC601,

        [PropertyName("xvYCC709")]
        [PropertyDescription("xvYCC709")]
        [PropertyType(typeof(bool))]
        xvYCC709,

        [PropertyName("xvYCC601")]
        [PropertyDescription("xvYCC601")]
        [PropertyType(typeof(bool))]
        xvYCC601
    }
    #endregion

    #region [internal] (enum) CeaExtendedMiscellaneousAudioFieldsDataBlock: Definition of properties for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaExtendedMiscellaneousAudioFieldsDataBlock
    {
    }
    #endregion

    #region [internal] (enum) CeaExtendedVendorSpecificAudioDataBlock: Definition of properties for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaExtendedVendorSpecificAudioDataBlock
    {
    }
    #endregion

    #region [internal] (enum) CeaExtendedVendorSpecificVideoDataBlock: Definition of properties for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaExtendedVendorSpecificVideoDataBlock
    {
    }
    #endregion

    #region [internal] (enum) CeaExtendedVideoCapabilityDataBlock: Definition of properties for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaExtendedVideoCapabilityDataBlock
    {
        [PropertyName("CE Overscan/Underscan")]
        [PropertyDescription("CE Overscan/Underscan")]
        [PropertyType(typeof(string))]
        CEOverscan,

        [PropertyName("IT Overscan/Underscan")]
        [PropertyDescription("IT Overscan/Underscan")]
        [PropertyType(typeof(string))]
        ITOverscan,

        [PropertyName("PT Overscan/Underscan")]
        [PropertyDescription("PT Overscan/Underscan")]
        [PropertyType(typeof(string))]
        PTOverscan,

        [PropertyName("Quantization Range RGB")]
        [PropertyDescription("Quantization Range RGB")]
        [PropertyType(typeof(string))]
        QuantizationRangeRGB,

        [PropertyName("Quantization Range YCC")]
        [PropertyDescription("Quantization Range YCC")]
        [PropertyType(typeof(string))]
        QuantizationRangeYCC
    }
    #endregion

    #region [internal] (enum) CeaReservedDataBlock: Definition of properties for 'Reserved' datablock section of 'DataBlockCollection' section
    /// <summary>
    /// Definition of properties for <b>Reserved</b> datablock section of <see cref="KnownCeaSection.DataBlockCollection"/> section.
    /// </summary>
    internal enum CeaReservedDataBlock
    {
        [PropertyName("Data")]
        [PropertyDescription("Raw data")]
        [PropertyType(typeof(ReadOnlyCollection<byte>))]
        Data,
    }
    #endregion

    #region [internal] (enum) CeaSpeakerDataBlock: Definition of properties for 'Speaker' datablock section of 'DataBlockCollection' section
    /// <summary>
    /// Definition of properties for <b>Speaker</b> datablock section of <see cref="KnownCeaSection.DataBlockCollection"/> section.
    /// </summary>
    internal enum CeaSpeakerDataBlock
    {
        [PropertyName("Front Left/Right High")]
        [PropertyDescription("Front Left/Right High")]
        [PropertyType(typeof(bool))]
        FrontLeftRightHigh,

        [PropertyName("Front Left/Right Wide")]
        [PropertyDescription("Front Left/Right Wide")]
        [PropertyType(typeof(bool))]
        FrontLeftRightWide,

        [PropertyName("Rear Left/Right Center")]
        [PropertyDescription("Rear Left/Right Center")]
        [PropertyType(typeof(bool))]
        RearLeftRightCenter,

        [PropertyName("Front Left/Right Center")]
        [PropertyDescription("Front Left/Right Center")]
        [PropertyType(typeof(bool))]
        FrontLeftRightCenter,

        [PropertyName("Rear Center")]
        [PropertyDescription("Rear Center")]
        [PropertyType(typeof(bool))]
        RearCenter,

        [PropertyName("Rear Left/Right")]
        [PropertyDescription("Rear Left/Right")]
        [PropertyType(typeof(bool))]
        RearLeftRight,

        [PropertyName("Front Center")]
        [PropertyDescription("Front Center")]
        [PropertyType(typeof(bool))]
        FrontCenter,

        [PropertyName("LFE Channel")]
        [PropertyDescription("LFE Channel")]
        [PropertyType(typeof(bool))]
        LFEChannel,

        [PropertyName("Front Left/Right")]
        [PropertyDescription("Front Left/Right")]
        [PropertyType(typeof(bool))]
        FrontLeftRight,

        [PropertyName("Top Center")]
        [PropertyDescription("Top Center")]
        [PropertyType(typeof(bool))]
        TopCenter,

        [PropertyName("Front Center High")]
        [PropertyDescription("Front Center High")]
        [PropertyType(typeof(bool))]
        FrontCenterHigh,
    }
    #endregion

    #region [internal] (enum) CeaVendorDataBlock: Definition of properties for 'Vendor' datablock section of 'DataBlockCollection' section
    /// <summary>
    /// Definition of properties for <b>Vendor</b> datablock section of <see cref="KnownCeaSection.DataBlockCollection"/> section.
    /// </summary>
    internal enum CeaVendorDataBlock
    {
        [PropertyName("IEEE Registration Identifier")]
        [PropertyDescription("IEEE Registration Identifier")]
        [PropertyType(typeof(int))]
        IEEERegistrationIdentifier,

        [PropertyName("Physical Address")]
        [PropertyDescription("Consumer Electronics Control (CEC) physical address")]
        [PropertyType(typeof(int))]
        PhysicalAddress,

        [PropertyName("Flags")]
        [PropertyDescription("Flags")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        Flags,

        [PropertyName("Maximum TMDS clock")]
        [PropertyDescription("Maximum TMDS clock")]
        [PropertyType(typeof(int))]
        MaxClock,

        [PropertyName("Vendor Specific Payload")]
        [PropertyDescription("Vendor Specific Payload")]
        [PropertyType(typeof(ReadOnlyCollection<byte>))]
        VendorPayload,
    }
    #endregion

    #region [internal] (enum) CeaVideoDataBlock: Definition of properties for 'Video' datablock section of 'DataBlockCollection' section
    /// <summary>
    /// Definition of properties for <b>Video</b> datablock section of <see cref="KnownCeaSection.DataBlockCollection"/> section.
    /// </summary>
    internal enum CeaVideoDataBlock
    {
        [PropertyName("Supported Timings")]
        [PropertyDescription("Supported Timings")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        SupportedTimings,
    }
    #endregion

    #endregion
}
