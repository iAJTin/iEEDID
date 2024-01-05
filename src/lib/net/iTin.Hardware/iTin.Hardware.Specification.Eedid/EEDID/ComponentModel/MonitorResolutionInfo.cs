
using System;
using System.Diagnostics;
using System.Drawing;

namespace iTin.Hardware.Specification.Eedid;

/// <summary>
/// Defines resolution of a monitor.
/// </summary>
public readonly struct MonitorResolutionInfo :  IEquatable<MonitorResolutionInfo>
{
    #region private readonly members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly int _verticalResolution;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly int _horizontalResolution;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="MonitorResolutionInfo" /> class.
    /// </summary>
    /// <param name="horizontalResolution">Horizontal resolution in pixels</param>
    /// <param name="verticalResolution">Vertical resolution in pixels.</param>
    /// <param name="verticalRefresh">Vertical refresh rate in Hz</param>
    /// <param name="name">Name</param>
    internal MonitorResolutionInfo(int horizontalResolution, int verticalResolution, byte verticalRefresh, string name)
        : this(horizontalResolution, verticalResolution, verticalRefresh, false, name)
    {
    }

    /// <summary>
    /// Initialize a new instance of the <see cref="MonitorResolutionInfo" /> class.
    /// </summary>
    /// <param name="horizontalResolution">Horizontal resolution in pixels</param>
    /// <param name="verticalResolution">Vertical resolution in pixels.</param>
    /// <param name="verticalRefresh">Vertical refresh rate in Hz</param>
    /// <param name="reduceBlanking"><strong>true</strong> if flicker is reduced; <strong>false</strong> otherwise</param>
    /// <param name="name">Name</param>
    internal MonitorResolutionInfo(int horizontalResolution, int verticalResolution, byte verticalRefresh, bool reduceBlanking, string name) 
        : this(horizontalResolution, verticalResolution, verticalRefresh, false, reduceBlanking, name)
    {
    }

    /// <summary>
    /// Initialize a new instance of the <see cref="MonitorResolutionInfo" /> class.
    /// </summary>
    /// <param name="horizontalResolution">Horizontal resolution in pixels</param>
    /// <param name="verticalResolution">Vertical resolution in pixels.</param>
    /// <param name="verticalRefresh">Vertical refresh rate in Hz</param>
    /// <param name="interlaced"><strong>true</strong> if it is interlaced; <strong>false</strong> otherwise</param>
    /// <param name="reduceBlanking"><strong>true</strong> if flicker is reduced; <strong>false</strong> otherwise</param>
    /// <param name="name">Name</param>
    internal MonitorResolutionInfo(int horizontalResolution, int verticalResolution, byte verticalRefresh, bool interlaced, bool reduceBlanking, string name)
    {
        Name = name;
        Interlaced = interlaced;
        ReduceBlanking = reduceBlanking;
        Frequency = verticalRefresh;
        _verticalResolution = verticalResolution;
        _horizontalResolution = horizontalResolution;
    }

    #endregion

    #region interfaces

    /// <inheritdoc />
    public bool Equals(MonitorResolutionInfo other) => other.Equals((object)this);

    #endregion

    #region public operators

    /// <summary>
    /// Implements the equality operator (==).
    /// </summary>
    /// <param name="deviceInfo1">Operand 1</param>
    /// <param name="deviceInfo2">Operand 2</param>
    /// <returns>
    /// Returns <strong>true</strong> if <c>deviceInfo1</c> is equal to <c>deviceInfo2</c>; <strong>false</strong> otherwise.
    /// </returns>
    public static bool operator ==(MonitorResolutionInfo deviceInfo1, MonitorResolutionInfo deviceInfo2) => deviceInfo1.Equals(deviceInfo2);

    /// <summary>
    /// Implement the inequality operator (!=).
    /// </summary>
    /// <param name="deviceInfo1">Operand 1</param>
    /// <param name="deviceInfo2">Operand 2</param>
    /// <returns>
    /// Returns <strong>true</strong> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; <strong>false</strong> otherwise.
    /// </returns>
    public static bool operator !=(MonitorResolutionInfo deviceInfo1, MonitorResolutionInfo deviceInfo2) => !deviceInfo1.Equals(deviceInfo2);

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets a value that represents the resolution name.
    /// </summary>
    /// <value>
    /// Value represents the resolution name.
    /// </value>
    public string Name { get; }

    /// <summary>
    /// Gets a value that represents the aspect ratio.
    /// </summary>
    /// <value>
    /// Value representing the the aspect ratio.
    /// </value>
    public string ApectRatio
    {
        get
        {
            var aspectRatio = Size.Width / (double)Size.Height;

            return aspectRatio switch
            {
                (double)4 / 3 => "4:3",
                (double)1.6 => "16:10",
                (double)5 / 4 => "5:4",
                (double)9 / 5 => "9:5",
                (double)16 / 9 => "16:9",
                (double)192 / 145 => "192:145",
                _ => "1:1"
            };
        }
    }

    /// <summary>
    /// Gets a value that represents the frequency with which the video driver updates the monitor image.
    /// </summary>
    /// <value>
    /// Frequency with which the video driver updates the monitor image.
    /// </value>
    public byte Frequency { get; }

    /// <summary>
    /// Gets a value indicating whether this resolution is interlaced.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if it is linked; <strong>false</strong> otherwise.
    /// </value>
    public bool Interlaced { get; }

    /// <summary>
    /// Gets a value that indicates whether this resolution reduces flicker.
    /// </summary>
    /// <value>
    /// <strong>true</strong> if it reduces flicker; <strong>false</strong> otherwise.
    /// </value>
    public bool ReduceBlanking { get; }

    /// <summary>
    /// Gets a value that represents the size in pixels of the video mode.
    /// </summary>
    /// <value>
    /// Value representing the size in pixels of the video mode.
    /// </value>
    public Size Size => new(_horizontalResolution, _verticalResolution);

    #endregion

    #region public override methods        

    /// <summary>
    /// Returns the hash code of the object.
    /// </summary>
    /// <returns>
    /// Hash code.
    /// </returns>
    public override int GetHashCode() => ToString().GetHashCode();

    /// <summary>
    /// Returns a value that indicates whether this object is equal to another.
    /// </summary>
    /// <param name="obj">Object with which to compare</param>
    /// <returns>
    /// Equality result.
    /// </returns>
    public override bool Equals(object obj)
    {
        if (obj is not MonitorResolutionInfo other)
        {
            return false;
        }

        return 
            other.Size.Equals(Size) && 
            other.Frequency.Equals(Frequency) && 
            other.ReduceBlanking.Equals(ReduceBlanking) &&
            other.Interlaced.Equals(Interlaced);
    }

    /// <summary>
    /// Returns a <see cref="string"/> that represents the current class.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents the <see cref="MonitorResolutionInfo" /> current class.
    /// </returns>
    public override string ToString() => ReduceBlanking ? $"{Size.Width} x {Size.Height}, {Frequency} Hz, Reduce Blanking" : $"{Size.Width} x {Size.Height}, {Frequency} Hz";

    #endregion
}
