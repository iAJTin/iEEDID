
using System.Collections.ObjectModel;

using iTin.Core;
using iTin.Core.Helpers;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors;

// Data Block Descriptor: Detailed Timing Mode Descriptor Definition
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Lenght      Description                                                     |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Pixel Clock               WORD        Field value = Pixel Clock / 10000. Measured in Khz.             |
// |                                                    LSB stored in byte 0, MSB stored in byte 1                      |
// |                                                    Valid range: 10Khz - 655.35Mhz in 10Khz increments              |
// |                                                    Note: Ver PixelClock                                            |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Lower 8 bits              BYTE        Value: 00h - 0fh. Measured in pixels.                           |
// |              Horizontal                                                                                            |
// |              Addressable Video                                                                                     |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 03h          Lower 8 bits              BYTE        Value: 00h - 0fh. Measured in pixels.                           |
// |              Horizontal                                                                                            |
// |              Blanking                                                                                              |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 04h          Upper 4 bits              BYTE        Value: 00h - 0fh. Measured in pixels.                           |
// |              Horizontal                            Nibbles:                                                        |
// |              Addressable video /                            bit 07-04 (High Nibble) - Horizontal Addressable video |
// |              Blanking                                       bit 03-00 (Low Nibble)  - Horizontal Blanking          |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 05h          Lower 8 bits              BYTE        Value: 00h - ffh. Measured in lines.                            |
// |              Vertical                                                                                              |
// |              Addressable Video                                                                                     |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 06h          Lower 8 bits              BYTE        Value: 00h - ffh. Measured in lines.                            |
// |              Vertical                                                                                              |
// |              Blanking                                                                                              |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 07h          Upper 4 bits              BYTE        Value: 00h - 0fh. Measured in lines.                            |
// |              Vertical                              Nibbles:                                                        |
// |              Addressable video /                            bit 07-04 (High Nibble) - Vertical Addressable video   |
// |              Blanking                                       bit 03-00 (Low Nibble)  - Vertical Blanking            |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 08h          Lower 8 bits              BYTE        Value:e 00h - ffh. Measured in pixels.                          |
// |              Horizontal                                                                                            |
// |              Front Porch                                                                                           |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 09h          Lower 8 bits              BYTE        Value: 00h - ffh. Measured in pixels.                           |
// |              Horizontal                                                                                            |
// |              Sync Pulse Width                                                                                      |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0ah          Lower 4 bits              BYTE        Value: 00h - 0fh. Measured in lines.                            |
// |              Vertical                              Nibbles:                                                        |
// |              Front Porch /                                  bit 07-04 (High Nibble) - Vertical Front Porch         |
// |              Sync Pulse Width                               bit 03-00 (Low Nibble)  - Vertical Sync Pulse Width    |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0bh          Upper 2 bits              BYTE        2 upper bits:                                                   |
// |              Horizontal / Vertica                           bit 07-06 - Horizontal Front Porch en pixels.          |
// |              Front Porch                                    bit 05-04 - Horizontal Sync Pulse Width en pixels.     |
// |              Horizontal / Vertical                          bit 03-02 - Vertical Front Porch en líneas.            |
// |              Sync Pulse Width                               bit 01-00 - Vertical Sync Pulse Width en líneas.       |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0ch          Lower 8 bits              BYTE        Value: 00h - ffh. Measured in en mm.                            |
// |              Horizontal                                                                                            |
// |              Addressable Video                                                                                     |
// |              Image Size                                                                                            |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0ch          Lower 8 bits              BYTE        Value: 00h - ffh. Measured in en mm.                            |
// |              vertical                                                                                              |
// |              Addressable Video                                                                                     |
// |              Image Size                                                                                            |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0eh          Upper 4 bits              BYTE        Value: 00h - 0fh. Measured in en mm.                            |
// |              Horizontal / Vertical                 Nibbles:                                                        |
// |              Addressable video                              bit 07-04 (High Nibble) - Horizontal Addressable video |
// |              Image Size                                                               Image Size                   |
// |                                                             bit 03-00 (Low Nibble)  - vertical Addressable video   |
// |                                                                                       Image Size                   |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 0fh          Horizontal                BYTE        Value: 00h - ffh.  Measured in pixels.                          |
// |              Border                                Right Horizontal Border or Left Horizontal Border in pixels.    |
// |                                                    Remarks: Right Border is equal to Left Border                   |
// |                                                    Note: See HorizontalBorder                                      |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 10h          Vertical                  BYTE        Value: 00h - ffh. Measured in lines.                            |
// |              Border                                Top Vertical Border or Bottom Vertical Border in Lines.         |
// |                                                    Remarks:  Top Border is equal to Bottom Border                  |
// |                                                    Note: See VerticalBorder                                        |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 11h          Flags                     BYTE                 bit 07: Signal Interface Type.                         |
// |                                                                     0b - Non Interlaced ( 1 frame = 1 fields )     |
// |                                                                     1b - Interlaced ( 1 frame = 2 fields )         |
// |                                                                     Note: See IsInterlaced                         |
// |                                                                                                                    |
// |                                                    bits 06:05 - 00: Stereo Viewing Support                         |
// |                                                                     00xb - Normal Display - No stereo              |
// |                                                                     010b - Field sequential stereo, right image    |
// |                                                                     011b - 2-way interleaved stereo, right image on|
// |                                                                            even lines.                             |
// |                                                                     100b - Field sequential stereo, left image     |
// |                                                                     101b - 2-way interleaved stereo, left image on |
// |                                                                            even lines.                             |
// |                                                                     110b - 4-way interleaved stereo                |
// |                                                                     111b - Side-by-side interleaved stereo         |
// |                                                                     Note: See GetStereoViewingSupport(byte)        |
// |                                                                                                                    |
// |                                                    bits 04:01:                                                     |
// |                                                    4 3 2 1 Analog Sync Signal Definiton                            |
// |                                                    0 0 _ _  Analog Composite Sync                                  |
// |                                                    0 1 _ _  Bipolar Analog Composite Sync                          |
// |                                                    0 _ 0 _  ---- Without Serrations                                |
// |                                                    0 _ 1 _  ---- With Serrations (H-sync during V-sync)            |
// |                                                    0 _ _ 0  ------ Sync on green signal only                       |
// |                                                    0 _ _ 1  ------ Sync on all three (RGB) video signals           |
// |                                                                                                                    |
// |                                                    4 3 2 1 Digital Sync Signal Definiton                           |
// |                                                    1 0 _ _  Digital Composite Sync                                 |
// |                                                    1 0 0 _  -- Without Serrations                                  |
// |                                                    1 0 1 _  -- With Serrations (H-sync during V-sync)              |
// |                                                    1 1 _ _  Digital Separate Sync                                  |
// |                                                    1 1 0 _  ---- Vertical sync is negative                         |
// |                                                    1 1 1 _  ---- Vertical sync is positive                         |
// |                                                    1 _ _ 0  ------ Horizontal sync is negative (outside of V-sync) |
// |                                                    1 _ _ 1  ------ Horizontal sync is positive (outside of V-sync) |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="EdidSection.DataBlocks"/> section of type this block <see cref="EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode"/>.
/// </summary> 
internal sealed class DetailedTimingModeDescriptor : BaseDataSection
{
    #region private enumerations

