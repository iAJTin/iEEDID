
using System.Collections.ObjectModel;

using iTin.Core.Hardware.Common;

namespace iTin.Hardware.Specification.Eedid.Blocks.DI;

/// <summary>
/// Contains all availables section properties for a <see cref="DiBlock"/> block.
/// </summary>
internal static class DiProperty
{
    #region [public] (enum) Information: Definition of properties for a section of type 'Information'
    /// <summary>
    /// Definition of properties for a section of type <see cref="DiSection.Information"/>.
    /// </summary>
    public enum Information
    {
        [PropertyName("VersionNumber")]
        [PropertyDescription("The Version Number for the DI-EXT Block Data Structure")]
        [PropertyType(typeof(byte))]
        VersionNumber
    }
    #endregion

    #region [public] (enum) DigitalInterface: Definition of properties for a section of type 'DigitalInterface'
    /// <summary>
    /// Definition of properties for a section of type <see cref="DiSection.DigitalInterface"/>.
    /// </summary>
    public enum DigitalInterface
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
        CrossoverFrequency
    }
    #endregion

    #region [public] (enum) DisplayDevice: Definition of properties for a section of type 'DisplayDevice'
    /// <summary>
    /// Definition of properties for a section of type <see cref="DiSection.DisplayDevice"/>.
    /// </summary>
    public enum DisplayDevice
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

    #region [public] (enum) DisplayCapabilitiesAndFeatureSupportSet: Definition of properties for a section of type 'DisplayCapabilitiesAndFeatureSupportSet'
    /// <summary>
    /// Definition of properties for a section of type <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/>.
    /// </summary>
    public enum DisplayCapabilitiesAndFeatureSupportSet
    {
        [PropertyName("Legacy Modes")]
        [PropertyDescription("Legacy Modes")]
        [PropertyType(typeof(string))]
        LegacyModes,

        [PropertyName("Stereo Video")]
        [PropertyDescription("Stereo Video")]
        [PropertyType(typeof(string))]
        StereoVideo,

        [PropertyName("Scaler On Board")]
        [PropertyDescription("Scaler On Board")]
        [PropertyType(typeof(bool))]
        ScalerOnBoard,

        [PropertyName("Image Centering")]
        [PropertyDescription("Image Centering")]
        [PropertyType(typeof(bool))]
        ImageCentering,

        [PropertyName("Conditional Update")]
        [PropertyDescription("Conditional Update")]
        [PropertyType(typeof(bool))]
        ConditionalUpdate,

        [PropertyName("Interlaced Video")]
        [PropertyDescription("Interlaced Video")]
        [PropertyType(typeof(bool))]
        InterlacedVideo,

        [PropertyName("Frame Lock")]
        [PropertyDescription("Frame Lock")]
        [PropertyType(typeof(bool))]
        FrameLock,

        [PropertyName("Frame Rate Conversion")]
        [PropertyDescription("Frame Rate Conversion")]
        [PropertyType(typeof(string))]
        FrameRateConversion,

        [PropertyName("Vertical Frequency")]
        [PropertyDescription("Vertical Frequency")]
        [PropertyType(typeof(int))]
        VerticalFrequency,

        [PropertyName("Horizontal Frequency")]
        [PropertyDescription("Horizontal Frequency")]
        [PropertyType(typeof(int))]
        HorizontalFrequency,

        [PropertyName("Display/Scan Orientation Definition Type")]
        [PropertyDescription("Display/Scan Orientation Definition Type")]
        [PropertyType(typeof(int))]
        DisplayScanOrientationType,

        [PropertyName("Screen Orientation")]
        [PropertyDescription("Screen Orientation")]
        [PropertyType(typeof(int))]
        ScreenOrientation,

        [PropertyName("Zero Pixel Location")]
        [PropertyDescription("Zero Pixel Location")]
        [PropertyType(typeof(int))]
        ZeroPixelLocation,

        [PropertyName("Scan Direction")]
        [PropertyDescription("Scan Direction")]
        [PropertyType(typeof(string))]
        ScanDirection,

        [PropertyName("Standalone Projector")]
        [PropertyDescription("Standalone Projector")]
        [PropertyType(typeof(bool))]
        StandaloneProjector,

        [PropertyName("Default Color/Luminance Decoding")]
        [PropertyDescription("Default Color/Luminance Decoding")]
        [PropertyType(typeof(bool))]
        DefaultColorLuminanceDecoding,

        [PropertyName("Preferred Color/Luminance Decoding")]
        [PropertyDescription("Preferred Color/Luminance Decoding")]
        [PropertyType(typeof(bool))]
        PreferredColorLuminanceDecoder,

        [PropertyName("Color/Luminance Decoding Capabilities")]
        [PropertyDescription("Color/Luminance Decoding Capabilities")]
        [PropertyType(typeof(string[]))]
        ColorLuminanceDecodingCapabilities,

        [PropertyName("Dithering")]
        [PropertyDescription("Dithering")]
        [PropertyType(typeof(bool))]
        Dithering,

        [PropertyName("Supported Color Bit-Depth of Sub-Channel 0 (Blue)")]
        [PropertyDescription("Supported Color Bit-Depth of Sub-Channel 0 (Blue)")]
        [PropertyType(typeof(bool))]
        SupportedColorBitDepthSubChannel0Blue,

        [PropertyName("Supported Color Bit-Depth of Sub-Channel 1 (Green)")]
        [PropertyDescription("Supported Color Bit-Depth of Sub-Channel 1 (Green)")]
        [PropertyType(typeof(bool))]
        SupportedColorBitDepthSubChannel1Green,

        [PropertyName("Supported Color Bit-Depth of Sub-Channel 2 (Red)")]
        [PropertyDescription("Supported Color Bit-Depth of Sub-Channel 2 (Red)")]
        [PropertyType(typeof(bool))]
        SupportedColorBitDepthSubChannel2Red,

        [PropertyName("Supported Color Bit-Depth of Sub-Channel 0 (Cb/Pb)")]
        [PropertyDescription("Supported Color Bit-Depth of Sub-Channel 0 (Cb/Pb)")]
        [PropertyType(typeof(bool))]
        SupportedColorBitDepthSubChannel0CbPb,

        [PropertyName("Supported Color Bit-Depth of Sub-Channel 1 (Y)")]
        [PropertyDescription("Supported Color Bit-Depth of Sub-Channel 1 (Y)")]
        [PropertyType(typeof(bool))]
        SupportedColorBitDepthSubChannel1Y,

        [PropertyName("Supported Color Bit-Depth of Sub-Channel 2 (Cr/Pr)")]
        [PropertyDescription("Supported Color Bit-Depth of Sub-Channel 2 (Cr/Pr)")]
        [PropertyType(typeof(bool))]
        SupportedColorBitDepthSubChannel2CrPr,

        [PropertyName("Aspect Ratio Conversion Modes")]
        [PropertyDescription("Aspect Ratio Conversion Modes")]
        [PropertyType(typeof(string))]
        AspectRatioConversionModes,

        [PropertyName("Packetized Digital Video Support Information")]
        [PropertyDescription("Packetized Digital Video Support Information")]
        [PropertyType(typeof(ReadOnlyCollection<byte>))]
        PacketizedDigitalVideoSupportInformation
    }
    #endregion

    #region [public] (enum) UnusedBytes: Definition of properties for a section of type 'UnusedBytes'
    /// <summary>
    /// Definition of properties for a section of type <see cref="DiSection.UnusedBytes"/>.
    /// </summary>
    public enum UnusedBytes
    {
        [PropertyName("Reserved Bytes")]
        [PropertyDescription("Reserved Bytes")]
        [PropertyType(typeof(ReadOnlyCollection<byte>))]
        Data
    }
    #endregion

    #region [public] (enum) AudioSupport: Definition of properties for a section of type 'AudioSupport'
    /// <summary>
    /// Definition of properties for a section of type <see cref="DiSection.AudioSupport"/>.
    /// </summary>
    public enum AudioSupport
    {
        [PropertyName("Types & Definitions of Audio Supported by the Monitor/Display")]
        [PropertyDescription("Types & Definitions of Audio Supported by the Monitor/Display")]
        [PropertyType(typeof(ReadOnlyCollection<byte>))]
        Data
    }
    #endregion

    #region [public] (enum) DisplayTransferCharacteristic: Definition of properties for a section of type 'DisplayTransferCharacteristic'
    /// <summary>
    /// Definition of properties for a section of type <see cref="DiSection.DisplayTransferCharacteristic"/>.
    /// </summary>
    public enum DisplayTransferCharacteristic
    {
        [PropertyName("Combined (White) or Separate (RGB) Sub-Channels")]
        [PropertyDescription("Combined (White) or Separate (RGB) Sub-Channels")]
        [PropertyType(typeof(string))]
        Status,

        [PropertyName("Number of Luminance Entries")]
        [PropertyDescription("Number of Luminance Entries")]
        [PropertyType(typeof(byte))]
        NumberLuminanceEntries,
    }
    #endregion


    #region [public] (class) DiMiscellaneous: Definition of properties for a section of type 'Miscellaneous'
    /// <summary>
    /// Definition of properties for a section of type <see cref="DiSection.Miscellaneous"/>.
    /// </summary>
    public static class Miscellaneous
    {
        /// <summary>
        /// Definition of properties for a Checksum section.
        /// </summary>
        public enum Checksum
        {
            [PropertyName("Status")]
            [PropertyDescription("Status")]
            [PropertyType(typeof(bool))]
            Ok,

            [PropertyDescription("Checksum datablock value")]
            [PropertyType(typeof(byte))]
            [PropertyName("Value")]
            Value
        }
    }
    #endregion
}
