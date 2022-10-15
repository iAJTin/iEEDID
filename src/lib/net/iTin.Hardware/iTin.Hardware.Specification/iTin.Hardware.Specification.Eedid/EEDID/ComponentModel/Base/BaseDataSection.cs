
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Hardware.Common;
using iTin.Core.Helpers;

namespace iTin.Hardware.Specification.Eedid
{
    /// <summary>
    /// Base class that represents a <b>section</b> of a <b>block</b> of the <see cref="EEDID"/> specification.
    /// </summary>
    public abstract class BaseDataSection
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SectionPropertiesTable _sectionPropertiesTable;
        #endregion

        #region constructor/s

        #region [protected] BaseDataSection(ReadOnlyCollection<byte>, int? = null): Initializes a new instance of the class BaseDataSection with the raw data of this section with version block
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

        #endregion

        #region public readonly properties

        #region [public] (SectionPropertiesTable) Properties: Gets the properties available for this section
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

        #endregion

        #region internal properties

        #region [internal] (ReadOnlyCollection<byte>) RawData: Gets a value that represents the data to be processed
        /// <summary>
        /// Gets a value that represents the data to be processed
        /// </summary>
        /// <value>
        /// Data to process.
        /// </value>
        internal ReadOnlyCollection<byte> RawData { get; }
        #endregion

        #region [internal] (int?) Version: Gets a value containing the version block
        /// <summary>
        /// Gets a value containing the version block
        /// </summary>
        /// <value>
        /// Version block.
        /// </value>
        internal int? Version { get; }
        #endregion

        #endregion

        #region public methods

        #region [public] (QueryPropertyResult) GetProperty(IPropertyKey): Returns the value of specified property. Always returns the first appearance of the property
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
            => !Properties.ContainsKey(propertyKey) 
                ? QueryPropertyResult.CreateErroResult("Can not found specified property key") 
                : QueryPropertyResult.CreateSuccessResult(((IEnumerable<PropertyItem>)Properties[propertyKey]).FirstOrDefault());
        #endregion

        #region [public] (object) GetPropertyValue(IPropertyKey): Returns the value of specified property. Always returns the first appearance of the property
        /// <summary>
        /// Returns the value of specified property. Always returns the first appearance of the property. If it does not exist, returns <c>null</c> (<c>Nothing</c> in visual basic).
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// Reference to the object that represents the value of the property. Always returns the first appearance of the property.
        /// </returns>
        public object GetPropertyValue(IPropertyKey propertyKey) => Properties.ContainsKey(propertyKey) ? Properties[propertyKey] : null;
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

        #region protected methods

        #region [protected] (byte) GetByte(byte): Returns the stored value from the specified byte
        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="target">target byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        protected byte GetByte(byte target) => RawData[target];
        #endregion

        #region [protected] (byte) GetBytes(byte, byte): Returns the stored array from start with specified lenght
        /// <summary>
        /// Returns the stored array from start with specified lenght.
        /// </summary>
        /// <param name="start">start byte</param>
        /// <param name="lenght">lenght</param>
        /// <returns>
        /// The array value stored.
        /// </returns>
        protected byte[] GetBytes(byte start, byte lenght)
        {
            var bytes = new Collection<byte>();
            for (byte i = start; i <= lenght; i++)
            {
                bytes.Add(RawData[i]);
            }

            return bytes.ToArray();

        }
        #endregion

        #region [protected] (int) GetWord(byte): Returns the stored value from the specified byte
        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="start">start byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        protected int GetWord(byte start) => RawData.GetWord(start);
        #endregion

        #region [protected] (int) GetDoubleWord(byte): Returns the stored value from the specified byte
        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="start">start byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        protected int GetDoubleWord(byte start) => RawData.GetDoubleWord(start);
        #endregion

        #region [protected] (long) GetQuadrupleWord(byte): Returns the stored value from the specified byte
        /// <summary>
        /// Returns the stored value from the specified byte.
        /// </summary>
        /// <param name="start">start byte</param>
        /// <returns>
        /// The value stored in the indicated byte.
        /// </returns>
        protected long GetQuadrupleWord(byte start) => RawData.GetQuadrupleWord(start);
        #endregion

        #region [protected] (void) Parse(SectionPropertiesTable): Populates the property collection for this section
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

        #endregion

        #region protected virtual methods

        #region [protected] {virtual} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected virtual void PopulateProperties(SectionPropertiesTable properties)
        {
        }
        #endregion

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
}
