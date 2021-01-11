
namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel
{
    using System;

    internal static class DataBlockFactory
    {
        public static BaseDataSection GetDataBlockData(DataBlockData data)
        {
            var type = data.BlockTag;
            switch (type)
            {
                case DataBlockTag.ProductIdentification13:
                    return new ProductIdentificationDataBlock(data.RawData, data.StructureVersion);

                case DataBlockTag.DisplayParameters13:
                    return new DisplayParametersDataBlock(data.RawData, data.StructureVersion);

                case DataBlockTag.DetailedTimingTypeI:
                    return new DetailedTimingTypeIDataBlock(data.RawData, data.StructureVersion);


                case DataBlockTag.ProductIdentification:
                    return new ProductIdentificationDataBlock(data.RawData, data.StructureVersion);

                case DataBlockTag.DisplayParameters:
                    return new DisplayParametersDataBlock(data.RawData, data.StructureVersion);

                case DataBlockTag.DynamicVideoTimingRangeLimits:
                    return new DynamicVideoTimingRangeLimitsDataBlock(data.RawData, data.StructureVersion);

                case DataBlockTag.VendorSpecific:
                    return new VendorSpecificDataBlock(data.RawData, data.StructureVersion);

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
