
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;

    // CEA Section: CheckSum
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          CheckSum                  BYTE        Note: Please see, Status                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> que representa la sección <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownCeaSection.CheckSum" /> de este bloque <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.CEA" />.
    /// </summary> 
    sealed class CheckSumCeaSection : BaseDataSection
    {
        #region constructor/s

        #region [public] CheckSumCeaSection(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de esta sección sin tratar.
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.CheckSumCeaSection" /> con los datos de esta sección sin tratar.
        /// </summary>
        /// <param name="sectionData">Datos de esta sección sin tratar.</param>
        public CheckSumCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (bool) Status: Obtiene un valor que representa al campo 'Status'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Status</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Status
        {
            get
            {
                int checksum = 0;

                for (int i = 0; i < 0x80; i++)
                {
                    checksum += RawData[i];
                }

                bool status = (checksum % 256 == 0);
                return status;
            }
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Obtiene un valor que representa el valor de la propiedad especificada.
        /// <summary>
        /// Obtiene un valor que representa el valor de la propiedad especificada.
        /// </summary>
        /// <param name="propertyKey">Clave de la propiedad a obtener.</param>
        /// <returns></returns>
        protected override object GetValueTypedProperty(PropertyKey propertyKey)
        {
            object value = null;
            var propertyId = (KnownCeaCheckSumProperty)propertyKey.PropertyId;
            switch (propertyId)
            {
                #region [0x00] - [Ok] - [Boolean]
                case KnownCeaCheckSumProperty.Ok:
                    value = Status;
                    break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(Hashtable): Obtiene la colección de items de esta sección.
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
            items.Add(KnownEedidPropertiesDefinition.Cea.CheckSum.Ok, Status);
            #endregion
        }
        #endregion

        #endregion
    }
}
