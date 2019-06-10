
namespace iTin.Core.Hardware.Specification.Eedid
{
    /// <summary>
    /// Sections corresponding to a block of type <see cref="CeaBlock" />.
    /// </summary>
    public enum KnownCeaSection
    {
        /// <summary>
        /// General Information section, For more information see <see cref="InformationCeaSection" />.
        /// </summary>
        Information,

        /// <summary>
        /// DTV Monitor Supports section, For more information see <see cref="MonitorSupportCeaSection" />.
        /// </summary>
        MonitorSupport,

        /// <summary>
        /// Data Block Collection Section, For more information see <see cref="DataBlockCollectionCeaSection" />.
        /// </summary>
        DataBlockCollection,

        /// <summary>
        /// Detailed Timing Descriptors section, For more information see <see cref="DetailedTimingsCeaSection" />.
        /// </summary>
        DetailedTiming,

        /// <summary>
        /// Checksum section, For more information see <see cref="CheckSumCeaSection" />.
        /// </summary>
        CheckSum,
    }
}
