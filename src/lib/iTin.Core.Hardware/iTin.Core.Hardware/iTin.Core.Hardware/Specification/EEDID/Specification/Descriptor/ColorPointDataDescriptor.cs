
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    // Data Block Descriptor: Color Point Descriptor Definition
    // •———————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                  Lenght              Description                            |
    // •———————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Additional Color      ColorPointInfo      Note:  Ver ColorPoint(KnownColorPoint) |
    // |              Point 1                                                                          |
    // •———————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Additional Color      ColorPointInfo      Note:  Ver ColorPoint(KnownColorPoint) |
    // |              Point 2                                                                          |
    // •———————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Especialización de la clase <see cref="BaseDataSection"/> que representa a un <see cref="KnownEdidSection.DataBlocks"/> de tipo <see cref="KnownEdidDataBlockDescriptor.ColorPointData"/>.
    /// </summary>
    sealed class ColorPointDataDescriptor : BaseDataSection
    {
        #region Enumeraciones

            #region [private] (enum) KnownColorPoint: Enumeración de colores conocidos para este bloque.
            /// <summary>
            /// Enumeración de colores conocidos para este bloque.
            /// </summary> 
            enum KnownColorPoint
            {
                /// <summary>
                /// Color rojo.
                /// </summary>
                Point1,
                /// <summary>
                /// Color verde.
                /// </summary>
                Point2,
            }
            #endregion

        #endregion

        #region Declaraciones
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<KnownColorPoint, ColorPointDataDescriptorItem> _colorPointTable;
        #endregion

        #region Constructor/es

            #region [public] ColorPointDataDescriptor(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de este bloque sin tratar.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="ColorPointDataDescriptor"/> con los datos de este bloque sin tratar.
            /// </summary>
            /// <param name="blockData">Datos de este bloque sin tratar.</param>
            public ColorPointDataDescriptor(ReadOnlyCollection<byte> blockData) : base(blockData)
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
                var propertyId = (KnownColorPointDataDescriptorProperty)propertyKey.PropertyId;

                switch (propertyId)
                {
                    #region [0x00] - [Color Point 1] - [AdditionalColorPointInfo]
                    case KnownColorPointDataDescriptorProperty.Point1:
                        value = ColorPoint(KnownColorPoint.Point1);
                        break;
                    #endregion

                    #region [0x01] - [Color Point 2] - [AdditionalColorPointInfo]
                    case KnownColorPointDataDescriptorProperty.Point2:
                        value = ColorPoint(KnownColorPoint.Point2);
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
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.ColorPointData.Point1, ColorPoint(KnownColorPoint.Point1));
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.ColorPointData.Point2, ColorPoint(KnownColorPoint.Point2));
                #endregion
            }
            #endregion

        #endregion

        #region Miembros privados

            #region Propiedades

                #region [private] (Dictionary<KnownColorPoint, ColorPointDataDescriptorItem>) ColorPointTable: Obtiene un valor que representa un diccionario de Color Point.
                /// <summary>
                /// Obtiene un valor que representa un diccionario diccionario de Color Point.
                /// </summary>
                /// <value>
                /// Diccionario que contiene el par Color Point / Valor del mismo.
                /// </value>e>
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                private Dictionary<KnownColorPoint, ColorPointDataDescriptorItem> ColorPointTable
                {
                    get
                    {
                        if (_colorPointTable == null)
                        {
                            _colorPointTable = new Dictionary<KnownColorPoint, ColorPointDataDescriptorItem>();
                            GetAdditionalColorPointTable(_colorPointTable);
                        }
                        return _colorPointTable;
                    }
                }
                #endregion

            #endregion

            #region Métodos

                #region [private] (ColorPointDataDescriptorItem) ColorPoint(KnownColorPoint): Obtiene el valor que contiene la clave especificada.
                /// <summary>
                /// Obtiene el valor que contiene la clave especificada.
                /// </summary>
                /// <param name="timing">Additional color que se va a recuperar.</param>
                /// <returns>
                /// 	<para>Tipo: <see cref="ColorPointDataDescriptorItem"/></para>
                /// 	<para>Valor del additional color especificado.</para>
                /// </returns>
                private ColorPointDataDescriptorItem ColorPoint(KnownColorPoint timing)
                {
                    ColorPointDataDescriptorItem result;
                    try
                    {
                        result = ColorPointTable[timing];
                    }
                    catch (KeyNotFoundException)
                    {
                        return null;
                    }
                    return result;
                }
                #endregion

                #region [private] (void) GetAdditionalColorPointTable(IDictionary<KnownColorPoint, ColorPointDataDescriptorItem>): Obtiene un valor que representa al diccionario de Color Point.
                /// <summary>
                /// Obtiene un valor que representa al diccionario de Color Point.
                /// </summary>
                /// <param name="colorPointDictionary">Diccionario de color point.</param>
                private void GetAdditionalColorPointTable(IDictionary<KnownColorPoint, ColorPointDataDescriptorItem> colorPointDictionary)
                {
                    var colorPointArray = new byte[0x05];
                    byte[] sectionDataArray = RawData.ToArray();

                    for (int n = 0, i = 0x05; i < 0x09; i += 0x05)
                    {
                        Array.Copy(sectionDataArray, i, colorPointArray, 0x00, 0x04);
                        var colorPointCollection = new ReadOnlyCollection<byte>(colorPointArray);
                        var colorPoint = new ColorPointDataDescriptorItem(colorPointCollection);
                        colorPointDictionary.Add((KnownColorPoint)n, colorPoint);
                        n++;
                    }
                }
                #endregion

            #endregion

        #endregion
    }
}