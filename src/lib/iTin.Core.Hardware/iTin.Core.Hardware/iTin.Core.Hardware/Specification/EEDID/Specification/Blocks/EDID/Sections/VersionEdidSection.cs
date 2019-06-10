
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
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

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> class that represents the <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownEdidSection.Version" /> section of this block <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.EDID" />.
    /// </summary> 
    sealed class VersionEdidSection : BaseDataSection
    {
        #region constructor/s

        #region [public] VersionEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.VersionEdidSection" /> class with the data in this section untreated.
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
            var propertyId = (KnownEdidVersionProperty)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x00] - [Version] - [byte]
                case KnownEdidVersionProperty.Version:
                    value = Version;
                    break;
                #endregion

                #region [0x01] - [Revision] - [byte]
                case KnownEdidVersionProperty.Revision:
                    value = Revision;
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
            items.Add(KnownEedidPropertiesDefinition.Edid.Version.Number, Version);
            items.Add(KnownEedidPropertiesDefinition.Edid.Version.Revision, Revision);
            #endregion
        }
        #endregion

        #endregion
    }
}
