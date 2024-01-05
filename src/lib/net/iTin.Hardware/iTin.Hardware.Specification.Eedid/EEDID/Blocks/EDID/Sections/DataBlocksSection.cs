
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Core;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections;

// EDID Section: 18 Byte Data Blocks Descriptors - 72 Bytes
// •—————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Length      Description                                      |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          First 18 Byte Descriptor  18 BYTEs    Descriptor 1.                                    |
// |                                                    Note: See Descriptor(KnownEdidDataBlockProperty) |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 17h          Second 18 Byte Descriptor 18 BYTEs    Descriptor 2.                                    |
// |                                                    Note: See Descriptor(KnownEdidDataBlockProperty) |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 23h          Third 18 Byte Descriptor  18 BYTEs    Descriptor 3.                                    |
// |                                                    Note: See Descriptor(KnownEdidDataBlockProperty) |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 35h          Fourth 18 Byte Descriptor 18 BYTEs    Descriptor 4.                                    |
// |                                                    Note: See Descriptor(KnownEdidDataBlockProperty) |
// •—————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="EdidSection.DataBlocks"/> section of this block <see cref="KnownDataBlock.EDID"/>.
/// </summary> 
internal sealed class DataBlocksSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="DataBlocksSection"/> class with the data in this section untreated.
    /// </summary>
    /// <param name="sectionData">Unprocessed data in this section</param>
    public DataBlocksSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
    {
    }

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        var descriptors = DataBlockDescriptorsData().ToList();
        properties.Add(EedidProperty.Edid.DataBlock.Descriptor1, descriptors[0]);
        properties.Add(EedidProperty.Edid.DataBlock.Descriptor2, descriptors[1]);
        properties.Add(EedidProperty.Edid.DataBlock.Descriptor3, descriptors[2]);
        properties.Add(EedidProperty.Edid.DataBlock.Descriptor4, descriptors[3]);
    }

    #endregion

    #region private methods

    /// <summary>
    /// Returns an implemented datablock related datat.
    /// </summary>
    /// <returns>
    /// Collection of datablock related data.
    /// </returns>
    private IEnumerable<DataBlockDescriptorData> DataBlockDescriptorsData()
    {
        byte[] sectionDataArray = RawData.ToArray();

        var data = new Collection<DataBlockDescriptorData>();
        for (byte i = 0x00; i < 0x48; i += 0x12)
        {
            byte[] descriptor = sectionDataArray.Extract(i, (byte)0x12).ToArray();
            var readonlyDescriptor = new ReadOnlyCollection<byte>(descriptor);
            data.Add(new DataBlockDescriptorData(readonlyDescriptor));
        }

        return data;
    }

    #endregion
}
