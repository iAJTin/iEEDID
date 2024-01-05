
using System;

using iTin.Hardware.Specification.Eedid.Blocks.EDID;
using iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors;

namespace iTin.Hardware.Specification.Eedid;

internal static class DataBlockDescriptorFactory
{
    public static BaseDataSection GetDataBlockDescription(DataBlockDescriptorData data) => data.DescriptorType switch
    {
        EdidDataBlockDescriptor.AlphaNumericDataString => new AlphaNumericDataStringDescriptor(data.RawData),
        EdidDataBlockDescriptor.ColorManagementData => new ColorManagementDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ColorPointData => new ColorPointDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.Cvt3ByteCode => new Cvt3ByteCodeDescriptor(data.RawData),
        EdidDataBlockDescriptor.DetailedTimingMode => new DetailedTimingModeDescriptor(data.RawData),
        EdidDataBlockDescriptor.DisplayProductName => new DisplayProductNameDescriptor(data.RawData),
        EdidDataBlockDescriptor.DisplayProductSerialNumber => new DisplayProductSerialNumberDescriptor(data.RawData),
        EdidDataBlockDescriptor.DisplayRangeLimits => new DisplayRangeLimitsDescriptor(data.RawData),
        EdidDataBlockDescriptor.DummyData => new DummyDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.EstablishedTimingsIII => new EstablishedTimingsIIIDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData15 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData14 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData13 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData12 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData11 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData10 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData09 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData08 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData07 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData06 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData05 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData04 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData03 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData02 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData01 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.ManufacturerSpecifiedData00 => new ManufacturerSpecifiedDataDescriptor(data.RawData),
        EdidDataBlockDescriptor.StandardTimingIdentifier => new StandardTimingIdentifierDescriptor(data.RawData),
        _ => throw new ArgumentOutOfRangeException()
    };
}
