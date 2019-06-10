
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    // Data Block Descriptor: Color Management Data Descriptor Definition
    // •—————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                  |
    // •—————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Version Number            BYTE        03h. Other values reserved.  |
    // •—————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Red                       QWORD       Note: Ver Color(KnownColor)  |
    // •—————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Green                     QWORD       Note: Ver Color(KnownColor)  |
    // •—————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Blue                      QWORD       Note: Ver Color(KnownColor)  |
    // •—————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Especialización de la clase <see cref="BaseDataSection"/> que representa a un <see cref="KnownEdidSection.DataBlocks"/> de tipo <see cref="KnownEdidDataBlockDescriptor.ColorManagementData"/>.
    /// </summary>
    sealed class ColorManagementDataDescriptor : BaseDataSection
    {
        #region Enumeraciones

            #region [public] (enum) KnownColor: Colores conocidos para este bloque.
            /// <summary>
            /// Colores conocidos para este bloque.
            /// </summary> 
            public enum KnownColor
            {
                /// <summary>
                /// Color rojo.
                /// </summary>
                Red,
                /// <summary>
                /// Color verde.
                /// </summary>
                Green,
                /// <summary>
                /// Color azul.
                /// </summary>
                Blue,
                /// <summary>
                /// Color blanco.
                /// </summary>
                White,
            }
            #endregion

        #endregion

        #region Declaraciones
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<KnownColor, ColorManagementDataDescriptorItem> _colorTable;
        #endregion

        #region Constructor/es

            #region [public] ColorManagementDataDescriptor(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de este bloque sin tratar.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="ColorManagementDataDescriptor"/> con los datos de este bloque sin tratar.
            /// </summary>
            /// <param name="blockData">Datos de este bloque sin tratar.</param>
            public ColorManagementDataDescriptor(ReadOnlyCollection<byte> blockData) : base(blockData)
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
                var propertyId = (KnownColorManagementDataDescriptorProperty)propertyKey.PropertyId;

                switch (propertyId)
                {
                    #region [0x00] - [Version Number] - [Byte]
                    case KnownColorManagementDataDescriptorProperty.Version:
                        value = VersionNumber;
                        break;
                    #endregion

                    #region [0x01] - [Color Red] - [ColorManagementDataDescriptorItem]
                    case KnownColorManagementDataDescriptorProperty.Red:
                        value = Color(KnownColor.Red);
                        break;
                    #endregion

                    #region [0x02] - [Color Green] - [ColorManagementDataDescriptorItem]
                    case KnownColorManagementDataDescriptorProperty.Green:
                        value = Color(KnownColor.Green);
                        break;
                    #endregion

                    #region [0x03] - [Color Blue] - [ColorManagementDataDescriptorItem]
                    case KnownColorManagementDataDescriptorProperty.Blue:
                        value = Color(KnownColor.Blue);
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
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.ColorManagementData.VersionNumber, VersionNumber);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.ColorManagementData.Red, Color(KnownColor.Red));
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.ColorManagementData.Green, Color(KnownColor.Green));
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.ColorManagementData.Blue, Color(KnownColor.Blue));
                #endregion
            }
            #endregion

        #endregion

        #region Miembros privados

            #region Propiedades

                #region [private] (Dictionary<KnownColor, ColorManagementDataDescriptorItem>) ColorTable: Obtiene un valor que representa un diccionario de colores.
                /// <summary>
                /// Obtiene un valor que representa un diccionario diccionario de colores.
                /// </summary>
                /// <value>
                /// Diccionario que contiene el par color / Valor de la mismo.
                /// </value>e>
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                private Dictionary<KnownColor, ColorManagementDataDescriptorItem> ColorTable
                {
                    get
                    {
                        if (_colorTable == null)
                        {
                            _colorTable = new Dictionary<KnownColor, ColorManagementDataDescriptorItem>();
                            GetColorTable(_colorTable);
                        }
                        return _colorTable;
                    }
                }
                #endregion

                #region [private] (byte) VersionNumber: Obtiene un valor que representa al campo 'Version Number'.
                /// <summary>
                /// Obtiene un valor que representa al campo '<c>Version Number</c>'.
                /// </summary>
                /// <value>
                ///   <para>Tipo: <see cref="T:System.Byte"/></para>
                ///   <para>Valor de la propiedad.</para>
                /// </value>
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                private byte VersionNumber
                {
                    get { return RawData[0x00]; }
                }
                #endregion

            #endregion

            #region Métodos

                #region [private] (ColorManagementDataDescriptorItem) Priority(KnownCVT3ByteCodePriority): Obtiene el valor que contiene la clave especificada.
                /// <summary>
                /// Obtiene el valor que contiene la clave especificada.
                /// </summary>
                /// <param name="color">Color que se va a recuperar.</param>
                /// <returns>
                /// 	<para>Tipo: <see cref="ColorManagementDataDescriptorItem"/></para>
                /// 	<para>Valor del color especificado</para>
                /// </returns>
                private ColorManagementDataDescriptorItem Color(KnownColor color)
                {
                    ColorManagementDataDescriptorItem result;
                    try
                    {
                        result = ColorTable[color];
                    }
                    catch (KeyNotFoundException)
                    {
                        return null;
                    }
                    return result;
                }
                #endregion

                #region [private] (void) GetColorTable(IDictionary<KnownColor, ColorManagementDataDescriptorItem>): Obtiene un valor que representa al diccionario de colores.
                /// <summary>
                /// Obtiene un valor que representa al diccionario de colores.
                /// </summary>
                /// <param name="colorDictionary">Diccionario de colores.</param>
                private void GetColorTable(IDictionary<KnownColor, ColorManagementDataDescriptorItem> colorDictionary)
                {
                    var colorArray = new byte[0x04];
                    byte[] sectionDataArray = RawData.ToArray();

                    for (int n = 0, i = 0x01; i < 0x0c; i += 0x04)
                    {
                        Array.Copy(sectionDataArray, i, colorArray, 0x00, 0x04);
                        var colorCollection = new ReadOnlyCollection<byte>(colorArray);
                        var color = new ColorManagementDataDescriptorItem(colorCollection);
                        colorDictionary.Add((KnownColor)n, color);
                        n++;
                    }
                }
                #endregion

            #endregion

        #endregion
    }
}