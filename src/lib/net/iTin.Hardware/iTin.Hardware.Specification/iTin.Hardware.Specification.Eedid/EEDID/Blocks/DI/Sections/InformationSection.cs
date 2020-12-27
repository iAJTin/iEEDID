
namespace iTin.Hardware.Specification.Eedid.Blocks.DI.Sections
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    // DI Section: Information
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          DI-EXT Block Header Tag   BYTE        Tag identifying DI-EXT Block. 40h                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          DI-EXT Version Number     BYTE        Version Number                                      |
    // |                                                    00h: is an invalid number.                          |
    // |                                                    00h - ffh: is an valid number.                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="DiSection.Information"/> section of this block <see cref="KnownDataBlock.DI"/>.
    /// </summary> 
    internal sealed class InformationSection : BaseDataSection
    {
        #region constructor/s

        #region [public] InformationSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="InformationSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public InformationSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) Tag: Gets a value representing the 'Tag' field
        /// <summary>
        /// Gets a value representing the <b>Tag</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Tag => RawData[0x00];

        #endregion

        #region [private] (byte) VersionNumber: Gets a value representing the 'Version Number' field
        /// <summary>
        /// Gets a value representing the <b>Version Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte VersionNumber => RawData[0x01];

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
            properties.Add(EedidProperty.DI.Information.VersionNumber, VersionNumber);
        }
        #endregion

        #endregion
    }
}
