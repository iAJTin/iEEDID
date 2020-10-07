
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Hardware.Specification.Eedid.BaseDataSection" /> que representa la sección <see cref="F:iTin.Hardware.Specification.Eedid.KnownDiSection.Version" /> de este bloque <see cref="F:iTin.Hardware.Specification.Eedid.KnownDataBlock.DI" />.
    /// </summary> 
    internal sealed class VersionDiSection : BaseDataSection
    {
        #region constructor/s

        #region [public] VersionDiSection(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de esta sección sin tratar.
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Hardware.Specification.Eedid.VersionDiSection" /> con los datos de esta sección sin tratar.
        /// </summary>
        /// <param name="sectionData">Datos de esta sección sin tratar.</param>
        public VersionDiSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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
            //properties.Add("Version", RawData[0x01]);
        }
        #endregion

        #endregion
    }
}
