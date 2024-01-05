
using iTin.Core.Hardware.Common;

using iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID;

/// <summary>
/// Sections available for a block <see cref="KnownDataBlock.EDID"/>.
/// </summary>
public enum EdidSection
{
    /// <summary>
    /// <strong>Header</strong> section of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="HeaderSection" />.
    /// </summary>
    [PropertyName("Header")]
    [PropertyDescription("Header Section")]
    Header,

    /// <summary>
    /// <strong>Vendor and Product</strong> section of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="VendorSection"/>.
    /// </summary>
    [PropertyName("Vendor")]
    [PropertyDescription("Vendor And Product Section")]
    Vendor,

    /// <summary>
    /// Section <strong>Version and Revision</strong> of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="VersionSection"/>.
    /// </summary>
    [PropertyName("Version")]
    [PropertyDescription("Version Section")]
    Version,

    /// <summary>
    /// Section <strong>Basic Display Parameters and Features</strong> of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="BasicDisplaySection"/>.
    /// </summary>
    [PropertyName("Basic Display")]
    [PropertyDescription(">Basic Display Parameters And Features Section")]
    BasicDisplay,

    /// <summary>
    /// <strong>Color Characteristics</strong> section of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="ColorCharacteristicsSection"/>.
    /// </summary>
    [PropertyName("Color Characteristics")]
    [PropertyDescription("Color Characteristics Section")]
    ColorCharacteristics,

    /// <summary>
    /// <strong>Established Timings I, II</strong> section of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="EstablishedTimingsSection"/>.
    /// </summary>
    [PropertyName("Established Timings")]
    [PropertyDescription("Established Timings I, II Section")]
    EstablishedTimings,

    /// <summary>
    /// Section <strong>Standard Timings 16 Bytes</strong> of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="StandardTimingsSection"/>.
    /// </summary>
    [PropertyName("Standard Timings")]
    [PropertyDescription("Standard Timings 16 Bytes Section")]
    StandardTimings,

    /// <summary>
    /// Section <strong>18 Byte Data Blocks Descriptors</strong> of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="DataBlocksSection"/>.
    /// </summary>
    [PropertyName("Data Blocks")]
    [PropertyDescription("18 Byte Data Blocks Descriptors Section")]
    DataBlocks,

    /// <summary>
    /// <strong>Extension Block Count</strong> section of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="ExtensionBlocksSection"/>.
    /// </summary>
    [PropertyName("Extension Blocks")]
    [PropertyDescription("Extension Block Count Section")]
    ExtensionBlocks,

    /// <summary>
    /// <strong> CheckSum </strong> section of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="ChecksumSection"/>.
    /// </summary>
    [PropertyName("CheckSum")]
    [PropertyDescription("CheckSum Section")]
    Checksum
}
