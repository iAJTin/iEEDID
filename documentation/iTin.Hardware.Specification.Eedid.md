# iTin.Hardware.Specification.Eedid assembly

## iTin.Hardware.Specification namespace

| public type | description |
| --- | --- |
| class [EEDID](./iTin.Hardware.Specification/EEDID.md) | Implementation of the E-EDID (Extended Display Identification Data) specification. |

## iTin.Hardware.Specification.Eedid namespace

| public type | description |
| --- | --- |
| abstract class [BaseDataSection](./iTin.Hardware.Specification.Eedid/BaseDataSection.md) | Base class that represents a section of a block of the [`EEDID`](./iTin.Hardware.Specification/EEDID.md) specification. |
| abstract class [BaseDataSectionCollection](./iTin.Hardware.Specification.Eedid/BaseDataSectionCollection.md) | Base class that represents a collection of [`DataSection`](./iTin.Hardware.Specification.Eedid/DataSection.md) objects from a [`DataBlock`](./iTin.Hardware.Specification.Eedid/DataBlock.md) of a [`KnownDataBlock`](./iTin.Hardware.Specification.Eedid/KnownDataBlock.md). |
| class [DataBlock](./iTin.Hardware.Specification.Eedid/DataBlock.md) | Represents a data block |
| class [DataBlockCollection](./iTin.Hardware.Specification.Eedid/DataBlockCollection.md) | Represents a collection of [`DataBlock`](./iTin.Hardware.Specification.Eedid/DataBlock.md) objects from the [`EEDID`](./iTin.Hardware.Specification/EEDID.md) specification. |
| struct [DataBlockDescriptorData](./iTin.Hardware.Specification.Eedid/DataBlockDescriptorData.md) | Defines header data block descriptor. |
| class [DataSection](./iTin.Hardware.Specification.Eedid/DataSection.md) | Represents a data section |
| static class [EedidProperty](./iTin.Hardware.Specification.Eedid/EedidProperty.md) | Definition of available keys for the [`EEDID`](./iTin.Hardware.Specification/EEDID.md) specification of a monitor. |
| enum [KnownDataBlock](./iTin.Hardware.Specification.Eedid/KnownDataBlock.md) | Types of known blocks. |
| enum [KnownModelYearStrategy](./iTin.Hardware.Specification.Eedid/KnownModelYearStrategy.md) | Model strategy for a `EDID Block``Vendor` section. |
| struct [MonitorResolutionInfo](./iTin.Hardware.Specification.Eedid/MonitorResolutionInfo.md) | Defines resolution of a monitor. |
| class [SectionProperties](./iTin.Hardware.Specification.Eedid/SectionProperties.md) | Represents a collection of properties of an object that implements the [`BaseDataSectionCollection`](./iTin.Hardware.Specification.Eedid/BaseDataSectionCollection.md) class. |
| class [SectionPropertiesTable](./iTin.Hardware.Specification.Eedid/SectionPropertiesTable.md) | Specialization of the BasePropertiesTable class that stores the available properties for each section. |

## iTin.Hardware.Specification.Eedid.Blocks.CEA namespace

| public type | description |
| --- | --- |
| enum [CeaSection](./iTin.Hardware.Specification.Eedid.Blocks.CEA/CeaSection.md) | Sections corresponding to a block of type CeaBlock. |

## iTin.Hardware.Specification.Eedid.Blocks.DI namespace

| public type | description |
| --- | --- |
| enum [DiSection](./iTin.Hardware.Specification.Eedid.Blocks.DI/DiSection.md) | Sections correspodientes to a block of type DiBlock. |

## iTin.Hardware.Specification.Eedid.Blocks.DisplayId namespace

| public type | description |
| --- | --- |
| enum [DisplayIdSection](./iTin.Hardware.Specification.Eedid.Blocks.DisplayId/DisplayIdSection.md) | Sections available for a block DisplayID. |

## iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel namespace

| public type | description |
| --- | --- |
| struct [DataBlockData](./iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel/DataBlockData.md) | Defines header data block descriptor. |
| enum [DataBlockTag](./iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel/DataBlockTag.md) | Available data blocks. |
| class [DetailedTimingTypeIData](./iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel/DetailedTimingTypeIData.md) | Specialization of the [`BaseDataSection`](./iTin.Hardware.Specification.Eedid/BaseDataSection.md) class. Represents a Detailed Timing Type I entry defined in DetailedTimingTypeI data block. |

## iTin.Hardware.Specification.Eedid.Blocks.EDID namespace

| public type | description |
| --- | --- |
| enum [EdidDataBlockDescriptor](./iTin.Hardware.Specification.Eedid.Blocks.EDID/EdidDataBlockDescriptor.md) | Definition of types of possible descriptors for a DataBlocks block. |
| enum [EdidSection](./iTin.Hardware.Specification.Eedid.Blocks.EDID/EdidSection.md) | Sections available for a block EDID. |

## iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors namespace

| public type | description |
| --- | --- |
| class [ColorPointDataDescriptorItem](./iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors/ColorPointDataDescriptorItem.md) | Specialization of the [`BaseDataSection`](./iTin.Hardware.Specification.Eedid/BaseDataSection.md) class. Represents the information of a DataBlocks of type [`ColorPointData`](./iTin.Hardware.Specification.Eedid/EedidProperty.Edid.DataBlock.Definition.ColorPointData.md). |
| class [Cvt3ByteCodeDescriptorItem](./iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors/Cvt3ByteCodeDescriptorItem.md) | Specialization of the [`BaseDataSection`](./iTin.Hardware.Specification.Eedid/BaseDataSection.md) class. Represents the information of a DataBlocks of type [`Cvt3ByteCode`](./iTin.Hardware.Specification.Eedid/EedidProperty.Edid.DataBlock.Definition.Cvt3ByteCode.md). |
| class [StandardTimingIdentifierDescriptorItem](./iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors/StandardTimingIdentifierDescriptorItem.md) | Represents an item of the StandardTimingIdentifierDescriptor. |

## iTin.Hardware.Specification.Eedid.Blocks.LS namespace

| public type | description |
| --- | --- |
| enum [LsSection](./iTin.Hardware.Specification.Eedid.Blocks.LS/LsSection.md) | Sections corresponding to a block of type LsBlock. |

## iTin.Hardware.Specification.Eedid.Blocks.VTB namespace

| public type | description |
| --- | --- |
| enum [VtbSection](./iTin.Hardware.Specification.Eedid.Blocks.VTB/VtbSection.md) | Sections corresponding to a block of type VtbBlock. |

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Hardware.Specification.Eedid.dll -->
