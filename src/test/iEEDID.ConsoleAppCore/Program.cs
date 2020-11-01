
namespace iEEDID.ConsoleAppCore
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;

    using iTin.Core.Hardware.Common;

    using iTin.Hardware.Specification;
    using iTin.Hardware.Specification.Eedid;

    class Program
    {
        static void Main(string[] args)
        {
            EEDID[] instances = EEDID.Instance;
            foreach(var eedid in instances)
            {
                Console.WriteLine();
                Console.WriteLine(@" Implemented Blocks");
                Console.WriteLine(@" ══════════════════");

                DataBlockCollection blocks = eedid.Blocks;
                foreach (KnownDataBlock block in blocks.ImplementedBlocks)
                {
                    Console.WriteLine($@" │ {block}");
                }

                foreach (DataBlock block in blocks)
                {
                    Console.WriteLine();
                    var blockLiteral = $@"{block.Key} Block";
                    Console.WriteLine($@" {blockLiteral}");
                    Console.WriteLine($@" {new string('═', blockLiteral.Length)}");

                    var implSections = eedid.Blocks[block.Key].Sections.ImplementedSections;
                    Console.WriteLine();
                    Console.WriteLine(@" Implemented Sections");
                    Console.WriteLine(@" ┌───────────────────");
                    foreach (Enum section in implSections)
                    {
                        Console.WriteLine($@" │ {GetFriendlyName(section)}");
                    }

                    Console.WriteLine();
                    Console.WriteLine(@" Sections");
                    Console.WriteLine(@" ┌───────");
                    BaseDataSectionCollection sections = block.Sections;
                    foreach (DataSection section in sections)
                    {
                        var literal = $"{GetFriendlyName(section.Key) } Section";
                        Console.WriteLine(@" │");
                        Console.WriteLine($@" ├ {GetFriendlyName(section.Key)} Section");
                        Console.WriteLine($" │ ┌{new string('─', literal.Length - 1)}");

                        IEnumerable<IPropertyKey> properties = section.ImplementedProperties;
                        foreach (IPropertyKey property in properties)
                        {
                            QueryPropertyResult queryResult = section.GetProperty(property);
                            PropertyItem propertyItem = queryResult.Value;
                            object value = propertyItem.Value;
                            PropertyUnit valueUnit = property.PropertyUnit;
                            string friendlyName = property.GetPropertyName();
                            string unit = valueUnit == PropertyUnit.None ? string.Empty : valueUnit.ToString();

                            if (value == null)
                            {
                                Console.WriteLine($@" │ │ {friendlyName}: NULL");
                                continue;
                            }

                            if (value is string)
                            {
                                Console.WriteLine($@" │ │ {friendlyName}: {value}{unit}");
                            }
                            else if (value is bool)
                            {
                                Console.WriteLine($@" │ │ {friendlyName}: {value}{unit}");
                            }
                            else if (value is double)
                            {
                                Console.WriteLine($@" │ │ {friendlyName}: {value}{unit}");
                            }
                            else if (value is byte)
                            {
                                Console.WriteLine($@" │ │ {friendlyName}: {value}{unit} [{value:X2}h]");
                            }
                            else if (value is short)
                            {
                                Console.WriteLine($@" │ │ {friendlyName}: {value}{unit} [{value:X4}h]");
                            }
                            else if (value is ushort)
                            {
                                Console.WriteLine($@" │ │ {friendlyName}: {value}{unit} [{value:X4}h]");
                            }
                            else if (value is int)
                            {
                                Console.WriteLine($@" │ │ {friendlyName}: {value}{unit} [{value:X4}h]");
                            }
                            else if (value is uint)
                            {
                                Console.WriteLine($@" │ │ {friendlyName}: {value}{unit} [{value:X4}h]");
                            }
                            else if (value is long)
                            {
                                Console.WriteLine($@" │ │ {friendlyName}: {value}{unit} [{value:X8}h]");
                            }
                            else if (value is ulong)
                            {
                                Console.WriteLine($@" │ │ {friendlyName}: {value}{unit} [{value:X8}h]");
                            }
                            else if (value is PointF)
                            {
                                var pointLiteral = $"{ friendlyName }";
                                Console.WriteLine($@" │ │ {pointLiteral}");
                                Console.WriteLine($@" │ │ ┌{new string('─', pointLiteral.Length - 1)}");
                                Console.WriteLine($@" │ │ │ X: {((PointF)value).X}");
                                Console.WriteLine($@" │ │ │ Y: {((PointF)value).Y}");
                                Console.WriteLine($@" │ │");
                            }
                            else if (value.GetType() == typeof(ReadOnlyCollection<byte>))
                            {
                                Console.WriteLine($@" │ │ {friendlyName}: {string.Join(", ", (ReadOnlyCollection<byte>)value)}");
                            }
                            else if (value is StandardTimingIdentifierDescriptorItem)
                            {
                                Console.WriteLine($@" │ │ {(StandardTimingIdentifierDescriptorItem)value}");
                            }
                            else if (value.GetType() == typeof(ReadOnlyCollection<MonitorResolutionInfo>))
                            {
                                var items = (ReadOnlyCollection<MonitorResolutionInfo>)value;
                                foreach (MonitorResolutionInfo item in items)
                                {
                                    Console.WriteLine($@" │ │ {item}");
                                }
                            }
                            //else if (value.GetType() == typeof(ReadOnlyCollection<DetailedTimingModeDescriptor>))
                            //{
                            //    var items = (ReadOnlyCollection<DetailedTimingModeDescriptor>)value;
                            //    foreach (MonitorResolutionInfo item in items)
                            //    {
                            //        Console.WriteLine($@" │ │ {item}");
                            //    }
                            //}
                            else if (value.GetType() == typeof(ReadOnlyCollection<string>))
                            {
                                Console.WriteLine($@" │ │ {friendlyName}");
                                Console.WriteLine($@" │ │ ┌{new string('─', friendlyName.Length - 1)}");
                                var items = (ReadOnlyCollection<string>)value;
                                foreach (string item in items)
                                {
                                    Console.WriteLine($@" │ │ │ {item}");
                                }
                            }
                            else if (value.GetType() == typeof(SectionPropertiesTable))
                            {
                                Console.WriteLine($@" │ │ {friendlyName}");
                                Console.WriteLine($@" │ │ ┌{new string('─', friendlyName.Length - 1)}");
                                var dataBlockProperties = (SectionPropertiesTable)value;
                                foreach (PropertyItem dataBlockProperty in dataBlockProperties)
                                {
                                    IPropertyKey dataBlockPropertyKey = (PropertyKey)dataBlockProperty.Key;
                                    string dataBlockPropertyName = dataBlockPropertyKey.GetPropertyName();

                                    PropertyUnit dataBlockPropertyUnit = dataBlockPropertyKey.PropertyUnit;
                                    string dataUnit = dataBlockPropertyKey.PropertyUnit == PropertyUnit.None ? string.Empty : dataBlockPropertyUnit.ToString();

                                    object dataBlockPropertyValue = dataBlockProperty.Value;
                                    if (dataBlockPropertyValue.GetType() == typeof(ReadOnlyCollection<string>))
                                    {
                                        var items = (ReadOnlyCollection<string>)dataBlockPropertyValue;
                                        foreach (string item in items)
                                        {
                                            Console.WriteLine($@" │ │ │ {item}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($@" │ │ │ {dataBlockPropertyName}: {dataBlockPropertyValue} {dataUnit}");
                                    }
                                }

                                Console.WriteLine($@" │ │");
                            }
                            else if (value.GetType() == typeof(List<SectionPropertiesTable>))
                            {
                                Console.WriteLine($@" │ │ {friendlyName}");
                                Console.WriteLine($@" │ │ ┌{new string('─', friendlyName.Length - 1)}");
                                var sectionPropertiesCollection = (List<SectionPropertiesTable>)value;
                                foreach (SectionPropertiesTable sectionProperty in sectionPropertiesCollection)
                                {
                                    foreach (PropertyItem dataBlockProperty in sectionProperty)
                                    {
                                        IPropertyKey dataBlockPropertyKey = (PropertyKey)dataBlockProperty.Key;
                                        string dataBlockPropertyName = dataBlockPropertyKey.GetPropertyName();

                                        PropertyUnit dataBlockPropertyUnit = dataBlockPropertyKey.PropertyUnit;
                                        string dataUnit = dataBlockPropertyKey.PropertyUnit == PropertyUnit.None ? string.Empty : dataBlockPropertyUnit.ToString();

                                        object dataBlockPropertyValue = dataBlockProperty.Value;
                                        if (dataBlockPropertyValue.GetType() == typeof(ReadOnlyCollection<string>))
                                        {
                                            Console.WriteLine($@" │ │ │ {dataBlockPropertyName}");
                                            Console.WriteLine($@" │ │ │ ┌{new string('─', dataBlockPropertyName.Length - 1)}");
                                            var items = (ReadOnlyCollection<string>)dataBlockPropertyValue;
                                            foreach (string item in items)
                                            {
                                                Console.WriteLine($@" │ │ │ │ {item}");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine($@" │ │ │ {dataBlockPropertyName}: {dataBlockPropertyValue} {dataUnit}");
                                        }
                                    }

                                }

                                Console.WriteLine($@" │ │");
                            }
                            else
                            {
                                Console.WriteLine($@" │ │ {friendlyName} > {value}{unit}");
                            }
                        }
                    }

                    Console.WriteLine();
                }

            }

            Console.WriteLine();
            Console.WriteLine(@" > Gets A Single Property Directly");
            EEDID parsed = EEDID.Parse(MacBookPro2018.IntegratedLaptopPanelEdidTable2);
            DataBlock edidBlock = parsed.Blocks[KnownDataBlock.EDID];
            BaseDataSectionCollection edidSections = edidBlock.Sections;
            DataSection basicDisplaySection = edidSections[(int)KnownEdidSection.BasicDisplay];
            QueryPropertyResult gammaResult = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Gamma);
            if (gammaResult.Success)
            {
                Console.WriteLine($@"   > Gamma > {gammaResult.Value.Value}");
            }

            Console.ReadLine();
        }

        private static string GetFriendlyName(Enum value)
        {
            string friendlyName = value.GetPropertyName();

            return string.IsNullOrEmpty(friendlyName)
                ? value.ToString()
                : friendlyName;
        }


        private class MacBookPro2018
        {
            public static readonly byte[] IntegratedLaptopPanelEdidTable =
            {
                0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00,
                0x42, 0x4c, 0x00, 0x50, 0x89, 0x13, 0x00, 0x00,
                0x06, 0x17, 0x01, 0x03, 0x0e, 0x21, 0x14, 0x78,
                0x6f, 0xee, 0x91, 0xa3, 0x54, 0x4c, 0x99, 0x26,
                0x0f, 0x50, 0x54, 0x21, 0x08, 0x00, 0x81, 0x80,
                0x81, 0x40, 0x81, 0x00, 0x90, 0x40, 0x95, 0x00,
                0xa9, 0x40, 0xb3, 0x00, 0xd1, 0x00, 0xe5, 0xa7,
                0x20, 0x00, 0xd0, 0x34, 0x20, 0x80, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1e,
                0x00, 0x00, 0x00, 0xfd, 0x00, 0x38, 0x40, 0x05,
                0xfa, 0xfa, 0x00, 0x0a, 0x20, 0x20, 0x20, 0x20,
                0x20, 0x20, 0x00, 0x00, 0x00, 0xfc, 0x00, 0x50,
                0x61, 0x72, 0x61, 0x6c, 0x6c, 0x65, 0x6c, 0x73,
                0x20, 0x56, 0x75, 0x0a, 0x00, 0x00, 0x00, 0x10,
                0x00, 0x50, 0x61, 0x72, 0x61, 0x6c, 0x6c, 0x65,
                0x6c, 0x73, 0x0a, 0x0a, 0x0a, 0x0a, 0x00, 0xc0
            };

            public static readonly byte[] IntegratedLaptopPanelEdidTable1 =
            {
                0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00,
                0x06, 0x10, 0x1b, 0xae, 0x2a, 0x76, 0x77, 0x26,
                0x21, 0x1a, 0x01, 0x04, 0xb5, 0x30, 0x1b, 0x78,
                0x20, 0x01, 0x35, 0xae, 0x52, 0x41, 0xb3, 0x26,
                0x0e, 0x4f, 0x54, 0x00, 0x00, 0x00, 0x01, 0x01,
                0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01,
                0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x00, 0x00,
                0x00, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0xfc, 0x00, 0x69,
                0x4d, 0x61, 0x63, 0x0a, 0x20, 0x20, 0x20, 0x20,
                0x20, 0x20, 0x20, 0x20, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x5f,
                0x70, 0x13, 0x79, 0x03, 0x00, 0x03, 0x00, 0x14,
                0x53, 0xec, 0x00, 0x84, 0xff, 0x0f, 0x9f, 0x00,
                0x2f, 0x80, 0x1f, 0x00, 0xff, 0x08, 0x41, 0x00,
                0x02, 0x00, 0x04, 0x00, 0x7f, 0x81, 0x18, 0xfa,
                0x10, 0x00, 0x01, 0x01, 0x00, 0x12, 0x76, 0x31,
                0xfc, 0x78, 0xfb, 0xb2, 0x02, 0x10, 0x88, 0x64,
                0xd4, 0xf6, 0xf6, 0xf7, 0xf8, 0xfe, 0xff, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x26, 0x90,
                0x70, 0x13, 0x79, 0x03, 0x00, 0x03, 0x01, 0x50,
                0x53, 0xec, 0x00, 0x04, 0xff, 0x0f, 0x9f, 0x00,
                0x2f, 0x00, 0x1f, 0x00, 0xff, 0x08, 0x41, 0x00,
                0x02, 0x00, 0x04, 0x00, 0x4c, 0xd0, 0x00, 0x04,
                0xff, 0x0e, 0x9f, 0x00, 0x2f, 0x00, 0x1f, 0x00,
                0x6f, 0x08, 0x3d, 0x00, 0x02, 0x00, 0x04, 0x00,
                0xcc, 0x91, 0x00, 0x04, 0x7f, 0x0c, 0x9f, 0x00,
                0x2f, 0x00, 0x1f, 0x00, 0x07, 0x07, 0x33, 0x00,
                0x02, 0x00, 0x04, 0x00, 0x55, 0x5e, 0x00, 0x04,
                0xff, 0x09, 0x9f, 0x00, 0x2f, 0x00, 0x1f, 0x00,
                0x9f, 0x05, 0x28, 0x00, 0x02, 0x00, 0x04, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1f, 0x90
            };

            public static readonly byte[] IntegratedLaptopPanelEdidTable2 =
            {
                0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00,
                0x1e, 0x6d, 0x07, 0x77, 0x07, 0x23, 0x05, 0x00,
                0x06, 0x1e, 0x01, 0x04, 0xb5, 0x3c, 0x22, 0x78,
                0x9e, 0x3e, 0x31, 0xae, 0x50, 0x47, 0xac, 0x27,
                0x0c, 0x50, 0x54, 0x21, 0x08, 0x00, 0x71, 0x40,
                0x81, 0x80, 0x81, 0xc0, 0xa9, 0xc0, 0xd1, 0xc0,
                0x81, 0x00, 0x01, 0x01, 0x01, 0x01, 0x4d, 0xd0,
                0x00, 0xa0, 0xf0, 0x70, 0x3e, 0x80, 0x30, 0x20,
                0x65, 0x0c, 0x58, 0x54, 0x21, 0x00, 0x00, 0x1a,
                0x28, 0x68, 0x00, 0xa0, 0xf0, 0x70, 0x3e, 0x80,
                0x08, 0x90, 0x65, 0x0c, 0x58, 0x54, 0x21, 0x00,
                0x00, 0x1a, 0x00, 0x00, 0x00, 0xfd, 0x00, 0x38,
                0x3d, 0x1e, 0x87, 0x38, 0x00, 0x0a, 0x20, 0x20, 
                0x20, 0x20, 0x20, 0x20, 0x00, 0x00, 0x00, 0xfc,
                0x00, 0x4c, 0x47, 0x20, 0x48, 0x44, 0x52, 0x20,
                0x34, 0x4b, 0x0a, 0x20, 0x20, 0x20, 0x01, 0x39,
                0x02, 0x03, 0x19, 0x71, 0x44, 0x90, 0x04, 0x03,
                0x01, 0x23, 0x09, 0x07, 0x07, 0x83, 0x01, 0x00,
                0x00, 0xe3, 0x05, 0xc0, 0x00, 0xe3, 0x06, 0x05,
                0x01, 0x02, 0x3a, 0x80, 0x18, 0x71, 0x38, 0x2d,
                0x40, 0x58, 0x2c, 0x45, 0x00, 0x58, 0x54, 0x21,
                0x00, 0x00, 0x1e, 0x56, 0x5e, 0x00, 0xa0, 0xa0,
                0xa0, 0x29, 0x50, 0x30, 0x20, 0x35, 0x00, 0x58,
                0x54, 0x21, 0x00, 0x00, 0x1a, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x29
            };
        }
    }
}
