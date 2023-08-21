
using System.Collections.ObjectModel;

namespace iTin.Hardware.Specification.Eedid.Blocks.LS.Sections;

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="LsSection.Version"/> section of this block <see cref="KnownDataBlock.LS"/>.
/// </summary> 
internal sealed class VersionSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="VersionSection"/> class with the data from this raw section.
    /// </summary>
    /// <param name="sectionData">Data from this section untreated.</param>
    public VersionSection(ReadOnlyCollection<byte> sectionData) 
        : base(sectionData)
    {
    }

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
    }

    #endregion
}
