
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

        #region [public] ShortVideoDescriptorCeaSection(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase.
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="ShortVideoDescriptorCeaSection"/>.
        /// </summary>
        /// <param name="sectionData">Datos de esta sección.</param>
        public ShortVideoDescriptorCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
            VideoDataBlock videoAllocationDataBlock = new VideoDataBlock(RawData);
            //properties.Add("Supported Timings", videoAllocationDataBlock.GetSupportTimmings());
        }
        #endregion

        #endregion
    }
}
