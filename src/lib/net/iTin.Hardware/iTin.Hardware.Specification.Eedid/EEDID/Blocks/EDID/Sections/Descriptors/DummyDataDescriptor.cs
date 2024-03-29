
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors;

// Data Block Descriptor: Dummy Data Descriptor Definition
// 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
// | Offset       Name                      Length      Description                                  |
// 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
// | 00h -> 0ch   Dummy Data                13 BYTEs    All bytes filled with 00h                    |
// 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="EdidSection.DataBlocks"/> section of type this block <see cref="EedidProperty.Edid.DataBlock.Definition.DummyData"/>.
/// </summary> 
internal sealed class DummyDataDescriptor : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="DummyDataDescriptor"/> class with the data of this block untreated.
    /// </summary>
    /// <param name="dataBlock">Unprocessed data in this block</param>
    public DummyDataDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
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
        var data = RawData.ToArray();
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DummyData.OriginalData, Encoding.ASCII.GetString(data, 0x00, data.Length));

        //byte[] rawData = RawData.ToArray();
        //string originalString = Encoding.ASCII.GetString(rawData, 0x00, rawData.Length);
        //string printableString = new string(originalString.Where(c => !char.IsControl(c)).ToArray());

        //properties.Add(EedidProperty.Edid.DataBlock.Definition.DummyData.OriginalData, originalString);
        //properties.Add(EedidProperty.Edid.DataBlock.Definition.DummyData.PrintableData, printableString);
    }

    #endregion
}
