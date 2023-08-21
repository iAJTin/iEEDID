
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

using iTin.Core.Hardware.Common;

using iTin.Hardware.Specification.Eedid.Blocks.EDID;

namespace iTin.Hardware.Specification.Eedid;

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

    #region public readonly properties

    /// <summary>
    /// Returns a list of implemented properties for this section.
    /// </summary>
    /// <value>
    /// A list of implemented properties for this section.
    /// </value>
    public ReadOnlyCollection<IPropertyKey> ImplementedProperties => Properties.Values.Keys.ToList().AsReadOnly();

    /// <summary>
    /// Gets a value that represents the key of this <see cref="DataSection"/>.
    /// </summary>
    /// <value>
    /// Key of this <see cref="DataSection"/>.
    /// </value>
    public Enum Key { get; }

    /// <summary>
    /// Gets a value that represents the collection <see cref="BaseDataSectionCollection"/> to which this section belongs.
    /// </summary>
    /// <value>
    /// Collection <see cref="BaseDataSectionCollection"/> to which this <see cref="DataSection"/> belongs.
    /// </value>
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public BaseDataSectionCollection Parent { get; private set; }

    /// <summary>
    /// Gets a value that represents the data to be processed
    /// </summary>
    /// <value>
    /// Data to process.
    /// </value>
    public ReadOnlyCollection<byte> RawData => 
        Key.Equals(EdidSection.Checksum) 
            ? new ReadOnlyCollection<byte>(new[] { _dataSection.RawData.Take(128).LastOrDefault() }) 
            : _dataSection.RawData;

    #endregion

    #region internal readonly properties

    /// <summary>
    /// Gets a value that represents the collection of items associated with this section.
    /// </summary>
    /// <value>
    /// Object <see cref="SectionProperties"/> that contains the properties of this <see cref="DataSection"/>.
    /// </value>
    internal SectionProperties Properties
    {
        get
        {
            var hasProperties = _itemsTable.Count > 0;
            if (!hasProperties)
            {
                return _properties;
            }

            return _properties ??= new SectionProperties(_itemsTable);
        }
    }

    #endregion

    #region public methods

    /// <summary>
    /// Returns the value of specified property. Always returns the first appearance of the property.
    /// </summary>
    /// <param name="propertyKey">Key to the property to obtain</param>
    /// <returns>
    /// <para>
    /// A <see cref="QueryPropertyResult"/> reference that contains the result of the operation, to check if the operation is correct, the <b>Success</b>
    /// property will be <b>true</b> and the <b>Value</b> property will contain the value; Otherwise, the the <b>Success</b> property
    /// will be false and the <b>Errors</b> property will contain the errors associated with the operation, if they have been filled in.
    /// </para>
    /// <para>
    /// The type of the <b>Value</b> property is <see cref="PropertyItem"/>. Contains the result of the operation.
    /// </para>
    /// <para>
    /// </para>
    /// </returns>
    public QueryPropertyResult GetProperty(IPropertyKey propertyKey)
        => _dataSection.Properties.ContainsKey(propertyKey)
            ? _dataSection.GetProperty(propertyKey)
            : QueryPropertyResult.CreateErroResult($"Property {propertyKey} not found");

    #endregion

    #region public override methods

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

    #region internal methods

    /// <summary>
    /// Sets the object <see cref="BaseDataSectionCollection"/> to which this <see cref="DataSection"/> belongs.
    /// </summary>
    /// <param name="parent">Object <see cref="BaseDataSectionCollection"/> to which this <see cref="DataSection"/> belongs.</param>
    internal void SetParent(BaseDataSectionCollection parent)
    {
        Parent = parent;
    }

    #endregion
}