    /// <summary>
    /// Enumeration of known type of signal interfaces.
    /// </summary> 
    private enum KnownSignalInterfaceType
    {
        /// <summary>
        /// Non Interlaced
        /// </summary>
        NonInterlaced,

        /// <summary>
        /// Interlaced.
        /// </summary>
        Interlaced
    }

    /// <summary>
    /// Enumeration of conoid type of synchronism signals.
    /// </summary> 
    private enum KnownSyncSignalType
    {
        /// <summary>
        /// Analog.
        /// </summary>
        Analog,

        /// <summary>
        /// Digital
        /// </summary>
        Digital
    }

    #endregion

    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="DetailedTimingModeDescriptor"/> class with the data of this block untreated.
    /// </summary>
    /// <param name="dataBlock">Unprocessed data in this block</param>
    public DetailedTimingModeDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <c>Pixel Clock</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private int PixelClock => RawData.GetWord(0x00) * 10000;

    /// <summary>
    /// Gets a value representing the <c>Horizontal Addressable Video</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private int HorizontalAddressableVideo => LogicHelper.Word(RawData[0x02], HorizontalAddresableAndBlanking[0]);

    /// <summary>
    /// Gets a value representing the <c>Horizontal Blanking</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private int HorizontalBlanking => LogicHelper.Word(RawData[0x03], HorizontalAddresableAndBlanking[1]);

