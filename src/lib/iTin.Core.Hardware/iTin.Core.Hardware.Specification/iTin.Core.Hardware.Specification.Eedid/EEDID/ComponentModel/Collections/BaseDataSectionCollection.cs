
namespace iTin.Core.Hardware.Specification.Eedid
{    
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    /// Base class that represents a collection of <see cref="DataSection"/> objects from a <see cref="DataBlock"/> of a <see cref="KnownDataBlock"/>.
    /// </summary>
    public abstract class BaseDataSectionCollection : IList<DataSection>
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly bool _readOnly;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly DataBlock _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] 
        private readonly ICollection<Enum> _keys;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] 
        private readonly IList<DataSection> _sections;
        #endregion

        #region constructor/s

        #region [protected] BaseDataBlock(ReadOnlyCollection<byte>): Initializes a new instance of the class specifying the untreated block and if it is read-only
        /// <summary>
        /// Initializes a new instance of the class <see cref="BaseDataSectionCollection"/> specifying the untreated block and if it is read-only.
        /// </summary>
        /// <param name="parent">Data of an untreated block.</param>
        /// <param name="readOnly"><b>true</b> if the collection should be read-only; otherwise <b>false</b>.</param>
        protected BaseDataSectionCollection(DataBlock parent, bool readOnly)
        {
            _parent = parent ?? throw new ArgumentNullException(nameof(parent));
            _readOnly = readOnly;
            _keys = parent.SectionTable.Keys.ToList();
            _sections = _parent.SectionTable.Select(sectionDictionaryEntry => new DataSection(sectionDictionaryEntry)).ToList();

            SetParentToItemSectionCollection();
        }
        #endregion

        #endregion

        #region interfaces

        #region IEnumerable
        
        #region public methods

        #region [IEnumerator] IEnumerable.GetEnumerator(): Returns an enumerator that iterates through a collection
        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// Object <see cref="T:System.Collections.IEnumerator"/> that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator() => _sections.GetEnumerator();
        #endregion

        #endregion

        #endregion

        #region IList<DataSection>

        #region indexers

        #region [public] (DataSection) this[int]: Gets or sets the DataSection object specified in the index
        /// <summary>
        /// Gets or sets the <see cref="DataSection"/> object specified in the index.
        /// </summary>
        /// <value>Index of the object</value>
        /// <returns>
        /// Object <see cref="DataSection"/> specified in the index.
        /// </returns>
        public DataSection this[int index]
        {
            get => _sections[index];
            set
            {
                if (_readOnly)
                {
                    throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
                }

                _sections[index] = value;
            }
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (int) IndexOf(DataSection): Returns the index of the DataSection object within the collection
        /// <summary>
        /// Returns the index of the <see cref="DataSection"/> object within the collection.
        /// </summary>
        /// <param name="item">Item to search</param>
        /// <returns>
        /// Zero-base index of the first appearance of the item in the collection, if found; otherwise, <b>-1</b>.
        /// </returns>
        public int IndexOf(DataSection item) => _sections.IndexOf(item);
        #endregion

        #region [public] (void) Insert(int, DataSection): Inserts a DataSection object into collection
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

            _sections.Insert(index, item);
        }
        #endregion

        #region [public] (void) RemoveAt(int): Removes the specified DataSection object from the collection
        /// <summary>
        /// Elimina el objeto <see cref="DataSection"/> especificado de la colección.
        /// </summary>
        /// <param name="index">Index of the element to be eliminated.</param>
        public void RemoveAt(int index)
        {
            if (_readOnly)
            {
                throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
            }

            _sections.RemoveAt(index);
        }
        #endregion

        #endregion

        #endregion

        #region ICollection<DataSection>

        #region public readonly properties

        #region [public] (int) Count: Gets the items into collection
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        public int Count => _sections.Count;
        #endregion

        #region [public] (bool) IsReadOnly: Gets a value indicating whether this instance is read only
        /// <summary>
        /// Gets a value indicating whether this instance is read only.
        /// </summary>
        /// <value>
        /// <b>true</b> if this instance is read only; otherwise, <b>false</b>.
        /// </value>
        public bool IsReadOnly => _readOnly;
        #endregion

        #endregion

        #region public methods

        #region [public] (void) Add(DataSection): Adds the specified item
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

            _sections.Add(item);
        }
        #endregion

        #region [public] (void) Clear(): Clears this instance
        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            if (_readOnly)
            {
                throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
            }

            _sections.Clear();
        }
        #endregion

        #region [public] (bool) Contains(): Determines whether contains specified item
        /// <summary>
        /// Determines whether [contains] [the specified item].
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>
        /// <b>true</b> if contains the specified item; otherwise, <b>false</b>.
        /// </returns>
        public bool Contains(DataSection item) => _sections.Contains(item);
        #endregion

        #region [public] (void) CopyTo(DataSection[]): Copies specified items into this collection
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

            if (array.Length < arrayIndex + _sections.Count)
            {
                throw new ArgumentException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly, "array");
            }

            for (int index = 0; index < _sections.Count; index++)
            {
                array[index + arrayIndex] = _sections[index];
            }
        }
        #endregion

        #region [public] (bool) Remove: Removes the specified item
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

            return _sections.Remove(item);
        }
        #endregion

        #endregion

        #endregion

        #region IEnumerable<DataSection>.

        #region public methods

        #region [public] (IEnumerator<DataSection>) GetEnumerator(): Returns an enumerator that iterates through a collection
        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// Object <see cref="T:System.Collections.IEnumerator"/> that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<DataSection> GetEnumerator() => _sections.GetEnumerator();
        #endregion

        #endregion

        #endregion

        #endregion

        #region public readonly properties

        #region [public] (ReadOnlyCollection<Enum>) ImplementedSections: Get a list with the implemented sections
        /// <summary>
        /// Get a list with the implemented sections.
        /// </summary>
        /// <value>
        /// List of sections implemented.
        /// </value>
        public ReadOnlyCollection<Enum> ImplementedSections => _keys.ToList().AsReadOnly();
        #endregion

        #region [public] (DataBlock) Block: Gets a value that represents the object to which this collection belongs
        /// <summary>
        /// Gets a value that represents the <see cref="DataBlock"/> object to which this collection belongs <see cref="BaseDataSectionCollection"/>.
        /// </summary>
        /// <value>
        /// Object <see cref="DataBlock"/> to which this <see cref="BaseDataSectionCollection"/> belongs.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public DataBlock Block => _parent;
        #endregion

        #endregion

        #region protected readonly properties

        #region [protected] (IList<DataSection>) Sections: Gets a value that represents the list of sections
        /// <summary>
        /// Gets a value that represents the list of sections.
        /// </summary>
        /// <value>
        /// List of available keys.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected IList<DataSection> Sections => _sections;
        #endregion

        #endregion

        #region private methods

        #region [private] (void) SetParentToItemSectionCollection(): Sets the parent to which each item in this collection belongs
        /// <summary>
        /// Sets the parent to which each <see cref="DataSection" /> element of this collection belongs.
        /// </summary>
        private void SetParentToItemSectionCollection()
        {
            foreach (var item in _sections)
            {
                item.SetParent(this);
            }
        }
        #endregion

        #endregion
    }
}
