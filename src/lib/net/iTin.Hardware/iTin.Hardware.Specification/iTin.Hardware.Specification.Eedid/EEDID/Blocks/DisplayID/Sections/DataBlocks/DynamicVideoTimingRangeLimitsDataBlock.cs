
namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Globalization;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    using ComponentModel;

    // Data Block: Dynamic Video Timing Range Limits Data Block
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                    Lenght      Description                                    |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          TAG                     1 BYTE      25h                                            |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Block Revision and      1 BYTE       Bits    Value                                 |
    // |              Other Data                          02:00    Block Revision, 000b Rev. 0 (default) |
    // |                                                  07:03    Reserved (Cleared to all 0s)          |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Number of Payload       1 BYTE      09h, Data block is composed of nine payload    |
    // |              Bytes in Block                      bytes.                                         |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          Minimum Pixel Clock     3 BYTEs     Required. Specifies the minimum pixel rate     |
    // |              (in kHz)                            above which dynamic video timing changes shall |
    // |                                                  be supported, as per the reported scheme       |
    // |                                                  Range shall be defined as 0.001 through        |
    // |                                                  16,777.216MP/s.                                |
    // |                                                  Value ranges from 000000h through FFFFFFh.     |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Maximum Pixel Clock     3 BYTEs     Required. Specifies the maximum pixel rate     |
    // |              (in kHz)                            below which dynamic video timing changes shall |
    // |                                                  be supported, as per the reported scheme       |
    // |                                                  Range shall be defined as 0.001 through        |
    // |                                                  16,777.216MP/s.                                |
    // |                                                  Value ranges from 000000h through FFFFFFh.     |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Minimum Vertical        1 BYTE      Required. Specifies the display device’s       |
    // |              Refresh Rate                        minimum dynamic vertical frequency.            |
    // |                                                  Vertical frequency shall be defined as follows |
    // |                                                  (PixelClock / HorizontalTotal) / VerticalTotal |
    // |                                                  Range shall be defined as 0 through 255Hz.     |
    // |                                                  Value ranges from 00h through FFh.             |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Maximum Vertical        1 BYTE      Required. Specifies the display device’s       |
    // |              Refresh Rate                        maximum dynamic vertical frequency.            |
    // |                                                  Range shall be defined as 0 through 255Hz.     |
    // |                                                  Value ranges from 00h through FFh.             |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh          Dynamic Video Timing    1 BYTE       Bits    Value                                 |
    // |              Range Support Flags                    07    Seamless Dynamic Video Timing Support |
    // |                                                           0 -> Seamless Dynamic Video Timing    |
    // |                                                                change shall not be supported    |
    // |                                                                with a fixed horizontal pixel    |
    // |                                                                rate and dynamic vertical        |
    // |                                                                blanking                         |
    // |                                                           1 -> Seamless Dynamic Video Timing    |
    // |                                                                change shall be supported with a |
    // |                                                                fixed horizontal pixel rate and  |
    // |                                                                dynamic vertical blanking.       |
    // |                                                  06:00    Reserved (Cleared to all 0s)          |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents a data block of type <see cref="DataBlockTag.DynamicVideoTimingRangeLimits"/>.
    /// </summary> 
    internal sealed class DynamicVideoTimingRangeLimitsDataBlock : BaseDataSection
    {
        #region constructor/s

        #region [public] DynamicVideoTimingRangeLimitsDataBlock(ReadOnlyCollection<byte>, int? = null): Initialize a new instance of the class with the data of this block untreated with version block
        /// <summary>
        /// Initialize a new instance of the <see cref="DynamicVideoTimingRangeLimitsDataBlock"/> class with the data of this block untreated with version block.
        /// </summary>
        /// <param name="dataBlock">Unprocessed data in this block</param>
        /// <param name="version">Block version.</param>
        public DynamicVideoTimingRangeLimitsDataBlock(ReadOnlyCollection<byte> dataBlock, int? version = null) : base(dataBlock, version)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (int) MinimumPixelClock: Gets a value representing the 'Minimum Pixel Clock' field
        /// <summary>
        /// Gets a value representing the <b>Minimum Pixel Clock</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MinimumPixelClock => int.Parse($"{RawData[0x05]:x2}{RawData[0x04]:x2}{RawData[0x03]:x2}", NumberStyles.AllowHexSpecifier);
        #endregion

        #region [private] (int) MaximumPixelClock: Gets a value representing the 'Maximum Pixel Clock' field
        /// <summary>
        /// Gets a value representing the <b>Maximum Pixel Clock</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MaximumPixelClock => int.Parse($"{RawData[0x08]:x2}{RawData[0x07]:x2}{RawData[0x06]:x2}", NumberStyles.AllowHexSpecifier);
        #endregion

        #region [private] (byte) MinimumVerticalRefreshRate: Gets a value representing the 'Minimum Vertical Refresh Rate' field
        /// <summary>
        /// Gets a value representing the <b>Minimum Vertical Refresh Rate</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MinimumVerticalRefreshRate => RawData[0x09];
        #endregion

        #region [private] (byte) MaximumVerticalRefreshRate: Gets a value representing the 'Maximum Vertical Refresh Rate' field
        /// <summary>
        /// Gets a value representing the <b>Maximum Vertical Refresh Rate</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MaximumVerticalRefreshRate => RawData[0x0a];
        #endregion

        #region [private] (bool) SupportSeamlessDynamicVideoTiming: Gets a value representing the 'Support Seamless Dynamic Video Timing' field
        /// <summary>
        /// Gets a value representing the <b>Support Seamless Dynamic Video Timing</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool SupportSeamlessDynamicVideoTiming => RawData[0x0b].CheckBit(Bits.Bit07);
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
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DynamicVideoTimingRangeLimits.MinimumPixelClock, MinimumPixelClock);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DynamicVideoTimingRangeLimits.MaximumPixelClock, MaximumPixelClock);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DynamicVideoTimingRangeLimits.MinimumVerticalRefreshRate, MinimumVerticalRefreshRate);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DynamicVideoTimingRangeLimits.MaximumVerticalRefreshRate, MaximumVerticalRefreshRate);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DynamicVideoTimingRangeLimits.SupportSeamlessDynamicVideoTiming, SupportSeamlessDynamicVideoTiming);
        }
        #endregion

        #endregion
    }
}
