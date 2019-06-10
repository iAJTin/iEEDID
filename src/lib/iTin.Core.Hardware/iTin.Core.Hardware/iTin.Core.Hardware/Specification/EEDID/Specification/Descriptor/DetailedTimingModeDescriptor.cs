
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using iTin.Core.Helpers;
    using iTin.Core.Helpers.Enumerations;

    // Data Block Descriptor: Detailed Timing Mode Descriptor Definition
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Pixel Clock               WORD        Valor campo = Pixel Clock / 10000. Se mide en Khz.              |
    // |                                                    LSB almacenado en el byte 0, MSB almacenado en el byte 1        |
    // |                                                    Rango válido: 10Khz - 655,35Mhz en incrementos de 10Khz         |
    // |                                                    Note: Ver PixelClock                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Lower 8 bits              BYTE        Valor entre 00h - ffh. Se mide en pixels.                       |
    // |              Horizontal                                                                                            |
    // |              Addressable Video                                                                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          Lower 8 bits              BYTE        Valor entre 00h - ffh. Se mide en pixels.                       |
    // |              Horizontal                                                                                            |
    // |              Blanking                                                                                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Upper 4 bits              BYTE        Valores entre 00h - 0fh. Se mide en pixels.                     |
    // |              Horizontal                            Nibbles:                                                        |
    // |              Addressable video /                            bit 07-04 (High Nibble) - Horizontal Addressable video |
    // |              Blanking                                       bit 03-00 (Low Nibble)  - Horizontal Blanking          |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Lower 8 bits              BYTE        Valor entre 00h - ffh. Se mide en líneas.                       |
    // |              Vertical                                                                                              |
    // |              Addressable Video                                                                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Lower 8 bits              BYTE        Valor entre 00h - ffh. Se mide en líneas.                       |
    // |              Vertical                                                                                              |
    // |              Blanking                                                                                              |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Upper 4 bits              BYTE        Valores entre 00h - 0fh. Se mide en líneas.                     |
    // |              Vertical                              Nibbles:                                                        |
    // |              Addressable video /                            bit 07-04 (High Nibble) - Vertical Addressable video   |
    // |              Blanking                                       bit 03-00 (Low Nibble)  - Vertical Blanking            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Lower 8 bits              BYTE        Valor entre 00h - ffh. Se mide en pixels.                       |
    // |              Horizontal                                                                                            |
    // |              Front Porch                                                                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 09h          Lower 8 bits              BYTE        Valor entre 00h - ffh. Se mide en pixels.                       |
    // |              Horizontal                                                                                            |
    // |              Sync Pulse Width                                                                                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0ah          Lower 4 bits              BYTE        Valores entre 00h - 0fh. Se mide en líneas.                     |
    // |              Vertical                              Nibbles:                                                        |
    // |              Front Porch /                                  bit 07-04 (High Nibble) - Vertical Front Porch         |
    // |              Sync Pulse Width                               bit 03-00 (Low Nibble)  - Vertical Sync Pulse Width    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0bh          Upper 2 bits              BYTE        2 upper bits:                                                   |
    // |              Horizontal / Vertica                           bit 07-06 - Horizontal Front Porch en pixels.          |
    // |              Front Porch                                    bit 05-04 - Horizontal Sync Pulse Width en pixels.     |
    // |              Horizontal / Vertical                          bit 03-02 - Vertical Front Porch en líneas.            |
    // |              Sync Pulse Width                               bit 01-00 - Vertical Sync Pulse Width en líneas.       |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0ch          Lower 8 bits              BYTE        Valor entre 00h - ffh. Se mide en mm.                           |
    // |              Horizontal                                                                                            |
    // |              Addressable Video                                                                                     |
    // |              Image Size                                                                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0ch          Lower 8 bits              BYTE        Valor entre 00h - ffh. Se mide en mm.                           |
    // |              vertical                                                                                              |
    // |              Addressable Video                                                                                     |
    // |              Image Size                                                                                            |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0eh          Upper 4 bits              BYTE        Valores entre 00h - 0fh. Se mide en mm.                         |
    // |              Horizontal / Vertical                 Nibbles:                                                        |
    // |              Addressable video                              bit 07-04 (High Nibble) - Horizontal Addressable video |
    // |              Image Size                                                               Image Size                   |
    // |                                                             bit 03-00 (Low Nibble)  - vertical Addressable video   |
    // |                                                                                       Image Size                   |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0fh          Horizontal                BYTE        Valor entre 00h - ffh. Se mide en pixels.                       |
    // |              Border                                Los bordes horizontales derecho e izquierdo son iguales.        |
    // |                                                    Note: Ver HorizontalBorder                                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 10h          Vertical                  BYTE        Valor entre 00h - ffh. Se mide en pixels.                       |
    // |              Border                                Los bordes verticales superior e inferior son iguales.          |
    // |                                                    Note: Ver VerticalBorder                                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 11h          Flags                     BYTE                 bit 07: Signal Interface Type.                         |
    // |                                                                     0b - Non Interlaced ( 1frame = 1 fields )      |
    // |                                                                     1b - Interlaced ( 1frame = 2 fields )          |
    // |                                                                     Note: Ver IsInterlaced                         |
    // |                                                                                                                    |
    // |                                                    bits 06:05 - 00: Stereo Viewing Support                         |
    // |                                                                     00xb - Normal Display - No stereo              |
    // |                                                                     010b - Field sequential stereo, right image    |
    // |                                                                     011b - 2-way interleaved stereo, right image on|
    // |                                                                            even lines.                             |
    // |                                                                     100b - Field sequential stereo, left image     |
    // |                                                                     101b - 2-way interleaved stereo, left image on |
    // |                                                                            even lines.                             |
    // |                                                                     110b - 4-way interleaved stereo                |
    // |                                                                     111b - Side-by-side interleaved stereo         |
    // |                                                                     Note: Ver GetStereoViewingSupport(byte)        |
    // |                                                                                                                    |
    // |                                                    bits 04:01:                                                     |
    // |                                                       4 3 2 1 Analog Sync Signal Definiton                         |
    // |                                                       0 0 _ _ Analog Composite Sync                                |
    // |                                                       0 1 _ _ Bipolar Analog Composite Sync                        |
    // |                                                       0 _ 0 _ -- Without Serrations                                |
    // |                                                       0 _ 1 _ -- With Serrations (H-sync during V-sync)            |
    // |                                                       0 _ _ 0 ---- Sync on green signal only                       |
    // |                                                       0 _ _ 1 ---- Sync on all three (RGB) video signals           |
    // |                                                                                                                    |
    // |                                                       4 3 2 1 Digital Sync Signal Definiton                        |
    // |                                                       1 0 _ _ Digital Composite Sync                               |
    // |                                                       1 0 0 _ -- Without Serrations                                |
    // |                                                       1 0 1 _ -- With Serrations (H-sync during V-sync)            |
    // |                                                       1 1 _ _ Digital Separate Sync                                |
    // |                                                       1 1 0 _ -- Vertical sync is negative                         |
    // |                                                       1 1 1 _ -- Vertical sync is positive                         |
    // |                                                       1 _ _ 0 ---- Horizontal sync is negative (outside of V-sync) |
    // |                                                       1 _ _ 1 ---- Horizontal sync is positive (outside of V-sync) |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Especialización de la clase <see cref="BaseDataSection"/> que representa a un <see cref="KnownEdidSection.DataBlocks"/> de tipo <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/>.
    /// </summary>
    sealed class DetailedTimingModeDescriptor : BaseDataSection
    {
        #region Enumeraciones

            #region [private] [enum] KnownSignalInterfaceType: Enumeración de tipo conocidos de interfaces de señal.
            /// <summary>
            /// Enumeración de tipo conocidos de interfaces de señal.
            /// </summary> 
            enum KnownSignalInterfaceType
            {
                /// <summary>
                /// No entrelazada.
                /// </summary>
                NonInterlaced,
                /// <summary>
                /// Entrelazada.
                /// </summary>
                Interlaced,
            }
            #endregion

            #region [private] [enum] KnownSyncSignalType: Enumeración de tipo conocideos de señales de sincronismo.
            /// <summary>
            /// Enumeración de tipo conocideos de señales de sincronismo.
            /// </summary> 
            enum KnownSyncSignalType
            {
                /// <summary>
                /// Analógica.
                /// </summary>
                Analog,
                /// <summary>
                /// Digital
                /// </summary>
                Digital,
            }
            #endregion

        #endregion

        #region Constructor/es

            #region [public] DetailedTimingModeDescriptor(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de este bloque sin tratar.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="DetailedTimingModeDescriptor"/> con los datos de este bloque sin tratar.
            /// </summary>
            /// <param name="blockData">Datos de este bloque sin tratar.</param>
            public DetailedTimingModeDescriptor(ReadOnlyCollection<byte> blockData) : base(blockData)
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
                var propertyId = (KnownDetailedTimingModeDescriptorProperty)propertyKey.PropertyId;

                switch (propertyId)
                {
                    #region [0x00] - [Pixel Clock] - [Int32] - [Khz]
                    case KnownDetailedTimingModeDescriptorProperty.PixelClock:
                        value = PixelClock;
                        break;
                    #endregion

                    #region [0x01] - [Horizontal Resolution Pixels] - [Int32] - [Pixels]
                    case KnownDetailedTimingModeDescriptorProperty.HorizontalResolution:
                        value = HorizontalResolution;
                        break;
                    #endregion

                    #region [0x02] - [Horizontal Blanking Pixels] - [Int32] - [Pixels]
                    case KnownDetailedTimingModeDescriptorProperty.HorizontalBlanking:
                        value = HorizontalBlanking;
                        break;
                    #endregion

                    #region [0x03] - [Vertical Lines] - [Int32] - [Lines]
                    case KnownDetailedTimingModeDescriptorProperty.VerticalLines:
                        value = VerticalLines;
                        break;
                    #endregion

                    #region [0x04] - [Vertical Blanking Lines] - [Int32] - [Lines]
                    case KnownDetailedTimingModeDescriptorProperty.VerticalBlanking:
                        value = VerticalBlanking;
                        break;
                    #endregion

                    #region [0x05] - [Horizontal Front Porch in Pixels] - [Int32] - [Pixels]
                    case KnownDetailedTimingModeDescriptorProperty.HorizontalFrontPorch:
                        value = HorizontalFrontPorch;
                        break;
                    #endregion

                    #region [0x06] - [Horizontal Sync Pulse Width in Pixels] - [Int32] - [Pixels]
                    case KnownDetailedTimingModeDescriptorProperty.HorizontalSyncPulseWidth:
                        value = HorizontalSyncPulseWidth;
                        break;
                    #endregion

                    #region [0x07] - [Vertical Front Porch in Lines] - [Int32] - [Lines]
                    case KnownDetailedTimingModeDescriptorProperty.VerticalFrontPorch:
                        value = VerticalFrontPorch;
                        break;
                    #endregion

                    #region [0x08] - [Vertical Sync Pulse Width in Lines] - [Int32] - [Lines]
                    case KnownDetailedTimingModeDescriptorProperty.VerticalSyncPulseWidth:
                        value = VerticalSyncPulseWidth;
                        break;
                    #endregion 

                    #region [0x09] - [Horizontal Addressable Video Image Size] - [Int32] - [mm]
                    case KnownDetailedTimingModeDescriptorProperty.HorizontalImageSize:
                        value = HorizontalImageSize;
                        break;
                    #endregion

                    #region [0x0a] - [Vertical Addressable Video Image Size] - [Int32] - [mm]
                    case KnownDetailedTimingModeDescriptorProperty.VerticalImageSize:
                        value = VerticalImageSize;
                        break;
                    #endregion

                    #region [0x0b] - [Right Horizontal Border or Left Horizontal Border] - [Byte] - [Pixels]
                    case KnownDetailedTimingModeDescriptorProperty.HorizontalBorder:
                        value = HorizontalBorder;
                        break;
                    #endregion

                    #region [0x0c] - [Top Vertical Border or Bottom Vertical Border] - [Byte] - [Pixels]
                    case KnownDetailedTimingModeDescriptorProperty.VerticalBorder:
                        value = VerticalBorder;
                        break;
                    #endregion

                    #region [0x0d] - [Byte 17]

                        #region [0x0d] - [Byte 17 -> Signal Interface Type] - [Boolean]
                        case KnownDetailedTimingModeDescriptorProperty.Interlaced:
                            value = IsInterlaced;
                            break;
                        #endregion

                        #region [0x0d] - [Byte 17 -> Stereo Viewing Support] - [String]
                        case KnownDetailedTimingModeDescriptorProperty.StereoViewingSupport:
                            value = GetStereoViewingSupport(StereoViewingSupport);
                            break;
                        #endregion

                        #region [0x0d] - [Byte 17 -> Sync Signal Definition] - [String]
                        case KnownDetailedTimingModeDescriptorProperty.SyncSignalType:
                            value = SyncSignalType;
                            break;
                        #endregion
                    
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
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.PixelClock, PixelClock);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalResolution, HorizontalResolution);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalBlanking, HorizontalBlanking);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.VerticalLines, VerticalLines);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.VerticalBlanking, VerticalBlanking);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalFrontPorch, HorizontalFrontPorch);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalSyncPulseWidth, HorizontalSyncPulseWidth);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.VerticalFrontPorch, VerticalFrontPorch);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.VerticalSyncPulseWidth, VerticalSyncPulseWidth);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalImageSize, HorizontalImageSize);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.VerticalImageSize, VerticalImageSize);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.HorizontalBorder, HorizontalBorder);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.VerticalBorder, VerticalBorder);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.IsInterlaced, IsInterlaced);
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.StereoViewingSupport, GetStereoViewingSupport(StereoViewingSupport));
                items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Definition.DetailedTimingMode.SyncSignalType, SyncSignalType);
                #endregion
            }
            #endregion

        #endregion

        #region Miembros privados

        #region [private] (int) PixelClock: Obtiene un valor que representa al campo 'Pixel Clock'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Pixel Clock</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Int32"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private int PixelClock => LogicHelper.Word(RawData[0x00], RawData[0x01]) * 10000;
        #endregion

        #region [private] (int) HorizontalResolution: Obtiene un valor que representa al campo 'Horizontal Addressable Video in pixels'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Horizontal Addressable Video in pixels</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Int32"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private int HorizontalResolution
        {
            get
            {
                byte lowHorizontalAddressableVideo = RawData[0x02];
                byte upperHorizontalAddressableVideo = HorizontalResolutionAndBlanking[0];

                int horizontalResolution = LogicHelper.Word(lowHorizontalAddressableVideo, upperHorizontalAddressableVideo);
                return horizontalResolution;
            }
        }
        #endregion

        #region [private] (int) HorizontalBlanking: Obtiene un valor que representa al campo 'Horizontal Blanking in Pixels'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Horizontal Blanking in Pixels</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Int32"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private int HorizontalBlanking
        {
            get
            {
                byte lowHorizontalBlankingPixels = RawData[0x03];
                byte upperHorizontalBlankingPixels = HorizontalResolutionAndBlanking[1];

                int horizontalBlankingPixels = LogicHelper.Word(lowHorizontalBlankingPixels, upperHorizontalBlankingPixels);
                return horizontalBlankingPixels;
            }
        }
        #endregion

        #region [private] (byte[]) HorizontalResolutionAndBlanking: Obtiene un valor que representa al campo 'Lower Nibble Horizontal Addressable Pixels / Lower Nibble Horizontal Blanking Pixels'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Lower Nibble Horizontal Addressable Pixels / Lower Nibble Horizontal Blanking Pixels</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/>[]</para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private byte[] HorizontalResolutionAndBlanking
        {
            get
            {
                byte[] horizontalAddresableAndBlankingArray = RawData[0x04].ToNibbles();
                return horizontalAddresableAndBlankingArray;
            }
        }
        #endregion

        #region [private] (int) VerticalLines: Obtiene un valor que representa al campo 'Vertical Addressable Video in lines'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Vertical Addressable Video in lines</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Int32"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private int VerticalLines
        {
            get
            {
                byte lowVerticalLinesVideo = RawData[0x05];
                byte upperVerticalLinesVideo = VerticalLinesAndBlanking[0];

                int verticalLines = LogicHelper.Word(lowVerticalLinesVideo, upperVerticalLinesVideo);
                return verticalLines;
            }
        }
        #endregion

        #region [private] (int) VerticalBlanking: Obtiene un valor que representa al campo 'Vertical Blanking in lines'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Vertical Blanking in lines</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Int32"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private int VerticalBlanking
        {
            get
            {
                byte lowVerticalBlankingLines = RawData[0x06];
                byte upperVerticalBlankingLines = VerticalLinesAndBlanking[1];

                int verticalBlankingLines = LogicHelper.Word(lowVerticalBlankingLines, upperVerticalBlankingLines);
                return verticalBlankingLines;
            }
        }
        #endregion

        #region [private] (byte[]) VerticalLinesAndBlanking: Obtiene un valor que representa al campo 'Upper Nibble Vertical Addressable Video in lines / Upper Nibble Vertical Blanking in lines'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Upper Nibble Vertical Addressable Video in lines / Upper Nibble Vertical Blanking in lines</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/>[]</para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private byte[] VerticalLinesAndBlanking
        {
            get
            {
                byte[] verticalLinesAndBlankingArray = RawData[0x07].ToNibbles(); 
                return verticalLinesAndBlankingArray;
            }
        }
        #endregion

        #region [private] (int) HorizontalFrontPorch: Obtiene un valor que representa al campo 'Horizontal Front Porch in Pixels'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Horizontal Front Porch in Pixels</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Int32"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private int HorizontalFrontPorch
        {
            get
            {
                byte lowHorizontalFrontPorch = RawData[0x08];
                byte upperHorizontalFrontPorch = UpperHorizontalFrontPorch;

                int horizontalFrontPorch = LogicHelper.Word(lowHorizontalFrontPorch, upperHorizontalFrontPorch);
                return horizontalFrontPorch;
            }
        }
        #endregion

        #region [private] (int) HorizontalSyncPulseWidth: Obtiene un valor que representa al campo 'Horizontal Sync Pulse Width in Pixels'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Horizontal Sync Pulse Width in Pixels</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Int32"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private int HorizontalSyncPulseWidth
        {
            get
            {
                byte lowHorizontalSyncPulseWidth = RawData[0x09];
                byte upperHorizontalSyncPulseWidth = UpperHorizontalSyncPulseWidth;

                int horizontalSyncPulseWidth = LogicHelper.Word(lowHorizontalSyncPulseWidth, upperHorizontalSyncPulseWidth);
                return horizontalSyncPulseWidth;
            }
        }
        #endregion

        #region [private] (byte[]) LowVerticalFrontPorchAndSyncPulse: Obtiene un valor que representa al campo 'Upper Nibble Vertical Front Porch in Lines / Upper Nibble Vertical Sync Pulse Width in Lines'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Upper Nibble Vertical Front Porch in Lines / Upper Nibble Vertical Sync Pulse Width in Lines</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/>[]</para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private byte[] LowVerticalFrontPorchAndSyncPulse
        {
            get
            {
                byte[] lowVerticalFrontPorchAndSyncPulseArray = RawData[0x0a].ToNibbles();
            return lowVerticalFrontPorchAndSyncPulseArray;
            }
        }
        #endregion

        #region [private] (int) VerticalFrontPorch: Obtiene un valor que representa al campo 'Vertical Front Porch in Lines'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Vertical Front Porch in Lines</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Int32"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private int VerticalFrontPorch
        {
            get
            {
                byte lowVerticalFrontPorch = LowVerticalFrontPorchAndSyncPulse[0];
                byte upperVerticalFrontPorch = UpperVerticalFrontPorch;

                int verticalFrontPorch = LogicHelper.Word(lowVerticalFrontPorch, upperVerticalFrontPorch);
                return verticalFrontPorch;
            }
        }
        #endregion

        #region [private] (int) VerticalSyncPulseWidth: Obtiene un valor que representa al campo 'Vertical Sync Pulse Width in Lines'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Vertical Sync Pulse Width in Lines</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Int32"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private int VerticalSyncPulseWidth
        {
            get
            {
                byte lowVerticalSyncPulseWidth = LowVerticalFrontPorchAndSyncPulse[1];
                byte upperVerticalSyncPulseWidth = UpperVerticalSyncPulseWidth;

                int verticalSyncPulseWidth = LogicHelper.Word(lowVerticalSyncPulseWidth, upperVerticalSyncPulseWidth);
                return verticalSyncPulseWidth;
            }
        }
        #endregion

        #region [private] (byte[]) CommonBitDefinition: Obtiene un valor que representa al campo 'Bit Definitions'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Bit Definitions</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/>[]</para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private byte[] CommonBitDefinition
        {
            get
            {
                byte[] commonBitDefinitionArray = RawData[0x0b].ToNibbles();
            return commonBitDefinitionArray;
            }
        }
        #endregion

        #region [private] (byte) UpperHorizontalFrontPorch: Obtiene un valor que representa la característica 'Horizontal Front Porch in Pixels' del campo 'Bit Definitions'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Horizontal Front Porch in Pixels</c>' del campo '<c>Bit Definitions</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private byte UpperHorizontalFrontPorch
        {
            get
            {
                byte[] commonBitDefinitionArray = CommonBitDefinition;
                byte[] upperNibbleCommonBitDefinition = commonBitDefinitionArray[0].ToNibbles();
            byte upperHorizontalFrontPorch = upperNibbleCommonBitDefinition[0];

                return upperHorizontalFrontPorch;
            }
        }
        #endregion

        #region [private] (byte) UpperHorizontalSyncPulseWidth: Obtiene un valor que representa la característica 'Horizontal Sync Pulse Width in Pixels' del campo 'Bit Definitions'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Horizontal Sync Pulse Width in Pixels</c>' del campo '<c>Bit Definitions</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private byte UpperHorizontalSyncPulseWidth
        {
            get
            {
                byte[] commonBitDefinitionArray = CommonBitDefinition;
                byte[] upperNibbleCommonBitDefinition = commonBitDefinitionArray[0].ToNibbles();
                byte upperHorizontalSyncPulseWidth = upperNibbleCommonBitDefinition[1];

                return upperHorizontalSyncPulseWidth;
            }
        }
        #endregion

        #region [private] (byte) UpperVerticalFrontPorch: Obtiene un valor que representa la característica 'Vertical Front Porch in Pixels' del campo 'Bit Definitions'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Vertical Front Porch in Pixels</c>' del campo '<c>Bit Definitions</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private byte UpperVerticalFrontPorch
        {
            get
            {
                byte[] commonBitDefinitionArray = CommonBitDefinition;
                byte[] upperNibbleCommonBitDefinition = commonBitDefinitionArray[1].ToNibbles();
                byte upperVerticalFrontPorch = upperNibbleCommonBitDefinition[0];

                return upperVerticalFrontPorch;
            }
        }
        #endregion

        #region [private] (byte) UpperVerticalSyncPulseWidth: Obtiene un valor que representa la característica 'Vertical Sync Pulse Width in Pixels' del campo 'Bit Definitions'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Vertical Sync Pulse Width in Pixels</c>' del campo '<c>Bit Definitions</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private byte UpperVerticalSyncPulseWidth
        {
            get
            {
                byte[] commonBitDefinitionArray = CommonBitDefinition;
                byte[] upperNibbleCommonBitDefinition = commonBitDefinitionArray[1].ToNibbles();
                byte upperVerticalSyncPulseWidth = upperNibbleCommonBitDefinition[1];

                return upperVerticalSyncPulseWidth;
            }
        }
        #endregion

        #region [private] (int) HorizontalImageSize: Obtiene un valor que representa al campo 'Horizontal Addressable Video Image Size in mm'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Horizontal Addressable Video Image Size in mm</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Int32"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private int HorizontalImageSize
        {
            get
            {
                byte lowHorizontalImageSize = RawData[0x0c];
                byte upperHorizontalImageSize = UpperHorizontalAndVerticalImageSize[0];

                int horizontalImageSize = LogicHelper.Word(lowHorizontalImageSize, upperHorizontalImageSize);
                return horizontalImageSize;
            }
        }
        #endregion

        #region [private] (int) VerticalImageSize: Obtiene un valor que representa al campo 'Vertical Addressable Video Image Size in mm'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Vertical Addressable Video Image Size in mm</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Int32"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private int VerticalImageSize
        {
            get
            {
                byte lowVerticalImageSize = RawData[0x0d];
                byte upperVerticalImageSize = UpperHorizontalAndVerticalImageSize[1];

                int verticalImageSize = LogicHelper.Word(lowVerticalImageSize, upperVerticalImageSize);
                return verticalImageSize;
            }
        }
        #endregion

        #region [private] (byte[]) UpperHorizontalAndVerticalImageSize: Obtiene un valor que representa al campo 'Upper Horizontal Addressable Video Image Size in mm / Upper Vertical Addressable Video Image Size in mm'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Upper Horizontal Addressable Video Image Size in mm / Upper Vertical Addressable Video Image Size in mm</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/>[]</para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private byte[] UpperHorizontalAndVerticalImageSize
        {
            get
            {
                byte[] upperHorizontalAndVerticalImageSizeArray = RawData[0x0e].ToNibbles();
                return upperHorizontalAndVerticalImageSizeArray;
            }
        }
        #endregion

        #region [private] (byte) HorizontalBorder: Obtiene un valor que representa al campo 'Right Horizontal Border or Left Horizontal Border in Pixels'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Right Horizontal Border or Left Horizontal Border in Pixels</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private byte HorizontalBorder
        {
            get
            {
                byte horizontalBorder = RawData[0x0f];
                return horizontalBorder;
            }
        }
        #endregion

        #region [private] (byte) VerticalBorder: Obtiene un valor que representa al campo 'Top Vertical Border or Bottom Vertical Border in Pixels'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Right Horizontal Border or Left Horizontal Border in Pixels</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private byte VerticalBorder
        {
            get
            {
                byte verticalBorder = RawData[0x10];
                return verticalBorder;
            }
        }
        #endregion

        #region [private] (KnownSignalInterfaceType) SignalInterfaceType: Obtiene un valor que representa la característica 'Signal Interface Type' del campo 'Byte 17'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Signal Interface Type</c>' del campo '<c>Byte 17</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="KnownSignalInterfaceType"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private KnownSignalInterfaceType SignalInterfaceType
        {
            get
            {
                byte byte17 = RawData[0x11];
                var signalInterfaceType = (byte) (byte17 >> 7 & 0x01);

                return (KnownSignalInterfaceType)signalInterfaceType;
            }
        }
        #endregion

        #region [private] (bool) IsInterlaced: Obtiene un valor que representa la característica 'Interlaced' de la característica 'de la característica'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Interlaced</c>' de la característica'<c>de la característica</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private bool IsInterlaced
        {
            get
            {
                bool isInterlaced = false;
                KnownSignalInterfaceType signalInterfaceType = SignalInterfaceType;

                if (signalInterfaceType == KnownSignalInterfaceType.Interlaced)
                    isInterlaced = true;

                return isInterlaced;
            }
        }
        #endregion

        #region [private] (byte) StereoViewingSupport: Obtiene un valor que representa al campo 'Right Horizontal Border or Left Horizontal Border in Pixels'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Right Horizontal Border or Left Horizontal Border in Pixels</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private byte StereoViewingSupport
        {
            get
            {
                byte byte17 = RawData[0x11];
                var stereoViewingSupport = (byte) (byte17 >> 4 & 0x07);

                return stereoViewingSupport;
            }
        }
        #endregion

        #region [private] (KnownSyncSignalType) SyncSignal: Obtiene un valor que representa la característica 'Signal Type' del campo 'Byte 17'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Signal Type</c>' del campo '<c>Byte 17</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="KnownSyncSignalType"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private KnownSyncSignalType SyncSignal
        {
            get
            {
                byte byte17 = RawData[0x11];
                var syncSignal = (byte)(byte17 >> 4 & 0x01);

                return (KnownSyncSignalType)syncSignal;
            }
        }
        #endregion

        #region [private] (bool) IsAnalogBipolar: Obtiene un valor que representa la característica 'Interlaced' de la característica 'de la característica'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Interlaced</c>' de la característica'<c>de la característica</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private bool IsAnalogBipolar
        {
            get
            {
                byte byte17 = RawData[0x11];
                bool isAnalogBipolar = byte17.CheckBit(Bits.Bit03);

                return isAnalogBipolar;
            }
        }
        #endregion

        #region [private] (bool) WithAnalogSerrations: Obtiene un valor que representa la característica 'Interlaced' de la característica 'de la característica'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Interlaced</c>' de la característica'<c>de la característica</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private bool WithAnalogSerrations
        {
            get
            {
                byte byte17 = RawData[0x11];
                bool withAnalogSerrations = byte17.CheckBit(Bits.Bit02);

                return withAnalogSerrations;
            }
        }
        #endregion

        #region [private] (bool) SyncOnThreeVideoSignals: Obtiene un valor que representa la característica 'Interlaced' de la característica 'de la característica'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Interlaced</c>' de la característica'<c>de la característica</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private bool SyncOnThreeVideoSignals
        {
            get
            {
                byte byte17 = RawData[0x11];
                bool syncOnThreeVideoSignals = byte17.CheckBit(Bits.Bit01);

                return syncOnThreeVideoSignals;
            }
        }
        #endregion

        #region [private] (bool) IsDigitalSeparateSync: Obtiene un valor que representa la característica 'Interlaced' de la característica 'de la característica'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Interlaced</c>' de la característica'<c>de la característica</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private bool IsDigitalSeparateSync => RawData[0x11].CheckBit(Bits.Bit03);
        #endregion

        #region [private] (bool) WithDigitalSerrations: Obtiene un valor que representa la característica 'Interlaced' de la característica 'de la característica'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Interlaced</c>' de la característica'<c>de la característica</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private bool WithDigitalSerrations => WithAnalogSerrations;
        #endregion

        #region [private] (bool) IsVerticalSyncPositive: Obtiene un valor que representa la característica 'Interlaced' de la característica 'de la característica'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Interlaced</c>' de la característica'<c>de la característica</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private bool IsVerticalSyncPositive => RawData[0x11].CheckBit(Bits.Bit02);
        #endregion

        #region [private] (bool) IsPositiveHorizontalSync: Obtiene un valor que representa la característica 'Interlaced' de la característica 'de la característica'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Interlaced</c>' de la característica'<c>de la característica</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private bool IsPositiveHorizontalSync => RawData[0x11].CheckBit(Bits.Bit01);
        #endregion

        #region [private] (bool) SyncSignalType: Obtiene un valor que representa la característica 'Interlaced' de la característica 'de la característica'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Interlaced</c>' de la característica'<c>de la característica</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        private string SyncSignalType
        {
            get
            {
                string syncOn = string.Empty;
                string signalType = string.Empty;
                string serrations = string.Empty;
                string verticalSync = string.Empty;
                string horizontalSync = string.Empty;
                string syncSignalValue = string.Empty;

                KnownSyncSignalType syncSignal = SyncSignal;
                switch (syncSignal)
                {
                    #region Digital
                    case KnownSyncSignalType.Digital:
                        bool isDigitalSeparateSync = IsDigitalSeparateSync;
                        switch (isDigitalSeparateSync)
                        {
                            case true:
                                signalType = "Digital separate sync, ";

                                bool isVerticalSyncPositive = IsVerticalSyncPositive;
                                switch (isVerticalSyncPositive)
                                {
                                    case true:
                                        verticalSync = "Vertical sync is positive, ";
                                        break;

                                    case false:
                                        verticalSync = "Vertical sync is negative, ";
                                        break;
                                }


                                bool isPositiveHorizontalSync = IsPositiveHorizontalSync;
                                switch (isPositiveHorizontalSync)
                                {
                                    case true:
                                        horizontalSync = "Horizontal sync is negative (outside of V-sync).";
                                        break;

                                    case false:
                                        horizontalSync = "Horizontal sync is positive (outside of V-sync).";
                                        break;
                                }

                                syncSignalValue = string.Concat(signalType, verticalSync, horizontalSync);
                                break;

                            case false:
                                signalType = "Digital composite sync ";

                                bool withDigitalSerrations = WithDigitalSerrations;
                                switch (withDigitalSerrations)
                                {
                                    case true:
                                        serrations = "with serrations (H-sync during V-sync) ";
                                        break;

                                    case false:
                                        serrations = "without serrantions ";
                                        break;
                                }
                                syncSignalValue = string.Concat(signalType, serrations);
                                break;
                        }
                        break;
                    #endregion

                    #region Analog
                    case KnownSyncSignalType.Analog:
                        bool isBipolar = IsAnalogBipolar;
                        switch (isBipolar)
                        {
                            case true:
                                signalType = "Analog bipolar composite sync ";
                                break;

                            case false:
                                signalType = "Analog composite sync ";
                                break;
                        }

                        bool withAnalogSerrations = WithAnalogSerrations;
                        switch (withAnalogSerrations)
                        {
                            case true:
                                serrations = "with serrations (H-sync during V-sync) ";
                                break;

                            case false:
                                serrations = "without serrantions ";
                                break;
                        }

                        bool syncOnThreeVideoSignals = SyncOnThreeVideoSignals;
                        switch (syncOnThreeVideoSignals)
                        {
                            case true:
                                syncOn = "on all three (RGB) video signals.";
                                break;

                            case false:
                                syncOn = "on green signal only.";
                                break;
                        }

                        syncSignalValue = string.Concat(signalType, serrations, syncOn);
                        break;
                    #endregion
                }

                return syncSignalValue;
            }
        }
        #endregion

        #endregion

        #region EDID 1.4 Specification

        #region [private] {static} (string) GetStereoViewingSupport(byte): Obtiene 
        /// <summary>
        /// Detaileds the timing flags.
        /// </summary>
        /// <param name="code">Valor a analizar.</param>
        /// <returns></returns>
        private static string GetStereoViewingSupport(byte code)
        {
            var value = new[]
            {
                "Normal Display (No stereo)",
                "Normal Display (No stereo)",
                "Field sequential stereo, right image",
	            "2-way interleaved stereo, right image on even lines",
	            "Field sequential stereo, left image",
	            "2-way interleaved stereo, left image on even lines",
	            "4-way interleaved stereo",
	            "Side-by-side interleaved stereo"	                                  
            };

            return value[code];
        }
        #endregion

        #endregion
    }
}
