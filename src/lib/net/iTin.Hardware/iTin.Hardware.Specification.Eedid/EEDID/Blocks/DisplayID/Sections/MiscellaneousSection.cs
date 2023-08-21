
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections;

// DI Section: Miscellaneous
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Lenght      Description                                         |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          CheckSum                  BYTE        Note: Please see, Status                            |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="DisplayIdSection.Miscellaneous"/> section of this block <see cref="KnownDataBlock.DisplayID"/>.
/// </summary> 
internal sealed class MiscellaneousSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="GeneralSection"/> class with the data in this section untreated with version block.
    /// </summary>
    /// <param name="sectionData">Unprocessed data in this section</param>
    /// <param name="version">Block version.</param>
    public MiscellaneousSection(ReadOnlyCollection<byte> sectionData, int? version = null) 
        : base(sectionData, version)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value that represents the <b>Status</b> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Status => RawData.Aggregate(0, (current, t) => current + t) % 256 == 0;

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.DisplayID.Miscellaneous.CheckSum.Ok, Status);
        properties.Add(EedidProperty.DisplayID.Miscellaneous.CheckSum.Value, RawData.Take(RawData.Count - 1).LastOrDefault());
    }

    #endregion
}
