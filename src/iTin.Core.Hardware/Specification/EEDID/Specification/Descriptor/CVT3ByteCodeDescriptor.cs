
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    // Data Block Descriptor: CVT 3 Byte Code Descriptor Definition
    // •——————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                   |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Version                   BYTE        01h. Other values reserved.                   |
    // |              Number                                                                              |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h - 03h    CTV 3 Byte Code           3 BYTE      Prioridad más alta. If not defined (00 00 00) |
    // |              Descriptor with                       Note: Ver Priority(KnownCVT3ByteCodePriority) |
    // |              #1 Priority                                                                         |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h - 06h    CTV 3 Byte Code           3 BYTE      If not defined (00 00 00)                     |
    // |              Descriptor with                       Note: Ver Priority(KnownCVT3ByteCodePriority) |
    // |              #2 Priority                                                                         |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h - 09h    CTV 3 Byte Code           3 BYTE      If not defined (00 00 00)                     |
    // |              Descriptor with                       Note: Ver Priority(KnownCVT3ByteCodePriority) |
    // |              #3 Priority                                                                         |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0ah - 0ch    CTV 3 Byte Code           3 BYTE      Prioridad más baja. If not defined (00 00 00) |
    // |              Descriptor with                       Note: Ver Priority(KnownCVT3ByteCodePriority) |
    // |              #4 Priority                                                                         |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Especialización de la clase <see cref="BaseDataSection"/> que representa a un <see cref="KnownEdidSection.DataBlocks"/> de tipo <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/>.
    /// </summary>
    sealed class Cvt3ByteCodeDescriptor : BaseDataSection
    {
        #region Enumeraciones

            #region [private] (enum) KnownCVT3ByteCodePriority: Enumeración con las prioridades conocidas para este bloque.
            /// <summary>
            /// Enumeración con las prioridades conocidas para este bloque.
            /// </summary> 
            enum KnownCvt3ByteCodePriority
            {
                /// <summary>
                /// Prioridad 1. La más alta.
                /// </summary>
                Priority1,
                /// <summary>
                /// Prioridad 2.
                /// </summary>
                Priority2,
                /// <summary>
                /// Prioridad 3
                /// </summary>
                Priority3,
                /// <summary>
                /// Prioridad 4. La más baja.
                /// </summary>
                Priority4,
            }
            #endregion

        #endregion

        #region Declaraciones
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IDictionary<KnownCvt3ByteCodePriority, Cvt3ByteCodeDescriptorItem> _priorityTable;
        #endregion

        #region Constructor/es

            #region [public] CVT3ByteCodeDescriptor(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de este bloque sin tratar.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="Cvt3ByteCodeDescriptor"/> con los datos de este bloque sin tratar.
            /// </summary>
            /// <param name="blockData">Datos de este bloque sin tratar.</param>
            public Cvt3ByteCodeDescriptor(ReadOnlyCollection<byte> blockData) : base(blockData)
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
                var propertyId = (KnownCvt3ByteCodeDescriptorProperty)propertyKey.PropertyId;

                switch (propertyId)
                {
                    #region [0x00] - [Version Number] - [Byte]
                    case KnownCvt3ByteCodeDescriptorProperty.Version:
                        value = VersionNumber;
                        break;
                    #endregion

                    #region [0x01] - [Priority 1] - [CVT3ByteCodeDescriptorItem]
                    case KnownCvt3ByteCodeDescriptorProperty.Priority1:
                        value = Priority(KnownCvt3ByteCodePriority.Priority1);
                        break;
                    #endregion

                    #region [0x02] - [Priority 2] - [CVT3ByteCodeDescriptorItem]
                    case KnownCvt3ByteCodeDescriptorProperty.Priority2:
                        value = Priority(KnownCvt3ByteCodePriority.Priority2);
                        break;
                    #endregion

                    #region [0x03] - [Priority 3] - [CVT3ByteCodeDescriptorItem]
                    case KnownCvt3ByteCodeDescriptorProperty.Priority3:
                        value = Priority(KnownCvt3ByteCodePriority.Priority3);
                        break;
                    #endregion

                    #region [0x04] - [Priority 4] - [CVT3ByteCodeDescriptorItem]
                    case KnownCvt3ByteCodeDescriptorProperty.Priority4:
                        value = Priority(KnownCvt3ByteCodePriority.Priority4);
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
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.CVT3ByteCode.VersionNumber, VersionNumber);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.CVT3ByteCode.Priority1, Priority(KnownCvt3ByteCodePriority.Priority1));
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.CVT3ByteCode.Priority2, Priority(KnownCvt3ByteCodePriority.Priority2));
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.CVT3ByteCode.Priority3, Priority(KnownCvt3ByteCodePriority.Priority3));
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.CVT3ByteCode.Priority4, Priority(KnownCvt3ByteCodePriority.Priority4));
                #endregion
            }
            #endregion

        #endregion

        #region Miembros privados

            #region Propiedades

                #region [private] (Dictionary<KnownCVT3ByteCodePriority, CVT3ByteCodeDescriptorItem>) PriorityTable: Obtiene un valor que representa un diccionario de prioridades.
                /// <summary>
                /// Obtiene un valor que representa un diccionario diccionario de prioridades.
                /// </summary>
                /// <value>
                /// Diccionario que contiene el par prioridad / Valor de la misma.
                /// </value>e>
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                private IDictionary<KnownCvt3ByteCodePriority, Cvt3ByteCodeDescriptorItem> PriorityTable
                {
                    get
                    {
                        if (_priorityTable == null)
                        {
                            _priorityTable = new Dictionary<KnownCvt3ByteCodePriority, Cvt3ByteCodeDescriptorItem>();
                            GetPriorityTable(_priorityTable);
                        }
                        return _priorityTable;
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

                #region [private] (CVT3ByteCodeDescriptorItem) Priority(KnownCVT3ByteCodePriority): Obtiene el valor que contiene la clave especificada.
                /// <summary>
                /// Obtiene el valor que contiene la clave especificada.
                /// </summary>
                /// <param name="byteCode">Prioridad que se va a recuperar.</param>
                /// <returns>
                /// 	<para>Tipo: <see cref="Cvt3ByteCodeDescriptorItem"/></para>
                /// 	<para>Valor de la prioridad especificada.</para>
                /// </returns>
                private Cvt3ByteCodeDescriptorItem Priority(KnownCvt3ByteCodePriority byteCode)
                {
                    Cvt3ByteCodeDescriptorItem result;
                    try
                    {
                        result = PriorityTable[byteCode];
                    }
                    catch (KeyNotFoundException)
                    {
                        return null;
                    }
                    return result;
                }
                #endregion

                #region [private] (void) GetPriorityTable(IDictionary<KnownCVT3ByteCodePriority, CVT3ByteCodeDescriptorItem>): Obtiene un valor que representa al diccionario de prioridades.
                /// <summary>
                /// Obtiene un valor que representa al diccionario de prioridades.
                /// </summary>
                /// <param name="priorityDictionary">Diccionario de prioridades.</param>
                private void GetPriorityTable(IDictionary<KnownCvt3ByteCodePriority, Cvt3ByteCodeDescriptorItem> priorityDictionary)
                {
                    byte[] sectionDataArray = RawData.ToArray();

                    for (int n = 0, i = 0x01; i < 0x0c; i += 0x03)
                    {
                        var priorityArray = new byte[0x03];
                        Array.Copy(sectionDataArray, i, priorityArray, 0x00, 0x03);

                        var priorityCollection = new ReadOnlyCollection<byte>(priorityArray);
                        var priority = new Cvt3ByteCodeDescriptorItem(priorityCollection);
                        priorityDictionary.Add((KnownCvt3ByteCodePriority)n, priority);
                        n++;                     
                    }
                }
                #endregion

            #endregion

        #endregion
    }
}