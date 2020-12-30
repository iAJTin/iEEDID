
namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId
{
    using iTin.Core.Hardware.Common;

    using Sections;

    /// <summary>
    /// Sections available for a block <see cref="KnownDataBlock.DisplayID" />.
    /// </summary> 
    public enum DisplayIdSection
    {
        /// <summary>
        /// <b>General</b> section, for more information see <see cref="GeneralSection"/>.
        /// </summary>
        [PropertyName("General")]
        [PropertyDescription("General")]
        General,

        /// <summary>
        /// <b>DataBlocks</b> section, for more information see <see cref="DataBlocksSection"/>.
        /// </summary>
        [PropertyName("Data Blocks")]
        [PropertyDescription("Data Blocks")]
        DataBlocks,

        /// <summary>
        /// <b>Miscellaneous</b> section, for more information see <see cref="MiscellaneousSection"/>.
        /// </summary>
        [PropertyName("Miscellaneous")]
        [PropertyDescription("Miscellaneous Data")]
        Miscellaneous
    }
}
