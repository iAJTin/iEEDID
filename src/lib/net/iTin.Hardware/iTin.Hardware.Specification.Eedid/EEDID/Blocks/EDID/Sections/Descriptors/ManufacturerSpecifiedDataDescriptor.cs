
using System.Collections.ObjectModel;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors;

// Data Block Descriptor: Manufacturer Spedified Data Descriptor Definition
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Lenght      Description                                  |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h -> 0ch   Manufacturer              13 BYTEs    Manufacturer Specifies the data stored in    |
// |              Data                                  bytes.                                       |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="EdidSection.DataBlocks"/> section of type this block <see cref="EedidProperty.Edid.DataBlock.Definition.ManufacturerSpecifiedData"/>.
/// </summary> 
internal sealed class ManufacturerSpecifiedDataDescriptor : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="ManufacturerSpecifiedDataDescriptor"/> class with the data of this block untreated.
    /// </summary>
    /// <param name="dataBlock">Unprocessed data in this block</param>
    public ManufacturerSpecifiedDataDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
    {
    }

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.Edid.DataBlock.Definition.ManufacturerSpecifiedData.Data, RawData);
    }

    #endregion
}
