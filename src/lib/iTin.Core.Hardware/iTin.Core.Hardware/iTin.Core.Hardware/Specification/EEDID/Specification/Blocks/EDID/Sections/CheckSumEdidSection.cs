
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    // EDID Section: CheckSum
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          CheckSum                  BYTE        Note: Ver Status                                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> class that represents the <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownEdidSection.CheckSum" /> section of this block <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.EDID" />.
    /// </summary> 
    sealed class CheckSumEdidSection : BaseDataSection
    {
        #region constructor/s

        #region [public] CheckSumEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.CheckSumEdidSection" /> class with the data in this section untreated.
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
            var propertyId = (KnownEdidCheckSumProperty)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x00] - [Ok] - [bool]
                case KnownEdidCheckSumProperty.IsValid:
                    value = Status;
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
            items.Add(KnownEedidPropertiesDefinition.Edid.CheckSum.IsValid, Status);
            #endregion
        }
        #endregion

        #endregion
    }
}
