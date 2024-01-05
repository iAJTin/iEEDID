
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace iTin.Hardware.Specification.Eedid.Blocks.DI.Sections;

// DI Section: Display Transfer Characteristic
// •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Length      Description                                                                                   |
// •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h                                                                                                                                              |
// •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="DiSection.DisplayTransferCharacteristic"/> section of this block <see cref="KnownDataBlock.DI"/>.
/// </summary> 
internal sealed class DisplayTransferCharacteristicSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="DisplayTransferCharacteristicSection"/> class with the data from this raw section.
    /// </summary>
    /// <param name="sectionData">Data from this section untreated.</param>
    public DisplayTransferCharacteristicSection(ReadOnlyCollection<byte> sectionData)
        : base(sectionData)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <strong>Status And Entries</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte StatusAndNumberLuminanceEntries => RawData[0x00];

    /// <summary>
    /// Gets a value representing the <strong>Combined (White) or Separate (RGB) Sub-Channels</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Status => (byte) (StatusAndNumberLuminanceEntries >> 0x06 & 0x03);

    /// <summary>
    /// Gets a value representing the <strong>Number of Luminance Entries</strong> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte NumberLuminanceEntries => (byte) (StatusAndNumberLuminanceEntries & 0x3f);

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.DI.DisplayTransferCharacteristic.Status, GetStatus(Status));
        properties.Add(EedidProperty.DI.DisplayTransferCharacteristic.NumberLuminanceEntries, NumberLuminanceEntries);
    }

    #endregion


    #region VESA Display Information Extension Block Standard

    private static string GetStatus(byte code) => code switch
    {
        0x00 => "No Display Transfer Characteristics",
        > 0x02 => "Reserved",
        _ => "Contains Display Transfer Characteristics"
    };

    #endregion
}
