
namespace iEEDID.ComponentModel.Parser
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;
    using System.Linq;

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
            logger.Info($@" ┌────────────────────────────────────────────────");

            var offset = 0;
            var instanceRawData = data.AsHexadecimal();
            var totalBytes = instanceRawData.Count();
            for (int i = 0; i <= (totalBytes - 1) / 16; i++)
            {
                var piece = instanceRawData.Skip(offset);
                var line = piece.Take(16);

                logger.Info($@" │ {string.Join(' ', line)}");

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
            logger.Info($@" ────────────────");
            logger.Info("");
        }

        public static void PrintsBlock(ILogger logger, DataBlock block)
        {
            switch (block.Key)
            {
                case KnownDataBlock.EDID:
                    PrintsEdidBlock(logger, block);
                    break;

                case KnownDataBlock.CEA:
                    PrintsCeaBlock(logger, block);
                    break;
            }

        }


        private static void PrintsCeaBlock(ILogger logger, DataBlock block)
        {
            logger.Info($@" Block 1, {block.Key.GetPropertyDescription()}:");

            var informationSection = block.Sections[(int)KnownCeaSection.Information];
            var revisionInformation = informationSection.GetProperty(EedidProperty.Cea.Information.Revision);
            logger.Info($@"   Revision: {revisionInformation.Value.Value}");
        }

        private static void PrintsEdidBlock(ILogger logger, DataBlock block)
        {
            logger.Info($@" Block 0, Base {block.Key}:");

            var versionSection = block.Sections[(int)KnownEdidSection.Version];
            var version = versionSection.GetProperty(EedidProperty.Edid.Version.Number);
            var revision = versionSection.GetProperty(EedidProperty.Edid.Version.Revision);
            logger.Info($@"   EDID Structure Version & Revision: {version.Value.Value}.{revision.Value.Value}");

            var vendorSection = block.Sections[(int)KnownEdidSection.Vendor];
            var manufacturer = vendorSection.GetProperty(EedidProperty.Edid.Vendor.IdManufacturerName);
            var model = vendorSection.GetProperty(EedidProperty.Edid.Vendor.IdProductCode);
            var serialNumber = vendorSection.GetProperty(EedidProperty.Edid.Vendor.IdSerialNumber);
            var manufactureDate = vendorSection.GetProperty(EedidProperty.Edid.Vendor.ManufactureDate);
            logger.Info($@"   Vendor & Product Identification:");
            logger.Info($@"     Manufacturer: {manufacturer.Value.Value}");
            logger.Info($@"     Model: {model.Value.Value}");
            logger.Info($@"     SerialNumber: {serialNumber.Value.Value}");
            logger.Info($@"     Made in: {manufactureDate.Value.Value}");

            var basicDisplaySection = block.Sections[(int)KnownEdidSection.BasicDisplay];
            //var manufacturer = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.IdManufacturerName);
            //var model = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.IdProductCode);
            //var serialNumber = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.IdSerialNumber);
            //var manufactureDate = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.ManufactureDate);
            logger.Info($@"   Basic Display Parameters & Features:");
            logger.Info($@"");

            var colorSection = block.Sections[(int)KnownEdidSection.ColorCharacteristics];
            var red = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Red);
            var green = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Green);
            var blue = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Blue);
            var white = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.White);
            logger.Info($@"   Color Characteristics:");
            logger.Info($@"     Red  : {((PointF)red.Value.Value).X:n4} {((PointF)red.Value.Value).Y:n4}");
            logger.Info($@"     Green: {((PointF)green.Value.Value).X:n4} {((PointF)green.Value.Value).Y:n4}");
            logger.Info($@"     Blue : {((PointF)blue.Value.Value).X:n4} {((PointF)blue.Value.Value).Y:n4}");
            logger.Info($@"     White: {((PointF)white.Value.Value).X:n4} {((PointF)white.Value.Value).Y:n4}");

            var establishedTimingsSection = block.Sections[(int)KnownEdidSection.EstablishedTimings];
            var resolutions = establishedTimingsSection.GetProperty(EedidProperty.Edid.EstablishedTimings.Resolutions);
            var monitorReslutions = (ReadOnlyCollection<MonitorResolutionInfo>)resolutions.Value.Value;
            logger.Info($@"   Established Timings I & II:");
            foreach (var monitorResolution in monitorReslutions)
            {
                logger.Info($@"     {monitorResolution}");
            }

            var standardTimingsSection = block.Sections[(int)KnownEdidSection.StandardTimings];
            //var red = standardTimingsSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Red);
            //var green = standardTimingsSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Green);
            //var blue = standardTimingsSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Blue);
            //var white = standardTimingsSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.White);
            logger.Info($@"   Standard Timings:");
            logger.Info($@"");

            logger.Info($@"   Detailed Timing Descriptors:");
            var dataBlocksSection = block.Sections[(int)KnownEdidSection.DataBlocks];
            foreach (var dataBlockProperty in dataBlocksSection.ImplementedProperties)
            {
                var dataBlockPropertyIdentifier = dataBlockProperty.PropertyId;
                switch (dataBlockPropertyIdentifier)
                {
                    case EdidDataBlockDescriptor.AlphaNumericDataString:
                        break;

                    case EdidDataBlockDescriptor.ColorManagementData:
                        break;

                    case EdidDataBlockDescriptor.ColorPointData:
                        break;

                    case EdidDataBlockDescriptor.Cvt3ByteCode:
                        break;

                    case EdidDataBlockDescriptor.DetailedTimingMode:
                        break;

                    case EdidDataBlockDescriptor.DisplayProductName:
                        var displayProductName = dataBlocksSection.GetProperty(dataBlockProperty);
                        var displayProductNameProperties = (SectionPropertiesTable)displayProductName.Value.Value;
                        var displayProductNameValue = (List<PropertyItem>)displayProductNameProperties[EedidProperty.Edid.DataBlock.Definition.DisplayProductName.Data];
                        logger.Info($@"     Display Product Name: {displayProductNameValue.FirstOrDefault().Value.ToString().Trim('\n')}");
                        break;

                    case EdidDataBlockDescriptor.DisplayProductSerialNumber:
                        var productSerialNumber = dataBlocksSection.GetProperty(dataBlockProperty);
                        logger.Info($@"     Display Product Serial Number: {productSerialNumber.Value.Value}");
                        break;

                    case EdidDataBlockDescriptor.DisplayRangeLimits:
                        break;

                    case EdidDataBlockDescriptor.DummyData:
                        var dummyData = dataBlocksSection.GetProperty(dataBlockProperty);
                        var dummyDataProperties = (SectionPropertiesTable)dummyData.Value.Value;
                        var dummyValue = (List<PropertyItem>)dummyDataProperties[EedidProperty.Edid.DataBlock.Definition.DummyData.OriginalData];
                        logger.Info($@"     Dummy Data: {dummyValue.FirstOrDefault().Value.ToString().Trim('\n')}");
                        break;

                    case EdidDataBlockDescriptor.EstablishedTimingsIII:
                        break;

                    case EdidDataBlockDescriptor.ManufacturerSpecifiedData:
                        break;

                    case EdidDataBlockDescriptor.Reserved:
                        break;

                    case EdidDataBlockDescriptor.StandardTimingIdentifier:
                        break;
                }
            }

            var extensionBlocksSection = block.Sections[(int)KnownEdidSection.ExtensionBlocks];
            var count = extensionBlocksSection.GetProperty(EedidProperty.Edid.ExtensionBlocks.Count);
            logger.Info($@"   Extension blocks: {count.Value.Value}");

            var checksumSection = block.Sections[(int)KnownEdidSection.CheckSum];
            var status = checksumSection.GetProperty(EedidProperty.Edid.CheckSum.Ok);
            var value = checksumSection.GetProperty(EedidProperty.Edid.CheckSum.Value);
            logger.Info($@" Checksum: {value.Value.Value:x2} ({((bool)status.Value.Value ? "Valid" : "Invalid")})");

            logger.Info("");
            logger.Info($@" ────────────────");
            logger.Info("");
        }
    }
}
