
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;

    /*  
        •—————•                 •—————•        •—————•          Dónde:
        | FLH |                 | FCH |        | FRH |                 · FL: Front Left
        •—————•                 •—————•        •—————•                 · FC: Front Center
                                                                       · FR: Front Center
        •—————•  •————• •—————• •————• •—————• •————• •—————•          · FLC: Front Left Center
        | FLW |  | FL | | FLC | | FC | | FRC | | FR | | FRW |          · FRC: Front Center
        •—————•  •————• •—————• •————• •—————• •————• •—————•          · RL: Rear Left
                                                                       · RC: Rear Center
       FRONT                                          •—————•          · RR: Rear Right
                                                      | LFE |          · RLC: Rear Left Center
         |                                            •—————•          · RRC: Rear Right Center
         |               •————•                                        · LFE: Low frequency effect
         |               | TC |                                        · FLW: Front Left Wide
         |               •————•                                        · FRW: Front Right Wide
                                                                       · FLH: Front Left High
       REAR                                                            · FCH: Front Center High
                                                                       · FRH: Front Right High
         •————• •—————• •————• •—————• •————•                          · TC: Top Center
         | RL | | RLC | | RC | | RRC | | RR |                       
         •————• •—————• •————• •—————• •————•                       
    */

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> que representa la sección Short Speaker Descriptor del bloque Data Block Collection.
    /// </summary> 
    sealed class ShortSpeakerDescriptorCeaSection : BaseDataSection
    {
        #region constructor/s

        #region [public] ShortSpeakerDescriptorCeaSection(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase.
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.ShortSpeakerDescriptorCeaSection" />.
        /// </summary>
        /// <param name="sectionData">Datos de esta sección.</param>
        public ShortSpeakerDescriptorCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) Parse(Hashtable): Obtiene la colección de items de esta sección.
        /// <inheritdoc />
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
            var speakerAllocationDataBlock = new SpeakerDataBlock(RawData);

            items.Add("Front Left/Right High", speakerAllocationDataBlock.FrontLeftRightHigh ? "Present" : "Not Present");
            items.Add("Front Left/Right Wide", speakerAllocationDataBlock.FrontLeftRightWide ? "Present" : "Not Present");
            items.Add("Rear Left/Right Center", speakerAllocationDataBlock.RearLeftRearCenter ? "Present" : "Not Present");
            items.Add("Front Left/Right Center", speakerAllocationDataBlock.FrontLeftRightCenter ? "Present" : "Not Present");
            items.Add("Rear Center", speakerAllocationDataBlock.RearCenter ? "Present" : "Not Present");
            items.Add("Rear Left/Right", speakerAllocationDataBlock.RearLeftRight ? "Present" : "Not Present");
            items.Add("Front Center", speakerAllocationDataBlock.FrontCenter ? "Present" : "Not Present");
            items.Add("LFE Channel", speakerAllocationDataBlock.LFEChannel ? "Present" : "Not Present");
            items.Add("Front Left/Right", speakerAllocationDataBlock.FrontLeftRight ? "Present" : "Not Present");
            items.Add("Top Center", speakerAllocationDataBlock.TopCenter ? "Present" : "Not Present");
            items.Add("Front Center High", speakerAllocationDataBlock.FrontCenterHigh ? "Present" : "Not Present");
            #endregion
        }
        #endregion

        #endregion
    }
}
