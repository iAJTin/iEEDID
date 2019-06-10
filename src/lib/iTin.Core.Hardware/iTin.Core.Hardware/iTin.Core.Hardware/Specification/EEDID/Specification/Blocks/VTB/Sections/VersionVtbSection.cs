
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> que representa la sección <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownVtbSection.Version" /> de este bloque <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.VTB" />.
    /// </summary> 
    sealed class VersionVtbSection : BaseDataSection
    {
        #region constructor/s

        #region [public] VersionVtbSection(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de esta sección sin tratar.
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.VersionVtbSection" /> con los datos de esta sección sin tratar.
        /// </summary>
        /// <param name="sectionData">Datos de esta sección sin tratar.</param>
        public VersionVtbSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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
            items.Add("Version", RawData[0x01]);
            #endregion
        }
        #endregion

        #endregion
    }
}
