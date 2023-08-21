
using System;

namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel;

internal static class DataBlockFactory
{
    public static BaseDataSection GetDataBlockData(DataBlockData data)
    {
        var type = data.BlockTag;

        return type switch
        {
            DataBlockTag.ProductIdentification13 => new ProductIdentificationDataBlock(data.RawData,
                data.StructureVersion),
            DataBlockTag.DisplayParameters13 => new DisplayParametersDataBlock(data.RawData, data.StructureVersion),
            DataBlockTag.DetailedTimingTypeI => new DetailedTimingTypeIDataBlock(data.RawData,
                data.StructureVersion),
            DataBlockTag.ProductIdentification => new ProductIdentificationDataBlock(data.RawData,
                data.StructureVersion),
            DataBlockTag.DisplayParameters => new DisplayParametersDataBlock(data.RawData, data.StructureVersion),
            DataBlockTag.DynamicVideoTimingRangeLimits => new DynamicVideoTimingRangeLimitsDataBlock(data.RawData,
                data.StructureVersion),
            DataBlockTag.VendorSpecific => new VendorSpecificDataBlock(data.RawData, data.StructureVersion),
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
