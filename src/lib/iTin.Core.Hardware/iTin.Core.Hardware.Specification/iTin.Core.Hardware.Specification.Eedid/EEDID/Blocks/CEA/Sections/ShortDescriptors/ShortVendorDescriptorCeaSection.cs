
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> que representa la sección Short Vendor Descriptor del bloque Data Block Collection.
    /// </summary> 
    internal sealed class ShortVendorDescriptorCeaSection : BaseDataSection
    {
        #region constructor/s

        #region [public] ShortVendorDescriptorCeaSection(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase.
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.ShortVendorDescriptorCeaSection" />.
        /// </summary>
        /// <param name="sectionData">Datos de esta sección.</param>
        public ShortVendorDescriptorCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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
            VendorDataBlock vendorAllocationDataBlock = new VendorDataBlock(RawData);
            //properties.Add("IEEE Registration Identifier", vendorAllocationDataBlock.IEEERegistrationIdentifier);
            ////properties.Add("Consumer Electronics Control (CEC) physical address", vendorAllocationDataBlock.PhysicalAddress);
            ////properties.Add("Flags", vendorAllocationDataBlock.Flags);
            ////properties.Add("Maximum TMDS clock", vendorAllocationDataBlock.MaxClock);
            //properties.Add("Vendor Specific Payload", vendorAllocationDataBlock.PayLoad);
        }
        #endregion

        #endregion
    }
}
