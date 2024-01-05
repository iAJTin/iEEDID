
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

using iTin.Core.Hardware.Abstractions.Devices.Desktop.Monitor;

using Linux = iTin.Core.Hardware.Linux.Device.Desktop;
using MacOS = iTin.Core.Hardware.MacOS.Device.Desktop;
using Windows = iTin.Core.Hardware.Windows.Device.Desktop;

namespace iTin.Hardware.Abstractions.Devices.Desktop;

/// <summary>
/// Define 
/// </summary>
public class MonitorOperations
{
    #region private readonly members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly IMonitorOperations _operations;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly Dictionary<OSPlatform, IMonitorOperations> _operationsTable =
        new()
        {
            { OSPlatform.Windows, new Windows.MonitorOperations() },
            { OSPlatform.Linux, new Linux.MonitorOperations() },
            { OSPlatform.OSX, new MacOS.MonitorOperations() }
        };

    #endregion

    #region constructor/s

    /// <summary>
    /// Prevents a default instance of the <see cref="MonitorOperations"/> class from being created.
    /// </summary>
    private MonitorOperations()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            _operations = _operationsTable[OSPlatform.Windows];
        }
        else
        {
            _operations = RuntimeInformation.IsOSPlatform(OSPlatform.OSX)
                ? _operationsTable[OSPlatform.OSX]
                : _operationsTable[OSPlatform.Linux];
        }
    }

    #endregion

    #region public static readonly properties

    /// <summary>
    /// Gets a unique instance of this class.
    /// </summary>
    /// <value>
    /// A <see cref="MonitorOperations"/> reference that contains <strong>Monitor</strong> operations.
    /// </value>
    public static MonitorOperations Instance { get; } = new();

    #endregion

    #region public methods

    /// <summary>
    /// Gets a value containing the raw <strong>EDID</strong> data.
    /// </summary>
    /// <returns>
    /// The raw <strong>EDID</strong> data.
    /// </returns>
    public IEnumerable<byte[]> GetEdidDataCollection() => _operations.GetEdidDataCollection();

    #endregion
}
