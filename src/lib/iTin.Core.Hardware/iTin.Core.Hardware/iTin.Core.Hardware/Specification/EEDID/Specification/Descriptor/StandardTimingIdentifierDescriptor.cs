
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using Helpers;

    // Data Block Descriptor: Standard Timings Identifier Descriptor Definition
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                            |
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Standard Timing 9         WORD        Note: Ver Timing(KnownStandardTiming)  |
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Standard Timing 10        WORD        Note: Ver Timing(KnownStandardTiming)  |
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Standard Timing 11        WORD        Note: Ver Timing(KnownStandardTiming)  |
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Standard Timing 12        WORD        Note: Ver Timing(KnownStandardTiming)  |
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Standard Timing 13        WORD        Note: Ver Timing(KnownStandardTiming)  |
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | 0ah          Standard Timing 14        WORD        Note: Ver Timing(KnownStandardTiming)  |
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | 0ch          Line Feed                 BYTE        0ah, all other values are reserved     |
    // •———————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Especialización de la clase <see cref="BaseDataSection"/> que representa a un <see cref="KnownEdidSection.DataBlocks"/> de tipo <see cref="KnownEdidDataBlockDescriptor.StandardTimingIdentifier"/>.
    /// </summary> 
    class StandardTimingIdentifierDescriptor : BaseDataSection
    {
        #region Enumeraciones.

            #region [private] (enum) KnownStandardTiming: Timings conocidos conocidos para este bloque.
            /// <summary>
            /// Timings conocidos conocidos para este bloque.
            /// </summary> 
            enum KnownStandardTiming
            {
                /// <summary>
                /// Timing 9.
                /// </summary>
                Timing9,
                /// <summary>
                /// Timing 10.
                /// </summary>
                Timing10,
                /// <summary>
                /// Timing 11.
                /// </summary>
                Timing11,
                /// <summary>
                /// Timing 12.
                /// </summary>
                Timing12,
                /// <summary>
                /// Timing 13.
                /// </summary>
                Timing13,
                /// <summary>
                /// Timing 14.
                /// </summary>
                Timing14,
            }
                #endregion

        #endregion

        #region Declaraciones.
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem> _timingTable;
        #endregion

        #region Constructor/es.

            #region [public] StandardTimingIdentifierDescriptor(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de este bloque sin tratar.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="StandardTimingIdentifierDescriptor"/> con los datos de este bloque sin tratar.
            /// </summary>
            /// <param name="blockData">Datos de este bloque sin tratar.</param>
            public StandardTimingIdentifierDescriptor(ReadOnlyCollection<byte> blockData) : base(blockData)
            {
            }
            #endregion

        #endregion

        #region Overrides.

            #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Obtiene un valor que representa el valor de la propiedad especificada.
            /// <summary>
            /// Obtiene un valor que representa el valor de la propiedad especificada.
            /// </summary>
            /// <param name="propertyKey">Clave de la propiedad a obtener.</param>
            /// <returns></returns>
            protected override object GetValueTypedProperty(PropertyKey propertyKey)
            {
                object value = null;
                var propertyId = (KnownStandardTimingIdentifierDescriptorProperty)propertyKey.PropertyId;

                switch (propertyId)
                {
                    #region [0x00] - [Timing 9] - [StandardTimingInfo]
                    case KnownStandardTimingIdentifierDescriptorProperty.Timing9:
                        value = Timing(KnownStandardTiming.Timing9);
                        break;
                    #endregion

                    #region [0x01] - [Timing 10] - [StandardTimingInfo]
                    case KnownStandardTimingIdentifierDescriptorProperty.Timing10:
                        value = Timing(KnownStandardTiming.Timing10);
                        break;
                    #endregion

                    #region [0x02] - [Timing 11] - [StandardTimingInfo]
                    case KnownStandardTimingIdentifierDescriptorProperty.Timing11:
                        value = Timing(KnownStandardTiming.Timing11);
                        break;
                    #endregion

                    #region [0x03] - [Timing 12] - [StandardTimingInfo]
                    case KnownStandardTimingIdentifierDescriptorProperty.Timing12:
                        value = Timing(KnownStandardTiming.Timing12);
                        break;
                    #endregion

                    #region [0x04] - [Timing 13] - [StandardTimingInfo]
                    case KnownStandardTimingIdentifierDescriptorProperty.Timing13:
                        value = Timing(KnownStandardTiming.Timing13);
                        break;
                    #endregion

                    #region [0x05] - [Timing 14] - [StandardTimingInfo]
                    case KnownStandardTimingIdentifierDescriptorProperty.Timing14:
                        value = Timing(KnownStandardTiming.Timing14);
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
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing9, Timing(KnownStandardTiming.Timing9));
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing10, Timing(KnownStandardTiming.Timing10));
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing11, Timing(KnownStandardTiming.Timing11));
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing12, Timing(KnownStandardTiming.Timing12));
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing13, Timing(KnownStandardTiming.Timing13));
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing14, Timing(KnownStandardTiming.Timing14));
                #endregion
            }
            #endregion

        #endregion

        #region Miembros privados.

            #region Propiedades.

                #region [private] (Dictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem>) TimingTable: Obtiene un valor que representa un diccionario de Timings.
                /// <summary>
                /// Obtiene un valor que representa un diccionario diccionario de Timings.
                /// </summary>
                /// <value>
                /// Diccionario que contiene el par Timing / Valor del mismo.
                /// </value>e>
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                private Dictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem> TimingTable
                {
                    get
                    {
                        if (_timingTable == null)
                        {
                            _timingTable = new Dictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem>();
                            GetTimingsTable(_timingTable);
                        }
                        return _timingTable;
                    }
                }
                #endregion

            #endregion

            #region Métodos.

            #region [private] (void) GetTimingsTable(IDictionary<KnownStandardTimming, StandardTimingIdentifierDescriptorItem>): Obtiene un valor que representa al diccionario de timmings.
            /// <summary>
            /// Obtiene un valor que representa al diccionario de timmings.
            /// </summary>
            /// <param name="timingDictionary">Diccionario de timmings.</param>
            private void GetTimingsTable(IDictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem> timingDictionary)
            {
                byte[] sectionDataArray = RawData.ToArray();

                for (int n = 0, i = 0x00; i < 0x0a; i += 0x02)
                {
                    if (LogicHelper.Word(RawData[i + 1], RawData[i]) > 0x0101)
                    {
                        byte[] timingArray = new byte[0x02];
                        Array.Copy(sectionDataArray, i, timingArray, 0x00, 0x02);

                        StandardTimingIdentifierDescriptorItem timing = new StandardTimingIdentifierDescriptorItem(timingArray);
                        timingDictionary.Add((KnownStandardTiming)n, timing);
                        n++;
                    }
                }
            }
            #endregion

            #region [private] (StandardTimingIdentifierDescriptorItem) Timing(KnownStandardTiming): Obtiene el valor que contiene la clave especificada.
            /// <summary>
            /// Obtiene el valor que contiene la clave especificada.
            /// </summary>
            /// <param name="timing">Timing que se va a recuperar.</param>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.Drawing.PointF"/></para>
            /// 	<para>Valor del timing especificado.</para>
            /// </returns>
            private StandardTimingIdentifierDescriptorItem Timing(KnownStandardTiming timing)
            {
                StandardTimingIdentifierDescriptorItem result;
                try
                {
                    result = TimingTable[timing];                        
                }
                catch (KeyNotFoundException)
                {
                    return null;
                }
                return result;
            }
            #endregion

            #endregion

        #endregion
    }
}
