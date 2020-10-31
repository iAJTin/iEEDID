
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    // CEA Section: Information
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Revision                  BYTE        Número de versión implementada.                     |
    // |                                                    Note: Please see, Revision                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Implemented               BYTE        Descripción de la versión implementada.             |
    // |                                                    Note: Please see, Implemented                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="KnownCeaSection.Information"/> section of this block <see cref="KnownDataBlock.CEA"/>.
    /// </summary> 
    internal sealed class InformationCeaSection : BaseDataSection
    {
        #region constructor/s

        #region [public] InformationCeaSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="InformationCeaSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public InformationCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) Revision: Gets a value representing the 'Revision' field
        /// <summary>
        /// Gets a value representing the <b>Revision</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Revision => RawData[0x00];

        #endregion

        #region [private] (string) Implemented: Gets a value representing the 'Implemented' field
        /// <summary>
        /// Gets a value representing the <b>Implemented</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Implemented
        {
            get
            {
                int revision = Revision;
                switch (revision)
                {
                    case 0x01:
                        return "EIA/CEA-861";

                    case 0x02:
                        return "EIA/CEA-861A";

                    case 0x03:
                        return "EIA/CEA-861B";

                    default:
                        return "Unknown";
                }
            }
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
            properties.Add(EedidProperty.Cea.Information.Revision, Revision);
            properties.Add(EedidProperty.Cea.Information.Implemented, Implemented);
        }
        #endregion

        #endregion
    }
}
