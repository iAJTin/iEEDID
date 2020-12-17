﻿
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;

    using iTin.Core.Hardware.Common;

    #region EEDID -> EDID

    #region [internal] (enum) EdidHeaderProperty: Definition of properties for a section of type 'Header'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.Header"/>.
    /// </summary>
    internal enum EdidHeaderProperty
    {
        [PropertyName("Signature")]
        [PropertyType(typeof(ReadOnlyCollection<byte>))]
        [PropertyDescription("Header identifying the EDID block")]
        Signature,

        [PropertyType(typeof(bool))]
        [PropertyName("Is Valid")]
        [PropertyDescription("Indicates if the header is the expected one")]
        IsValid,
    }
    #endregion

    #region [internal] (enum) EdidVendorProperty: Definition of properties for a section of type 'Vendor'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.Vendor"/>.
    /// </summary>
    internal enum EdidVendorProperty
    {
        [PropertyType(typeof(string))]
        [PropertyDescription("")]
        [PropertyName("Manufacturer Name")]
        IdManufacturerName,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        [PropertyName("Product Code")]
        IdProductCode,

        [PropertyDescription("")]
        [PropertyType(typeof(int?))]
        [PropertyName("Serial Number")]
        IdSerialNumber,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        [PropertyName("Week Of Manufacture Or Model Year Flag")]
        WeekOfManufactureOrModelYear,

        [PropertyDescription("")]
        [PropertyType(typeof(byte?))]
        [PropertyName("Year Of Manufacture Or Model Year")]
        YearOfManufactureOrModelYear,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        [PropertyName("Manufacturer Date")]
        ManufactureDate,

        [PropertyDescription("")]
        [PropertyType(typeof(KnownModelYearStrategy))]
        [PropertyName("Model Year")]
        ModelYearStrategy,
    }
    #endregion

    #region [internal] (enum) EdidVersionProperty: Definition of properties for a section of type 'Version'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.Version"/>.
    /// </summary>
    internal enum EdidVersionProperty
    {
        [PropertyType(typeof(byte))]
        [PropertyName("Version")]
        [PropertyDescription("")]
        Version,

        [PropertyName("Revision")]
        [PropertyType(typeof(byte))]
        [PropertyDescription("")]
        Revision,
    }
    #endregion

    #region [internal] (enum) EdidBasicDisplayProperty: Definition of properties for a section of type 'Basic Display'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.BasicDisplay"/>.
    /// </summary>
    internal enum EdidBasicDisplayProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        [PropertyName("Video Input Definition")]
        VideoInputDefinition,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        [PropertyName("Analog Signal Level")]
        AnalogSignalLevelStandard,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        [PropertyName("Analog Signal Setup")]
        AnalogVideoSetup,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        [PropertyName("Analog Separated Sync Supported")]
        AnalogSeparateSyncSupported,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        [PropertyName("Analog Composite Sync Signal Horizontal Supported")]
        AnalogCompositeSyncSignalHorizontalSupported,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        [PropertyName("Analog Composite Sync Signal Green Video Supported")]
        AnalogCompositeSyncSignalGreenVideoSupported,

        [PropertyDescription("Analog Vertical Sync Supported")]
        [PropertyType(typeof(bool))]
        [PropertyName("Analog Vertical Sync Supported")]
        AnalogVerticalSyncSupported,

        [PropertyDescription("Digital Color Bit Depth")]
        [PropertyType(typeof(string))]
        [PropertyName("Digital Color Bit Depth")]
        DigitalColorBitDepth,

        [PropertyDescription("Digital Video Interface")]
        [PropertyType(typeof(string))]
        [PropertyName("Video Interface")]
        DigitalVideoInterface,

        [PropertyDescription("Horizontal Screen Size")]
        [PropertyType(typeof(byte))]
        [PropertyName("Horizontal Screen Size")]
        HorizontalScreenSize,

        [PropertyDescription("Vertical screen size")]
        [PropertyType(typeof(byte))]
        [PropertyName("Vertical Screen Size")]
        VerticalScreenSize,

        [PropertyDescription("The display transfer characteristic")]
        [PropertyType(typeof(double?))]
        [PropertyName("Gamma")]
        Gamma,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        [PropertyName("Standby Mode Supported")]
        StandbyModeSupported,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        [PropertyName("Suspend Mode Supported")]
        SuspendModeSupported,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        [PropertyName("Active Off Supported")]
        ActiveOffSupported,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        [PropertyName("Analog Display Color Type")]
        AnalogDisplayColorType,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        [PropertyName("Digital Color Encoding Format")]
        DigitalColorEncodingFormat,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        [PropertyName("Srgb Default Color Space")]
        SrgbDefaultColorSpace,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        [PropertyName("Preferred Timing Mode")]
        PreferredTimingMode,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        [PropertyName("Continuous Frequency")]
        ContinuousFrequency,
    }
    #endregion

    #region [internal] (enum) EdidColorCharacteristicsProperty: Definition of properties for a section of type 'Color Characteristics'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.ColorCharacteristics"/>.
    /// </summary>
    internal enum EdidColorCharacteristicsProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(PointF))]
        [PropertyName("White")]
        White,

        [PropertyDescription("")]
        [PropertyType(typeof(PointF))]
        [PropertyName("Red")]
        Red,

        [PropertyDescription("")]
        [PropertyType(typeof(PointF))]
        [PropertyName("Blue")]
        Blue,

        [PropertyDescription("")]
        [PropertyType(typeof(PointF))]
        [PropertyName("Green")]
        Green,
    }
    #endregion

    #region [internal] (enum) EdidEstablishedTimingsProperty: Definition of properties for a section of type 'Established Timings'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.EstablishedTimings"/>.
    /// </summary>
    internal enum EdidEstablishedTimingsProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<MonitorResolutionInfo>))]
        [PropertyName("Resolutions")]
        Resolutions,
    }
    #endregion

    #region [internal] (enum) EdidStandardTimingProperty: Definition of properties for a section of type 'Standard Timings'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.StandardTimings"/>.
    /// </summary>
    internal enum EdidStandardTimingProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 1")]
        Timing1,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 2")]
        Timing2,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 3")]
        Timing3,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 4")]
        Timing4,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 5")]
        Timing5,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 6")]
        Timing6,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 7")]
        Timing7,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 8")]
        Timing8,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 9")]
        Timing9,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 10")]
        Timing10,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 11")]
        Timing11,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 12")]
        Timing12,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 13")]
        Timing13,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 14")]
        Timing14,
    }
    #endregion

    #region [internal] (enum) EdidDataBlockProperty: Definition of properties for a section of type 'Data Blocks'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.DataBlocks"/>.
    /// </summary>
    internal enum EdidDataBlockProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>))]
        [PropertyName("Descriptor 1")]
        Descriptor1,

        [PropertyDescription("")]
        [PropertyType(typeof(KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>))]
        [PropertyName("Descriptor 2")]
        Descriptor2,

        [PropertyDescription("")]
        [PropertyType(typeof(KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>))]
        [PropertyName("Descriptor 3")]
        Descriptor3,

        [PropertyDescription("")]
        [PropertyType(typeof(KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>))]
        [PropertyName("Descriptor 4")]
        Descriptor4,
    }
    #endregion

    #region [internal] (enum) EdidExtensionBlocksProperty: Definition of properties for a section of type 'Extension Blocks'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.ExtensionBlocks"/>.
    /// </summary>
    internal enum EdidExtensionBlocksProperty
    {
        [PropertyType(typeof(byte))]
        [PropertyDescription("Number of extension blocks available")]
        [PropertyName("Count")]
        Count,

        [PropertyType(typeof(bool))]
        [PropertyDescription("Indicates if there are extension blocks available")]
        [PropertyName("Has Blocks")]
        HasBlocks,
    }
    #endregion

    #region [internal] (enum) EdidCheckSumProperty: Definition of properties for a section of type 'CheckSum'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.CheckSum"/>.
    /// </summary>
    internal enum EdidCheckSumProperty
    {
        [PropertyDescription("Status")]
        [PropertyType(typeof(bool))]
        [PropertyName("Ok")]
        Ok,

        [PropertyDescription("Checksum datablock value")]
        [PropertyType(typeof(bool))]
        [PropertyName("Value")]
        Value,
    }
    #endregion

    #endregion

    #region EEDID -> EDID -> Sections

    #region Data Blocks

    #region Descriptors

    #region [public] (enum) EdidDataBlockDescriptor: Definition of types of possible descriptors for a 'DataBlock' block
    /// <summary>
    /// Definition of types of possible descriptors for a <see cref="KnownEdidSection.DataBlocks"/> block.
    /// </summary>
    public enum EdidDataBlockDescriptor
    {
        /// <summary>
        /// Descriptor <b>Detailed Timing</b>, for more information see <see cref ="DetailedTimingModeDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(DetailedTimingModeDescriptor))]
        [PropertyName("Detailed Timing Mode")]
        [PropertyDescription("Detailed Timing Descriptor")]
        DetailedTimingMode = -1,

        /// <summary>
        /// Descriptor <b>Display Product Serial Number</b>, for more information see <see cref ="DisplayProductSerialNumberDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(DisplayProductSerialNumberDescriptor))]
        [PropertyName("Display Product Serial Number")]
        [PropertyDescription("Display Product Serial Number Descriptor")]
        DisplayProductSerialNumber = 0xff,

        /// <summary>
        /// Descriptor <b>AlphaNumeric Data String</b>, for more information see <see cref ="AlphaNumericDataStringDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(AlphaNumericDataStringDescriptor))]
        [PropertyName("AlphaNumeric Data String")]
        [PropertyDescription("AlphaNumeric Data String Descriptor")]
        AlphaNumericDataString = 0xfe,

        /// <summary>
        /// Descriptor <b>Display Range Limits</b>, for more information see <see cref ="DisplayRangeLimitsDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(DisplayRangeLimitsDescriptor))]
        [PropertyName("Display Range Limits")]
        [PropertyDescription("Display Range Limits Descriptor")]
        DisplayRangeLimits = 0xfd,

        /// <summary>
        /// Descriptor <b>Display Product Name</b>, for more information see <see cref ="DisplayProductNameDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(DisplayProductNameDescriptor))]
        [PropertyName("Display Product Name")]
        [PropertyDescription("Display Product Name Descriptor")]
        DisplayProductName = 0xfc,

        /// <summary>
        /// Descriptor <b>Color Point Data</b>, for more information see <see cref ="ColorPointDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ColorPointDataDescriptor))]
        [PropertyName("Color Point Data")]
        [PropertyDescription("Color Point Data Descriptor")]
        ColorPointData = 0xfb,

        /// <summary>
        /// Descriptor <b>Standard Timing Identifier</b>, for more information see <see cref ="StandardTimingIdentifier"/>.
        /// </summary>
        [PropertyType(typeof(StandardTimingIdentifierDescriptor))]
        [PropertyName("Standard Timing Identifier")]
        [PropertyDescription("Standard Timing Identifier Descriptor")]
        StandardTimingIdentifier = 0xfa,

        /// <summary>
        /// Descriptor <b>Color Management Data</b>, for more information see <see cref ="ColorManagementDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ColorManagementDataDescriptor))]
        [PropertyName("Color Management Data")]
        [PropertyDescription("Color Management Data Descriptor")]
        ColorManagementData = 0xf9,

        /// <summary>
        /// Descriptor <b>CVT 3 Bytes Timing Codes</b>, for more information see <see cref ="Cvt3ByteCodeDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(Cvt3ByteCodeDescriptor))]
        [PropertyName("CVT 3 Byte Code")]
        [PropertyDescription("CVT 3 Bytes Timing Codes")]
        Cvt3ByteCode = 0xf8,

        /// <summary>
        /// Descriptor <b>Established Timings III</b>, for more information see <see cref ="EstablishedTimingsIIIDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(EstablishedTimingsIIIDescriptor))]
        [PropertyName("Established Timings III")]
        [PropertyDescription("Established Timings III")]
        EstablishedTimingsIII = 0xf7,

        /// <summary>
        /// Descriptor <b>Dummy Data Descriptor</b>, for more information see <see cref ="DummyDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(DummyDataDescriptor))]
        [PropertyName("Dummy Data")]
        [PropertyDescription("Dummy Data Descriptor")]
        DummyData = 0x10,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData15 = 0x0f,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData14 = 0x0e,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData13 = 0x0d,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData12 = 0x0c,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData11 = 0x0b,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData10 = 0x0a,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData09 = 0x09,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData08 = 0x08,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData07 = 0x07,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData06 = 0x06,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData05 = 0x05,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData04 = 0x04,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData03 = 0x03,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData02 = 0x02,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData01 = 0x01,

        /// <summary>
        /// Descriptor <b>Manufacturer Specified Data</b>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [PropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [PropertyName("Manufacturer Specified Data")]
        [PropertyDescription("Manufacturer Specified Data")]
        ManufacturerSpecifiedData00 = 0x00,

        /// <summary>
        /// Descriptor <b>Reserved</b>, for more information see
        /// </summary>
        [PropertyName("Reserved")]
        [PropertyDescription("Reserved")]
        Reserved = -2,
    }
    #endregion

    #endregion

    #region Definitions

    #region [internal] (enum) KnownAlphanumericDataStringDescriptorProperty: Definition of properties for a type descriptor 'AlphanumericDataString'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="EdidDataBlockDescriptor.AlphaNumericDataString"/>.
    /// </summary>
    internal enum AlphanumericDataStringDescriptorProperty
    {
        [PropertyType(typeof(string))]
        [PropertyName("Text")]
        [PropertyDescription("")] 
        Text,
    }
    #endregion

    #region [internal] (enum) ColorManagementDataDescriptorProperty: Definition of properties for a type descriptor 'ColorManagementData'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="EdidDataBlockDescriptor.ColorManagementData"/>.
    /// </summary>
    internal enum ColorManagementDataDescriptorProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        [PropertyName("Version")]
        Version,

        [PropertyDescription("")]
        [PropertyType(typeof(ColorManagementDataDescriptorItem))]
        [PropertyName("Red")]
        Red,

        [PropertyDescription("")]
        [PropertyType(typeof(ColorManagementDataDescriptorItem))]
        [PropertyName("Green")]
        Green,

        [PropertyDescription("")]
        [PropertyType(typeof(ColorManagementDataDescriptorItem))]
        [PropertyName("Blue")]
        Blue,
    }
    #endregion

    #region [internal] (enum) ColorPointDataDescriptorProperty: Definition of properties for a type descriptor 'ColorPointData'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="EdidDataBlockDescriptor.ColorPointData"/>.
    /// </summary>
    internal enum ColorPointDataDescriptorProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(ColorPointDataDescriptorItem))]
        [PropertyName("Point 1")]
        Point1,

        [PropertyDescription("")]
        [PropertyType(typeof(ColorPointDataDescriptorItem))]
        [PropertyName("Point 2")]
        Point2,
    }
    #endregion

    #region [internal] (enum) Cvt3ByteCodeDescriptorProperty: Definition of properties for a type descriptor 'Cvt3ByteCode'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/>.
    /// </summary>
    internal enum Cvt3ByteCodeDescriptorProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        [PropertyName("Version")]
        Version,

        [PropertyDescription("")]
        [PropertyType(typeof(Cvt3ByteCodeDescriptorItemProperty))]
        [PropertyName("Priority 1")]
        Priority1,

        [PropertyDescription("")]
        [PropertyType(typeof(Cvt3ByteCodeDescriptorItemProperty))]
        [PropertyName("Priority 2")]
        Priority2,

        [PropertyDescription("")]
        [PropertyType(typeof(Cvt3ByteCodeDescriptorItemProperty))]
        [PropertyName("Priority 3")]
        Priority3,

        [PropertyDescription("")]
        [PropertyType(typeof(Cvt3ByteCodeDescriptorItemProperty))]
        [PropertyName("Priority 4")]
        Priority4,
    }
    #endregion

    #region [internal] (enum) DetailedTimingModeDescriptorProperty: Definition of properties for a type descriptor 'DetailedTimingMode'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/>.
    /// </summary>
    internal enum DetailedTimingModeDescriptorProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        [PropertyName("Pixel Clock")]
        PixelClock,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        [PropertyName("Horizontal Resolution")]
        HorizontalResolution,

        [PropertyDescription("Horizontal Blanking")]
        [PropertyName("Horizontal Blanking")]
        [PropertyType(typeof(int))]
        HorizontalBlanking,

        [PropertyDescription("Vertical Lines")]
        [PropertyName("Vertical Lines")]
        [PropertyType(typeof(int))]
        VerticalLines,

        [PropertyDescription("Vertical Blanking")]
        [PropertyName("Vertical Blanking")]
        [PropertyType(typeof(int))]
        VerticalBlanking,

        [PropertyDescription("Horizontal Front Porch")]
        [PropertyName("Horizontal Front Porch")]
        [PropertyType(typeof(int))]
        HorizontalFrontPorch,

        [PropertyDescription("Horizontal Sync Pulse Width")]
        [PropertyName("Horizontal Sync Pulse Width")]
        [PropertyType(typeof(int))]
        HorizontalSyncPulseWidth,

        [PropertyDescription("")]
        [PropertyName("Vertical Front Porch")]
        [PropertyType(typeof(int))]
        VerticalFrontPorch,

        [PropertyDescription("Vertical Sync Pulse Width")]
        [PropertyName("Vertical Sync Pulse Width")]
        [PropertyType(typeof(int))]
        VerticalSyncPulseWidth,

        [PropertyDescription("Horizontal Image Size")]
        [PropertyName("Horizontal Image Size")]
        [PropertyType(typeof(int))]
        HorizontalImageSize,

        [PropertyDescription("Vertical Image Size")]
        [PropertyName("Vertical Image Size")]
        [PropertyType(typeof(int))]
        VerticalImageSize,

        [PropertyDescription("Horizontal Border")]
        [PropertyName("Horizontal Border")]
        [PropertyType(typeof(byte))]
        HorizontalBorder,

        [PropertyDescription("Vertical Border")]
        [PropertyName("Vertical Border")]
        [PropertyType(typeof(byte))]
        VerticalBorder,

        [PropertyDescription("Interlaced")]
        [PropertyName("Interlaced")]
        [PropertyType(typeof(bool))]
        Interlaced,

        [PropertyDescription("Stereo Viewing Support")]
        [PropertyName("Stereo Viewing Support")]
        [PropertyType(typeof(string))]
        StereoViewingSupport,

        [PropertyDescription("Sync Signal Type")]
        [PropertyName("Sync Signal Type")]
        [PropertyType(typeof(string))]
        SyncSignalType
    }
    #endregion

    #region [internal] (enum) DisplayProductNameDescriptorProperty: Definition of properties for a type descriptor 'DisplayProductName'.
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="EdidDataBlockDescriptor.DisplayProductName"/>.
    /// </summary>
    internal enum DisplayProductNameDescriptorProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        [PropertyName("Text")]
        Text,
    }
    #endregion

    #region [internal] (enum) DisplayProductSerialNumberDescriptorProperty: Definition of properties for a type descriptor 'DisplayProductSerialNumber'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="EdidDataBlockDescriptor.DisplayProductSerialNumber"/>.
    /// </summary>
    internal enum DisplayProductSerialNumberDescriptorProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        [PropertyName("Text")]
        Text,
    }
    #endregion

    #region [internal] (enum) DisplayRangeLimitsDescriptorProperty: Definition of properties for a type descriptor 'DisplayRangeLimits'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/>.
    /// </summary>
    internal enum DisplayRangeLimitsDescriptorProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        [PropertyName("Minimum Vertical Rate")]
        MinimumVerticalRate,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        [PropertyName("Maximum Vertical Rate")]
        MaximumVerticalRate,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        [PropertyName("Minimum Horizontal Rate")]
        MinimumHorizontalRate,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        [PropertyName("Maximum Horizontal Rate")]
        MaximumHorizontalRate,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        [PropertyName("Maximum Pixel Clock")]
        MaximumPixelClock,
    }
    #endregion

    #region [internal] (enum) DummyDataDescriptorProperty: Definition of properties for a type descriptor 'DummyData'.
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="EdidDataBlockDescriptor.DummyData"/>.
    /// </summary>
    internal enum DummyDataDescriptorProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        [PropertyName("Printable Data")]
        PrintableData,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        [PropertyName("Original Data")]
        OriginalData,
    }
    #endregion

    #region [internal] (enum) EstablishedTimingsIIIDescriptorProperty: Definition of properties for a type descriptor 'EstablishedTimingsIII'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="EdidDataBlockDescriptor.EstablishedTimingsIII"/>.
    /// </summary>
    internal enum EstablishedTimingsIIIDescriptorProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        [PropertyName("Revision")]
        Revision,

        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<MonitorResolutionInfo>))]
        [PropertyName("Resolutions")]
        Resolutions,
    }
    #endregion

    #region [internal] (enum) ManufacturerSpecifiedDataDescriptorProperty: Definition of properties for a type descriptor 'ManufacturerSpecifiedData'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="EdidDataBlockDescriptor.ManufacturerSpecifiedData"/>.
    /// </summary>
    internal enum ManufacturerSpecifiedDataDescriptorProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(ReadOnlyCollection<byte>))]
        [PropertyName("Data")]
        Data,
    }
    #endregion

    #region [internal] (enum) StandardTimingIdentifierDescriptorProperty: Definition of properties for a type descriptor 'StandardTimingIdentifier'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/>.
    /// </summary>
    internal enum StandardTimingIdentifierDescriptorProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 9")]
        Timing9,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 10")]
        Timing10,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 11")]
        Timing11,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 12")]
        Timing12,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 13")]
        Timing13,

        [PropertyDescription("")]
        [PropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        [PropertyName("Timing 14")]
        Timing14,
    }
    #endregion

    #region Item Definitions

    #region [internal] (enum) ColorManagementDataDescriptorItemProperty: Definition of properties for a type descriptor 'ColorManagementData'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="EdidDataBlockDescriptor.ColorManagementData"/>.
    /// </summary>
    internal enum ColorManagementDataDescriptorItemProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        [PropertyName("A3")]
        A2,

        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        [PropertyName("A3")]
        A3,
    }
    #endregion

    #region [internal] (enum) ColorPointDataDescriptorItemProperty: Definition of properties for a type descriptor 'ColorPointData'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="EdidDataBlockDescriptor.ColorPointData"/>.
    /// </summary>
    internal enum ColorPointDataDescriptorItemProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        [PropertyName("Index")]
        Index,

        [PropertyDescription("")]
        [PropertyType(typeof(PointF))]
        [PropertyName("White")]
        White,

        [PropertyDescription("")]
        [PropertyType(typeof(double?))]
        [PropertyName("Gamma")]
        Gamma,
    }
    #endregion

    #region [internal] (enum) Cvt3ByteCodeDescriptorItemProperty: Definición de propiedades para un elemento del descriptor 'CVT3ByteCode'.
    /// <summary>
    /// Definición de propiedades para un elemento del descriptor <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/>.
    /// </summary>
    internal enum Cvt3ByteCodeDescriptorItemProperty
    {
        [PropertyDescription("")]
        [PropertyType(typeof(int))]
        [PropertyName("Addressable Vertical Lines")]
        AddressableVerticalLines,

        [PropertyDescription("")]
        [PropertyType(typeof(string))]
        [PropertyName("Aspect Ratio")]
        AspectRatio,

        [PropertyDescription("")]
        [PropertyType(typeof(byte))]
        [PropertyName("Preferred Vertical Rate")]
        PreferredVerticalRate,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        [PropertyName("Is Supported 50Hz With Standard Blanking")]
        IsSupported50HzWithStandardBlanking,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        [PropertyName("Is Supported 60Hz With Standard Blanking")]
        IsSupported60HzWithStandardBlanking,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        [PropertyName("Is Supported 75Hz With Standard Blanking")]
        IsSupported75HzWithStandardBlanking,

        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        [PropertyName("Is Supported 85Hz With Standard Blanking")]
        IsSupported85HzWithStandardBlanking,
                         
        [PropertyDescription("")]
        [PropertyType(typeof(bool))]
        [PropertyName("Is Supported 60Hz With Reduced Blanking")]
        IsSupported60HzWithReducedBlanking,
    }
    #endregion

    #endregion

    #endregion

    #endregion

    #region Extension Blocks

    #region [internal] (enum) EdidExtensionBlockTag: Definition of types of extension blocks supported by a 'EDID' block
    /// <summary>
    /// Definition of types of extension blocks supported by a <see cref="KnownDataBlock.EDID" /> block.
    /// </summary>
    internal enum EdidExtensionBlockTag
    {
        /// <summary>
        /// CEA-EXT: CEA 861 Series Extension, para más información ver <see cref="CeaBlock"/>.
        /// </summary>
        [PropertyType(typeof(CeaBlock))]
        [PropertyDescription("CEA-EXT: CEA 861 Series Extension")]
        [PropertyName("CEA")]
        CEA = 0x02,

        /// <summary>
        /// VTB-EXT: Video Timing Block Extension
        /// </summary>
        [PropertyType(typeof(CeaBlock))]
        [PropertyDescription("VTB-EXT: Video Timing Block Extension")]
        [PropertyName("VTB")]
        VTB = 0x10,

        /// <summary>
        /// DI-EXT: Display Information Extension, para más información ver <see cref="DiBlock"/>.
        /// </summary>
        [PropertyType(typeof(DiBlock))]
        [PropertyDescription("DI-EXT: Display Information Extension")]
        [PropertyName("DI")]
        DI = 0x40,

        /// <summary>
        /// LS-EXT: Localizated String Extension
        /// </summary>
        [PropertyType(typeof(CeaBlock))]
        [PropertyDescription("LS-EXT: Localizated String Extension")]
        [PropertyName("LS")]
        LS = 0x50,

        /// <summary>
        /// DPVL-EXT: Digital Packet Video Link Extension
        /// </summary>
        [PropertyType(typeof(CeaBlock))]
        [PropertyDescription("DPVL-EXT: Digital Packet Video Link Extension")]
        [PropertyName("DPVL")]
        DPVL = 0x60,

        /// <summary>
        /// Extension Block Map
        /// </summary>
        [PropertyType(typeof(CeaBlock))]
        [PropertyDescription("Extension Block Map")]
        [PropertyName("Block Map")]
        BlockMap = 0xf0,

        /// <summary>
        /// Extensions definidas por el fabricante
        /// </summary>
        [PropertyType(typeof(CeaBlock))]
        [PropertyDescription("Extensions definidas por el fabricante")]
        [PropertyName("By Manufacturer")]
        ByManufacturer = 0xff,
    }
    #endregion

    #endregion

    #endregion
}
