
namespace iEEDID.ComponentModel.Parser
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;
    using System.Linq;
    using System.Text;

    using iTin.Core;
    using iTin.Core.Hardware.Common;

    using iTin.Logging.ComponentModel;
    using iTin.Hardware.Specification.Eedid;

    /// <summary>
    /// static class containing methods for prints <b>EEDID</b> instances.
    /// </summary> 
    internal static class ParserHelper
    {
        public static void PrintsRawData(ILogger logger, IEnumerable<byte> data)
        {
            logger.Info("");
            logger.Info($@" edid-decode (hex)");
            logger.Info($@" ┌{new string('─', 48)}");

            var offset = 0;
            var instanceRawData = data.AsHexadecimal().ToList();
            var totalBytes = instanceRawData.Count();
            for (int i = 0; i <= (totalBytes - 1) / 16; i++)
            {
                var piece = instanceRawData.Skip(offset);
                var line = piece.Take(16);

                logger.Info($@" │ {string.Join(" ", line)}");

                offset += 16;
                if (totalBytes <= 128)
                {
                    continue;
                }

                if (offset == 128)
                {
                    logger.Info($@" │");
                }
            }

            logger.Info("");
            logger.Info($" {new string('─', 15)}");
        }

        public static void PrintsBlock(ILogger logger, DataBlock block, int index)
        {
            switch (block.Key)
            {
                case KnownDataBlock.EDID:
                    PrintsEdidBlock(logger, block, index);
                    break;

                case KnownDataBlock.CEA:
                    PrintsCeaBlock(logger, block, index);
                    break;

                case KnownDataBlock.DI:
                    PrintsDiBlock(logger, block, index);
                    break;
            }
        }


        private static void PrintsCeaBlock(ILogger logger, DataBlock block, int index)
        {
            #region Init Block
            logger.Info($@" Block {index}, {block.Key.GetPropertyDescription()}:");
            #endregion

            #region Information Section
            var informationSection = block.Sections[(int)KnownCeaSection.Information];
            var revisionInformation = informationSection.GetProperty(EedidProperty.Cea.Information.Revision);
            logger.Info($@"   Revision: {revisionInformation.Result.Value}");
            #endregion

            #region End Block
            logger.Info("");
            logger.Info(new string('─', 15));
            logger.Info("");
            #endregion
        }

        private static void PrintsDiBlock(ILogger logger, DataBlock block, int index)
        {
            #region Init Block
            logger.Info($@" Block {index}, {block.Key.GetPropertyDescription()}:");
            #endregion

            #region Information Section
            var informationSection = block.Sections[(int)KnownDiSection.Information];
            var versionNumber = informationSection.GetProperty(EedidProperty.DI.Information.VersionNumber);
            logger.Info($@"   Version: {versionNumber.Result.Value}");
            #endregion

            #region Digital Interface Section
            var digitalInterfaceSection = block.Sections[(int)KnownDiSection.DigitalInterface];
            if (digitalInterfaceSection != null)
            {
                logger.Info($@" Digital Interface:");

                var supportedDigitalInterface = digitalInterfaceSection.GetProperty(EedidProperty.DI.DigitalInterface.SupportedDigitalInterface);
                if (supportedDigitalInterface.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DigitalInterface.SupportedDigitalInterface.GetPropertyName()}: {supportedDigitalInterface.Result.Value}");
                }

                var dataEnableSignalUsageAvailable = digitalInterfaceSection.GetProperty(EedidProperty.DI.DigitalInterface.DataEnableSignalUsageAvailable);
                if (dataEnableSignalUsageAvailable.Success)
                {
                    var dataEnableSignalUsageAvailableValue = (bool)dataEnableSignalUsageAvailable.Result.Value;
                    logger.Info($@"   Data Enable Signal Usage{(dataEnableSignalUsageAvailableValue ? " " : " Not ")}Available");

                    if (dataEnableSignalUsageAvailableValue)
                    {
                        var dataEnableSignalHighOrLow = digitalInterfaceSection.GetProperty(EedidProperty.DI.DigitalInterface.DataEnableSignalHighOrLow);
                        if (dataEnableSignalUsageAvailable.Success)
                        {
                            logger.Info($@"   {dataEnableSignalHighOrLow.Result.Value}");
                        }
                    }
                }

                var edgeOfShiftClock = digitalInterfaceSection.GetProperty(EedidProperty.DI.DigitalInterface.EdgeOfShiftClock);
                if (edgeOfShiftClock.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DigitalInterface.EdgeOfShiftClock.GetPropertyName()}: {edgeOfShiftClock.Result.Value}");
                }

                var hdcpSupport = digitalInterfaceSection.GetProperty(EedidProperty.DI.DigitalInterface.HdcpSupport);
                if (hdcpSupport.Success)
                {
                    var hdcpSupportValue = (bool)hdcpSupport.Result.Value;
                    logger.Info($@"   HDCP is{(hdcpSupportValue ? " " : " not ")}support");
                }

                var doubleClockingOfInputData = digitalInterfaceSection.GetProperty(EedidProperty.DI.DigitalInterface.DoubleClockingOfInputData);
                if (doubleClockingOfInputData.Success)
                {
                    var doubleClockingOfInputDataValue = (bool) doubleClockingOfInputData.Result.Value;
                    logger.Info($@"   Digital Receivers{(doubleClockingOfInputDataValue ? " " : " do not ")}support Double Clocking of Input Data");
                }

                var supportForPacketizedDigitalVideoSupport = digitalInterfaceSection.GetProperty(EedidProperty.DI.DigitalInterface.SupportForPacketizedDigitalVideoSupport);
                if (supportForPacketizedDigitalVideoSupport.Success)
                {
                    var supportForPacketizedDigitalVideoSupportValue = (bool) supportForPacketizedDigitalVideoSupport.Result.Value;
                    logger.Info($@"   Packetized Digital Video is{(supportForPacketizedDigitalVideoSupportValue ? " " : " not ")}supported");
                }

                var dataFormats = digitalInterfaceSection.GetProperty(EedidProperty.DI.DigitalInterface.DataFormats);
                if (dataFormats.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DigitalInterface.DataFormats.GetPropertyName()}: {dataFormats.Result.Value}");
                }

                var minimumPixelClockFrequencyPerLink = digitalInterfaceSection.GetProperty(EedidProperty.DI.DigitalInterface.MinimumPixelClockFrequencyPerLink);
                if (minimumPixelClockFrequencyPerLink.Success)
                {
                    var minimumPixelClockFrequencyPerLinkValue = (byte)minimumPixelClockFrequencyPerLink.Result.Value;
                    var minimumPixelClockFrequencyPerLinkText = minimumPixelClockFrequencyPerLinkValue switch
                    {
                        0x00 => "Display has an Analog Video Input",
                        0xff => "Reserved",
                        _ => $"{minimumPixelClockFrequencyPerLinkValue} {EedidProperty.DI.DigitalInterface.MinimumPixelClockFrequencyPerLink.PropertyUnit}"
                    };

                    logger.Info($@"   {EedidProperty.DI.DigitalInterface.MinimumPixelClockFrequencyPerLink.GetPropertyName()}: {minimumPixelClockFrequencyPerLinkText}");
                }

                var maximumPixelClockFrequencyPerLink = digitalInterfaceSection.GetProperty(EedidProperty.DI.DigitalInterface.MaximumPixelClockFrequencyPerLink);
                if (maximumPixelClockFrequencyPerLink.Success)
                {
                    var maximumPixelClockFrequencyPerLinkValue = (int)maximumPixelClockFrequencyPerLink.Result.Value;
                    var maximumPixelClockFrequencyPerLinkText = maximumPixelClockFrequencyPerLinkValue switch
                    {
                        0x0000 => "Display has an Analog Video Input",
                        0xffff => "Reserved",
                        _ => $"{maximumPixelClockFrequencyPerLinkValue} {EedidProperty.DI.DigitalInterface.MaximumPixelClockFrequencyPerLink.PropertyUnit}"
                    };

                    logger.Info($@"   {EedidProperty.DI.DigitalInterface.MaximumPixelClockFrequencyPerLink.GetPropertyName()}: {maximumPixelClockFrequencyPerLinkText}");
                }

                var crossoverFrequency = digitalInterfaceSection.GetProperty(EedidProperty.DI.DigitalInterface.CrossoverFrequency);
                if (crossoverFrequency.Success)
                {
                    var crossoverFrequencyValue = (int)crossoverFrequency.Result.Value;
                    var crossoverFrequencyText = crossoverFrequencyValue switch
                    {
                        0x0000 => "Display has an Analog Video Input",
                        0xffff => "None - Single Link",
                        _ => $"{crossoverFrequencyValue} {EedidProperty.DI.DigitalInterface.CrossoverFrequency.PropertyUnit}"
                    };

                    logger.Info($@"   {EedidProperty.DI.DigitalInterface.CrossoverFrequency.GetPropertyName()}: {crossoverFrequencyText}");
                }
            }
            #endregion

            #region Display Device Section
            var displayDeviceSection = block.Sections[(int)KnownDiSection.DisplayDevice];
            if (displayDeviceSection != null)
            {
                logger.Info($@" Display Device:");

                var subPixelLayout = displayDeviceSection.GetProperty(EedidProperty.DI.DisplayDevice.SubPixelLayout);
                if (subPixelLayout.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayDevice.SubPixelLayout.GetPropertyName()}: {subPixelLayout.Result.Value}");
                }

                var subPixelConfiguration = displayDeviceSection.GetProperty(EedidProperty.DI.DisplayDevice.SubPixelConfiguration);
                if (subPixelConfiguration.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayDevice.SubPixelConfiguration.GetPropertyName()}: {subPixelConfiguration.Result.Value}");
                }

                var subPixelShape = displayDeviceSection.GetProperty(EedidProperty.DI.DisplayDevice.SubPixelShape);
                if (subPixelShape.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayDevice.SubPixelShape.GetPropertyName()}: {subPixelShape.Result.Value}");
                }

                var horizontalDotPixelPitch = displayDeviceSection.GetProperty(EedidProperty.DI.DisplayDevice.HorizontalDotPixelPitch);
                if (horizontalDotPixelPitch.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayDevice.HorizontalDotPixelPitch.GetPropertyName()}: {horizontalDotPixelPitch.Result.Value} {EedidProperty.DI.DisplayDevice.HorizontalDotPixelPitch.PropertyUnit}");
                }

                var verticalDotPixelPitch = displayDeviceSection.GetProperty(EedidProperty.DI.DisplayDevice.VerticalDotPixelPitch);
                if (verticalDotPixelPitch.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayDevice.VerticalDotPixelPitch.GetPropertyName()}: {verticalDotPixelPitch.Result.Value} {EedidProperty.DI.DisplayDevice.VerticalDotPixelPitch.PropertyUnit}");
                }

                var fixedPixelFormat = displayDeviceSection.GetProperty(EedidProperty.DI.DisplayDevice.FixedPixelFormat);
                if (fixedPixelFormat.Success)
                {
                    var fixedPixelFormatValue = (bool) fixedPixelFormat.Result.Value;
                    logger.Info($@"   Display Device{(fixedPixelFormatValue ? " has " : " does not have ")}a Fixed Pixel Format");
                }

                var viewDirection = displayDeviceSection.GetProperty(EedidProperty.DI.DisplayDevice.ViewDirection);
                if (viewDirection.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayDevice.ViewDirection.GetPropertyName()}: {viewDirection.Result.Value}");
                }

                var displayBackground = displayDeviceSection.GetProperty(EedidProperty.DI.DisplayDevice.DisplayBackground);
                if (displayBackground.Success)
                {
                    var displayBackgroundValue = (bool) displayBackground.Result.Value;
                    logger.Info($@"   Display Device uses{(displayBackgroundValue ? " " : " non-")}transparent background");
                }

                var physicalImplementation = displayDeviceSection.GetProperty(EedidProperty.DI.DisplayDevice.PhysicalImplementation);
                if (physicalImplementation.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayDevice.PhysicalImplementation.GetPropertyName()}: {physicalImplementation.Result.Value}");
                }

                var ddc = displayDeviceSection.GetProperty(EedidProperty.DI.DisplayDevice.DDC);
                if (ddc.Success)
                {
                    var ddcValue = (bool) fixedPixelFormat.Result.Value;
                    logger.Info($@"   Monitor/display does{(ddcValue ? " " : " not ")}support DDC/CI");
                }
            }
            #endregion

            #region Display Capabities & Feature Support Set Section
            var displayCapabitiesSection = block.Sections[(int)KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet];
            if (displayCapabitiesSection != null)
            {
                logger.Info($@" Display Capabities & Feature Support Set:");

                var legacyModes = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.LegacyModes);
                if (legacyModes.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.LegacyModes.GetPropertyName()}: {legacyModes.Result.Value}");
                }

                var stereoVideo = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.StereoVideo);
                if (stereoVideo.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.StereoVideo.GetPropertyName()}: {stereoVideo.Result.Value}");
                }

                var scalerOnBoard = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ScalerOnBoard);
                if (scalerOnBoard.Success)
                {
                    var scalerOnBoardValue = (bool) scalerOnBoard.Result.Value;
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ScalerOnBoard.GetPropertyName()}: {(scalerOnBoardValue ? "Yes" : "No")}");
                }

                var imageCentering = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ImageCentering);
                if (imageCentering.Success)
                {
                    var imageCenteringValue = (bool) imageCentering.Result.Value;
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ImageCentering.GetPropertyName()}: {(imageCenteringValue ? "Yes" : "No")}");
                }

                var conditionalUpdate = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ConditionalUpdate);
                if (conditionalUpdate.Success)
                {
                    var conditionalUpdateValue = (bool) conditionalUpdate.Result.Value;
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ConditionalUpdate.GetPropertyName()}: {(conditionalUpdateValue ? "Yes" : "No")}");
                }

                var interlacedVideo = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.InterlacedVideo);
                if (interlacedVideo.Success)
                {
                    var interlacedVideoValue = (bool) interlacedVideo.Result.Value;
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.InterlacedVideo.GetPropertyName()}: {(interlacedVideoValue ? "Yes" : "No")}");
                }

                var frameLock = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.FrameLock);
                if (frameLock.Success)
                {
                    var frameLockValue = (bool) frameLock.Result.Value;
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.FrameLock.GetPropertyName()}: {(frameLockValue ? "Yes" : "No")}");
                }

                var frameRateConversion = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.FrameRateConversion);
                if (frameRateConversion.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.FrameRateConversion.GetPropertyName()}: {frameRateConversion.Result.Value}");
                }

                var verticalFrequency = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.VerticalFrequency);
                if (verticalFrequency.Success)
                {
                    var verticalFrequencyValue = (int) verticalFrequency.Result.Value;
                    var verticalFrequencyText = verticalFrequencyValue switch
                    {
                        0x00 => "Not available",
                        0xff => "Reserved",
                        _ => $"{verticalFrequencyValue} {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.VerticalFrequency.PropertyUnit}"
                    };

                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.VerticalFrequency.GetPropertyName()}: {verticalFrequencyText}");
                }

                var horizontalFrequency = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.HorizontalFrequency);
                if (horizontalFrequency.Success)
                {
                    var horizontalFrequencyValue = (int) horizontalFrequency.Result.Value;
                    var horizontalFrequencyText = horizontalFrequencyValue switch
                    {
                        0x00 => "Not available",
                        0xff => "Reserved",
                        _ => $"{horizontalFrequencyValue} {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.HorizontalFrequency.PropertyUnit}"
                    };

                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.HorizontalFrequency.GetPropertyName()}: {horizontalFrequencyText}");
                }

                var displayScanOrientationType = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.DisplayScanOrientationType);
                if (displayScanOrientationType.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.DisplayScanOrientationType.GetPropertyName()}: {displayScanOrientationType.Result.Value}");
                }

                var screenOrientation = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ScreenOrientation);
                if (screenOrientation.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ScreenOrientation.GetPropertyName()}: {screenOrientation.Result.Value}");
                }

                var zeroPixelLocation = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ZeroPixelLocation);
                if (zeroPixelLocation.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ZeroPixelLocation.GetPropertyName()}: {zeroPixelLocation.Result.Value}");
                }

                var scanDirection = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ScanDirection);
                if (scanDirection.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ScanDirection.GetPropertyName()}: {scanDirection.Result.Value}");
                }

                var standaloneProjector = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.StandaloneProjector);
                if (standaloneProjector.Success)
                {
                    var standaloneProjectorValue = (bool)standaloneProjector.Result.Value;
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.StandaloneProjector.GetPropertyName()}: {(standaloneProjectorValue ? "Yes" : "No")}");
                }

                var defaultColorLuminanceDecoding = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.DefaultColorLuminanceDecoding);
                if (defaultColorLuminanceDecoding.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.DefaultColorLuminanceDecoding.GetPropertyName()}: {defaultColorLuminanceDecoding.Result.Value}");
                }

                var preferredColorLuminanceDecoder = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.PreferredColorLuminanceDecoder);
                if (preferredColorLuminanceDecoder.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.PreferredColorLuminanceDecoder.GetPropertyName()}: {preferredColorLuminanceDecoder.Result.Value}");
                }

                var colorLuminanceDecodingCapabilities = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ColorLuminanceDecodingCapabilities);
                if (colorLuminanceDecodingCapabilities.Success)
                {
                    var colorLuminanceDecodingCapabilitiesValue = (string[]) colorLuminanceDecodingCapabilities.Result.Value;
                    var hasElements = colorLuminanceDecodingCapabilitiesValue.Any();
                    if (hasElements)
                    {
                        var onlyOne = colorLuminanceDecodingCapabilitiesValue.Length == 1;
                        if (onlyOne)
                        {
                            logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ColorLuminanceDecodingCapabilities.GetPropertyName()}: {colorLuminanceDecodingCapabilitiesValue.FirstOrDefault()}");
                        }
                        else
                        {
                            logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.ColorLuminanceDecodingCapabilities.GetPropertyName()}:");
                            foreach (var entry in colorLuminanceDecodingCapabilitiesValue)
                            {
                                logger.Info($@"     {entry}");
                            }
                        }
                    }
                }

                var dithering = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.Dithering);
                if (dithering.Success)
                {
                    var ditheringValue = (bool) dithering.Result.Value;
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.Dithering.GetPropertyName()}: {(ditheringValue ? "Yes" : "No")}");
                }

                var supportedColorBitDepthSubChannel0Blue = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0Blue);
                if (supportedColorBitDepthSubChannel0Blue.Success)
                {
                    var supportedColorBitDepthSubChannel0BlueValue = (byte) supportedColorBitDepthSubChannel0Blue.Result.Value;
                    var supportedColorBitDepthSubChannel0BlueText = supportedColorBitDepthSubChannel0BlueValue switch
                    {
                        0x00 => "No Information",
                        var n when n >= 0x01 && n <= 0x10 => $"{supportedColorBitDepthSubChannel0BlueValue} {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0Blue.PropertyUnit} per color",
                        _ => "Reserved"
                    };

                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0Blue.GetPropertyName()}: {supportedColorBitDepthSubChannel0BlueText}");
                }

                var supportedColorBitDepthSubChannel1Green = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Green);
                if (supportedColorBitDepthSubChannel1Green.Success)
                {
                    var supportedColorBitDepthSubChannel1GreenValue = (byte) supportedColorBitDepthSubChannel1Green.Result.Value;
                    var supportedColorBitDepthSubChannel1GreenText = supportedColorBitDepthSubChannel1GreenValue switch
                    {
                        0x00 => "No Information",
                        var n when n >= 0x01 && n <= 0x10 => $"{supportedColorBitDepthSubChannel1GreenValue} {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Green.PropertyUnit} per color",
                        _ => "Reserved"
                    };

                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Green.GetPropertyName()}: {supportedColorBitDepthSubChannel1GreenText}");
                }

                var supportedColorBitDepthSubChannel2Red = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2Red);
                if (supportedColorBitDepthSubChannel2Red.Success)
                {
                    var supportedColorBitDepthSubChannel2RedValue = (byte) supportedColorBitDepthSubChannel2Red.Result.Value;
                    var supportedColorBitDepthSubChannel2RedText = supportedColorBitDepthSubChannel2RedValue switch
                    {
                        0x00 => "No Information",
                        var n when n >= 0x01 && n <= 0x10 => $"{supportedColorBitDepthSubChannel2RedValue} {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2Red.PropertyUnit} per color",
                        _ => "Reserved"
                    };

                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2Red.GetPropertyName()}: {supportedColorBitDepthSubChannel2RedText}");
                }

                var supportedColorBitDepthSubChannel0CbPb = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0CbPb);
                if (supportedColorBitDepthSubChannel0CbPb.Success)
                {
                    var supportedColorBitDepthSubChannel0CbPbValue = (byte) supportedColorBitDepthSubChannel0CbPb.Result.Value;
                    var supportedColorBitDepthSubChannel0CbPbText = supportedColorBitDepthSubChannel0CbPbValue switch
                    {
                        0x00 => "No Information",
                        var n when n >= 0x01 && n <= 0x10 => $"{supportedColorBitDepthSubChannel0CbPbValue} {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0CbPb.PropertyUnit} per color",
                        _ => "Reserved"
                    };

                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0CbPb.GetPropertyName()}: {supportedColorBitDepthSubChannel0CbPbText}");
                }

                var supportedColorBitDepthSubChannel1Y = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Y);
                if (supportedColorBitDepthSubChannel1Y.Success)
                {
                    var supportedColorBitDepthSubChannel1YValue = (byte)supportedColorBitDepthSubChannel0CbPb.Result.Value;
                    string supportedColorBitDepthSubChannel1YText = supportedColorBitDepthSubChannel1YValue switch
                    {
                        0x00 => "No Information",
                        var n when n >= 0x01 && n <= 0x10 => $"{supportedColorBitDepthSubChannel1YValue} {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Y.PropertyUnit} per color",
                        _ => "Reserved"
                    };

                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Y.GetPropertyName()}: {supportedColorBitDepthSubChannel1YText}");
                }

                var supportedColorBitDepthSubChannel2CrPr = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2CrPr);
                if (supportedColorBitDepthSubChannel2CrPr.Success)
                {
                    var supportedColorBitDepthSubChannel2CrPrValue = (byte)supportedColorBitDepthSubChannel2CrPr.Result.Value;
                    string supportedColorBitDepthSubChannel2CrPrText = supportedColorBitDepthSubChannel2CrPrValue switch
                    {
                        0x00 => "No Information",
                        var n when n >= 0x01 && n <= 0x10 => $"{supportedColorBitDepthSubChannel2CrPrValue} {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2CrPr.PropertyUnit} per color",
                        _ => "Reserved"
                    };

                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2CrPr.GetPropertyName()}: {supportedColorBitDepthSubChannel2CrPrText}");
                }

                var aspectRatioConversionModes = displayCapabitiesSection.GetProperty(EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.AspectRatioConversionModes);
                if (aspectRatioConversionModes.Success)
                {
                    logger.Info($@"   {EedidProperty.DI.DisplayCapabilitiesAndFeatureSupportSet.AspectRatioConversionModes.GetPropertyName()}: {aspectRatioConversionModes.Result.Value}");
                }
            }
            #endregion

            #region Display Transfer Characteristics
            var displayTransferCharacteristicSection = block.Sections[(int)KnownDiSection.DisplayTransferCharacteristic];
            if (displayTransferCharacteristicSection != null)
            {
                logger.Info($@" Display Transfer Characteristics - Gamma:");

                var displayTransferCharacteristicStatus = displayTransferCharacteristicSection.GetProperty(EedidProperty.DI.DisplayTransferCharacteristic.Status);
                if (displayTransferCharacteristicStatus.Success)
                {
                    logger.Info($@"   {displayTransferCharacteristicStatus.Result.Value}");
                }
            }
            #endregion

            #region Miscellaneous Section
            var miscellaneousSection = block.Sections[(int)KnownDiSection.Miscellaneous];
            var status = miscellaneousSection.GetProperty(EedidProperty.DI.Miscellaneous.CheckSum.Ok);
            var value = miscellaneousSection.GetProperty(EedidProperty.DI.Miscellaneous.CheckSum.Value);
            logger.Info($@" Checksum: {value.Result.Value:x2} ({((bool)status.Result.Value ? "Valid" : "Invalid")})");
            #endregion

            #region End Block
            logger.Info("");
            logger.Info(new string('─', 15));
            logger.Info("");
            #endregion
        }

        private static void PrintsEdidBlock(ILogger logger, DataBlock block, int index)
        {
            #region Init Block
            logger.Info("");
            logger.Info($@" Block {index}, Base {block.Key}:");
            #endregion

            #region Version Section
            var versionSection = block.Sections[(int)KnownEdidSection.Version];
            var version = versionSection.GetProperty(EedidProperty.Edid.Version.Number);
            var revision = versionSection.GetProperty(EedidProperty.Edid.Version.Revision);
            logger.Info($@"   EDID Structure Version & Revision: {version.Result.Value}.{revision.Result.Value}");
            #endregion

            #region Vendor Section
            var vendorSection = block.Sections[(int)KnownEdidSection.Vendor];
            logger.Info($@"   Vendor & Product Identification:");
            var manufacturer = vendorSection.GetProperty(EedidProperty.Edid.Vendor.IdManufacturerName);
            if (manufacturer.Success)
            {
                logger.Info($@"     Manufacturer: {manufacturer.Result.Value}");
            }

            var model = vendorSection.GetProperty(EedidProperty.Edid.Vendor.IdProductCode);
            if (model.Success)
            {
                logger.Info($@"     Model: {model.Result.Value}");
            }

            var serialNumber = vendorSection.GetProperty(EedidProperty.Edid.Vendor.IdSerialNumber);
            if (serialNumber.Success)
            {
                logger.Info($@"     Serial Number: {serialNumber.Result.Value}");
            }

            var manufactureDate = vendorSection.GetProperty(EedidProperty.Edid.Vendor.ManufactureDate);
            if (model.Success)
            {
                logger.Info($@"     Made in: {manufactureDate.Result.Value}");
            }
            #endregion

            #region Basic Display Section
            var basicDisplaySection = block.Sections[(int)KnownEdidSection.BasicDisplay];
            logger.Info(@"   Basic Display Parameters & Features:");

            bool isDigital = true;
            var videoInputDefinition = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.VideoInputDefinition);
            if (videoInputDefinition.Success)
            {
                isDigital = videoInputDefinition.Result.Value.ToString().Equals("Digital", System.StringComparison.OrdinalIgnoreCase);
                logger.Info($@"     {videoInputDefinition.Result.Value} display");
            }

            if(isDigital)
            {
                var bitsPrimaryColorChannel = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Digital.ColorBitDepth);
                if (bitsPrimaryColorChannel.Success)
                {
                    var bitsPrimaryColorChannelValue = bitsPrimaryColorChannel.Result.Value.ToString();
                    if (!bitsPrimaryColorChannelValue.Equals("Undefined", System.StringComparison.OrdinalIgnoreCase))
                    {
                        logger.Info($@"     Bits per primary color channel: {bitsPrimaryColorChannel.Result.Value}");
                    }
                }
                 
                var digitalVideoInterface = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Digital.VideoInterface);
                if (digitalVideoInterface.Success)
                {
                    var digitalVideoInterfaceValue = digitalVideoInterface.Result.Value.ToString();
                    if (!digitalVideoInterfaceValue.Equals("Undefined", System.StringComparison.OrdinalIgnoreCase))
                    {
                        logger.Info($@"     {digitalVideoInterface.Result.Value} interface");
                    }
                }

                var encodingFormat = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Digital.ColorEncodingFormat);
                if (encodingFormat.Success)
                {
                    logger.Info($@"     Supported color formats: {encodingFormat.Result.Value}");
                }
            }
            else
            {
                var signalLevel = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Analog.SignalLevelStandard);
                if (signalLevel.Success)
                {
                    logger.Info($@"     Input voltage level: {signalLevel.Result.Value}");
                }

                var syncBuilder = new StringBuilder();
                var separateSync = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Analog.Syncrhonization.SeparateSyncSupported);
                if (separateSync.Success)
                {
                    syncBuilder.Append($"{((bool)separateSync.Result.Value ? "Separate" : "Non separate")}");
                }

                var compositeSync = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Analog.Syncrhonization.CompositeSyncSignalHorizontalSupported);
                if (compositeSync.Success)
                {
                    var compositeSyncValue = (bool)compositeSync.Result.Value;
                    if (compositeSyncValue)
                    {
                        syncBuilder.Append(" Composite");
                    }
                }

                var syncOnGreen = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Analog.Syncrhonization.CompositeSyncSignalGreenVideoSupported);
                if (syncOnGreen.Success)
                {
                    var syncOnGreenValue = (bool)syncOnGreen.Result.Value;
                    if (syncOnGreenValue)
                    {
                        syncBuilder.Append(" SyncOnGreen");
                    }
                }

                logger.Info($@"     Sync: {syncBuilder}");
            }

            var horizontalScreenSizeUnits = EedidProperty.Edid.BasicDisplay.HorizontalScreenSize.PropertyUnit;
            var horizontalScreenSize = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.HorizontalScreenSize);
            var verticalScreenSizeUnits = EedidProperty.Edid.BasicDisplay.VerticalScreenSize.PropertyUnit;
            var verticalScreenSize = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.VerticalScreenSize);
            if (horizontalScreenSize.Success && verticalScreenSize.Success)
            {
                logger.Info($@"     Maximum image size: {horizontalScreenSize.Result.Value} {horizontalScreenSizeUnits} x {verticalScreenSize.Result.Value} {verticalScreenSizeUnits}");
            }

            var gamma = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Gamma);
            if (gamma.Success)
            {
                logger.Info($@"     Gamma: {gamma.Result.Value:n2}");
            }

            var lowPowerValue = false;
            var lowPower = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Features.DisplayPowerManagement.ActiveOffSupported);
            if (lowPower.Success)
            {
                lowPowerValue = (bool)lowPower.Result.Value;
            }

            var standbyModeValue = false;
            var standbyMode = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Features.DisplayPowerManagement.StandbyModeSupported);
            if (standbyMode.Success)
            {
                standbyModeValue = (bool)standbyMode.Result.Value;
            }

            var suspendModeValue = false;
            var suspendMode = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Features.DisplayPowerManagement.SuspendModeSupported);
            if (suspendMode.Success)
            {
                suspendModeValue = (bool)suspendMode.Result.Value;
            }

            var dpmsLevelsIsOff = lowPowerValue == true && standbyModeValue == false && suspendModeValue == false;
            if (dpmsLevelsIsOff)
            {
                logger.Info($@"     DPMS levels : Off");
            }
            else
            {
                if (suspendModeValue)
                {
                    logger.Info($@"     DPMS levels : Standby Suspend Off");
                }
                else if (!standbyModeValue)
                {
                    logger.Info($@"     DPMS levels : Standby Off");
                }
            }

            var displayColorType = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Analog.DisplayColorType);
            if (displayColorType.Success)
            {
                logger.Info($@"     {displayColorType.Result.Value}");
            }

            var isSrgbDefaultColorSpace = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Features.Other.IsSrgbDefaultColorSpace);
            if (isSrgbDefaultColorSpace.Success)
            {
                var isSrgbDefaultColorSpaceValue = (bool)isSrgbDefaultColorSpace.Result.Value;
                if (isSrgbDefaultColorSpaceValue)
                {
                    logger.Info($@"     Default (sRGB) color space is primary color space");
                }
            }

            var includePreferredTimingMode = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Features.Other.IncludePreferredTimingMode);
            if (includePreferredTimingMode.Success)
            {
                var includePreferredTimingModeValue = (bool)includePreferredTimingMode.Result.Value;
                logger.Info(includePreferredTimingModeValue 
                    ? "     First detailed timing includes the native pixel format and preferred refresh rate" 
                    : "     First detailed timing is the preferred timing");
            }
            #endregion

            #region Color Characteristics Section
            var colorSection = block.Sections[(int)KnownEdidSection.ColorCharacteristics];
            logger.Info(@"   Color Characteristics:");

            var red = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Red);
            if (red.Success)
            {
                logger.Info($@"     Red  : {((PointF)red.Result.Value).X:n4} {((PointF)red.Result.Value).Y:n4}");
            }

            var green = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Green);
            if (green.Success)
            {
                logger.Info($@"     Green: {((PointF)green.Result.Value).X:n4} {((PointF)green.Result.Value).Y:n4}");
            }

            var blue = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Blue);
            if (blue.Success)
            {
                logger.Info($@"     Blue : {((PointF)blue.Result.Value).X:n4} {((PointF)blue.Result.Value).Y:n4}");
            }

            var white = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.White);
            if (white.Success)
            {
                logger.Info($@"     White: {((PointF)white.Result.Value).X:n4} {((PointF)white.Result.Value).Y:n4}");
            }
            #endregion

            #region Established Timings Section
            var establishedTimingsSection = block.Sections[(int)KnownEdidSection.EstablishedTimings];
            var resolutions = establishedTimingsSection.GetProperty(EedidProperty.Edid.EstablishedTimings.Resolutions);
            if (resolutions.Success)
            {
                var monitorReslutions = (ReadOnlyCollection<MonitorResolutionInfo>)resolutions.Result.Value;
                if (monitorReslutions.Any())
                {
                    logger.Info(@"   Established Timings I & II:");
                    foreach (var monitorResolution in monitorReslutions)
                    {
                        var resolution = $@"{monitorResolution.Size.Width}x{monitorResolution.Size.Height}";
                        logger.Info($@"     {monitorResolution.Name, 6}:{resolution, 10}{'\t'}{monitorResolution.Frequency} Hz{'\t'}{monitorResolution.ApectRatio}");
                    }
                }
                else
                {
                    logger.Info(@"   Established Timings I & II: none");
                }
            }
            else
            {
                logger.Info(@"   Established Timings I & II: none");
            }
            #endregion

            #region Standard Timings Section
            var standardTimingsSection = block.Sections[(int)KnownEdidSection.StandardTimings];
            var timing1 = standardTimingsSection.GetProperty(EedidProperty.Edid.StandardTimings.Timing1);
            var timing2 = standardTimingsSection.GetProperty(EedidProperty.Edid.StandardTimings.Timing2);
            var timing3 = standardTimingsSection.GetProperty(EedidProperty.Edid.StandardTimings.Timing3);
            var timing4 = standardTimingsSection.GetProperty(EedidProperty.Edid.StandardTimings.Timing4);
            var timing5 = standardTimingsSection.GetProperty(EedidProperty.Edid.StandardTimings.Timing5);
            var timing6 = standardTimingsSection.GetProperty(EedidProperty.Edid.StandardTimings.Timing6);
            var timing7 = standardTimingsSection.GetProperty(EedidProperty.Edid.StandardTimings.Timing7);
            var timing8 = standardTimingsSection.GetProperty(EedidProperty.Edid.StandardTimings.Timing8);
            var hasTimings = timing1.Success && timing2.Success && timing3.Success && timing4.Success && timing5.Success && timing6.Success && timing7.Success && timing8.Success;

            var timing1Value = (StandardTimingIdentifierDescriptorItem) timing1.Result.Value;
            var timing2Value = (StandardTimingIdentifierDescriptorItem) timing2.Result.Value;
            var timing3Value = (StandardTimingIdentifierDescriptorItem) timing3.Result.Value;
            var timing4Value = (StandardTimingIdentifierDescriptorItem) timing4.Result.Value;
            var timing5Value = (StandardTimingIdentifierDescriptorItem) timing5.Result.Value;
            var timing6Value = (StandardTimingIdentifierDescriptorItem) timing6.Result.Value;
            var timing7Value = (StandardTimingIdentifierDescriptorItem) timing7.Result.Value;
            var timing8Value = (StandardTimingIdentifierDescriptorItem) timing8.Result.Value;
            var hasTimmingValues = timing1Value != null || timing2Value != null || timing3Value != null || timing4Value != null || timing5Value != null || timing6Value != null || timing7Value != null || timing8Value != null;
            
            if (!hasTimings || !hasTimmingValues)
            {
                logger.Info(@"   Standard Timings: none");
            }
            else
            {
                logger.Info(@"   Standard Timings:");
                PrintsStandardTimming(timing1Value, logger);
                PrintsStandardTimming(timing2Value, logger);
                PrintsStandardTimming(timing3Value, logger);
                PrintsStandardTimming(timing4Value, logger);
                PrintsStandardTimming(timing5Value, logger);
                PrintsStandardTimming(timing6Value, logger);
                PrintsStandardTimming(timing7Value, logger);
                PrintsStandardTimming(timing8Value, logger);
            }
            #endregion

            #region Detailed Timing Descriptors
            logger.Info(@"   Detailed Timing Descriptors:");
            var dataBlocksSection = block.Sections[(int)KnownEdidSection.DataBlocks];

            #region Descriptor 1. Preferred Timing Mode (Required)
            var descriptor1 = dataBlocksSection.GetProperty(EedidProperty.Edid.DataBlock.Descriptor1);
            if (descriptor1.Success)
            {
                var descriptorValue = descriptor1.Result.Value;
                if (descriptorValue != null)
                {
                    PrintsDescriptor((DataBlockDescriptorData) descriptorValue, logger);
                }
            }
            #endregion

            #region Descriptor 2
            var descriptor2 = dataBlocksSection.GetProperty(EedidProperty.Edid.DataBlock.Descriptor2);
            if (descriptor2.Success)
            {
                var descriptorValue = descriptor2.Result.Value;
                if (descriptorValue != null)
                {
                    PrintsDescriptor((DataBlockDescriptorData)descriptorValue, logger);
                }
            }
            #endregion

            #region Descriptor 3
            var descriptor3 = dataBlocksSection.GetProperty(EedidProperty.Edid.DataBlock.Descriptor3);
            if (descriptor3.Success)
            {
                var descriptorValue = descriptor3.Result.Value;
                if (descriptorValue != null)
                {
                    PrintsDescriptor((DataBlockDescriptorData)descriptorValue, logger);
                }
            }
            #endregion

            #region Descriptor 4
            var descriptor4 = dataBlocksSection.GetProperty(EedidProperty.Edid.DataBlock.Descriptor4);
            if (descriptor4.Success)
            {
                var descriptorValue = descriptor4.Result.Value;
                if (descriptorValue != null)
                {
                    PrintsDescriptor((DataBlockDescriptorData)descriptorValue, logger);
                }
            }
            #endregion

            #endregion

            #region Extension Blocks Section
            var extensionBlocksSection = block.Sections[(int)KnownEdidSection.ExtensionBlocks];
            var count = extensionBlocksSection.GetProperty(EedidProperty.Edid.ExtensionBlocks.Count);
            if (count.Success)
            {
                var countNumber = (byte) count.Result.Value;
                if (countNumber > 0)
                {
                    logger.Info($@"   Extension blocks: {countNumber}");
                }
            }
            #endregion

            #region CheckSum Section
            var checksumSection = block.Sections[(int)KnownEdidSection.CheckSum];
            var status = checksumSection.GetProperty(EedidProperty.Edid.CheckSum.Ok);
            var value = checksumSection.GetProperty(EedidProperty.Edid.CheckSum.Value);
            logger.Info($@" Checksum: {value.Result.Value:x2} ({((bool)status.Result.Value ? "Valid" : "Invalid")})");
            #endregion

            #region End Block
            logger.Info("");
            logger.Info(new string('─', 15));
            logger.Info("");
            #endregion
        }


        private static void PrintsStandardTimming(StandardTimingIdentifierDescriptorItem data, ILogger logger)
        {
            if (data == null)
            {
                return;
            }

            var resolution1 = $@"{data.HorizontalPixels}x{data.VerticalPixels}";
            logger.Info($@"     {resolution1,9}{'\t'}{data.RefreshRate} Hz{'\t'}{data.AspectRatio}");
        }

        private static void PrintsDescriptor(DataBlockDescriptorData data, ILogger logger)
        {
            var type = data.DescriptorType;
            switch (type)
            {
                #region AlphaNumeric Data String Descriptor
                case EdidDataBlockDescriptor.AlphaNumericDataString:
                    var alphanumericData = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.AlphanumericDataString.Data);
                    if (alphanumericData.Success)
                    {
                        var alphanumericDataString = alphanumericData.Result.Value;
                        if (alphanumericDataString != null)
                        {
                            var value = alphanumericDataString.ToString().RemoveControlCharacters().Trim().Replace("?", string.Empty);
                            logger.Info($@"     Alphanumeric Data String: '{value}'");
                        }
                    }
                    break;
                #endregion

                #region Color Management Data Descriptor
                case EdidDataBlockDescriptor.ColorManagementData:
                    logger.Info($@"     Color Management Data Descriptor:");

                    var version = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.ColorManagementData.VersionNumber);
                    if (version.Success)
                    {
                        logger.Info($@"     Version: {version.Result.Value}");
                    }

                    var red = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.ColorManagementData.Red);
                    if (red.Success)
                    {
                        logger.Info($@"         Red: {((PointF)red.Result.Value).X:n4} {((PointF)red.Result.Value).Y:n4}");
                    }

                    var green = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.ColorManagementData.Green);
                    if (green.Success)
                    {
                        logger.Info($@"       Green: {((PointF)green.Result.Value).X:n4} {((PointF)green.Result.Value).Y:n4}");
                    }

                    var blue = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.ColorManagementData.Blue);
                    if (blue.Success)
                    {
                        logger.Info($@"        Blue: {((PointF)blue.Result.Value).X:n4} {((PointF)blue.Result.Value).Y:n4}");
                    }
                    break;
                #endregion

                #region Color Point Data Descriptor
                case EdidDataBlockDescriptor.ColorPointData:
                    logger.Info($@"     Color Point Data Descriptor:");

                    var point1 = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.ColorPointData.Point1);
                    if (point1.Success)
                    {
                        var point1Data = (ColorPointDataDescriptorItem) point1.Result.Value;
                        if (point1Data != null)
                        {
                            logger.Info($@"     Point 1:");

                            var gamma = point1Data.GetProperty(EedidProperty.Edid.DataBlock.Definition.ColorPointData.Item.Gamma);
                            if (gamma.Success)
                            {
                                logger.Info($@"       Gamma: {gamma.Result.Value:n2}");
                            }

                            var white = point1Data.GetProperty(EedidProperty.Edid.DataBlock.Definition.ColorPointData.Item.White);
                            if (white.Success)
                            {
                                var index = point1Data.GetProperty(EedidProperty.Edid.DataBlock.Definition.ColorPointData.Item.Index);
                                logger.Info($@"       White {index.Result.Value}: {((PointF)white.Result.Value).X:n4} {((PointF)white.Result.Value).Y:n4}");
                            }
                        }
                    }

                    var point2 = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.ColorPointData.Point2);
                    if (point2.Success)
                    {
                        var point2Data = (ColorPointDataDescriptorItem)point2.Result.Value;
                        if (point2Data != null)
                        {
                            logger.Info($@"     Point 2:");

                            var gamma = point2Data.GetProperty(EedidProperty.Edid.DataBlock.Definition.ColorPointData.Item.Gamma);
                            if (gamma.Success)
                            {
                                logger.Info($@"       Gamma: {gamma.Result.Value:n2}");
                            }

                            var white = point2Data.GetProperty(EedidProperty.Edid.DataBlock.Definition.ColorPointData.Item.White);
                            if (white.Success)
                            {
                                var index = point2Data.GetProperty(EedidProperty.Edid.DataBlock.Definition.ColorPointData.Item.Index);
                                logger.Info($@"       White {index.Result.Value}: {((PointF)white.Result.Value).X:n4} {((PointF)white.Result.Value).Y:n4}");
                            }
                        }
                    }
                    break;
                #endregion

                #region Cvt 3Byte Code Descriptor
                case EdidDataBlockDescriptor.Cvt3ByteCode:
                    logger.Info($@"     Cvt 3Byte Code Descriptor:");
                    var versionNumber = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.VersionNumber);
                    if (versionNumber.Success)
                    {
                        logger.Info($@"       Version: {versionNumber.Result.Value}");
                    }

                    var priority1 = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Priority1);
                    if (priority1.Success)
                    {
                        var priority1Value = (Cvt3ByteCodeDescriptorItem) priority1.Result.Value;
                        if (priority1Value != null)
                        {
                            var vl = priority1Value.GetProperty(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.AddressableVerticalLines);
                            var ap = priority1Value.GetProperty(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.AspectRatio);
                            var vr = priority1Value.GetProperty(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.PreferredVerticalRate);
                            var is50 = priority1Value.GetProperty(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.SupportedVerticalRateAndBlanking.IsSupported50HzWithStandardBlanking);
                            var is60 = priority1Value.GetProperty(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.SupportedVerticalRateAndBlanking.IsSupported60HzWithReducedBlanking);
                            var is60_1 = priority1Value.GetProperty(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.SupportedVerticalRateAndBlanking.IsSupported60HzWithStandardBlanking);
                            var is75 = priority1Value.GetProperty(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.SupportedVerticalRateAndBlanking.IsSupported75HzWithStandardBlanking);
                            var is85 = priority1Value.GetProperty(EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.Item.SupportedVerticalRateAndBlanking.IsSupported85HzWithStandardBlanking);
                        }
                    }
                    break;
                #endregion

                #region Detailed Timing Mode Descriptor
                case EdidDataBlockDescriptor.DetailedTimingMode:
                    var verticalLines = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalLines);
                    var horizontalResolution = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalResolution);
                    var pixelClock = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.PixelClock);
                    var horizontalImageSize = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalImageSize);
                    var verticalImageSize = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalImageSize);

                    var resolution = $@"{horizontalResolution.Result.Value}x{verticalLines.Result.Value}";
                    logger.Info($@"     DTD: {resolution, 10} {(int)pixelClock.Result.Value / 1000:N0} MHz ({horizontalImageSize.Result.Value} {EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalImageSize.PropertyUnit} x {verticalImageSize.Result.Value} {EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalImageSize.PropertyUnit})");

                    var horizontalFront = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalFrontPorch);
                    var horizontalSyncPulse = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalSyncPulseWidth);
                    logger.Info($@"{"Hfront", 19}{horizontalFront.Result.Value, 5} Hsync{horizontalSyncPulse.Result.Value, 4} Hback 00 Hpol ?");

                    var verticalFront = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalFrontPorch);
                    var verticalSyncPulse = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalSyncPulseWidth);
                    logger.Info($@"{"Vfront", 19}{verticalFront.Result.Value, 5} Vsync{verticalSyncPulse.Result.Value,4} Vback 00 Vpol ?");
                    break;
                #endregion

                #region Display Product Name Descriptor
                case EdidDataBlockDescriptor.DisplayProductName:
                    var productNameData = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DisplayProductName.Data);
                    if (productNameData.Success)
                    {
                        var productName = productNameData.Result.Value;
                        if (productName != null)
                        {
                            var value = productName.ToString().RemoveControlCharacters().Trim().Replace("?", string.Empty);
                            logger.Info(string.IsNullOrEmpty(value)
                                ? @"     Display Product Name:"
                                : $@"     Display Product Name: '{value}'");
                        }
                    }
                    break;
                #endregion

                #region Display Product Serial Number Descriptor
                case EdidDataBlockDescriptor.DisplayProductSerialNumber:
                    var displayProductSerialNumberData = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DisplayProductSerialNumber.Data);
                    if (displayProductSerialNumberData.Success)
                    {
                        var productSerialNumber = displayProductSerialNumberData.Result.Value;
                        if (productSerialNumber != null)
                        {
                            var value = productSerialNumber.ToString().RemoveControlCharacters().Replace("?", string.Empty);
                            logger.Info(string.IsNullOrEmpty(value)
                                ? @"     Display Product Serial Number:"
                                : $@"     Display Product Serial Number: '{value}'");
                        }
                    }
                    break;
                #endregion

                #region Display Range Limits Descriptor
                case EdidDataBlockDescriptor.DisplayRangeLimits:
                    var minimumHorizontalRate = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MinimumHorizontalRate);
                    var maximumHorizontalRate = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MaximumHorizontalRate);
                    var minimumVerticalRate = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MinimumVerticalRate);
                    var maximumVerticalRate = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MaximumVerticalRate);
                    var maximumPixelClock = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MaximumPixelClock);
                    logger.Info($@"     Display Range Limits:");
                    logger.Info($@"       Monitor ranges (GTF): {minimumVerticalRate.Result.Value}-{maximumVerticalRate.Result.Value} Hz V, {minimumHorizontalRate.Result.Value}-{maximumHorizontalRate.Result.Value} kHz H, max dotclock {maximumPixelClock.Result.Value} MHz");
                    break;
                #endregion

                #region Dummy Data Descriptor
                case EdidDataBlockDescriptor.DummyData:
                    var dummyData = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.DummyData.OriginalData);
                    if (dummyData.Success)
                    {
                        var dummy = dummyData.Result.Value;
                        if (dummy != null)
                        {
                            var value = dummy.ToString().RemoveControlCharacters().Replace("?", string.Empty);
                            logger.Info(string.IsNullOrEmpty(value)
                                ? @"     Dummy Descriptor:"
                                : $@"     Dummy Descriptor: '{value}'");
                        }
                    }
                    break;
                #endregion

                #region Established Timings III Descriptor
                case EdidDataBlockDescriptor.EstablishedTimingsIII:
                    var revision = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.EstablishedTimingsIII.Revision);
                    if (revision.Success)
                    {
                        var resolutions = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.EstablishedTimingsIII.Resolutions);
                        if (resolutions != null)
                        {
                        }
                    }
                    break;
                #endregion

                #region Manufacturer Specified Data Descriptor
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData00:
                    var manufacturerSpecifiedData = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.ManufacturerSpecifiedData.Data);
                    if (manufacturerSpecifiedData.Success)
                    {
                        var value = manufacturerSpecifiedData.Result.Value;
                        var valueArray = ((ReadOnlyCollection<byte>)value).ToArray();
                        logger.Info($@"     Manufacturer-Specified Display Descriptor (0x{valueArray[03]:X2}): {string.Join(" ", valueArray.AsHexadecimal())} '{valueArray.ToPrintableString()}'");
                    }
                    break;
                #endregion

                #region Reserved Descriptor
                case EdidDataBlockDescriptor.Reserved:
                    logger.Info($@"     Reserved Descriptor:");
                    break;
                #endregion

                #region Standard Timing Identifier Descriptor
                case EdidDataBlockDescriptor.StandardTimingIdentifier:
                    var timing9 = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing9);
                    var timing10 = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing10);
                    var timing11 = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing11);
                    var timing12 = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing12);
                    var timing13 = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing13);
                    var timing14 = data.GetProperty(EedidProperty.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing14);
                    var hasTimings = timing9.Success && timing10.Success && timing11.Success && timing12.Success && timing13.Success && timing14.Success;

                    var timing9Value = (StandardTimingIdentifierDescriptorItem)timing9.Result.Value;
                    var timing10Value = (StandardTimingIdentifierDescriptorItem)timing10.Result.Value;
                    var timing11Value = (StandardTimingIdentifierDescriptorItem)timing11.Result.Value;
                    var timing12Value = (StandardTimingIdentifierDescriptorItem)timing12.Result.Value;
                    var timing13Value = (StandardTimingIdentifierDescriptorItem)timing13.Result.Value;
                    var timing14Value = (StandardTimingIdentifierDescriptorItem)timing14.Result.Value;
                    var hasTimmingValues = timing9Value != null || timing10Value != null || timing11Value != null || timing12Value != null || timing13Value != null || timing14Value != null;

                    if (!hasTimings || !hasTimmingValues)
                    {
                        logger.Info(@"   Standard Timing Identifier Descriptor: none");
                    }
                    else
                    {
                        logger.Info(@"   Standard Timing Identifier Descriptor:");
                        PrintsStandardTimming(timing9Value, logger);
                        PrintsStandardTimming(timing10Value, logger);
                        PrintsStandardTimming(timing11Value, logger);
                        PrintsStandardTimming(timing12Value, logger);
                        PrintsStandardTimming(timing13Value, logger);
                        PrintsStandardTimming(timing14Value, logger);
                    }
                    break;
                #endregion
            }
        }
    }
}

