# EdidSection enumeration

Sections available for a block EDID.

```csharp
public enum EdidSection
```

## Values

| name | value | description |
| --- | --- | --- |
| Header | `0` | Header section of a block EDID, for more information see HeaderSection. |
| Vendor | `1` | Vendor and Product section of a block EDID, for more information see VendorSection. |
| Version | `2` | Section Version and Revision of a block EDID, for more information see VersionSection. |
| BasicDisplay | `3` | Section Basic Display Parameters and Features of a block EDID, for more information see BasicDisplaySection. |
| ColorCharacteristics | `4` | Color Characteristics section of a block EDID, for more information see ColorCharacteristicsSection. |
| EstablishedTimings | `5` | Established Timings I, II section of a block EDID, for more information see EstablishedTimingsSection. |
| StandardTimings | `6` | Section Standard Timings 16 Bytes of a block EDID, for more information see StandardTimingsSection. |
| DataBlocks | `7` | Section 18 Byte Data Blocks Descriptors of a block EDID, for more information see DataBlocksSection. |
| ExtensionBlocks | `8` | Extension Block Count section of a block EDID, for more information see ExtensionBlocksSection. |
| Checksum | `9` | CheckSum  section of a block EDID, for more information see ChecksumSection. |

## See Also

* namespace [iTin.Hardware.Specification.Eedid.Blocks.EDID](../iTin.Hardware.Specification.Eedid.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Hardware.Specification.Eedid.dll -->