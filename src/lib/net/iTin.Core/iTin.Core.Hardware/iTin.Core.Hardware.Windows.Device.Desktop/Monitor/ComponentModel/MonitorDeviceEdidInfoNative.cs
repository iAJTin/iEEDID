
using System;
using System.Linq;

namespace iTin.Core.Hardware.Windows.Device.Desktop.Monitor.ComponentModel;

/// <summary>
/// The data structure <see cref="MonitorDeviceEdidInfoNative"/> contains the raw <c>EDID</c> information of a system monitor.
/// </summary>
internal struct MonitorDeviceEdidInfoNative : IEquatable<MonitorDeviceEdidInfoNative>
{
    #region public static properties
    public static MonitorDeviceEdidInfoNative NoValid => new();

    #endregion

    #region public properties

    /// <summary>
    /// Gets a value that represents the device identifier.
    /// </summary>
    /// <value>
    /// String representing the device identifier.
    /// </value>
    public string DeviceId { get; internal set; }

    /// <summary>
    /// Gets a value that indicates whether the raw EDID information is valid.
    /// </summary>
    /// <value>
    /// Returns <strong>true</strong> if the raw EDID information is valid; <strong>false</strong> otherwise.
    /// </value>
    public bool IsValid { get; internal set; }

    /// <summary>
    /// Gets or sets a value that contains the raw EDID information
    /// </summary>
    /// <value>
    /// Returns raw EDID information.
    /// </value>
    public byte[] RawEdid { get; internal set; }

    #endregion

    #region interfaces

    /// <summary>
    /// Indicates whether the current structure is the same as another structure of the same type.
    /// </summary>
    /// <param name="other">Structure to be compared with this structure.</param>
    /// <returns>
    /// Returns <strong>true</strong> if the current structure is equal to the <c>other</c> parameter; otherwise, <strong>false</strong>.
    /// </returns>
    public bool Equals(MonitorDeviceEdidInfoNative other) => other.Equals((object)this);

    #endregion

    #region public operators

    /// <summary>
    /// Implements the equality operator (==).
    /// </summary>
    /// <param name="left">Left </param>
    /// <param name="right">Right </param>
    /// <returns>
    /// Returns <strong> true </strong> if <c>left</c> is equal to <c>right</c>; <strong> false </strong> otherwise.
    /// </returns>
    public static bool operator ==(MonitorDeviceEdidInfoNative left, MonitorDeviceEdidInfoNative right) => left.Equals(right);

    /// <summary>
    /// Implements the inequality operator (!=).
    /// </summary>
    /// <param name = "left"> Left </param>
    /// <param name = "right"> Right </param>
    /// <returns>
    /// Returns <strong>true</strong> if <c>left</c> is not equal to <c>right</c>; <strong>false</strong> otherwise.
    /// </returns>
    public static bool operator !=(MonitorDeviceEdidInfoNative left, MonitorDeviceEdidInfoNative right) => !left.Equals(right);

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a value that represents the hash code of this structure.
    /// </summary>
    /// <returns>
    /// Hash code of this structure.
    /// </returns>
    public override int GetHashCode() => DeviceId.GetHashCode() ^ IsValid.GetHashCode() ^ RawEdid.GetHashCode();

    /// <summary>
    /// Returns a value that indicates whether this structure is the same as another.
    /// </summary>
    /// <param name="obj"> Structure to compare. </param>
    /// <returns>
    /// Result of the equality comparison.
    /// </returns>
    public override bool Equals(object obj)
    {
        if (obj is not MonitorDeviceEdidInfoNative other)
        {
            return false;
        }

        return
            other.DeviceId.Equals(DeviceId) &&
            other.IsValid.Equals(IsValid) &&
            other.RawEdid.SequenceEqual(RawEdid);
    }

    /// <summary>
    /// Returns a string that represents the current structure
    /// </summary>
    /// <returns>
    /// String representing the current <see cref="MonitorDeviceEdidInfoNative"/> structure.
    /// </returns>
    public override string ToString() => $"{DeviceId}";

    #endregion
}
