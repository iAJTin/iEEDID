
namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    // CEA Section: CheckSum
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          CheckSum                  BYTE        Note: Please see, Status                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="CeaSection.Checksum"/> section of this block <see cref="KnownDataBlock.CEA"/>.
    /// </summary> 
    internal sealed class ChecksumSection : BaseDataSection
    {
        #region constructor/s

        #region [public] ChecksumSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksumSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public ChecksumSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (bool) Status: Gets a value that represents the 'Status' field
        /// <summary>
        /// Gets a value that represents the <b>Status</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Status
        {
            get
            {
                int checksum = 0;

                for (int i = 0; i < 0x80; i++)
                {
                    checksum += RawData[i];
                }

                bool status = (checksum % 256 == 0);
                return status;
            }
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
            properties.Add(EedidProperty.Cea.CheckSum.Value, RawData.LastOrDefault());
            properties.Add(EedidProperty.Cea.CheckSum.Ok, Status);
        }
        #endregion

        #endregion
    }
}
