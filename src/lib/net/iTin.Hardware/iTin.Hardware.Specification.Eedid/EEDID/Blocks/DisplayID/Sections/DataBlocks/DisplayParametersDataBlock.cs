
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

using iTin.Core;
using iTin.Core.Helpers;
using iTin.Core.Helpers.Enumerations;

using iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel;

namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks;

// Data Block: Display Parameters Data Block v1.3
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                    Lenght      Description                                                  |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          TAG                     BYTE        7Fh                                                          |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Block Revision and      BYTE         Bits    Value                                               |
// |              Other Data                          07:03    Reserved (Cleared to all 0s)                        |
// |                                                  02:00    Block Revision, 000b Rev. 0 (default)               |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Number of Payload       BYTE        12h                                                          |
// |              Bytes in Block                                                                                   |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 03h          Horizontal Image Size   WORD        Horizontal Image Size.                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 05h          Vertical Image Size     WORD        Vertical Image Size.                                         |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 07h          Horizontal Pixel Count  WORD        Horizontal Pixel Count.                                      |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 09h          Vertical Pixel Count    WORD        Vertical Pixel Count.                                        |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Bh          Feature Support Flags   BYTE        Feature Support Flags.                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Ch          GAMMA                   BYTE        Transfer Characteristic Gamma.                               |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Dh          Aspect Ratio            BYTE        Aspect Ratio.                                                |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 12h          Color Bit Depth         BYTE        Color Bit Depth.                                             |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•

