
namespace iTin.Core.Hardware.Device
{
    using System.Diagnostics;

    using Helpers;

    public abstract class DeviceObjectProperties : DeviceObjectPropertiesBase
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly DeviceObject owner;
        #endregion

        #region constructor/s

        #region [protected] DeviceObjectProperties(DeviceObject): Inicializa una nueva instancia de la clase
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Core.Hardware.Device.DeviceObjectProperties" />.
        /// </summary>
        /// <param name="owner"><see cref="T:iTin.Core.Hardware.Device.DeviceObject" /> que contiene estas propiedades.</param>
        protected DeviceObjectProperties(DeviceObject owner) : base(SentinelHelper.PassThroughNonNull(owner).GetTypedDeviceData())
        {
            this.owner = owner;
        }
        #endregion

        #endregion

        #region protected methods

        #region [protected] (DeviceObject) Device: Obtiene una referencia al dispositivo que contiene estas propiedades
        /// <summary>
        /// Obtiene una referencia al dispositivo que contiene estas propiedades.
        /// </summary>
        /// <value>
        /// Referencia al dispositivo que contiene estas propiedades.
        /// </value>
        protected DeviceObject Device => owner;

        #endregion

        #endregion
    }
}
