
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

using iTin.Core;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections;

// EDID Section: Header
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Length      Description                                         |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Header                    8 BYTES     Must be: 00h, ffh, ffh, ffh, ffh, ffh, ffh, 00h     |
// |                                                    Note: See Header                                    |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="EdidSection.Header"/> section of this block <see cref="KnownDataBlock.EDID"/>.
/// </summary> 
internal sealed class HeaderSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="HeaderSection"/> class with the data in this section untreated.
    /// </summary>
    /// <param name="sectionData">Unprocessed data in this section</param>
    public HeaderSection(ReadOnlyCollection<byte> sectionData) 
        : base(sectionData)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <c>Signature</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte[] Signature => RawData.Extract((byte)0x00, (byte)0x08).ToArray();

    /// <summary>
    /// Gets a value representing the <c>IsValid</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool IsValid => Signature.SequenceEqual(new byte[] { 0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00 });

    #endregion

    #region protected overide methods

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.Edid.Header.IsValid, IsValid);
        properties.Add(EedidProperty.Edid.Header.Signature, new ReadOnlyCollection<byte>(Signature));
    }

    #endregion
}
