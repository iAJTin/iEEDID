
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Helpers;

    // Data Block Descriptor -> Descriptor Item : Color Management Data Descriptor Item Definition
    // •————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          LSB Color a3              BYTE        Value 00h -> ffh                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          MSB Color a3              BYTE        Value 00h -> ffh                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          LSB Color a2              BYTE        Value 00h -> ffh                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          MSB Color a2              BYTE        Value 00h -> ffh                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> class that represents the information of a <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownEdidSection.DataBlocks" /> of type <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownEdidDataBlockDescriptor.ColorManagementData" />.
    /// </summary>
    sealed class ColorManagementDataDescriptorItem : BaseDataSection
    {
        #region constructor/s

        #region [public] ColorManagementDataDescriptorItem(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this block untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.ColorCharacteristicsEdidSection" /> class with the data in this block untreated.
        /// </summary>
        /// <param name="blockData">Unprocessed data in this block</param>
        public ColorManagementDataDescriptorItem(ReadOnlyCollection<byte> blockData) : base(blockData)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (byte) A3Lsb: Gets a value that represents the 'LSB Color a3' field
        /// <summary>
        /// Gets a value that represents the <c>LSB Color a3</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte A3Lsb => RawData[0x00];
        #endregion

        #region [private] (byte) A3Msb: Gets a value that represents the 'MSB Color a3' field
        /// <summary>
        /// Gets a value that represents the <c>MSB Color a3</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte A3Msb => RawData[0x01];
        #endregion

        #region [private] (byte) A2Lsb: Gets a value that represents the 'LSB Color a2' field
        /// <summary>
        /// Gets a value that represents the <c>LSB Color a2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte A2Lsb => RawData[0x02];
        #endregion

        #region [private] (byte) A2Msb: Gets a value that represents the 'MSB Color a2' field
        /// <summary>
        /// Gets a value that represents the <c>MSB Color a2</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte A2Msb => RawData[0x03];
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
            var propertyId = (KnownColorManagementDataDescriptorItemProperty)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x00] - [A2] - [int]
                case KnownColorManagementDataDescriptorItemProperty.A2:
                    value = LogicHelper.Word(A2Lsb, A2Msb);
                    break;
                #endregion

                #region [0x01] - [A3] - [int]
                case KnownColorManagementDataDescriptorItemProperty.A3:
                    value = LogicHelper.Word(A3Lsb, A3Msb);
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
            items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.ColorManagementData.Item.A2, LogicHelper.Word(A2Lsb, A2Msb));
            items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.ColorManagementData.Item.A3, LogicHelper.Word(A3Lsb, A3Msb));
            #endregion
        }
        #endregion

        #endregion
    }
}
