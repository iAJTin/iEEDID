
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors;

// Data Block Descriptor: Display Product Name Descriptor Definition
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Lenght      Description                                  |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h -> 0ch   ASCII                     13 BYTEs    Up to 13 alphanumeric characters of a data   |
// |              Text                                  string may be stored.                        |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="EdidSection.DataBlocks"/> section of type this block <see cref="EedidProperty.Edid.DataBlock.Definition.DisplayProductName"/>.
/// </summary> 
internal sealed class DisplayProductNameDescriptor : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="DisplayProductNameDescriptor"/> class with the data of this block untreated.
    /// </summary>
    /// <param name="dataBlock">Unprocessed data in this block</param>
    public DisplayProductNameDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
    {
    }

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        var data = RawData.ToArray();
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DisplayProductName.Data, Encoding.ASCII.GetString(data, 0x00, data.Length));
    }

    #endregion
}
