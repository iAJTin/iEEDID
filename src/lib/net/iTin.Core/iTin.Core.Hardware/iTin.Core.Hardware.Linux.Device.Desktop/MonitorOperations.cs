
using System.Collections.Generic;
using System.Linq;

using iTin.Core.Hardware.Abstractions.Devices.Desktop.Monitor;

namespace iTin.Core.Hardware.Linux.Device.Desktop;

/// <summary>
/// Specialization of the <see cref="IMonitorOperations"/> interface that contains the <strong>Monitor</strong> operations for <strong>Linux</strong> system.
/// </summary>
public class MonitorOperations : IMonitorOperations
{
    /// <summary>
    /// Gets a value containing the raw <strong>EDID</strong> data.
    /// </summary>
    /// <returns>
    /// The raw <strong>EDID</strong> data.
    /// </returns>
    public IEnumerable<byte[]> GetEdidDataCollection()
    {
        return Enumerable.Empty<byte[]>();
    }
}
