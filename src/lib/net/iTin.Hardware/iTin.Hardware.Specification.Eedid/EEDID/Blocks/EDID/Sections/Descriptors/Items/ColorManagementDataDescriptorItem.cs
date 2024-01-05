
using System.Collections.ObjectModel;
using System.Diagnostics;

using iTin.Core.Helpers;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors;

// Data Block Descriptor -> Descriptor Item : Color Management Data Descriptor Item Definition
// •————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Length      Description                             |
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
/// Represents the information of a <see cref="EdidSection.DataBlocks"/> of type <see cref="EedidProperty.Edid.DataBlock.Definition.ColorManagementData"/>.
/// </summary>
internal sealed class ColorManagementDataDescriptorItem : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="ColorManagementDataDescriptorItem" /> class with the data in this block untreated.
    /// </summary>
    /// <param name="blockData">Unprocessed data in this block</param>
    public ColorManagementDataDescriptorItem(ReadOnlyCollection<byte> blockData) : base(blockData)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value that represents the <c>LSB Color a3</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte A3Lsb => RawData[0x00];

    /// <summary>
    /// Gets a value that represents the <c>MSB Color a3</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte A3Msb => RawData[0x01];

    /// <summary>
    /// Gets a value that represents the <c>LSB Color a2</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte A2Lsb => RawData[0x02];

    /// <summary>
    /// Gets a value that represents the <c>MSB Color a2</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte A2Msb => RawData[0x03];

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.Edid.DataBlock.Definition.ColorManagementData.Item.A2, LogicHelper.Word(A2Lsb, A2Msb));
        properties.Add(EedidProperty.Edid.DataBlock.Definition.ColorManagementData.Item.A3, LogicHelper.Word(A3Lsb, A3Msb));
    }

    #endregion
}
