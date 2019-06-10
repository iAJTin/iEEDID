
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.ObjectModel;

    using Device.DeviceProperty;

    #region EEDID -> CEA -> Sections

    #region (enum) KnownCeaInformationProperty: Definición de propiedades para una sección de tipo 'Information'.
    /// <summary>
    /// Definición de propiedades para una sección de tipo <see cref="KnownCeaSection.Information"/>.
    /// Para más información ver <see cref="InformationCeaSection.GetValueTypedProperty"/>.
    /// </summary>
    enum KnownCeaInformationProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Byte))]
        Revision,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(String))]
        Implemented,
    }
    #endregion

    #region (enum) KnownCeaMonitorSupportProperty: Definición de propiedades para una sección de tipo 'MonitorSupport'.
    /// <summary>
    /// Definición de propiedades para una sección de tipo <see cref="KnownCeaSection.MonitorSupport"/>.
    /// Para más información ver <see cref="MonitorSupportCeaSection.GetValueTypedProperty"/>.
    /// </summary>
    enum KnownCeaMonitorSupportProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        IsDvtUnderscan,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        BasicAudioSupported,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        YCbCr444Supported,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        YCbCr422Supported,
    }
    #endregion

    #region (enum) KnownCeaCheckSumProperty: Definición de propiedades para una sección de tipo 'CheckSum'.
    /// <summary>
    /// Definición de propiedades para una sección de tipo <see cref="KnownCeaSection.CheckSum"/>.
    /// Para más información ver <see cref="CheckSumCeaSection.GetValueTypedProperty"/>.
    /// </summary>
    enum KnownCeaCheckSumProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(Boolean))]
        Ok,
    }
    #endregion

    #region (enum) KnownCeaDetailedTimingModeProperty: Definición de propiedades para una sección de tipo 'DetailedTimings'.
    /// <summary>
    /// Definición de propiedades para una sección de tipo <see cref="KnownCeaSection.DetailedTiming"/>.
    /// Para más información ver <see cref="CheckSumCeaSection.GetValueTypedProperty"/>.
    /// </summary>
    enum KnownCeaDetailedTimingModeProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<DetailedTimingModeDescriptor>))]
        Timings,
    }
    #endregion

    #endregion
}