    /// <summary>
    /// Gets a value representing the <c>Lower Nibble Horizontal Addressable Pixels / Lower Nibble Horizontal Blanking</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private byte[] HorizontalAddresableAndBlanking => RawData[0x04].ToNibbles();

    /// <summary>
    /// Gets a value representing the <c>Vertical Lines</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private int VerticalLines => LogicHelper.Word(RawData[0x05], VerticalLinesAndBlanking[0]);

    /// <summary>
    /// Gets a value representing the <c>Vertical Blanking</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private int VerticalBlanking => LogicHelper.Word(RawData[0x06], VerticalLinesAndBlanking[1]);

    /// <summary>
    /// Gets a value representing the <c>Upper Nibble Vertical Addressable Video in lines / Upper Nibble Vertical Blanking in lines</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private byte[] VerticalLinesAndBlanking => RawData[0x07].ToNibbles();

    /// <summary>
    /// Gets a value representing the <c>Horizontal Front Porch</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private int HorizontalFrontPorch => LogicHelper.Word(RawData[0x08], UpperHorizontalFrontPorch);

    /// <summary>
    /// Gets a value representing the <c>Horizontal Sync Pulse Width</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private int HorizontalSyncPulseWidth => LogicHelper.Word(RawData[0x09], UpperHorizontalSyncPulseWidth);

    /// <summary>
    /// Gets a value representing the <c>Upper Nibble Vertical Front Porch in Lines / Upper Nibble Vertical Sync Pulse Width</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private byte[] LowVerticalFrontPorchAndSyncPulse => RawData[0x0a].ToNibbles();

    /// <summary>
    /// Gets a value representing the <c>Vertical Front Porch</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private int VerticalFrontPorch => LogicHelper.Word(LowVerticalFrontPorchAndSyncPulse[0], UpperVerticalFrontPorch);

    /// <summary>
    /// Gets a value representing the <c>Vertical Sync Pulse Width</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private int VerticalSyncPulseWidth => LogicHelper.Word(LowVerticalFrontPorchAndSyncPulse[1], UpperVerticalSyncPulseWidth);

    /// <summary>
    /// Gets a value representing the <c>Bit Definitions</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private byte[] CommonBitDefinition => RawData[0x0b].ToNibbles();

    /// <summary>
    /// Gets a value representing the <c>Horizontal Front Porch</c> charactersitic of <c>Bit Definitions</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private byte UpperHorizontalFrontPorch => CommonBitDefinition[0].ToNibbles()[0];

    /// <summary>
    /// Gets a value representing the <c>Horizontal Sync Pulse Width</c> charactersitic of <c>Bit Definitions</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private byte UpperHorizontalSyncPulseWidth => CommonBitDefinition[0].ToNibbles()[1];

    /// <summary>
    /// Gets a value representing the <c>Vertical Front Porch</c> charactersitic of <c>Bit Definitions</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private byte UpperVerticalFrontPorch => CommonBitDefinition[1].ToNibbles()[0];

