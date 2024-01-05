
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Hardware.Common;
using iTin.Core.Helpers;

namespace iTin.Hardware.Specification.Eedid;

/// <summary>
/// Base class that represents a <strong>section</strong> of a <strong>block</strong> of the <see cref="EEDID"/> specification.
/// </summary>
public abstract class BaseDataSection
{
    #region private members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private SectionPropertiesTable _sectionPropertiesTable;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the class <see cref="BaseDataSection"/> with the raw data of this section with version block.
    /// </summary>
    /// <param name="sectionData">Raw data section.</param>
    /// <param name="version">Block version.</param>
    protected BaseDataSection(ReadOnlyCollection<byte> sectionData, int? version = null)
    {
        Version = version;
        RawData = sectionData;
    }

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets the properties available for this section.
    /// </summary>
    /// <value>
    /// Availables properties.
    /// </value>
    public SectionPropertiesTable Properties
    {
        get
        {
            if (_sectionPropertiesTable != null)
            {
                return _sectionPropertiesTable;
            }

            _sectionPropertiesTable = new SectionPropertiesTable();
            Parse(_sectionPropertiesTable);

            return _sectionPropertiesTable;
        }
    }

    #endregion

    #region internal readonly properties

    /// <summary>
    /// Gets a value that represents the data to be processed
    /// </summary>
    /// <value>
    /// Data to process.
    /// </value>
    internal ReadOnlyCollection<byte> RawData { get; }

    /// <summary>
    /// Gets a value containing the version block
    /// </summary>
    /// <value>
    /// Version block.
    /// </value>
    internal int? Version { get; }

    #endregion

    #region public methods

    /// <summary>
    /// Returns the value of specified property. Always returns the first appearance of the property.
    /// </summary>
    /// <param name="propertyKey">Key to the property to obtain</param>
    /// <returns>
    /// <para>
    /// A <see cref="QueryPropertyResult"/> reference that contains the result of the operation, to check if the operation is correct, the <strong>Success</strong>
    /// property will be <strong>true</strong> and the <strong>Value</strong> property will contain the value; Otherwise, the <strong>Success</strong> property
    /// will be false and the <strong>Errors</strong> property will contain the errors associated with the operation, if they have been filled in.
    /// </para>
    /// <para>
    /// The type of the <strong>Value</strong> property is <see cref="PropertyItem"/>. Contains the result of the operation.
    /// </para>
    /// <para>
    /// </para>
    /// </returns>
    public QueryPropertyResult GetProperty(IPropertyKey propertyKey) => !Properties.ContainsKey(propertyKey)
        ? QueryPropertyResult.CreateErrorResult("Can not found specified property key")
        : QueryPropertyResult.CreateSuccessResult(((IEnumerable<PropertyItem>)Properties[propertyKey]).FirstOrDefault());

    /// <summary>
    /// Returns the value of specified property. Always returns the first appearance of the property. If it does not exist, returns <c>null</c> (<c>Nothing</c> in visual basic).
    /// </summary>
    /// <param name="propertyKey">Key to the property to obtain</param>
    /// <returns>
    /// Reference to the object that represents the value of the property. Always returns the first appearance of the property.
    /// </returns>
    public object GetPropertyValue(IPropertyKey propertyKey) => Properties.ContainsKey(propertyKey) ? Properties[propertyKey] : null;

    /// <summary>
    /// Returns the strongly typed value of specified property.<br/>
    /// Always returns the first appearance of the property.<br/>
    /// If it does not exist, returns <see langword="null"/>.
    /// </summary>
    /// <param name="propertyKey">Key to the property to obtain</param>
    /// <returns>
    /// Reference to the object that represents the strongly typed value of the property.<br/>
    /// Always returns the first appearance of the property.
    /// </returns>
    public T GetPropertyValue<T>(IPropertyKey propertyKey) => (T)GetPropertyValue(propertyKey);

    #endregion

    #region protected methods

    /// <summary>
    /// Returns the stored value from the specified byte.
    /// </summary>
    /// <param name="target">target byte</param>
    /// <returns>
    /// The value stored in the indicated byte.
    /// </returns>
    protected byte GetByte(byte target) => RawData[target];

    /// <summary>
    /// Returns the stored array from start with specified length.
    /// </summary>
    /// <param name="start">start byte</param>
    /// <param name="length">length</param>
    /// <returns>
    /// The array value stored.
    /// </returns>
    protected byte[] GetBytes(byte start, byte length)
    {
        var bytes = new Collection<byte>();
        for (var i = start; i <= length; i++)
        {
            bytes.Add(RawData[i]);
        }

        return [.. bytes];
    }

    /// <summary>
    /// Returns the stored value from the specified byte.
    /// </summary>
    /// <param name="start">start byte</param>
    /// <returns>
    /// The value stored in the indicated byte.
    /// </returns>
    protected int GetWord(byte start) => RawData.GetWord(start);

    /// <summary>
    /// Returns the stored value from the specified byte.
    /// </summary>
    /// <param name="start">start byte</param>
    /// <returns>
    /// The value stored in the indicated byte.
    /// </returns>
    protected int GetDoubleWord(byte start) => RawData.GetDoubleWord(start);

    /// <summary>
    /// Returns the stored value from the specified byte.
    /// </summary>
    /// <param name="start">start byte</param>
    /// <returns>
    /// The value stored in the indicated byte.
    /// </returns>
    protected long GetQuadrupleWord(byte start) => RawData.GetQuadrupleWord(start);

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected virtual void Parse(SectionPropertiesTable properties)
    {
        SentinelHelper.ArgumentNull(properties, nameof(properties));

        PopulateProperties(properties);
    }

    #endregion

    #region protected virtual methods

    /// <summary>
    /// Populates the property collection for this section.
    /// </summary>
    /// <param name="properties">Collection of properties of this section.</param>
    protected virtual void PopulateProperties(SectionPropertiesTable properties)
    {
    }

    #endregion

    #region private methods

    //#region [private] (IDeviceProperty) GetTypedProperty(PropertyKey): Obtiene una referencia a un objeto que implementa la interfaz IDeviceProperty, representa el valor de la propiedad especificada mediante su clave por el parámetro propertyKey.
    ///// <summary>
    ///// Obtiene una referencia a un objeto que implementa la interfaz <see cref="IDeviceProperty"/>, representa el valor de la propiedad especificada mediante su clave por el parámetro <c>propertyKey</c>.
    ///// </summary>
    ///// <param name="propertyKey">Clave de la propiedad a obtener.</param>
    ///// <returns>Interfaz que representa el valor de la propiedad.</returns>
    //private object GetTypedProperty(PropertyKey propertyKey)
    //{
    //    object propertyValue = GetValueTypedProperty(propertyKey);
    //    IDeviceProperty newTypedProperty = DevicePropertyFactory.CreateTypedDeviceProperty(propertyKey, propertyValue);

    //    return newTypedProperty;
    //}
    //#endregion

    #endregion
}
