
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections;

// EDID Section: Extension Blocks 
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Lenght      Description                                         |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Count                     BYTE        Number of extension blocks.                         |
// |                                                    Note: See Count                                     |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 01h          Has Blocks                BYTE        Indicates if there are extension blocks.            |
// |                                                    Note: See HasBlocks                                 |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="EdidSection.ExtensionBlocks"/> section of this block <see cref="KnownDataBlock.EDID"/>.
/// </summary> 
internal sealed class ExtensionBlocksSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="ExtensionBlocksSection"/> class with the data in this section untreated.
    /// </summary>
    /// <param name="sectionData">Unprocessed data in this section</param>
    public ExtensionBlocksSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
    {
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value representing the <c>Count</c> field.
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private byte Count => RawData[0x00];

    /// <summary>
    /// Gets a value representing the '<c>Has Blocks</c>' field
    /// </summary>
    /// <value>
    /// Property value.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool HasBlocks => Count > 0;

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.Edid.ExtensionBlocks.Count, Count);
        properties.Add(EedidProperty.Edid.ExtensionBlocks.HasBlocks, HasBlocks);
    }

    #endregion
}
