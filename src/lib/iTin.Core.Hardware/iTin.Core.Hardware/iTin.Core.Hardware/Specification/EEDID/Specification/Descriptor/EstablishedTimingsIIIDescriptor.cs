
using iTin.Core.Helpers.Enumerations;

namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;

    // Data Block Descriptor: Established Timings III Descriptor Definition
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                              |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Revision Number           BYTE        0ah, other values reserved.              |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Resolutions 0             BYTE        7 6 5 4 3 2 1 0                          |
    // |                                                    1 _ _ _ _ _ _ _ 640 x 350 @ 85 Hz        |
    // |                                                    _ 1 _ _ _ _ _ _ 640 x 400 @ 85 Hz        |
    // |                                                    _ _ 1 _ _ _ _ _ 720 x 400 @ 85 Hz        |
    // |                                                    _ _ _ 1 _ _ _ _ 640 x 480 @ 85 Hz        |
    // |                                                    _ _ _ _ 1 _ _ _ 848 x 480 @ 60 Hz        |
    // |                                                    _ _ _ _ _ 1 _ _ 800 x 600 @ 85 Hz        |
    // |                                                    _ _ _ _ _ _ 1 _ 1024 x 768 @ 85 Hz       |
    // |                                                    _ _ _ _ _ _ _ 1 1152 x 864 @ 75 Hz       |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Resolutions 1             BYTE        7 6 5 4 3 2 1 0                          |
    // |                                                    1 _ _ _ _ _ _ _ 1280 x 768 @ 60 Hz (RB)  |
    // |                                                    _ 1 _ _ _ _ _ _ 1280 x 768 @ 60 Hz       |
    // |                                                    _ _ 1 _ _ _ _ _ 1280 x 768 @ 75 Hz       |
    // |                                                    _ _ _ 1 _ _ _ _ 1280 x 768 @ 85 Hz       |
    // |                                                    _ _ _ _ 1 _ _ _ 1280 x 960 @ 60 Hz       |
    // |                                                    _ _ _ _ _ 1 _ _ 1280 x 960 @ 85 Hz       |
    // |                                                    _ _ _ _ _ _ 1 _ 1280 x 1024 @ 60 Hz      |
    // |                                                    _ _ _ _ _ _ _ 1 1280 x 1024 @ 85 Hz      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          Resolutions 2             BYTE        7 6 5 4 3 2 1 0                          |
    // |                                                    1 _ _ _ _ _ _ _ 1360 x 768 @ 60 Hz       |
    // |                                                    _ 1 _ _ _ _ _ _ 1440 x 900 @ 60 Hz (RB)  |
    // |                                                    _ _ 1 _ _ _ _ _ 1440 x 900 @ 60 Hz       |
    // |                                                    _ _ _ 1 _ _ _ _ 1440 x 900 @ 75 Hz       |
    // |                                                    _ _ _ _ 1 _ _ _ 1440 x 900 @ 85 Hz       |
    // |                                                    _ _ _ _ _ 1 _ _ 1400 x 1050 @ 60 Hz (RB) |
    // |                                                    _ _ _ _ _ _ 1 _ 1400 x 1050 @ 60 Hz      |
    // |                                                    _ _ _ _ _ _ _ 1 1400 x 1050 @ 75 Hz      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Resolutions 3             BYTE        7 6 5 4 3 2 1 0                          |
    // |                                                    1 _ _ _ _ _ _ _ 1400 x 1050 @ 85 Hz      |
    // |                                                    _ 1 _ _ _ _ _ _ 1680 x 1050 @ 60 Hz (RB) |
    // |                                                    _ _ 1 _ _ _ _ _ 1680 x 1050 @ 60 Hz      |
    // |                                                    _ _ _ 1 _ _ _ _ 1680 x 1050 @ 75 Hz      |
    // |                                                    _ _ _ _ 1 _ _ _ 1680 x 1050 @ 85 Hz      |
    // |                                                    _ _ _ _ _ 1 _ _ 1600 x 1200 @ 60 Hz      |
    // |                                                    _ _ _ _ _ _ 1 _ 1600 x 1200 @ 65 Hz      |
    // |                                                    _ _ _ _ _ _ _ 1 1600 x 1200 @ 70 Hz      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Resolutions 4             BYTE        7 6 5 4 3 2 1 0                          |
    // |                                                    1 _ _ _ _ _ _ _ 1600 x 1200 @ 75 Hz      |
    // |                                                    _ 1 _ _ _ _ _ _ 1600 x 1200 @ 85 Hz      |
    // |                                                    _ _ 1 _ _ _ _ _ 1792 x 1344 @ 60 Hz      |
    // |                                                    _ _ _ 1 _ _ _ _ 1792 x 1344 @ 75 Hz      |
    // |                                                    _ _ _ _ 1 _ _ _ 1856 x 1392 @ 60 Hz      |
    // |                                                    _ _ _ _ _ 1 _ _ 1856 x 1392 @ 75 Hz      |
    // |                                                    _ _ _ _ _ _ 1 _ 1920 x 1200 @ 60 Hz (RB) |
    // |                                                    _ _ _ _ _ _ _ 1 1920 x 1200 @ 60 Hz      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Resolutions 5             BYTE        7 6 5 4 3 2 1 0                          |
    // |                                                    1 _ _ _ 0 0 0 0 1920 x 1200 @ 75 Hz      |
    // |                                                    _ 1 _ _ 0 0 0 0 1920 x 1200 @ 85 Hz      |
    // |                                                    _ _ 1 _ 0 0 0 0 1920 x 1440 @ 60 Hz      |
    // |                                                    _ _ _ 1 0 0 0 0 1920 x 1440 @ 75 Hz      |
    // |                                                    _ _ _ _ 0 0 0 0 Reserved bits: set 0000h |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h -> 0bh   Future resolutions        5 BYTEs     Shall be set to '00h' each byte.         |
    // •—————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Especialización de la clase <see cref="BaseDataSection"/> que representa a un <see cref="KnownEdidSection.DataBlocks"/> de tipo <see cref="KnownEdidDataBlockDescriptor.EstablishedTimingsIII"/>.
    /// </summary>
    sealed class EstablishedTimingsIIIDescriptor : BaseDataSection
    {
        #region Constructor/es

            #region [public] EstablishedTimingsIIIDescriptor(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de este bloque sin tratar.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="EstablishedTimingsIIIDescriptor"/> con los datos de este bloque sin tratar.
            /// </summary>
            /// <param name="blockData">Datos de este bloque sin tratar.</param>
            public EstablishedTimingsIIIDescriptor(ReadOnlyCollection<byte> blockData) : base(blockData)
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
                var propertyId = (KnownEstablishedTimingsIIIDescriptorProperty)propertyKey.PropertyId;

                switch (propertyId)
                {
                    #region [0x00] - [Revision Number] - [Byte]
                    case KnownEstablishedTimingsIIIDescriptorProperty.Revision:
                        value = Revision;
                        break;
                    #endregion

                    #region [0x01] - [Resolutions] - [ReadOnlyCollection<MonitorResolutionInfo>]
                    case KnownEstablishedTimingsIIIDescriptorProperty.Resolutions:
                        value = GetResolutionCollection();
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
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.EstablishedTimingsIII.Revision, Revision);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.EstablishedTimingsIII.Resolutions, GetResolutionCollection());
                #endregion
            }
            #endregion

        #endregion

        #region Miembros privados

            #region [private] (byte) Revision: Obtiene un valor que representa al campo 'Revision Number'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Revision Number</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private byte Revision
            {
                get
                {
                    byte revision = RawData[0x00];
                    return revision;
                }
            }
            #endregion

            #region [private] (byte) Resolutions0: Obtiene un valor que representa al campo 'Resolutions 0'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Resolutions 0</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private byte Resolutions0
            {
                get
                {
                    byte resolutions0 = RawData[0x01];
                    return resolutions0;
                }
            }
            #endregion

            #region [private] (bool) Is640x350x85: Obtiene un valor que representa la característica '640 x 350 @ 85 Hz' del campo 'Resolutions 0'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>640 x 350 @ 85Hz</c>' del campo '<c>Resolutions 0</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is640x350x85
            {
                get
                {
                    byte resolutions0 = Resolutions0;
                    bool is640x350x85 = resolutions0.CheckBit(Bits.Bit07);

                    return is640x350x85;
                }
            }
            #endregion

            #region [private] (bool) Is640x400x85: Obtiene un valor que representa la característica '640 x 400 @ 85 Hz' del campo 'Resolutions 0'
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>640 x 400 @ 85Hz</c>' del campo '<c>Resolutions 0</c>'.
            /// </summary>
            /// <value>
            /// Valor de la propiedad.
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is640x400x85
            {
                get
                {
                    byte resolutions0 = Resolutions0;
                    bool is640x400x85 = resolutions0.CheckBit(Bits.Bit06);

                    return is640x400x85;
                }
            }
            #endregion

            #region [private] (bool) Is720x400x85: Obtiene un valor que representa la característica '720 x 400 @ 85 Hz' del campo 'Resolutions 0'
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>720 x 400 @ 85Hz</c>' del campo '<c>Resolutions 0</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is720x400x85
            {
                get
                {
                    byte resolutions0 = Resolutions0;
                    bool is720x400x85 = resolutions0.CheckBit(Bits.Bit05);

                    return is720x400x85;
                }
            }
            #endregion

            #region [private] (bool) Is640x480x85: Obtiene un valor que representa la característica '640 x 480 @ 85 Hz' del campo 'Resolutions 0'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>640 x 480 @ 85Hz</c>' del campo '<c>Resolutions 0</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is640x480x85
            {
                get
                {
                    byte resolutions0 = Resolutions0;
                    bool is640x480x85 = resolutions0.CheckBit(Bits.Bit04);

                    return is640x480x85;
                }
            }
            #endregion

            #region [private] (bool) Is848x480x60: Obtiene un valor que representa la característica '848 x 480 @ 60 Hz' del campo 'Resolutions 0'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>848 x 480 @ 60 Hz</c>' del campo '<c>Resolutions 0</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is848x480x60
            {
                get
                {
                    byte resolutions0 = Resolutions0;
                    bool is848x480x60 = resolutions0.CheckBit(Bits.Bit03);

                    return is848x480x60;
                }
            }
            #endregion

            #region [private] (bool) Is800x600x85: Obtiene un valor que representa la característica '848 x 480 @ 60 Hz' del campo 'Resolutions 0'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>800 x 600 @ 85 Hz</c>' del campo '<c>Resolutions 0</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is800x600x85
            {
                get
                {
                    byte resolutions0 = Resolutions0;
                    bool is800x600x85 = resolutions0.CheckBit(Bits.Bit02);

                    return is800x600x85;
                }
            }
            #endregion

            #region [private] (bool) Is1024x768x85: Obtiene un valor que representa la característica '1024 x 768 @ 85 Hz' del campo 'Resolutions 0'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1024 x 768 @ 85 Hz</c>' del campo '<c>Resolutions 0</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1024x768x85
            {
                get
                {
                    byte resolutions0 = Resolutions0;
                    bool is1024x768x85 = resolutions0.CheckBit(Bits.Bit01);

                    return is1024x768x85;
                }
            }
            #endregion

            #region [private] (bool) Is1152x864x75: Obtiene un valor que representa la característica '1152 x 864 @ 75 Hz' del campo 'Resolutions 0'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1024 x 768 @ 85 Hz</c>' del campo '<c>Resolutions 0</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1152x864x75
            {
                get
                {
                    byte resolutions0 = Resolutions0;
                    bool is1152x864x75 = resolutions0.CheckBit(Bits.Bit00);

                    return is1152x864x75;
                }
            }
            #endregion


            #region [private] (byte) Resolutions1: Obtiene un valor que representa al campo 'Resolutions 1'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Resolutions 1</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private byte Resolutions1
            {
                get
                {
                    byte resolutions1 = RawData[0x02];
                    return resolutions1;
                }
            }
            #endregion

            #region [private] (bool) Is1280x768x60RB: Obtiene un valor que representa la característica '1280 x 768 @ 60 Hz Reduce Blanking' del campo 'Resolutions 1'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1280 x 768 @ 60 Hz Reduce Blanking</c>' del campo '<c>Resolutions 1</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1280x768x60RB
            {
                get
                {
                    byte resolutions1 = Resolutions1;
                    bool is1280x768x60RB = resolutions1.CheckBit(Bits.Bit07);

                    return is1280x768x60RB;
                }
            }
            #endregion

            #region [private] (bool) Is1280x768x60: Obtiene un valor que representa la característica '1280 x 768 @ 60 Hz' del campo 'Resolutions 1'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1280 x 768 @ 60 Hz</c>' del campo '<c>Resolutions 1</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1280x768x60
            {
                get
                {
                    byte resolutions1 = Resolutions1;
                    bool is1280x768x60 = resolutions1.CheckBit(Bits.Bit06);

                    return is1280x768x60;
                }
            }
            #endregion

            #region [private] (bool) Is1280x768x75: Obtiene un valor que representa la característica '1280 x 768 @ 75 Hz' del campo 'Resolutions 1'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1280 x 768 @ 75 Hz</c>' del campo '<c>Resolutions 1</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1280x768x75
            {
                get
                {
                    byte resolutions1 = Resolutions1;
                    bool is1280x768x75 = resolutions1.CheckBit(Bits.Bit05);

                    return is1280x768x75;
                }
            }
            #endregion

            #region [private] (bool) Is1280x768x85: Obtiene un valor que representa la característica '1280 x 768 @ 85 Hz' del campo 'Resolutions 1'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1280 x 768 @ 85 Hz</c>' del campo '<c>Resolutions 1</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1280x768x85
            {
                get
                {
                    byte resolutions1 = Resolutions1;
                    bool is1280x768x85 = resolutions1.CheckBit(Bits.Bit04);

                    return is1280x768x85;
                }
            }
            #endregion

            #region [private] (bool) Is1280x960x60: Obtiene un valor que representa la característica '1280 x 960 @ 60 Hz' del campo 'Resolutions 1'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1280 x 960 @ 60 Hz</c>' del campo '<c>Resolutions 1</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1280x960x60
            {
                get
                {
                    byte resolutions1 = Resolutions1;
                    bool is1280x960x60 = resolutions1.CheckBit(Bits.Bit03);

                    return is1280x960x60;
                }
            }
            #endregion

            #region [private] (bool) Is1280x960x85: Obtiene un valor que representa la característica '1280 x 960 @ 85 Hz' del campo 'Resolutions 1'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1280 x 960 @ 85 Hz</c>' del campo '<c>Resolutions 1</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1280x960x85
            {
                get
                {
                    byte resolutions1 = Resolutions1;
                    bool is1280x960x85 = resolutions1.CheckBit(Bits.Bit02);

                    return is1280x960x85;
                }
            }
            #endregion

            #region [private] (bool) Is1280x1024x60: Obtiene un valor que representa la característica '1280 x 1024 @ 60 Hz' del campo 'Resolutions 1'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1280 x 1024 @ 60 Hz</c>' del campo '<c>Resolutions 1</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1280x1024x60
            {
                get
                {
                    byte resolutions1 = Resolutions1;
                    bool is1280x1024x60 = resolutions1.CheckBit(Bits.Bit01);

                    return is1280x1024x60;
                }
            }
            #endregion

            #region [private] (bool) Is1280x1024x85: Obtiene un valor que representa la característica '1280 x 1024 @ 85 Hz' del campo 'Resolutions 1'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1280 x 1024 @ 85 Hz</c>' del campo '<c>Resolutions 1</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1280x1024x85
            {
                get
                {
                    byte resolutions1 = Resolutions1;
                    bool is1280x1024x85 = resolutions1.CheckBit(Bits.Bit00);

                    return is1280x1024x85;
                }
            }
            #endregion


            #region [private] (byte) Resolutions2: Obtiene un valor que representa al campo 'Resolutions 2'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Resolutions 2</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private byte Resolutions2
            {
                get
                {
                    byte resolutions2 = RawData[0x03];
                    return resolutions2;
                }
            }
            #endregion

            #region [private] (bool) Is1360x768x60: Obtiene un valor que representa la característica '1280 x 768 @ 60 Hz' del campo 'Resolutions 2'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1360 x 768 @ 60 Hz</c>' del campo '<c>Resolutions 2</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1360x768x60
            {
                get
                {
                    byte resolutions2 = Resolutions2;
                    bool is1360x768x60 = resolutions2.CheckBit(Bits.Bit07);

                    return is1360x768x60;
                }
            }
            #endregion

            #region [private] (bool) Is1440x900x60RB: Obtiene un valor que representa la característica '1440 x 900 @ 60 Hz Reduce Blanking' del campo 'Resolutions 2'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1440 x 900 @ 60 Hz Reduce Blanking</c>' del campo '<c>Resolutions 2</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1440x900x60RB
            {
                get
                {
                    byte resolutions2 = Resolutions2;
                    bool is1440x900x60RB = resolutions2.CheckBit(Bits.Bit06);

                    return is1440x900x60RB;
                }
            }
            #endregion

            #region [private] (bool) Is1440x900x60: Obtiene un valor que representa la característica '1440 x 900 @ 60 Hz' del campo 'Resolutions 2'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1440 x 900 @ 60 Hz</c>' del campo '<c>Resolutions 2</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1440x900x60
            {
                get
                {
                    byte resolutions2 = Resolutions2;
                    bool is1440x900x60 = resolutions2.CheckBit(Bits.Bit05);

                    return is1440x900x60;
                }
            }
            #endregion

            #region [private] (bool) Is1440x900x75: Obtiene un valor que representa la característica '1440 x 900 @ 75 Hz' del campo 'Resolutions 2'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1440 x 900 @ 75 Hz</c>' del campo '<c>Resolutions 2</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1440x900x75
            {
                get
                {
                    byte resolutions2 = Resolutions2;
                    bool is1440x900x75 = resolutions2.CheckBit(Bits.Bit04);

                    return is1440x900x75;
                }
            }
            #endregion

            #region [private] (bool) Is1440x900x85: Obtiene un valor que representa la característica '1440 x 900 @ 85 Hz' del campo 'Resolutions 2'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1440 x 900 @ 85 Hz</c>' del campo '<c>Resolutions 2</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1440x900x85
            {
                get
                {
                    byte resolutions2 = Resolutions2;
                    bool is1440x900x85 = resolutions2.CheckBit(Bits.Bit03);

                    return is1440x900x85;
                }
            }
            #endregion

            #region [private] (bool) Is1400x1050x60RB: Obtiene un valor que representa la característica '1400 x 1050 @ 60 Hz Reduce Blanking' del campo 'Resolutions 2'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1400 x 1050 @ 60 Hz Reduce Blanking</c>' del campo '<c>Resolutions 2</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1400x1050x60RB
            {
                get
                {
                    byte resolutions2 = Resolutions2;
                    bool is1400x1050x60RB = resolutions2.CheckBit(Bits.Bit02);

                    return is1400x1050x60RB;
                }
            }
            #endregion

            #region [private] (bool) Is1400x1050x60: Obtiene un valor que representa la característica '1400 x 1050 @ 60 Hz' del campo 'Resolutions 2'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1400 x 1050 @ 60 Hz</c>' del campo '<c>Resolutions 2</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1400x1050x60 
            {
                get
                {
                    byte resolutions2 = Resolutions2;
                    bool is1400x1050x60 = resolutions2.CheckBit(Bits.Bit01);

                    return is1400x1050x60;
                }
            }
            #endregion

            #region [private] (bool) Is1400x1050x75: Obtiene un valor que representa la característica '1400 x 1050 @ 75 Hz' del campo 'Resolutions 2'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1400 x 1050 @ 75 Hz</c>' del campo '<c>Resolutions 2</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1400x1050x75
            {
                get
                {
                    byte resolutions2 = Resolutions2;
                    bool is1400x1050x75 = resolutions2.CheckBit(Bits.Bit00);

                    return is1400x1050x75;
                }
            }
            #endregion


            #region [private] (byte) Resolutions3: Obtiene un valor que representa al campo 'Resolutions 3'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Resolutions 3</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private byte Resolutions3
            {
                get
                {
                    byte resolutions3 = RawData[0x04];
                    return resolutions3;
                }
            }
            #endregion

            #region [private] (bool) Is1400x1050x85: Obtiene un valor que representa la característica '1400 x 1050 @ 85 Hz' del campo 'Resolutions 3'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1400 x 1050 @ 85 Hz</c>' del campo '<c>Resolutions 3</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1400x1050x85
            {
                get
                {
                    byte resolutions3 = Resolutions3;
                    bool is1400x1050x85 = resolutions3.CheckBit(Bits.Bit07);

                    return is1400x1050x85;
                }
            }
            #endregion

            #region [private] (bool) Is1680x1050x60RB: Obtiene un valor que representa la característica '1680 x 1050 @ 60 Hz Reduce Blanking' del campo 'Resolutions 3'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1680 x 1050 @ 60 Hz Reduce Blanking</c>' del campo '<c>Resolutions 3</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1680x1050x60RB
            {
                get
                {
                    byte resolutions3 = Resolutions3;
                    bool is1680x1050x60RB = resolutions3.CheckBit(Bits.Bit06);

                    return is1680x1050x60RB;
                }
            }
            #endregion

            #region [private] (bool) Is1680x1050x60: Obtiene un valor que representa la característica '1680 x 1050 @ 60 Hz' del campo 'Resolutions 3'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1680 x 1050 @ 60 Hz</c>' del campo '<c>Resolutions 3</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1680x1050x60
            {
                get
                {
                    byte resolutions3 = Resolutions3;
                    bool is1680x1050x60 = resolutions3.CheckBit(Bits.Bit05);

                    return is1680x1050x60;
                }
            }
            #endregion

            #region [private] (bool) Is1680x1050x75: Obtiene un valor que representa la característica '1680 x 1050 @ 75 Hz' del campo 'Resolutions 3'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1680 x 1050 @ 75 Hz</c>' del campo '<c>Resolutions 3</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1680x1050x75
            {
                get
                {
                    byte resolutions3 = Resolutions3;
                    bool is1680x1050x75 = resolutions3.CheckBit(Bits.Bit04);

                    return is1680x1050x75;
                }
            }
            #endregion

            #region [private] (bool) Is1680x1050x85: Obtiene un valor que representa la característica '1680 x 1050 @ 85 Hz' del campo 'Resolutions 3'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1680 x 1050 @ 85 Hz</c>' del campo '<c>Resolutions 3</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1680x1050x85
            {
                get
                {
                    byte resolutions3 = Resolutions3;
                    bool is1680x1050x85 = resolutions3.CheckBit(Bits.Bit03);

                    return is1680x1050x85;
                }
            }
            #endregion

            #region [private] (bool) Is1600x1200x60: Obtiene un valor que representa la característica '1600 x 1200 @ 60 Hz' del campo 'Resolutions 3'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1600 x 1200 @ 60 Hz</c>' del campo '<c>Resolutions 3</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1600x1200x60
            {
                get
                {
                    byte resolutions3 = Resolutions3;
                    bool is1600x1200x60 = resolutions3.CheckBit(Bits.Bit02);

                    return is1600x1200x60;
                }
            }
            #endregion

            #region [private] (bool) Is1600x1200x65: Obtiene un valor que representa la característica '1600 x 1200 @ 65 Hz' del campo 'Resolutions 3'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1600 x 1200 @ 65 Hz</c>' del campo '<c>Resolutions 3</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1600x1200x65
            {
                get
                {
                    byte resolutions3 = Resolutions3;
                    bool is1600x1200x65 = resolutions3.CheckBit(Bits.Bit01);

                    return is1600x1200x65;
                }
            }
            #endregion

            #region [private] (bool) Is1600x1200x70: Obtiene un valor que representa la característica '1600 x 1200 @ 70 Hz' del campo 'Resolutions 3'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1600 x 1200 @ 70 Hz</c>' del campo '<c>Resolutions 3</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1600x1200x70
            {
                get
                {
                    byte resolutions3 = Resolutions3;
                    bool is1600x1200x70 = resolutions3.CheckBit(Bits.Bit00);

                    return is1600x1200x70;
                }
            }
            #endregion


            #region [private] (byte) Resolutions4: Obtiene un valor que representa al campo 'Resolutions 4'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Resolutions 4</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private byte Resolutions4
            {
                get
                {
                    byte resolutions4 = RawData[0x05];
                    return resolutions4;
                }
            }
            #endregion

            #region [private] (bool) Is1600x1200x75: Obtiene un valor que representa la característica '1600 x 1200 @ 75 Hz' del campo 'Resolutions 4'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1600 x 1200 @ 75 Hz</c>' del campo '<c>Resolutions 4</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1600x1200x75
            {
                get
                {
                    byte resolutions4 = Resolutions4;
                    bool is1600x1200x75 = resolutions4.CheckBit(Bits.Bit07);

                    return is1600x1200x75;
                }
            }
            #endregion

            #region [private] (bool) Is1600x1200x85: Obtiene un valor que representa la característica '1600 x 1200 @ 85 Hz' del campo 'Resolutions 4'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1600 x 1200 @ 85 Hz</c>' del campo '<c>Resolutions 4</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1600x1200x85
            {
                get
                {
                    byte resolutions4 = Resolutions4;
                    bool is1600x1200x85 = resolutions4.CheckBit(Bits.Bit06);

                    return is1600x1200x85;
                }
            }
            #endregion

            #region [private] (bool) Is1792x1344x60: Obtiene un valor que representa la característica '1792 x 1344 @ 60 Hz' del campo 'Resolutions 4'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1792 x 1344 @ 60 Hz</c>' del campo '<c>Resolutions 4</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1792x1344x60
            {
                get
                {
                    byte resolutions4 = Resolutions4;
                    bool is1792x1344x60 = resolutions4.CheckBit(Bits.Bit05);

                    return is1792x1344x60;
                }
            }
            #endregion

            #region [private] (bool) Is1792x1344x75: Obtiene un valor que representa la característica '1792 x 1344 @ 75 Hz' del campo 'Resolutions 4'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1792 x 1344 @ 75 Hz</c>' del campo '<c>Resolutions 4</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1792x1344x75
            {
                get
                {
                    byte resolutions4 = Resolutions4;
                    bool is1792x1344x75 = resolutions4.CheckBit(Bits.Bit04);

                    return is1792x1344x75;
                }
            }
            #endregion

            #region [private] (bool) Is1856x1392x60: Obtiene un valor que representa la característica '1856 x 1392 @ 60 Hz' del campo 'Resolutions 4'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1856 x 1392 @ 60 Hz</c>' del campo '<c>Resolutions 4</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1856x1392x60
            {
                get
                {
                    byte resolutions4 = Resolutions4;
                    bool is1856x1392x60 = resolutions4.CheckBit(Bits.Bit03);

                    return is1856x1392x60;
                }
            }
            #endregion

            #region [private] (bool) Is1856x1392x75: Obtiene un valor que representa la característica '1856 x 1392 @ 75 Hz' del campo 'Resolutions 4'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1856 x 1392 @ 75 Hz</c>' del campo '<c>Resolutions 4</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1856x1392x75
            {
                get
                {
                    byte resolutions4 = Resolutions4;
                    bool is1856x1392x75 = resolutions4.CheckBit(Bits.Bit02);

                    return is1856x1392x75;
                }
            }
            #endregion

            #region [private] (bool) Is1920x1200x60RB: Obtiene un valor que representa la característica '1920 x 1200 @ 60 Hz Reduce Blanking' del campo 'Resolutions 4'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1920 x 1200 @ 60 Hz Reduce Blanking</c>' del campo '<c>Resolutions 4</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1920x1200x60RB
            {
                get
                {
                    byte resolutions4 = Resolutions4;
                    bool is1920x1200x60RB = resolutions4.CheckBit(Bits.Bit01);

                    return is1920x1200x60RB;
                }
            }
            #endregion

            #region [private] (bool) Is1920x1200x60: Obtiene un valor que representa la característica '1920 x 1200 @ 60 Hz' del campo 'Resolutions 4'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1920 x 1200 @ 60 Hz</c>' del campo '<c>Resolutions 4</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1920x1200x60
            {
                get
                {
                    byte resolutions4 = Resolutions4;
                    bool is1920x1200x60 = resolutions4.CheckBit(Bits.Bit00);

                    return is1920x1200x60;
                }
            }
            #endregion


            #region [private] (byte) Resolutions5: Obtiene un valor que representa al campo 'Resolutions 5'.
            /// <summary>
            /// Obtiene un valor que representa al campo '<c>Resolutions 5</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Byte"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private byte Resolutions5
            {
                get
                {
                    byte resolutions5 = RawData[0x06];
                    return resolutions5;
                }
            }
            #endregion

            #region [private] (bool) Is1920x1200x75: Obtiene un valor que representa la característica '1920 x 1200 @ 75 Hz' del campo 'Resolutions 5'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1920 x 1200 @ 75 Hz</c>' del campo '<c>Resolutions 5</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1920x1200x75
            {
                get
                {
                    byte resolutions5 = Resolutions5;
                    bool is1920x1200x75 = resolutions5.CheckBit(Bits.Bit07);

                    return is1920x1200x75;
                }
            }
            #endregion

            #region [private] (bool) Is1920x1200x85: Obtiene un valor que representa la característica '1920 x 1200 @ 85 Hz' del campo 'Resolutions 5'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1920 x 1200 @ 85 Hz</c>' del campo '<c>Resolutions 5</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1920x1200x85
            {
                get
                {
                    byte resolutions5 = Resolutions5;
                    bool is1920x1200x85 = resolutions5.CheckBit(Bits.Bit06);

                    return is1920x1200x85;
                }
            }
            #endregion

            #region [private] (bool) Is1920x1440x60: Obtiene un valor que representa la característica '1920 x 1440 @ 60 Hz' del campo 'Resolutions 5'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1920 x 1440 @ 60 Hz</c>' del campo '<c>Resolutions 5</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1920x1440x60
            {
                get
                {
                    byte resolutions5 = Resolutions5;
                    bool is1920x1440x60 = resolutions5.CheckBit(Bits.Bit05);

                    return is1920x1440x60;
                }
            }
            #endregion

            #region [private] (bool) Is1920x1440x75: Obtiene un valor que representa la característica '1920 x 1440 @ 75 Hz' del campo 'Resolutions 5'.
            /// <summary>
            /// Obtiene un valor que representa la característica '<c>1920 x 1440 @ 75 Hz</c>' del campo '<c>Resolutions 5</c>'.
            /// </summary>
            /// <value>
            ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
            ///   <para>Valor de la propiedad.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private bool Is1920x1440x75
            {
                get
                {
                    byte resolutions5 = Resolutions5;
                    bool is1920x1440x75 = resolutions5.CheckBit(Bits.Bit04);

                    return is1920x1440x75;
                }
            }
            #endregion

        #endregion

        #region EDID 1.4 Specification

            #region [private] (ReadOnlyCollection<MonitorResolutionInfo>) GetResolutionCollection(): Obtiene un objeto que representa una colección de resoluciones disponibles.
            /// <summary>
            /// Obtiene un objeto que representa una colección de resoluciones disponibles.
            /// </summary>
            /// <returns>Colección de resoluciones disponibles.</returns>
            [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
            private ReadOnlyCollection<MonitorResolutionInfo> GetResolutionCollection()
            {
                var items = new List<MonitorResolutionInfo>();

                if (Is640x350x85)      items.Add(new MonitorResolutionInfo(640, 350, 85));
                if (Is640x400x85)      items.Add(new MonitorResolutionInfo(640, 400, 85));
                if (Is640x480x85)      items.Add(new MonitorResolutionInfo(640, 480, 85));
                if (Is720x400x85)      items.Add(new MonitorResolutionInfo(720, 400, 85));
                if (Is800x600x85)      items.Add(new MonitorResolutionInfo(800, 600, 85));
                if (Is848x480x60)      items.Add(new MonitorResolutionInfo(848, 480, 60));
                if (Is1024x768x85)     items.Add(new MonitorResolutionInfo(1024, 768, 85));
                if (Is1152x864x75)     items.Add(new MonitorResolutionInfo(1152, 864, 75));
                if (Is1280x768x60)     items.Add(new MonitorResolutionInfo(1280, 768, 60));
                if (Is1280x768x60RB)   items.Add(new MonitorResolutionInfo(1280, 768, 60, true));
                if (Is1280x768x75)     items.Add(new MonitorResolutionInfo(1280, 768, 75));
                if (Is1280x768x85)     items.Add(new MonitorResolutionInfo(1280, 768, 85));
                if (Is1280x960x60)     items.Add(new MonitorResolutionInfo(1280, 960, 60));
                if (Is1280x960x85)     items.Add(new MonitorResolutionInfo(1280, 960, 85));
                if (Is1280x1024x60)    items.Add(new MonitorResolutionInfo(1280, 1024, 60));
                if (Is1280x1024x85)    items.Add(new MonitorResolutionInfo(1280, 1024, 85));
                if (Is1360x768x60)     items.Add(new MonitorResolutionInfo(1360, 768, 60));               
                if (Is1400x1050x60)    items.Add(new MonitorResolutionInfo(1400, 1050, 60));
                if (Is1400x1050x60RB)  items.Add(new MonitorResolutionInfo(1400, 1050, 60, true));
                if (Is1400x1050x75)    items.Add(new MonitorResolutionInfo(1400, 1050, 75));
                if (Is1400x1050x85)    items.Add(new MonitorResolutionInfo(1400, 1050, 85));
                if (Is1440x900x60)     items.Add(new MonitorResolutionInfo(1440, 900, 60));
                if (Is1440x900x60RB)   items.Add(new MonitorResolutionInfo(1440, 900, 60, true));
                if (Is1440x900x75)     items.Add(new MonitorResolutionInfo(1440, 900, 75));
                if (Is1440x900x85)     items.Add(new MonitorResolutionInfo(1440, 900, 85));
                if (Is1600x1200x60)    items.Add(new MonitorResolutionInfo(1600, 1200, 60));
                if (Is1600x1200x65)    items.Add(new MonitorResolutionInfo(1600, 1200, 65));
                if (Is1600x1200x70)    items.Add(new MonitorResolutionInfo(1600, 1200, 70));
                if (Is1600x1200x75)    items.Add(new MonitorResolutionInfo(1600, 1200, 75));
                if (Is1600x1200x85)    items.Add(new MonitorResolutionInfo(1600, 1200, 85));
                if (Is1680x1050x60)    items.Add(new MonitorResolutionInfo(1680, 1050, 60));
                if (Is1680x1050x60RB)  items.Add(new MonitorResolutionInfo(1680, 1050, 60, true));
                if (Is1680x1050x75)    items.Add(new MonitorResolutionInfo(1680, 1050, 75));
                if (Is1680x1050x85)    items.Add(new MonitorResolutionInfo(1680, 1050, 85));
                if (Is1792x1344x60)    items.Add(new MonitorResolutionInfo(1792, 1344, 60));
                if (Is1792x1344x75)    items.Add(new MonitorResolutionInfo(1792, 1344, 75));
                if (Is1856x1392x60)    items.Add(new MonitorResolutionInfo(1856, 1392, 60));
                if (Is1856x1392x75)    items.Add(new MonitorResolutionInfo(1856, 1392, 75));
                if (Is1920x1200x60)    items.Add(new MonitorResolutionInfo(1920, 1200, 60));
                if (Is1920x1200x60RB)  items.Add(new MonitorResolutionInfo(1920, 1200, 60, true));
                if (Is1920x1200x75)    items.Add(new MonitorResolutionInfo(1920, 1200, 75));
                if (Is1920x1200x85)    items.Add(new MonitorResolutionInfo(1920, 1200, 85));
                if (Is1920x1440x60)    items.Add(new MonitorResolutionInfo(1920, 1440, 60));
                if (Is1920x1440x75)    items.Add(new MonitorResolutionInfo(1920, 1440, 75));

                return items.AsReadOnly();
            }
            #endregion

        #endregion
    }
}