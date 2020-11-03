
namespace iEEDID.ComponentModel.Parser
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;

    using iTin.Core.Hardware.Common;

    using iTin.Logging.ComponentModel;

    using iTin.Hardware.Specification;
    using iTin.Hardware.Specification.Eedid;
    using System.Linq;

    /// <summary>
    /// Specialization of the <see cref="IParser"/> interface.<br/>
    /// Defines a custom parser for <see cref="EEDID"/> instances.
    /// </summary> 
    internal class TechParser : IParser
    {
        /// <summary>
        /// Gets or sets the logger to use
        /// </summary>
        /// <value>
        /// A <see cref="ILogger"/> reference.
        /// </value>
        public ILogger Logger { get; set; }

        /// <summary>
        /// Parse the <see cref="EEDID"/> given.
        /// </summary>
        /// <param name="instance"><see cref="EEDID"/> instance to parse.</param>
        public void Parse(EEDID instance)
        {
            Logger.Info("");
            Logger.Info($@" edid-decode (hex)");
            Logger.Info($@" ┌────────────────────────────────────────────────");

            DataBlockCollection blocks = instance.Blocks;
            foreach (DataBlock block in blocks)
            {
                var offset = 0;
                var rawData = block.RawData.Select(item => $"{item:x2}");
                for (int i = 0; i <= (rawData.Count() - 1) / 16; i++)
                {
                    var piece = rawData.Skip(offset);
                    var line = piece.Take(16);
                    Logger.Info($@" │ {string.Join(' ', line)}");
                    offset += 16;
                }

                Logger.Info("");
                Logger.Info($@" ────────────────");
                Logger.Info("");
                switch(block.Key)
                {
                    case KnownDataBlock.EDID:
                        Logger.Info($@" Block 0, Base {block.Key}:");

                        var versionSection = block.Sections[(int)KnownEdidSection.Version];
                        var version = versionSection.GetProperty(EedidProperty.Edid.Version.Number);
                        var revision = versionSection.GetProperty(EedidProperty.Edid.Version.Revision);
                        Logger.Info($@"   EDID Structure Version & Revision: {version.Value.Value}.{revision.Value.Value}");

                        var vendorSection = block.Sections[(int)KnownEdidSection.Vendor];
                        var manufacturer = vendorSection.GetProperty(EedidProperty.Edid.Vendor.IdManufacturerName);
                        var model = vendorSection.GetProperty(EedidProperty.Edid.Vendor.IdProductCode);
                        var serialNumber = vendorSection.GetProperty(EedidProperty.Edid.Vendor.IdSerialNumber);
                        var manufactureDate = vendorSection.GetProperty(EedidProperty.Edid.Vendor.ManufactureDate);
                        Logger.Info($@"   Vendor & Product Identification:");
                        Logger.Info($@"     Manufacturer: {manufacturer.Value.Value}");
                        Logger.Info($@"     Model: {model.Value.Value}");
                        Logger.Info($@"     SerialNumber: {serialNumber.Value.Value}");
                        Logger.Info($@"     Made in: {manufactureDate.Value.Value}");

                        var basicDisplaySection = block.Sections[(int)KnownEdidSection.BasicDisplay];
                        //var manufacturer = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.IdManufacturerName);
                        //var model = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.IdProductCode);
                        //var serialNumber = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.IdSerialNumber);
                        //var manufactureDate = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.ManufactureDate);
                        Logger.Info($@"   Basic Display Parameters & Features:");
                        Logger.Info($@"");

                        var colorSection = block.Sections[(int)KnownEdidSection.ColorCharacteristics];
                        var red = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Red);
                        var green = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Green);
                        var blue = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Blue);
                        var white = colorSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.White);
                        Logger.Info($@"   Color Characteristics:");
                        Logger.Info($@"     Red  : {((PointF)red.Value.Value).X:n4} {((PointF)red.Value.Value).Y:n4}");
                        Logger.Info($@"     Green: {((PointF)green.Value.Value).X:n4} {((PointF)green.Value.Value).Y:n4}");
                        Logger.Info($@"     Blue : {((PointF)blue.Value.Value).X:n4} {((PointF)blue.Value.Value).Y:n4}");
                        Logger.Info($@"     White: {((PointF)white.Value.Value).X:n4} {((PointF)white.Value.Value).Y:n4}");

                        var establishedTimingsSection = block.Sections[(int)KnownEdidSection.EstablishedTimings];
                        var resolutions = establishedTimingsSection.GetProperty(EedidProperty.Edid.EstablishedTimings.Resolutions);
                        var monitorReslutions = (ReadOnlyCollection<MonitorResolutionInfo>)resolutions.Value.Value;
                        Logger.Info($@"   Established Timings I & II:");
                        foreach(var monitorResolution in monitorReslutions)
                        {
                            Logger.Info($@"     {monitorResolution}");
                        }

                        var standardTimingsSection = block.Sections[(int)KnownEdidSection.StandardTimings];
                        //var red = standardTimingsSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Red);
                        //var green = standardTimingsSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Green);
                        //var blue = standardTimingsSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.Blue);
                        //var white = standardTimingsSection.GetProperty(EedidProperty.Edid.ColorCharacteristics.White);
                        Logger.Info($@"   Standard Timings:");
                        Logger.Info($@"");

                        Logger.Info($@"   Detailed Timing Descriptors:");
                        var dataBlocksSection = block.Sections[(int)KnownEdidSection.DataBlocks];
                        foreach(var dataBlockProperty in dataBlocksSection.ImplementedProperties)
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
                                    Logger.Info($@"     Display Product Name: {displayProductNameValue.FirstOrDefault().Value.ToString().Trim('\n')}");
                                    break;

                                case EdidDataBlockDescriptor.DisplayProductSerialNumber:
                                    var productSerialNumber = dataBlocksSection.GetProperty(dataBlockProperty);
                                    Logger.Info($@"     Display Product Serial Number: {productSerialNumber.Value.Value}");
                                    break;

                                case EdidDataBlockDescriptor.DisplayRangeLimits:
                                    break;

                                case EdidDataBlockDescriptor.DummyData:
                                    var dummyData = dataBlocksSection.GetProperty(dataBlockProperty);
                                    var dummyDataProperties = (SectionPropertiesTable)dummyData.Value.Value;
                                    var dummyValue = (List<PropertyItem>) dummyDataProperties[EedidProperty.Edid.DataBlock.Definition.DummyData.OriginalData];
                                    Logger.Info($@"     Dummy Data: {dummyValue.FirstOrDefault().Value.ToString().Trim('\n')}");
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
                        Logger.Info($@"   Extension blocks: {count.Value.Value}");

                        var checksumSection = block.Sections[(int)KnownEdidSection.CheckSum];
                        var status = checksumSection.GetProperty(EedidProperty.Edid.CheckSum.Ok);
                        var value = checksumSection.GetProperty(EedidProperty.Edid.CheckSum.Value);
                        Logger.Info($@" Checksum: {value.Value.Value:x2} ({((bool)status.Value.Value ? "Valid" : "Invalid")})");

                        Logger.Info("");
                        Logger.Info($@" ────────────────");
                        Logger.Info("");

                        break;
                }
            }
        }
    }
}