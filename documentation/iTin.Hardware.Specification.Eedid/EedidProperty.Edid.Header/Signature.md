# EedidProperty.Edid.Header.Signature property

Gets a value representing the key to retrieve the property value.

Contains the EDID header signature. Always returns (00 FF FF FF FF FF FF 00).

Key Composition

* Structure: Header
* Property: Signature
* Unit: None

Return Value

Type: ReadOnlyCollection where T is Byte.

Remarks

1.4

```csharp
public static IPropertyKey Signature { get; }
```

## See Also

* class [Header](../EedidProperty.Edid.Header.md)
* namespace [iTin.Hardware.Specification.Eedid](../../iTin.Hardware.Specification.Eedid.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Hardware.Specification.eedid.dll -->