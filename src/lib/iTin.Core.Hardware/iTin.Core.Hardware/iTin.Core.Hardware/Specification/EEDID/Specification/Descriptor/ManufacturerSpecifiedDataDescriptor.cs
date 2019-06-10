using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace iTin.Core.Hardware.Specification.Eedid
{
    // Data Block Descriptor: Manufacturer Spedified Data Descriptor Definition
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                  |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h -> 0ch   Manufacturer              13 BYTEs    Manufacturer Specifies the data stored in    |
    // |              Data                                  bytes.                                       |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Especialización de la clase <see cref="BaseDataSection"/> que representa a un <see cref="KnownEdidSection.DataBlocks"/> de tipo <see cref="KnownEdidDataBlockDescriptor.ManufacturerSpecifiedData"/>.
    /// </summary>
    sealed class ManufacturerSpecifiedDataDescriptor : BaseDataSection
    {
        #region Constructor/es

            #region [public] ManufacturerSpecifiedDataDescriptor(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="ManufacturerSpecifiedDataDescriptor"/> con los datos de este bloque sin tratar.
            /// </summary>
            /// <param name="blockData">Datos de este bloque sin tratar.</param>
            public ManufacturerSpecifiedDataDescriptor(ReadOnlyCollection<byte> blockData) : base(blockData)
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
                var propertyId = (KnownManufacturerSpecifiedDataDescriptorProperty)propertyKey.PropertyId;

                switch (propertyId)
                {
                    #region [0x00] - [Manufacturer Data] - [ReadOnlyCollection<Byte>]
                    case KnownManufacturerSpecifiedDataDescriptorProperty.Data:
                        value = RawData;
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
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.ManufacturerSpecifiedData.Data, RawData);
                #endregion
            }
            #endregion

        #endregion
    }
}