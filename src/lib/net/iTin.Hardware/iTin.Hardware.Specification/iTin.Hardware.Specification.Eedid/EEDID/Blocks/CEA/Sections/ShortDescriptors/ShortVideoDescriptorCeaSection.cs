
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the Short Video Descriptor section of the Data Block Collection block.
    /// </summary> 
    internal sealed class ShortVideoDescriptorCeaSection : BaseDataSection
    {
        #region constructor/s

        #region [public] ShortVideoDescriptorCeaSection(ReadOnlyCollection<byte>): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the <see cref="ShortVideoDescriptorCeaSection"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Raw data of this section.</param>
        public ShortVideoDescriptorCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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
