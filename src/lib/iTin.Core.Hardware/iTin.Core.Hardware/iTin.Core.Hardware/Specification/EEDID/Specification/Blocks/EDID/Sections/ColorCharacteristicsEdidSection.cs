
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Drawing;

    // EDID Section: Color Characteristics
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                        Type        Description                                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Red                         PointF      Note: See Color(KnownColor)                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Green                       PointF      Note: See Color(KnownColor)                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Blue                        PointF      Note: See Color(KnownColor)                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          White                       PointF      Note: See Color(KnownColor)                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> class that represents the <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownEdidSection.ColorCharacteristics" /> section of this block <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.EDID" />.
    /// </summary> 
    sealed class ColorCharacteristicsEdidSection : BaseDataSection
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<ColorManagementDataDescriptor.KnownColor, PointF> _colorTable;
        #endregion

        #region constructor/s

        #region [public] ColorCharacteristicsEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.ColorCharacteristicsEdidSection" /> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public ColorCharacteristicsEdidSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (Dictionary<ColorManagementDataDescriptor.KnownColor, PointF>) ColorTable: Gets a value that represents a color dictionary
        /// <summary>
        /// Gets a value that represents a color dictionary
        /// </summary>
        /// <value>
        /// Referencce to color dictionary.
        /// </value>
        private Dictionary<ColorManagementDataDescriptor.KnownColor, PointF> ColorTable
        {
            get
            {
                if (_colorTable != null)
                {
                    return _colorTable;
                }

                _colorTable = new Dictionary<ColorManagementDataDescriptor.KnownColor, PointF>();
                GetAdditionalColorTable(_colorTable);

                return _colorTable;
            }
        }
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
            var propertyId = (KnownEdidColorCharacteristicsProperty)propertyKey.PropertyId;
           
            switch (propertyId)
            {
                #region [0x00] - [Red] - [PointF]
                case KnownEdidColorCharacteristicsProperty.Red:
                    value = Color(ColorManagementDataDescriptor.KnownColor.Red);
                    break;
                #endregion

                #region [0x01] - [Green] - [PointF]
                case KnownEdidColorCharacteristicsProperty.Green:
                    value = Color(ColorManagementDataDescriptor.KnownColor.Green);
                    break;
                #endregion

                #region [0x02] - [Blue] - [PointF]
                case KnownEdidColorCharacteristicsProperty.Blue:
                    value = Color(ColorManagementDataDescriptor.KnownColor.Blue);
                    break;
                #endregion

                #region [0x03] - [White] - [PointF]
                case KnownEdidColorCharacteristicsProperty.White:
                    value = Color(ColorManagementDataDescriptor.KnownColor.White);
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
            items.Add(KnownEedidPropertiesDefinition.Edid.ColorCharacteristics.Blue, Color(ColorManagementDataDescriptor.KnownColor.Blue));
            items.Add(KnownEedidPropertiesDefinition.Edid.ColorCharacteristics.Green, Color(ColorManagementDataDescriptor.KnownColor.Green));
            items.Add(KnownEedidPropertiesDefinition.Edid.ColorCharacteristics.Red, Color(ColorManagementDataDescriptor.KnownColor.Red));
            items.Add(KnownEedidPropertiesDefinition.Edid.ColorCharacteristics.White, Color(ColorManagementDataDescriptor.KnownColor.White));
            #endregion
        }
        #endregion

        #endregion


        #region EDID 1.4 Specification

        #region [private] (PointF) Color(ColorManagementDataDescriptor.KnownColor): Returns the value that contains the specified key
        /// <summary>
        /// Returns the value that contains the specified key.
        /// </summary>
        /// <param name="color">Color that is going to recover</param>
        /// <returns>
        /// Value of the specified color.
        /// </returns>
        private PointF Color(ColorManagementDataDescriptor.KnownColor color) => ColorTable[color];
        #endregion

        #region [private] (void) GetAdditionalColorTable(IDictionary<ColorManagementDataDescriptor.KnownColor, PointF>): Returns a value that represents the color dictionary
        /// <summary>
        /// Returns a value that represents the color dictionary
        /// </summary>
        /// <param name="colorDictionary">Color dictionary</param>
        private void GetAdditionalColorTable(IDictionary<ColorManagementDataDescriptor.KnownColor, PointF> colorDictionary)
        {
            var lowBits = 0;
            var color = ColorManagementDataDescriptor.KnownColor.White;

            for (var i = 0x02; i < 0x0a; i += 2)
            {
                switch (i)
                {
                    case 0x02:
                        color = ColorManagementDataDescriptor.KnownColor.Red;
                        lowBits = 0x00;
                        break;

                    case 0x04:
                        color = ColorManagementDataDescriptor.KnownColor.Green;
                        lowBits = 0x00;
                        break;

                    case 0x06:
                        color = ColorManagementDataDescriptor.KnownColor.Blue;
                        lowBits = 0x01;
                        break;

                    case 0x08:
                        color = ColorManagementDataDescriptor.KnownColor.White;
                        lowBits = 0x01;
                        break;
                }

                var colorDataArray = new[] { RawData[lowBits], RawData[i], RawData[i + 1] };
                var colorDataCollection = new ReadOnlyCollection<byte>(colorDataArray);

                var additionalColorPointDataBlock = new ColorCharacteristicDetail(colorDataCollection, color);
                colorDictionary.Add(color, additionalColorPointDataBlock.Value);
            }
        }
        #endregion

        #endregion
    }
}
