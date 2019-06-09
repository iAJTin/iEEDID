
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;

    // Data Block Descriptor: Display Product Serial Number Descriptor Definition
    // 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
    // | Offset       Name                      Lenght      Description                                  |
    // 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
    // | 00h -> 0ch   ASCII                     13 BYTEs    Up to 13 alphanumeric characters of a serial |
    // |              Text                                  number may be stored.                        |
    // 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�

    /// <summary>
    /// Especializaci�n de la clase <see cref="BaseDataSection"/> que representa a un <see cref="KnownEdidSection.DataBlocks"/> de tipo <see cref="KnownEdidDataBlockDescriptor.DisplayProductSerialNumber"/>.
    /// </summary>
    sealed class DisplayProductSerialNumberDescriptor : BaseDataSection
    {
        #region Constructor/es

            #region [public] DisplayProductSerialNumberDescriptor(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de este bloque sin tratar.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="DisplayProductSerialNumberDescriptor"/> con los datos de este bloque sin tratar.
            /// </summary>
            /// <param name="blockData">Datos de este bloque sin tratar.</param>
            public DisplayProductSerialNumberDescriptor(ReadOnlyCollection<byte> blockData) : base(blockData)
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
                var propertyId = (KnownDisplayProductNameDescriptorProperty)propertyKey.PropertyId;

                switch (propertyId)
                {
                    #region [0x00] - [Text] - [String]
                    case KnownDisplayProductNameDescriptorProperty.Text:
                        value = GetAsciiText(RawDataArray);
                        break;
                    #endregion
                }

                return value;
            }
            #endregion

            #region [protected] {override} (void) Parse(Hashtable): Obtiene la colecci�n de items de este bloque.
            /// <summary>
            /// Obtiene la colecci�n de items de este bloque.
            /// </summary>
            /// <param name="items">Colecci�n de items de este bloque.</param>
            [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de m騁odos p�blicos", MessageId = "0")]
            protected override void Parse(Hashtable items)
            {
                #region Comprobar par疥etro/s.
                base.Parse(items);
                #endregion

                #region Diccionario de propiedades (PropertyKey / Value).
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DisplayProductSerialNumber.Text, GetAsciiText(RawDataArray));
                #endregion
            }
            #endregion

        #endregion

        #region Miembros privados

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

        #region EDID 1.4 Specification

            #region [private] {static} (string) GetAsciiText(byte[]): Convierte un array de bytes a su representaci�n ASCII.
            /// <summary>
            /// Convierte un array de bytes a su representaci�n ASCII.
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