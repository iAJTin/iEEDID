
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections;

// CEA Section: Detailed Timings Descriptors Information
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Lenght      Description                                         |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="CeaSection.DetailedTiming"/> section of this block <see cref="KnownDataBlock.CEA"/>.
/// </summary> 
internal sealed class DetailedTimingsSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="DetailedTimingsSection"/> class with the data from this raw section.
    /// </summary>
    /// <param name="sectionData">Data from this section untreated.</param>
    public DetailedTimingsSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
    {
    }

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        var sectionProperties = new List<SectionPropertiesTable>();
        var timings = GetTimings(RawData);
        foreach (var timing in timings)
        {
            var timingProperties = timing.Properties;
            foreach(var timingProperty in timingProperties)
            {
                var key = timingProperty.Key;
                if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.PixelClock))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.PixelClock;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalResolution))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.HorizontalResolution;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalBlanking))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.HorizontalBlanking;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalLines))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.VerticalLines;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalBlanking))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.VerticalBlanking;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalFrontPorch))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.HorizontalFrontPorch;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalSyncPulseWidth))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.HorizontalSyncPulseWidth;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalFrontPorch))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.VerticalFrontPorch;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalSyncPulseWidth))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.VerticalSyncPulseWidth;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalImageSize))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.HorizontalImageSize;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalImageSize))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.VerticalImageSize;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalBorder))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.HorizontalBorder;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.VerticalBorder))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.VerticalBorder;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.IsInterlaced))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.IsInterlaced;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.StereoViewingSupport))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.StereoViewingSupport;
                }
                else if (key.Equals(EedidProperty.Edid.DataBlock.Definition.DetailedTimingMode.SyncSignalType))
                {
                    timingProperty.Key = EedidProperty.Cea.DetailedTiming.Descriptor.SyncSignalType;
                }
            }

            sectionProperties.Add(timing.Properties);
        }

        properties.Add(EedidProperty.Cea.DetailedTiming.Timings, sectionProperties);
    }

    #endregion

    #region private static methods

    /// <summary>
    /// Gets the timings.
    /// </summary>
    /// <param name="rawData">The raw data.</param>
    /// <returns>
    /// Timings collection
    /// </returns>
    private static ReadOnlyCollection<DetailedTimingModeDescriptor> GetTimings(ReadOnlyCollection<byte> rawData)
    {
        var dataTimmingCollection = ToDataTimmingCollection(rawData);

        var timings = 
            (from timmingDataItem in dataTimmingCollection
                let valid = IsValidDataTimming(timmingDataItem)
                where valid
                select timmingDataItem)
            .Select(timmingDataItem => new DetailedTimingModeDescriptor(timmingDataItem))
            .ToList();

        return timings.AsReadOnly();
    }

    /// <summary>
    /// Gets the collection of Data Timmings Descriptors available in this CEA block.
    /// </summary>
    /// <param name="dataTimmings">Array with Data Timmings Descriptors data.</param>
    /// <returns>
    /// Collection of Data Timmings Descriptors.
    /// </returns>
    private static IEnumerable<ReadOnlyCollection<byte>> ToDataTimmingCollection(ReadOnlyCollection<byte> dataTimmings)
    {
        var dataTimmingsArray = dataTimmings.ToArray();
        var dataTimmingCollection = new List<ReadOnlyCollection<byte>>();
        for (var i = 0; i < dataTimmings.Count; i += 0x12)
        {
            var dataTimmingArray = new byte[0x12];

            Array.Copy(dataTimmingsArray, i, dataTimmingArray, 0x00, 0x12);
            dataTimmingCollection.Add(new ReadOnlyCollection<byte>(dataTimmingArray));
        }

        return dataTimmingCollection;
    }

    /// <summary>
    /// Gets a value that indicates whether the specified Data Timming Descriptor is valid.
    /// </summary>
    /// <param name="dataTimming">Data Timming Descriptor.</param>
    /// <returns>
    /// <b>true</b> if the specified Data Timming Descriptor is valid; otherwise <b>false</b>.
    /// </returns>
    private static bool IsValidDataTimming(ReadOnlyCollection<byte> dataTimming) => !((dataTimming[0x00] == 0x00) & (dataTimming[0x01] == 0x00));

    #endregion
}
