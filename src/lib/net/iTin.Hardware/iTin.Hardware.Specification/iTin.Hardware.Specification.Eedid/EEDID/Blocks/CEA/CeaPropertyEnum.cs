
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;

    using iTin.Core.Hardware.Common;

    #region EEDID -> CEA -> Sections

    #region [internal] (enum) CeaInformationProperty: Definition of properties for a section of type 'Information'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.Information"/>.
    /// </summary>
    internal enum CeaInformationProperty
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

    #region [internal] (enum) CeaMonitorSupportProperty: Definition of properties for a section of type 'MonitorSupport'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.MonitorSupport"/>.
    /// </summary>
    internal enum CeaMonitorSupportProperty
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

    #region [internal] (enum) CeaCheckSumProperty: Definition of properties for a section of type 'CheckSum'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.CheckSum"/>.
    /// </summary>
    internal enum CeaCheckSumProperty
    {
        [PropertyName("Status")]
        [PropertyDescription("Status")]
        [PropertyType(typeof(bool))]
        Ok,
    }
    #endregion

    #region [internal] (enum) CeaDetailedTimingModeProperty: Definition of properties for a section of type 'DetailedTimings'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DetailedTiming"/>.
    /// </summary>
    internal enum CeaDetailedTimingModeProperty
    {
        [PropertyName("Timings")]
        [PropertyDescription("Timings")]
        [PropertyType(typeof(ReadOnlyCollection<DetailedTimingModeDescriptor>))]
        Timings,
    }
    #endregion


    #region [internal] (enum) CeaExtendedColorimetryDataBlockProperty: Definition of properties for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaExtendedColorimetryDataBlockProperty
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

    #region [internal] (enum) CeaExtendedMiscellaneousAudioFieldsDataBlockProperty: Definition of properties for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaExtendedMiscellaneousAudioFieldsDataBlockProperty
    {
    }
    #endregion

    #region [internal] (enum) CeaExtendedVendorSpecificAudioDataBlockProperty: Definition of properties for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaExtendedVendorSpecificAudioDataBlockProperty
    {
    }
    #endregion

    #region [internal] (enum) CeaExtendedVendorSpecificVideoDataBlockProperty: Definition of properties for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaExtendedVendorSpecificVideoDataBlockProperty
    {
    }
    #endregion

    #region [internal] (enum) CeaExtendedVideoCapabilityDataBlockProperty: Definition of properties for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaExtendedVideoCapabilityDataBlockProperty
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

    #region [internal] (enum) CeaReservedDataBlockProperty: Definition of properties for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaReservedDataBlockProperty
    {
        [PropertyName("Data")]
        [PropertyDescription("Raw data")]
        [PropertyType(typeof(ReadOnlyCollection<byte>))]
        Data,
    }
    #endregion

    #region [internal] (enum) CeaSpeakerDataBlockProperty: Definition of properties for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaSpeakerDataBlockProperty
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

    #region [internal] (enum) CeaVideoDataBlockProperty: Definition of properties for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaVideoDataBlockProperty
    {
        [PropertyName("Supported Timings")]
        [PropertyDescription("Supported Timings")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        SupportedTimings,
    }
    #endregion

    #region [internal] (enum) CeaVendorDataBlockProperty: Definition of properties for a section of type 'DataBlockCollection'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DataBlockCollection"/>.
    /// </summary>
    internal enum CeaVendorDataBlockProperty
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

    #endregion
}
