
namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks
{
    using System.Collections.ObjectModel;
    using System.Linq;

    using iTin.Core;

    using ComponentModel;

    // Data Block: Display Parameters Data Block v1.3
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                    Lenght      Description                                                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          TAG                     BYTE        7Fh                                                          |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Block Revision and      BYTE         Bits    Value                                               |
    // |              Other Data                          07:03    Reserved (Cleared to all 0s)                        |
    // |                                                  02:00    Block Revision, 000b Rev. 0 (default)               |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Number of Payload       BYTE        12h                                                          |
    // |              Bytes in Block                                                                                   |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          Horizontal Image Size   WORD        Horizontal Image Size.                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Vertical Image Size     WORD        Vertical Image Size.                                         |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Horizontal Pixel Count  WORD        Horizontal Pixel Count.                                      |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Vertical Pixel Count    WORD        Vertical Pixel Count.                                        |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh          Feature Support Flags   BYTE        Feature Support Flags.                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch          GAMMA                   BYTE        Transfer Characteristic Gamma.                               |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Dh          Aspect Ratio            BYTE        Aspect Ratio.                                                |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 12h          Color Bit Depth         BYTE        Color Bit Depth.                                             |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    // Data Block: Display Parameters Data Block v2.0
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                    Lenght      Description                                                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          TAG                     BYTE        7Eh                                                          |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Block Revision and      BYTE         Bits    Value                                               |
    // |              Other Data                             07    Image Size Multiplier                               |
    // |                                                           0   Horizontal And Vertical Image Size have 0.1mm   |
    // |                                                               precision (default)                             |
    // |                                                           1   Horizontal And Vertical Image Size have 1.0mm   |
    // |                                                               precision                                       |
    // |                                                  06:03    Reserved (Cleared to all 0s)                        |
    // |                                                  02:00    Block Revision, 000b Rev. 0 (default)               |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Number of Payload       BYTE        1Dh                                                          |
    // |              Bytes in Block                                                                                   |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          Horizontal Image Size   WORD        Horizontal Image Size.                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Vertical Image Size     WORD        Vertical Image Size.                                         |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Horizontal Pixel Count  WORD        Horizontal Pixel Count.                                      |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Vertical Pixel Count    WORD        Vertical Pixel Count.                                        |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Bh          Feature Support Flags   BYTE        Feature Support Flags.                                       |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ch          Native Color            3-BYTE      Native Color Chromaticity (Primary Color 1 Chromaticity).    |
    // |              Chromaticity                        Descriptor.                                                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Fh          Native Color            3-BYTE      Native Color Chromaticity (Primary Color 2 Chromaticity).    |
    // |              Chromaticity                        Descriptor.                                                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 12h          Native Color            3-BYTE      Native Color Chromaticity (Primary Color 3 Chromaticity).    |
    // |              Chromaticity                        Descriptor.                                                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 15h          Native Color            3-BYTE      Native Color Chromaticity (White Point Chromaticity).        |
    // |              Chromaticity                        Descriptor.                                                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 18h          Native Maximum          WORD        Native Maximum Luminance (Full Coverage).                    |
    // |              Luminance                           Descriptor.                                                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 1Ah          Native Maximum          WORD        Native Maximum Luminance (10% Rectangular Coverage).         |
    // |              Luminance                           Descriptor.                                                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 1Ch          Native Minimum          WORD        Native Minimum Luminance.                                    |
    // |              Luminance                           Descriptor.                                                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 1Eh          Native Color Depth      BYTE        Native Color Depth and Display Device Technology.            |
    // |              and Display Device                  Descriptor.                                                  |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 1Fh          GAMMA                   BYTE        Native Gamma EOTF.                                           |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents a data block of type <see cref="DataBlockTag.DisplayParameters"/>.
    /// </summary> 
    internal sealed class DisplayParametersDataBlock : BaseDataSection
    {
        #region constructor/s

        #region [public] DisplayParametersDataBlock(ReadOnlyCollection<byte>, int? = null): Initialize a new instance of the class with the data of this block untreated with version block
        /// <summary>
        /// Initialize a new instance of the <see cref="DisplayParametersDataBlock"/> class with the data of this block untreated with version block.
        /// </summary>
        /// <param name="dataBlock">Unprocessed data in this block</param>
        /// <param name="version">Block version.</param>
        public DisplayParametersDataBlock(ReadOnlyCollection<byte> dataBlock, int? version = null) : base(dataBlock, version)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
        }
        #endregion

        #endregion
    }
}
