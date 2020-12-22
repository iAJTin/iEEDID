
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    // DI Section: Audio Support
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                                                                   |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Sub-Pixel Layout          BYTE                                                                                                      |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Sub-Pixel Configuration   BYTE                                                                                                      |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Sub-Pixel Shape           BYTE                                                                                                      |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          HPP                       BYTE                                                                                                      |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          VPP                       BYTE                                                                                                      |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Major Display Device      BYTE                                                                                                      |
    // |              Characteristics                                                                                                                     |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="KnownDiSection.AudioSupport"/> section of this block <see cref="KnownDataBlock.DI"/>.
    /// </summary> 
    internal sealed class AudioSupportDiSection : BaseDataSection
    {
        #region constructor/s

        #region [public] AudioSupportDiSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSupportDiSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public AudioSupportDiSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <inheritdoc />
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
