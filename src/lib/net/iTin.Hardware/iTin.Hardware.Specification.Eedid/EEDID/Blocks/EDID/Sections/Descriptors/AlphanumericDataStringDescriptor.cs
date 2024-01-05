
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors;

// Data Block Descriptor: Alphanumeric Data String Descriptor Definition
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Length      Description                                  |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h -> 0ch   ASCII                     13 BYTEs    Up to 13 alphanumeric characters of a data   |
// |              Text                                  string may be stored.                        |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="EdidSection.DataBlocks"/> section of type this block <see cref="EdidDataBlockDescriptor.AlphaNumericDataString"/>.
/// </summary> 
internal sealed class AlphaNumericDataStringDescriptor : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="AlphaNumericDataStringDescriptor"/> class with the data of this block untreated.
    /// </summary>
    /// <param name="dataBlock">Unprocessed data in this block</param>
    public AlphaNumericDataStringDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
    {
    }

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        var data = RawData.ToArray();
        properties.Add(EedidProperty.Edid.DataBlock.Definition.AlphanumericDataString.Data, Encoding.ASCII.GetString(data, 0x00, data.Length));
    }

    #endregion
}
