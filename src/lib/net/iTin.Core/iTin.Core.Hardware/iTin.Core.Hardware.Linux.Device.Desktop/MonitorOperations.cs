
using System.Collections.Generic;
using System.Linq;

using iTin.Core.Hardware.Abstractions.Devices.Desktop.Monitor;

namespace iTin.Core.Hardware.Linux.Device.Desktop
{
    /// <summary>
    /// Specialization of the <see cref="IMonitorOperations"/> interface that contains the <b>Monitor</b> operations for <b>Linux</b> system.
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
        {
            return Enumerable.Empty<byte[]>();
        }
    }
}
