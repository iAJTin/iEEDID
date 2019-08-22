
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;

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
    internal sealed class ShortSpeakerDescriptorCeaSection : BaseDataSection
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

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
            SpeakerDataBlock speakerAllocationDataBlock = new SpeakerDataBlock(RawData);
            //properties.Add("Front Left/Right High", speakerAllocationDataBlock.FrontLeftRightHigh ? "Present" : "Not Present");
            //properties.Add("Front Left/Right Wide", speakerAllocationDataBlock.FrontLeftRightWide ? "Present" : "Not Present");
            //properties.Add("Rear Left/Right Center", speakerAllocationDataBlock.RearLeftRearCenter ? "Present" : "Not Present");
            //properties.Add("Front Left/Right Center", speakerAllocationDataBlock.FrontLeftRightCenter ? "Present" : "Not Present");
            //properties.Add("Rear Center", speakerAllocationDataBlock.RearCenter ? "Present" : "Not Present");
            //properties.Add("Rear Left/Right", speakerAllocationDataBlock.RearLeftRight ? "Present" : "Not Present");
            //properties.Add("Front Center", speakerAllocationDataBlock.FrontCenter ? "Present" : "Not Present");
            //properties.Add("LFE Channel", speakerAllocationDataBlock.LFEChannel ? "Present" : "Not Present");
            //properties.Add("Front Left/Right", speakerAllocationDataBlock.FrontLeftRight ? "Present" : "Not Present");
            //properties.Add("Top Center", speakerAllocationDataBlock.TopCenter ? "Present" : "Not Present");
            //properties.Add("Front Center High", speakerAllocationDataBlock.FrontCenterHigh ? "Present" : "Not Present");
        }
        #endregion

        #endregion
    }
}
