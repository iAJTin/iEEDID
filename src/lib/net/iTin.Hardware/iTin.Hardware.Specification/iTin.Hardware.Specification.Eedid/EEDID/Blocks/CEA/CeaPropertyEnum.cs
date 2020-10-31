
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
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Revision,

        [PropertyDescription("")]
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
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        IsDvtUnderscan,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        BasicAudioSupported,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        YCbCr444Supported,

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
        [PropertyDescription("")]
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
        [PropertyDescription("")]
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
        [PropertyDescription("Adobe RGB")]
        [PropertyType(typeof(bool))]
        AdobeRGB,

        [PropertyDescription("Adobe YCC601")]
        [PropertyType(typeof(bool))]
        AdobeYCC601,

        [PropertyDescription("sYCC601")]
        [PropertyType(typeof(bool))]
        sYCC601,

        [PropertyDescription("xvYCC709")]
        [PropertyType(typeof(bool))]
        xvYCC709,

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
        [PropertyDescription("CE Overscan/Underscan")]
        [PropertyType(typeof(string))]
        CEOverscan,

        [PropertyDescription("IT Overscan/Underscan")]
        [PropertyType(typeof(string))]
        ITOverscan,

        [PropertyDescription("PT Overscan/Underscan")]
        [PropertyType(typeof(string))]
        PTOverscan,

        [PropertyDescription("Quantization Range RGB")]
        [PropertyType(typeof(string))]
        QuantizationRangeRGB,

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
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        FrontLeftRightHigh,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        FrontLeftRightWide,
        
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        RearLeftRightCenter,
        
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        FrontLeftRightCenter,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        RearCenter,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        RearLeftRight,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        FrontCenter,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        LFEChannel,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        FrontLeftRight,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        TopCenter,

        [PropertyDescription("")]
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
        [PropertyDescription("")]
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
        [PropertyDescription("IEEE Registration Identifier")]
        [PropertyType(typeof(int))]
        IEEERegistrationIdentifier,

        [PropertyDescription("Consumer Electronics Control (CEC) physical address")]
        [PropertyType(typeof(int))]
        PhysicalAddress,

        [PropertyDescription("Flags")]
        [PropertyType(typeof(ReadOnlyCollection<string>))]
        Flags,

        [PropertyDescription("Maximum TMDS clock")]
        [PropertyType(typeof(int))]
        MaxClock,

        [PropertyDescription("Vendor Specific Payload")]
        [PropertyType(typeof(ReadOnlyCollection<byte>))]
        VendorPayload,
    }
    #endregion

    #endregion
}
