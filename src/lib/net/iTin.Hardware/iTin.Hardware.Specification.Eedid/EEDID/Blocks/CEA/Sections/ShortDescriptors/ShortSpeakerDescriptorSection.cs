
using System.Collections.ObjectModel;

using iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors.DataBlocks;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors;

/*  
    •—————•                 •—————•        •—————•          Where:
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

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the Short Speaker Descriptor section of the Data Block Collection block.
/// </summary> 
internal sealed class ShortSpeakerDescriptorSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="ShortSpeakerDescriptorSection"/>.
    /// </summary>
    /// <param name="sectionData">Datos de esta sección.</param>
    public ShortSpeakerDescriptorSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
    {
    }

    #endregion

    #region protected override methods

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected override void PopulateProperties(SectionPropertiesTable properties)
    {
        var speakerAllocationDataBlock = new SpeakerDataBlock(RawData);
        properties.Add(EedidProperty.Cea.DataBlock.Speaker.FrontLeftRightHigh, speakerAllocationDataBlock.FrontLeftRightHigh);
        properties.Add(EedidProperty.Cea.DataBlock.Speaker.FrontLeftRightWide, speakerAllocationDataBlock.FrontLeftRightWide);
        properties.Add(EedidProperty.Cea.DataBlock.Speaker.RearLeftRightCenter, speakerAllocationDataBlock.RearLeftRearCenter);
        properties.Add(EedidProperty.Cea.DataBlock.Speaker.FrontLeftRightCenter, speakerAllocationDataBlock.FrontLeftRightCenter);
        properties.Add(EedidProperty.Cea.DataBlock.Speaker.RearCenter, speakerAllocationDataBlock.RearCenter);
        properties.Add(EedidProperty.Cea.DataBlock.Speaker.RearLeftRight, speakerAllocationDataBlock.RearLeftRight);
        properties.Add(EedidProperty.Cea.DataBlock.Speaker.FrontCenter, speakerAllocationDataBlock.FrontCenter);
        properties.Add(EedidProperty.Cea.DataBlock.Speaker.LFEChannel, speakerAllocationDataBlock.LFEChannel);
        properties.Add(EedidProperty.Cea.DataBlock.Speaker.FrontLeftRight, speakerAllocationDataBlock.FrontLeftRight);
        properties.Add(EedidProperty.Cea.DataBlock.Speaker.TopCenter, speakerAllocationDataBlock.TopCenter);
        properties.Add(EedidProperty.Cea.DataBlock.Speaker.FrontCenterHigh, speakerAllocationDataBlock.FrontCenterHigh);
    }

    #endregion
}
