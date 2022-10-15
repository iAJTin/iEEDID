
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;

using iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections
{
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

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="EdidSection.ColorCharacteristics"/> section of this block <see cref="KnownDataBlock.EDID"/>.
    /// </summary> 
    internal sealed class ColorCharacteristicsSection : BaseDataSection
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<ColorManagementDataDescriptor.KnownColor, PointF> _colorTable;
        #endregion

        #region constructor/s

        #region [public] ColorCharacteristicsSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="ColorCharacteristicsSection"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public ColorCharacteristicsSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
            properties.Add(EedidProperty.Edid.ColorCharacteristics.Blue, Color(ColorManagementDataDescriptor.KnownColor.Blue));
            properties.Add(EedidProperty.Edid.ColorCharacteristics.Green, Color(ColorManagementDataDescriptor.KnownColor.Green));
            properties.Add(EedidProperty.Edid.ColorCharacteristics.Red, Color(ColorManagementDataDescriptor.KnownColor.Red));
            properties.Add(EedidProperty.Edid.ColorCharacteristics.White, Color(ColorManagementDataDescriptor.KnownColor.White));
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
