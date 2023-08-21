
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

using iTin.Core.Hardware.Common;

using iTin.Logging.ComponentModel;

using iTin.Hardware.Specification;
using iTin.Hardware.Specification.Eedid;
using iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors;

namespace iEEDID.ComponentModel.Parser;

/// <summary>
/// Specialization of the <see cref="IParser"/> interface.<br/>
/// Defines a custom parser for <see cref="EEDID"/> raw instances.
/// </summary> 
internal class RawParser : IParser
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
        Logger.Info(@" Implemented Blocks");
        Logger.Info(@" ══════════════════");

        DataBlockCollection blocks = instance.Blocks;
        foreach (KnownDataBlock block in blocks.ImplementedBlocks)
        {
            Logger.Info($@" │ {block}");
        }

        foreach (DataBlock block in blocks)
        {
            var blockLiteral = $@"{block.Key} Block";

            Logger.Info("");
            Logger.Info($@" {blockLiteral}");
            Logger.Info($@" {new string('═', blockLiteral.Length)}");

            Logger.Info("");
            Logger.Info(@" Implemented Sections");
            Logger.Info(@" ┌───────────────────");
            var implSections = instance.Blocks[block.Key].Sections.ImplementedSections;
            foreach (Enum section in implSections)
            {
                Logger.Info($@" │ {section.AsFriendlyName()}");
            }

            Logger.Info("");
            Logger.Info(@" Sections");
            Logger.Info(@" ┌───────");
            BaseDataSectionCollection sections = block.Sections;
            foreach (DataSection section in sections)
            {
                var sectionLiteral = $"{section.Key.AsFriendlyName()} Section";

                Logger.Info($@" │");
                Logger.Info($@" ├ {sectionLiteral}");
                Logger.Info($@" │ ┌{new string('─', sectionLiteral.Length - 1)}");

                IEnumerable<IPropertyKey> properties = section.ImplementedProperties;
                foreach (IPropertyKey property in properties)
                {
                    string friendlyName = property.GetPropertyName();
                    PropertyUnit valueUnit = property.PropertyUnit;
                    string unit = valueUnit == PropertyUnit.None ? string.Empty : valueUnit.ToString();

                    QueryPropertyResult queryResult = section.GetProperty(property);
                    PropertyItem propertyItem = queryResult.Result;
                    object value = propertyItem.Value;
                    if (value == null)
                    {
                        Logger.Info($@" │ │ {friendlyName}: NULL");
                        continue;
                    }

                    if (value is string)
                    {
                        Logger.Info($@" │ │ {friendlyName}: {value}{unit}");
                    }
                    else if (value is bool)
                    {
                        Logger.Info($@" │ │ {friendlyName}: {value}{unit}");
                    }
                    else if (value is double)
                    {
                        Logger.Info($@" │ │ {friendlyName}: {value}{unit}");
                    }
                    else if (value is byte)
                    {
                        Logger.Info($@" │ │ {friendlyName}: {value}{unit} [{value:X2}h]");
                    }
                    else if (value is short)
                    {
                        Logger.Info($@" │ │ {friendlyName}: {value}{unit} [{value:X4}h]");
                    }
                    else if (value is ushort)
                    {
                        Logger.Info($@" │ │ {friendlyName}: {value}{unit} [{value:X4}h]");
                    }
                    else if (value is int)
                    {
                        Logger.Info($@" │ │ {friendlyName}: {value}{unit} [{value:X4}h]");
                    }
                    else if (value is uint)
                    {
                        Logger.Info($@" │ │ {friendlyName}: {value}{unit} [{value:X4}h]");
                    }
                    else if (value is long)
                    {
                        Logger.Info($@" │ │ {friendlyName}: {value}{unit} [{value:X8}h]");
                    }
                    else if (value is ulong)
                    {
                        Logger.Info($@" │ │ {friendlyName}: {value}{unit} [{value:X8}h]");
                    }
                    else if (value is PointF)
                    {
                        var pointLiteral = $"{ friendlyName }";
                        Logger.Info($@" │ │ {pointLiteral}");
                        Logger.Info($@" │ │ ┌{new string('─', pointLiteral.Length - 1)}");
                        Logger.Info($@" │ │ │ X: {((PointF)value).X}");
                        Logger.Info($@" │ │ │ Y: {((PointF)value).Y}");
                        Logger.Info($@" │ │");
                    }
                    else if (value is StandardTimingIdentifierDescriptorItem)
                    {
                        Logger.Info($@" │ │ {(StandardTimingIdentifierDescriptorItem)value}");
                    }
                    else if (value.GetType() == typeof(ReadOnlyCollection<byte>))
                    {
                        Logger.Info($@" │ │ {friendlyName}: {string.Join(", ", (ReadOnlyCollection<byte>)value)}");
                    }
                    else if (value.GetType() == typeof(ReadOnlyCollection<string>))
                    {
                        Logger.Info($@" │ │ {friendlyName}");
                        Logger.Info($@" │ │ ┌{new string('─', friendlyName.Length - 1)}");
                        var items = (ReadOnlyCollection<string>)value;
                        foreach (string item in items)
                        {
                            Logger.Info($@" │ │ │ {item}");
                        }
                    }
                    else if (value.GetType() == typeof(ReadOnlyCollection<MonitorResolutionInfo>))
                    {
                        var items = (ReadOnlyCollection<MonitorResolutionInfo>)value;
                        foreach (MonitorResolutionInfo item in items)
                        {
                            Logger.Info($@" │ │ {item}");
                        }
                    }
                    else if (value.GetType() == typeof(SectionPropertiesTable))
                    {
                        Logger.Info($@" │ │ {friendlyName}");
                        Logger.Info($@" │ │ ┌{new string('─', friendlyName.Length - 1)}");
                        var dataBlockProperties = (SectionPropertiesTable)value;
                        foreach (PropertyItem dataBlockProperty in dataBlockProperties)
                        {
                            IPropertyKey dataBlockPropertyKey = (PropertyKey)dataBlockProperty.Key;
                            string dataBlockPropertyName = dataBlockPropertyKey.GetPropertyName();

                            PropertyUnit dataBlockPropertyUnit = dataBlockPropertyKey.PropertyUnit;
                            string dataUnit = dataBlockPropertyKey.PropertyUnit == PropertyUnit.None ? string.Empty : dataBlockPropertyUnit.ToString();

                            object dataBlockPropertyValue = dataBlockProperty.Value;
                            if (dataBlockPropertyValue.GetType() == typeof(ReadOnlyCollection<byte>))
                            {
                                Logger.Info($@" │ │ │ {dataBlockPropertyName}: {string.Join(" ", (ReadOnlyCollection<byte>)dataBlockPropertyValue)}");
                            }
                            else if (dataBlockPropertyValue.GetType() == typeof(ReadOnlyCollection<string>))
                            {
                                var items = (ReadOnlyCollection<string>)dataBlockPropertyValue;
                                foreach (string item in items)
                                {
                                    Logger.Info($@" │ │ │ {item}");
                                }
                            }
                            else
                            {
                                Logger.Info($@" │ │ │ {dataBlockPropertyName}: {dataBlockPropertyValue} {dataUnit}");
                            }
                        }

                        Logger.Info($@" │ │");
                    }
                    else if (value.GetType() == typeof(List<SectionPropertiesTable>))
                    {
                        Logger.Info($@" │ │ {friendlyName}");
                        Logger.Info($@" │ │ ┌{new string('─', friendlyName.Length - 1)}");
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
                                    Logger.Info($@" │ │ │ {dataBlockPropertyName}");
                                    Logger.Info($@" │ │ │ ┌{new string('─', dataBlockPropertyName.Length - 1)}");
                                    var items = (ReadOnlyCollection<string>)dataBlockPropertyValue;
                                    foreach (string item in items)
                                    {
                                        Logger.Info($@" │ │ │ │ {item}");
                                    }
                                }
                                else
                                {
                                    Logger.Info($@" │ │ │ {dataBlockPropertyName}: {dataBlockPropertyValue} {dataUnit}");
                                }
                            }
                        }

                        Logger.Info($@" │ │");
                    }
                    else
                    {
                        Logger.Info($@" │ │ {friendlyName} > {value}{unit}");
                    }
                }
            }
        }
    }
}
