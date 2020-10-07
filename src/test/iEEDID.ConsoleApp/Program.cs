
namespace iEEDID.ConsoleApp
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
            Console.WriteLine(@" > Implemented Blocks");

            EEDID eedid = EEDID.Parse(MacBookPro2018.IntegratedLaptopPanelEdidTable);
            DataBlockCollection blocks = eedid.Blocks;
            foreach (KnownDataBlock block in blocks.ImplementedBlocks)
            {
                Console.WriteLine($@"   > {block}");
            }

            foreach (DataBlock block in blocks)
            {
                Console.WriteLine();
                Console.WriteLine($@"   > {block.Key} Block");
                
                var implSections = eedid.Blocks[block.Key].Sections.ImplementedSections;
                Console.WriteLine();
                Console.WriteLine(@"     > Implemented Sections");
                foreach (Enum section in implSections)
                {
                    Console.WriteLine($@"       > {GetFriendlyName(section)}");
                }

                Console.WriteLine();
                Console.WriteLine(@"     > Sections detail");
                BaseDataSectionCollection sections = block.Sections;
                foreach (DataSection section in sections)
                {
                    Console.WriteLine();
                    Console.WriteLine($@"       > {GetFriendlyName(section.Key)} Section");

                    IEnumerable<IPropertyKey> properties = section.ImplementedProperties;
                    foreach (IPropertyKey property in properties)
                    {
                        string friendlyName = GetFriendlyName(property);

                        QueryPropertyResult queryResult = section.GetProperty(property);
                        PropertyItem propertyItem = queryResult.Value;
                        object value = propertyItem.Value;

                        PropertyUnit valueUnit = property.PropertyUnit;
                        string unit = valueUnit == PropertyUnit.None ? string.Empty : valueUnit.ToString();

                        if (value == null)
                        {
                            Console.WriteLine($@"         > {friendlyName} > NULL");
                            continue;
                        }

                        if (value is string)
                        {
                            Console.WriteLine($@"         > {friendlyName} > {value}{unit}");
                        }
                        else if (value is bool)
                        {
                            Console.WriteLine($@"         > {friendlyName} > {value}{unit}");
                        }
                        else if (value is double)
                        {
                            Console.WriteLine($@"         > {friendlyName} > {value}{unit}");
                        }
                        else if (value is byte)
                        {
                            Console.WriteLine($@"         > {friendlyName} > {value}{unit} [{value:X2}h]");
                        }
                        else if (value is short)
                        {
                            Console.WriteLine($@"         > {friendlyName} > {value}{unit} [{value:X4}h]");
                        }
                        else if (value is ushort)
                        {
                            Console.WriteLine($@"         > {friendlyName} > {value}{unit} [{value:X4}h]");
                        }
                        else if (value is int)
                        {
                            Console.WriteLine($@"         > {friendlyName} > {value}{unit} [{value:X4}h]");
                        }
                        else if (value is uint)
                        {
                            Console.WriteLine($@"         > {friendlyName} > {value}{unit} [{value:X4}h]");
                        }
                        else if (value is long)
                        {
                            Console.WriteLine($@"         > {friendlyName} > {value}{unit} [{value:X8}h]");
                        }
                        else if (value is ulong)
                        {
                            Console.WriteLine($@"         > {friendlyName} > {value}{unit} [{value:X8}h]");
                        }
                        else if (value is PointF)
                        {
                            Console.WriteLine($@"         > {friendlyName}");
                            Console.WriteLine($@"           > X > {((PointF)value).X}");
                            Console.WriteLine($@"           > Y > {((PointF)value).Y}");
                        }
                        else if (value.GetType() == typeof(ReadOnlyCollection<string>))
                        {
                            Console.WriteLine($@"         > {friendlyName} > {string.Join(", ", (ReadOnlyCollection<string>)value)}");
                        }
                        else if (value.GetType() == typeof(ReadOnlyCollection<byte>))
                        {
                            Console.WriteLine($@"         > {friendlyName} > {string.Join(", ", (ReadOnlyCollection<byte>)value)}");
                        }
                        else if (value is StandardTimingIdentifierDescriptorItem)
                        {
                            Console.WriteLine($@"         > {(StandardTimingIdentifierDescriptorItem)value}");
                        }
                        else if (value.GetType() == typeof(ReadOnlyCollection<MonitorResolutionInfo>))
                        {
                            var resolutions = (ReadOnlyCollection<MonitorResolutionInfo>)value;
                            foreach (MonitorResolutionInfo resolution in resolutions)
                            {
                                Console.WriteLine($@"         > {resolution}");
                            }
                        }
                        else if (value.GetType() == typeof(SectionPropertiesTable))
                        {
                            Console.WriteLine($@"         > {friendlyName}");
                            var dataBlockProperties = (SectionPropertiesTable)value;
                            foreach (PropertyItem dataBlockProperty in dataBlockProperties)
                            {
                                object dataValue = dataBlockProperty.Value;

                                IPropertyKey dataBlockKey = (PropertyKey)dataBlockProperty.Key;
                                string dataName = GetFriendlyName(dataBlockKey);
                                PropertyUnit dataBlockUnit = dataBlockKey.PropertyUnit;
                                string dataUnit = dataBlockUnit == PropertyUnit.None ? string.Empty : dataBlockUnit.ToString();
                                Console.WriteLine($@"           > {dataName} > {dataValue} {dataUnit}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($@"         > {friendlyName} > {value}{unit}");
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(@" > Gets A Single Property Directly");

            DataBlock edidBlock = eedid.Blocks[KnownDataBlock.EDID];
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

        private static string GetFriendlyName(IPropertyKey value)
        {
            string friendlyName = value.GetPropertyName();

            return string.IsNullOrEmpty(friendlyName)
                ? value.PropertyId.ToString()
                : friendlyName;
        }


        // nested classes
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
        }
    }
}
