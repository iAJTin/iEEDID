﻿
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
    /// Represents the <see cref="DisplayIdSection.Miscellaneous"/> section of this block <see cref="KnownDataBlock.DisplayID"/>.
    /// </summary> 
    internal sealed class MiscellaneousSection : BaseDataSection
    {
        #region constructor/s

        #region [public] MiscellaneousSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="MiscellaneousSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public MiscellaneousSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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
        private bool Status => RawData.Aggregate(0, (current, t) => current + t) % 256 == 0;
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
            properties.Add(EedidProperty.DisplayID.Miscellaneous.CheckSum.Ok, Status);
            properties.Add(EedidProperty.DisplayID.Miscellaneous.CheckSum.Value, RawData.Take(RawData.Count - 1).LastOrDefault());
        }
        #endregion

        #endregion
    }
}