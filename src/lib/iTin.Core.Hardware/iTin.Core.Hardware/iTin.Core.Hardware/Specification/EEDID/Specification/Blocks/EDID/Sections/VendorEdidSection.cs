
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Helpers;

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

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> class that represents the <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownEdidSection.Vendor" /> section of this block <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.EDID" />.
    /// </summary> 
    sealed class VendorEdidSection : BaseDataSection
    {
        #region constructor/s

        #region [public] VendorEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.VendorEdidSection" /> class with the data in this section untreated.
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
        private uint IdSerialNumber => (uint)RawData.GetWord(0x04);
        #endregion

        #region [private] (byte) WeekOfManufacture: Gets a value representing the 'Week Of Manufacture' field.
        /// <summary>
        /// Gets a value representing the <c>Week Of Manufacture</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte WeekOfManufacture => RawData[0x08];
        #endregion

        #region [private] (byte) ManufactureDate: Gets a value representing the 'Manufacture Date' field
        /// <summary>
        /// Gets a value representing the <c>Manufacture Date</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ManufactureDate => (byte) (1990 + RawData[0x09]);
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Returns a value that represents the value of the specified property
        /// <inheritdoc />
        /// <summary>
        /// Returns a value that represents the value of the specified property.
        /// </summary>
        /// <param name="propertyKey">Property key to be obtained.</param>
        /// <returns>
        /// Property value.
        /// </returns>
        protected override object GetValueTypedProperty(PropertyKey propertyKey)
        {
            object value = null;
            var propertyId = (KnownEdidVendorProperty) propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x00] - [Id Manufacturer Name] - [string]
                case KnownEdidVendorProperty.IdManufacturerName:
                    value = IdManufacturerName;
                    break;
                #endregion

                #region [0x02] - [Id Product Code] - [int]
                case KnownEdidVendorProperty.IdProductCode:
                    value = IdProductCode;
                    break;
                #endregion

                #region [0x04] - [Id Serial Number] - [uint?]
                case KnownEdidVendorProperty.IdSerialNumber:
                    var idSerialNumber = IdSerialNumber;
                    if (idSerialNumber != 0x00)
                    {
                        value = (int?) idSerialNumber;
                    }
                    break;
                #endregion

                #region [0x08] - [Week Of Manufacture] - [byte?]
                case KnownEdidVendorProperty.WeekOfManufacture:
                {
                    var weekOfManufacture = WeekOfManufacture;
                    if (weekOfManufacture != 0x00)
                    {
                        if (weekOfManufacture != 0xff)
                        {
                            if (weekOfManufacture >= 0x01 && weekOfManufacture <= 0x36)
                            {
                                value = WeekOfManufacture;
                            }
                        }
                    }
                }
                break;
                #endregion

                #region [0x09] - [Manufacture Date] - [byte]
                case KnownEdidVendorProperty.ManufactureDate:
                    value = ManufactureDate;
                    break;
                #endregion

                #region [----] - [Model Year Strategy] - [KnownModelYearStrategy]
                case KnownEdidVendorProperty.ModelYearStrategy:
                {
                    var weekOfManufacture = WeekOfManufacture;
                    value = weekOfManufacture == 0xff
                        ? KnownModelYearStrategy.ModelYear
                        : KnownModelYearStrategy.YearOfManufacture;
                }
                break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(Hashtable): Populates the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="items">Collection of properties of this structure</param>
        protected override void Parse(Hashtable items)
        {
            #region validate parameter/s
            base.Parse(items);
            #endregion

            #region items
            items.Add(KnownEedidPropertiesDefinition.Edid.Vendor.IdManufacturerName, IdManufacturerName);
            items.Add(KnownEedidPropertiesDefinition.Edid.Vendor.IdProductCode, IdProductCode);

            var idSerialNumber = IdSerialNumber;
            if (idSerialNumber != 0x0000)
            {
                items.Add(KnownEedidPropertiesDefinition.Edid.Vendor.IdSerialNumber, (int?) IdSerialNumber);
            }

            var weekOfManufacture = WeekOfManufacture;
            if (weekOfManufacture != 0x00)
            {
                if (weekOfManufacture != 0xff)
                {
                    if (weekOfManufacture >= 0x01 && weekOfManufacture <= 0x36)
                    {
                        items.Add(KnownEedidPropertiesDefinition.Edid.Vendor.WeekOfManufacture, WeekOfManufacture);
                    }
                }
            }

            items.Add(KnownEedidPropertiesDefinition.Edid.Vendor.ManufactureDate, ManufactureDate);
            items.Add(KnownEedidPropertiesDefinition.Edid.Vendor.ModelYearStrategy, weekOfManufacture == 0xff ? KnownModelYearStrategy.ModelYear : KnownModelYearStrategy.YearOfManufacture);
            #endregion
        }
        #endregion

        #endregion
    }
}
