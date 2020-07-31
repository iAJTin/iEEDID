
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;

    using Helpers;
    using Helpers.Enumerations;

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
    /// Represents the <see cref="KnownEdidSection.DataBlocks"/> section of type this block <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/>.
    /// </summary> 
    sealed class DetailedTimingModeDescriptor : BaseDataSection
    {
        #region private enumerations

        #region [private] [enum] KnownSignalInterfaceType: Enumeration of known type of signal interfaces
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
            Interlaced,
        }
        #endregion

        #region [private] [enum] KnownSyncSignalType: Enumeration of conoid type of synchronism signals
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
            Digital,
        }
        #endregion

        #endregion

        #region constructor/s

        #region [public] DetailedTimingModeDescriptor(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data of this block untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="DetailedTimingModeDescriptor"/> class with the data of this block untreated.
        /// </summary>
        /// <param name="dataBlock">Unprocessed data in this block</param>
        public DetailedTimingModeDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (int) PixelClock: Gets a value representing the 'Pixel Clock' field
        /// <summary>
        /// Gets a value representing the <c>Pixel Clock</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private int PixelClock => RawData.GetWord(0x00) * 10000;
        #endregion

        #region [private] (int) HorizontalAddressableVideo: Gets a value representing the 'Horizontal Addressable Video' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Addressable Video</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private int HorizontalAddressableVideo => LogicHelper.Word(RawData[0x02], HorizontalAddresableAndBlanking[0]);
        #endregion

        #region [private] (int) HorizontalBlanking: Gets a value representing the 'Horizontal Blanking' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Blanking</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private int HorizontalBlanking => LogicHelper.Word(RawData[0x03], HorizontalAddresableAndBlanking[1]);
        #endregion

        #region [private] (byte[]) HorizontalAddresableAndBlanking: Gets a value representing the 'Lower Nibble Horizontal Addressable Pixels / Lower Nibble Horizontal Blanking' field
        /// <summary>
        /// Gets a value representing the <c>Lower Nibble Horizontal Addressable Pixels / Lower Nibble Horizontal Blanking</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private byte[] HorizontalAddresableAndBlanking => RawData[0x04].ToNibbles();
        #endregion

        #region [private] (int) VerticalLines: Gets a value representing the 'Vertical Lines' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Lines</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private int VerticalLines => LogicHelper.Word(RawData[0x05], VerticalLinesAndBlanking[0]);
        #endregion

        #region [private] (int) VerticalBlanking: Gets a value representing the 'Vertical Blanking' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Blanking</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private int VerticalBlanking => LogicHelper.Word(RawData[0x06], VerticalLinesAndBlanking[1]);
        #endregion

        #region [private] (byte[]) VerticalLinesAndBlanking: Gets a value representing the 'Upper Nibble Vertical Addressable Video in lines / Upper Nibble Vertical Blanking' field
        /// <summary>
        /// Gets a value representing the <c>Upper Nibble Vertical Addressable Video in lines / Upper Nibble Vertical Blanking in lines</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private byte[] VerticalLinesAndBlanking => RawData[0x07].ToNibbles();
        #endregion

        #region [private] (int) HorizontalFrontPorch: Gets a value representing the 'Horizontal Front Porch' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Front Porch</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private int HorizontalFrontPorch => LogicHelper.Word(RawData[0x08], UpperHorizontalFrontPorch);
        #endregion

        #region [private] (int) HorizontalFrontPorch: Gets a value representing the 'Horizontal Sync Pulse Width' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Sync Pulse Width</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private int HorizontalSyncPulseWidth => LogicHelper.Word(RawData[0x09], UpperHorizontalSyncPulseWidth);
        #endregion

        #region [private] (byte[]) LowVerticalFrontPorchAndSyncPulse: Gets a value representing the 'Upper Nibble Vertical Front Porch in Lines / Upper Nibble Vertical Sync Pulse Width' field
        /// <summary>
        /// Gets a value representing the <c>Upper Nibble Vertical Front Porch in Lines / Upper Nibble Vertical Sync Pulse Width</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private byte[] LowVerticalFrontPorchAndSyncPulse => RawData[0x0a].ToNibbles();
        #endregion

        #region [private] (int) VerticalFrontPorch: Gets a value representing the 'Vertical Front Porch' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Front Porch</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private int VerticalFrontPorch => LogicHelper.Word(LowVerticalFrontPorchAndSyncPulse[0], UpperVerticalFrontPorch);
        #endregion

        #region [private] (int) VerticalSyncPulseWidth: Gets a value representing the 'Vertical Sync Pulse Width' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Sync Pulse Width</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private int VerticalSyncPulseWidth => LogicHelper.Word(LowVerticalFrontPorchAndSyncPulse[1], UpperVerticalSyncPulseWidth);
        #endregion

        #region [private] (byte[]) CommonBitDefinition: Gets a value representing the 'Bit Definitions' field
        /// <summary>
        /// Gets a value representing the <c>Bit Definitions</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private byte[] CommonBitDefinition => RawData[0x0b].ToNibbles();
        #endregion

        #region [private] (byte) UpperHorizontalFrontPorch: Gets a value representing the 'Horizontal Front Porch' charactersitic of 'Bit Definitions' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Front Porch</c> charactersitic of <c>Bit Definitions</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private byte UpperHorizontalFrontPorch => CommonBitDefinition[0].ToNibbles()[0];
        #endregion

        #region [private] (byte) UpperHorizontalFrontPorch: Gets a value representing the 'Horizontal Sync Pulse Width' charactersitic of 'Bit Definitions' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Sync Pulse Width</c> charactersitic of <c>Bit Definitions</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private byte UpperHorizontalSyncPulseWidth => CommonBitDefinition[0].ToNibbles()[1];
        #endregion

        #region [private] (byte) UpperVerticalFrontPorch: Gets a value representing the 'Vertical Front Porch' charactersitic of 'Bit Definitions' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Front Porch</c> charactersitic of <c>Bit Definitions</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private byte UpperVerticalFrontPorch => CommonBitDefinition[1].ToNibbles()[0];
        #endregion

        #region [private] (byte) UpperVerticalSyncPulseWidth: Gets a value representing the 'Vertical Sync Pulse Width' charactersitic of 'Bit Definitions' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Sync Pulse Width</c> charactersitic of <c>Bit Definitions</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private byte UpperVerticalSyncPulseWidth => CommonBitDefinition[1].ToNibbles()[1];
        #endregion

        #region [private] (int) HorizontalAddresableVideoImageSize: Gets a value representing the 'Horizontal Addressable Video Image Size' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Addressable Video Image Size</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private int HorizontalAddresableVideoImageSize => LogicHelper.Word(RawData[0x0c], UpperHorizontalAndVerticalImageSize[0]);
        #endregion

        #region [private] (int) VerticalAddresableVideoImageSize: Gets a value representing the 'Vertical Addressable Video Image Size' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Addressable Video Image Size</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private int VerticalAddresableVideoImageSize => LogicHelper.Word(RawData[0x0d], UpperHorizontalAndVerticalImageSize[1]);
        #endregion

        #region [private] (byte[]) UpperHorizontalAndVerticalImageSize: Gets a value representing the 'Upper Horizontal Addressable Video Image Size / Upper Vertical Addressable Video Image Size' field
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Upper Horizontal Addressable Video Image Size in mm / Upper Vertical Addressable Video Image Size in mm</c>'.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private byte[] UpperHorizontalAndVerticalImageSize => RawData[0x0e].ToNibbles();
        #endregion

        #region [private] (byte) HorizontalBorder: Gets a value representing the 'Horizontal Border' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Border</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private byte HorizontalBorder => RawData[0x0f];
        #endregion

        #region [private] (byte) VerticalBorder: Gets a value representing the 'Vertical Border' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Border</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private byte VerticalBorder => RawData[0x10];
        #endregion

        #region [private] (KnownSignalInterfaceType) SignalInterfaceType: Gets a value representing the 'Signal Interface Type' characterisitic of 'Byte 17' field
        /// <summary>
        /// Gets a value representing the <c>Signal Interface Type</c> characterisitic of <c>Byte 17</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private KnownSignalInterfaceType SignalInterfaceType => (KnownSignalInterfaceType)(byte) (RawData[0x11] >> 7 & 0x01);
        #endregion

        #region [private] (bool) IsInterlaced: Gets a value representing the 'Interlaced' characterisitic
        /// <summary>
        /// Gets a value representing the <c>Interlaced</c> characterisitic.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private bool IsInterlaced => SignalInterfaceType == KnownSignalInterfaceType.Interlaced;
        #endregion

        #region [private] (byte) StereoViewingSupport: Gets a value representing the 'Stereo Viewing Support' characterisitic of 'Byte 17' field
        /// <summary>
        /// Gets a value representing the <c>Stereo Viewing Support</c> characterisitic of <c>Byte 17</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private byte StereoViewingSupport => (byte) (RawData[0x11] >> 4 & 0x07);
        #endregion

        #region [private] (KnownSyncSignalType) SyncSignal: Gets a value representing the 'Sync Signal' characterisitic of 'Byte 17' field
        /// <summary>
        /// Gets a value representing the <c>Sync Signal</c> characterisitic of <c>Byte 17</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private KnownSyncSignalType SyncSignal => (KnownSyncSignalType)(byte)(RawData[0x11] >> 4 & 0x01);
        #endregion

        #region [private] (bool) IsAnalogBipolar: Gets a value representing the 'Is Analog Bipolar' characterisitic of 'Byte 17' field
        /// <summary>
        /// Gets a value representing the <c>Is Analog Bipolar</c> characterisitic of <c>Byte 17</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private bool IsAnalogBipolar => RawData[0x11].CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) WithAnalogSerrations: Gets a value representing the 'With Analog Serrations' characterisitic of 'Byte 17' field
        /// <summary>
        /// Gets a value representing the <c>With Analog Serrations</c> characterisitic of <c>Byte 17</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private bool WithAnalogSerrations => RawData[0x11].CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) SyncOnThreeVideoSignals: Gets a value representing the 'Sync On Three Video Signals' characterisitic of 'Byte 17' field
        /// <summary>
        /// Gets a value representing the <c>Sync On Three Video Signals</c> characterisitic of <c>Byte 17</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private bool SyncOnThreeVideoSignals => RawData[0x11].CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) IsDigitalSeparateSync: Gets a value representing the 'Is Digital Separate Sync' characterisitic of 'Byte 17' field
        /// <summary>
        /// Gets a value representing the <c>Is Digital Separate Sync</c> characterisitic of <c>Byte 17</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private bool IsDigitalSeparateSync => RawData[0x11].CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) WithDigitalSerrations: Gets a value representing the 'With Digital Serrations' characterisitic of 'Byte 17' field
        /// <summary>
        /// Gets a value representing the <c>With Digital Serrations</c> characterisitic of <c>Byte 17</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private bool WithDigitalSerrations => WithAnalogSerrations;
        #endregion

        #region [private] (bool) IsVerticalSyncPositive: Gets a value representing the 'Is Vertical Sync Positive' characterisitic of 'Byte 17' field
        /// <summary>
        /// Gets a value representing the <c>Is Vertical Sync Positive</c> characterisitic of <c>Byte 17</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private bool IsVerticalSyncPositive => RawData[0x11].CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) IsPositiveHorizontalSync: Gets a value representing the 'Is Positive Horizontal Sync' characterisitic of 'Byte 17' field
        /// <summary>
        /// Gets a value representing the <c>Is Positive Horizontal Sync</c> characterisitic of <c>Byte 17</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private bool IsPositiveHorizontalSync => RawData[0x11].CheckBit(Bits.Bit01);
        #endregion

        #region [private] (string) SyncSignalType: Gets a value representing the 'Sync Signal Type' characterisitic of 'Byte 17' field
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
                string syncOn = string.Empty;
                string signalType = string.Empty;
                string serrations = string.Empty;
                string verticalSync = string.Empty;
                string horizontalSync = string.Empty;
                string syncSignalValue = string.Empty;

                KnownSyncSignalType syncSignal = SyncSignal;
                switch (syncSignal)
                {
                    #region Digital
                    case KnownSyncSignalType.Digital:
                        bool isDigitalSeparateSync = IsDigitalSeparateSync;
                        switch (isDigitalSeparateSync)
                        {
                            case true:
                                signalType = "Digital separate sync, ";

                                bool isVerticalSyncPositive = IsVerticalSyncPositive;
                                switch (isVerticalSyncPositive)
                                {
                                    case true:
                                        verticalSync = "Vertical sync is positive, ";
                                        break;

                                    case false:
                                        verticalSync = "Vertical sync is negative, ";
                                        break;
                                }

                                bool isPositiveHorizontalSync = IsPositiveHorizontalSync;
                                switch (isPositiveHorizontalSync)
                                {
                                    case true:
                                        horizontalSync = "Horizontal sync is negative (outside of V-sync).";
                                        break;

                                    case false:
                                        horizontalSync = "Horizontal sync is positive (outside of V-sync).";
                                        break;
                                }

                                syncSignalValue = string.Concat(signalType, verticalSync, horizontalSync);
                                break;

                            case false:
                                signalType = "Digital composite sync ";

                                bool withDigitalSerrations = WithDigitalSerrations;
                                switch (withDigitalSerrations)
                                {
                                    case true:
                                        serrations = "with serrations (H-sync during V-sync) ";
                                        break;

                                    case false:
                                        serrations = "without serrantions ";
                                        break;
                                }

                                syncSignalValue = string.Concat(signalType, serrations);
                                break;
                        }
                        break;
                    #endregion

                    #region Analog
                    case KnownSyncSignalType.Analog:
                        bool isBipolar = IsAnalogBipolar;
                        switch (isBipolar)
                        {
                            case true:
                                signalType = "Analog bipolar composite sync ";
                                break;

                            case false:
                                signalType = "Analog composite sync ";
                                break;
                        }

                        bool withAnalogSerrations = WithAnalogSerrations;
                        switch (withAnalogSerrations)
                        {
                            case true:
                                serrations = "with serrations (H-sync during V-sync) ";
                                break;

                            case false:
                                serrations = "without serrantions ";
                                break;
                        }

                        bool syncOnThreeVideoSignals = SyncOnThreeVideoSignals;
                        switch (syncOnThreeVideoSignals)
                        {
                            case true:
                                syncOn = "on all three (RGB) video signals.";
                                break;

                            case false:
                                syncOn = "on green signal only.";
                                break;
                        }

                        syncSignalValue = string.Concat(signalType, serrations, syncOn);
                        break;
                    #endregion
                }

                return syncSignalValue;
            }
        }
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

        #endregion


        #region EDID 1.4 Specification

        #region [private] {static} (string) GetStereoViewingSupport(byte): Returns stereo viewing support 
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

        #endregion
    }
}