    /// <summary>
    /// Gets a value representing the <c>Vertical Sync Pulse Width</c> charactersitic of <c>Bit Definitions</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private byte UpperVerticalSyncPulseWidth => CommonBitDefinition[1].ToNibbles()[1];

    /// <summary>
    /// Gets a value representing the <c>Horizontal Addressable Video Image Size</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private int HorizontalAddresableVideoImageSize => LogicHelper.Word(RawData[0x0c], UpperHorizontalAndVerticalImageSize[0]);

    /// <summary>
    /// Gets a value representing the <c>Vertical Addressable Video Image Size</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private int VerticalAddresableVideoImageSize => LogicHelper.Word(RawData[0x0d], UpperHorizontalAndVerticalImageSize[1]);

    /// <summary>
    /// Obtiene un valor que representa al campo '<c>Upper Horizontal Addressable Video Image Size in mm / Upper Vertical Addressable Video Image Size in mm</c>'.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private byte[] UpperHorizontalAndVerticalImageSize => RawData[0x0e].ToNibbles();

    /// <summary>
    /// Gets a value representing the <c>Horizontal Border</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private byte HorizontalBorder => RawData[0x0f];

    /// <summary>
    /// Gets a value representing the <c>Vertical Border</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private byte VerticalBorder => RawData[0x10];

    /// <summary>
    /// Gets a value representing the <c>Signal Interface Type</c> characterisitic of <c>Byte 17</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private KnownSignalInterfaceType SignalInterfaceType => (KnownSignalInterfaceType)(byte) (RawData[0x11] >> 7 & 0x01);

    /// <summary>
    /// Gets a value representing the <c>Interlaced</c> characterisitic.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private bool IsInterlaced => SignalInterfaceType == KnownSignalInterfaceType.Interlaced;

    /// <summary>
    /// Gets a value representing the <c>Stereo Viewing Support</c> characterisitic of <c>Byte 17</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private byte StereoViewingSupport => (byte) (RawData[0x11] >> 4 & 0x07);

    /// <summary>
    /// Gets a value representing the <c>Sync Signal</c> characterisitic of <c>Byte 17</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private KnownSyncSignalType SyncSignal => (KnownSyncSignalType)(byte)(RawData[0x11] >> 4 & 0x01);

    /// <summary>
    /// Gets a value representing the <c>Is Analog Bipolar</c> characterisitic of <c>Byte 17</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private bool IsAnalogBipolar => RawData[0x11].CheckBit(Bits.Bit03);

    /// <summary>
    /// Gets a value representing the <c>With Analog Serrations</c> characterisitic of <c>Byte 17</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private bool WithAnalogSerrations => RawData[0x11].CheckBit(Bits.Bit02);

    /// <summary>
    /// Gets a value representing the <c>Sync On Three Video Signals</c> characterisitic of <c>Byte 17</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private bool SyncOnThreeVideoSignals => RawData[0x11].CheckBit(Bits.Bit01);

    /// <summary>
    /// Gets a value representing the <c>Is Digital Separate Sync</c> characterisitic of <c>Byte 17</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private bool IsDigitalSeparateSync => RawData[0x11].CheckBit(Bits.Bit03);

    /// <summary>
    /// Gets a value representing the <c>With Digital Serrations</c> characterisitic of <c>Byte 17</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private bool WithDigitalSerrations => WithAnalogSerrations;

    /// <summary>
    /// Gets a value representing the <c>Is Vertical Sync Positive</c> characterisitic of <c>Byte 17</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private bool IsVerticalSyncPositive => RawData[0x11].CheckBit(Bits.Bit02);

    /// <summary>
    /// Gets a value representing the <c>Is Positive Horizontal Sync</c> characterisitic of <c>Byte 17</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private bool IsPositiveHorizontalSync => RawData[0x11].CheckBit(Bits.Bit01);

