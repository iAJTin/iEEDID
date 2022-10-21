
using System.Collections.Generic;
using System.Drawing;

using iTin.Core.Hardware.Common;

using iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks;
using iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel;

namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId
{
    /// <summary>
    /// Contains all availables section properties for a <see cref="DisplayIdBlock"/> block.
    /// </summary>
    internal static class DisplayIdProperty
    {
        #region [public] {static} (class) General: Definition of properties for a section of type 'General'
        /// <summary>
        /// Definition of properties for a section of type <see cref="DisplayIdSection.General"/>.
        /// </summary>
        public static class General
        {
            /// <summary>
            /// Definition of properties for a <b>Data</b> section.
            /// </summary>
            public enum Data
            {
                [PropertyName("Display Product")]
                [PropertyDescription("Display Product Type Identifier")]
                [PropertyType(typeof(string))]
                DisplayProduct,

                [PropertyName("Extension Count")]
                [PropertyDescription("Extension Count")]
                [PropertyType(typeof(byte))]
                ExtensionCount
            }

            /// <summary>
            /// Definition of properties for a <b>Version</b> section.
            /// </summary>
            public enum Version
            {
                [PropertyName("Version Number")]
                [PropertyDescription("The Version Number for the DisplayID Block Data Structure")]
                [PropertyType(typeof(byte))]
                Number,

                [PropertyName("Version Revision")]
                [PropertyDescription("The Revision Number for the DisplayID Block Data Structure")]
                [PropertyType(typeof(byte))]
                Revision,
            }
        }
        #endregion

        #region [public] {static} (class) DataBlocks: Definition of properties for a section of type 'Data Blocks'
        /// <summary>
        /// Definition of properties for a section of type <see cref="DisplayIdSection.DataBlocks"/>.
        /// </summary>
        public static class DataBlocks
        {
            /// <summary>
            /// Definition of properties for a <b>Data Blocks</b> section.
            /// </summary>
            public enum Implemented
            {
                [PropertyName("Implemented Blocks")]
                [PropertyDescription("DImplemented Blocks")]
                [PropertyType(typeof(IEnumerable<DataBlockData>))]
                ImplementedBlocks
            }

            /// <summary>
            /// Definition of properties for a known data blocks.
            /// </summary>
            public static class Blocks
            {
                /// <summary>
                /// Definition of data block identifiers.
                /// </summary>
                public enum Identifier
                {
                    [PropertyName("Container ID")]
                    [PropertyDescription("Container ID")]
                    [PropertyType(typeof(ContainerIdDataBlock))]
                    ContainerID,

                    [PropertyName("Detailed Timing Type I")]
                    [PropertyDescription("Detailed Timing Type I")]
                    [PropertyType(typeof(DetailedTimingTypeIDataBlock))]
                    DetailedTimingTypeI,

                    [PropertyName("Product Identification")]
                    [PropertyDescription("Product Identification")]
                    [PropertyType(typeof(ProductIdentificationDataBlock))]
                    ProductIdentification,

                    [PropertyName("Display Parameters")]
                    [PropertyDescription("Display Parameters")]
                    [PropertyType(typeof(DisplayParametersDataBlock))]
                    DisplayParameters,

                    [PropertyName("Dynamic Video Timing Range Limits")]
                    [PropertyDescription("Dynamic Video Timing Range Limits")]
                    [PropertyType(typeof(DynamicVideoTimingRangeLimitsDataBlock))]
                    DynamicVideoTimingRangeLimits,

                    [PropertyName("Vendor Specific")]
                    [PropertyDescription("Vendor Specific")]
                    [PropertyType(typeof(VendorSpecificDataBlock))]
                    VendorSpecific,
                }


                /// <summary>
                /// Definition of properties for a <b>Detailed Timing Type I</b> data block.
                /// </summary>
                public static class DetailedTimingTypeI
                {
                    /// <summary>
                    /// Definition of properties for a <b>General</b>.
                    /// </summary>
                    public enum General
                    {
                        [PropertyName("Timings")]
                        [PropertyDescription("Timings")]
                        [PropertyType(typeof(IEnumerable<DetailedTimingTypeIData>))]
                        Timings,
                    }

                    /// <summary>
                    /// Definition of properties for a <b>Detailed Timing Type I Item</b>.
                    /// </summary>
                    public enum Timing
                    {
                        [PropertyName("Pixel Clock")]
                        [PropertyDescription("Pixel Clock")]
                        [PropertyType(typeof(int))]
                        PixelClock,

                        [PropertyName("Aspect Ratio")]
                        [PropertyDescription("Aspect Ratio")]
                        [PropertyType(typeof(string))]
                        AspectRatio,

                        [PropertyName("Interface Frame Scanning Type")]
                        [PropertyDescription("Interface Frame Scanning Type")]
                        [PropertyType(typeof(string))]
                        InterfaceFrameScanningType,

                        [PropertyName("3D Stereo Support")]
                        [PropertyDescription("3D Stereo Support")]
                        [PropertyType(typeof(string))]
                        Stereo3DSupport,

                        [PropertyName("Preferred Detailed Timing")]
                        [PropertyDescription("Is Preferred Detailed Timing")]
                        [PropertyType(typeof(bool))]
                        IsPreferredTiming,

                        [PropertyName("Horizontal Active Image")]
                        [PropertyDescription("Horizontal Active Image")]
                        [PropertyType(typeof(int))]
                        HorizontalActiveImage,

                        [PropertyName("Horizontal Blank Pixels")]
                        [PropertyDescription("Horizontal Blank Pixels")]
                        [PropertyType(typeof(int))]
                        HorizontalBlankPixels,

                        [PropertyName("Horizontal Front Porch Offset")]
                        [PropertyDescription("Horizontal Front Porch Offset")]
                        [PropertyType(typeof(int))]
                        HorizontalFrontPorchOffset,

                        [PropertyName("Horizontal Sync Polarity")]
                        [PropertyDescription("Horizontal Sync Polarity")]
                        [PropertyType(typeof(string))]
                        HorizontalSyncPolarity,
                        
                        [PropertyName("Horizontal Sync Width")]
                        [PropertyDescription("Horizontal Sync Width")]
                        [PropertyType(typeof(int))]
                        HorizontalSyncWidth,

                        [PropertyName("Vertical Active Image")]
                        [PropertyDescription("Vertical Active Image")]
                        [PropertyType(typeof(int))]
                        VerticalActiveImage,

                        [PropertyName("Vertical Blank Lines")]
                        [PropertyDescription("Vertical Blank Lines")]
                        [PropertyType(typeof(int))]
                        VerticalBlankLines,

                        [PropertyName("Vertical Sync Front Porch Offset")]
                        [PropertyDescription("Vertical Sync Front Porch Offset")]
                        [PropertyType(typeof(int))]
                        VerticalSyncFrontPorchOffset,

                        [PropertyName("Vertical Sync Polarity")]
                        [PropertyDescription("Vertical Sync Polarity")]
                        [PropertyType(typeof(int))]
                        VerticalSyncPolarity,

                        [PropertyName("Vertical Sync Width")]
                        [PropertyDescription("Vertical Sync Width")]
                        [PropertyType(typeof(int))]
                        VerticalSyncWidth,
                    }
                }

                /// <summary>
                /// Definition of properties for a <b>Product Identification</b> data block.
                /// </summary>
                public enum ProductIdentification
                {
                    [PropertyName("Manufacturer")]
                    [PropertyDescription("Manufacturer/Vendor ID")]
                    [PropertyType(typeof(string))]
                    Manufacturer,

                    [PropertyName("Product Id")]
                    [PropertyDescription("Product Id Code")]
                    [PropertyType(typeof(int))]
                    ProductIdCode,

                    [PropertyName("Serial Number")]
                    [PropertyDescription("Serial Number")]
                    [PropertyType(typeof(int))]
                    SerialNumber,

                    [PropertyDescription("Week Of Manufacture Or Model Tag")]
                    [PropertyType(typeof(byte?))]
                    [PropertyName("Week Of Manufacture Or Model Tag")]
                    WeekOfManufactureOrModelTag,

                    [PropertyDescription("Year Of Manufacture Or Model Year")]
                    [PropertyType(typeof(byte?))]
                    [PropertyName("Year Of Manufacture Or Model Year")]
                    YearOfManufactureOrModelYear,

                    [PropertyDescription("Manufacturer Date")]
                    [PropertyType(typeof(string))]
                    [PropertyName("Manufacturer Date")]
                    ManufactureDate,

                    [PropertyDescription("Model Year Strategy")]
                    [PropertyType(typeof(KnownModelYearStrategy))]
                    [PropertyName("Model Year")]
                    ModelYearStrategy,

                    [PropertyName("Product Name")]
                    [PropertyDescription("Product Name")]
                    [PropertyType(typeof(string))]
                    ProductName,
                }

                /// <summary>
                /// Definition of properties for a <b>Display Parameters</b> data block.
                /// </summary>
                public static class DisplayParameters
                {
                    /// <summary>
                    /// Definition of common properties for a <b>Display Parameters</b> data block.
                    /// </summary>
                    public enum Common
                    {
                        [PropertyName("Horizontal Image Size")]
                        [PropertyDescription("Horizontal Image Size")]
                        [PropertyType(typeof(int))]
                        HorizontalImageSize,

                        [PropertyName("Vertical Image Size")]
                        [PropertyDescription("Vertical Image Size")]
                        [PropertyType(typeof(int))]
                        VerticalImageSize,

                        [PropertyName("Horizontal Pixel Count")]
                        [PropertyDescription("Horizontal Pixel Count")]
                        [PropertyType(typeof(int))]
                        HorizontalPixelCount,

                        [PropertyName("Vertical Pixel Count")]
                        [PropertyDescription("Vertical Pixel Count")]
                        [PropertyType(typeof(int))]
                        VerticalPixelCount,

                        [PropertyName("Gamma")]
                        [PropertyDescription("Gamma Value")]
                        [PropertyType(typeof(double))]
                        Gamma,

                        [PropertyName("Aspect Ratio")]
                        [PropertyDescription("Aspect Ratio")]
                        [PropertyType(typeof(double))]
                        AspectRatio,

                        [PropertyName("Display Overall Color Bit Depth")]
                        [PropertyDescription("Indicate the dynamic range, in bits/color, provided by the display overall")]
                        [PropertyType(typeof(double))]
                        DisplayOverallColorBitDepth,

                        [PropertyName("Display Device Color Bit Depth")]
                        [PropertyDescription("Indicate the dynamic range provided by the display device (transducer)")]
                        [PropertyType(typeof(double))]
                        DisplayDeviceColorBitDepth,

                        [PropertyName("Primary Color 1")]
                        [PropertyDescription("Primary Color 1")]
                        [PropertyType(typeof(PointF))]
                        PrimaryColor1,

                        [PropertyName("Primary Color 2")]
                        [PropertyDescription("Primary Color 2")]
                        [PropertyType(typeof(PointF))]
                        PrimaryColor2,

                        [PropertyName("Primary Color 3")]
                        [PropertyDescription("Primary Color 3")]
                        [PropertyType(typeof(PointF))]
                        PrimaryColor3,

                        [PropertyName("White Point")]
                        [PropertyDescription("White Point")]
                        [PropertyType(typeof(PointF))]
                        WhitePoint,

                        [PropertyName("Native Maximum Luninance Full Coverage")]
                        [PropertyDescription("Native maximum luminance, in candela per square meter (cd/m2), that shall be physically possible to attain on the display with all pixels programmed to maximum code)")]
                        [PropertyType(typeof(float))]
                        NativeMaximumLuninanceFullCoverage,
                        
                        [PropertyName("Native Maximum Luninance Rectangular Coverage")]
                        [PropertyDescription("Native maximum luminance, in candela per square meter (cd/m2), that shall be physically possible to attain on the display with a 10% rectangular patch programmed to maximum code in the middle of the screen")]
                        [PropertyType(typeof(float))]
                        NativeMaximumLuninanceRectangularCoverage,

                        [PropertyName("Native MinimumLun Luninance")]
                        [PropertyDescription("Native minimum luminance, in candela per square meter (cd/m2), that shall be physically possible to attain on the display")]
                        [PropertyType(typeof(float))]
                        NativeMinimumLuninance,

                        [PropertyName("Native Color Depth")]
                        [PropertyDescription("Native Color Depth. Ability to use all available bits per component(bpc) for display output rendering")]
                        [PropertyType(typeof(string))]
                        NativeColorDepth,

                        [PropertyName("Display Device Technology")]
                        [PropertyDescription("Describes the technology used by the display device’s 'glass'")]
                        [PropertyType(typeof(string))]
                        DisplayDeviceTechnology
                    }

                    /// <summary>
                    /// Definition of properties for a <b>Features</b> data block section.
                    /// </summary>
                    public enum Features
                    {
                        [PropertyName("Audio Support On Video Interface")]
                        [PropertyDescription("Determines if audio is supported on the video interface")]
                        [PropertyType(typeof(bool))]
                        AudioSupportOnVideoInterface,

                        [PropertyName("Separate Audio Inputs")]
                        [PropertyDescription("Determines if audio inputs are provided separately from the video interface")]
                        [PropertyType(typeof(bool))]
                        SeparateAudioInputs,

                        [PropertyName("Separate Audio Inputs")]
                        [PropertyDescription("Determines if audio information received via the video interface structure will automatically override any other audio input channels provided and will be routed to the appropriate audio output devices or connectors")]
                        [PropertyType(typeof(bool))]
                        AudioInputOverride,

                        [PropertyName("Power Management")]
                        [PropertyDescription("Determines if the display supports the VESA Display Power Management(DPM) standard")]
                        [PropertyType(typeof(bool))]
                        VesaPowerManagementSupported,

                        [PropertyName("Fixed Timing")]
                        [PropertyDescription("This property shall always be set to true when the display is capable of only a single fixed timing")]
                        [PropertyType(typeof(bool))]
                        FixedTiming,

                        [PropertyName("Fixed Pixel Format")]
                        [PropertyDescription("This property shall always be set to true when the display is capable of supporting timings at only a single fixed pixel format as detailed in the Horizontal and Vertical pixel counts within this block")]
                        [PropertyType(typeof(bool))]
                        FixedPixelFormat,

                        [PropertyName("Support AI")]
                        [PropertyDescription("This property shall always be set to true when supports and processes ACP, ISRC1 or ISRC2packets")]
                        [PropertyType(typeof(bool))]
                        SupportAI,

                        [PropertyName("De-Interlacing")]
                        [PropertyDescription("Determines if the display by default will de-interlace any interlaced video input and display it in a progressive-scan format")]
                        [PropertyType(typeof(bool))]
                        DeInterlacing,


                        [PropertyName("Scan Orientation")]
                        [PropertyDescription("Scan Orientation with respect to normal viewing position")]
                        [PropertyType(typeof(string))]
                        ScanOrientation,

                        [PropertyName("Luminance Information")]
                        [PropertyDescription("Luminance Information")]
                        [PropertyType(typeof(string))]
                        LuminanceInformation,

                        [PropertyName("Color Information")]
                        [PropertyDescription("Color Information provided int terms of CIE 1931 or CIE 1976")]
                        [PropertyType(typeof(bool))]
                        ColorInformationCie1931,

                        [PropertyName("Audio Speakers Integrated")]
                        [PropertyDescription("Determines if the audio speakers integrated into the display")]
                        [PropertyType(typeof(bool))]
                        AudioSpeakersIntegrated
                    }
                }

                /// <summary>
                /// Definition of properties for a <b>Dynamic Video Timing Range Limits</b> data block.
                /// </summary>
                public enum DynamicVideoTimingRangeLimits
                {
                    [PropertyName("Minimum Pixel Clock")]
                    [PropertyDescription("Minimum Pixel Clock")]
                    [PropertyType(typeof(int))]
                    MinimumPixelClock,

                    [PropertyName("Maximum Pixel Clock")]
                    [PropertyDescription("Maximum Pixel Clock")]
                    [PropertyType(typeof(int))]
                    MaximumPixelClock,

                    [PropertyName("Minimum Vertical Refresh Rate")]
                    [PropertyDescription("Minimum Vertical Refresh Rate")]
                    [PropertyType(typeof(byte))]
                    MinimumVerticalRefreshRate,

                    [PropertyName("Maximum Vertical Refresh Rate")]
                    [PropertyDescription("Maximum Vertical Refresh Rate")]
                    [PropertyType(typeof(byte))]
                    MaximumVerticalRefreshRate,

                    [PropertyName("Seamless Dynamic Video Timing Support")]
                    [PropertyDescription("Seamless Dynamic Video Timing Support")]
                    [PropertyType(typeof(bool))]
                    SupportSeamlessDynamicVideoTiming
                }

                /// <summary>
                /// Definition of properties for a <b>ContainerID</b> data block.
                /// </summary>
                public enum ContainerID
                {
                    [PropertyName("UUID")]
                    [PropertyDescription("16-byte Universally Unique Identifier (UUID)")]
                    [PropertyType(typeof(string))]
                    UUID
                }

                /// <summary>
                /// Definition of properties for a <b>Vendor Specific</b> data block.
                /// </summary>
                public enum VendorSpecific
                {
                    [PropertyName("Vendor-Specific data")]
                    [PropertyDescription("Vendor-Specific data")]
                    [PropertyType(typeof(IEnumerable<byte>))]
                    Data,

                    [PropertyName("Manufacturer")]
                    [PropertyDescription("Manufacturer/Vendor ID")]
                    [PropertyType(typeof(string))]
                    Manufacturer
                }
            }
        }
        #endregion

        #region [public] {static} (class) Miscellaneous: Definition of properties for a section of type 'Miscellaneous'
        /// <summary>
        /// Definition of properties for a section of type <see cref="DisplayIdSection.Miscellaneous"/>.
        /// </summary>
        public static class Miscellaneous
        {
            /// <summary>
            /// Definition of properties for a <b>CheckSum</b> section.
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
}
