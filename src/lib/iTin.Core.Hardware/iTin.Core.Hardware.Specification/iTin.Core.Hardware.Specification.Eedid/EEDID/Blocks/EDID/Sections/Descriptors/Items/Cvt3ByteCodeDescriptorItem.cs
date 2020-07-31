
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Helpers;
    using Helpers.Enumerations;

    // Data Block Descriptor -> Descriptor Item : CVT 3 Byte Code Descriptor Item Definition
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          8 Lower                   BYTE        8 least significant bits of 12 bit Addresable Lines             |
    // |              Addressable                           Value 00h reserved.                                             |
    // |              Lines                                                                                                 |
    // |                                                    Compute.                                                        |
    // |                                                    12 bits value stored = (Addressable Lines / 2) - 1              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          4 Upper                   BYTE        bits 07:04 - 4 upper Addressable Lines                          |
    // |              Addressable                                                                                           |
    // |              Lines / Aspect                        bits 03:02 - Aspect Ratio                                       |
    // |              Ratio                                              0h -  4 : 3 AR                                     |
    // |                                                                 1h - 16 : 9 AR                                     |
    // |                                                                 2h - 16 : 10 AR                                    |
    // |                                                                 3h - 15 : 9 AR                                     |
    // |                                                                                                                    |
    // |                                                    bits 01:00 - Shall be set to 00b                                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Preferred Vertical        BYTE        bit 07 - Reserved set to 0b                                     |
    // |              Rate / Supported                                                                                      |
    // |              Vertical Rate And                     bits 03:02 - Preferred Vertical Rate                            |
    // |              Blanking Style                                     0h - 50 Hz                                         |
    // |                                                                 1h - 60 Hz                                         |
    // |                                                                 2h - 75 Hz                                         |
    // |                                                                 3h - 85 Hz                                         |
    // |                                                                                                                    |
    // |                                                    4 3 2 1 0 - Supported Vertical Rate & Blanking rate             |
    // |                                                    1 _ _ _ _ 50 Hz with standard blanking (CRT Style) is supported |
    // |                                                    _ 1 _ _ _ 60 Hz with standard blanking (CRT Style) is supported |
    // |                                                    _ _ 1 _ _ 75 Hz with standard blanking (CRT Style) is supported |
    // |                                                    _ _ _ 1 _ 85 Hz with standard blanking (CRT Style) is supported |
    // |                                                    _ _ _ _ 1 60 Hz with reduced blanking (as per CVT Standard) is  |
    // |                                                              supported                                             | 
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the information of a <see cref="KnownEdidSection.DataBlocks"/> of type <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/>.
    /// </summary>
    internal sealed class Cvt3ByteCodeDescriptorItem : BaseDataSection
    {
        #region constructor/s

        #region [public] ColorManagementDataDescriptorItem(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this block untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="Cvt3ByteCodeDescriptorItem"/> class with the data in this block untreated.
        /// </summary>
        /// <param name="blockData">Unprocessed data in this block</param>
        public Cvt3ByteCodeDescriptorItem(ReadOnlyCollection<byte> blockData) : base(blockData)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (byte) LowerAddressableLines: Gets a value that represents the '8 Lower Bits Addressable Lines' field
        /// <summary>
        /// Gets a value that represents the <c>8 Lower Bits Addressable Lines</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte LowerAddressableLines => RawData[0x00];
        #endregion

        #region [private] (byte) UpperAddressableLinesAndAspectRatio: Gets a value that represents the '4 Upper Bits Addressable Lines / Aspect Ratio' field.
        /// <summary>
        /// Gets a value that represents the <c>4 Upper Bits Addressable Lines / Aspect Ratio</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte UpperAddressableLinesAndAspectRatio => RawData[0x01];
        #endregion

        #region [private] (byte) UpperAddressableLines: Gets a value that represents the '4 Upper Bits Addressable Lines' field
        /// <summary>
        /// Gets a value that represents the <c>4 Upper Bits Addressable Lines</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte UpperAddressableLines => (byte) ((UpperAddressableLinesAndAspectRatio >> 0x04) & 0x0f);
        #endregion

        #region [private] (byte) AspectRatio: Gets a value that represents the 'Aspect Ratio' field
        /// <summary>
        /// Gets a value that represents the <c>Aspect Ratio</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte AspectRatio => (byte)((UpperAddressableLinesAndAspectRatio >> 0x02) & 0x03);
        #endregion

        #region [private] (byte) PreferredVerticalRateAndSupportedVerticalRateAndBlankingStyle: Gets a value that represents the 'Preferred Vertical Rate / Supported Vertical Rate And Blanking Style' field
        /// <summary>
        /// Gets a value that represents the <c>Preferred Vertical Rate / Supported Vertical Rate And Blanking Style</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte PreferredVerticalRateAndSupportedVerticalRateAndBlankingStyle => RawData[0x02];
        #endregion

        #region [private] (byte) PreferredVerticalRate: Gets a value that represents the 'Preferred Vertical Rate' field
        /// <summary>
        /// Gets a value that represents the <c>Preferred Vertical Rate</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte PreferredVerticalRate => (byte)((PreferredVerticalRateAndSupportedVerticalRateAndBlankingStyle >> 0x05) & 0x03);
        #endregion

        #region [private] (byte) SupportedVerticalRateAndBlankingStyle: Gets a value that represents the 'Supported Vertical Rate And Blanking Style' field
        /// <summary>
        /// Gets a value that represents the <c>Supported Vertical Rate And Blanking Style</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SupportedVerticalRateAndBlankingStyle => (byte)(PreferredVerticalRateAndSupportedVerticalRateAndBlankingStyle & 0x1f);
        #endregion

        #region [private] (bool) IsSupported50HzWithStandardBlanking: Gets a value that represents the 'Supported 50Hz with standard Blanking' field
        /// <summary>
        /// Gets a value that represents the <c>Supported 50Hz with standard Blanking</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsSupported50HzWithStandardBlanking => SupportedVerticalRateAndBlankingStyle.CheckBit(Bits.Bit04);
        #endregion

        #region [private] (bool) IsSupported60HzWithStandardBlanking: Gets a value that represents the 'Supported 60Hz with standard Blanking' field
        /// <summary>
        /// Gets a value that represents the <c>Supported 60Hz with standard Blanking</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsSupported60HzWithStandardBlanking => SupportedVerticalRateAndBlankingStyle.CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) IsSupported75HzWithStandardBlanking: Gets a value that represents the 'Supported 75Hz with standard Blanking' field
        /// <summary>
        /// Gets a value that represents the <c>Supported 75Hz with standard Blanking</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsSupported75HzWithStandardBlanking => SupportedVerticalRateAndBlankingStyle.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) IsSupported85HzWithStandardBlanking: Gets a value that represents the 'Supported 75Hz with standard Blanking' field
        /// <summary>
        /// Gets a value that represents the <c>Supported 85Hz with standard Blanking</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsSupported85HzWithStandardBlanking => SupportedVerticalRateAndBlankingStyle.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) IsSupported60HzWithReducedBlanking:  Gets a value that represents the 'Supported 60Hz with reduced Blanking' field
        /// <summary>
        /// Gets a value that represents the <c>Supported 60Hz with reduced Blanking</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsSupported60HzWithReducedBlanking => SupportedVerticalRateAndBlankingStyle.CheckBit(Bits.Bit00);
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
            properties.Add(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.AddressableVerticalLines, LogicHelper.Word(LowerAddressableLines, UpperAddressableLines));
            properties.Add(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.AspectRatio, GetAspectRatio(AspectRatio));
            properties.Add(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.PreferredVerticalRate, GetVerticalRate(PreferredVerticalRate));
            properties.Add(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.SupportedVerticalRateAndBlanking.IsSupported50HzWithStandardBlanking, IsSupported50HzWithStandardBlanking);
            properties.Add(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.SupportedVerticalRateAndBlanking.IsSupported60HzWithStandardBlanking, IsSupported60HzWithStandardBlanking);
            properties.Add(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.SupportedVerticalRateAndBlanking.IsSupported75HzWithStandardBlanking, IsSupported75HzWithStandardBlanking);
            properties.Add(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.SupportedVerticalRateAndBlanking.IsSupported85HzWithStandardBlanking, IsSupported85HzWithStandardBlanking);
            properties.Add(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.SupportedVerticalRateAndBlanking.IsSupported60HzWithReducedBlanking, IsSupported60HzWithReducedBlanking);
        }
        #endregion

        #endregion


        #region EDID 1.4 Specification

        #region [private] {static} (string) GetAspectRatio(byte): Returns a string that represents the aspect ratio
        /// <summary>
        /// Returns a string that represents the aspect ratio.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Aspect ratio value
        /// </returns>
        private static string GetAspectRatio(byte code)
        {
            var value = new[]
            {
                "4 : 3",
                "16 : 9",
                "16 : 10",
                "15 : 9"
            };

            return value[code];
        }
        #endregion

        #region [private] {static} (string) GetVerticalRate(byte): Returns a string that represents the vertical refresh rate
        /// <summary>
        /// Returns a string that represents the vertical refresh rate.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Vertical refresh rate
        /// </returns>
        private static byte GetVerticalRate(byte code)
        {
            var value = new byte[]
            {
                50,
                60,
                75,
                85
            };

            return value[code];
        }
        #endregion

        #endregion
    }
}
