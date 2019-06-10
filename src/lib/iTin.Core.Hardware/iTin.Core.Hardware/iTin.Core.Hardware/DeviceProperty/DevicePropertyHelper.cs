using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using iTin.Core.Hardware.Specification.Eedid;

namespace iTin.Core.Hardware.Device.DeviceProperty
{
    /// <summary>
    /// Clase de ayuda para <c>DevicesProperties</c>.
    /// </summary>
    static class DevicePropertyHelper
    {
        #region [private] (IDeviceProperty) GetDescriptorInformation: Obtiene un valor que representa una propiedad que almacena un descriptor.
        /// <summary>
        /// Obtiene un valor que representa una propiedad que almacena un descriptor.
        /// </summary>
        /// <param name="descriptorDataBlock">Par clave/Valor que representa la definición para contruir la propiedad.</param>
        /// <returns></returns>
        public static IDeviceProperty GetDescriptorInformation(DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>> descriptorDataBlock)
        {
            PropertyKey key = descriptorDataBlock.Value.Key;
            ReadOnlyCollection<Byte> value = descriptorDataBlock.Value.Value;
            return DevicePropertyFactory.CreateTypedDeviceProperty(key, value);
        }
        #endregion

        #region [public] {static} (Hashtable) GetDescriptorItemsFrom(PropertyKey, IDeviceProperty): Obtiene un valor que representa la colección de propiedades que contiene un descriptor.
        /// <summary>
        /// Obtiene un valor que representa la colección de propiedades que contiene un descriptor.
        /// </summary>
        /// <param name="key">Clave del descriptor.</param>
        /// <param name="typedDescriptor">Información del descriptor.</param>
        /// <returns>
        /// Colección de propiedades del descriptor.
        /// </returns>
        public static Hashtable GetDescriptorItemsFrom(PropertyKey key, IDeviceProperty typedDescriptor)
        {
            Hashtable items = null;

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.AlphaNumericDataString)
            {
                var info = ToTypedDevice<AlphaNumericDataStringDescriptor>(typedDescriptor);
                items = info.Value.Items;
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.ColorManagementData)
            {
                var info = ToTypedDevice<ColorManagementDataDescriptor>(typedDescriptor);
                items = info.Value.Items;
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.ColorPointData)
            {
                var info = ToTypedDevice<ColorPointDataDescriptor>(typedDescriptor);
                items = info.Value.Items;
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.CVT3ByteCode)
            {
                var info = ToTypedDevice<Cvt3ByteCodeDescriptor>(typedDescriptor);
                items = info.Value.Items;
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DetailedTimingMode)
            {
                var info = ToTypedDevice<DetailedTimingModeDescriptor>(typedDescriptor);
                items = info.Value.Items;
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DisplayProductName)
            {
                var info = ToTypedDevice<DisplayProductNameDescriptor>(typedDescriptor);
                items = info.Value.Items;
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DisplayProductSerialNumber)
            {
                var info = ToTypedDevice<DisplayProductSerialNumberDescriptor>(typedDescriptor);
                items = info.Value.Items;
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DisplayRangeLimits)
            {
                var info = ToTypedDevice<DisplayRangeLimitsDescriptor>(typedDescriptor);
                items = info.Value.Items;
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DummyData)
            {
                var info = ToTypedDevice<DummyDataDescriptor>(typedDescriptor);
                items = info.Value.Items;
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.EstablishedTimingsIII)
            {
                var info = ToTypedDevice<EstablishedTimingsIIIDescriptor>(typedDescriptor);
                items = info.Value.Items;
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.ManufacturerSpecifiedData)
            {
                var info = ToTypedDevice<ManufacturerSpecifiedDataDescriptor>(typedDescriptor);
                items = info.Value.Items;
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.StandardTimingIdentifier)
            {
                var info = ToTypedDevice<StandardTimingIdentifierDescriptor>(typedDescriptor);
                items = info.Value.Items;
            }

            return items;
        }
        #endregion

        #region [public] {static} (IDeviceProperty) GetPropertyFrom(PropertyKey, IDeviceProperty): Obtiene un valor que representa la definición sin tipar de la propiedad especificada mediante su clave.
        /// <summary>
        /// Obtiene un valor que representa la definición sin tipar de la propiedad especificada mediante su clave.
        /// </summary>
        /// <param name="key">Clave del descriptor.</param>
        /// <param name="typedDescriptor">Información del descriptor.</param>
        /// <returns>Colección de propiedades del descriptor.</returns>
        public static IDeviceProperty GetPropertyFrom(PropertyKey key, IDeviceProperty typedDescriptor)
        {
            IDeviceProperty property = null;

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.AlphaNumericDataString)
            {
                var info = ToTypedDevice<AlphaNumericDataStringDescriptor>(typedDescriptor);
                property = info.Value.GetProperty(key);
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.ColorManagementData)
            {
                var info = ToTypedDevice<ColorManagementDataDescriptor>(typedDescriptor);
                property = info.Value.GetProperty(key);
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.ColorPointData)
            {
                var info = ToTypedDevice<ColorPointDataDescriptor>(typedDescriptor);
                property = info.Value.GetProperty(key);
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.CVT3ByteCode)
            {
                var info = ToTypedDevice<Cvt3ByteCodeDescriptor>(typedDescriptor);
                property = info.Value.GetProperty(key);
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DetailedTimingMode)
            {
                var info = ToTypedDevice<DetailedTimingModeDescriptor>(typedDescriptor);
                property = info.Value.GetProperty(key);
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DisplayProductName)
            {
                var info = ToTypedDevice<DisplayProductNameDescriptor>(typedDescriptor);
                property = info.Value.GetProperty(key);
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DisplayProductSerialNumber)
            {
                var info = ToTypedDevice<DisplayProductSerialNumberDescriptor>(typedDescriptor);
                property = info.Value.GetProperty(key);
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DisplayRangeLimits)
            {
                var info = ToTypedDevice<DisplayRangeLimitsDescriptor>(typedDescriptor);
                property = info.Value.GetProperty(key);
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DummyData)
            {
                var info = ToTypedDevice<DummyDataDescriptor>(typedDescriptor);
                property = info.Value.GetProperty(key);
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.EstablishedTimingsIII)
            {
                var info = ToTypedDevice<EstablishedTimingsIIIDescriptor>(typedDescriptor);
                property = info.Value.GetProperty(key);
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.ManufacturerSpecifiedData)
            {
                var info = ToTypedDevice<ManufacturerSpecifiedDataDescriptor>(typedDescriptor);
                property = info.Value.GetProperty(key);
            }

            if (key == KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.StandardTimingIdentifier)
            {
                var info = ToTypedDevice<StandardTimingIdentifierDescriptor>(typedDescriptor);
                property = info.Value.GetProperty(key);
            }

            return property;
        }
        #endregion

        #region [public] {static} (DeviceProperty<T>) ToTypedDevice<T>(IDeviceProperty): Obtiene una propiedad fuertemente tipada a partir la interfaz que la define.
        /// <summary>
        /// Obtiene una propiedad fuertemente tipada a partir la interfaz que la define.
        /// </summary>
        /// <typeparam name="T">Tipo de la propiedad.</typeparam>
        /// <param name="descriptor">Definición de la propiedad.</param>
        /// <returns>
        /// Devuelve un objeto que representa una propiedad fuertemente tipada al tipo indicado.
        /// </returns>
        public static DeviceProperty<T> ToTypedDevice<T>(IDeviceProperty descriptor)
        {
            return descriptor as DeviceProperty<T>;
        }
        #endregion
    }
}