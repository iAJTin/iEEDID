
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    // EDID Section: Basic Display Parameters & Features Information
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                                              |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Video Input Definition    BYTE        Bit     07 - Video Signal Interface                                      |
    // |                                                                 0b - Analog                                                 |
    // |                                                                 1b - Digital                                                |
    // |                                                                 Note: See DigitalVideoInputDefinitionValue                  |
    // |                                                    Analog                                                                   |
    // |                                                    ——————                                                                   |
    // |                                                    Bits 06:05 - Signal Level Standard.                                      |
    // |                                                                 0h – 0.700 : 0.300 : 1.000 V p-p                            |
    // |                                                                 1h – 0.714 : 0.286 : 1.000 V p-p                            |
    // |                                                                 2h – 1.000 : 0.400 : 1.400 V p-p                            |
    // |                                                                 3h – 0.700 : 0.000 : 0.700 V p-p                            |
    // |                                                                 Note: See GetSignalLevelStandard(byte)                      |
    // |                                                                                                                             |
    // |                                                    Bit     04 - Video Setup.                                                |
    // |                                                                 0b - Blank Level = Black Level                              |
    // |                                                                 1b - Blank-to-Black setup or pedestal                       |
    // |                                                                 Note: See VideoSetup                                        |
    // |                                                                                                                             |
    // |                                                    Bit     03 - Synchronization Types.                                      |
    // |                                                                 0b - Separate Sync H & V Signals are not supported          |
    // |                                                                 1b - Separate Sync H & V Signals are supported              |
    // |                                                                 Note: See SeparateSyncSupported                             |
    // |                                                                                                                             |
    // |                                                    Bit     02 - Synchronization Types.                                      |
    // |                                                                 0b - Composite Sync Signal on Horizontal is not supported   |
    // |                                                                 1b - Composite Sync Signal on Horizontal is supported       |
    // |                                                                 Note: See CompositeSyncSignalHorizontalSupported            |
    // |                                                                                                                             |
    // |                                                    Bit     01 - Synchronization Types.                                      |
    // |                                                                 0b - Composite Sync Signal on Green Video is not supported  |
    // |                                                                 1b - Composite Sync Signal on Green Video is supported      |
    // |                                                                 Note: See CompositeSyncSignalGreenVideoSupported            |
    // |                                                                                                                             |
    // |                                                                                                                             |
    // |                                                    Bit     00 - Serrations.                                                 |
    // |                                                                 0b - Serration on the Vertical Sync is not supported        |
    // |                                                                 1b - Serration on the Vertical Sync is supported            |
    // |                                                                 Note: See VerticalSyncSupported                             |
    // |                                                    Digital                                                                  |
    // |                                                    ———————                                                                  |
    // |                                                    Bits 06:04 - Color Bit Depth.                                            |
    // |                                                                 0h – Color Bit Depth is undefined                           |
    // |                                                                 1h – 6 Bits per Primary Color                               |
    // |                                                                 2h – 8 Bits per Primary Color                               |
    // |                                                                 3h – 10 Bits per Primary Color                              |
    // |                                                                 4h – 12 Bits per Primary Color                              |
    // |                                                                 5h – 14 Bits per Primary Color                              |
    // |                                                                 6h – 16 Bits per Primary Color                              |
    // |                                                                 7h – Reserved                                               |
    // |                                                                 Note: See GetColorBitDepth(byte)                            |
    // |                                                                                                                             |
    // |                                                    Bits 03:00 - Digital Video Interface Standard Supported.                 |
    // |                                                                        0h – Digital Interface is not defined                |
    // |                                                                        1h – DVI is supported                                |
    // |                                                                        2h – HDMI-a is supported                             |
    // |                                                                        3h – HDMI-b is supported                             |
    // |                                                                        4h – MDDI is supported                               |
    // |                                                                        5h – MDDI is supported                               |
    // |                                                                 6h <-> fh - DisplayPort is supported                        |
    // |                                                                 Note: See GetDigitalVideoInterface(byte)                    |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Horizontal Screen Size    BYTE        Note: See HorizontalScreenSize                                           |
    // |              or Aspect Ratio                                                                                                |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Vertical Screen Size      BYTE        Note: See VerticalScreenSize                                             |
    // |              or Aspect Ratio                                                                                                |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          Display Transfer          BYTE        The integer value stored shall be determined by the formula              |
    // |              Characteristic (Gamma)                Stored Value = (GAMMA x 100) – 100                                       |
    // |                                                    Note: See Gamma                                                          |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Feature Support           BYTE        Bits 07:05 - Display Power Management                                    |
    // |                                                                                                                             |
    // |                                                        Bit 07 - Standby Mode                                                |
    // |                                                                 0b - Not supported                                          |
    // |                                                                 1b - Supported                                              |
    // |                                                                 Note: See StandbyModeSupported                              |
    // |                                                                                                                             |
    // |                                                        Bit 06 - Suspend Mode                                                |
    // |                                                                 0b - Not supported                                          |
    // |                                                                 1b - Supported                                              |
    // |                                                                 Note: See SuspendModeSupported                              |
    // |                                                                                                                             |
    // |                                                        Bit 05 - Active Off = Very Low Power                                 |
    // |                                                                 0b - Not supported                                          |
    // |                                                                 1b - Supported                                              |
    // |                                                                 Note: See ActiveOffSupported                                |
    // |                                                                                                                             |
    // |                                                    Depending on the value of bit 07 of the Video Input Definition field     |
    // |                                                    the following bits are defined as follows:                               |
    // |                                                                                                                             |
    // |                                                    Analog                                                                   |
    // |                                                    ——————                                                                   |
    // |                                                    Bits 04:03 - Display Color Type                                          |
    // |                                                                 0h - Monochrome or Grayscale display                        |
    // |                                                                 1h - RGB color display                                      |
    // |                                                                 2h - Non-RGB color display                                  |
    // |                                                                 3h - Display Color Type is Undefined                        |
    // |                                                                 Note: See GetDisplayColorType(byte)                         |
    // |                                                                                                                             |
    // |                                                    Digital                                                                  |
    // |                                                    ———————                                                                  |
    // |                                                    Bits 04:03 - Supported Color Encoding Format(s)                          |
    // |                                                                 0h - RGB 4:4:4                                              |
    // |                                                                 1h - RGB 4:4:4 & YCrCb 4:4:4                                |
    // |                                                                 2h - RGB 4:4:4 & YCrCb 4:2:2                                |
    // |                                                                 3h - RGB 4:4:4 & YCrCb 4:4:4 & YCrCb 4:2:2                  |
    // |                                                                 Note: See GetSupportedColorEncodingFormat(byte)             |
    // |                                                                                                                             |
    // |                                                    Bits 02:00 - Other Feature Support Flags                                 |
    // |                                                                                                                             |
    // |                                                        Bit 02 - sRGB Standard is the default color space                    |
    // |                                                                 0b - False                                                  |
    // |                                                                 1b - True                                                   |
    // |                                                                 Note: See IssRGBDefaultColorSpace                           |
    // |                                                                                                                             |
    // |                                                        Bit 01 - Preferred Timing Mode includes the native pixel format and  |
    // |                                                                 preferred refresh rate of the display device                |
    // |                                                                 0b - False                                                  |
    // |                                                                 1b - True                                                   |
    // |                                                                 Note: See IncludePreferredTimingMode                        |
    // |                                                                                                                             |
    // |                                                        Bit 00 - Display is continuous frequency                             |
    // |                                                                 0b - False                                                  |
    // |                                                                 1b - True                                                   |
    // |                                                                 Note: See IsContinuousFrequency                             |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="KnownEdidSection.BasicDisplay"/> section of this block <see cref="KnownDataBlock.EDID"/>.
    /// </summary> 
    internal sealed class BasicDisplayEdidSection : BaseDataSection
    {
        #region constructor/s

        #region [public] BasicDisplayEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="BasicDisplayEdidSection"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public BasicDisplayEdidSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (byte) BasicParameters: Gets a value representing the 'Basic Parameters' field
        /// <summary>
        /// Gets a value representing the <c>Basic Parameters</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte BasicParameters => RawData[0x00];
        #endregion

        #region [private] (bool) DigitalVideoInputDefinitionFlag: Gets a value representing the 'Digital Video Input Definition' field
        /// <summary>
        /// Gets a value representing the <c>Digital Video Input Definition</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool DigitalVideoInputDefinitionFlag => BasicParameters.CheckBit(Bits.Bit07);
        #endregion

        #region [private] (string) DigitalVideoInputDefinitionValue: Gets a value representing the 'Digital Video Input Definition Value' field
        /// <summary>
        /// Gets a value representing the <c>Digital Video Input Definition Value</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DigitalVideoInputDefinitionValue => DigitalVideoInputDefinitionFlag ? "Digital" : "Analog";
        #endregion

        #region [private] (byte) SignalLevelStandard: Gets a value representing the 'Signal Level Standard' field
        /// <summary>
        /// Gets a value representing the <c>Signal Level Standard</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SignalLevelStandard => (byte) (BasicParameters >> 5 & 0x03);
        #endregion

        #region [private] (string) VideoSetup: Gets a value representing the 'Video Setup' field
        /// <summary>
        /// Gets a value representing the <c>Video Setup</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string VideoSetup => BasicParameters.CheckBit(Bits.Bit04) ? "Blank Level = Black Level" : "Blank-to-Black setup or pedestal";
        #endregion

        #region [private] (byte) SynchronizationTypes: Gets a value representing the 'Synchronization Types' field
        /// <summary>
        /// Gets a value representing the <c>Synchronization Types</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SynchronizationTypes => (byte) (BasicParameters >> 1 & 0x07);
        #endregion

        #region [private] (bool) SeparateSyncSupported: Gets a value representing the 'Separate Sync Supported' field
        /// <summary>
        /// Gets a value representing the <c>Separate Sync Supported</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool SeparateSyncSupported => SynchronizationTypes.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) CompositeSyncSignalHorizontalSupported: Gets a value representing the 'Composite Sync Signal Horizontal Supported' field
        /// <summary>
        /// Gets a value representing the <c>Composite Sync Signal Horizontal Supported</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool CompositeSyncSignalHorizontalSupported => SynchronizationTypes.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) CompositeSyncSignalGreenVideoSupported: Gets a value representing the 'Composite Sync Signal Green Video Supported' field
        /// <summary>
        /// Gets a value representing the <c>Composite Sync Signal Green Video Supported</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool CompositeSyncSignalGreenVideoSupported => SynchronizationTypes.CheckBit(Bits.Bit00);
        #endregion

        #region [private] (byte) ColorBitDepth: Gets a value representing the 'Color Bit Depth' field
        /// <summary>
        /// Gets a value representing the <c>Color Bit Depth</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ColorBitDepth => (byte) (BasicParameters >> 4 & 0x07);
        #endregion

        #region [private] (byte) DigitalVideoInterface: Gets a value representing the 'Digital Video Interface' field
        /// <summary>
        /// Gets a value representing the <c>Digital Video Interface</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DigitalVideoInterface => (byte)(BasicParameters & 0x0f);
        #endregion

        #region [private] (bool) VerticalSyncSupported: Gets a value representing the 'Vertical Sync Supported' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Sync Supported</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool VerticalSyncSupported => BasicParameters.CheckBit(Bits.Bit00);
        #endregion

        #region [private] (byte) HorizontalScreenSize: Gets a value representing the 'Horizontal Screen Size or Aspect Ratio' field
        /// <summary>
        /// Gets a value representing the <c>Horizontal Screen Size or Aspect Ratio</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte HorizontalScreenSize => RawData[0x01];
        #endregion

        #region [private] (byte) VerticalScreenSize: Gets a value representing the 'Vertical Screen Size or Aspect Ratio' field
        /// <summary>
        /// Gets a value representing the <c>Vertical Screen Size or Aspect Ratio</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte VerticalScreenSize => RawData[0x02];
        #endregion

        #region [private] (double) Gamma: Gets a value representing the 'Gamma' field
        /// <summary>
        /// Gets a value representing the <c>Gamma</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private double Gamma
        {
            get
            {
                double gamma = 0xff;
                byte rawData = RawData[0x03];
                if (rawData != 0xff)
                {
                    gamma = rawData * 0.01 + 1.0;
                }

                return gamma;                    
            }
        }
        #endregion

        #region [private] (byte) Features: Gets a value representing the 'Features' field
        /// <summary>
        /// Gets a value representing the <c>Features</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Features => RawData[0x04];
        #endregion

        #region [private] (byte) DisplayPowerManagement: Gets a value representing the 'Display Power Management' field
        /// <summary>
        /// Gets a value representing the <c>Display Power Management</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DisplayPowerManagement => (byte)(Features >> 5 & 0x07);
        #endregion

        #region [private] (bool) StandbyModeSupported: Gets a value representing the 'Standby Mode Supported' field
        /// <summary>
        /// Gets a value representing the <c>Standby Mode Supported</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool StandbyModeSupported => DisplayPowerManagement.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) SuspendModeSupported: Gets a value representing the 'Suspend Mode Supported' field
        /// <summary>
        /// Gets a value representing the <c>Suspend Mode Supported</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool SuspendModeSupported => DisplayPowerManagement.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) ActiveOffSupported: Gets a value representing the 'Active Off Supported' field
        /// <summary>
        /// Gets a value representing the <c>Active Off Supported</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool ActiveOffSupported => DisplayPowerManagement.CheckBit(Bits.Bit00);
        #endregion

        #region [private] (bool) DisplayColorType: Gets a value representing the 'Display Color Type' field
        /// <summary>
        /// Gets a value representing the 'Display Color Type' field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DisplayColorType => (byte)(Features >> 3 & 0x03);
        #endregion

        #region [private] (byte) ColorEncodingFormat: Gets a value representing the 'Color Encoding Format' field
        /// <summary>
        /// Gets a value representing the 'Color Encoding Format' field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ColorEncodingFormat => (byte) (Features >> 3 & 0x03);
        #endregion

        #region [private] (byte) OtherFeatures: Gets a value representing the 'Other Features' field
        /// <summary>
        /// Gets a value representing the 'Other Features' field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte OtherFeatures => (byte) (Features & 0x07);
        #endregion

        #region [private] (bool) IssRgbDefaultColorSpace: Gets a value representing the 'Is sRgb Default Color Space' field
        /// <summary>
        /// Gets a value representing the 'Is sRgb Default Color Space' field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IssRgbDefaultColorSpace => OtherFeatures.CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) IncludePreferredTimingMode: Gets a value representing the 'Include Preferred Timming Mode' field
        /// <summary>
        /// Gets a value representing the 'Include Preferred Timming Mode' field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IncludePreferredTimingMode => OtherFeatures.CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) IsContinuousFrequency: Gets a value representing the 'Is Continuous Frequency' field
        /// <summary>
        /// Gets a value representing the 'Is Continuous Frequency' field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsContinuousFrequency => OtherFeatures.CheckBit(Bits.Bit00);
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
            #region Basic Parameters

            #region Video Input Definition
            var digitalVideoInputDefinitionFlag = DigitalVideoInputDefinitionFlag;
            properties.Add(EedidProperty.Edid.BasicDisplay.VideoInputDefinition, DigitalVideoInputDefinitionValue);
            switch (digitalVideoInputDefinitionFlag)
            {
                #region Analog Video Signal Interface
                case false:

                    #region Signal Level Standard
                    properties.Add(EedidProperty.Edid.BasicDisplay.Analog.SignalLevelStandard, GetSignalLevelStandard(SignalLevelStandard));
                    #endregion

                    #region Video Setup
                    properties.Add(EedidProperty.Edid.BasicDisplay.Analog.VideoSetup, VideoSetup);
                    #endregion

                    #region Synchronization Types
                    properties.Add(EedidProperty.Edid.BasicDisplay.Analog.Syncrhonization.SeparateSyncSupported, SeparateSyncSupported);
                    properties.Add(EedidProperty.Edid.BasicDisplay.Analog.Syncrhonization.CompositeSyncSignalHorizontalSupported, CompositeSyncSignalHorizontalSupported);
                    properties.Add(EedidProperty.Edid.BasicDisplay.Analog.Syncrhonization.CompositeSyncSignalGreenVideoSupported, CompositeSyncSignalGreenVideoSupported);
                    #endregion

                    #region Vertical Sync Supported
                    properties.Add(EedidProperty.Edid.BasicDisplay.Analog.VerticalSyncSupported, VerticalSyncSupported);
                    break;
                #endregion

                #endregion

                #region Digital Video Signal Interface
                case true:

                    #region Color Bit Depth
                    properties.Add(EedidProperty.Edid.BasicDisplay.Digital.ColorBitDepth, GetColorBitDepth(ColorBitDepth));
                    #endregion

                    #region Digital Video Interface Standard Supported
                    properties.Add(EedidProperty.Edid.BasicDisplay.Digital.VideoInterface, GetDigitalVideoInterface(DigitalVideoInterface));
                    break;
                    #endregion

                #endregion
            }
            #endregion

            #region Horizontal Screen Size or Aspect Ratio
            properties.Add(EedidProperty.Edid.BasicDisplay.HorizontalScreenSize, HorizontalScreenSize);
            #endregion

            #region Vertical Screen Size or Aspect Ratio
            properties.Add(EedidProperty.Edid.BasicDisplay.VerticalScreenSize, VerticalScreenSize);
            #endregion

            #region Display Transfer Characteristic (Gamma)
            var gamma = Gamma;
            if (!gamma.Equals(0xff))
            {
                properties.Add(EedidProperty.Edid.BasicDisplay.Gamma, (double?)gamma);
            }
            #endregion

            #endregion

            #region Feature Support

            #region Display Power Management (DPM)
            properties.Add(EedidProperty.Edid.BasicDisplay.Features.DisplayPowerManagement.StandbyModeSupported, StandbyModeSupported);
            properties.Add(EedidProperty.Edid.BasicDisplay.Features.DisplayPowerManagement.SuspendModeSupported, SuspendModeSupported);
            properties.Add(EedidProperty.Edid.BasicDisplay.Features.DisplayPowerManagement.ActiveOffSupported, ActiveOffSupported);
            #endregion

            #region Display Color Type
            switch (digitalVideoInputDefinitionFlag)
            {
                #region Display Color Type
                case false:
                    properties.Add(EedidProperty.Edid.BasicDisplay.Analog.DisplayColorType, GetDisplayColorType(DisplayColorType));
                    break;
                #endregion

                #region Supported Color Encoding Format
                case true:
                    properties.Add(EedidProperty.Edid.BasicDisplay.Digital.ColorEncodingFormat, GetSupportedColorEncodingFormat(ColorEncodingFormat));
                    break;
                    #endregion
            }
            #endregion

            #region Other Feature Support Flags
            properties.Add(EedidProperty.Edid.BasicDisplay.Features.Other.IsSrgbDefaultColorSpace, IssRgbDefaultColorSpace);
            properties.Add(EedidProperty.Edid.BasicDisplay.Features.Other.IncludePreferredTimingMode, IncludePreferredTimingMode);
            properties.Add(EedidProperty.Edid.BasicDisplay.Features.Other.IsContinuousFrequency, IsContinuousFrequency);
            #endregion

            #endregion            
        }
        #endregion

        #endregion


        #region EDID 1.4 Specification

        #region [private] {static} (string) GetSignalLevelStandard(byte): Returns the signal level for an analog monitor
        /// <summary>
        /// Returns the signal level for an analog monitor.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Signal level for an analog monitor.
        /// </returns>
        private static string GetSignalLevelStandard(byte code)
        {
            var items = new List<string>
            {
                "0.7/0.3 V",
                "0.714/0.286 V",
                "1/0.4 : 1.4 V",
                "0.7/0.0 : 0.7 V"
            };

            return items[code];
        }
        #endregion

        #region [private] {static} (string) GetColorBitDepth(byte): Returns the number of bits of color depth
        /// <summary>
        /// Returns the number of bits of color depth.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Number of color depth bits.
        /// </returns>
        private static string GetColorBitDepth(byte code)
        {
            var items = new[]
            {
                "Undefined",
                "6",
                "8",
                "10",
                "12",
                "14",
                "16",
                "Reserved"
            };

            return items[code];
        }
        #endregion

        #region [private] {static} (string) GetDigitalVideoInterface(byte): Returns the video interface of a monitor
        /// <summary>
        /// Returns the video interface of a monitor.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Monitor video interface.
        /// </returns>
        private static string GetDigitalVideoInterface(byte code)
        {
            var items = new[]
            {
                "Undefined",
                "DVI",
                "HDMI-a",
                "HDMI-b",
                "MDDI",
                "DisplayPort"
            };

            if (code <= 0x05)
            {
                return items[code];
            }

            return "Reserved";
        }
        #endregion

        #region [private] {static} (string) GetDisplayColorType(byte): Returns the color type of the monitor
        /// <summary>
        /// Returns the color type of the monitor.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Color type of the monitor.
        /// </returns> 
        private static string GetDisplayColorType(byte code)
        {
            var items = new[]
            {
                "Monochrome or grayscale display",
                "RGB color display",
                "Non-RGB color display",
                "Undefined"
            };

            return items[code];
        }
        #endregion

        #region [private] {static} (string) GetSupportedColorEncodingFormat(byte): Returns the color coding format of the monitor
        /// <summary>
        /// Returns the color coding format of the monitor.
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Color coding format of the monitor.
        /// </returns> 
        private static string GetSupportedColorEncodingFormat(byte code)
        {
            var items = new[]
            {
                "RGB 4:4:4",
                "RGB 4:4:4 & YCrCb 4:4:4",
                "RGB 4:4:4 & YCrCb 4:2:2",
                "RGB 4:4:4 & YCrCb 4:4:4 & YCrCb 4:2:2"
            };

            return items[code];
        }
        #endregion

        #endregion
    }
}
