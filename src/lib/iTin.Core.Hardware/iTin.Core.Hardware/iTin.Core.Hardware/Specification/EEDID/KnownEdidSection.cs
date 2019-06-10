
namespace iTin.Core.Hardware.Specification.Eedid
{
    /// <summary>
    /// Sections available for a block <see cref="KnownDataBlock.EDID" />.
    /// </summary>
    public enum KnownEdidSection
    {
        /// <summary>
        /// <strong>Header</strong> section of a block <see cref="KnownDataBlock.EDID" />, for more information see <see cref="HeaderEdidSection" />.
        /// </summary>
        Header,

        /// <summary>
        /// <strong>Vendor and Product</strong> section of a block <see cref="KnownDataBlock.EDID" />, for more information see <see cref="VendorEdidSection" />.
        /// </summary>
        Vendor,

        /// <summary>
        /// Section <strong>Version and Revision</strong> of a block <see cref="KnownDataBlock.EDID" />, for more information see <see cref="VersionEdidSection" />.
        /// </summary>
        Version,

        /// <summary>
        /// Section <strong>Basic Display Parameters and Features</strong> of a block <see cref="KnownDataBlock.EDID" />, for more information see <see cref="BasicDisplayEdidSection" />.
        /// </summary>
        BasicDisplay,

        /// <summary>
        /// <strong>Color Characteristics</strong> section of a block <see cref="KnownDataBlock.EDID" />, for more information see <see cref="ColorCharacteristicsEdidSection" />.
        /// </summary>
        ColorCharacteristics,

        /// <summary>
        /// <strong>Established Timings I, II</strong> section of a block <see cref="KnownDataBlock.EDID" />, for more information see <see cref="EstablishedTimingsEdidSection" />.
        /// </summary>
        EstablishedTimings,

        /// <summary>
        /// Section <strong>Standard Timings 16 Bytes</strong> of a block <see cref="KnownDataBlock.EDID" />, for more information see <see cref="StandardTimingsEdidSection" />.
        /// </summary>
        StandardTimings,

        /// <summary>
        /// Section <strong>18 Byte Data Blocks Descriptors</strong> of a block <see cref="KnownDataBlock.EDID" />, for more information see <see cref="DataBlocksEdidSection" />.
        /// </summary>
        DataBlocks,

        /// <summary>
        /// <strong>Extension Block Count</strong> section of a block <see cref="KnownDataBlock.EDID" />, for more information see <see cref="ExtensionBlocksEdidSection" />.
        /// </summary>
        ExtensionBlocks,

        /// <summary>
        /// <strong> CheckSum </strong> section of a block <see cref="KnownDataBlock.EDID" />, for more information see <see cref="CheckSumEdidSection" />.
        /// </summary>
        CheckSum,
    }
}
