
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;

    using Device.DeviceProperty;

    /// <summary>
    /// 
    /// </summary>
    public sealed class DataSection
    {
        #region private members

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SectionProperties _properties;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly Hashtable _itemsTable;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly BaseDataSection _dataSection;
        #endregion

        #region constructor/s

        #region [internal] DataSection(KeyValuePair<Enum, BaseDataSection>): Inicializa una nueva instancia de la clase con los datos asociados a esta sección.
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DataSection"/> con los datos asociados a esta sección.
        /// </summary>
        /// <param name="sectionDictionaryEntry">Datos asociados a esta sección.</param>
        internal DataSection(KeyValuePair<Enum, BaseDataSection> sectionDictionaryEntry)
        {
            Key = sectionDictionaryEntry.Key;
            _itemsTable = sectionDictionaryEntry.Value.Items;

            _dataSection = sectionDictionaryEntry.Value;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (bool) HasProperties: Obtiene un valor que indica si hay propiedades disponibles.
        /// <summary>
        /// Obtiene un valor que indica si hay propiedades disponibles.
        /// </summary>
        /// <value>
        /// 	<para><strong>true</strong> si existen propiedades; de lo contrario, es <strong>false</strong>.</para>
        /// </value>
        public bool HasProperties => _itemsTable.Count > 0;
        #endregion

        #region [public] (Enum) Key: Obtiene un valor que representa la clave de esta sección.
        /// <summary>
        /// Obtiene un valor que representa la clave de esta <see cref="DataSection"/>.
        /// </summary>
        /// <value>
        /// 	<para>Clave de esta <see cref="DataSection"/>.</para>
        /// </value>
        [field: DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public Enum Key { get; }
        #endregion

        #region [public] (BaseDataSectionCollection) Parent: Obtiene un valor que representa la colección 'BaseDataSectionCollection' al que pertence esta sección.
        /// <summary>
        /// Obtiene un valor que representa la colección <see cref="BaseDataSectionCollection"/> al que pertence esta <see cref="DataSection"/>
        /// </summary>
        /// <value>
        /// 	<para>Tipo: <see cref="BaseDataSectionCollection"/></para>
        /// 	<para>Colección <see cref="BaseDataSectionCollection"/> al que pertenece esta <see cref="DataSection"/>.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public BaseDataSectionCollection Parent { get; private set; }

        #endregion

        #region [public] (SectionProperties) Properties: Obtiene un valor que representa la colección de items asociados a esta sección.
        /// <summary>
        /// Obtiene un valor que representa la colección de items asociados a esta sección.
        /// </summary>
        /// <value>
        /// 	<para>Objeto <see cref="SectionProperties"/> que contiene las propiedades de esta <see cref="DataSection"/>.</para>
        /// </value>
        public SectionProperties Properties
        {
            get
            {
                if (HasProperties)
                {
                    if (_properties == null)
                    {
                        _properties = new SectionProperties(_itemsTable);
                    }
                }

                return _properties;
            }
        }
        #endregion

        #region [public] (IDeviceProperty) GetProperty: Obtiene un valor que representa la colección de items asociados a esta sección.
        /// <summary>
        /// Obtiene un valor que representa la colección de items asociados a esta sección.
        /// </summary>
        /// <value>
        /// Propiedades de esta sección.
        /// </value>
        public IDeviceProperty GetProperty(PropertyKey propertyKey) => _dataSection.GetProperty(propertyKey);

        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (String) ToString: Devuelve una cadena que representa al objeto actual.
        /// <summary>
        /// Devuelve una cadena que representa al objeto <see cref="DataSection"/> actual.
        /// </summary>
        /// <returns>
        ///   <para>Tipo: <see cref="T:System.String"/></para>
        ///   <para>Cadena que representa al objeto <see cref="DataSection"/> actual.</para>
        /// </returns>
        /// <remarks>
        /// El método <see cref="DataSection.ToString()"/> devuelve una cadena que incluye la clave de esta sección.
        /// </remarks>   
        public override string ToString() => $"Key=\"{Key}\"";

        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(BaseDataSectionCollection): Establece el objeto DataBlock al que pertenece este DataSection.
        /// <summary>
        /// Establece el objeto <see cref="BaseDataSectionCollection"/> al que pertenece este <see cref="DataSection"/>.
        /// </summary>
        /// <param name="parent">Objeto <see cref="BaseDataSectionCollection"/> al que pertenece este <see cref="DataSection"/>.</param>
        internal void SetParent(BaseDataSectionCollection parent)
        {
            Parent = parent;
        }
        #endregion

        #endregion
    }
}
