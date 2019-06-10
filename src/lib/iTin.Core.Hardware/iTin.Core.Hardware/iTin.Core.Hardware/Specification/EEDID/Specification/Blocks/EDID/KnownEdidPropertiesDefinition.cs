
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;

    using Device.DeviceProperty;

    #region EEDID -> EDID

    #region (enum) KnownEdidHeaderProperty: Definition of properties for a section of type 'Header'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.Header" />.
    /// For more information see <see cref="HeaderEdidSection.GetValueTypedProperty" />.
    /// </summary>
    enum KnownEdidHeaderProperty
    {
        [DevicePropertyType(typeof(ReadOnlyCollection<byte>))]
        [DevicePropertyDescription("Header identifying the EDID block")]
        Signature,

        [DevicePropertyType(typeof(bool))]
        [DevicePropertyDescription("Indicates if the header is the expected one")]
        IsValid,
    }
    #endregion

    #region (enum) KnownEdidVendorProperty: Definition of properties for a section of type 'Vendor'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.Vendor" />.
    /// For more information see <see cref="VendorEdidSection.GetValueTypedProperty" />.
    /// </summary>
    enum KnownEdidVendorProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        IdManufacturerName,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        IdProductCode,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(uint?))]
        IdSerialNumber,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte?))]
        WeekOfManufacture,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        ManufactureDate,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(KnownModelYearStrategy))]
        ModelYearStrategy,
    }
    #endregion

    #region (enum) KnownEdidVersionProperty: Definition of properties for a section of type 'Version'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.Version" />.
    /// For more information see <see cref="VersionEdidSection.GetValueTypedProperty" />.
    /// </summary>
    enum KnownEdidVersionProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        Version,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        Revision,
    }
    #endregion

    #region (enum) KnownEdidBasicDisplayProperty: Definition of properties for a section of type 'Basic Display'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.BasicDisplay" />.
    /// For more information see <see cref="BasicDisplayEdidSection.GetValueTypedProperty" />.
    /// </summary>
    enum KnownEdidBasicDisplayProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        VideoInputDefinition,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        AnalogSignalLevelStandard,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        AnalogVideoSetup,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        AnalogSeparateSyncSupported,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        AnalogCompositeSyncSignalHorizontalSupported,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        AnalogCompositeSyncSignalGreenVideoSupported,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        AnalogVerticalSyncSupported,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        DigitalColorBitDepth,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        DigitalVideoInterface,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        HorizontalScreenSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        VerticalScreenSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(double?))]
        Gamma,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        StandbyModeSupported,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        SuspendModeSupported,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        ActiveOffSupported,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        AnalogDisplayColorType,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        DigitalColorEncodingFormat,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        SrgbDefaultColorSpace,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        PreferredTimingMode,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        ContinuousFrequency,
    }
    #endregion

    #region (enum) KnownEdidColorCharacteristicsProperty: Definition of properties for a section of type 'Color Characteristics'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.ColorCharacteristics" />.
    /// For more information see <see cref="ColorCharacteristicsEdidSection.GetValueTypedProperty" />.
    /// </summary>
    enum KnownEdidColorCharacteristicsProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(PointF))]
        White,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(PointF))]
        Red,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(PointF))]
        Blue,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(PointF))]
        Green,
    }
    #endregion

    #region (enum) KnownEdidEstablishedTimingsProperty: Definition of properties for a section of type 'Established Timings'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.EstablishedTimings" />.
    /// For more information see <see cref="EstablishedTimingsEdidSection.GetValueTypedProperty" />.
    /// </summary>
    enum KnownEdidEstablishedTimingsProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<MonitorResolutionInfo>))]
        Resolutions,
    }
    #endregion

    #region (enum) KnownEdidStandardTimingsProperty: Definition of properties for a section of type 'Standard Timings'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.StandardTimings" />.
    /// For more information see <see cref="StandardTimingsEdidSection.GetValueTypedProperty" />.
    /// </summary>
    enum KnownEdidStandardTimingProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing1,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing2,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing3,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing4,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing5,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing6,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing7,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing8,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing9,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing10,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing11,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing12,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing13,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing14,
    }
    #endregion

    #region (enum) KnownEdidDataBlockProperty: Definition of properties for a section of type 'Data Blocks'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.DataBlocks" />.
    /// For more information see <see cref="DataBlocksEdidSection.GetValueTypedProperty" />.
    /// </summary>
    enum KnownEdidDataBlockProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>))]
        Descriptor1,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>))]
        Descriptor2,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>))]
        Descriptor3,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>))]
        Descriptor4,
    }
    #endregion

    #region (enum) KnownEdidExtensionBlocksProperty: Definition of properties for a section of type 'Extension Blocks'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.ExtensionBlocks" />.
    /// For more information see <see cref="ExtensionBlocksEdidSection.GetValueTypedProperty" />.
    /// </summary>
    enum KnownEdidExtensionBlocksProperty
    {
        [DevicePropertyType(typeof(byte))]
        [DevicePropertyDescription("Number of extension blocks available")]
        Count,

        [DevicePropertyType(typeof(bool))]
        [DevicePropertyDescription("Indicates if there are extension blocks available")]
        HasBlocks,
    }
    #endregion

    #region (enum) KnownEdidCheckSumProperty: Definition of properties for a section of type 'CheckSum'
    /// <summary>
    /// Definition of properties for a section of type <see cref="KnownEdidSection.CheckSum" />.
    /// For more information see <see cref="CheckSumEdidSection.GetValueTypedProperty" />.
    /// </summary>
    enum KnownEdidCheckSumProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        IsValid,
    }
    #endregion

    #endregion

    #region EEDID -> EDID -> Sections

    #region Data Blocks

    #region Descriptors

    #region (enum) KnownEdidDataBlockDescriptor: Definition of types of possible descriptors for a 'DataBlock' block
    /// <summary>
    /// Definition of types of possible descriptors for a <see cref="KnownEdidSection.DataBlocks"/> block.
    /// </summary>
    enum KnownEdidDataBlockDescriptor
    {
        /// <summary>
        /// Descriptor <strong>Detailed Timing</strong>, for more information see <see cref ="DetailedTimingModeDescriptor"/>.
        /// </summary>
        [DevicePropertyType(typeof(DetailedTimingModeDescriptor))]
        [DevicePropertyDescription("Descriptor de tipo 'Detailed Timing'")]
        DetailedTimingMode = -1,

        /// <summary>
        /// Descriptor <strong>Display Product Serial Number</strong>, for more information see <see cref ="DisplayProductSerialNumberDescriptor"/>.
        /// </summary>
        [DevicePropertyType(typeof(DisplayProductSerialNumberDescriptor))]
        [DevicePropertyDescription("Descriptor de tipo 'Display Product Serial Number'")]
        DisplayProductSerialNumber = 0xff,

        /// <summary>
        /// Descriptor <strong>AlphaNumeric Data String</strong>, for more information see <see cref ="AlphaNumericDataStringDescriptor"/>.
        /// </summary>
        [DevicePropertyType(typeof(AlphaNumericDataStringDescriptor))]
        [DevicePropertyDescription("Descriptor de tipo 'AlphaNumeric Data String'")]
        AlphaNumericDataString = 0xfe,

        /// <summary>
        /// Descriptor <strong>Display Range Limits</strong>, for more information see <see cref ="DisplayRangeLimitsDescriptor"/>.
        /// </summary>
        [DevicePropertyType(typeof(DisplayRangeLimitsDescriptor))]
        [DevicePropertyDescription("Descriptor de tipo 'Display Range Limits'")]
        DisplayRangeLimits = 0xfd,

        /// <summary>
        /// Descriptor <strong>Display Product Name</strong>, for more information see <see cref ="DisplayProductNameDescriptor"/>.
        /// </summary>
        [DevicePropertyType(typeof(DisplayProductNameDescriptor))]
        [DevicePropertyDescription("Descriptor de tipo 'Display Product Name'")]
        DisplayProductName = 0xfc,

        /// <summary>
        /// Descriptor <strong>Color Point Data</strong>, for more information see <see cref ="ColorPointDataDescriptor"/>.
        /// </summary>
        [DevicePropertyType(typeof(ColorPointDataDescriptor))]
        [DevicePropertyDescription("Descriptor de tipo 'Color Point Data'")]
        ColorPointData = 0xfb,

        /// <summary>
        /// Descriptor <strong>Standard Timing Identifier</strong>, for more information see <see cref ="StandardTimingIdentifier"/>.
        /// </summary>
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptor))]
        [DevicePropertyDescription("Descriptor de tipo 'Standard Timing Identifier'")]
        StandardTimingIdentifier = 0xfa,

        /// <summary>
        /// Descriptor <strong>Color Management Data</strong>, for more information see <see cref ="ColorManagementDataDescriptor"/>.
        /// </summary>
        [DevicePropertyType(typeof(ColorManagementDataDescriptor))]
        [DevicePropertyDescription("Descriptor de tipo 'Color Management Data'")]
        ColorManagementData = 0xf9,

        /// <summary>
        /// Descriptor <strong>CVT 3 Bytes Timing Codes</strong>, for more information see <see cref ="Cvt3ByteCodeDescriptor"/>.
        /// </summary>
        [DevicePropertyType(typeof(Cvt3ByteCodeDescriptor))]
        [DevicePropertyDescription("Descriptor de tipo 'CVT 3 Bytes Timing Codes'")]
        Cvt3ByteCode = 0xf8,

        /// <summary>
        /// Descriptor <strong>Established Timings III</strong>, for more information see <see cref ="EstablishedTimingsIIIDescriptor"/>.
        /// </summary>
        [DevicePropertyType(typeof(EstablishedTimingsIIIDescriptor))]
        [DevicePropertyDescription("Descriptor de tipo 'Established Timings III'")]
        EstablishedTimingsIII = 0xf7,

        /// <summary>
        /// Descriptor <strong>Dummy Data Descriptor</strong>, for more information see <see cref ="DummyDataDescriptor"/>.
        /// </summary>
        [DevicePropertyType(typeof(DummyDataDescriptor))]
        [DevicePropertyDescription("Descriptor de tipo 'Dummy Data Descriptor'")]
        DummyData = 0x10,

        /// <summary>
        /// Descriptor <strong>Reserved</strong>, for more information see
        /// </summary>
        [DevicePropertyDescription("Descriptor de tipo 'Reserved'")]
        Reserved = -2,

        /// <summary>
        /// Descriptor <strong>Manufacturer Specified Data</strong>, for more information see <see cref ="ManufacturerSpecifiedDataDescriptor"/>.
        /// </summary>
        [DevicePropertyType(typeof(ManufacturerSpecifiedDataDescriptor))]
        [DevicePropertyDescription("Descriptor de tipo 'Manufacturer Specified Data'")]
        ManufacturerSpecifiedData = 0x00,
    }
    #endregion

    #endregion

    #region Definitions

    #region (enum) KnownAlphanumericDataStringDescriptorProperty: Definition of properties for a type descriptor 'AlphanumericDataString'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="KnownEdidDataBlockDescriptor.AlphaNumericDataString" />.
    /// For more information see <see cref="AlphaNumericDataStringDescriptor.GetValueTypedProperty" />.
    /// </summary>
    enum KnownAlphanumericDataStringDescriptorProperty
    {
        [DevicePropertyType(typeof(string))] 
        [DevicePropertyDescription("")] 
        Text,
    }
    #endregion

    #region (enum) KnownColorManagementDataDescriptorProperty: Definition of properties for a type descriptor 'ColorManagementData'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="KnownEdidDataBlockDescriptor.ColorManagementData" />.
    /// For more information see <see cref="ColorManagementDataDescriptor.GetValueTypedProperty" />.
    /// </summary>
    enum KnownColorManagementDataDescriptorProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        Version,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ColorManagementDataDescriptorItem))]
        Red,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ColorManagementDataDescriptorItem))]
        Green,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ColorManagementDataDescriptorItem))]
        Blue,
    }
    #endregion

    #region (enum) KnownColorPointDataDescriptorProperty: Definition of properties for a type descriptor 'ColorPointData'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="KnownEdidDataBlockDescriptor.ColorPointData" />.
    /// For more information see <see cref="ColorPointDataDescriptor.GetValueTypedProperty" />.
    /// </summary>
    enum KnownColorPointDataDescriptorProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ColorPointDataDescriptorItem))]
        Point1,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ColorPointDataDescriptorItem))]
        Point2,
    }
    #endregion

    #region (enum) KnownCVT3ByteCodeDescriptorProperty: Definition of properties for a type descriptor 'CVT3ByteCode'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode" />.
    /// For more information see <see cref="Cvt3ByteCodeDescriptor.GetValueTypedProperty" />.
    /// </summary>
    enum KnownCvt3ByteCodeDescriptorProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        Version,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(KnownCvt3ByteCodeDescriptorItemProperty))]
        Priority1,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(KnownCvt3ByteCodeDescriptorItemProperty))]
        Priority2,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(KnownCvt3ByteCodeDescriptorItemProperty))]
        Priority3,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(KnownCvt3ByteCodeDescriptorItemProperty))]
        Priority4,
    }
    #endregion

    #region (enum) KnownDetailedTimingModeDescriptorProperty: Definition of properties for a type descriptor 'DetailedTimingMode'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode" />.
    /// For more information see <see cref="DetailedTimingModeDescriptor.GetValueTypedProperty" />.
    /// </summary>
    enum KnownDetailedTimingModeDescriptorProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        PixelClock,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        HorizontalResolution,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        HorizontalBlanking,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        VerticalLines,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        VerticalBlanking,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        HorizontalFrontPorch,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        HorizontalSyncPulseWidth,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        VerticalFrontPorch,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        VerticalSyncPulseWidth,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        HorizontalImageSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        VerticalImageSize,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        HorizontalBorder,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        VerticalBorder,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        Interlaced,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        StereoViewingSupport,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        SyncSignalType
    }
    #endregion

    #region (enum) KnownDisplayProductNameDescriptorProperty: Definition of properties for a type descriptor 'DisplayProductName'.
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="KnownEdidDataBlockDescriptor.DisplayProductName" />.
    /// For more information see <see cref="DisplayProductNameDescriptor.GetValueTypedProperty" />.
    /// </summary>
    enum KnownDisplayProductNameDescriptorProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Text,
    }
    #endregion

    #region (enum) KnownDisplayProductSerialNumberDescriptorProperty: Definition of properties for a type descriptor 'DisplayProductSerialNumber'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="KnownEdidDataBlockDescriptor.DisplayProductSerialNumber" />.
    /// For more information see <see cref="DisplayProductSerialNumberDescriptor.GetValueTypedProperty" />.
    /// </summary>
    enum KnownDisplayProductSerialNumberDescriptorProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        Text,
    }
    #endregion

    #region (enum) KnownDisplayRangeLimitsDescriptorProperty: Definition of properties for a type descriptor 'DisplayRangeLimits'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="KnownEdidDataBlockDescriptor.DisplayRangeLimits" />.
    /// For more information see <see cref="DisplayRangeLimitsDescriptor.GetValueTypedProperty" />.
    /// </summary>
    enum KnownDisplayRangeLimitsDescriptorProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        FaltanTodasLasClaves,
    }
    #endregion

    #region (enum) KnownDummyDataDescriptorProperty: Definition of properties for a type descriptor 'DummyData'.
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="KnownEdidDataBlockDescriptor.DummyData" />.
    /// For more information see <see cref="DummyDataDescriptor.GetValueTypedProperty" />.
    /// </summary>
    enum KnownDummyDataDescriptorProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<byte>))]
        Data,
    }
    #endregion

    #region (enum) KnownEstablishedTimingsIIIDescriptorProperty: Definition of properties for a type descriptor 'EstablishedTimingsIII'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="KnownEdidDataBlockDescriptor.EstablishedTimingsIII" />.
    /// For more information see <see cref="EstablishedTimingsIIIDescriptor.GetValueTypedProperty" />.
    /// </summary>
    enum KnownEstablishedTimingsIIIDescriptorProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        Revision,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<MonitorResolutionInfo>))]
        Resolutions,
    }
    #endregion

    #region (enum) KnownManufacturerSpecifiedDataDescriptorProperty: Definition of properties for a type descriptor 'ManufacturerSpecifiedData'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="KnownEdidDataBlockDescriptor.ManufacturerSpecifiedData" />.
    /// For more information see <see cref="ManufacturerSpecifiedDataDescriptor.GetValueTypedProperty" />.
    /// </summary>
    enum KnownManufacturerSpecifiedDataDescriptorProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(ReadOnlyCollection<byte>))]
        Data,
    }
    #endregion

    #region (enum) KnownStandardTimingIdentifierDescriptorProperty: Definition of properties for a type descriptor 'StandardTimingIdentifier'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="KnownEdidDataBlockDescriptor.StandardTimingIdentifier" />.
    /// For more information see <see cref="StandardTimingIdentifierDescriptor.GetValueTypedProperty" />.
    /// </summary>
    enum KnownStandardTimingIdentifierDescriptorProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing9,
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing10,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing11,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing12,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing13,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(StandardTimingIdentifierDescriptorItem))]
        Timing14,
    }
    #endregion

    #region Item Definitions

    #region (enum) KnownColorManagementDataDescriptorItemProperty: Definition of properties for a type descriptor 'ColorManagementData'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="KnownEdidDataBlockDescriptor.ColorManagementData" />.
    /// For more information see <see cref="ColorManagementDataDescriptorItem.GetValueTypedProperty" />.
    /// </summary>
    enum KnownColorManagementDataDescriptorItemProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        A2,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        A3,
    }
    #endregion

    #region (enum) KnownColorPointDataDescriptorItemProperty: Definition of properties for a type descriptor 'ColorPointData'
    /// <summary>
    /// Definition of properties for a type descriptor <see cref="KnownEdidDataBlockDescriptor.ColorPointData" />.
    /// For more information see <see cref="ColorPointDataDescriptorItem.GetValueTypedProperty" />.
    /// </summary>
    enum KnownColorPointDataDescriptorItemProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        Index,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(PointF))]
        White,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(double?))]
        Gamma,
    }
    #endregion

    #region (enum) KnownCVT3ByteCodeDescriptorItemProperty: Definición de propiedades para un elemento del descriptor 'CVT3ByteCode'.
    /// <summary>
    /// Definición de propiedades para un elemento del descriptor <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/>.
    /// Para más información ver <see cref="Cvt3ByteCodeDescriptorItem.GetValueTypedProperty"/>.
    /// </summary>
    enum KnownCvt3ByteCodeDescriptorItemProperty
    {
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(int))]
        AddressableVerticalLines,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(string))]
        AspectRatio,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(byte))]
        PreferredVerticalRate,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        IsSupported50HzWithStandardBlanking,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        IsSupported60HzWithStandardBlanking,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        IsSupported75HzWithStandardBlanking,

        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        IsSupported85HzWithStandardBlanking,
                         
        [DevicePropertyDescription("")]
        [DevicePropertyType(typeof(bool))]
        IsSupported60HzWithReducedBlanking,
    }
    #endregion

    #endregion

    #endregion

    #endregion

    #region Extension Blocks

    #region (enum) KnownEdidExtensionBlockTag: Definition of types of extension blocks supported by a 'EDID' block
    /// <summary>
    /// Definition of types of extension blocks supported by a <see cref="KnownDataBlock.EDID" /> block.
    /// </summary>
    enum KnownEdidExtensionBlockTag
    {
        /// <summary>
        /// CEA-EXT: CEA 861 Series Extension, para más información ver <see cref="CeaBlock"/>.
        /// </summary>
        [DevicePropertyType(typeof(CeaBlock))]
        [DevicePropertyDescription("CEA-EXT: CEA 861 Series Extension")]
        CEA = 0x02,

        /// <summary>
        /// VTB-EXT: Video Timing Block Extension
        /// </summary>
        [DevicePropertyType(typeof(CeaBlock))]
        [DevicePropertyDescription("VTB-EXT: Video Timing Block Extension")]
        VTB = 0x10,

        /// <summary>
        /// DI-EXT: Display Information Extension, para más información ver <see cref="DiBlock"/>.
        /// </summary>
        [DevicePropertyType(typeof(DiBlock))]
        [DevicePropertyDescription("DI-EXT: Display Information Extension")]
        DI = 0x40,

        /// <summary>
        /// LS-EXT: Localizated String Extension
        /// </summary>
        [DevicePropertyType(typeof(CeaBlock))]
        [DevicePropertyDescription("LS-EXT: Localizated String Extension")]
        LS = 0x50,

        /// <summary>
        /// DPVL-EXT: Digital Packet Video Link Extension
        /// </summary>
        [DevicePropertyType(typeof(CeaBlock))]
        [DevicePropertyDescription("DPVL-EXT: Digital Packet Video Link Extension")]
        DPVL = 0x60,

        /// <summary>
        /// Extension Block Map
        /// </summary>
        [DevicePropertyType(typeof(CeaBlock))]
        [DevicePropertyDescription("Extension Block Map")]
        BlockMap = 0xf0,

        /// <summary>
        /// Extensions definidas por el fabricante
        /// </summary>
        [DevicePropertyType(typeof(CeaBlock))]
        [DevicePropertyDescription("Extensions definidas por el fabricante")]
        ByManufacturer = 0xff,
    }
    #endregion

    #endregion

    #endregion
}
