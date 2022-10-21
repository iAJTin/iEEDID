
using System.Collections.Generic;
using System.Linq;

using iTin.Core.Hardware.Abstractions.Devices.Desktop.Monitor;
using iTin.Core.Hardware.Windows.Device.Desktop.Monitor;

namespace iTin.Core.Hardware.Windows.Device.Desktop
{
    /// <summary>
    /// Specialization of the <see cref="IMonitorOperations"/> interface that contains the <b>Monitor</b> operations for <b>Windows</b> system.
    /// </summary>
    public class MonitorOperations : IMonitorOperations
    {
        /// <summary>
        /// Gets a value containing the raw <b>EDID</b> data.
        /// </summary>
        /// <returns>
        /// The raw <b>EDID</b> data.
        /// </returns>
        public IEnumerable<byte[]> GetEdidDataCollection() 
            => SafeMonitorNativeMethods.EnumerateMonitorDevices().Select(device => (byte[])device.Edid.Clone());
    }
}
