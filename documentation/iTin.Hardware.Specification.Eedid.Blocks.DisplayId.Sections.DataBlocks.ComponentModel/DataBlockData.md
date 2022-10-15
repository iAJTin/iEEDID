# DataBlockData structure

Defines header data block descriptor.

```csharp
public struct DataBlockData : IEquatable<DataBlockData>
```

## Public Members

| name | description |
| --- | --- |
| [BlockRevision](DataBlockData/BlockRevision.md) { get; } | Gets a value that represents block revision. |
| [BlockTag](DataBlockData/BlockTag.md) { get; } | Gets a value that represents the type of data block. |
| [ImplementedProperties](DataBlockData/ImplementedProperties.md) { get; } | Gets a value containing the implemented properties for this data block. |
| [RawData](DataBlockData/RawData.md) { get; } | Get the raw data from a data block. |
| [StructureVersion](DataBlockData/StructureVersion.md) { get; } | Gets a value that represents the structure version. |
| [Equals](DataBlockData/Equals.md)(…) | Indicates whether the current object is equal to another object of the same type. |
| override [Equals](DataBlockData/Equals.md)(…) | Returns a value that indicates whether this object is equal to another. |
| override [GetHashCode](DataBlockData/GetHashCode.md)() | Returns the hash code of the object. |
| [GetProperty](DataBlockData/GetProperty.md)(…) | Returns the value of specified property. Always returns the first appearance of the property. |
| override [ToString](DataBlockData/ToString.md)() | Returns a String that represents the current class. |
| [operator ==](DataBlockData/op_Equality.md) | Implements the equality operator (==). |
| [operator !=](DataBlockData/op_Inequality.md) | Implement the inequality operator (!=). |

## See Also

* namespace [iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel](../iTin.Hardware.Specification.Eedid.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Hardware.Specification.Eedid.dll -->