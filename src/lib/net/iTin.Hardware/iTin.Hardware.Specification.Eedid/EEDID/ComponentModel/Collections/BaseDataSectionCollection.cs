
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace iTin.Hardware.Specification.Eedid;

/// <summary>
/// Base class that represents a collection of <see cref="DataSection"/> objects from a <see cref="DataBlock"/> of a <see cref="KnownDataBlock"/>.
/// </summary>
public abstract class BaseDataSectionCollection : IList<DataSection>
{
    #region private readonly members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly bool _readOnly;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)] 
    private readonly ICollection<Enum> _keys;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the class <see cref="BaseDataSectionCollection"/> specifying the untreated block and if it is read-only.
    /// </summary>
    /// <param name="parent">Data of an untreated block.</param>
    /// <param name="readOnly"><strong>true</strong> if the collection should be read-only; otherwise <strong>false</strong>.</param>
    protected BaseDataSectionCollection(DataBlock parent, bool readOnly)
    {
        Block = parent ?? throw new ArgumentNullException(nameof(parent));
        _readOnly = readOnly;
        _keys = parent.SectionTable.Keys.ToList();
        Sections = Block.SectionTable.Select(sectionDictionaryEntry => new DataSection(sectionDictionaryEntry)).ToList();

        SetParentToItemSectionCollection();
    }

    #endregion

    #region interfaces

    #region IEnumerable
    
    /// <summary>
    /// Returns an enumerator that iterates through a collection.
    /// </summary>
    /// <returns>
    /// Object <see cref="T:System.Collections.IEnumerator"/> that can be used to iterate through the collection.
    /// </returns>
    IEnumerator IEnumerable.GetEnumerator() => Sections.GetEnumerator();

    #endregion

    #region IList<DataSection>

    /// <summary>
    /// Gets or sets the <see cref="DataSection"/> object specified in the index.
    /// </summary>
    /// <value>Index of the object</value>
    /// <returns>
    /// Object <see cref="DataSection"/> specified in the index.
    /// </returns>
    public DataSection this[int index]
    {
        get => Sections[index];
        set
        {
            if (_readOnly)
            {
                throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
            }

            Sections[index] = value;
        }
    }

    /// <summary>
    /// Returns the index of the <see cref="DataSection"/> object within the collection.
    /// </summary>
    /// <param name="item">Item to search</param>
    /// <returns>
    /// Zero-base index of the first appearance of the item in the collection, if found; otherwise, <strong>-1</strong>.
    /// </returns>
    public int IndexOf(DataSection item) => Sections.IndexOf(item);

    /// <summary>
    /// Inserts a <see cref="DataSection"/> object into collection.
    /// </summary>
    /// <param name="index">Index where to insert.</param>
    /// <param name="item">Item to insert.</param>
    public void Insert(int index, DataSection item)
    {
        if (_readOnly)
        {
            //switch ( System.Globalization )
            throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
        }

        Sections.Insert(index, item);
    }

    /// <summary>
    /// Removes the specified <see cref="DataSection"/> object from the collection.
    /// </summary>
    /// <param name="index">Index of the element to be eliminated.</param>
    public void RemoveAt(int index)
    {
        if (_readOnly)
        {
            throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
        }

        Sections.RemoveAt(index);
    }

    #endregion

    #region ICollection<DataSection>

    /// <summary>
    /// Gets the count.
    /// </summary>
    /// <value>
    /// The count.
    /// </value>
    public int Count => Sections.Count;

    /// <summary>
    /// Gets a value indicating whether this instance is read only.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if this instance is read only; otherwise, <strong>false</strong>.
    /// </value>
    public bool IsReadOnly => _readOnly;

    /// <summary>
    /// Adds the specified item.
    /// </summary>
    /// <param name="item">The item.</param>
    public void Add(DataSection item)
    {
        if (_readOnly)
        {
            throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
        }

        Sections.Add(item);
    }

    /// <summary>
    /// Clears this instance.
    /// </summary>
    public void Clear()
    {
        if (_readOnly)
        {
            throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
        }

        Sections.Clear();
    }

    /// <summary>
    /// Determines whether [contains] [the specified item].
    /// </summary>
    /// <param name="item">The item.</param>
    /// <returns>
    /// <strong>true</strong> if contains the specified item; otherwise, <strong>false</strong>.
    /// </returns>
    public bool Contains(DataSection item) => Sections.Contains(item);

    /// <summary>
    /// Copies to.
    /// </summary>
    /// <param name="array">The array.</param>
    /// <param name="arrayIndex">Index of the array.</param>
    public void CopyTo(DataSection[] array, int arrayIndex)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        if (array.Length < arrayIndex + Sections.Count)
        {
            throw new ArgumentException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly, "array");
        }

        for (int index = 0; index < Sections.Count; index++)
        {
            array[index + arrayIndex] = Sections[index];
        }
    }

    /// <summary>
    /// Removes the specified item.
    /// </summary>
    /// <param name="item">The item.</param>
    /// <returns></returns>
    public bool Remove(DataSection item)
    {
        if (_readOnly)
        {
            throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
        }

        return Sections.Remove(item);
    }

    #endregion

    #region IEnumerable<DataSection>.

    /// <summary>
    /// Returns an enumerator that iterates through a collection.
    /// </summary>
    /// <returns>
    /// Object <see cref="T:System.Collections.IEnumerator"/> that can be used to iterate through the collection.
    /// </returns>
    public IEnumerator<DataSection> GetEnumerator() => Sections.GetEnumerator();

    #endregion

    #endregion

    #region public readonly properties

    /// <summary>
    /// Get a list with the implemented sections.
    /// </summary>
    /// <value>
    /// List of sections implemented.
    /// </value>
    public ReadOnlyCollection<Enum> ImplementedSections => _keys.ToList().AsReadOnly();

    /// <summary>
    /// Gets a value that represents the <see cref="DataBlock"/> object to which this collection belongs <see cref="BaseDataSectionCollection"/>.
    /// </summary>
    /// <value>
    /// Object <see cref="DataBlock"/> to which this <see cref="BaseDataSectionCollection"/> belongs.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public DataBlock Block { get; }

    #endregion

    #region protected readonly properties

    /// <summary>
    /// Gets a value that represents the list of sections.
    /// </summary>
    /// <value>
    /// List of available keys.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    protected IList<DataSection> Sections { get; }

    #endregion

    #region private methods

    /// <summary>
    /// Sets the parent to which each <see cref="DataSection" /> element of this collection belongs.
    /// </summary>
    private void SetParentToItemSectionCollection()
    {
        foreach (var item in Sections)
        {
            item.SetParent(this);
        }
    }

    #endregion
}
