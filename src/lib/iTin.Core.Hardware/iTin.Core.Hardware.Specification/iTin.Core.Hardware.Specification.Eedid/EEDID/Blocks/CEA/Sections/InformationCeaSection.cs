
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    // CEA Section: Information
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Revision                  BYTE        Número de versión implementada.                     |
    // |                                                    Note: Please see, Revision                          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Implemented               BYTE        Descripción de la versión implementada.             |
    // |                                                    Note: Please see, Implemented                       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> que representa la sección <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownCeaSection.Information" /> de este bloque <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.CEA" />.
    /// </summary> 
    internal sealed class InformationCeaSection : BaseDataSection
    {
        #region constructor/s

        #region [public] InformationCeaSection(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de esta sección sin tratar.
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="InformationCeaSection"/> con los datos de esta sección sin tratar.
        /// </summary>
        /// <param name="sectionData">Datos de esta sección sin tratar.</param>
        public InformationCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) Revision: Obtiene un valor que representa al campo 'Revision'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Revision</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Revision => RawData[0x00];

        #endregion

        #region [private] (string) Implemented: Obtiene un valor que representa al campo 'Implemented'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Implemented</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.String"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string Implemented
        {
            get
            {
                int revision = Revision;
                switch (revision)
                {
                    case 0x01:
                        return "EIA/CEA-861";

                    case 0x02:
                        return "EIA/CEA-861A";

                    case 0x03:
                        return "EIA/CEA-861B";

                    default:
                        return "Unknown";
                }
            }
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
            properties.Add(EedidProperty.Cea.Information.Revision, Revision);
            properties.Add(EedidProperty.Cea.Information.Implemented, Implemented);
        }
        #endregion

        #endregion
    }
}
