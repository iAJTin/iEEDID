
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
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

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> class that represents the <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownEdidSection.ExtensionBlocks" /> section of this block <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.EDID" />.
    /// </summary> 
    sealed class ExtensionBlocksEdidSection : BaseDataSection
    {
        #region constructor/s

        #region [public] VendorEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.ExtensionBlocksEdidSection" /> class with the data in this section untreated.
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

        #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Returns a value that represents the value of the specified property
        /// <inheritdoc />
        /// <summary>
        /// Returns a value that represents the value of the specified property.
        /// </summary>
        /// <param name="propertyKey">Property key to be obtained.</param>
        /// <returns>
        /// Property value.
        /// </returns>
        protected override object GetValueTypedProperty(PropertyKey propertyKey)
        {
            object value = null;
            var propertyId = (KnownEdidExtensionBlocksProperty)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x00] - [Count] - [byte]
                case KnownEdidExtensionBlocksProperty.Count:
                    value = Count;
                    break;
                #endregion

                #region [0x01] - [HasBlocks] - [bool]
                case KnownEdidExtensionBlocksProperty.HasBlocks:
                    value = HasBlocks;
                    break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(Hashtable): Populates the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="items">Collection of properties of this structure</param>
        protected override void Parse(Hashtable items)
        {
            #region validate parameter/s
            base.Parse(items);
            #endregion

            #region items
            items.Add(KnownEedidPropertiesDefinition.Edid.ExtensionBlocks.Count, Count);
            items.Add(KnownEedidPropertiesDefinition.Edid.ExtensionBlocks.HasBlocks, HasBlocks);
            #endregion
        }
        #endregion

        #endregion
    }
}
