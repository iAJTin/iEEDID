
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Eedid.Blocks.DI.Sections;

// DI Section: Display Capabilities & Feature Support Set
// •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                                  Length      Description                                                                       |
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

    /// <summary>
    /// Initializes a new instance of the <see cref="DisplayCapabilitiesAndFeatureSupportSetSection"/> class with the data from this raw section.
    /// </summary>
    /// <param name="sectionData">Data from this section untreated.</param>
    public DisplayCapabilitiesAndFeatureSupportSetSection(ReadOnlyCollection<byte> sectionData) 
        : base(sectionData)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <strong>Miscellaneous Display Capabilities</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte MiscellaneousDisplayCapabilities => RawData[0x00];

    /// <summary>
    /// Gets a value representing the <strong>Legacy Modes</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool LegacyModes => MiscellaneousDisplayCapabilities.CheckBit(Bits.Bit07);

    /// <summary>
    /// Gets a value representing the <strong>Stereo Video</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte StereoVideo => (byte)((MiscellaneousDisplayCapabilities >> 4) & 0x07);

    /// <summary>
    /// Gets a value representing the <strong>Scaler On Board</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool ScalerOnBoard => MiscellaneousDisplayCapabilities.CheckBit(Bits.Bit03);

    /// <summary>
    /// Gets a value representing the <strong>Image Centering</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool ImageCentering => MiscellaneousDisplayCapabilities.CheckBit(Bits.Bit02);

    /// <summary>
    /// Gets a value representing the <strong>Conditional Update</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool ConditionalUpdate => MiscellaneousDisplayCapabilities.CheckBit(Bits.Bit01);

    /// <summary>
    /// Gets a value representing the <strong>Interlaced Video</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool InterlacedVideo => MiscellaneousDisplayCapabilities.CheckBit(Bits.Bit01);

    /// <summary>
    /// Gets a value representing the <strong>Frame Rate Conversion Entry</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte FrameRateConversionEntry => RawData[0x01];

    /// <summary>
    /// Gets a value representing the <strong>Frame Lock</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool FrameLock => FrameRateConversionEntry.CheckBit(Bits.Bit07);

    /// <summary>
    /// Gets a value representing the <strong>Frame Rate Conversion</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte FrameRateConversion => (byte)((FrameRateConversionEntry >> 5) & 0x03);

    /// <summary>
    /// Gets a value representing the <strong>Vertical Frequency</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int VerticalFrequency => RawData.GetWord(2);

    /// <summary>
    /// Gets a value representing the <strong>Horizontal Frequency</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int HorizontalFrequency => RawData.GetWord(4);

    /// <summary>
    /// Gets a value representing the <strong>Display/Scan Orientation Entry</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte DisplayScanOrientationEntry => RawData[0x06];

    /// <summary>
    /// Gets a value representing the <strong>Display/Scan Orientation Definition Type</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte DisplayScanOrientationType => (byte) ((DisplayScanOrientationEntry >> 6) & 0x03);

    /// <summary>
    /// Gets a value representing the <strong>Screen Orientation</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool ScreenOrientation => DisplayScanOrientationEntry.CheckBit(Bits.Bit05);

    /// <summary>
    /// Gets a value representing the <strong>Zero Pixel Location</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte ZeroPixelLocation => (byte)((DisplayScanOrientationEntry >> 3) & 0x03);

    /// <summary>
    /// Gets a value representing the <strong>Scan Direction</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte ScanDirection => (byte) ((DisplayScanOrientationEntry >> 1) & 0x03);

    /// <summary>
    /// Gets a value representing the <strong>Standalone Projector</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool StandaloneProjector => DisplayScanOrientationEntry.CheckBit(Bits.Bit00);

    /// <summary>
    /// Gets a value representing the <strong>Color/Luminance Decoding Description</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte DefaultColorLuminanceDecoding => RawData[0x07];

    /// <summary>
    /// Gets a value representing the <strong>Preferred Color/Luminance Decoder</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte PreferredColorLuminanceDecoder => RawData[0x08];

    /// <summary>
    /// Gets a value representing the <strong>Color/Luminance Decoding Capabilities</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int ColorLuminanceDecodingCapabilities => RawData.GetWord(0x09);

    /// <summary>
    /// Gets a value representing the <strong>Dithering</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Dithering => RawData[0x0b].CheckBit(Bits.Bit07);

    /// <summary>
    /// Gets a value representing the <strong>Supported Color Bit-Depth of Sub-Channel 0 (Blue)</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte SupportedColorBitDepthSubChannel0Blue => RawData[0x0c];

    /// <summary>
    /// Gets a value representing the <strong>Supported Color Bit-Depth of Sub-Channel 1 (Green)</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte SupportedColorBitDepthSubChannel1Green => RawData[0x0d];

    /// <summary>
    /// Gets a value representing the <strong>Supported Color Bit-Depth of Sub-Channel 2 (Red)</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte SupportedColorBitDepthSubChannel2Red => RawData[0x0e];

    /// <summary>
    /// Gets a value representing the <strong>Supported Color Bit-Depth of Sub-Channel 0 (Cb/Pb)</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte SupportedColorBitDepthSubChannel0CbPb => RawData[0x0f];

    /// <summary>
    /// Gets a value representing the <strong>Supported Color Bit-Depth of Sub-Channel 1 (Y)</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte SupportedColorBitDepthSubChannel1Y => RawData[0x10];

    /// <summary>
    /// Gets a value representing the <strong>Supported Color Bit-Depth of Sub-Channel 2 (Cr/Pr)</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte SupportedColorBitDepthSubChannel2CrPr => RawData[0x11];

    /// <summary>
    /// Gets a value representing the <strong>Aspect Ratio Conversion Modes</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte AspectRatioConversionModes => RawData[0x12];

    /// <summary>
    /// Gets a value representing the <strong>Packetized Digital Video Support Information</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private ReadOnlyCollection<byte> PacketizedDigitalVideoSupportInformation => RawData.Extract((byte)0x13, (byte)0x10);

    #endregion

    #region protected override methods

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
