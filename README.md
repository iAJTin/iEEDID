<p align="center">
  <img src="https://cdn.rawgit.com/iAJTin/iEEDID/master/nuget/iEEDID.png"  
       height="32">
</p>
<p align="center">
  <a href="https://github.com/iAJTin/iEEDID">
    <img src="https://img.shields.io/badge/iTin-iEEDID-green.svg?style=flat"/>
  </a>
</p>

***

# What is iEEDID?
**iEEDID** is a lightweight implementation that allows us to obtain the **EDID** information


# Install via NuGet

<table>
  <tr>
    <td>
      <a href="https://github.com/iAJTin/iEEID/tree/master/src/iTin.Core.Hardware">
        <img src="https://img.shields.io/badge/-iEEID-green.svg?style=flat"/>
      </a>
    </td>
    <td>
      <a href="https://www.nuget.org/packages/iEEID/">
        <img alt="NuGet Version" 
             src="https://img.shields.io/nuget/v/iEEID.svg" /> 
      </a>
    </td>  
  </tr>
</table>

# Usage

## Examples

1. Gets and prints all **EEDID** implemented blocks.


       EEDID edid = EEDID.Parse(MacBookPro2018.IntegratedLaptopPanelEdidTable);
       DataBlockCollection blocks = edid.Blocks;
       foreach (KnownDataBlock block in blocks.ImplementedBlocks)
       {
           Console.WriteLine($" > {block}");
       }

2. Gets a specific **EEDID** structure.


       EEDID edid = EEDID.Parse(MacBookPro2018.IntegratedLaptopPanelEdidTable);
       DataBlockCollection blocks = edid.Blocks;
       DmiStructure vendor = blocks[SmbiosStructure.Bios];
       if (bios != null)
       {
           /// block exist!!!
       }

3. Prints all **EEDID** structures properties

		EEDID edid = EEDID.Parse(MacBookPro2018.IntegratedLaptopPanelEdidTable);
		DataBlockCollection blocks = edid.Blocks;
		foreach (DataBlock block in blocks)
		{
			Console.WriteLine();
			Console.WriteLine($" ——————————————————————————————————————————————————————————————");
			Console.WriteLine($" {block.Key} block");
			Console.WriteLine($" ——————————————————————————————————————————————————————————————");

			BaseDataSectionCollection sections = block.Sections;
			foreach (DataSection section in sections)
			{
				Console.WriteLine($" > {section.Key} section");

				Hashtable sectionProperties = section.Properties.Values;
				foreach (DictionaryEntry property in sectionProperties)
				{
					object value = property.Value;

					PropertyKey key = (PropertyKey) property.Key;
					Enum id = key.PropertyId;

					var valueUnit = key.PropertyUnit;
					var unit =
						valueUnit == PropertyUnit.None
							? string.Empty
							: valueUnit.ToString();

					if (value == null)
					{
						Console.WriteLine($"   > {id} > NULL");
						continue;
					}

					if (value is string)
					{
						Console.WriteLine($"   > {id} > {value}{unit}");
					}
					else if (value is bool)
					{
						Console.WriteLine($"   > {id} > {value}{unit}");
					}
					else if (value is double)
					{
						Console.WriteLine($"   > {id} > {value}{unit}");
					}
					else if (value is byte)
					{
						Console.WriteLine($"   > {id} > {value}{unit} [{value:X2}h]");
					}
					else if (value is short)
					{
						Console.WriteLine($"   > {id} > {value}{unit} [{value:X4}h]");
					}
					else if (value is ushort)
					{
						Console.WriteLine($"   > {id} > {value}{unit} [{value:X4}h]");
					}
					else if (value is int)
					{
						Console.WriteLine($"   > {id} > {value}{unit} [{value:X4}h]");
					}
					else if (value is uint)
					{
						Console.WriteLine($"   > {id} > {value}{unit} [{value:X4}h]");
					}
					else if (value is long)
					{
						Console.WriteLine($"   > {id} > {value}{unit} [{value:X8}h]");
					}
					else if (value is ulong)
					{
						Console.WriteLine($"   > {id} > {value}{unit} [{value:X8}h]");
					}
					else if (value is PointF)
					{
						Console.WriteLine($"   > {id}");
						Console.WriteLine($"     > X > {((PointF)value).X}");
						Console.WriteLine($"     > Y > {((PointF)value).Y}");
					}
					else if (value.GetType() == typeof(ReadOnlyCollection<string>))
					{
						Console.WriteLine($"   > {id} > {string.Join(", ", (ReadOnlyCollection<string>)value)}");
					}
					else if (value.GetType() == typeof(ReadOnlyCollection<byte>))
					{
						Console.WriteLine($"   > {id} > {string.Join(", ",(ReadOnlyCollection<byte>) value)}");
					}
					else if (value is StandardTimingIdentifierDescriptorItem)
					{
						Console.WriteLine($"   > {(StandardTimingIdentifierDescriptorItem)value}");
					}
					else if (value.GetType() == typeof(ReadOnlyCollection<MonitorResolutionInfo>))
					{
						var resolutions = (ReadOnlyCollection<MonitorResolutionInfo>)value;
						foreach (MonitorResolutionInfo resolution in resolutions)
						{
							Console.WriteLine($"   > {resolution}");
						}
					}
					else
					{
						Console.WriteLine($"   > {id} > {value}{unit}");
					}
				}
			}
		}

# How can I send feedback!!!

If you have found **iEEDID** useful at work or in a personal project, I would love to hear about it. If you have decided not to use **iEEDID**, please send me and email stating why this is so. I will use this feedback to improve **iEEDID** in future releases.

My email address is fdo.garcia.vega@gmail.com
