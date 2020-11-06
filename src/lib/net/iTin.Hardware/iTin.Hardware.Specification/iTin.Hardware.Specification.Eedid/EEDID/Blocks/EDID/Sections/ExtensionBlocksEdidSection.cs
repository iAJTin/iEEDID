
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    // EDID Section: Extension Blocks 
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Count                     BYTE        Number of extension blocks.                         |
    // |                                                    Note: See Count                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Has Blocks                BYTE        Indicates if there are extension blocks.            |
    // |                                                    Note: See HasBlocks                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="KnownEdidSection.ExtensionBlocks"/> section of this block <see cref="KnownDataBlock.EDID"/>.
    /// </summary> 
    internal sealed class ExtensionBlocksEdidSection : BaseDataSection
    {
        #region constructor/s

        #region [public] VendorEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="ExtensionBlocksEdidSection"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public ExtensionBlocksEdidSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (byte) Count: Gets a value representing the 'Count' field
        /// <summary>
        /// Gets a value representing the <c>Count</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Count => RawData[0x00];

        #endregion

        #region [private] (bool) HasBlocks: Gets a value representing the 'Has Blocks' field
        /// <summary>
        /// Gets a value representing the '<c>Has Blocks</c>' field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool HasBlocks => Count > 0;
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
            properties.Add(EedidProperty.Edid.ExtensionBlocks.Count, Count);
            properties.Add(EedidProperty.Edid.ExtensionBlocks.HasBlocks, HasBlocks);
        }
        #endregion

        #endregion
    }
}
