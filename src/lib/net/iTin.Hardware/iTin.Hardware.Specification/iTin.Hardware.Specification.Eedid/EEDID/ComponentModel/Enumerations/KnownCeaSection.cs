
namespace iTin.Hardware.Specification.Eedid
{
    using iTin.Core.Hardware.Common;

    /// <summary>
    /// Sections corresponding to a block of type <see cref="CeaBlock" />.
    /// </summary>
    public enum KnownCeaSection
    {
        /// <summary>
        /// <b>General Information</b> section of a block <see cref="KnownDataBlock.CEA" />, for more information see <see cref="InformationCeaSection"/>.
        /// </summary>
        [PropertyName("Information")]
        [PropertyDescription("Information Section")]
        Information,

        /// <summary>
        /// <b>DTV Monitor Supports</b> section of a block <see cref="KnownDataBlock.CEA" />, for more information see <see cref="MonitorSupportCeaSection"/>.
        /// </summary>
        [PropertyName("Monitor Support")]
        [PropertyDescription("Monitor Support Section")]
        MonitorSupport,

        /// <summary>
        /// <b>Data Block Collection</b> section of a block <see cref="KnownDataBlock.CEA" />, for more information see <see cref="DataBlockCollectionCeaSection"/>.
        /// </summary>
        [PropertyName("Data Block Collection")]
        [PropertyDescription("Data Block Collection Section")]
        DataBlockCollection,

        /// <summary>
        /// <b>Detailed Timing Descriptors</b> section of a block <see cref="KnownDataBlock.CEA" />, for more information see <see cref="DetailedTimingsCeaSection"/>.
        /// </summary>
        [PropertyName("Detailed Timing Descriptors")]
        [PropertyDescription("Detailed Timing Descriptors Section")]
        DetailedTiming,

        /// <summary>
        /// <b>CheckSum</b> section of a block <see cref="KnownDataBlock.CEA" />, for more information see <see cref="CheckSumCeaSection"/>.
        /// </summary>
        [PropertyName("CheckSum")]
        [PropertyDescription("CheckSum Section")]
        CheckSum
    }
}