// Data Block: Display Parameters Data Block v2.0
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                    Lenght      Description                                                  |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          TAG                     BYTE        7Eh                                                          |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Block Revision and      BYTE         Bits    Value                                               |
// |              Other Data                             07    Image Size Multiplier                               |
// |                                                           0   Horizontal And Vertical Image Size have 0.1mm   |
// |                                                               precision (default)                             |
// |                                                           1   Horizontal And Vertical Image Size have 1.0mm   |
// |                                                               precision                                       |
// |                                                  06:03    Reserved (Cleared to all 0s)                        |
// |                                                  02:00    Block Revision, 000b Rev. 0 (default)               |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Number of Payload       BYTE        1Dh                                                          |
// |              Bytes in Block                                                                                   |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 03h          Horizontal Image Size   WORD        Horizontal Image Size.                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 05h          Vertical Image Size     WORD        Vertical Image Size.                                         |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 07h          Horizontal Pixel Count  WORD        Horizontal Pixel Count.                                      |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 09h          Vertical Pixel Count    WORD        Vertical Pixel Count.                                        |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Bh          Feature Support Flags   BYTE        Feature Support Flags.                                       |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Ch          Native Color            3-BYTE      Native Color Chromaticity (Primary Color 1 Chromaticity).    |
// |              Chromaticity                        Descriptor.                                                  |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0Fh          Native Color            3-BYTE      Native Color Chromaticity (Primary Color 2 Chromaticity).    |
// |              Chromaticity                        Descriptor.                                                  |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 12h          Native Color            3-BYTE      Native Color Chromaticity (Primary Color 3 Chromaticity).    |
// |              Chromaticity                        Descriptor.                                                  |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 15h          Native Color            3-BYTE      Native Color Chromaticity (White Point Chromaticity).        |
// |              Chromaticity                        Descriptor.                                                  |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 18h          Native Maximum          WORD        Native Maximum Luminance (Full Coverage).                    |
// |              Luminance                           Descriptor.                                                  |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 1Ah          Native Maximum          WORD        Native Maximum Luminance (10% Rectangular Coverage).         |
// |              Luminance                           Descriptor.                                                  |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 1Ch          Native Minimum          WORD        Native Minimum Luminance.                                    |
// |              Luminance                           Descriptor.                                                  |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 1Eh          Native Color Depth      BYTE        Native Color Depth and Display Device Technology.            |
// |              and Display Device                  Descriptor.                                                  |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 1Fh          GAMMA                   BYTE        Native Gamma EOTF.                                           |
// •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents a data block of type <see cref="DataBlockTag.DisplayParameters"/>.
/// </summary> 
internal sealed class DisplayParametersDataBlock : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="DisplayParametersDataBlock"/> class with the data of this block untreated with version block.
    /// </summary>
    /// <param name="dataBlock">Unprocessed data in this block</param>
    /// <param name="version">Block version.</param>
    public DisplayParametersDataBlock(ReadOnlyCollection<byte> dataBlock, int? version = null) 
        : base(dataBlock, version)
    {
    }

    #endregion

    #region private readonly properties

    #region common properties

    /// <summary>
    /// Gets a value representing the <b>Horizontal Image Size</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int HorizontalImageSize => RawData.GetWord(0x03);

    /// <summary>
    /// Gets a value representing the <b>Vertical Image Size</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int VerticalImageSize => RawData.GetWord(0x05);

    /// <summary>
    /// Gets a value representing the <b>Horizontal Pixel Count</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int HorizontalPixelCount => RawData.GetWord(0x07);

    /// <summary>
    /// Gets a value representing the <b>Vertical Pixel Count</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int VerticalPixelCount => RawData.GetWord(0x09);

    #endregion

    #region feature flags

    /// <summary>
    /// Gets a value representing the <b>Feature Support Flags</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte FeatureSupportFlags => RawData[0x0b];

    #region v13

    /// <summary>
    /// Gets a value representing the <b>Audio Support On Video Interfaces</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool AudioSupportOnVideoInterface => FeatureSupportFlags.CheckBit(Bits.Bit07);

    /// <summary>
    /// Gets a value representing the <b>Separate Audio Inputs</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool SeparateAudioInputs => FeatureSupportFlags.CheckBit(Bits.Bit06);

    /// <summary>
    /// Gets a value representing the <b>Audio Input Override</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool AudioInputOverride => FeatureSupportFlags.CheckBit(Bits.Bit05);

    /// <summary>
    /// Gets a value representing the <b>VESA Power Management Supported</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool VesaPowerManagementSupported => FeatureSupportFlags.CheckBit(Bits.Bit04);

    /// <summary>
    /// Gets a value representing the <b>Fixed Timing</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool FixedTiming => FeatureSupportFlags.CheckBit(Bits.Bit03);

    /// <summary>
    /// Gets a value representing the <b>Fixed Pixel Format</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool FixedPixelFormat => FeatureSupportFlags.CheckBit(Bits.Bit02);

    /// <summary>
    /// Gets a value representing the <b>Support AI</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool SupportAI => FeatureSupportFlags.CheckBit(Bits.Bit01);

    /// <summary>
    /// Gets a value representing the <b>De-Interlacing</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool DeInterlacing => FeatureSupportFlags.CheckBit(Bits.Bit00);

    #endregion

    #region v20

    /// <summary>
    /// Gets a value representing the <b>Scan Orientation</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte ScanOrientation => (byte) (FeatureSupportFlags & 0x07);

    /// <summary>
    /// Gets a value representing the <b>Luminance Information</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte LuminanceInformation => (byte)((byte)(FeatureSupportFlags >> 0x03) & 0x03);

    /// <summary>
    /// Gets a value representing the <b>Color Information Cie 1931</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool ColorInformationCie1931 => FeatureSupportFlags.CheckBit(Bits.Bit06);

    /// <summary>
    /// Gets a value representing the <b>Audio Speakers Integrated</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool AudioSpeakersIntegrated => FeatureSupportFlags.CheckBit(Bits.Bit07);

    #endregion

    #endregion

    #region v13

    /// <summary>
    /// Gets a value representing the <b>Transfer Characteristic Gamma</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private double TransferCharacteristicGamma
    {
        get
        {
            double gamma = 0xff;

            byte rawData = RawData[0x0c];
            if (rawData != 0xff)
            {
                gamma = rawData * 0.01 + 1.0;
            }

            return gamma;
        }
    }

    /// <summary>
    /// Gets a value representing the <b>Aspect Ratio</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private double AspectRatio => (double)RawData[0x0d] / 100 + 1;

    #region color bit depth

    /// <summary>
    /// Gets a value representing the <b>Color Bit Depth</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte ColorBitDepth => RawData[0x0e];

    /// <summary>
    /// Gets a value representing the <b>Display Overall Color Bit Depth</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte DisplayOverallColorBitDepth => (byte)(ColorBitDepth >> 0x04 & 0x0f);

    /// <summary>
    /// Gets a value representing the <b>Display Device Color Bit Depth</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte DisplayDeviceColorBitDepth => (byte) (ColorBitDepth & 0x0f);

    #endregion

    #endregion

    #region v20

    /// <summary>
    /// Gets a value representing the <b>Native Gamma</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private double NativeGamma
    {
        get
        {
            double gamma = 0xff;

            byte rawData = RawData[0x1f];
            if (rawData != 0xff)
            {
                gamma = rawData * 0.01 + 1.0;
            }

            return gamma;
        }
    }

    /// <summary>
    /// Gets a value representing the <b>Primary Color 1</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte[] RawPrimaryColor1 => RawData.Extract((byte)0x0c, (byte)0x03).ToArray();

    /// <summary>
    /// Gets a value representing the <b>Primary Color 2</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte[] RawPrimaryColor2 => RawData.Extract((byte) 0x0f, (byte) 0x03).ToArray();

    /// <summary>
    /// Gets a value representing the <b>Primary Color 3</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte[] RawPrimaryColor3 => RawData.Extract((byte)0x12, (byte)0x03).ToArray();

    /// <summary>
    /// Gets a value representing the <b>White Color</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte[] RawWhiteColor => RawData.Extract((byte)0x15, (byte)0x03).ToArray();

    /// <summary>
    /// Gets a value representing the <b>Native Maximum Luninance (Full Coverage)</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int NativeMaximumLuninanceFullCoverage => RawData.GetWord(0x18);

    /// <summary>
    /// Gets a value representing the <b>Native Maximum Luninance (Rectangular Coverage)</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int NativeMaximumLuninanceRectangularCoverage => RawData.GetWord(0x1a);

    /// <summary>
    /// Gets a value representing the <b>Native Minimum Luninance</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private int NativeMinimumLuninance => RawData.GetWord(0x1c);

    #endregion

    #region native color depth and device technology

    /// <summary>
    /// Gets a value representing the <b>Native Color Depth And Device Technology</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte NativeColorDepthAndDeviceTechnology => RawData[0x1e];

    /// <summary>
    /// Gets a value representing the <b>Native Color Depth</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte NativeColorDepth => (byte) (NativeColorDepthAndDeviceTechnology & 0x07);

    /// <summary>
    /// Gets a value representing the <b>Display Device Technology</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte DisplayDeviceTechnology => (byte) (NativeColorDepthAndDeviceTechnology >> 0x04 & 0x07);

    #endregion

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.HorizontalImageSize, HorizontalImageSize);
        properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.VerticalImageSize, VerticalImageSize);
        properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.HorizontalPixelCount, HorizontalPixelCount);
        properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.VerticalPixelCount, VerticalPixelCount);

        if (Version >= 0x20)
        {
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.Features.ScanOrientation, GetScanOrientation(ScanOrientation));
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.Features.LuminanceInformation, GetLuminanceInformation(LuminanceInformation));
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.Features.ColorInformationCie1931, ColorInformationCie1931);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.Features.AudioSpeakersIntegrated, AudioSpeakersIntegrated);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.PrimaryColor1, CalculateNativeColorCromaticity(RawPrimaryColor1.ToArray()));
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.PrimaryColor2, CalculateNativeColorCromaticity(RawPrimaryColor2.ToArray()));
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.PrimaryColor3, CalculateNativeColorCromaticity(RawPrimaryColor3.ToArray()));
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.WhitePoint, CalculateNativeColorCromaticity(RawWhiteColor.ToArray()));

            var nativeMaximumLuninanceFullCoverage = NativeMaximumLuninanceFullCoverage.FromIEEE754();
            if (nativeMaximumLuninanceFullCoverage >= 0.0f)
            {
                properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.NativeMaximumLuninanceFullCoverage, nativeMaximumLuninanceFullCoverage);
            }

            var nativeMaximumLuninanceRectangularCoverage = NativeMaximumLuninanceRectangularCoverage.FromIEEE754();
            if (nativeMaximumLuninanceRectangularCoverage >= 0.0f)
            {
                properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.NativeMaximumLuninanceRectangularCoverage, nativeMaximumLuninanceRectangularCoverage);
            }

            var nativeMinimumLuninance = NativeMinimumLuninance.FromIEEE754();
            if (nativeMinimumLuninance >= 0.0f)
            {
                properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.NativeMinimumLuninance, nativeMinimumLuninance);
            }

            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.NativeColorDepth, GetNativeColorDepth(NativeColorDepth));
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.DisplayDeviceTechnology, GetDisplayDeviceTechnology(DisplayDeviceTechnology));
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.Gamma, NativeGamma);
        }
        else
        {
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.Features.AudioSupportOnVideoInterface, AudioSupportOnVideoInterface);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.Features.SeparateAudioInputs, SeparateAudioInputs);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.Features.AudioInputOverride, AudioInputOverride);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.Features.VesaPowerManagementSupported, VesaPowerManagementSupported);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.Features.FixedTiming, FixedTiming);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.Features.FixedPixelFormat, FixedPixelFormat);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.Features.SupportAI, SupportAI);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.Features.DeInterlacing, DeInterlacing);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.Gamma, TransferCharacteristicGamma);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.AspectRatio, AspectRatio);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.DisplayOverallColorBitDepth, DisplayOverallColorBitDepth);
            properties.Add(EedidProperty.DisplayID.DataBlocks.Blocks.DisplayParameters.DisplayDeviceColorBitDepth, DisplayDeviceColorBitDepth);
        }
    }

    #endregion


    #region VESA Display Identification Data (DisplayID)

    private static PointF CalculateNativeColorCromaticity(byte[] rawData)
    {
        var vCx = 0.0;
        var vCy = 0.0;

        byte xl = rawData[0x00];
        byte xh = (byte)(rawData[0x01] >> 0x04 & 0x0f);
        int x = LogicHelper.Word(xl, xh);

        byte yl = (byte)(rawData[0x01] & 0x0f);
        byte yh = rawData[0x02];
        int y = LogicHelper.Word(yl, yh);

        for (var i = 0; i <= 11; vCx += x.CheckBit((Bits)i) ? System.Math.Pow(2, i - 12) : 0, vCy += y.CheckBit((Bits)i) ? System.Math.Pow(2, i - 12) : 0, i++)
        {
        }

        return new PointF((float)vCx, (float)vCy);
    }

    private static string GetDisplayDeviceTechnology(byte code)
    {
        var items = new List<string>
        {
            "Technology type is not specified", // 0x00
            "Active Matrix LCD technology",
            "Organic LED technology"            // 0x02
        };

        return code > 0x02
            ? "Reserved"
            : items[code];
    }

    private static string GetNativeColorDepth(byte code)
    {
        var items = new List<string>
        {
            "Not defined",  // 0x00
            "6 bpc",
            "8 bpc",
            "10 bpc",
            "12 bpc",
            "16 bpc",       // 0x05
        };

        return code > 0x06
            ? "Reserved"
            : items[code];
    }

    private static string GetScanOrientation(byte code)
    {
        var items = new List<string>
        {
            "Left to right, top to bottom",  // 0x00
            "Right to left, top to bottom",
            "Top to bottom, right to left",
            "Bottom to top, right to left",
            "Right to left, bottom to top",
            " Left to right, bottom to top",
            "Bottom to top, left to right",
            "Top to bottom, left to right"   // 0x07
        };

        return code > 0x07
            ? "Reserved"
            : items[code];
    }

    private static string GetLuminanceInformation(byte code)
    {
        var items = new List<string>
        {
            "Non-zero maximum luminance information contained within this block is exposed as a minimum guaranteed value",        // 0x00
            "Non-zero maximum luminance information contained within this block is provided as a guidance for the Source device"  // 0x01
        };

        return code > 0x01
            ? "Reserved"
            : items[code];
    }

    #endregion
}
