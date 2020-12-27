
namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    // DI Section: Miscellaneous
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          CheckSum                  BYTE        Note: Please see, Status                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="DisplayIdSection.ExtensionBlocks"/> section of this block <see cref="KnownDataBlock.DisplayID"/>.
    /// </summary> 
    internal sealed class ExtensionBlocksSection : BaseDataSection
    {
        #region constructor/s

        #region [public] ExtensionBlocksSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionBlocksSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public ExtensionBlocksSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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
