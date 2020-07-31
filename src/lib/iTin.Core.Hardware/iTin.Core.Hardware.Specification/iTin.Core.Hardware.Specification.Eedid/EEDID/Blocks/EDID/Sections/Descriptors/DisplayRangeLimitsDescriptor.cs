
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Helpers.Enumerations;

    // Data Block Descriptor: Display Range Limits & Additional Timming Descriptor Block Definition
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                                                                      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Display Range Limits      BYTE        Flags. Other reserved values do not use.                                                         |
    // |              Offsets                               7 6 5 4 | 3 2 1 0                                                                                |
    // |                                                    0 0 0 0 | _ _ 0 0 -> Vertical rate offset are zero.                                              |
    // |                                                    0 0 0 0 | _ _ 1 0 -> Max. Vertical Rate +255 Hz Offset, Min. Vertical Rate without offset.       |
    // |                                                    0 0 0 0 | _ _ 1 1 -> Max. Vertical Rate +255 Hz Offset, Min. Vertical Rate +255 Hz offset.       |
    // |                                                    0 0 0 0 | 0 0 _ _ -> Horizontal rate offset are zero.                                            |
    // |                                                    0 0 0 0 | 1 0 _ _ -> Max. Horizontal Rate +255 KHz Offset, Min. Horizontal Rate without offset.  |
    // |                                                    0 0 0 0 | 1 1 _ _ -> Max. Horizontal Rate +255 KHz Offset, Min. Horizontal Rate +255 KHz offset. |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Minimun Vertical          BYTE        Values:                                                                                          |
    // |              Rate                                                 00h - Reserved.                                                                   |
    // |                                                             01h - ffh - If [Byte 04h, bits 0, 1] <> 11b -> rate in Hz (rango 1Hz - 255Hz)           |
    // |                                                                         If [Byte 04h, bits 0, 1] == 11b -> rate in Hz (rango 256Hz - 510Hz)         |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Maximun Vertical          BYTE        Values:                                                                                          |
    // |              Rate                                                 00h - Reserved.                                                                   |
    // |                                                             01h - ffh - If [Byte 04h, bit 1] <> 1b -> rate in Hz (rango 1Hz - 255Hz)                |
    // |                                                                         If [Byte 04h, bit 1] == 1b -> rate in Hz (rango 256Hz - 510Hz)              |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          Minimun Horizontal        BYTE        Values:                                                                                          |
    // |              Rate                                                 00h - Reserved.                                                                   |
    // |                                                             01h - ffh - If [Byte 04h, bits 3, 2] <> 11b -> rate in KHz (rango 1KHz - 255KHz)        |
    // |                                                                         If [Byte 04h, bits 3, 2] == 11b -> rate in KHz (rango 256KHz - 510KHz)      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Maximun Horizontal        BYTE        Values:                                                                                          |
    // |              Rate                                                 00h - Reserved.                                                                   |
    // |                                                             01h - ffh - If [Byte 04h, bit 3] <> 1b -> rate in KHz (rango 1KHz - 255KHz)             |
    // |                                                                         If [Byte 04h, bit 3] == 1b -> rate in KHz (rango 256KHz - 510KHz)           |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Maximun Pixel Clock       BYTE        Values:                                                                                          |
    // |                                                                   00h - Reserved.                                                                   |
    // |                                                             01h - ffh - Binary coded clock rate in Mhz / 10. Example: 130Mhz es '0dh'.              |
    // |                                                                         This value must be rounded to the nearest 10Mhz multiplex.                  |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Video Timming             BYTE        Bytes 0ah -> 11h indicate support for additional video timings.                                  |
    // |              Support Flags                         Values:                                                                                          |
    // |                                                                   00h - Default GTF supported if bit 0 in Feature Support Byte at address 18h = 1.  |
    // |                                                                   01h - Range Limits Only. No additional timing information is provided.            |
    // |                                                                   02h - Secondary GTF supported. Requires support for Default GTF.                  |
    // |                                                                   03h - Reserved for future timing definitions.                                     |
    // |                                                                   04h - CTV supported if bit 0 in Feature Support Byte at address 18h = 1.          |
    // |                                                             05h - ffh - Reserved for future timing definitions.                                     |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Line Feed / Video         BYTE        Line feed (0ah) , if Byte 0ah = 00h or Byte 0ah = 01h.                                           |
    // |              Timing Data                           video Timing Data (00h -> ffh), if Byte 0ah = 02h or Byte 0ah = 04h.                             |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h -> 0ch   Space / Video             7 BYTEs     Space (20h) , If Byte 0ah = 00h or Byte 0ah = 01h.                                               |
    // |              Timing Data                           video Timing Data (00h -> ffh), If Byte 0ah = 02h or Byte 0ah = 04h.                             |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="KnownEdidSection.DataBlocks"/> section of type this block <see cref="EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits"/>.
    /// </summary> 
    internal sealed class DisplayRangeLimitsDescriptor : BaseDataSection
    {
        #region constructor/s

        #region [public] DisplayRangeLimitsDescriptor(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data of this block untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="DisplayRangeLimitsDescriptor"/> class with the data of this block untreated.
        /// </summary>
        /// <param name="dataBlock">Unprocessed data in this block</param>
        public DisplayRangeLimitsDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region Display Range Limits Offesets

        #region [private] (byte) DisplayRangeLimitsFlags: Gets a value representing the 'Display Range Limits Flags' field
        /// <summary>
        /// Gets a value representing the <c>Display Range Limits Flags</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DisplayRangeLimitsFlags => RawData[0x04];
        #endregion

        #region [private] (bool) VerticalRateOffsetsAreZero: Gets a value representing the 'Vertical Rate Offsets Are Zero' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Rate Offsets Are Zero</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool VerticalRateOffsetsAreZero => (byte)(DisplayRangeLimitsFlags & 0x03) == 0x00;
        #endregion

        #region [private] (bool) UseHighRangeForMinimumVerticalRate: Gets a value that determines if the high frequency range is used
        /// <summary>
        /// Gets a value that determines if the high frequency range is used.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool UseHighRangeForMinimumVerticalRate => (byte)(DisplayRangeLimitsFlags & 0x03) == 0x03;
        #endregion

        #region [private] (bool) UseHighRangeForMaximumVerticalRate: Gets a value that determines if the high frequency range is used
        /// <summary>
        /// Gets a value that determines if the high frequency range is used.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool UseHighRangeForMaximumVerticalRate => DisplayRangeLimitsFlags.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) HorizontalRateOffsetsAreZero: Gets a value representing the 'Horizontal Rate Offsets Are Zero' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Rate Offsets Are Zero</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool HorizontalRateOffsetsAreZero => (byte)((DisplayRangeLimitsFlags >> 2) & 0x03) == 0x00;
        #endregion

        #region [private] (bool) UseHighRangeForMinimumHorizontalRate: Gets a value that determines if the high frequency range is used
        /// <summary>
        /// Gets a value that determines if the high frequency range is used.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool UseHighRangeForMinimumHorizontalRate => (byte)((DisplayRangeLimitsFlags >> 2) & 0x03) == 0x03;
        #endregion

        #region [private] (bool) UseHighRangeForMaximumHorizontalRate: Gets a value that determines if the high frequency range is used
        /// <summary>
        /// Gets a value that determines if the high frequency range is used.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool UseHighRangeForMaximumHorizontalRate => DisplayRangeLimitsFlags.CheckBit(Bits.Bit03);
        #endregion

        #endregion

        #region [private] (int) MinimumVerticalRate: Gets a value representing the 'Minimum Vertical Rate' field
        /// <summary>
        /// Gets a value representing the <c>Minimum Vertical Rate</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MinimumVerticalRate => RawData[0x05] + (UseHighRangeForMinimumVerticalRate ?  0x100 : 0x00);
        #endregion

        #region [private] (int) MaximumVerticalRate: Gets a value representing the 'Maximum Vertical Rate' field
        /// <summary>
        /// Gets a value representing the <c>Maximum Vertical Rate</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MaximumVerticalRate => RawData[0x06] + (UseHighRangeForMaximumVerticalRate ? 0x100 : 0x00);
        #endregion

        #region [private] (int) MinimumHorizontalRate: Gets a value representing the 'Minimum Horizontal Rate' field
        /// <summary>
        /// Gets a value representing the <c>Minimum Horizontal Rate</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MinimumHorizontalRate => RawData[0x07] + (UseHighRangeForMinimumHorizontalRate ? 0x100 : 0x00);
        #endregion

        #region [private] (int) MaximumVerticalRate: Gets a value representing the 'Maximum Horizontal Rate' field
        /// <summary>
        /// Gets a value representing the <c>Maximum Horizontal Rate</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MaximumHorizontalRate => RawData[0x08] + (UseHighRangeForMaximumHorizontalRate ? 0x100 : 0x00);
        #endregion

        #region [private] (int) MaximumPixelClock: Gets a value representing the 'Maximum Pixel Clock' field
        /// <summary>
        /// Gets a value representing the <c>Maximum Pixel Clock</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MaximumPixelClock => RawData[0x09] * 0x0a;
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
            properties.Add(EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MinimumVerticalRate, MinimumVerticalRate);
            properties.Add(EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MaximumVerticalRate, MaximumVerticalRate);
            properties.Add(EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MinimumHorizontalRate, MinimumHorizontalRate);
            properties.Add(EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MaximumHorizontalRate, MaximumHorizontalRate);
            properties.Add(EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MaximumPixelClock, MaximumPixelClock);
        }
        #endregion

        #endregion
    }
}
