
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    // EDID Section: Version & Revision Information
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Version                   BYTE        Implemented version number.                         |
    // |                                                    Note: See Number                                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Revision                  BYTE        Implemented revision number.                        |
    // |                                                    Note: See Revision                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="KnownEdidSection.Version"/> section of this block <see cref="KnownDataBlock.EDID"/>.
    /// </summary> 
    internal sealed class VersionEdidSection : BaseDataSection
    {
        #region constructor/s

        #region [public] VersionEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="VersionEdidSection"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public VersionEdidSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (byte) Version: Gets a value representing the 'Version' field
        /// <summary>
        /// Gets a value representing the <c>Version</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Version => RawData[0x00];
        #endregion

        #region [private] (byte) Revision: Gets a value representing the 'Revision' field
        /// <summary>
        /// Gets a value representing the <c>Revision</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Revision => RawData[0x01];
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
            properties.Add(EedidProperty.Edid.Version.Number, Version);
            properties.Add(EedidProperty.Edid.Version.Revision, Revision);
        }
        #endregion

        #endregion
    }
}
