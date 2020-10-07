
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;

    using iTin.Core.Hardware.Common;

    #region EEDID -> CEA -> Sections

    #region [internal] (enum) KnownCeaInformationProperty: Definition of properties for a section of type 'Information'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.Information"/>.
    /// </summary>
    internal enum KnownCeaInformationProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        Revision,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        Implemented,
    }
    #endregion

    #region [internal] (enum) KnownCeaMonitorSupportProperty: Definition of properties for a section of type 'MonitorSupport'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.MonitorSupport"/>.
    /// </summary>
    internal enum KnownCeaMonitorSupportProperty
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

    #region [internal] (enum) KnownCeaCheckSumProperty: Definition of properties for a section of type 'CheckSum'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.CheckSum"/>.
    /// </summary>
    internal enum KnownCeaCheckSumProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        Ok,
    }
    #endregion

    #region [internal] (enum) KnownCeaDetailedTimingModeProperty: Definition of properties for a section of type 'DetailedTimings'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownCeaSection.DetailedTiming"/>.
    /// </summary>
    internal enum KnownCeaDetailedTimingModeProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<DetailedTimingModeDescriptor>))]
        Timings,
    }
    #endregion

    #endregion
}
