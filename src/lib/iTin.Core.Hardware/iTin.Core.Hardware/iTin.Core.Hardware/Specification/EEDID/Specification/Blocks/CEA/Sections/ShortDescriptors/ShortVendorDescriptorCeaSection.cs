
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> que representa la sección Short Vendor Descriptor del bloque Data Block Collection.
    /// </summary> 
    sealed class ShortVendorDescriptorCeaSection : BaseDataSection
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

        #region [protected] {override} (void) Parse(Hashtable): Obtiene la colección de items de esta sección.
        /// <inheritdoc />
        /// <summary>
        /// Obtiene la colección de items de esta sección.
        /// </summary>
        /// <param name="items">Colección de items de esta sección.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        protected override void Parse(Hashtable items)
        {
            #region Comprobar parámetro/s.
            base.Parse(items);
            #endregion

            #region Diccionario de propiedades (PropertyKey / Value).
            var vendorAllocationDataBlock = new VendorDataBlock(RawData);

            items.Add("IEEE Registration Identifier", vendorAllocationDataBlock.IEEERegistrationIdentifier);
            //items.Add("Consumer Electronics Control (CEC) physical address", vendorAllocationDataBlock.PhysicalAddress);
            //items.Add("Flags", vendorAllocationDataBlock.Flags);
            //items.Add("Maximum TMDS clock", vendorAllocationDataBlock.MaxClock);
            items.Add("Vendor Specific Payload", vendorAllocationDataBlock.PayLoad);
            #endregion
        }
        #endregion

        #endregion
    }
}
