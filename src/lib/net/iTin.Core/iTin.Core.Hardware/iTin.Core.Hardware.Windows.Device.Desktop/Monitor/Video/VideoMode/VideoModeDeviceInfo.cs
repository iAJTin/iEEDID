﻿
using System;
using System.Diagnostics;
using System.Drawing;

using iTin.Core.Interop.Shared.Windows.Development.DocumentAndPrinting.Printing.GdiPrint;

namespace iTin.Core.Hardware.Windows.Device.Desktop.Monitor.Video.VideoMode;

/// <summary>
/// The videoModeInfo data structure contains information about a video mode.
/// </summary>
public struct VideoModeDeviceInfo : IEquatable<VideoModeDeviceInfo>
{
    #region private readonly members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly DEVMODE _modeInfo;

    #endregion

    #region private members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private bool _current;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="VideoModeDeviceInfo"/> structure.
    /// </summary>
    /// <param name="modeInfo">Native video mode information.</param>
    public VideoModeDeviceInfo(DEVMODE modeInfo)
    {
        _current = false;
        _modeInfo = modeInfo;
    }

    #endregion

    #region interfaces

    /// <summary>
    /// Indicates whether the current structure is the same as another structure of the same type.
    /// </summary>
    /// <param name="other">Structure to be compared with this structure.</param>
    /// <returns>
    /// Returns <see langword="true"/> if the current structure is equal to the <c>other</c> parameter; otherwise <see langword="false"/>.
    /// </returns>
    public bool Equals(VideoModeDeviceInfo other) => other.Equals((object)this);

    #endregion

    #region public operators

    /// <summary>
    /// Implements the equality operator (==).
    /// </summary>
    /// <param name="left">Left</param>
    /// <param name="right">Right</param>
    /// <returns>
    /// Returns<see langword="true"/> if <c>left</c> is equal to <c>right</c>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator ==(VideoModeDeviceInfo left, VideoModeDeviceInfo right) => left.Equals(right);

    /// <summary>
    /// Implements the inequality operator (!=).
    /// </summary>
    /// <param name="left">Left</param>
    /// <param name="right">Right</param>
    /// <returns>
    /// Returns <see langword="true"/> if <c>left</c> is not equal to <c>right</c>; otherwise <see langword="false"/>.
    /// </returns>
    public static bool operator !=(VideoModeDeviceInfo left, VideoModeDeviceInfo right) => !left.Equals(right);

    #endregion

    #region public properties

    /// <summary>
    /// Gets the number of bits used to display each pixel.
    /// </summary>
    /// <value>
    /// Number of bits used to display each pixel.
    /// </value>
    public readonly int BitsPerPixel => _modeInfo.dmBitsPerPel;

    /// <summary>
    /// Gets a value that represents how often the video driver updates the monitor image.
    /// </summary>
    /// <value>
    /// Frequency with which the video controller updates the monitor image.
    /// </value>
    public readonly int Frequency => _modeInfo.dmDisplayFrequency;

    /// <summary>
    /// Gets a value that indicates whether this video mode is the current one.
    /// </summary>
    /// <value>
    /// <see langword="true"/> if it's the current video mode; otherwise <see langword="false"/>.
    /// </value>
    public readonly bool IsCurrent => _current;

    /// <summary>
    /// Gets a value that represents the coordinate of the first pixel of this video mode.
    /// </summary>
    /// <value>
    /// Coordinate of the first pixel of this video mode.
    /// </value>
    public readonly Point Location => new(_modeInfo.dmPosition.X, _modeInfo.dmPosition.Y);

    /// <summary>
    /// Gets a value that represents the size in pixels of the video mode.
    /// </summary>
    /// <value>
    /// Value representing the size in pixels of the video mode.
    /// </value>
    public readonly Size Size => new(_modeInfo.dmPelsWidth, _modeInfo.dmPelsHeight);

    #endregion

    #region public override methods

    /// <inheritdoc/>
    public override int GetHashCode() => _modeInfo.GetHashCode();

    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        if (obj is not VideoModeDeviceInfo other)
        {
            return false;
        }

        return
            other.Size == Size &&
            other.BitsPerPixel == BitsPerPixel &&
            other.Frequency == Frequency;
    }

    /// <inheritdoc/>
    public override string ToString() => _modeInfo.ToString();

    #endregion

    #region public methods

    /// <summary>
    /// Sets this instance as the current one
    /// </summary>
    /// <param name="current">Indicates if is current.</param>
    public void SetCurrent(bool current)
    {
        _current = current;
    }

    #endregion
}
