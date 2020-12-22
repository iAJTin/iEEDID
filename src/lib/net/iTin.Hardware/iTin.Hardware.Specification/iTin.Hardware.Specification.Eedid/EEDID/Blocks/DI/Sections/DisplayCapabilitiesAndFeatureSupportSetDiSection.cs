
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    // DI Section: Display Capabilities & Feature Support Set
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
    /// Represents the <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/> section of this block <see cref="KnownDataBlock.DI"/>.
    /// </summary> 
    internal sealed class DisplayCapabilitiesAndFeatureSupportSetDiSection : BaseDataSection
    {
        #region constructor/s

        #region [public] DisplayCapabilitiesAndFeatureSupportSetDiSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayCapabilitiesAndFeatureSupportSetDiSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public DisplayCapabilitiesAndFeatureSupportSetDiSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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
