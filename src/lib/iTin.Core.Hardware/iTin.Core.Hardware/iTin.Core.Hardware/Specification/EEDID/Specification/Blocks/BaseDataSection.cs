
using iTin.Core.Helpers;

namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Device.DeviceProperty;

    /// <summary>
    /// Clase base que representa una <strong>sección</strong> de un <strong>bloque</strong> de la especificación <see cref="EEDID"/>.
    /// </summary>
    public abstract class BaseDataSection
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Hashtable _itemsSection;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Hashtable _typedItemsSection;

        #endregion

        #region constructor/s

        #region [protected] BaseDataSection(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de esta sección sin tratar.
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="BaseDataSection"/> con los datos de esta sección sin tratar.
        /// </summary>
        /// <param name="sectionData">Datos de esta sección sin tratar.</param>
        protected BaseDataSection(ReadOnlyCollection<byte> sectionData)
        {
            RawData = sectionData;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (Hashtable) Items: Obtiene un valor que representa la colección de items disponibles para esta sección.
        /// <summary>
        /// Obtiene un valor que representa la colección de items disponibles para esta sección.
        /// </summary>
        /// <value>Colección de items disponibles para esta sección.</value>
        public Hashtable Items
        {
            get
            {
                if (_itemsSection != null)
                {
                    return _itemsSection;
                }

                _itemsSection = new Hashtable();
                Parse(_itemsSection);
                return _itemsSection;
            }
        }
        #endregion

        #endregion

        #region protected properties

        #region [protected] (ReadOnlyCollection<byte>) RawData: Obtiene un valor que representa los datos a procesar.
        /// <summary>
        /// Obtiene un valor que representa los datos a procesar.
        /// </summary>
        /// <value>Datos a procesar.</value>
        protected ReadOnlyCollection<byte> RawData { get; }
        #endregion

        #endregion

        #region private properties

        #region [private] (Hashtable) TypedItems: Obtiene el diccionario de propiedades fuertemente tipados de esta sección.
        /// <summary>
        /// Obtiene el diccionario de propiedades fuertemente tipados de esta sección.
        /// </summary>
        /// <value>
        /// 	<para>Propiedades fuertemente tipadas.</para>
        /// </value>
        private Hashtable TypedItems => _typedItemsSection ?? (_typedItemsSection = new Hashtable());
        #endregion

        #endregion

        #region public methods

        #region [public] (IDeviceProperty) GetProperty(PropertyKey): Obtiene una referencia a un objeto que implementa la interfaz IDeviceProperty, representa el valor fuertemente tipado de la propiedad.
        /// <summary>
        /// Obtiene una referencia a un objeto que implementa la interfaz IDeviceProperty, representa el valor fuertemente tipado de la propiedad.
        /// </summary>
        /// <param name="propertyKey">Clave de la propiedad a recuperar.</param>
        /// <returns>Referencia al objeto que representa el valor fuertemente tipado de la propiedad</returns>
        public IDeviceProperty GetProperty(PropertyKey propertyKey)
            {
                if (!TypedItems.Contains(propertyKey))
                    TypedItems.Add(propertyKey, GetTypedProperty(propertyKey));

                return (IDeviceProperty)TypedItems[propertyKey];
            }
        #endregion

        #endregion

        #region protected virtual methods

        #region [protected] {virtual} (object) GetValueTypedProperty(PropertyKey): Obtiene un valor que representa el valor de la propiedad especificada.
        /// <summary>
        /// Obtiene un valor que representa el valor de la propiedad especificada.
        /// </summary>
        /// <param name="propertyKey">Clave de la propiedad a obtener.</param>
        protected virtual object GetValueTypedProperty(PropertyKey propertyKey)
        {
            return null;
        }
        #endregion

        #region [protected] {virtual} (void) Parse(Hashtable): Populates the property collection for this structure
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure</param>
        protected virtual void Parse(Hashtable properties)
        {
            SentinelHelper.ArgumentNull(properties);
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (IDeviceProperty) GetTypedProperty(PropertyKey): Obtiene una referencia a un objeto que implementa la interfaz IDeviceProperty, representa el valor de la propiedad especificada mediante su clave por el parámetro propertyKey.
        /// <summary>
        /// Obtiene una referencia a un objeto que implementa la interfaz <see cref="IDeviceProperty"/>, representa el valor de la propiedad especificada mediante su clave por el parámetro <c>propertyKey</c>.
        /// </summary>
        /// <param name="propertyKey">Clave de la propiedad a obtener.</param>
        /// <returns>Interfaz que representa el valor de la propiedad.</returns>
        private IDeviceProperty GetTypedProperty(PropertyKey propertyKey)
        {
            object propertyValue = GetValueTypedProperty(propertyKey);
            IDeviceProperty newTypedProperty = DevicePropertyFactory.CreateTypedDeviceProperty(propertyKey, propertyValue);

            return newTypedProperty;
        }
        #endregion

        #endregion
    }
}
