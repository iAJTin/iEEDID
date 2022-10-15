
using System.Collections.ObjectModel;

using iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors.DataBlocks;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors
{
    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the Short Video Descriptor section of the Data Block Collection block.
    /// </summary> 
    internal sealed class ShortVideoDescriptorSection : BaseDataSection
    {
        #region constructor/s

        #region [public] ShortVideoDescriptorSection(ReadOnlyCollection<byte>): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the <see cref="ShortVideoDescriptorSection"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Raw data of this section.</param>
        public ShortVideoDescriptorSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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
            VideoDataBlock videoAllocationDataBlock = new VideoDataBlock(RawData);
            properties.Add(EedidProperty.Cea.DataBlock.Video.SupportedTimings, new ReadOnlyCollection<string>(videoAllocationDataBlock.GetSupportTimmings()));
        }
        #endregion

        #endregion
    }
}
