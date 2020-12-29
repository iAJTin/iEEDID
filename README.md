<p align="center">
  <img src="https://github.com/iAJTin/iEEDID/blob/master/nuget/iEEDID.png" height="32">
</p>
<p align="center">
  <a href="https://github.com/iAJTin/iEEDID">
    <img src="https://img.shields.io/badge/iTin-iEEDID-green.svg?style=flat"/>
  </a>
</p>

***

# What is iEEDID?
**iEEDID** is a lightweight implementation that allows us to obtain the **EDID** information.

# Supported standards

The following **EDID** standards are supported by **iEEDID**:

| Standard | Status |
|:------|:------|
| EDID 1.4: VESA Enhanced Extended Display Identication Data Standard, Release A, Revision 2 | Implemented |
| DisplayID 1.3: VESA Display Identification Data (DisplayID) Standard, Version 1.3 | **In progress...** |
| DisplayID 2.0: VESA DisplayID Standard, Version 2.0 | **In progress...** |
| CTA-861-G: A DTV Profile for Uncompressed High Speed Digital Interfaces | **In progress...** |
| DI-EXT: VESA Display Information Extension Block Standard, Release A | Implemented |
| LS-EXT: VESA Enhanced EDID Localized String Extension Standard, Release A | **In progress...** |
| VTB-EXT: VESA Video Timing Block Extension Data Standard, Release A | **In progress...** |

# Install via NuGet

- From nuget gallery

<table>
  <tr>
    <td>
      <a href="https://github.com/iAJTin/iEEID/tree/master/src/iTin.Core.Hardware">
        <img src="https://img.shields.io/badge/-iEEID-green.svg?style=flat"/>
      </a>
    </td>
    <td>
      <a href="https://www.nuget.org/packages/iEEDID/">
        <img alt="NuGet Version" 
             src="https://img.shields.io/nuget/v/iEEDID.svg" /> 
      </a>
    </td>  
  </tr>
</table>

- From package manager console

```PM> Install-Package iEEDID```

# Usage

## Examples

1. Gets and prints all **EEDID** implemented blocks.


        EEDID edid = EEDID.Parse(MacBookPro2018.IntegratedLaptopPanelEdidTable);
        DataBlockCollection blocks = edid.Blocks;
        foreach (KnownDataBlock block in blocks.ImplementedBlocks)
        {
            Console.WriteLine($@" > {block}");
        }

2. Gets a specific **EEDID** block.


        EEDID edid = EEDID.Parse(MacBookPro2018.IntegratedLaptopPanelEdidTable);
        DataBlockCollection blocks = edid.Blocks;
        DataBlock edid = blocks[KnownDataBlock.EDID];
        if (edid != null)
        {
            /// block exist!!!
        }

3. Prints all **EEDID** blocks properties.

        {
            EEDID eedid = EEDID.Parse(MacBookPro2018.IntegratedLaptopPanelEdidTable);
            DataBlockCollection blocks = eedid.Blocks;
            foreach (DataBlock block in blocks)
            {
                var implSections = eedid.Blocks[block.Key].Sections.ImplementedSections; 
                BaseDataSectionCollection sections = block.Sections;
                foreach (DataSection section in sections)
                {
                    Console.WriteLine();
                    Console.WriteLine($@"       > {GetFriendlyName(section.Key)} Section");

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
                                string dataName = dataBlockKey.GetPropertyName();
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
        }

        ...
        ...
        ...

        private static string GetFriendlyName(Enum value)
        {
            string friendlyName = value.GetPropertyName();

            return string.IsNullOrEmpty(friendlyName)
                ? value.ToString()
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

4. Gets a **single property** directly.

        DataBlock edidBlock = eedid.Blocks[KnownDataBlock.EDID];
        BaseDataSectionCollection edidSections = edidBlock.Sections;
        DataSection basicDisplaySection = edidSections[(int)KnownEdidSection.BasicDisplay];
        QueryPropertyResult gammaResult = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Gamma);
        if (gammaResult.Success)
        {
            Console.WriteLine($@"   > Gamma > {gammaResult.Value.Value}");
        }

# Documentation

 - For full code documentation, please see next link [documentation].

# How can I send feedback!!!

If you have found **iEEDID** useful at work or in a personal project, I would love to hear about it. If you have decided not to use **iEEDID**, please send me and email stating why this is so. I will use this feedback to improve **iEEDID** in future releases.

My email address is 

![email.png][email] 


[email]: ./assets/email.png "email"
[documentation]: ./documentation/iTin.Hardware.Specification.Eedid.md
