
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;

using iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel;

namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks;

// Data Block: Vendor Specific Data Block
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                    Length      Description                                    |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          TAG                     1 BYTE      29h                                            |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Block Revision and      1 BYTE       Bits    Value                                 |
// |              Other Data                          02:00    Block Revision, 000b Rev. 0 (default) |
// |                                                  07:03    Reserved (Cleared to all 0s)          |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Number of Payload       1 BYTE      10h, Data block is composed of 16 payload      |
// |              Bytes in Block                      bytes.                                         |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 03h          ContainerID             16 BYTEs    16-byte Universally Unique Identifier (UUID).  |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents a data block of type <see cref="DataBlockTag.ContainerID"/>.
/// </summary> 
internal sealed class ContainerIdDataBlock : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="ContainerIdDataBlock"/> class with the data of this block untreated with version block.
    /// </summary>
    /// <param name="dataBlock">Unprocessed data in this block</param>
    /// <param name="version">Block version.</param>
    public ContainerIdDataBlock(ReadOnlyCollection<byte> dataBlock, int? version = null)
        : base(dataBlock, version)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <strong>UUID</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string UUID =>  string.Format(
        CultureInfo.InvariantCulture,
        "{{{0}{1}{2}{3}-{4}{5}-{6}{7}-{8}{9}-{10}{11}{12}{13}{14}{15}}}",
        RawData[0x03].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x04].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x05].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x06].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x07].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x08].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x09].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x0a].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x0b].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x0c].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x0d].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x0e].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x0f].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x10].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x11].ToString("X2", CultureInfo.InvariantCulture),
        RawData[0x12].ToString("X2", CultureInfo.InvariantCulture));

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.ContainerID.UUID, UUID);
    }

    #endregion
}
