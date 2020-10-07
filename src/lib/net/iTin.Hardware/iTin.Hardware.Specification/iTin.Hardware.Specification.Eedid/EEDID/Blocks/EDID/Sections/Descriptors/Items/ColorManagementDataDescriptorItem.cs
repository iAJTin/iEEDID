
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core.Helpers;

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

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the information of a <see cref="KnownEdidSection.DataBlocks"/> of type <see cref="EdidDataBlockDescriptor.ColorManagementData"/>.
    /// </summary>
    internal sealed class ColorManagementDataDescriptorItem : BaseDataSection
    {
        #region constructor/s

        #region [public] ColorManagementDataDescriptorItem(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this block untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Hardware.Specification.Eedid.ColorCharacteristicsEdidSection" /> class with the data in this block untreated.
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

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
            properties.Add(EedidProperty.Edid.DataBlock.Definition.ColorManagementData.Item.A2, LogicHelper.Word(A2Lsb, A2Msb));
            properties.Add(EedidProperty.Edid.DataBlock.Definition.ColorManagementData.Item.A3, LogicHelper.Word(A3Lsb, A3Msb));
        }
        #endregion

        #endregion
    }
}
