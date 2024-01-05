
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

using iTin.Core.Hardware.Windows.Device.Desktop.Monitor.ComponentModel;

namespace iTin.Core.Hardware.Windows.Device.Desktop.Monitor;

/// <summary>
/// The <see cref="MonitorDeviceInfo"/> data structure contains information about a system monitor.
/// </summary>
public readonly struct MonitorDeviceInfo : IEquatable<MonitorDeviceInfo>
{
    #region private readonly members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly MonitorDeviceInfoNative _deviceInfo;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly MonitorDeviceEdidInfoNative _edidDeviceInfo;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="MonitorDeviceInfo"/> structure.
    /// </summary>
    /// <param name="deviceInfo">Monitor information.</param>
    /// <param name="edidDeviceInfo">Screen information.</param>
    internal MonitorDeviceInfo(MonitorDeviceInfoNative deviceInfo, MonitorDeviceEdidInfoNative edidDeviceInfo)
    {
        _deviceInfo = deviceInfo;
        _edidDeviceInfo = edidDeviceInfo;
    }

    #endregion

    #region interfaces

    /// <inheritdoc/>
    public bool Equals(MonitorDeviceInfo other) => other.Equals((object)this);

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
    public static bool operator ==(MonitorDeviceInfo left, MonitorDeviceInfo right) => left.Equals(right);

    /// <summary>
    /// Implements the inequality operator (!=).
    /// </summary>
    /// <param name="left">Left</param>
    /// <param name="right">Right</param>
    /// <returns>
    /// Returns <see langword="true"/> if <c>left</c> is not equal to <c>right</c>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator !=(MonitorDeviceInfo left, MonitorDeviceInfo right) => !left.Equals(right);

    #endregion

    #region public properties

    /// <summary>
    /// Gets a value that represents the device identifier.
    /// </summary>
    /// <value>
    /// String representing the device identifier.
    /// </value>
    public string DeviceId => _deviceInfo.DeviceId;

    /// <summary>
    /// Get a value that represents the name of the screen that contains this monitor.
    /// </summary>
    /// <value>
    /// String representing the name of the screen that contains this monitor.
    /// </value>
    public string DisplayName => _deviceInfo.DisplayName;

    /// <summary>
    /// Gets a value that contains the raw <c>EDID</c> information of this monitor.
    /// </summary>
    /// <value>
    /// Raw <c>EDID</c> information.
    /// </value>
    public byte[] Edid => _edidDeviceInfo.RawEdid;

    /// <summary>
    /// Gets a value that indicates whether the monitor is part of the desktop.
    /// </summary>
    /// <value>
    /// Returns <see langword="true"/> if it is part of the desktop; otherwise <see langword="false"/>.
    /// </value>
    public bool IsAttached => _deviceInfo.IsAttached;

    /// <summary>
    /// Gets a value that indicates whether the monitor is the main monitor.
    /// </summary>
    /// <value>
    /// Returns <see langword="true"/> if it is the main monitor; otherwise <see langword="false"/>.
    /// </value>
    public bool IsPrimaryMonitor => _deviceInfo.IsPrimaryMonitor;

    /// <summary>
    /// Gets a value that represents the total area of the monitor.
    /// </summary>
    /// <value>
    /// Rectangle of the monitor screen, expressed in virtual screen coordinates.
    /// </value>
    /// <remarks>
    /// Note that if the monitor is not the monitor of the main screen, some of the coordinates of the rectangle may be negative values.
    /// </remarks>
    public Rectangle MonitorArea => _deviceInfo.MonitorArea;

    /// <summary>
    /// Gets a value that represents the registry key that contains the information on this monitor.
    /// </summary>
    /// <value>
    /// String representing the registry key that contains the information on this monitor.
    /// </value>
    public string MonitorDriverRegistryPath => _deviceInfo.MonitorDriverRegistryPath;

    /// <summary>
    /// Gets a value that represents the name of the monitor.
    /// </summary>
    /// <value>
    /// String representing the name of the monitor.
    /// </value>
    public string MonitorName => _deviceInfo.MonitorName;

    /// <summary>
    /// Gets a value that represents the usable surface of the monitor.
    /// </summary>
    /// <value>
    /// Usable monitor rectangle, taskbar and sidebars are excluded.
    /// </value>
    /// <remarks>
    /// Note that if the monitor is not the monitor of the main screen, some of the coordinates of the rectangle may be negative values.
    /// </remarks>
    public Rectangle MonitorWorkingArea => _deviceInfo.MonitorWorkingArea;

    #endregion

    #region public override methods

    /// <inheritdoc/>
    public override int GetHashCode() => _deviceInfo.GetHashCode() ^ _edidDeviceInfo.GetHashCode() ^ Edid.GetHashCode();

    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        if (obj is not MonitorDeviceInfo other)
        {
            return false;
        }

        return
            other.DisplayName.Equals(DisplayName) &&
            other.MonitorName.Equals(MonitorName) &&
            other.IsAttached.Equals(IsAttached) &&
            other.IsPrimaryMonitor.Equals(IsPrimaryMonitor) &&
            other.Edid.SequenceEqual(Edid);
    }

    /// <inheritdoc/>
    public override string ToString() => $"{MonitorName}";

    #endregion
}
