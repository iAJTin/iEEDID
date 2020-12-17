
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers;

    // EDID Section: Vendor & Product Information
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                                              |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          ID Manufacturer Name      WORD        ISA 3-character ID Code.                                                 |
    // |                                                    The ID manufacturer name field, contains a 2-byte representation of the  |
    // |                                                    display manufacturer’s 3 character code.                                 |
    // |                                                    These codes are also called the ISA (Industry Standard Architecture) Plug|
    // |                                                    and Play Device Identifier (PNPID).                                      |
    // |                                                    They are based on 5 bit compressed ASCII codes.                          |
    // |                                                    Example: '00001=A' ... '11010=Z'.                                        |
    // |                                                    ISA Manufacturer PNPIDs are issued by Microsoft.                         |
    // |                                                    URL: Refer to http://www.microsoft.com/whdc/system/pnppwr/pnp/pnpid.mspx |
    // |                                                    for more information on ISA PNPID.                                       |
    // |                                                    Note: See IdManufacturerName                                             |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          ID Product Code           WORD        Vendor assigned code.                                                    |
    // |                                                    This is used to differentiate between different models from the same     |
    // |                                                    manufacturer, for example a model number.                                |
    // |                                                    Note: See IdProductCode                                                  |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          ID Serial Number          DWORD       32-bit serial number.                                                    |
    // |                                                    The ID serial number is a 32-bit serial number used to differentiate     |
    // |                                                    between individual instances of the same display model.                  |
    // |                                                    Its use is optional.                                                     |
    // |                                                    Note: See IDSerialNumber                                                 |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Week of Manufacture       BYTE        Week number or Model Year Flag.                                          |
    // |                                                    Note: See WeekOfManufacture                                              |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Year of Manufacture       BYTE        Manufacture Year or Model Year.                                          |
    // |              or Model Year                         Note: See ManufactureDate                                                |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="KnownEdidSection.Vendor"/> section of this block <see cref="KnownDataBlock.EDID"/>.
    /// </summary> 
    internal sealed class VendorEdidSection : BaseDataSection
    {
        #region constructor/s

        #region [public] VendorEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="VendorEdidSection"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public VendorEdidSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (string) IdManufacturerName: Gets a value representing the 'Id Manufacturer Name' field
        /// <summary>
        /// Gets a value representing the <c>Id Manufacturer Name</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string IdManufacturerName => $"{(char) ((byte) 'A' + ((RawData[0x00] >> 2) & 0x1f) - 1)}{(char) ((byte) 'A' + ((LogicHelper.Word(RawData[0x01], RawData[0x00]) >> 5) & 0x1f) - 1)}{(char) ((byte) 'A' + (RawData[0x01] & 0x1f) - 1)}";
        #endregion

        #region [private] (int) IdProductCode: Gets a value representing the 'Id Product Code' field
        /// <summary>
        /// Gets a value representing the <c>Id Product Code</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int IdProductCode => RawData.GetWord(0x02);
        #endregion

        #region [private] (uint) IdSerialNumber: Gets a value representing the 'Id Serial Number' field
        /// <summary>
        /// Gets a value representing the <c>Id Serial Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint IdSerialNumber => (uint)RawData.GetDoubleWord(0x04);
        #endregion

        #region [private] (byte) WeekOfManufactureOrModelYearFlag: Gets a value representing the 'Week Of Manufacture' field.
        /// <summary>
        /// Gets a value representing the <c>Week Of Manufacture</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte WeekOfManufactureOrModelYearFlag => RawData[0x08];
        #endregion

        #region [private] (byte) YearOfManufactureOrModelYear: Gets a value representing the 'Year Of Manufacture' field.
        /// <summary>
        /// Gets a value representing the <c>Year Of Manufacture</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte YearOfManufactureOrModelYear => RawData[0x09];
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
            properties.Add(EedidProperty.Edid.Vendor.IdManufacturerName, IdManufacturerName);
            properties.Add(EedidProperty.Edid.Vendor.IdProductCode, $"{IdProductCode:X4}");

            var idSerialNumber = IdSerialNumber;
            if (idSerialNumber != 0x0000)
            {
                properties.Add(EedidProperty.Edid.Vendor.IdSerialNumber, (int?)IdSerialNumber);
            }

            properties.Add(EedidProperty.Edid.Vendor.WeekOfManufactureOrModelYear, WeekOfManufactureOrModelYearFlag);
            properties.Add(EedidProperty.Edid.Vendor.YearOfManufactureOrModelYear, YearOfManufactureOrModelYear);
            var modelYearStrategy = WeekOfManufactureOrModelYearFlag == 0xff || WeekOfManufactureOrModelYearFlag == 0x00 ? KnownModelYearStrategy.ModelYear : KnownModelYearStrategy.YearOfManufacture;
            properties.Add(EedidProperty.Edid.Vendor.ModelYearStrategy, modelYearStrategy);

            if (modelYearStrategy == KnownModelYearStrategy.ModelYear)
            {
                properties.Add(EedidProperty.Edid.Vendor.ManufactureDate, 1990 + YearOfManufactureOrModelYear);
            }
            else
            {
                properties.Add(EedidProperty.Edid.Vendor.ManufactureDate, $"week {WeekOfManufactureOrModelYearFlag} of {1990 + YearOfManufactureOrModelYear}");
            }
        }
        #endregion

        #endregion
    }
}
