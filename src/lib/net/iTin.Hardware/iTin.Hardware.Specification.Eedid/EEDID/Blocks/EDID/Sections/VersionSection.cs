
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections;

// EDID Section: Version & Revision Information
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Length      Description                                         |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Version                   BYTE        Implemented version number.                         |
// |                                                    Note: See Number                                    |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Revision                  BYTE        Implemented revision number.                        |
// |                                                    Note: See Revision                                  |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="EdidSection.Version"/> section of this block <see cref="KnownDataBlock.EDID"/>.
/// </summary> 
internal sealed class VersionSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="VersionSection"/> class with the data in this section untreated.
    /// </summary>
    /// <param name="sectionData">Unprocessed data in this section</param>
    public VersionSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <c>Version</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private new byte Version => RawData[0x00];

    /// <summary>
    /// Gets a value representing the <c>Revision</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Revision => RawData[0x01];

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.Edid.Version.Number, Version);
        properties.Add(EedidProperty.Edid.Version.Revision, Revision);
    }

    #endregion
}
