﻿
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

using iTin.Core;

using iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel;
using iTin.Hardware.Specification.IEEE;

namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks;

// Data Block: Product Identification Data Block
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                    Length      Description                                    |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          TAG                     1 BYTE      DisplayID    Value                             |
// |                                                        1.3      00h                             |
// |                                                        2.0      20h                             |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Block Revision and      1 BYTE       Bits    Value                                 |
// |              Other Data                          02:00    Block Revision, 000b Rev. 0 (default) |
// |                                                  07:03    Reserved (Cleared to all 0s)          |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Number of Payload       1 BYTE      Value ranges from 0Ch through F8h.             |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 03h          Manufacturer/Vendor ID   3 BYTEs                                                   |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 06h          Product ID Code          WORD                                                      |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 08h          Product ID Code          4 BYTEs                                                   |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Ch          Week of Manufacture/     BYTE                                                      |
// |              Model Tag                                                                          |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Dh          Year of Manufacture/     BYTE                                                      |
// |              Model Year                                                                         |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Eh          Size of Product Name     BYTE                                                      |
// |              String                                                                             |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Fh          Product Name String      n BYTEs                                                   |
// •—————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents a data block of type <see cref="DataBlockTag.ProductIdentification"/>.
/// </summary> 
internal sealed class ProductIdentificationDataBlock : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="ProductIdentificationDataBlock"/> class with the data of this block untreated with version block.
    /// </summary>
    /// <param name="dataBlock">Unprocessed data in this block</param>
    /// <param name="version">Block version.</param>
    public ProductIdentificationDataBlock(ReadOnlyCollection<byte> dataBlock, int? version = null) 
        : base(dataBlock, version)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <strong>Id Product Code</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int ProductIdCode => RawData.GetWord(0x06);

    /// <summary>
    /// Gets a value representing the <strong>Serial Number</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private uint SerialNumber => (uint)RawData.GetDoubleWord(0x08);

    /// <summary>
    /// Gets a value representing the <strong>Week Of Manufacture</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte WeekOfManufactureOrModelTag => RawData[0x0c];

    /// <summary>
    /// Gets a value representing the <strong>Year Of Manufacture</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte YearOfManufactureOrModelYear => RawData[0x0d];

    /// <summary>
    /// Gets a value representing the <strong>Product Name Size</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte ProductNameSize => RawData[0x0e];

    /// <summary>
    /// Gets a value representing the <strong>Product Name Data</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte[] ProductNameData => RawData.Extract((byte)0x0f, ProductNameSize).ToArray();

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.ProductIdentification.Manufacturer,
            Version >= 0x20
                ? Operations.GetManufacturer(RawData.ToArray().Extract(0x03, 0x03))
                : $"{RawData[0x03]}{RawData[0x04]}{RawData[0x05]}");

        properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.ProductIdentification.ProductIdCode, ProductIdCode);
        properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.ProductIdentification.SerialNumber, SerialNumber);
        properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.ProductIdentification.WeekOfManufactureOrModelTag, WeekOfManufactureOrModelTag);
        properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.ProductIdentification.YearOfManufactureOrModelYear, YearOfManufactureOrModelYear);
            
        var modelYearStrategy = WeekOfManufactureOrModelTag is 0xff or 0x00 ? KnownModelYearStrategy.ModelYear : KnownModelYearStrategy.YearOfManufacture;
        properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.ProductIdentification.ModelYearStrategy, modelYearStrategy);

        if (modelYearStrategy == KnownModelYearStrategy.ModelYear)
        {
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.ProductIdentification.ManufactureDate, 2000 + YearOfManufactureOrModelYear);
        }
        else
        {
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.ProductIdentification.ManufactureDate, $"week {WeekOfManufactureOrModelTag} of {2000 + YearOfManufactureOrModelYear}");
        }

        if (ProductNameSize == 0x00)
        {
            return;
        }

        if (ProductNameSize is > 0x01 and <= 0xec)
        {
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.ProductIdentification.ProductName, Encoding.Default.GetString(ProductNameData));
        }
    }

    #endregion
}
