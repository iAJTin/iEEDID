
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    // Data Block Descriptor: Color Management Data Descriptor Definition
    // •—————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                  |
    // •—————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Version Number            BYTE        03h. Other values reserved.  |
    // •—————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Red                       QWORD       Note: See Color(KnownColor)  |
    // •—————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Green                     QWORD       Note: See Color(KnownColor)  |
    // •—————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Blue                      QWORD       Note: See Color(KnownColor)  |
    // •—————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> class that represents the <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownEdidSection.DataBlocks" /> section of type this block <see cref="EdidDataBlockDescriptor.ColorManagementData" />.
    /// </summary> 
    internal sealed class ColorManagementDataDescriptor : BaseDataSection
    {
        #region private enumerations

        #region [public] (enum) KnownColor: Known colors for this block
        /// <summary>
        /// Known colors for this block.
        /// </summary> 
        public enum KnownColor
        {
            /// <summary>
            /// Red color
            /// </summary>
            Red,

            /// <summary>
            /// Green color
            /// </summary>
            Green,

            /// <summary>
            /// Blue color
            /// </summary>
            Blue,

            /// <summary>
            /// White color
            /// </summary>
            White
        }
        #endregion

        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<KnownColor, ColorManagementDataDescriptorItem> _colorTable;
        #endregion

        #region constructor/s

        #region [public] ColorManagementDataDescriptor(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data of this block untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.ColorManagementDataDescriptor" /> class with the data of this block untreated.
        /// </summary>
        /// <param name="dataBlock">Unprocessed data in this block</param>
        public ColorManagementDataDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (Dictionary<KnownColor, ColorManagementDataDescriptorItem>) ColorTable: Gets a value that represents a dictionary of color dictionary
        /// <summary>
        /// Gets a value that represents a dictionary of color dictionary.
        /// </summary>
        /// <value>
        /// Dictionary containing the pair color / Value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<KnownColor, ColorManagementDataDescriptorItem> ColorTable
        {
            get
            {
                if (_colorTable != null)
                {
                    return _colorTable;
                }

                _colorTable = new Dictionary<KnownColor, ColorManagementDataDescriptorItem>();
                PopulatesColorTable(_colorTable);
                return _colorTable;
            }
        }
        #endregion

        #region [private] (byte) VersionNumber: Gets a value representing 'Version Number' field
        /// <summary>
        /// Gets a value representing <c>Version Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte VersionNumber => RawData[0x00];
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
            properties.Add(EedidProperty.Edid.DataBlock.Definition.ColorManagementData.VersionNumber, VersionNumber);
            properties.Add(EedidProperty.Edid.DataBlock.Definition.ColorManagementData.Red, Color(KnownColor.Red));
            properties.Add(EedidProperty.Edid.DataBlock.Definition.ColorManagementData.Green, Color(KnownColor.Green));
            properties.Add(EedidProperty.Edid.DataBlock.Definition.ColorManagementData.Blue, Color(KnownColor.Blue));
        }
        #endregion

        #endregion


        #region EDID 1.4 Specification

        #region [private] (ColorManagementDataDescriptorItem) Priority(KnownCVT3ByteCodePriority): Returns the value that contains the specified key
        /// <summary>
        /// Returns the value that contains the specified key.
        /// </summary>
        /// <param name="color">Color to be recovere.</param>
        /// <returns>
        /// Value of the specified timing
        /// </returns>
        private ColorManagementDataDescriptorItem Color(KnownColor color)
        {
            ColorManagementDataDescriptorItem result;

            try
            {
                result = ColorTable[color];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }

            return result;
        }
        #endregion

        #region [private] (void) PopulatesColorTable(IDictionary<KnownColor, ColorManagementDataDescriptorItem>): Returns a value that represents the color dictionary
        /// <summary>
        /// Returns a value that represents the color dictionary.
        /// </summary>
        /// <param name="colorDictionary">Color dictionary.</param>
        private void PopulatesColorTable(IDictionary<KnownColor, ColorManagementDataDescriptorItem> colorDictionary)
        {
            var colorArray = new byte[0x04];
            byte[] sectionDataArray = RawData.ToArray();

            for (int n = 0, i = 0x01; i < 0x0c; i += 0x04)
            {
                Array.Copy(sectionDataArray, i, colorArray, 0x00, 0x04);
                var colorCollection = new ReadOnlyCollection<byte>(colorArray);
                var color = new ColorManagementDataDescriptorItem(colorCollection);
                colorDictionary.Add((KnownColor)n, color);
                n++;
            }
        }
        #endregion

        #endregion
    }
}
