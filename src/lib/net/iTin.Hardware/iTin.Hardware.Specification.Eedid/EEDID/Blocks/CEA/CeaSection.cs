
using iTin.Core.Hardware.Common;

using iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA;

/// <summary>
/// Sections corresponding to a block of type <see cref="CeaBlock"/>.
/// </summary>
public enum CeaSection
{
    /// <summary>
    /// <b>General Information</b> section of a block <see cref="KnownDataBlock.CEA"/>, for more information see <see cref="InformationSection"/>.
    /// </summary>
    [PropertyName("Information")]
    [PropertyDescription("Information Section")]
    Information,

    /// <summary>
    /// <b>DTV Monitor Supports</b> section of a block <see cref="KnownDataBlock.CEA"/>, for more information see <see cref="MonitorSupportSection"/>.
    /// </summary>
    [PropertyName("Monitor Support")]
    [PropertyDescription("Monitor Support Section")]
    MonitorSupport,

    /// <summary>
    /// <b>Data Block Collection</b> section of a block <see cref="KnownDataBlock.CEA"/>, for more information see <see cref="DataBlockCollectionSection"/>.
    /// </summary>
    [PropertyName("Data Block Collection")]
    [PropertyDescription("Data Block Collection Section")]
    DataBlockCollection,

    /// <summary>
    /// <b>Detailed Timing Descriptors</b> section of a block <see cref="KnownDataBlock.CEA"/>, for more information see <see cref="DetailedTimingsSection"/>.
    /// </summary>
    [PropertyName("Detailed Timing Descriptors")]
    [PropertyDescription("Detailed Timing Descriptors Section")]
    DetailedTiming,

    /// <summary>
    /// <b>CheckSum</b> section of a block <see cref="KnownDataBlock.CEA"/>, for more information see <see cref="ChecksumSection"/>.
    /// </summary>
    [PropertyName("Checksum")]
    [PropertyDescription("Checksum Section")]
    Checksum
}
