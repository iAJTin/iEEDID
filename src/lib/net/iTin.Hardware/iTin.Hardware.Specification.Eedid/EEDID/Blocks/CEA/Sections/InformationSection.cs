
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections;

// CEA Section: Information
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Lenght      Description                                         |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Revision                  BYTE        Número de versión implementada.                     |
// |                                                    Note: Please see, Revision                          |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Implemented               BYTE        Descripción de la versión implementada.             |
// |                                                    Note: Please see, Implemented                       |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="CeaSection.Information"/> section of this block <see cref="KnownDataBlock.CEA"/>.
/// </summary> 
internal sealed class InformationSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="InformationSection"/> class with the data from this raw section.
    /// </summary>
    /// <param name="sectionData">Data from this section untreated.</param>
    public InformationSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <b>Revision</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Revision => RawData[0x00];

    /// <summary>
    /// Gets a value representing the <b>Implemented</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string Implemented =>
        Revision switch
        {
            0x01 => "EIA/CEA-861",
            0x02 => "EIA/CEA-861A",
            0x03 => "EIA/CEA-861B",
            _ => "Unknown"
        };

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.Cea.Information.Revision, Revision);
        properties.Add(EedidProperty.Cea.Information.Implemented, Implemented);
    }

    #endregion
}
