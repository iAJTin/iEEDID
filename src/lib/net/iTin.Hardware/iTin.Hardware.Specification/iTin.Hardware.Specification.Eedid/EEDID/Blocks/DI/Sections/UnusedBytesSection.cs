
namespace iTin.Hardware.Specification.Eedid.Blocks.DI.Sections
{
    using System.Collections.ObjectModel;

    // DI Section: Unused Bytes
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                  Lenght      Description                                                                                       |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Unused Bytes          17 BYTE     All 17 Bytes are Reserved (Must be set to "00h"). These Bytes may be defined in a future revision |
    // |                                                to the DI-EXT Standard.                                                                           |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="DiSection.UnusedBytes"/> section of this block <see cref="KnownDataBlock.DI"/>.
    /// </summary> 
    internal sealed class UnusedBytesSection : BaseDataSection
    {
        #region constructor/s

        #region [public] UnusedBytesSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="UnusedBytesSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public UnusedBytesSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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
            properties.Add(EedidProperty.DI.UnusedBytes.Data, RawData);
        }
        #endregion

        #endregion
    }
}
