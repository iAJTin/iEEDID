
using iTin.Core.Hardware.Common;

using iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID
{
    /// <summary>
    /// Sections available for a block <see cref="KnownDataBlock.EDID"/>.
    /// </summary>
    public enum EdidSection
    {
        /// <summary>
        /// <b>Header</b> section of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="HeaderSection" />.
        /// </summary>
        [PropertyName("Header")]
        [PropertyDescription("Header Section")]
        Header,

        /// <summary>
        /// <b>Vendor and Product</b> section of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="VendorSection"/>.
        /// </summary>
        [PropertyName("Vendor")]
        [PropertyDescription("Vendor And Product Section")]
        Vendor,

        /// <summary>
        /// Section <b>Version and Revision</b> of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="VersionSection"/>.
        /// </summary>
        [PropertyName("Version")]
        [PropertyDescription("Version Section")]
        Version,

        /// <summary>
        /// Section <b>Basic Display Parameters and Features</b> of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="BasicDisplaySection"/>.
        /// </summary>
        [PropertyName("Basic Display")]
        [PropertyDescription(">Basic Display Parameters And Features Section")]
        BasicDisplay,

        /// <summary>
        /// <b>Color Characteristics</b> section of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="ColorCharacteristicsSection"/>.
        /// </summary>
        [PropertyName("Color Characteristics")]
        [PropertyDescription("Color Characteristics Section")]
        ColorCharacteristics,

        /// <summary>
        /// <b>Established Timings I, II</b> section of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="EstablishedTimingsSection"/>.
        /// </summary>
        [PropertyName("Established Timings")]
        [PropertyDescription("Established Timings I, II Section")]
        EstablishedTimings,

        /// <summary>
        /// Section <b>Standard Timings 16 Bytes</b> of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="StandardTimingsSection"/>.
        /// </summary>
        [PropertyName("Standard Timings")]
        [PropertyDescription("Standard Timings 16 Bytes Section")]
        StandardTimings,

        /// <summary>
        /// Section <b>18 Byte Data Blocks Descriptors</b> of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="DataBlocksSection"/>.
        /// </summary>
        [PropertyName("Data Blocks")]
        [PropertyDescription("18 Byte Data Blocks Descriptors Section")]
        DataBlocks,

        /// <summary>
        /// <b>Extension Block Count</b> section of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="ExtensionBlocksSection"/>.
        /// </summary>
        [PropertyName("Extension Blocks")]
        [PropertyDescription("Extension Block Count Section")]
        ExtensionBlocks,

        /// <summary>
        /// <b> CheckSum </b> section of a block <see cref="KnownDataBlock.EDID"/>, for more information see <see cref="ChecksumSection"/>.
        /// </summary>
        [PropertyName("CheckSum")]
        [PropertyDescription("CheckSum Section")]
        Checksum
    }
}
