
using iTin.Core.Hardware.Common;

using iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections;

namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId;

/// <summary>
/// Sections available for a block <see cref="KnownDataBlock.DisplayID" />.
/// </summary> 
public enum DisplayIdSection
{
    /// <summary>
    /// <strong>General</strong> section, for more information see <see cref="GeneralSection"/>.
    /// </summary>
    [PropertyName("General")]
    [PropertyDescription("General")]
    General,

    /// <summary>
    /// <strong>DataBlocks</strong> section, for more information see <see cref="DataBlocksSection"/>.
    /// </summary>
    [PropertyName("Data Blocks")]
    [PropertyDescription("Data Blocks")]
    DataBlocks,

    /// <summary>
    /// <strong>Miscellaneous</strong> section, for more information see <see cref="MiscellaneousSection"/>.
    /// </summary>
    [PropertyName("Miscellaneous")]
    [PropertyDescription("Miscellaneous Data")]
    Miscellaneous
}
