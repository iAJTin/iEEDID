
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Core;

using iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel;

namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks;

// Data Block: Detailed Timing Type I Data Block
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                    Length      Description                                    |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          TAG                     1 BYTE      03h                                            |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Block Revision and      1 BYTE       Bits    Value                                 |
// |              Other Data                          02:00    Block Revision, 000b Rev. 0 (default) |
// |                                                  07:03    Reserved (Cleared to all 0s)          |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Number of Payload       1 BYTE      Number of payload bytes within the data block  |
// |              Bytes in Block                      ranges from 20 through 240 (1 ≤ N ≤ 12).       |
// |              Bytes in Block                      When N  represents the number of Detailed      |
// |                                                  Timing Descriptors in the data block.          |
// |                                                  Value is based on N × 20 – 14h, 28h, 3Ch, etc. |
// |                                                  through F0h.                                   |
// |                                                  All other values are RESERVED.                 |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 03h          1st Type I ‘DETAILED’   20 BYTEs    20-byte descriptor. Priority 1.                |
// |              TIMING                                                                             |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 17h          2ndt Type I ‘DETAILED’  20 BYTEs    20-byte descriptor. Priority 2.                |
// |              TIMING                                                                             |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | ...          ...                     20 BYTEs    20-byte descriptor. Priority ...               |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents a data block of type <see cref="DataBlockTag.DetailedTimingTypeI"/>.
/// </summary> 
internal sealed class DetailedTimingTypeIDataBlock : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="DetailedTimingTypeIDataBlock"/> class with the data of this block untreated with version block.
    /// </summary>
    /// <param name="dataBlock">Unprocessed data in this block</param>
    /// <param name="version">Block version.</param>
    public DetailedTimingTypeIDataBlock(ReadOnlyCollection<byte> dataBlock, int? version = null)
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
        properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timings, new ReadOnlyCollection<DetailedTimingTypeIData>(GetImplementedTimings().ToList()));
    }

    #endregion


    #region VESA Display Identification Data (DisplayID)

    private IEnumerable<DetailedTimingTypeIData> GetImplementedTimings()
    {
        var sectionDataArray = RawData.Extract(0x03).ToArray();
        var data = new Collection<DetailedTimingTypeIData>();
        for (byte i = 0x00; i < sectionDataArray.Length; i += 0x14)
        {
            byte[] dataBlockBytes = sectionDataArray.Extract(i, (byte) 0x14).ToArray();
            var item = new ReadOnlyCollection<byte>(dataBlockBytes);
            data.Add(new DetailedTimingTypeIData(new ReadOnlyCollection<byte>(dataBlockBytes), Version));
        }

        return data;
    }

    #endregion
}
