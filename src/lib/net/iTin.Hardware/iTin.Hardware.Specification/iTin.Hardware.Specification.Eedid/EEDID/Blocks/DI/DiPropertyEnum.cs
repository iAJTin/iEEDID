
namespace iTin.Hardware.Specification.Eedid
{
    using iTin.Core.Hardware.Common;

    #region [internal] (enum) DiInformation: Definition of properties for a section of type 'Information'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownDiSection.Information"/>.
    /// </summary>
    internal enum DiInformation
    {
        [PropertyName("VersionNumber")]
        [PropertyDescription("The Version Number for the DI-EXT Block Data Structure")]
        [PropertyType(typeof(byte))]
        VersionNumber,
    }
    #endregion

    #region [internal] {static} (class) DiDigitalInterface: Definition of properties for a section of type 'DigitalInterface'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownDiSection.DigitalInterface"/>.
    /// </summary>
    internal enum DiDigitalInterface
    {
        [PropertyName("Supported Digital Interface")]
        [PropertyDescription("Supported Digital Interface")]
        [PropertyType(typeof(string))]
        SupportedDigitalInterface,

        [PropertyName("Data Enable Signal Usage Available")]
        [PropertyDescription("Data Enable Signal Usage Available")]
        [PropertyType(typeof(bool))]
        DataEnableSignalUsageAvailable,

        [PropertyName("Data Enable Signal High or Low")]
        [PropertyDescription("Data Enable Signal High or Low")]
        [PropertyType(typeof(string))]
        DataEnableSignalHighOrLow,

        [PropertyName("Edge of Shift Clock Usage")]
        [PropertyDescription("Edge of Shift Clock Usage")]
        [PropertyType(typeof(string))]
        EdgeOfShiftClock,

        [PropertyName("HDCP Support")]
        [PropertyDescription("HDCP Support")]
        [PropertyType(typeof(bool))]
        HdcpSupport,

        [PropertyName("Double Clocking Of Input Data")]
        [PropertyDescription("Double Clocking Of Input Data")]
        [PropertyType(typeof(bool))]
        DoubleClockingOfInputData,

        [PropertyName("Support For Packetized Digital Video Support")]
        [PropertyDescription("Support For Packetized Digital Video Support")]
        [PropertyType(typeof(bool))]
        SupportForPacketizedDigitalVideoSupport,

        [PropertyName("Data Formats")]
        [PropertyDescription("Data Formats")]
        [PropertyType(typeof(string))]
        DataFormats,

        [PropertyName("Minimum Pixel Clock Frequency Per Link")]
        [PropertyDescription("Minimum Pixel Clock Frequency Per Link")]
        [PropertyType(typeof(byte))]
        MinimumPixelClockFrequencyPerLink,

        [PropertyName("Maximum Pixel Clock Frequency Per Link")]
        [PropertyDescription("Maximum Pixel Clock Frequency Per Link")]
        [PropertyType(typeof(int))]
        MaximumPixelClockFrequencyPerLink,

        [PropertyName("Crossover Frequency")]
        [PropertyDescription("Crossover Frequency")]
        [PropertyType(typeof(int))]
        CrossoverFrequency,
    }
    #endregion

    #region [internal] {static} (class) DiDisplayDevice: Definition of properties for a section of type 'DisplayDevice'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownDiSection.DisplayDevice"/>.
    /// </summary>
    internal enum DiDisplayDevice
    {
        [PropertyName("Sub-Pixel Layout")]
        [PropertyDescription("Sub-Pixel Layout")]
        [PropertyType(typeof(string))]
        SubPixelLayout,

        [PropertyName("Sub-Pixel Configuration")]
        [PropertyDescription("Sub-Pixel Configuration")]
        [PropertyType(typeof(string))]
        SubPixelConfiguration,

        [PropertyName("Sub-Pixel Shape")]
        [PropertyDescription("Sub-Pixel Shape")]
        [PropertyType(typeof(string))]
        SubPixelShape,

        [PropertyName("Horizontal Dot/Pixel Pitch")]
        [PropertyDescription("Horizontal Dot/Pixel Pitch")]
        [PropertyType(typeof(float))]
        HorizontalDotPixelPitch,

        [PropertyName("Vertical Dot/Pixel Pitch")]
        [PropertyDescription("Vertical Dot/Pixel Pitch")]
        [PropertyType(typeof(float))]
        VerticalDotPixelPitch,

        [PropertyName("Fixed Pixel Format")]
        [PropertyDescription("FixedPixelFormat")]
        [PropertyType(typeof(bool))]
        FixedPixelFormat,

        [PropertyName("View Direction")]
        [PropertyDescription("View Direction")]
        [PropertyType(typeof(string))]
        ViewDirection,

        [PropertyName("Display Background")]
        [PropertyDescription("Display Background")]
        [PropertyType(typeof(bool))]
        DisplayBackground,

        [PropertyName("Physical Implementation")]
        [PropertyDescription("Physical Implementation")]
        [PropertyType(typeof(string))]
        PhysicalImplementation,

        [PropertyName("DDC/CI")]
        [PropertyDescription("DDC/CI")]
        [PropertyType(typeof(bool))]
        DDC,
    }
    #endregion

    #region [internal] {static} (class) DiMiscellaneous: Definition of properties for a section of type 'Miscellaneous'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownDiSection.Miscellaneous"/>.
    /// </summary>
    internal static class DiMiscellaneous
    {
        /// <summary>
        /// Definition of properties for a CheckSum section.
        /// </summary>
        public enum CheckSum
        {
            [PropertyName("Status")]
            [PropertyDescription("Status")]
            [PropertyType(typeof(bool))]
            Ok,

            [PropertyDescription("Checksum datablock value")]
            [PropertyType(typeof(byte))]
            [PropertyName("Value")]
            Value,
        }
    }
    #endregion
}