    /// <summary>
    /// Gets a value representing the <c>Sync Signal Type</c> characterisitic of <c>Byte 17</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private string SyncSignalType
    {
        get
        {
            var syncSignalValue = string.Empty;

            KnownSyncSignalType syncSignal = SyncSignal;
            string signalType;
            string serrations;
            switch (syncSignal)
            {
                #region Digital
                case KnownSyncSignalType.Digital:
                    var isDigitalSeparateSync = IsDigitalSeparateSync;
                    switch (isDigitalSeparateSync)
                    {
                        case true:
                            signalType = "Digital separate sync, ";

                            var isVerticalSyncPositive = IsVerticalSyncPositive;
                            string verticalSync = isVerticalSyncPositive switch
                            {
                                true => "Vertical sync is positive, ",
                                false => "Vertical sync is negative, "
                            };

                            var isPositiveHorizontalSync = IsPositiveHorizontalSync;
                            string horizontalSync = isPositiveHorizontalSync switch
                            {
                                true => "Horizontal sync is negative (outside of V-sync).",
                                false => "Horizontal sync is positive (outside of V-sync)."
                            };

                            syncSignalValue = string.Concat(signalType, verticalSync, horizontalSync);
                            break;

                        case false:
                            signalType = "Digital composite sync ";

                            var withDigitalSerrations = WithDigitalSerrations;
                            serrations = withDigitalSerrations switch
                            {
                                true => "with serrations (H-sync during V-sync) ",
                                false => "without serrantions "
                            };

                            syncSignalValue = string.Concat(signalType, serrations);
                            break;
                    }
                    break;
                #endregion

                #region Analog
                case KnownSyncSignalType.Analog:
                    var isBipolar = IsAnalogBipolar;
                    signalType = isBipolar switch
                    {
                        true => "Analog bipolar composite sync ",
                        false => "Analog composite sync "
                    };

                    var withAnalogSerrations = WithAnalogSerrations;
                    serrations = withAnalogSerrations switch
                    {
                        true => "with serrations (H-sync during V-sync) ",
                        false => "without serrantions "
                    };

                    var syncOnThreeVideoSignals = SyncOnThreeVideoSignals;
                    string syncOn = syncOnThreeVideoSignals switch
                    {
                        true => "on all three (RGB) video signals.",
                        false => "on green signal only."
                    };

                    syncSignalValue = string.Concat(signalType, serrations, syncOn);
                    break;
                    #endregion
            }

            return syncSignalValue;
        }
    }

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.PixelClock, PixelClock);
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalResolution, HorizontalAddressableVideo);
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalBlanking, HorizontalBlanking);
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalLines, VerticalLines);
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalBlanking, VerticalBlanking);
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalFrontPorch, HorizontalFrontPorch);
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalSyncPulseWidth, HorizontalSyncPulseWidth);
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalFrontPorch, VerticalFrontPorch);
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalSyncPulseWidth, VerticalSyncPulseWidth);
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalImageSize, HorizontalAddresableVideoImageSize);
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalImageSize, VerticalAddresableVideoImageSize);
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalBorder, HorizontalBorder);
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalBorder, VerticalBorder);
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.IsInterlaced, IsInterlaced);
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.StereoViewingSupport, GetStereoViewingSupport(StereoViewingSupport));
        properties.Add(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.SyncSignalType, SyncSignalType);
    }

    #endregion


    #region EDID 1.4 Specification

    /// <summary>
    /// Returns stereo viewing support .
    /// </summary>
    /// <param name="code">value.</param>
    /// <returns></returns>
    private static string GetStereoViewingSupport(byte code)
    {
        var value = new[]
        {
            "Normal Display (No stereo)",
            "Normal Display (No stereo)",
            "Field sequential stereo, right image",
            "2-way interleaved stereo, right image on even lines",
            "Field sequential stereo, left image",
            "2-way interleaved stereo, left image on even lines",
            "4-way interleaved stereo",
            "Side-by-side interleaved stereo"	                                  
        };

        return value[code];
    }

    #endregion
}
