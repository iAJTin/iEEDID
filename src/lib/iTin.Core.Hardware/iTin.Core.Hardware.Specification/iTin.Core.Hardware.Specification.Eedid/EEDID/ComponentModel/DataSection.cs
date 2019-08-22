
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    /// <summary>
    /// Represents a data section
    /// </summary>
    public sealed class DataSection
    {
        #region private members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SectionProperties _properties;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly BaseDataSection _dataSection;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly SectionPropertiesTable _itemsTable;

        #endregion

        #region constructor/s

        #region [internal] DataSection(KeyValuePair<Enum, BaseDataSection>): Initializes a new instance of the class with the data associated with this section
        /// <summary>
        /// Initializes a new instance of <see cref="DataSection"/> class with the data associated with this section.
        /// </summary>
        /// <param name="sectionDictionaryEntry">Data associated with this section.</param>
        internal DataSection(KeyValuePair<Enum, BaseDataSection> sectionDictionaryEntry)
        {
            Key = sectionDictionaryEntry.Key;
            _dataSection = sectionDictionaryEntry.Value;
            _itemsTable = sectionDictionaryEntry.Value.Properties;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (bool) HasProperties: Gets a value that indicates if there are available properties
        /// <summary>
        /// Gets a value that indicates if there are available properties.
        /// </summary>
        /// <value>
        /// <b>true</b> if there are properties; otherwise, it is <b>false</b>.
        /// </value>
        public bool HasProperties => _itemsTable.Count > 0;
        #endregion

        #region [public] (Enum) Key: Gets a value that represents the key of this section
        /// <summary>
        /// Gets a value that represents the key of this <see cref="DataSection"/>.
        /// </summary>
        /// <value>
        /// Key of this <see cref="DataSection"/>.
        /// </value>
        public Enum Key { get; }
        #endregion

        #region [public] (BaseDataSectionCollection) Parent: Gets a value that represents the collection 'BaseDataSectionCollection' to which this section belongs
        /// <summary>
        /// Gets a value that represents the collection <see cref="BaseDataSectionCollection"/> to which this section belongs.
        /// </summary>
        /// <value>
        /// Collection <see cref="BaseDataSectionCollection"/> to which this <see cref="DataSection"/> belongs.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public BaseDataSectionCollection Parent { get; private set; }

        #endregion

        #region [public] (SectionProperties) Properties: Gets a value that represents the collection of items associated with this section
        /// <summary>
        /// Gets a value that represents the collection of items associated with this section.
        /// </summary>
        /// <value>
        /// Object <see cref="SectionProperties"/> that contains the properties of this <see cref="DataSection"/>.
        /// </value>
        public SectionProperties Properties
        {
            get
            {
                if (!HasProperties)
                {
                    return _properties;
                }

                return _properties ?? (_properties = new SectionProperties(_itemsTable));
            }
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (object) GetPropertyValue(IPropertyKey): Returns the value of specified property. Always returns the first appearance of the property
        /// <summary>
        /// Returns the value of specified property. Always returns the first appearance of the property. If it does not exist, returns <c>null</c> (<c>Nothing</c> in visual basic).
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object that represents the value of the property. Always returns the first appearance of the property.
        /// </returns>
        public object GetPropertyValue(IPropertyKey propertyKey) => _dataSection.Properties[propertyKey];
        #endregion

        #region [public] (T) GetPropertyValue<T>(IPropertyKey): Returns the the strongly typed value of specified property
        /// <summary>
        /// Returns the the strongly typed value of specified property. Always returns the first appearance of the property. If it does not exist, returns <c>null</c> (<c>Nothing</c> in visual basic).
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object that represents the strongly typed value of the property. Always returns the first appearance of the property.
        /// </returns>
        public T GetPropertyValue<T>(IPropertyKey propertyKey) => (T)GetPropertyValue(propertyKey);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (String) ToString: Returns a string that represents the current object
        /// <summary>
        /// Returns a string that represents the current <see cref="DataSection"/> object.
        /// </summary>
        /// <returns>
        /// String representing the current <see cref="DataSection"/> object.
        /// </returns>
        /// <remarks>
        /// The <see cref="DataSection.ToString()"/> method returns a string that includes the key of this section.
        /// </remarks>   
        public override string ToString() => $"Key=\"{Key}\"";

        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(BaseDataSectionCollection): Sets the DataBlock object to which this DataSection belongs
        /// <summary>
        /// Sets the object <see cref="BaseDataSectionCollection"/> to which this <see cref="DataSection"/> belongs.
        /// </summary>
        /// <param name="parent">Object <see cref="BaseDataSectionCollection"/> to which this <see cref="DataSection"/> belongs.</param>
        internal void SetParent(BaseDataSectionCollection parent)
        {
            Parent = parent;
        }
        #endregion

        #endregion
    }
}
