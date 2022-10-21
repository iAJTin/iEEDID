
using System.Collections.ObjectModel;

namespace iTin.Hardware.Specification.Eedid.Blocks.VTB.Sections
{
    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="VtbSection.Version"/> section of this block <see cref="KnownDataBlock.VTB"/>.
    /// </summary> 
    internal sealed class VersionSection : BaseDataSection
    {
        #region constructor/s

        #region [public] VersionSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public VersionSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
        }
        #endregion

        #endregion
    }
}
