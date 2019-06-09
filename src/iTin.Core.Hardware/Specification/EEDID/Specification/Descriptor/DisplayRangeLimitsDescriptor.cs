
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.ObjectModel;

    // Data Block Descriptor: Display Range Limits & Additional Timming Descriptor Block Definition
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                                                                      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Display Range             BYTE        Flags. Resto de valores reservados no usar.                                                      |
    // |              Limits                                7 6 5 4 | 3 2 1 0                                                                                |
    // |              Offsets                               0 0 0 0 | _ _ 0 0 -> Vertical rate offset son cero.                                              |
    // |                                                    0 0 0 0 | _ _ 1 0 -> Max. Vertical Rate +255 Hz Offset, Min. Vertical Rate sin offset.           |
    // |                                                    0 0 0 0 | _ _ 1 1 -> Max. Vertical Rate +255 Hz Offset, Min. Vertical Rate +255 Hz offset.       |
    // |                                                    0 0 0 0 | 0 0 _ _ -> Horizontal rate offset son cero.                                            |
    // |                                                    0 0 0 0 | 1 0 _ _ -> Max. Horizontal Rate +255 KHz Offset, Min. Horizontal Rate sin offset.      |
    // |                                                    0 0 0 0 | 1 1 _ _ -> Max. Horizontal Rate +255 KHz Offset, Min. Horizontal Rate +255 KHz offset. |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Minimun Vertical          BYTE        Valores:                                                                                         |
    // |              Rate                                                 00h - Reserved.                                                                   |
    // |                                                             01h - ffh - Si [Byte 04h, bits 0, 1] <> 11b -> rate in Hz (rango 1Hz - 255Hz)           |
    // |                                                                         Si [Byte 04h, bits 0, 1] == 11b -> rate in Hz (rango 256Hz - 510Hz)         |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Maximun Vertical          BYTE        Valores:                                                                                         |
    // |              Rate                                                 00h - Reserved.                                                                   |
    // |                                                             01h - ffh - Si [Byte 04h, bit 1] <> 1b -> rate in Hz (rango 1Hz - 255Hz)                |
    // |                                                                         Si [Byte 04h, bit 1] == 1b -> rate in Hz (rango 256Hz - 510Hz)              |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          Minimun Horizontal        BYTE        Valores:                                                                                         |
    // |              Rate                                                 00h - Reserved.                                                                   |
    // |                                                             01h - ffh - Si [Byte 04h, bits 3, 2] <> 11b -> rate in KHz (rango 1KHz - 255KHz)        |
    // |                                                                         Si [Byte 04h, bits 3, 2] == 11b -> rate in KHz (rango 256KHz - 510KHz)      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Maximun Horizontal        BYTE        Valores:                                                                                         |
    // |              Rate                                                 00h - Reserved.                                                                   |
    // |                                                             01h - ffh - Si [Byte 04h, bit 3] <> 1b -> rate in KHz (rango 1KHz - 255KHz)             |
    // |                                                                         Si [Byte 04h, bit 3] == 1b -> rate in KHz (rango 256KHz - 510KHz)           |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Maximun Pixel Clock       BYTE        Valores:                                                                                         |
    // |                                                                   00h - Reserved.                                                                   |
    // |                                                             01h - ffh - Binary coded clock rate in Mhz / 10. Ejemplo: 130Mhz es '0dh'.              |
    // |                                                                         Este valor se ha de redondear al multiplo de 10Mhz mas cercano.             |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Video Timming             BYTE        Bytes 0ah -> 11h indicate support for additional video timings.                                  |
    // |              Support Flags                         Valores:                                                                                         |
    // |                                                                   00h - Default GTF supported if bit 0 in Feature Support Byte at address 18h = 1.  |
    // |                                                                   01h - Range Limits Only. No additional timing information is provided.            |
    // |                                                                   02h - Secondary GTF supported. Requires support for Default GTF.                  |
    // |                                                                   03h - Reserved for future timing definitions.                                     |
    // |                                                                   04h - CTV supported if bit 0 in Feature Support Byte at address 18h = 1.          |
    // |                                                             05h - ffh - Reserved for future timing definitions.                                     |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Line Feed / Video         BYTE        Line feed (0ah) , si Byte 0ah = 00h ó si Byte 0ah = 01h.                                         |
    // |              Timing Data                           video Timing Data (00h -> ffh), si Byte 0ah = 02h ó si Byte 0ah = 04h.                           |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h -> 0ch   Space / Video             7 BYTEs     Space (20h) , si Byte 0ah = 00h ó si Byte 0ah = 01h.                                             |
    // |              Timing Data                           video Timing Data (00h -> ffh), si Byte 0ah = 02h ó si Byte 0ah = 04h.                           |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Especialización de la clase <see cref="BaseDataSection"/> que representa a un <see cref="KnownEdidSection.DataBlocks"/> de tipo <see cref="KnownEdidDataBlockDescriptor.DisplayRangeLimits"/>.
    /// </summary>
    sealed class DisplayRangeLimitsDescriptor : BaseDataSection
    {
        #region Constructor/es

            #region [public] DisplayRangeLimitsDescriptor(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de este bloque sin tratar.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="DisplayRangeLimitsDescriptor"/> con los datos de este bloque sin tratar.
            /// </summary>
            /// <param name="blockData">Datos de este bloque sin tratar.</param>
            public DisplayRangeLimitsDescriptor(ReadOnlyCollection<byte> blockData) : base(blockData)
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
                var propertyId = (KnownDisplayRangeLimitsDescriptorProperty)propertyKey.PropertyId;

                switch (propertyId)
                {
                    case KnownDisplayRangeLimitsDescriptorProperty.FaltanTodasLasClaves:
                        value = 0;
                        break;
                }

                return value;
            }
            #endregion

            #region [protected] {override} (void) Parse(Hashtable): Obtiene la colección de items de este bloque.
            /// <summary>
            /// Obtiene la colección de items de este bloque.
            /// </summary>
            /// <param name="items">Colección de items de este bloque.</param>
            protected override void Parse(Hashtable items)
            {
            }
            #endregion

        #endregion
    }
}