
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections;

// EDID Section: Established Timings I & II Information.
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Length      Description                                         |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Established Timings I     BYTE        7 6 5 4 3 2 1 0                                     |
// |                                                    1 _ _ _ _ _ _ _ 720 x 400 @ 70Hz - IBM, VGA         |
// |                                                    _ 1 _ _ _ _ _ _ 720 x 400 @ 88Hz - IBM, XGA2        |
// |                                                    _ _ 1 _ _ _ _ _ 640 x 480 @ 60Hz - IBM, VGA         |
// |                                                    _ _ _ 1 _ _ _ _ 640 x 480 @ 67Hz - Apple, Mac II    |
// |                                                    _ _ _ _ 1 _ _ _ 640 x 480 @ 72Hz - VESA             |
// |                                                    _ _ _ _ _ 1 _ _ 640 x 480 @ 75Hz - VESA             |
// |                                                    _ _ _ _ _ _ 1 _ 800 x 600 @ 56Hz - VESA             |
// |                                                    _ _ _ _ _ _ _ 1 800 x 600 @ 60Hz - VESA             |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Established Timings II    BYTE        7 6 5 4 3 2 1 0                                     |
// |                                                    1 _ _ _ _ _ _ _ 800 x  600 @ 72Hz - VESA            |
// |                                                    _ 1 _ _ _ _ _ _ 800 x  600 @ 75Hz - VESA            |
// |                                                    _ _ 1 _ _ _ _ _ 832 x  624 @ 75Hz - Apple, Mac II   |
// |                                                    _ _ _ 1 _ _ _ _ 1024 x  768 @ 87Hz - IBM Interlaced |
// |                                                    _ _ _ _ 1 _ _ _ 1024 x  768 @ 60Hz - VESA           |
// |                                                    _ _ _ _ _ 1 _ _ 1024 x  768 @ 70Hz - VESA           |
// |                                                    _ _ _ _ _ _ 1 _ 1024 x  768 @ 75Hz - VESA           |
// |                                                    _ _ _ _ _ _ _ 1 1280 x 1024 @ 75Hz - VESA           |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 02h          Manufacturer's Timings    BYTE        7 6 5 4 3 2 1 0                                     |
// |                                                    1 _ _ _ _ _ _ _ 1152 x 870 @ 75Hz - Apple, Mac II   |
// |                                                                                                        |
// |                                                    bits 06:00 - Reserved all set to 00h                |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="EdidSection.EstablishedTimings"/> section of this block <see cref="KnownDataBlock.EDID"/>.
/// </summary> 
internal sealed class EstablishedTimingsSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="EstablishedTimingsSection"/> class with the data in this section untreated.
    /// </summary>
    /// <param name="sectionData">Unprocessed data in this section</param>
    public EstablishedTimingsSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
    {
    }

    #endregion

    #region private readonly properties

    #region Established Timings I

    /// <summary>
    /// Gets a value representing <c>Established Timings I</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte EstablishedTimingsI => RawData[0x00];

    /// <summary>
    /// Gets a value representing the <c>720 x 400 @ 70 Hz, IBM, VGA</c> characteristic of <c>Established Timings I</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is720X400X70 => EstablishedTimingsI.CheckBit(Bits.Bit07);

    /// <summary>
    /// Gets a value representing the <c>720 x 400 @ 88 Hz, IBM, XGA2</c> characteristic of <c>Established Timings I</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is720X400X88 => EstablishedTimingsI.CheckBit(Bits.Bit06);

    /// <summary>
    /// Gets a value representing the <c>640 x 480 @ 60 Hz, IBM, VGA</c> characteristic of <c>Established Timings I</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is640X480X60 => EstablishedTimingsI.CheckBit(Bits.Bit05);

    /// <summary>
    /// Gets a value representing the <c>640 x 480 @ 67 Hz, Apple, Mac II</c> characteristic of <c>Established Timings I</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is640X480X67 => EstablishedTimingsI.CheckBit(Bits.Bit04);

    /// <summary>
    /// Gets a value representing the <c>640 x 480 @ 72 Hz, VESA</c> characteristic of <c>Established Timings I</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    private bool Is640X480X72 => EstablishedTimingsI.CheckBit(Bits.Bit03);

    /// <summary>
    /// Gets a value representing the <c>640 x 480 @ 75 Hz, VESA</c> characteristic of <c>Established Timings I</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is640X480X75 => EstablishedTimingsI.CheckBit(Bits.Bit02);

    /// <summary>
    /// Gets a value representing the <c>800 x 600 @ 56 Hz, VESA</c> characteristic of <c>Established Timings I</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is800X600X56 => EstablishedTimingsI.CheckBit(Bits.Bit01);

    /// <summary>
    /// Gets a value representing the <c>800 x 600 @ 60 Hz, VESA</c> characteristic of <c>Established Timings I</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is800X600X60 => EstablishedTimingsI.CheckBit(Bits.Bit00);

    #endregion

    #region Established Timings II

    /// <summary>
    /// Gets a value representing <c>Established Timings II</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte EstablishedTimingsII => RawData[0x01];

    /// <summary>
    /// Gets a value representing the <c>800 x 600 @ 72 Hz, VESA</c> characteristic of <c>Established Timings II</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is800X600X72 => EstablishedTimingsII.CheckBit(Bits.Bit07);

    /// <summary>
    /// Gets a value representing the <c>800 x 600 @ 75 Hz, VESA</c> characteristic of <c>Established Timings II</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is800X600X75 => EstablishedTimingsII.CheckBit(Bits.Bit06);

    /// <summary>
    /// Gets a value representing the <c>832 x 624 @ 75 Hz, Apple, Mac II</c> characteristic of <c>Established Timings II</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is832X624X75 => EstablishedTimingsII.CheckBit(Bits.Bit05);

    /// <summary>
    /// Gets a value representing the <c>1024 x 768 @ 87 Hz, IBM, Interlaced</c> characteristic of <c>Established Timings II</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is1024X768X87I => EstablishedTimingsII.CheckBit(Bits.Bit04);

    /// <summary>
    /// Gets a value representing the <c>1024 x 768 @ 60 Hz, VESA</c> characteristic of <c>Established Timings II</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is1024X768X60 => EstablishedTimingsII.CheckBit(Bits.Bit03);

    /// <summary>
    /// Gets a value representing the <c>1024 x 768 @ 70 Hz, VESA</c> characteristic of <c>Established Timings II</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is1024X768X70 => EstablishedTimingsII.CheckBit(Bits.Bit02);

    /// <summary>
    /// Gets a value representing the <c>1024 x 768 @ 75 Hz, VESA</c> characteristic of <c>Established Timings II</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is1024X768X75 => EstablishedTimingsII.CheckBit(Bits.Bit01);

    /// <summary>
    /// Gets a value representing the <c>1280 x 1024 @ 75 Hz, VESA</c> characteristic of <c>Established Timings II</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is1280X1024X75 => EstablishedTimingsII.CheckBit(Bits.Bit00);

    #endregion

    #region Manufacturer's Timings

    /// <summary>
    /// Gets a value representing <c>Manufacturer's Timings</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte ManufacturerTimings => RawData[0x02];

    /// <summary>
    /// Gets a value representing the <c>1152 x 870 @ 75 Hz, Apple, Mac II</c> characteristic of <c>Manufacturer's Timings</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Is1152X870X75 => ManufacturerTimings.CheckBit(Bits.Bit07);

    #endregion

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.Edid.EstablishedTimings.Resolutions, GetResolutionCollection());
    }

    #endregion


    #region EDID 1.4 Specification

    /// <summary>
    /// Returns an object that represents a collection of available resolutions.
    /// </summary>
    /// <returns>
    /// Collection of available resolutions.
    /// </returns>
    private ReadOnlyCollection<MonitorResolutionInfo> GetResolutionCollection()
    {
        var items = new List<MonitorResolutionInfo>();

        if (Is640X480X60)
        {
            items.Add(new MonitorResolutionInfo(640, 480, 60, "IBM"));
        }

        if (Is640X480X67)
        {
            items.Add(new MonitorResolutionInfo(640, 480, 67, "Apple"));
        }

        if (Is640X480X72)
        {
            items.Add(new MonitorResolutionInfo(640, 480, 72, "VESA"));
        }

        if (Is640X480X75)
        {
            items.Add(new MonitorResolutionInfo(640, 480, 75, "VESA"));
        }

        if (Is720X400X70)
        {
            items.Add(new MonitorResolutionInfo(720, 400, 70, "IBM"));
        }

        if (Is720X400X88)
        {
            items.Add(new MonitorResolutionInfo(720, 400, 88, "IBM"));
        }

        if (Is800X600X56)
        {
            items.Add(new MonitorResolutionInfo(800, 600, 56, "VESA"));
        }

        if (Is800X600X60)
        {
            items.Add(new MonitorResolutionInfo(800, 600, 60, "VESA"));
        }

        if (Is800X600X72)
        {
            items.Add(new MonitorResolutionInfo(800, 600, 72, "VESA"));
        }

        if (Is800X600X75)
        {
            items.Add(new MonitorResolutionInfo(800, 600, 75, "VESA"));
        }

        if (Is832X624X75)
        {
            items.Add(new MonitorResolutionInfo(832, 624, 75, "Apple"));
        }

        if (Is1024X768X60)
        {
            items.Add(new MonitorResolutionInfo(1024, 768, 60, "VESA"));
        }

        if (Is1024X768X70)
        {
            items.Add(new MonitorResolutionInfo(1024, 768, 70, "VESA"));
        }

        if (Is1024X768X75)
        {
            items.Add(new MonitorResolutionInfo(1024, 768, 75, "VESA"));
        }

        if (Is1024X768X87I)
        {
            items.Add(new MonitorResolutionInfo(1024, 768, 87, true, false, "IBM Interlaced"));
        }

        if (Is1152X870X75)
        {
            items.Add(new MonitorResolutionInfo(1152, 870, 75, "Apple"));
        }

        if (Is1280X1024X75)
        {
            items.Add(new MonitorResolutionInfo(1280, 1024, 75, "VESA"));
        }

        return items.AsReadOnly();
    }

    #endregion
}
