
namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId
{
    using System.Collections.Generic;

    using iTin.Core.Hardware.Common;

    using Sections.DataBlocks;
    using Sections.DataBlocks.ComponentModel;

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
                    [PropertyName("Detailed Timing Type I")]
                    [PropertyDescription("Detailed Timing Type I")]
                    [PropertyType(typeof(DetailedTimingTypeIDataBlock))]
                    DetailedTimingTypeI,

                    [PropertyName("Product Identification")]
                    [PropertyDescription("Product Identification")]
                    [PropertyType(typeof(ProductIdentificationDataBlock))]
                    ProductIdentification,

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
