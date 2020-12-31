
namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Globalization;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    using ComponentModel;

    // Data Block: Detailed Timing Type I Definition
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                    Lenght      Description                                    |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // |                                                                                                 |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents a <b>Detailed Timing Type I</b> entry defined in <see cref="DataBlockTag.DetailedTimingTypeI"/> data block.
    /// </summary> 
    public sealed class DetailedTimingTypeIData : BaseDataSection
    {
        #region constructor/s

        #region [public] DetailedTimingTypeIData(ReadOnlyCollection<byte>, int? = null): Initialize a new instance of the class with the data of this block untreated with version block
        /// <summary>
        /// Initialize a new instance of the <see cref="DetailedTimingTypeIData"/> class with the data of this block untreated with version block.
        /// </summary>
        /// <param name="dataBlock">Unprocessed data in this block</param>
        /// <param name="version">Block version.</param>
        public DetailedTimingTypeIData(ReadOnlyCollection<byte> dataBlock, int? version = null) : base(dataBlock, version)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region PixelClock

        #region [private] (int) PixelClock: Gets a value representing the 'Pixel Clock' field
        /// <summary>
        /// Gets a value representing the <c>Pixel Clock</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int PixelClock => int.Parse($"{PixelClockHigh:x2}{PixelClockMiddle:x2}{PixelClockLow:x2}", NumberStyles.AllowHexSpecifier);
        #endregion

        #region [private] (byte) PixelClockLow: Gets a value representing the 'Pixel Clock Low' field
        /// <summary>
        /// Gets a value representing the <c>Pixel Clock Low</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte PixelClockLow => RawData[0x00];
        #endregion

        #region [private] (byte) PixelClockMiddle: Gets a value representing the 'Pixel Clock Middle' field
        /// <summary>
        /// Gets a value representing the <c>Pixel Clock Middle</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte PixelClockMiddle => RawData[0x01];
        #endregion

        #region [private] (byte) PixelClockHigh: Gets a value representing the 'Pixel Clock High' field
        /// <summary>
        /// Gets a value representing the <c>Pixel Clock High</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte PixelClockHigh => RawData[0x02];
        #endregion

        #endregion

        #region Timing Options

        #region [private] (byte) TimingOptions: Gets a value representing the 'Timing Options' field
        /// <summary>
        /// Gets a value representing the <c>Timing Options</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte TimingOptions => RawData[0x03];
        #endregion

        #region [private] (byte) AspectRatio: Gets a value representing the 'Aspect Ratio' field
        /// <summary>
        /// Gets a value representing the <c>Aspect Ratio</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte AspectRatio => (byte)(TimingOptions & 0x0f);
        #endregion

        #region [private] (bool) Interlaced: Gets a value representing the 'Interlaced' field
        /// <summary>
        /// Gets a value representing the <c>Interlaced</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Interlaced => TimingOptions.CheckBit(Bits.Bit04);
        #endregion

        #region [private] (byte) Stereo3DSupport: Gets a value representing the '3D Stereo Support' field
        /// <summary>
        /// Gets a value representing the <c>3D Stereo Support</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Stereo3DSupport => (byte)(TimingOptions >> 0x05 & 0x03);
        #endregion

        #region [private] (bool) IsPreferredTiming: Gets a value representing the 'Is Preferred Timing' field
        /// <summary>
        /// Gets a value representing the <c>Is Preferred Timing</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsPreferredTiming => TimingOptions.CheckBit(Bits.Bit07);
        #endregion

        #endregion

        #region Horizontal Active Image Pixels

        #region [private] (int) HorizontalActiveImagePixels: Gets a value representing the 'Horizontal Active Image Pixels' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Active Image Pixels</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int HorizontalActiveImagePixels => int.Parse($"{HorizontalActiveImagePixelsHigh:X2}{HorizontalActiveImagePixelsLow:X2}", NumberStyles.AllowHexSpecifier); 
        #endregion

        #region [private] (byte) HorizontalActiveImagePixelsLow: Gets a value representing the 'Horizontal Active Image Pixels Low' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Active Image Pixels Low</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte HorizontalActiveImagePixelsLow => RawData[0x04];
        #endregion

        #region [private] (byte) HorizontalActiveImagePixelsHigh: Gets a value representing the 'Horizontal Active Image Pixels High' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Active Image Pixels High</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte HorizontalActiveImagePixelsHigh => RawData[0x05];
        #endregion

        #endregion

        #region Horizontal Blank Pixels

        #region [private] (int) HorizontalBlankPixels: Gets a value representing the 'Horizontal Blank Pixels' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Blank Pixels</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int HorizontalBlankPixels => int.Parse($"{HorizontalBlankPixelsHigh:X2}{HorizontalBlankPixelsLow:X2}", NumberStyles.AllowHexSpecifier);
        #endregion

        #region [private] (byte) HorizontalBlankPixelsLow: Gets a value representing the 'Horizontal Blank Pixels Low' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Blank Pixels Low</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte HorizontalBlankPixelsLow => RawData[0x06];
        #endregion

        #region [private] (byte) HorizontalBlankPixelsHigh: Gets a value representing the 'Horizontal Blank Pixels High' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Blank Pixels High</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte HorizontalBlankPixelsHigh => RawData[0x07];
        #endregion

        #endregion

        #region Horizontal Offset (Front Porch)

        #region [private] (int) HorizontalFrontPorchOffset: Gets a value representing the 'Horizontal Front Porch Offset' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Front Porch Offset</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int HorizontalFrontPorchOffset => int.Parse($"{HorizontalFrontPorchOffsetHigh:X2}{HorizontalFrontPorchOffsetLow:X2}", NumberStyles.AllowHexSpecifier);
        #endregion

        #region [private] (byte) HorizontalFrontPorchOffsetLow: Gets a value representing the 'Horizontal Front Porch Offset Low' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Front Porch Offset Low</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte HorizontalFrontPorchOffsetLow => RawData[0x08];
        #endregion

        #region [private] (byte) HorizontalFrontPorchOffsetHigh: Gets a value representing the 'Horizontal Front Porch Offset High' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Front Porch Offset High</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte HorizontalFrontPorchOffsetHigh => RawData[0x09];
        #endregion

        #region [private] (bool) IsHorizontalPositiveSyncPolarity: Gets a value representing the 'Horizontal Sync Polarity' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Sync Polarity</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsHorizontalPositiveSyncPolarity => HorizontalFrontPorchOffset.CheckBit(Bits.Bit15);
        #endregion

        #endregion

        #region Horizontal Sync Width

        #region [private] (int) HorizontalSyncWidth: Gets a value representing the 'Horizontal Sync Width' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Sync Width</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int HorizontalSyncWidth => int.Parse($"{HorizontalSyncWidthHigh:X2}{HorizontalSyncWidthLow:X2}", NumberStyles.AllowHexSpecifier);
        #endregion

        #region [private] (byte) HorizontalSyncWidthLow: Gets a value representing the 'Horizontal Sync Width Low' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Sync Width Low</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte HorizontalSyncWidthLow => RawData[0x0a];
        #endregion

        #region [private] (byte) HorizontalSyncWidthHigh: Gets a value representing the 'Horizontal Sync Width High' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Sync Width High</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte HorizontalSyncWidthHigh => RawData[0x0b];
        #endregion

        #endregion

        #region Vertical Active Image Lines
        
        #region [private] (int) VerticalActiveImageLines: Gets a value representing the 'Horizontal Active Image Pixels' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Active Image Pixels Low</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int VerticalActiveImageLines => int.Parse($"{VerticalActiveImageLinesHigh:X2}{VerticalActiveImageLinesLow:X2}", NumberStyles.AllowHexSpecifier);
        #endregion

        #region [private] (byte) VerticalActiveImageLinesLow: Gets a value representing the 'Vertical Active Image Lines Low' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Active Image Lines Low</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte VerticalActiveImageLinesLow => RawData[0x0c];
        #endregion

        #region [private] (byte) VerticalActiveImageLinesHigh: Gets a value representing the 'Vertical Active Image Lines High' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Active Image Lines High</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte VerticalActiveImageLinesHigh => RawData[0x0d];
        #endregion

        #endregion

        #region Vertical Blank Lines

        #region [private] (int) VerticalBlankLines: Gets a value representing the 'Vertical Blank Lines' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Blank Lines</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int VerticalBlankLines=> int.Parse($"{VerticalBlankLinesHigh:X2}{VerticalBlankLinesLow:X2}", NumberStyles.AllowHexSpecifier);
        #endregion

        #region [private] (byte) VerticalBlankLinesLow: Gets a value representing the 'Vertical Blank Lines Low' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Blank Lines Low</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte VerticalBlankLinesLow => RawData[0x0e];
        #endregion

        #region [private] (byte) VerticalBlankLinesHigh: Gets a value representing the 'Vertical Blank Lines High' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Blank Lines High</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte VerticalBlankLinesHigh => RawData[0x0f];
        #endregion

        #endregion

        #region Vertical Sync Offset (Front Porch)

        #region [private] (int) VerticalSyncFrontPorchOffset: Gets a value representing the 'Vertical Sync Front Porch Offset' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Sync Front Porch Offset</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int VerticalSyncFrontPorchOffset => int.Parse($"{VerticalSyncFrontPorchOffsetHigh:X2}{VerticalSyncFrontPorchOffsetLow:X2}", NumberStyles.AllowHexSpecifier);
        #endregion

        #region [private] (byte) VerticalSyncForntPorchOffsetLow: Gets a value representing the 'Vertical Sync Front Porch Offset Low' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Sync Front Porch Offset Low</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte VerticalSyncFrontPorchOffsetLow => RawData[0x10];
        #endregion

        #region [private] (byte) VerticalSyncFrontPorchOffsetHigh: Gets a value representing the 'Vertical Sync Front Porch Offset High' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Sync Front Porch Offset High</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte VerticalSyncFrontPorchOffsetHigh => RawData[0x11];
        #endregion

        #region [private] (bool) IsVerticalSyncPositivePolarity: Gets a value representing the 'Vertical Sync Polarity' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Sync Polarity</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsVerticalSyncPositivePolarity => VerticalSyncFrontPorchOffset.CheckBit(Bits.Bit15);
        #endregion

        #endregion

        #region Vertical Sync Width

        #region [private] (int) VerticalSyncWidth: Gets a value representing the 'Vertical Sync Width' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Sync Width</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int VerticalSyncWidth => int.Parse($"{VerticalSyncWidthHigh:X2}{VerticalSyncWidthLow:X2}", NumberStyles.AllowHexSpecifier);
        #endregion

        #region [private] (byte) VerticalSyncWidthLow: Gets a value representing the 'Vertical Sync Width Low' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Sync Width Low</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte VerticalSyncWidthLow => RawData[0x12];
        #endregion

        #region [private] (byte) VerticalSyncWidthHigh: Gets a value representing the 'Vertical Sync Width High' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Sync Width High</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte VerticalSyncWidthHigh => RawData[0x13];
        #endregion

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
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.PixelClock, PixelClock);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.AspectRatio, GetAspectRatio(AspectRatio));
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.InterfaceFrameScanningType, GetInterfaceFrameScanningType(Interlaced));
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.Stereo3DSupport, GetStereo3DSupport(Stereo3DSupport));
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.IsPreferredTiming, IsPreferredTiming);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.HorizontalActiveImage, HorizontalActiveImagePixels);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.HorizontalBlankPixels, HorizontalBlankPixels);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.HorizontalFrontPorchOffset, HorizontalFrontPorchOffset);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.HorizontalSyncPolarity, GetSyncPolarity(IsHorizontalPositiveSyncPolarity));
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.HorizontalSyncWidth, HorizontalSyncWidth);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.HorizontalSyncWidth, HorizontalSyncWidth);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.VerticalActiveImage, VerticalActiveImageLines);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.VerticalBlankLines, VerticalBlankLines);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.VerticalSyncFrontPorchOffset, VerticalSyncFrontPorchOffset);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.VerticalSyncPolarity, GetSyncPolarity(IsVerticalSyncPositivePolarity));
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DetailedTimingTypeI.Timing.VerticalSyncWidth, VerticalSyncWidth);
        }
        #endregion

        #endregion


        #region VESA Display Identification Data (DisplayID)

        private static string GetInterfaceFrameScanningType(bool interlaced) => interlaced ? "Interlaced" : "Progressive";

        private static string GetSyncPolarity(bool isPositiveSyncPolarity) => isPositiveSyncPolarity ? "Positive" : "Negative";

        private static string GetStereo3DSupport(byte code)
        {
            var items = new List<string>
            {
                "Mono",          // 0x00
                "Stereo",
                "Mono or Stereo" // 0x02
            };

            return code > 0x02
                ? "Reserved"
                : items[code];
        }


        private string GetAspectRatio(byte code)
        {
            var items = new List<string>
            {
                "1:1",     // 0x00
                "5:4",
                "4:3",
                "15:9",
                "16:9",
                "16:10",
                "67:27",
                "256:135", // 0x07
            };

            if (code == 0x08)
            {
                return $"{HorizontalActiveImagePixels}:{VerticalActiveImageLines}";
            }

            return code > 0x07
                ? "Reserved"
                : items[code];
        }

        #endregion
    }
}
