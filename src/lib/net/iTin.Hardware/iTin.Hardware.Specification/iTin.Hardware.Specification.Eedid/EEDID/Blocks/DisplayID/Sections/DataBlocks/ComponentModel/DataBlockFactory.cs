
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
                case DataBlockTag.VendorSpecific:
                    return new VendorSpecificDataBlock(data.RawData, data.StructureVersion);

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
