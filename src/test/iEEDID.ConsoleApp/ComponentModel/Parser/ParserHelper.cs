
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
        public static void PrintsBlock(ILogger logger, DataBlock block)
        {
            switch (block.Key)
            {
                case KnownDataBlock.EDID:
                    PrintsDescriptors(logger, block);
                    PrintsEdidBlock(logger, block);
                    break;

                case KnownDataBlock.CEA:
                    PrintsCeaBlock(logger, block);
                    break;
            }

        }

        public static void PrintsRawData(ILogger logger, IEnumerable<byte> data)
        {
            logger.Info("");
            logger.Info($@" edid-decode (hex)");
            logger.Info($@" ┌{new string('─', 48)}");

            var offset = 0;
            var instanceRawData = data.AsHexadecimal();
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
        }


        private static void PrintsCeaBlock(ILogger logger, DataBlock block)
        {
            #region Init Block
            logger.Info($@" Block 1, {block.Key.GetPropertyDescription()}:");
            logger.Info($@" ┌{new string('─', 48)}");
            #endregion

            #region Information Section
            var informationSection = block.Sections[(int)KnownCeaSection.Information];
            var revisionInformation = informationSection.GetProperty(EedidProperty.Cea.Information.Revision);
            logger.Info($@" │ Revision: {revisionInformation.Result.Value}");
            #endregion

            #region CheckSum Section
            var checksumSection = block.Sections[(int)KnownCeaSection.CheckSum];
            var status = checksumSection.GetProperty(EedidProperty.Cea.CheckSum.Ok);
            var value = checksumSection.GetProperty(EedidProperty.Cea.CheckSum.Value);
            logger.Info($@" │ Checksum: 0x{value.Result.Value:x2} ({((bool)status.Result.Value ? "Valid" : "Invalid")})");
            #endregion

            #region End Block
            logger.Info("");
            #endregion
        }

        private static void PrintsDescriptors(ILogger logger, DataBlock dataBlock)
        {
            logger.Info("");
            logger.Info($@" Extracted contents:");
            logger.Info($@" ┌{new string('─', 48)}");

            DataSection headerSection = dataBlock.Sections[(int)KnownEdidSection.Header];
            logger.Info($@" │ Header:{'\t'}{'\t'}{string.Join(" ", headerSection.RawData.AsHexadecimal())}");

            DataSection vendorSection = dataBlock.Sections[(int)KnownEdidSection.Vendor];
            QueryPropertyResult serialNumberResult = vendorSection.GetProperty(EedidProperty.Edid.Vendor.IdSerialNumber);
            if (serialNumberResult.Success)
            {
                logger.Info($@" │ Serial number:{'\t'}{serialNumberResult.Result.Value}");
            }
            else
            {
                logger.Info($@" │ Serial number:{'\t'}...");
            }

            DataSection versionSection = dataBlock.Sections[(int)KnownEdidSection.Version];
            logger.Info($@" │ Version:{'\t'}{'\t'}{string.Join(" ", versionSection.RawData.AsHexadecimal())}");

            DataSection basicDisplaySection = dataBlock.Sections[(int)KnownEdidSection.BasicDisplay];
            logger.Info($@" │ Basic params:{'\t'}{string.Join(" ", basicDisplaySection.RawData.AsHexadecimal())}");

            DataSection colorCharacteristicsTimingsSection = dataBlock.Sections[(int)KnownEdidSection.ColorCharacteristics];
            logger.Info($@" │ Chroma info:{'\t'}{'\t'}{string.Join(" ", colorCharacteristicsTimingsSection.RawData.AsHexadecimal())}");

            DataSection establishedTimingsSection = dataBlock.Sections[(int)KnownEdidSection.EstablishedTimings];
            logger.Info($@" │ Established:{'\t'}{'\t'}{string.Join(" ", establishedTimingsSection.RawData.AsHexadecimal())}");

            DataSection standardTimingsSection = dataBlock.Sections[(int)KnownEdidSection.StandardTimings];
            logger.Info($@" │ Standard:{'\t'}{'\t'}{string.Join(" ", standardTimingsSection.RawData.AsHexadecimal())}");

            DataSection dataBlocksSection = dataBlock.Sections[(int)KnownEdidSection.DataBlocks];
            logger.Info($@" │ Descriptor 1:{'\t'}{string.Join(" ", ((ReadOnlyCollection<byte>)dataBlocksSection.GetProperty(EedidProperty.Edid.DataBlock.Descriptor1).Result.Value).AsHexadecimal())}");
            logger.Info($@" │ Descriptor 2:{'\t'}{string.Join(" ", ((ReadOnlyCollection<byte>)dataBlocksSection.GetProperty(EedidProperty.Edid.DataBlock.Descriptor2).Result.Value).AsHexadecimal())}");
            logger.Info($@" │ Descriptor 3:{'\t'}{string.Join(" ", ((ReadOnlyCollection<byte>)dataBlocksSection.GetProperty(EedidProperty.Edid.DataBlock.Descriptor3).Result.Value).AsHexadecimal())}");
            logger.Info($@" │ Descriptor 4:{'\t'}{string.Join(" ", ((ReadOnlyCollection<byte>)dataBlocksSection.GetProperty(EedidProperty.Edid.DataBlock.Descriptor4).Result.Value).AsHexadecimal())}");

            DataSection extensionSection = dataBlock.Sections[(int)KnownEdidSection.ExtensionBlocks];
            logger.Info($@" │ Extensions:{'\t'}{'\t'}{string.Join(" ", extensionSection.RawData.AsHexadecimal())}");

            DataSection checksumSection = dataBlock.Sections[(int)KnownEdidSection.CheckSum];
            logger.Info($@" │ Checksum:{'\t'}{'\t'}{string.Join(" ", checksumSection.RawData.AsHexadecimal())}");

            logger.Info("");
        }

        private static void PrintsEdidBlock(ILogger logger, DataBlock block)
        {
            #region Init Block
            logger.Info("");
            logger.Info($@" Block 0, Base {block.Key}:");
            logger.Info($@" ┌{new string('─', 48)}");
            #endregion

            #region Version Section
            var versionSection = block.Sections[(int)KnownEdidSection.Version];
            var version = versionSection.GetProperty(EedidProperty.Edid.Version.Number);
            var revision = versionSection.GetProperty(EedidProperty.Edid.Version.Revision);
            logger.Info($@" │ EDID Structure Version & Revision: {version.Result.Value}.{revision.Result.Value}");
            #endregion

            #region Vendor Section
            var vendorSection = block.Sections[(int)KnownEdidSection.Vendor];
            logger.Info($@" │ Vendor & Product Identification:");
            var manufacturer = vendorSection.GetProperty(EedidProperty.Edid.Vendor.IdManufacturerName);
            if(manufacturer.Success)
            {
                logger.Info($@" │   Manufacturer: {manufacturer.Result.Value}");
            }

            var model = vendorSection.GetProperty(EedidProperty.Edid.Vendor.IdProductCode);
            if (model.Success)
            {
                logger.Info($@" │   Model: {model.Result.Value}");
            }

            var serialNumber = vendorSection.GetProperty(EedidProperty.Edid.Vendor.IdSerialNumber);
            if (serialNumber.Success)
            {
                logger.Info($@" │   Serial Number: {serialNumber.Result.Value}");
            }

            var manufactureDate = vendorSection.GetProperty(EedidProperty.Edid.Vendor.ManufactureDate);
            if (model.Success)
            {
                logger.Info($@" │   Made in: {manufactureDate.Result.Value}");
            }
            #endregion

            #region Basic Display Section
            var basicDisplaySection = block.Sections[(int)KnownEdidSection.BasicDisplay];
            logger.Info($@" │ Basic Display Parameters & Features:");

            bool isDigital = true;
            var videoInputDefinition = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.VideoInputDefinition);
            if (videoInputDefinition.Success)
            {
                isDigital = videoInputDefinition.Result.Value.ToString().Equals("Digital", System.StringComparison.OrdinalIgnoreCase);
                logger.Info($@" │   {videoInputDefinition.Result.Value} display");
            }

            if (!isDigital)
            {
                var signalLevel = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Analog.SignalLevelStandard);
                if (signalLevel.Success)
                {
                    logger.Info($@" │   Input voltage level: {signalLevel.Result.Value}");
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
                    
                logger.Info($@" │   Sync: {syncBuilder}");
            }

            var horizontalScreenSizeUnits = EedidProperty.Edid.BasicDisplay.HorizontalScreenSize.PropertyUnit;
            var horizontalScreenSize = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.HorizontalScreenSize);
            var verticalScreenSizeUnits = EedidProperty.Edid.BasicDisplay.VerticalScreenSize.PropertyUnit;
            var verticalScreenSize = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.VerticalScreenSize);
            if (horizontalScreenSize.Success && verticalScreenSize.Success)
            {
                logger.Info($@" │   Maximum image size: {horizontalScreenSize.Result.Value} {horizontalScreenSizeUnits} x {verticalScreenSize.Result.Value} {verticalScreenSizeUnits}");
            }

            var gamma = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Gamma);
            if (gamma.Success)
            {
                logger.Info($@" │   Gamma: {gamma.Result.Value:n2}");
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

            var dpmsLevelsIsOff = lowPowerValue == false && standbyModeValue == false && suspendModeValue == false;
            if (dpmsLevelsIsOff)
            {
                logger.Info($@" │   DPMS levels : Off");
            }
            else
            {
                if (!suspendModeValue)
                {
                    logger.Info($@" │   DPMS levels : Standby Suspend Off");
                }
                else if(!standbyModeValue)
                {
                    logger.Info($@" │   DPMS levels : Standby Off");
                }
            }

            var displayColorType = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Analog.DisplayColorType);
            if (displayColorType.Success)
            {
                logger.Info($@" │   {displayColorType.Result.Value}");
            }

            var isSrgbDefaultColorSpace = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Features.Other.IsSrgbDefaultColorSpace);
            if (isSrgbDefaultColorSpace.Success)
            {
                var isSrgbDefaultColorSpaceValue = (bool)isSrgbDefaultColorSpace.Result.Value;
                if (isSrgbDefaultColorSpaceValue)
                {
                    logger.Info($@" │   Default (sRGB) color space is primary color space");
                }
            }

            var includePreferredTimingMode = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Features.Other.IncludePreferredTimingMode);
            if (includePreferredTimingMode.Success)
            {
                var includePreferredTimingModeValue = (bool)includePreferredTimingMode.Result.Value;
                if (includePreferredTimingModeValue)
                {
                    logger.Info($@" │   First detailed timing is the preferred timing");
                }
            }
            #endregion

            #region Color Characteristics Section
            var colorSection = block.Sections[(int)KnownEdidSection.ColorCharacteristics];
            logger.Info($@" │ Color Characteristics:");

            var red = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Red);
            if (red.Success)
            {
                logger.Info($@" │   Red  : {((PointF)red.Result.Value).X:n4} {((PointF)red.Result.Value).Y:n4}");
            }

            var green = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Green);
            if (green.Success)
            {
                logger.Info($@" │   Green: {((PointF)green.Result.Value).X:n4} {((PointF)green.Result.Value).Y:n4}");
            }

            var blue = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Blue);
            if (blue.Success)
            {
                logger.Info($@" │   Blue : {((PointF)blue.Result.Value).X:n4} {((PointF)blue.Result.Value).Y:n4}");
            }

            var white = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.White);
            if (blue.Success)
            {
                logger.Info($@" │   White: {((PointF)white.Result.Value).X:n4} {((PointF)white.Result.Value).Y:n4}");
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
                    logger.Info($@" │ Established Timings I & II:");
                    foreach (var monitorResolution in monitorReslutions)
                    {
                        var resolution = $@"{monitorResolution.Size.Width}x{monitorResolution.Size.Height}";
                        logger.Info($@" │   {resolution,9}{'\t'}{monitorResolution.Frequency} Hz{'\t'}{monitorResolution.ApectRatio}");
                    }
                }
                else
                {
                    logger.Info($@" │ Established Timings I & II: none");
                }
            }
            else
            {
                logger.Info($@" │ Established Timings I & II: none");
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
            var hasValidTimings = 
                timing1.Success == true && timing2.Success == true && timing3.Success == true && timing4.Success == true && 
                timing5.Success == true && timing6.Success == true && timing7.Success == true && timing8.Success == true;
            if (!hasValidTimings)
            {
                logger.Info($@" │ Standard Timings: none");
            }
            else
            {
                var timings = new Collection<StandardTimingIdentifierDescriptorItem>();
                if(timing1.Result.Value != null)
                {
                    timings.Add((StandardTimingIdentifierDescriptorItem)timing1.Result.Value);
                }

                if (timing2.Result.Value != null)
                {
                    timings.Add((StandardTimingIdentifierDescriptorItem)timing2.Result.Value);
                }

                if (timing3.Result.Value != null)
                {
                    timings.Add((StandardTimingIdentifierDescriptorItem)timing3.Result.Value);
                }

                if (timing4.Result.Value != null)
                {
                    timings.Add((StandardTimingIdentifierDescriptorItem)timing4.Result.Value);
                }

                if (timing5.Result.Value != null)
                {
                    timings.Add((StandardTimingIdentifierDescriptorItem)timing5.Result.Value);
                }

                if (timing6.Result.Value != null)
                {
                    timings.Add((StandardTimingIdentifierDescriptorItem)timing6.Result.Value);
                }

                if (timing7.Result.Value != null)
                {
                    timings.Add((StandardTimingIdentifierDescriptorItem)timing7.Result.Value);
                }

                if (timing8.Result.Value != null)
                {
                    timings.Add((StandardTimingIdentifierDescriptorItem)timing8.Result.Value);
                }

                var hasTimingValues = timings.Any();
                if (!hasTimingValues)
                {
                    logger.Info($@" │ Standard Timings: none");
                }
                else
                {
                    logger.Info($@" │ Standard Timings:");
                    foreach (var timing in timings)
                    {
                        var resolution1 = $@"{timing.HorizontalPixels}x{timing.VerticalPixels}";
                        logger.Info($@" │   {resolution1,9}{'\t'}{timing.RefreshRate} Hz{'\t'}{timing.AspectRatio}");
                    }
                }
            }
            #endregion

            #region Detailed Timing Descriptors
            logger.Info($@" │ Detailed Timing Descriptors:");
            var dataBlocksSection = block.Sections[(int)KnownEdidSection.DataBlocks];
            foreach (var dataBlockProperty in dataBlocksSection.ImplementedProperties)
            {
                var dataBlockPropertyIdentifier = dataBlockProperty.PropertyId;
                switch (dataBlockPropertyIdentifier)
                {
                    case EdidDataBlockDescriptor.AlphaNumericDataString:
                        var alphanumericData = dataBlocksSection.GetProperty(dataBlockProperty);
                        var alphanumericDataProperties = (SectionPropertiesTable)alphanumericData.Result.Value;
                        var alphanumericDataValue = (List<PropertyItem>)alphanumericDataProperties[EedidProperty.Edid.DataBlock.Definition.AlphanumericDataString.Data];
                        logger.Info($@" │   Alphanumeric Data String: '{alphanumericDataValue.FirstOrDefault().Value.ToString().Trim()}'");
                        break;

                    case EdidDataBlockDescriptor.ColorManagementData:
                        break;

                    case EdidDataBlockDescriptor.ColorPointData:
                        break;

                    case EdidDataBlockDescriptor.Cvt3ByteCode:
                        break;

                    case EdidDataBlockDescriptor.DetailedTimingMode:
                        var detailedTimingMode = dataBlocksSection.GetProperty(dataBlockProperty);
                        var detailedTimingModeProperties = (SectionPropertiesTable)detailedTimingMode.Result.Value;
                        var horResolutionValue = (List<PropertyItem>)detailedTimingModeProperties[EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalResolution];
                        var vertResolutionValue = (List<PropertyItem>)detailedTimingModeProperties[EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalLines];
                        var vertImageSizeValue = (List<PropertyItem>)detailedTimingModeProperties[EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalImageSize];
                        var horImageSizeValue = (List<PropertyItem>)detailedTimingModeProperties[EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalImageSize];
                        //var horImageSizeValue = (List<PropertyItem>)detailedTimingModeProperties[EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode];
                        var pixelClockValue = (List<PropertyItem>)detailedTimingModeProperties[EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.PixelClock];
                        
                        var horizontalFrontPorchValue = (List<PropertyItem>)detailedTimingModeProperties[EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalFrontPorch];
                        var horizontalSyncPulseValue = (List<PropertyItem>)detailedTimingModeProperties[EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalSyncPulseWidth];
                        var verticalFrontPorchValue = (List<PropertyItem>)detailedTimingModeProperties[EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalFrontPorch];
                        var verticalSyncPulseValue = (List<PropertyItem>)detailedTimingModeProperties[EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalSyncPulseWidth];

                        var resolution = $@"{horResolutionValue.FirstOrDefault().Value}x{vertResolutionValue.FirstOrDefault().Value}";
                        logger.Info($@" │   DTD: {resolution,9}  60.020 Hz  5:4  63.981 kHz {(((int)pixelClockValue.FirstOrDefault().Value) / 1000):N0} MHz ({horImageSizeValue.FirstOrDefault().Value} mm x {vertImageSizeValue.FirstOrDefault().Value} mm)");
                        logger.Info($@" │             Hfront {horizontalFrontPorchValue.FirstOrDefault().Value} Hsync {horizontalSyncPulseValue.FirstOrDefault().Value} Hback ");
                        logger.Info($@" │             Vfront {verticalFrontPorchValue.FirstOrDefault().Value} Vsync {verticalSyncPulseValue.FirstOrDefault().Value} Vback");
                        break;

                    case EdidDataBlockDescriptor.DisplayProductName:
                        var displayProductName = dataBlocksSection.GetProperty(dataBlockProperty);
                        var displayProductNameProperties = (SectionPropertiesTable)displayProductName.Result.Value;
                        var displayProductNameValue = (List<PropertyItem>)displayProductNameProperties[EedidProperty.Edid.DataBlock.Definition.DisplayProductName.Data];
                        logger.Info($@" │   Display Product Name: '{displayProductNameValue.FirstOrDefault().Value.ToString().Trim()}'");
                        break;

                    case EdidDataBlockDescriptor.DisplayProductSerialNumber:
                        var productSerialNumber = dataBlocksSection.GetProperty(dataBlockProperty);
                        var productSerialNumberProperties = (SectionPropertiesTable)productSerialNumber.Result.Value;
                        var productSerialNumberValue = (List<PropertyItem>)productSerialNumberProperties[EedidProperty.Edid.DataBlock.Definition.DisplayProductSerialNumber.Data];
                        logger.Info($@" │   Display Product Serial Number: '{productSerialNumberValue.FirstOrDefault().Value.ToString().Trim()}'");
                        break;

                    case EdidDataBlockDescriptor.DummyData:
                        var dummyData = dataBlocksSection.GetProperty(dataBlockProperty);
                        var dummyDataProperties = (SectionPropertiesTable)dummyData.Result.Value;
                        var dummyValue = (List<PropertyItem>)dummyDataProperties[EedidProperty.Edid.DataBlock.Definition.DummyData.OriginalData];
                        logger.Info($@" │   Dummy Data: '{dummyValue.FirstOrDefault().Value.ToString().Trim()}'");
                        break;

                    case EdidDataBlockDescriptor.EstablishedTimingsIII:
                        break;

                    case EdidDataBlockDescriptor.ManufacturerSpecifiedData00:
                        var manufacturerData = dataBlocksSection.GetProperty(dataBlockProperty);
                        var manufacturerDataProperties = (SectionPropertiesTable)manufacturerData.Result.Value;
                        var manufacturerDataValue = (List<PropertyItem>)manufacturerDataProperties[EedidProperty.Edid.DataBlock.Definition.ManufacturerSpecifiedData.Data];
                        logger.Info($@" │   Manufacturer-Specified Display Descriptor: {string.Join(" ", ((ReadOnlyCollection<byte>)manufacturerDataValue.FirstOrDefault().Value).AsEnumerable().AsHexadecimal())}");
                        break;

                    case EdidDataBlockDescriptor.Reserved:
                        break;

                    case EdidDataBlockDescriptor.StandardTimingIdentifier:
                        break;
                }
            }
            #endregion

            #region Display Range Limits
            var hasDisplayRangeLimitsBlock = dataBlocksSection.ImplementedProperties.Contains(EedidProperty.Edid.DataBlock.Descriptor.DisplayRangeLimits);
            if (hasDisplayRangeLimitsBlock)
            {
                var displayRangeLimitsBlock = dataBlocksSection.GetProperty(EedidProperty.Edid.DataBlock.Descriptor.DisplayRangeLimits);
                var displayRangeLimitsBlockProperties = (SectionPropertiesTable)displayRangeLimitsBlock.Result.Value;
                var minVertRateValue = (List<PropertyItem>)displayRangeLimitsBlockProperties[EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MinimumVerticalRate];
                var maxVertRateValue = (List<PropertyItem>)displayRangeLimitsBlockProperties[EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MaximumVerticalRate];
                var minHortRateValue = (List<PropertyItem>)displayRangeLimitsBlockProperties[EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MinimumHorizontalRate];
                var maxHortRateValue = (List<PropertyItem>)displayRangeLimitsBlockProperties[EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MaximumHorizontalRate];
                var maxClockValue = (List<PropertyItem>)displayRangeLimitsBlockProperties[EedidProperty.Edid.DataBlock.Definition.DisplayRangeLimits.MaximumPixelClock];
                logger.Info($@" │ Display Range Limits:");
                logger.Info($@" │   Monitor ranges (GTF): {minVertRateValue.FirstOrDefault().Value}-{maxVertRateValue.FirstOrDefault().Value} Hz V, {minHortRateValue.FirstOrDefault().Value}-{maxHortRateValue.FirstOrDefault().Value} kHz H, max dotclock {maxClockValue.FirstOrDefault().Value} MHz");
            }
            #endregion

            #region Extension Blocks Section
            var extensionBlocksSection = block.Sections[(int)KnownEdidSection.ExtensionBlocks];
            var count = extensionBlocksSection.GetProperty(EedidProperty.Edid.ExtensionBlocks.Count);
            logger.Info($@" │ Extension blocks: {count.Result.Value}");
            #endregion

            #region CheckSum Section
            var checksumSection = block.Sections[(int)KnownEdidSection.CheckSum];
            var status = checksumSection.GetProperty(EedidProperty.Edid.CheckSum.Ok);
            var value = checksumSection.GetProperty(EedidProperty.Edid.CheckSum.Value);
            logger.Info($@" │ Checksum: 0x{value.Result.Value:x2} ({((bool)status.Result.Value ? "Valid" : "Invalid")})");
            #endregion

            #region End Block
            logger.Info("");
            #endregion
        }
    }
}
