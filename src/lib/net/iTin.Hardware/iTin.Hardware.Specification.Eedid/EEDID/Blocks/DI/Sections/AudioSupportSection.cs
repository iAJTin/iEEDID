
using System.Collections.ObjectModel;

namespace iTin.Hardware.Specification.Eedid.Blocks.DI.Sections;

// DI Section: Audio Support
// •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                  Lenght     Description                                                                                        |
// •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | 00h          Unused Bytes          9 BYTE     All 9 Bytes are Reserved (Must be set to "00h"). These Bytes may be defined in a future revision   |
// |                                               to the DI-EXT Standard.                                                                            |
// •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="DiSection.AudioSupport"/> section of this block <see cref="KnownDataBlock.DI"/>.
/// </summary> 
internal sealed class AudioSupportSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="AudioSupportSection"/> class with the data from this raw section.
    /// </summary>
    /// <param name="sectionData">Data from this section untreated.</param>
    public AudioSupportSection(ReadOnlyCollection<byte> sectionData) 
        : base(sectionData)
    {
    }

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        properties.Add(EedidProperty.DI.AudioSupport.Data, RawData);
    }

    #endregion
}
