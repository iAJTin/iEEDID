# DataBlockCollection.Contains method (1 of 2)

```csharp
public bool Contains(DataBlock item)
```

## See Also

* class [DataBlock](../DataBlock.md)
* class [DataBlockCollection](../DataBlockCollection.md)
* namespace [iTin.Hardware.Specification.Eedid](../../iTin.Hardware.Specification.Eedid.md)

---

# DataBlockCollection.Contains method (2 of 2)

Determines whether the element with the specified key is in the [`DataBlockCollection`](../DataBlockCollection.md) collection.

```csharp
public bool Contains(KnownDataBlock valueKey)
```

| parameter | description |
| --- | --- |
| valueKey | One of the [`KnownDataBlock`](../KnownDataBlock.md) values that represents the key of the [`DataBlock`](../DataBlock.md) object to find. |

## Return Value

true if the object [`DataBlock`](../DataBlock.md) with the `valueKey` is in the collection [`DataBlockCollection`](../DataBlockCollection.md); otherwise it is  false .

## Exceptions

| exception | condition |
| --- | --- |
| InvalidEnumArgumentException | Specified block is not valid. |

## See Also

* enum [KnownDataBlock](../KnownDataBlock.md)
* class [DataBlockCollection](../DataBlockCollection.md)
* namespace [iTin.Hardware.Specification.Eedid](../../iTin.Hardware.Specification.Eedid.md)

<!-- DO NOT EDIT: generated by xmldocmd for iTin.Hardware.Specification.Eedid.dll -->
