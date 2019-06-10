
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;

    // Data Block Descriptor: Dummy Data Descriptor Definition
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                  |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h -> 0ch   Dummy Data                13 BYTEs    All bytes filled with 00h                    |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Especialización de la clase <see cref="BaseDataSection"/> que representa a un <see cref="KnownEdidSection.DataBlocks"/> de tipo <see cref="KnownEdidDataBlockDescriptor.DummyData"/>.
    /// </summary>
    sealed class DummyDataDescriptor : BaseDataSection
    {
        #region Constructor/es

            #region [public] DummyDataDescriptor(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de este bloque sin tratar.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="DummyDataDescriptor"/> con los datos de este bloque sin tratar.
            /// </summary>
            /// <param name="blockData">Datos de este bloque sin tratar.</param>
            public DummyDataDescriptor(ReadOnlyCollection<byte> blockData) : base(blockData)
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
                var propertyId = (KnownDummyDataDescriptorProperty)propertyKey.PropertyId;

                switch (propertyId)
                {
                    #region [0x00] - [Dummy Data] - [ReadOnlyCollection<Byte>]
                    case KnownDummyDataDescriptorProperty.Data:
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
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DummyData.Data, RawData);
                #endregion
            }
            #endregion

        #endregion
    }
}