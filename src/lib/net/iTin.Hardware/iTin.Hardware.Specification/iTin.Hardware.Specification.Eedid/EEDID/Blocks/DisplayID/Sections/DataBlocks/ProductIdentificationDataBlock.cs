
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

using iTin.Core;

using iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel;
using iTin.Hardware.Specification.IEEE;

namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks
{
    // Data Block: Product Identification Data Block
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                    Lenght      Description                                    |
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

        #region [public] ProductIdentificationDataBlock(ReadOnlyCollection<byte>, int? = null): Initialize a new instance of the class with the data of this block untreated with version block
        /// <summary>
        /// Initialize a new instance of the <see cref="ProductIdentificationDataBlock"/> class with the data of this block untreated with version block.
        /// </summary>
        /// <param name="dataBlock">Unprocessed data in this block</param>
        /// <param name="version">Block version.</param>
        public ProductIdentificationDataBlock(ReadOnlyCollection<byte> dataBlock, int? version = null) : base(dataBlock, version)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (int) ProductIdCode: Gets a value representing the 'Id Product Code' field
        /// <summary>
        /// Gets a value representing the <b>Id Product Code</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ProductIdCode => RawData.GetWord(0x06);
        #endregion

        #region [private] (uint) SerialNumber: Gets a value representing the 'Serial Number' field
        /// <summary>
        /// Gets a value representing the <b>Serial Number</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint SerialNumber => (uint)RawData.GetDoubleWord(0x08);
        #endregion

        #region [private] (byte) WeekOfManufactureOrModelTag: Gets a value representing the 'Week Of Manufacture' field
        /// <summary>
        /// Gets a value representing the <b>Week Of Manufacture</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte WeekOfManufactureOrModelTag => RawData[0x0c];
        #endregion

        #region [private] (byte) YearOfManufactureOrModelYear: Gets a value representing the 'Year Of Manufacture' field
        /// <summary>
        /// Gets a value representing the <b>Year Of Manufacture</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte YearOfManufactureOrModelYear => RawData[0x0d];
        #endregion

        #region [private] (byte) ProductNameSize: Gets a value representing the 'Product Name Size' field
        /// <summary>
        /// Gets a value representing the <b>Product Name Size</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ProductNameSize => RawData[0x0e];
        #endregion

        #region [private] (byte[]) ProductNameData: Gets a value representing the 'Product Name Data' field
        /// <summary>
        /// Gets a value representing the <b>Product Name Data</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte[] ProductNameData => RawData.Extract((byte)0x0f, ProductNameSize).ToArray();
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
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
            
            var modelYearStrategy = WeekOfManufactureOrModelTag == 0xff || WeekOfManufactureOrModelTag == 0x00 ? KnownModelYearStrategy.ModelYear : KnownModelYearStrategy.YearOfManufacture;
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

            if (ProductNameSize > 0x01 && ProductNameSize <= 0xec)
            {
                properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.ProductIdentification.ProductName, Encoding.Default.GetString(ProductNameData));
            }
        }
        #endregion

        #endregion
    }
}
