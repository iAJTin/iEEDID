
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

using iTin.Core.Helpers;

namespace iTin.Hardware.Specification.Eedid;

/// <summary>
/// Represents a collection of <see cref="DataBlock"/> objects from the <see cref="EEDID"/> specification.
/// </summary>
public sealed class DataBlockCollection : IList<DataBlock>
{
    #region private members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly IList<DataBlock> _blocks;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly ICollection<KnownDataBlock> _keys;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the class <see cref="DataBlockCollection" /> specifying the available blocks untreated and if they are read only.
    /// </summary>
    /// <param name="parent">Available blocks untreated.</param>
    /// <param name="readOnly"><strong>true</strong> if the collection should be read-only; <strong>false</strong> otherwise.</param>
    internal DataBlockCollection(EEDID parent, bool readOnly)
    {
        Parent = parent;
        IsReadOnly = readOnly;
        _keys = Parent.BlockTable.Keys.ToList();
        _blocks = Parent.BlockTable.Select(blockDictionaryEntry => new DataBlock(blockDictionaryEntry)).ToList();

        SetParentToItemBlockCollection();
    }

    #endregion

    #region interfaces

    #region IEnumerable

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return _blocks.GetEnumerator();
    }

    #endregion

    #region IList<DataBlock>

    /// <inheritdoc />
    public int IndexOf(DataBlock item) => _blocks.IndexOf(item);

    /// <inheritdoc />
    public void Insert(int index, DataBlock item)
    {
        if (IsReadOnly)
        {
            throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
        }

        _blocks.Insert(index, item);
    }

    /// <inheritdoc />
    public void RemoveAt(int index)
    {
        if (IsReadOnly)
        {
            throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
        }
        _blocks.RemoveAt(index);
    }

    /// <inheritdoc />
    public DataBlock this[int index]
    {
        get => _blocks[index];
        set
        {
            if (IsReadOnly)
            {
                throw new NotSupportedException();//enLocalizedMessages.DataBlockCollectionInsertReadOnly);
            }

            _blocks[index] = value;
        }
    }

    #endregion

    #region ICollection<DataBlock>

    /// <inheritdoc />
    public void Add(DataBlock item)
    {
        if(IsReadOnly)
        {
            throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);               
        }

        _blocks.Add(item);
    }

    /// <inheritdoc />
    public void Clear()
    {
        if (IsReadOnly)
        {
            throw new NotSupportedException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
        }

        _blocks.Clear();
    }

    /// <inheritdoc />
    public bool Contains(DataBlock item) => _blocks.Contains(item);

    /// <inheritdoc />
    public void CopyTo(DataBlock[] array, int arrayIndex)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        if (array.Length < arrayIndex + _blocks.Count)
        {
            throw new ArgumentException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly, "array");
        }

        for (int index = 0; index < _blocks.Count; index++)
        {
            array[index + arrayIndex] = _blocks[index];
        }
    }

    /// <inheritdoc />
    public int Count => _blocks.Count;

    /// <inheritdoc />
    public bool IsReadOnly { get; }

    /// <inheritdoc />
    public bool Remove(DataBlock item)
    {
        if (IsReadOnly)
        {
            throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
        }

        return _blocks.Remove(item);
    }

    #endregion

    #region IEnumerable<DataBlock>

    /// <inheritdoc />
    public IEnumerator<DataBlock> GetEnumerator() => _blocks.GetEnumerator();

    #endregion

    #endregion

    #region public properties

    /// <summary>
    /// Gets the element with the specified key.
    /// </summary>
    /// <value>
    /// A <see cref="DataBlock"/> element.
    /// </value>
    /// <remarks>
    /// If the element does not exist, <see langword="null"/> is returned.
    /// </remarks>
    /// <exception cref="InvalidEnumArgumentException">Specified block not exist</exception>
    public DataBlock this[KnownDataBlock valueKey]
    {
        get
        {
            var knownBlockValid = IsValidBlock(valueKey);
            if (!knownBlockValid)
            {
                throw new InvalidEnumArgumentException(nameof(valueKey), (int) valueKey, typeof (KnownDataBlock));
            }

            var blockIndex = IndexOf(valueKey);
            if (blockIndex != -1)
            {
                return this[blockIndex];
            }

            return null;
        }
    }

    /// <summary>
    /// Gets a list of the implemented blocks.
    /// </summary>
    /// <value>
    /// List of implemented blocks.
    /// </value>
    public ReadOnlyCollection<KnownDataBlock> ImplementedBlocks => _keys.ToList().AsReadOnly();

    /// <summary>
    /// Gets parent of this data block collection.
    /// </summary>
    /// <value>
    /// Parent of this instance.
    /// </value>
    public EEDID Parent { get; }

    #endregion

    #region public methods

    /// <summary>
    /// Determines whether the element with the specified key is in the <see cref="DataBlockCollection"/> collection.
    /// </summary>
    /// <param name="valueKey">One of the <see cref="KnownDataBlock"/> values that represents the key of the <see cref="DataBlock"/> object to find.</param>
    /// <returns>
    /// <strong>true</strong> if the object <see cref="DataBlock"/> with the <c>valueKey</c> is in the collection <see cref="DataBlockCollection"/>; otherwise it is <strong> false </strong>.
    /// </returns>
    /// <exception cref="InvalidEnumArgumentException">Specified block is not valid.</exception>
    public bool Contains(KnownDataBlock valueKey)
    {
        var knownBlockValid = IsValidBlock(valueKey);
        if (!knownBlockValid)
        {
            throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(KnownDataBlock));
        }

        return _keys.Contains(valueKey);
    }

    /// <summary>
    /// Returns the index of the object with the specified key in the collection.
    /// </summary>
    /// <param name="valueKey">Uno de los valores de <see cref="KnownDataBlock"/> que representa la clave del objeto <see cref="DataBlock"/> que se va a buscar en <see cref="DataBlockCollection"/>.</param>
    /// <returns>
    /// Zero-based index of the first occurrence of item in the entire <see cref="DataBlockCollection"/>, if found; otherwise <strong>-1</strong>.
    /// </returns>
    /// <exception cref="InvalidEnumArgumentException">Specified block is not valid.</exception>
    public int IndexOf(KnownDataBlock valueKey)
    {
        var knownBlockValid = IsValidBlock(valueKey);
        if (!knownBlockValid)
        {
            throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(KnownDataBlock));
        }

        var block = _blocks.FirstOrDefault(item => item.Key == valueKey);

        return IndexOf(block);
    }

    #endregion

    #region public override methods

    /// <summary>
    /// Devuelve una cadena que representa al objeto <see cref="DataBlockCollection"/> actual.
    /// </summary>
    /// <returns>
    /// String representing the current <see cref="DataBlockCollection"/> object.
    /// </returns>
    /// <remarks>
    /// The <see cref="DataBlockCollection.ToString()"/> method returns a string that includes the number of available blocks.
    /// </remarks>   
    public override string ToString() => $"Count = {Count}";

    #endregion

    #region private static methods

    /// <summary>
    /// Determines if the specified key is a valid key from the <see cref="KnownDataBlock"/> enumeration.
    /// </summary>
    /// <param name="value">Key to check.</param>
    /// <returns>
    /// <strong>true</strong> if the value belongs to the enumeration <see cref="KnownDataBlock"/>; otherwise it is <strong>false</strong>.
    /// </returns>
    private static bool IsValidBlock(KnownDataBlock value) => SentinelHelper.IsEnumValid(value);

    #endregion

    #region private methods

    /// <summary>
    /// Set the parent to which each element belongs <see cref="DataBlock"/> with this <see cref="DataBlockCollection"/>.
    /// </summary>
    private void SetParentToItemBlockCollection()
    {
        foreach (var item in _blocks)
        {
            item.SetParent(this);
        }
    }

    #endregion
}
