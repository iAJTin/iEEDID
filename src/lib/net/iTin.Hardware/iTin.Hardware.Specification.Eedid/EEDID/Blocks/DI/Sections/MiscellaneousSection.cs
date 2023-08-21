
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace iTin.Hardware.Specification.Eedid.Blocks.DI.Sections;

// DI Section: Miscellaneous
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Lenght      Description                                         |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          CheckSum                  BYTE        Note: Please see, Status                            |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="DiSection.Miscellaneous"/> section of this block <see cref="KnownDataBlock.DI"/>.
/// </summary> 
internal sealed class MiscellaneousSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="MiscellaneousSection"/> class with the data from this raw section.
    /// </summary>
    /// <param name="sectionData">Data from this section untreated.</param>
    public MiscellaneousSection(ReadOnlyCollection<byte> sectionData) 
        : base(sectionData)
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
    private bool Status
    {
        get
        {
            int checksum = 0;

            for (int i = 0; i < 0x80; i++)
            {
                checksum += RawData[i];
            }

            bool status = checksum % 256 == 0;
            return status;
        }
    }

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.DI.Miscellaneous.Checksum.Value, RawData.LastOrDefault());
        properties.Add(EedidProperty.DI.Miscellaneous.Checksum.Ok, Status);
    }

    #endregion
}
