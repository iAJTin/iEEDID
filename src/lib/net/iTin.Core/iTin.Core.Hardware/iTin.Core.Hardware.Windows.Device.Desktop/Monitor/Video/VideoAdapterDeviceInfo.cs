
using System;
using System.Diagnostics;

using iTin.Core.Interop.Shared.Windows.Development.Graphics.Legacy.Gdi.DeviceContext;

namespace iTin.Core.Hardware.Windows.Device.Desktop.Monitor.Video;

/// <summary>
/// The <see cref="VideoAdapterDeviceInfo"/> data structure contains information about a video adapter.
/// </summary>
public readonly struct VideoAdapterDeviceInfo : IEquatable<VideoAdapterDeviceInfo>
{
    #region private readonly members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly DISPLAY_DEVICE _adapterInfo;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="VideoAdapterDeviceInfo"/> structure.
    /// </summary>
    /// <param name="adapterInfo">Native video adapter information..</param>
    public VideoAdapterDeviceInfo(DISPLAY_DEVICE adapterInfo) => _adapterInfo = adapterInfo;

    #endregion

    #region interfaces

    /// <summary>
    /// Indicates whether the current structure is the same as another structure of the same type.
    /// </summary>
    /// <param name="other">Structure to be compared with this structure.</param>
    /// <returns>
    /// Returns <strong> true </strong> if the current structure is equal to the <c>other</c> parameter; otherwise, <strong>false</strong>.
    /// </returns>
    public bool Equals(VideoAdapterDeviceInfo other) => other.Equals((object)this);

    #endregion

    #region public operators

    /// <summary>
    /// Implements the equality operator (==).
    /// </summary>
    /// <param name="left">Left</param>
    /// <param name="right">Right</param>
    /// <returns>
    /// Returns <strong>true</strong> if <c>left</c> is equal to <c>right</c>; <strong>false</strong> otherwise.
    /// </returns>
    public static bool operator ==(VideoAdapterDeviceInfo left, VideoAdapterDeviceInfo right) => left.Equals(right);

    /// <summary>
    /// Implements the inequality operator (!=).
    /// </summary>
    /// <param name="left">Left</param>
    /// <param name="right">Right</param>
    /// <returns>
    /// Returns <strong>true</strong> if <c>left</c> is not equal to <c>right</c>; <strong>false</strong> otherwise.
    /// </returns>
    public static bool operator !=(VideoAdapterDeviceInfo left, VideoAdapterDeviceInfo right) => !left.Equals(right);

    #endregion

    #region public properties

    /// <summary>
    /// Gets a string that represents the PnP identifier of this video adapter.
    /// </summary>
    /// <value>
    /// PnP identifier of this video adapter.
    /// </value>
    public string DeviceId => _adapterInfo.DeviceID;

    /// <summary>
    /// Gets a value that represents the name of the screen to which this video adapter is connected.
    /// </summary>
    /// <value>
    /// String representing the name of the screen to which this video adapter is connected.
    /// </value>
    public string DisplayName => _adapterInfo.DeviceName;

    /// <summary>
    /// Gets a value that indicates whether the video adapter shows the desktop.
    /// </summary>
    /// <value>
    /// Returns <strong>true</strong> if it is part of the desktop; <strong>false</strong> otherwise.
    /// </value>
    public bool IsAttached
    {
        get
        {
            DISPLAY_DEVICE.KnownDisplayDeviceStates flags = _adapterInfo.State;
            return (flags & DISPLAY_DEVICE.KnownDisplayDeviceStates.AttachedToDesktop) == DISPLAY_DEVICE.KnownDisplayDeviceStates.AttachedToDesktop;
        }
    }

    /// <summary>
    /// Gets a value that indicates whether this video adapter is the primary adapter.
    /// </summary>
    /// <value>
    /// Returns <strong>true</strong> if it is the primary adapter; <strong>false</strong> otherwise.
    /// </value>
    public bool IsPrimaryVideoAdapter
    {
        get
        {
            DISPLAY_DEVICE.KnownDisplayDeviceStates flags = _adapterInfo.State;
            return (flags & DISPLAY_DEVICE.KnownDisplayDeviceStates.PrimaryDevice) == DISPLAY_DEVICE.KnownDisplayDeviceStates.PrimaryDevice;
        }
    }

    /// <summary>
    /// Gets a value that represents the registry key that contains the information for this video adapter.
    /// </summary>
    /// <value>
    /// String representing the registry key that contains the information of this video adapter.
    /// </value>
    public string VideoAdapterDriverRegistryPath
    {
        get
        {
            int i = _adapterInfo.DeviceKey.IndexOf("\\System", StringComparison.OrdinalIgnoreCase);
            string deviceRegistryKeyBranch = _adapterInfo.DeviceKey.Substring(i + 1, _adapterInfo.DeviceKey.Length - (i + 1));

            return deviceRegistryKeyBranch;
        }
    }

    /// <summary>
    /// Gets a value that represents the name of the video adapter.
    /// </summary>
    /// <value>
    /// String representing the name of the video adapter.
    /// </value>
    public string VideoAdapterName => _adapterInfo.DeviceString;

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a value that represents the hash code of this structure.
    /// </summary>
    /// <returns>
    /// Hash code of this structure.
    /// </returns>
    public override int GetHashCode() => _adapterInfo.GetHashCode();

    /// <summary>
    /// Returns a value that indicates whether this structure is the same as another.
    /// </summary>
    /// <param name="obj">Structure to compare.</param>
    /// <returns>
    /// Result of the equality comparison.
    /// </returns>
    public override bool Equals(object obj)
    {
        if (obj is not VideoAdapterDeviceInfo other)
        {
            return false;
        }

        return
            other.DisplayName.Equals(DisplayName) &&
            other.VideoAdapterName.Equals(VideoAdapterName) &&
            other.IsAttached.Equals(IsAttached);
    }

    /// <summary>
    /// Returns a string that represents the current <see cref="VideoAdapterDeviceInfo"/> structure.
    /// </summary>
    /// <returns>
    /// String representing the current <see cref="VideoAdapterDeviceInfo"/> structure.
    /// </returns>
    public override string ToString() => $"{VideoAdapterName}";

    #endregion
}
