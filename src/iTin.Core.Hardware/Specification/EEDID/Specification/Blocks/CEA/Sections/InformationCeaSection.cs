
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;

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
    sealed class InformationCeaSection : BaseDataSection
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

        #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Obtiene un valor que representa el valor de la propiedad especificada.
        /// <inheritdoc />
        /// <summary>
        /// Obtiene un valor que representa el valor de la propiedad especificada.
        /// </summary>
        /// <param name="propertyKey">Clave de la propiedad a obtener.</param>
        /// <returns>
        /// </returns>
        protected override object GetValueTypedProperty(PropertyKey propertyKey)
        {
            object value = null;
            var propertyId = (KnownCeaInformationProperty)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x00] - [Revision] - [Byte]
                case KnownCeaInformationProperty.Revision:
                    value = Revision;
                    break;
                #endregion

                #region [0x01] - [Implemented] - [String]
                case KnownCeaInformationProperty.Implemented:
                    value = Implemented;
                    break;
                #endregion
            }

            return value;
        }
        #endregion

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
            items.Add(KnownEedidPropertiesDefinition.Cea.Information.Revision, Revision);
            items.Add(KnownEedidPropertiesDefinition.Cea.Information.Implemented, Implemented);
            #endregion
        }
        #endregion

        #endregion
    }
}
