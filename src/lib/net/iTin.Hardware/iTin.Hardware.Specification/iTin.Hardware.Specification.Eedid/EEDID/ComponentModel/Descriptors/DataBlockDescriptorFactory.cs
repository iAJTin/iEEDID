
namespace iTin.Hardware.Specification.Eedid
{
    using System;

    internal static class DataBlockDescriptorFactory
    {
        public static BaseDataSection GetDataBlockDescription(DataBlockDescriptorData data)
        {
            var type = data.DescriptorType;
            switch (type)
            {
                case EdidDataBlockDescriptor.AlphaNumericDataString:
                    return new AlphaNumericDataStringDescriptor(data.RawData);

                case EdidDataBlockDescriptor.ColorManagementData:
                    return new ColorManagementDataDescriptor(data.RawData);

                case EdidDataBlockDescriptor.ColorPointData:
                    return new ColorPointDataDescriptor(data.RawData);

                case EdidDataBlockDescriptor.Cvt3ByteCode:
                    return new Cvt3ByteCodeDescriptor(data.RawData);

                case EdidDataBlockDescriptor.DetailedTimingMode:
                    return new DetailedTimingModeDescriptor(data.RawData);

                case EdidDataBlockDescriptor.DisplayProductName:
                    return new DisplayProductNameDescriptor(data.RawData);

                case EdidDataBlockDescriptor.DisplayProductSerialNumber:
                    return new DisplayProductSerialNumberDescriptor(data.RawData);

                case EdidDataBlockDescriptor.DisplayRangeLimits:
                    return new DisplayRangeLimitsDescriptor(data.RawData);

                case EdidDataBlockDescriptor.DummyData:
                    return new DummyDataDescriptor(data.RawData);

                case EdidDataBlockDescriptor.EstablishedTimingsIII:
                    return new EstablishedTimingsIIIDescriptor(data.RawData);

                case EdidDataBlockDescriptor.ManufacturerSpecifiedData15:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData14:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData13:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData12:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData11:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData10:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData09:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData08:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData07:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData06:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData05:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData04:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData03:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData02:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData01:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData00:
                    return new ManufacturerSpecifiedDataDescriptor(data.RawData);

                case EdidDataBlockDescriptor.StandardTimingIdentifier:
                    return new StandardTimingIdentifierDescriptor(data.RawData);

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
