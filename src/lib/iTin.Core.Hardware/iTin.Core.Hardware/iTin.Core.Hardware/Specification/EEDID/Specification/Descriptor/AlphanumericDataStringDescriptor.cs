
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;

    // Data Block Descriptor: Alphanumeric Data String Descriptor Definition
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                  |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h -> 0ch   ASCII                     13 BYTEs    Up to 13 alphanumeric characters of a data   |
    // |              Text                                  string may be stored.                        |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Especialización de la clase <see cref="BaseDataSection"/> que representa a un <see cref="KnownEdidSection.DataBlocks"/> de tipo <see cref="KnownEdidDataBlockDescriptor.AlphaNumericDataString"/>.
    /// </summary>
    sealed class AlphaNumericDataStringDescriptor : BaseDataSection
    {
        #region Constructor/s

        #region [public] AlphaNumericDataStringDescriptor(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase.
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="AlphaNumericDataStringDescriptor"/> con los datos de este bloque sin tratar.
        /// </summary>
        /// <param name="blockData">Datos de este bloque sin tratar.</param>
        public AlphaNumericDataStringDescriptor(ReadOnlyCollection<byte> blockData) : base(blockData)
        {
        }
        #endregion

        #endregion

        #region Overrides

        #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Obtiene un valor que representa el valor de la propiedad especificada.
        /// <summary>
        /// Obtiene un valor que representa el valor de la propiedad especificada.
        /// </summary>
        /// <param name="propertyKey">Clave de la propiedad a obtener.</param>
        /// <returns></returns>
        protected override object GetValueTypedProperty(PropertyKey propertyKey)
        {
            object value = null;
            var propertyId = (KnownAlphanumericDataStringDescriptorProperty)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x00] - [Text] - [String]
                case KnownAlphanumericDataStringDescriptorProperty.Text:
                    value = GetAsciiText(RawDataArray);
                    break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(Hashtable): Obtiene la colección de items de este bloque.
        /// <summary>
        /// Obtiene la colección de items de este bloque.
        /// </summary>
        /// <param name="items">Colección de items de este bloque.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        protected override void Parse(Hashtable items)
        {
            #region Comprobar parámetro/s.
            base.Parse(items);
            #endregion

            #region Diccionario de propiedades (PropertyKey / Value).
            items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.AlphanumericDataString.Text, GetAsciiText(RawDataArray));
            #endregion
        }
        #endregion

        #endregion

        #region Miembros privados.

        #region [private] (byte[]) RawDataArray: Obtiene un valor que representa al campo 'ASCII Text'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>ASCII Text</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/>[]</para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte[] RawDataArray
        {
            get { return RawData.ToArray(); }
        }
        #endregion

        #endregion

        #region EDID 1.4 Specification.

        #region [private] {static} (string) GetAsciiText(byte[]): Convierte un array de bytes a su representación ASCII.
        /// <summary>
        /// Convierte un array de bytes a su representación ASCII.
        /// </summary>
        /// <param name="rawDataArray">Valor a analizar.</param>
        /// <returns>
        /// Cadena que representa al array.
        /// </returns>
        private static string GetAsciiText(byte[] rawDataArray)
        {
            return Encoding.ASCII.GetString(rawDataArray, 0x00, rawDataArray.Count());
        }
        #endregion

        #endregion
    }
}