
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections;

// EDID Section: CheckSum
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Length      Description                                         |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          CheckSum                  BYTE        Note: Ver Status                                    |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="EdidSection.Checksum"/> section of this block <see cref="KnownDataBlock.EDID"/>.
/// </summary> 
internal sealed class ChecksumSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="ChecksumSection"/> class with the data in this section untreated.
    /// </summary>
    /// <param name="sectionData">Unprocessed data in this section</param>
    public ChecksumSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value that represents the <c>Status</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool Status
    {
        get
        {
            var checksum = 0;

            for (var i = 0; i < 0x80; i++)
            {
                checksum += RawData[i];
            }

            return checksum % 256 == 0;
        }
    }

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.Edid.CheckSum.Value, RawData.Take(128).LastOrDefault());
        properties.Add(EedidProperty.Edid.CheckSum.Ok, Status);
    }

    #endregion
}
