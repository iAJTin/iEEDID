
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Drawing;

    using iTin.Core;
    using iTin.Core.Helpers;
    using iTin.Core.Helpers.Enumerations;

    // Data Block Descriptor -> Descriptor Item : Color Point Data Desctiptor Item Definition.
    // •———————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          White Point               BYTE        Range:                                     |
    // |              Index                                        00h - Reserved Do not use.          |
    // |                                                           01h - ffh. White Point Index Number |
    // •———————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Bit Definitions           BYTE        Bits 07:04. 0000b                          |
    // |              White-x, y                            Bit     03. Wx1                            |
    // |                                                    Bit     02. Wx0                            |
    // |                                                    Bit     01. Wy1                            |
    // |                                                    Bit     00. Wy0                            |
    // •———————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Bit Definitions           BYTE        Bit 07. Wx9                                |
    // |              White-x                               Bit 06. Wx9                                |
    // |                                                    Bit 05. Wx7                                |
    // |                                                    Bit 04. Wx6                                |
    // |                                                    Bit 03. Wx5                                |
    // |                                                    Bit 02. Wx4                                |
    // |                                                    Bit 01. Wx3                                |
    // |                                                    Bit 00. Wx2                                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          Bit Definitions           BYTE        Bit 07. Wy9                                |
    // |              White-y                               Bit 06. Wy9                                |
    // |                                                    Bit 05. Wy7                                |
    // |                                                    Bit 04. Wy6                                |
    // |                                                    Bit 03. Wy5                                |
    // |                                                    Bit 02. Wy4                                |
    // |                                                    Bit 01. Wy3                                |
    // |                                                    Bit 00. Wy2                                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Gamma                     BYTE        Range:                                     |
    // |                                                          00h -> feh. (1.00 -> 3.54)           |
    // |                                                          Value Stored = (GAMMA * 100) - 100   |
    // |                                                                                               |
    // |                                                          ffh. Gamma Value is not defined      |
    // |                                                               here then Gamma data shall be   |
    // |                                                               stored in an Extension Block;   |
    // |                                                               for example, DI-EXT             |
    // •———————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the information of a <see cref="KnownEdidSection.DataBlocks" /> of type <see cref="EdidDataBlockDescriptor.ColorPointData"/>.
    /// </summary>
    internal sealed class ColorPointDataDescriptorItem : BaseDataSection
    {
        #region constructor/s

        #region [public] ColorPointDataDescriptorItem(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this block untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="ColorPointDataDescriptorItem"/> class with the data in this block untreated.
        /// </summary>
        /// <param name="blockData">Unprocessed data in this block</param>
        internal ColorPointDataDescriptorItem(ReadOnlyCollection<byte> blockData) : base(blockData)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (byte) Number: Gets a value that represents the 'White Point Index Number' field
        /// <summary>
        /// Gets a value that represents the <c>White Point Index Number</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>  
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Number => RawData[0x00];
        #endregion

        #region [private] (byte) WhiteXY: Gets a value that represents the 'White Point X, Y' field
        /// <summary>
        /// Gets a value that represents the <c>White Point X, Y</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>  
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte WhiteXY => RawData[0x06];
        #endregion

        #region [private] (byte) WhiteX: Gets a value that represents the 'White Point X' field
        /// <summary>
        /// Gets a value that represents the <c>White Point X</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>  
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte WhiteX => RawData[0x07];
        #endregion

        #region [private] (byte) WhiteY: Gets a value that represents the 'White Point Y' field
        /// <summary>
        /// Gets a value that represents the <c>White Point Y</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>  
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte WhiteY => RawData[0x08];
        #endregion

        #region [private] (byte) Gamma: Gets a value that represents the 'Gamma Value' field
        /// <summary>
        /// Gets a value that represents the <c>Gamma Value</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Gamma => RawData[0x04];
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
            if (Gamma != 0xff)
            {
                properties.Add(EedidProperty.Edid.DataBlock.Definition.ColorPointData.Item.Gamma, (double?)((Gamma + 100) / 100));
            }

            properties.Add(EedidProperty.Edid.DataBlock.Definition.ColorPointData.Item.Index, Number);
            properties.Add(EedidProperty.Edid.DataBlock.Definition.ColorPointData.Item.White, GetWhitePoint(WhiteXY, WhiteX, WhiteY));
        }
        #endregion

        #endregion


        #region EDID 1.4 Specification

        #region [private] {static} (PointF) GetWhitePoint(byte, byte, byte) : Returns the point of the white color
        /// <summary>
        /// Returns the point of the white color.
        /// </summary>
        /// <param name="xy">XY value</param>
        /// <param name="x">X value.</param>
        /// <param name="y">Y value</param>
        /// <returns>
        /// Aspect ratio value.
        /// </returns>
        private static PointF GetWhitePoint(byte xy, byte x, byte y)
        {
            double vCx = 0.0;
            double vCy = 0.0;

            int cx = LogicHelper.Word(x, (byte) ((xy >> 2) & 0x03));
            int cy = LogicHelper.Word(y, (byte) (xy & 0x03));


            for (int i = 0; i <= 9; vCx += cx.CheckBit((Bits)i) ? System.Math.Pow(2, i - 10) : 0, vCy += cy.CheckBit((Bits)i) ? System.Math.Pow(2, i - 10) : 0, i++)
            { }

            return new PointF((float)vCx, (float)vCy);
        }
        #endregion

        #endregion
    }
}
