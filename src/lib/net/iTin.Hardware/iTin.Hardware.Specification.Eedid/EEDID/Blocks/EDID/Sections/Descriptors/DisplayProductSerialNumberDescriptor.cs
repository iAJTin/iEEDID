
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors;

// Data Block Descriptor: Display Product Serial Number Descriptor Definition
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Lenght      Description                                  |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h -> 0ch   ASCII                     13 BYTEs    Up to 13 alphanumeric characters of a serial |
// |              Text                                  number may be stored.                        |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="EdidSection.DataBlocks"/> section of type this block <see cref="EedidProperty.Edid.DataBlock.Definition.DisplayProductSerialNumber"/>.
/// </summary> 
internal sealed class DisplayProductSerialNumberDescriptor : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="DisplayProductSerialNumberDescriptor"/> class with the data of this block untreated.
    /// </summary>
    /// <param name="dataBlock">Unprocessed data in this block</param>
    public DisplayProductSerialNumberDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
    {
    }

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        byte[] data = RawData.ToArray();
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DisplayProductSerialNumber.Data, Encoding.ASCII.GetString(data, 0x00, data.Length));
    }

    #endregion
}
