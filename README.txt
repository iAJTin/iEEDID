
What is iEEDID?
================

iEEDID is a lightweight implementation that allows us to obtain the the EEDID information.


Changes in this version (v1.0.7)
================================

· Fixed
  -----

    - Fixes an issue that generates an exception when a property that returns an object of type QueryPropertyDictionaryResult not available.

· Added
  -----

    - Added support for **netstandard2.1** 
 
      - Add **SplitEnumerator** ref struct.
   
      - ByteReader class rewritten to work with Span in net core projects.

    - Added sample project for net60

    - Added support for MacOS (In progress...)
 
      Tested on:
      •—————————————————————•
      | macOS       Version |
      •—————————————————————•
      | Big Sur     10.15.7 |
      •—————————————————————•
      | Catalina     11.0.1 |
      •—————————————————————•
    
    - Added support for DI blocks (Implemented)

    - Added support for CEA blocks (In progress...)
    
    - Added support for DisplayID blocks (In progress...)

    - Added EEDID.Instance static property for gets all available EEDID structures for current system

    - Library documentation

    - tools folder in solution root. Contains a script for update help md files

· Changed
  -------
  
    - Rewrite hardware libraries for compability with others projects.

    - Changed IResultGeneric interface. Changed Value property name by Result (for code clarify).

      · This change may have implications in your final code, it is resolved by changing Value to Result

    - Update result classes for support more scenaries

    - Library versions for this version

      •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | Library                                      Version     Description                                                                       |
      •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core                                    2.0.0.6     Base library containing various extensions, helpers, common constants             |
      •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Hardware.Abstractions              1.0.0.0     Generic Common Hardware Abstractions                                              |
      •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Hardware.Common                    1.0.0.5     Common Hardware Infrastructure                                                    |
      •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Hardware.Linux.Device.Desktop      1.0.0.1     Linux Hardware Infrastructure                                                     |
      •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Hardware.MacOS.Device.Desktop      1.0.0.1     MacOS Hardware Infrastructure                                                     |
      •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Hardware.Windows.Device.Desktop    1.0.0.1     Generic Common Hardware Abstractions                                              |
      •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Interop.Shared                     1.0.0.4     Generic Shared Interop Definitions                                                |
      •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Interop.Windows.Devices            1.0.0.1     Generic Win32 Interop Definitions, Data Structures, Constants...                  |
      •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Hardware.Abstractions.Devices           1.0.0.1     Generic Common Hardware Abstractions                                              |
      •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Hardware.Specification.Eedid            1.0.0.8     Implementation of the E-EDID (Extended Display Identification Data) specification |
      •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Hardware.Specification.IEEE             1.0.0.0     IEEE Registration Authority                                                       |
      •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Logging                                 1.0.0.2     Logging library                                                                   |
      •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

v1.0.6
======

· Changed
  -------

    - Library versions for this version

      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | Library                               Version      Description                                                                          |
      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core                             2.0.0.1     Base library containing various extensions, helpers, common constants                 |
      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Core.Hardware.Common             1.0.0.1     Common Hardware Infrastructure                                                        |
      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Hardware.Specification.Eedid     1.0.0.6     Implementation of the E-EDID (Extended Display Identification Data) specification     |
      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | iTin.Logging                          1.0.0.0     Logging library                                                                       |
      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

· Removed
  -------

    - Removed netcoreapp target. Current supported targets, net461 and netstandard20


v1.0.5
======

· Changed
  -------

    - Library versions for this version

      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      | Library                                  Version      Description                                                                       |
      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      |iTin.Core                                 2.0.0.0      Base library containing various extensions, helpers, common constants             |
      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      |iTin.Core.Hardware.Common                 1.0.0.0      Common Hardware Infrastructure                                                    |
      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      |iTin.Core.Hardware.Specification.Eedid    1.0.0.5      Implementation of the E-EDID (Extended Display Identification Data) specification |
      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
      |iTin.Logging                              1.0.0.0      Logging library                                                                   |
      •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•


Install via NuGet
=================

PM> Install-Package iEEDID

For more information, please see https://www.nuget.org/packages/iEEDID/

Usage
=====

Examples
--------

1.  Gets and prints all EEDID implemented blocks.

    EEDID edid = EEDID.Parse(MacBookPro2018.IntegratedLaptopPanelEdidTable);
    DataBlockCollection blocks = edid.Blocks;
    foreach (KnownDataBlock block in blocks.ImplementedBlocks)
    {
        Console.WriteLine($@" > {block}");
    }

2.  Gets a specific EEDID block.

    EEDID edid = EEDID.Parse(MacBookPro2018.IntegratedLaptopPanelEdidTable);
    DataBlockCollection blocks = edid.Blocks;
    DataBlock edid = blocks[KnownDataBlock.EDID];
    if (edid != null)
    {
        /// block exist!!!
    }

3.  Prints all EEDID blocks properties.

    EEDID edid = EEDID.Parse(MacBookPro2018.IntegratedLaptopPanelEdidTable);
    DataBlockCollection blocks = edid.Blocks;
    foreach (DataBlock block in blocks)
    { 
        Console.WriteLine();
        Console.WriteLine($@"   > {block.Key} Block");

        Console.WriteLine();
        Console.WriteLine(@"     > Implemented Sections");
        ReadOnlyCollection<Enum> implSections = eedid.Blocks[block.Key].Sections.ImplementedSections;
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

4.  Gets a single property directly.

    DataBlock edidBlock = eedid.Blocks[KnownDataBlock.EDID];
    BaseDataSectionCollection edidSections = edidBlock.Sections;
    DataSection basicDisplaySection = edidSections[(int)KnownEdidSection.BasicDisplay];
    QueryPropertyResult gammaResult = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Gamma);
    if (gammaResult.Success)
    {
        Console.WriteLine($@"   > Gamma > {gammaResult.Value.Value}");
    }

Documentation
==============

 - For full code documentation, please see next link https://github.com/iAJTin/iEEDID/blob/master/documentation/iTin.Hardware.Specification.Eedid.md.
