
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections
{
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
    /// Represents the <see cref="EdidSection.ExtensionBlocks"/> section of this block <see cref="KnownDataBlock.EDID"/>.
    /// </summary> 
    internal sealed class ExtensionBlocksSection : BaseDataSection
    {
        #region constructor/s

        #region [public] ExtensionBlocksSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="ExtensionBlocksSection"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public ExtensionBlocksSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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
