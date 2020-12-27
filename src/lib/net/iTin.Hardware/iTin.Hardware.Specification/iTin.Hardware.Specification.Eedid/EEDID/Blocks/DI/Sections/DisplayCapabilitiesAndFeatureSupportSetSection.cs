
namespace iTin.Hardware.Specification.Eedid.Blocks.DI.Sections
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    // DI Section: Display Capabilities & Feature Support Set
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                                  Lenght      Description                                                                       |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Miscellaneous Display Capabilities    BYTE                                                                                          |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Frame Rate Conversion                 5 BYTE                                                                                        |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Display/Scan Orientation              BYTE                                                                                          |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Color/Luminance Decoding Description  4 BYTE                                                                                        |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh          Monitor Color Depth                   7 BYTE                                                                                        |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 11h          Aspect Ratio Conversion Modes         1 BYTE                                                                                        |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 12h          Packetized Digital Video Support      16 BYTE                                                                                       |
    // |              Information                                                                                                                         |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/> section of this block <see cref="KnownDataBlock.DI"/>.
    /// </summary> 
    internal sealed class DisplayCapabilitiesAndFeatureSupportSetSection : BaseDataSection
    {
        #region constructor/s

        #region [public] DisplayCapabilitiesAndFeatureSupportSetSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayCapabilitiesAndFeatureSupportSetSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public DisplayCapabilitiesAndFeatureSupportSetSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) MiscellaneousDisplayCapabilities: Gets a value representing the 'Miscellaneous Display Capabilities' field
        /// <summary>
        /// Gets a value representing the <b>Miscellaneous Display Capabilities</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MiscellaneousDisplayCapabilities => RawData[0x00];

        #endregion

        #region [private] (bool) LegacyModes: Gets a value representing the 'Legacy Modes' field
        /// <summary>
        /// Gets a value representing the <b>Legacy Modes</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool LegacyModes => MiscellaneousDisplayCapabilities.CheckBit(Bits.Bit07);
        #endregion

        #region [private] (byte) StereoVideo: Gets a value representing the 'Stereo Video' field
        /// <summary>
        /// Gets a value representing the <b>Stereo Video</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte StereoVideo => (byte)((MiscellaneousDisplayCapabilities >> 4) & 0x07);
        #endregion

        #region [private] (bool) ScalerOnBoard: Gets a value representing the 'Scaler On Board' field
        /// <summary>
        /// Gets a value representing the <b>Scaler On Board</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool ScalerOnBoard => MiscellaneousDisplayCapabilities.CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) ImageCentering: Gets a value representing the 'Image Centering' field
        /// <summary>
        /// Gets a value representing the <b>Image Centering</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool ImageCentering => MiscellaneousDisplayCapabilities.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) ImageCentering: Gets a value representing the 'Conditional Update' field
        /// <summary>
        /// Gets a value representing the <b>Conditional Update</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool ConditionalUpdate => MiscellaneousDisplayCapabilities.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) InterlacedVideo: Gets a value representing the 'Interlaced Video' field
        /// <summary>
        /// Gets a value representing the <b>Interlaced Video</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool InterlacedVideo => MiscellaneousDisplayCapabilities.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (byte) FrameRateConversionEntry: Gets a value representing the 'Frame Rate Conversion Entry' field
        /// <summary>
        /// Gets a value representing the <b>Frame Rate Conversion Entry</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte FrameRateConversionEntry => RawData[0x01];

        #endregion

        #region [private] (bool) FrameLock: Gets a value representing the 'Frame Lock' field
        /// <summary>
        /// Gets a value representing the <b>Frame Lock</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool FrameLock => FrameRateConversionEntry.CheckBit(Bits.Bit07);
        #endregion

        #region [private] (byte) FrameRateConversion: Gets a value representing the 'Frame Rate Conversion' field
        /// <summary>
        /// Gets a value representing the <b>Frame Rate Conversion</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte FrameRateConversion => (byte)((FrameRateConversionEntry >> 5) & 0x03);
        #endregion

        #region [private] (byte) VerticalFrequency: Gets a value representing the 'Vertical Frequency' field
        /// <summary>
        /// Gets a value representing the <b>Vertical Frequency</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int VerticalFrequency => RawData.GetWord(2);
        #endregion

        #region [private] (byte) HorizontalFrequency: Gets a value representing the 'Horizontal Frequency' field
        /// <summary>
        /// Gets a value representing the <b>Horizontal Frequency</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int HorizontalFrequency => RawData.GetWord(4);
        #endregion

        #region [private] (byte) DisplayScanOrientationEntry: Gets a value representing the 'Display/Scan Orientation Entry' field
        /// <summary>
        /// Gets a value representing the <b>Display/Scan Orientation Entry</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DisplayScanOrientationEntry => RawData[0x06];
        #endregion

        #region [private] (byte) DisplayScanOrientationType: Gets a value representing the 'Display/Scan Orientation Definition Type' field
        /// <summary>
        /// Gets a value representing the <b>Display/Scan Orientation Definition Type</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DisplayScanOrientationType => (byte) ((DisplayScanOrientationEntry >> 6) & 0x03);
        #endregion

        #region [private] (bool) ScreenOrientation: Gets a value representing the 'Screen Orientation' field
        /// <summary>
        /// Gets a value representing the <b>Screen Orientation</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool ScreenOrientation => DisplayScanOrientationEntry.CheckBit(Bits.Bit05);
        #endregion

        #region [private] (byte) ZeroPixelLocation: Gets a value representing the 'Zero Pixel Location' field
        /// <summary>
        /// Gets a value representing the <b>Zero Pixel Location</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ZeroPixelLocation => (byte)((DisplayScanOrientationEntry >> 3) & 0x03);
        #endregion

        #region [private] (byte) ScanDirection: Gets a value representing the 'Scan Direction' field
        /// <summary>
        /// Gets a value representing the <b>Scan Direction</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ScanDirection => (byte) ((DisplayScanOrientationEntry >> 1) & 0x03);
        #endregion

        #region [private] (bool) StandaloneProjector: Gets a value representing the 'Standalone Projector' field
        /// <summary>
        /// Gets a value representing the <b>Standalone Projector</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool StandaloneProjector => DisplayScanOrientationEntry.CheckBit(Bits.Bit00);
        #endregion

        #region [private] (byte) DefaultColorLuminanceDecoding: Gets a value representing the 'Color/Luminance Decoding Description' field
        /// <summary>
        /// Gets a value representing the <b>Color/Luminance Decoding Description</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DefaultColorLuminanceDecoding => RawData[0x07];
        #endregion

        #region [private] (byte) PreferredColorLuminanceDecoder: Gets a value representing the 'Preferred Color/Luminance Decoder' field
        /// <summary>
        /// Gets a value representing the <b>Preferred Color/Luminance Decoder</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte PreferredColorLuminanceDecoder => RawData[0x08];
        #endregion

        #region [private] (byte) ColorLuminanceDecodingCapabilities: Gets a value representing the 'Color/Luminance Decoding Capabilities' field
        /// <summary>
        /// Gets a value representing the <b>Color/Luminance Decoding Capabilities</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int ColorLuminanceDecodingCapabilities => RawData.GetWord(0x09);
        #endregion

        #region [private] (bool) Dithering: Gets a value representing the 'Dithering' field
        /// <summary>
        /// Gets a value representing the <b>Dithering</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Dithering => RawData[0x0b].CheckBit(Bits.Bit07);
        #endregion

        #region [private] (bool) SupportedColorBitDepthSubChannel0Blue: Gets a value representing the 'Supported Color Bit-Depth of Sub-Channel 0 (Blue)' field
        /// <summary>
        /// Gets a value representing the <b>Supported Color Bit-Depth of Sub-Channel 0 (Blue)</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SupportedColorBitDepthSubChannel0Blue => RawData[0x0c];
        #endregion

        #region [private] (bool) SupportedColorBitDepthSubChannel1Green: Gets a value representing the 'Supported Color Bit-Depth of Sub-Channel 1 (Green)' field
        /// <summary>
        /// Gets a value representing the <b>Supported Color Bit-Depth of Sub-Channel 1 (Green)</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SupportedColorBitDepthSubChannel1Green => RawData[0x0d];
        #endregion

        #region [private] (bool) SupportedColorBitDepthSubChannel2Red: Gets a value representing the 'Supported Color Bit-Depth of Sub-Channel 2 (Red)' field
        /// <summary>
        /// Gets a value representing the <b>Supported Color Bit-Depth of Sub-Channel 2 (Red)</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SupportedColorBitDepthSubChannel2Red => RawData[0x0e];
        #endregion

        #region [private] (bool) SupportedColorBitDepthSubChannel0CbPb: Gets a value representing the 'Supported Color Bit-Depth of Sub-Channel 0 (Cb/Pb)' field
        /// <summary>
        /// Gets a value representing the <b>Supported Color Bit-Depth of Sub-Channel 0 (Cb/Pb)</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SupportedColorBitDepthSubChannel0CbPb => RawData[0x0f];
        #endregion

        #region [private] (bool) SupportedColorBitDepthSubChannel1Y: Gets a value representing the 'Supported Color Bit-Depth of Sub-Channel 1 (Y)' field
        /// <summary>
        /// Gets a value representing the <b>Supported Color Bit-Depth of Sub-Channel 1 (Y)</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SupportedColorBitDepthSubChannel1Y => RawData[0x10];
        #endregion

        #region [private] (bool) SupportedColorBitDepthSubChannel2CrPr: Gets a value representing the 'Supported Color Bit-Depth of Sub-Channel 2 (Cr/Pr)' field
        /// <summary>
        /// Gets a value representing the <b>Supported Color Bit-Depth of Sub-Channel 2 (Cr/Pr)</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SupportedColorBitDepthSubChannel2CrPr => RawData[0x11];
        #endregion

        #region [private] (bool) AspectRatioConversionModes: Gets a value representing the 'Aspect Ratio Conversion Modes' field
        /// <summary>
        /// Gets a value representing the <b>Aspect Ratio Conversion Modes</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte AspectRatioConversionModes => RawData[0x12];
        #endregion

        #region [private] (ReadOnlyCollection<byte>) PacketizedDigitalVideoSupportInformation: Gets a value representing the 'Packetized Digital Video Support Information' field
        /// <summary>
        /// Gets a value representing the <b>Packetized Digital Video Support Information</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ReadOnlyCollection<byte> PacketizedDigitalVideoSupportInformation => RawData.Extract((byte)0x13, (byte)0x10);
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
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.LegacyModes, GetLegacyModes(LegacyModes));
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.StereoVideo, GetStereoVideo(StereoVideo));
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ScalerOnBoard, ScalerOnBoard);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ImageCentering, ImageCentering);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ConditionalUpdate, ConditionalUpdate);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.InterlacedVideo, InterlacedVideo);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.FrameLock, FrameLock);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.FrameRateConversion, GetFrameRateConversion(FrameRateConversion));
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.VerticalFrequency, VerticalFrequency);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.HorizontalFrequency, HorizontalFrequency);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.DisplayScanOrientationType, GetDisplayScanOrientationType(DisplayScanOrientationType));
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ScreenOrientation, GetScreenOrientation(ScreenOrientation));
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ZeroPixelLocation, GetZeroPixelLocation(ZeroPixelLocation));
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ScanDirection, GetScanDirection(ScanDirection));
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.StandaloneProjector, StandaloneProjector);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.DefaultColorLuminanceDecoding, GetDefaultColorLuminanceDecoding(DefaultColorLuminanceDecoding));
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.PreferredColorLuminanceDecoder, GetPreferredColorLuminanceDecoder(PreferredColorLuminanceDecoder));
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ColorLuminanceDecodingCapabilities, GetColorLuminanceDecodingCapabilities(ColorLuminanceDecodingCapabilities));
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.Dithering, Dithering);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0Blue, SupportedColorBitDepthSubChannel0Blue);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Green, SupportedColorBitDepthSubChannel1Green);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2Red, SupportedColorBitDepthSubChannel2Red);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0CbPb, SupportedColorBitDepthSubChannel0CbPb);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Y, SupportedColorBitDepthSubChannel1Y);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2CrPr, SupportedColorBitDepthSubChannel2CrPr);
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.AspectRatioConversionModes, GetAspectRatioConversionModes(AspectRatioConversionModes));
            properties.Add(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.PacketizedDigitalVideoSupportInformation, PacketizedDigitalVideoSupportInformation);
        }
        #endregion

        #endregion


        #region VESA Display Information Extension Block Standard

        private static string GetAspectRatioConversionModes(byte code)
        {
            if (code == 0x00)
            {
                return "None";
            }

            if (code.CheckBit(Bits.Bit04))
            {
                return "Variable Mode";
            }

            if (code.CheckBit(Bits.Bit05))
            {
                return "Squeeze Mode";
            }

            if (code.CheckBit(Bits.Bit06))
            {
                return "Zoom Mode";
            }

            return "Full Mode";
        }

        private static string[] GetColorLuminanceDecodingCapabilities(int code)
        {
            if (code == 0x00)
            {
                return new[] {"None"};
            }

            var items = new List<string>
            {
                "Monochrome",                // 0x02
                "Y B-Y R-Y M-2, Matsushita",
                "Y B-Y R-Y BetaCam, Sony",
                "YPbPr, Modern HDTV",
                "YCrCb, Modern HDTV",
                "YPbPr, Legacy HDTV",
                "YCrCb, Legacy HDTV",
                "YCrCb, 4:2:0",
                "YCrCb, 4:2:2",
                "YCrCb, 4:4:4",
                "Y/C (S-Video) SECAM",              
                "Y/C (S-Video) PAL",
                "Y/C (S-Video) NTSC",
                "BGR"                        // 0x0f
            };

            var result = new List<string>();
            for (byte i = 2; i < 16; i++)
            {
                if (code.CheckBit(i))
                {
                    result.Add(items[i - 2]);
                }
            }

            return (string[]) result.ToArray().Clone();
        }

        private static string GetDisplayScanOrientationType(byte code)
        {
            var items = new List<string>
            {
                "Not defined",                     // 0x00
                "Display has a Fixed Orientation",
                "Default Orientation",
                "Current Orientation"              // 0x03
            };

            return code > 0x03
                ? "Unknown"
                : items[code];
        }

        private static string GetFrameRateConversion(byte code)
        {
            var items = new List<string>
            {
                "Not supported",                                                 // 0x00
                "Vertical is converted to a single frequency",
                "Horizontal is converted to a single frequency",
                "Both Vertical & Horizontal are converted to single frequencies" // 0x03
            };

            return code > 0x03
                ? "Unknown"
                : items[code];
        }

        private static string GetLegacyModes(bool legacyCheck) => $"{(legacyCheck ? "A" : "Not a")}ll VGA/DOS Legacy Timing Modes are supported";

        private static string GetDefaultColorLuminanceDecoding(byte code)
        {
            var items = new List<string>
            {
                "Not defined",  // 0x00
                "BGR",
                "Y/C (S-Video) NTSC",
                "Y/C (S-Video) PAL",
                "Y/C (S-Video) SECAM",
                "YCrCb, 4:4:4",
                "YCrCb, 4:2:2",
                "YCrCb, 4:2:0",
                "YCrCb, Legacy HDTV",
                "YPbPr, Legacy HDTV",
                "YCrCb, Modern HDTV",
                "YPbPr, Modern HDTV",
                "Y B-Y R-Y BetaCam, Sony",
                "Y B-Y R-Y M-2, Matsushita",
                "Monochrome",
            };

            return code > 0x0e
                ? "Reserved"
                : items[code];
        }

        private static string GetPreferredColorLuminanceDecoder(byte code)
        {
            var items = new List<string>
            {
                "Uses Default Decoding",  // 0x00
                "BGR",
                "Y/C (S-Video)",
                "Yxx (SMPTE 2xxM)",
                "Monochrome",
            };

            return code > 0x04
                ? "Reserved"
                : items[code];
        }

        private static string GetScanDirection(byte code)
        {
            var items = new List<string>
            {
                "Not defined",  // 0x00
                "Fast Scan is on the Major Axis and Slow Scan is on the Minor Axis",
                "Fast Scan is on the Minor Axis and Slow Scan is on the Major Axis",
                "Undefined"    // 0x03
            };

            return code > 0x03
                ? "Reserved"
                : items[code];
        }

        private static string GetScreenOrientation(bool portrait) => $"{(portrait ? "Portrait" : "Landscape")}";

        private static string GetStereoVideo(byte code)
        {
            var items = new List<string>
            {
                "No direct stereo",                         // 0x00
                "Field seq. stereo via stereo sync signal",
                "Auto-stereoscopic, column interleave",
                "Auto-stereoscopic, line interleave"        // 0x03
            };

            return code > 0x03
                ? "Reserved"
                : items[code];
        }

        private static string GetZeroPixelLocation(byte code)
        {
            var items = new List<string>
            {
                "Upper Left",  // 0x00
                "Upper Right",
                "Lower Left",
                "Lower Right"  // 0x03
            };

            return code > 0x03
                ? "Reserved"
                : items[code];
        }

        #endregion
    }
}
