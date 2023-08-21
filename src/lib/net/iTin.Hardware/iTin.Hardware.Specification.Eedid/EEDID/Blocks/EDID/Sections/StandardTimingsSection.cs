
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

using iTin.Core;

using iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections;

// EDID Section: Standard Timings 16 Bytes
// •————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Lenght      Description                             |
// •————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Standard Timing 1         WORD        Note:  See Timing(KnownStandardTiming)  |
// •————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Standard Timing 2         WORD        Note:  See Timing(KnownStandardTiming)  |
// •————————————————————————————————————————————————————————————————————————————————————————————•
// | 04h          Standard Timing 3         WORD        Note:  See Timing(KnownStandardTiming)  |
// •————————————————————————————————————————————————————————————————————————————————————————————•
// | 06h          Standard Timing 4         WORD        Note:  See Timing(KnownStandardTiming)  |
// •————————————————————————————————————————————————————————————————————————————————————————————•
// | 08h          Standard Timing 5         WORD        Note:  See Timing(KnownStandardTiming)  |
// •————————————————————————————————————————————————————————————————————————————————————————————•
// | 0ah          Standard Timing 6         WORD        Note:  See Timing(KnownStandardTiming)  |
// •————————————————————————————————————————————————————————————————————————————————————————————•
// | 0ch          Standard Timing 7         WORD        Note:  See Timing(KnownStandardTiming)  |
// •————————————————————————————————————————————————————————————————————————————————————————————•
// | 0eh          Standard Timing 8         WORD        Note:  See Timing(KnownStandardTiming)  |
// •————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="EdidSection.StandardTimings"/> section of this block <see cref="KnownDataBlock.EDID"/>.
/// </summary> 
internal sealed class StandardTimingsSection : BaseDataSection
{
    #region private enumerations

    /// <summary>
    /// Known timings for this block.
    /// </summary> 
    private enum KnownStandardTiming
    {
        /// <summary>
        /// Timing 1.
        /// </summary>
        Timing1,

        /// <summary>
        /// Timing 2.
        /// </summary>
        Timing2,

        /// <summary>
        /// Timing 3.
        /// </summary>
        Timing3,

        /// <summary>
        /// Timing 4.
        /// </summary>
        Timing4,

        /// <summary>
        /// Timing 5.
        /// </summary>
        Timing5,

        /// <summary>
        /// Timing 6.
        /// </summary>
        Timing6,

        /// <summary>
        /// Timing 7.
        /// </summary>
        Timing7,

        /// <summary>
        /// Timing 8.
        /// </summary>
        Timing8,
    }

    #endregion

    #region private members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Dictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem> _timingTable;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="StandardTimingsSection"/> class with the data in this section untreated.
    /// </summary>
    /// <param name="sectionData">Unprocessed data in this section</param>
    public StandardTimingsSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value that represents a dictionary of Timings dictionary.
    /// </summary>
    /// <value>
    /// Dictionary containing the pair Timing / Value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Dictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem> TimingTable
    {
        get
        {
            if (_timingTable != null)
            {
                return _timingTable;
            }

            _timingTable = new Dictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem>();
            PopulatesTimingsTable(_timingTable);
            return _timingTable;
        }
    }

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.Edid.StandardTimings.Timing1, Timing(KnownStandardTiming.Timing1));
        properties.Add(EedidProperty.Edid.StandardTimings.Timing2, Timing(KnownStandardTiming.Timing2));
        properties.Add(EedidProperty.Edid.StandardTimings.Timing3, Timing(KnownStandardTiming.Timing3));
        properties.Add(EedidProperty.Edid.StandardTimings.Timing4, Timing(KnownStandardTiming.Timing4));
        properties.Add(EedidProperty.Edid.StandardTimings.Timing5, Timing(KnownStandardTiming.Timing5));
        properties.Add(EedidProperty.Edid.StandardTimings.Timing6, Timing(KnownStandardTiming.Timing6));
        properties.Add(EedidProperty.Edid.StandardTimings.Timing7, Timing(KnownStandardTiming.Timing7));
        properties.Add(EedidProperty.Edid.StandardTimings.Timing8, Timing(KnownStandardTiming.Timing8));
    }

    #endregion


    #region EDID 1.4 Specification

    /// <summary>
    /// Returns a value that represents the timmings dictionary.
    /// </summary>
    /// <param name="timingDictionary">Timmings dictionary.</param>
    private void PopulatesTimingsTable(IDictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem> timingDictionary)
    {
        var sectionDataArray = RawData.ToArray();
        for (byte n = 0, i = 0x00; i < 0x10; n++, i += 0x02)
        {
            var rawTimming = sectionDataArray.Extract(i, (byte)0x02).ToArray();
            var unUsedTimming = rawTimming.SequenceEqual(new byte[] {0x01, 0x01});
            if (unUsedTimming)
            {
                continue;
            }

            timingDictionary.Add((KnownStandardTiming)n, new StandardTimingIdentifierDescriptorItem(rawTimming));
        }
    }

    /// <summary>
    /// Returns the value that contains the specified key.
    /// </summary>
    /// <param name="timing">Timing to be recovere.</param>
    /// <returns>
    /// Value of the specified timing
    /// </returns>
    private StandardTimingIdentifierDescriptorItem Timing(KnownStandardTiming timing)
    {
        StandardTimingIdentifierDescriptorItem result;

        try
        {
            result = TimingTable[timing];
        }
        catch (KeyNotFoundException)
        {
            return null;
        }

        return result;
    }

    #endregion
}
