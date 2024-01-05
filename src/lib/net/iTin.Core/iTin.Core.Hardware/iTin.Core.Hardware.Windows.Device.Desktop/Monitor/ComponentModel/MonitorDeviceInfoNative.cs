
using System;
using System.Diagnostics;
using System.Drawing;

using iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.DeviceContext;
using iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.MultipleDisplayMonitors;

namespace iTin.Core.Hardware.Windows.Device.Desktop.Monitor.ComponentModel;

/// <summary>
/// The data structure <see cref="MonitorDeviceInfoNative"/> contains the basic information of a system monitor.
/// </summary>
internal readonly struct MonitorDeviceInfoNative : IEquatable<MonitorDeviceInfoNative>
{
    #region private readonly members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly MONITORINFOEX _monitorInfo;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly DISPLAY_DEVICE _displayInfo;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="MonitorDeviceInfoNative"/> structure.
    /// </summary>
    /// <param name="displayInfo">Monitor information.</param>
    /// <param name="monitorInfo">Screen information.</param>
    public MonitorDeviceInfoNative(MONITORINFOEX monitorInfo, DISPLAY_DEVICE displayInfo)
    {
        _monitorInfo = monitorInfo;
        _displayInfo = displayInfo;
    }

    #endregion

    #region interfaces

    /// <inheritdoc/>
    public bool Equals(MonitorDeviceInfoNative other) => other.Equals((object)this);

    #endregion

    #region public operators

    /// <summary>
    /// Implements the equality operator (==).
    /// </summary>
    /// <param name="left">Left</param>
    /// <param name="right">Right</param>
    /// <returns>
    /// Returns <see langword="true"/> if <c>left</c> is equal to <c>right</c>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator ==(MonitorDeviceInfoNative left, MonitorDeviceInfoNative right) => left.Equals(right);

    /// <summary>
    /// Implements the inequality operator (!=).
    /// </summary>
    /// <param name="left">Left</param>
    /// <param name="right">Right</param>
    /// <returns>
    /// Returns <see langword="true"/> if <c>left</c> is not equal to <c>right</c>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator !=(MonitorDeviceInfoNative left, MonitorDeviceInfoNative right) => !left.Equals(right);

    #endregion

    #region public properties

    /// <summary>
    /// Gets a value that represents the device identifier.
    /// </summary>
    /// <value>
    /// String representing the device identifier.
    /// </value>
    public string DeviceId => _displayInfo.DeviceID;

    /// <summary>
    /// Get a value that represents the name of the screen that contains this monitor.
    /// </summary>
    /// <value>
    /// String representing the name of the screen that contains this monitor.
    /// </value>
    public string DisplayName => _monitorInfo.DeviceName;

    /// <summary>
    /// Gets a value that indicates whether the monitor is part of the desktop.
    /// </summary>
    /// <value>
    /// Returns <strong>true</strong> if it is part of the desktop; <strong>false</strong> otherwise.
    /// </value>
    public bool IsAttached
    {
        get
        {
            var flags = _displayInfo.State;
            return (flags & DISPLAY_DEVICE.KnownDisplayDeviceStates.AttachedToDesktop) == DISPLAY_DEVICE.KnownDisplayDeviceStates.AttachedToDesktop;
        }
    }

    /// <summary>
    /// Gets a value that indicates whether the monitor is the main monitor.
    /// </summary>
    /// <value>
    /// Returns <strong>true</strong> if it is the main monitor; <strong>false</strong> otherwise.
    /// </value>
    public bool IsPrimaryMonitor
    {
        get
        {
            var flags = _monitorInfo.Flags;
            return (flags & MONITORINFOEX.MONITORINFOF_PRIMARY) == MONITORINFOEX.MONITORINFOF_PRIMARY;
        }
    }

    /// <summary>
    /// Gets a value that represents the total area of the monitor.
    /// </summary>
    /// <value>
    /// Rectangle of the monitor screen, expressed in virtual screen coordinates.
    /// </value>
    /// <remarks>
    /// Note that if the monitor is not the monitor of the main screen, some of the coordinates of the rectangle may be negative values.
    /// </remarks>
    public Rectangle MonitorArea => _monitorInfo.Monitor;

    /// <summary>
    /// Gets a value that represents the registry key that contains the information on this monitor.
    /// </summary>
    /// <value>
    /// String representing the registry key that contains the information on this monitor.
    /// </value>
    public string MonitorDriverRegistryPath
    {
        get
        {
            var i = _displayInfo.DeviceKey.IndexOf("\\System", StringComparison.OrdinalIgnoreCase);
            var deviceRegistryKeyBranch = _displayInfo.DeviceKey.Substring((i + 1), _displayInfo.DeviceKey.Length - (i + 1));

            return deviceRegistryKeyBranch;
        }
    }

    /// <summary>
    /// Gets a value that represents the name of the monitor.
    /// </summary>
    /// <value>
    /// String representing the name of the monitor.
    /// </value>
    public string MonitorName => _displayInfo.DeviceString;

    /// <summary>
    /// Gets a value that represents the usable surface of the monitor.
    /// </summary>
    /// <value>
    /// Usable monitor rectangle, taskbar and sidebars are excluded.
    /// </value>
    /// <remarks>
    /// Note that if the monitor is not the monitor of the main screen, some of the coordinates of the rectangle may be negative values.
    /// </remarks>
    public Rectangle MonitorWorkingArea => _monitorInfo.WorkArea;

    #endregion

    #region public override methods

    /// <inheritdoc/>
    public override int GetHashCode() => _displayInfo.GetHashCode() ^ _monitorInfo.GetHashCode();

    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        if (obj is not MonitorDeviceInfoNative other)
        {
            return false;
        }

        return
            other.DisplayName.Equals(DisplayName) &&
            other.MonitorName.Equals(MonitorName) &&
            other.IsAttached.Equals(IsAttached) &&
            other.IsPrimaryMonitor.Equals(IsPrimaryMonitor);
    }

    /// <inheritdoc/>
    public override string ToString() => $"{MonitorName}";

    #endregion
}
