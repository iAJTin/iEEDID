
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    // EDID Section: CheckSum
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          CheckSum                  BYTE        Note: Ver Status                                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="KnownEdidSection.CheckSum"/> section of this block <see cref="KnownDataBlock.EDID"/>.
    /// </summary> 
    internal sealed class CheckSumEdidSection : BaseDataSection
    {
        #region constructor/s

        #region [public] CheckSumEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="CheckSumEdidSection"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public CheckSumEdidSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (bool) Status: Gets a value that represents the 'Status' field
        /// <summary>
        /// Gets a value that represents the <c>Status</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Status
        {
            get
            {
                var checksum = 0;

                for (var i = 0; i < 0x80; i++)
                {
                    checksum += RawData[i];
                }

                return checksum % 256 == 0;
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
            properties.Add(EedidProperty.Edid.CheckSum.Value, RawData.Take(128).LastOrDefault());
            properties.Add(EedidProperty.Edid.CheckSum.Ok, Status);
        }
        #endregion

        #endregion
    }
}
