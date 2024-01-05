
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Core;

using iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel;
using iTin.Hardware.Specification.IEEE;

namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks;

// Data Block: Vendor Specific Data Block
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                    Length      Description                                    |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          TAG                     1 BYTE      DisplayID    Value                             |
// |                                                        1.3      7Fh                             |
// |                                                        2.0      7Eh                             |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Block Revision and      1 BYTE       Bits    Value                                 |
// |              Other Data                          02:00    Block Revision, 000b Rev. 0 (default) |
// |                                                  07:03    Reserved (Cleared to all 0s)          |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Number of Payload       1 BYTE      Value ranges from 03h through F8h              |
// |              Bytes in Block                                                                     |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 03h          IEEE OUI First Byte     1 BYTE      Byte code. Byte length ranges from 0 - 255.    |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 04h          IEEE OUI Second Byte    1 BYTE      Byte code. Byte length ranges from 0 - 255.    |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 05h          IEEE OUI Third Byte     1 BYTE      Byte code. Byte length ranges from 0 - 255.    |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 06h          Vendor-specific Data    N BYTEs     Number of Payload (see byte 02h)               |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents a data block of type <see cref="DataBlockTag.VendorSpecific"/>.
/// </summary> 
internal sealed class VendorSpecificDataBlock : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="VendorSpecificDataBlock"/> class with the data of this block untreated with version block.
    /// </summary>
    /// <param name="dataBlock">Unprocessed data in this block</param>
    /// <param name="version">Block version.</param>
    public VendorSpecificDataBlock(ReadOnlyCollection<byte> dataBlock, int? version = null) 
        : base(dataBlock, version)
    {
    }

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.VendorSpecific.Data, RawData.Extract(0x03));
        properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.VendorSpecific.Manufacturer, Operations.GetManufacturer(RawData.ToArray().Extract(0x03, 0x03)));
    }

    #endregion
}
