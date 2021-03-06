﻿
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Diagnostics;
    using System.Drawing;

    /// <summary>
    /// Defines resolution of a monitor.
    /// </summary>
    public struct MonitorResolutionInfo :  IEquatable<MonitorResolutionInfo>
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly int _verticalResolution;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly int _horizontalResolution;
        #endregion

        #region constructor/s

        #region [internal] MonitorResolutionInfo(int, int, byte): Initialize a new instance of the class
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="MonitorResolutionInfo" /> class.
        /// </summary>
        /// <param name="horizontalResolution">Horizontal resolution in pixels</param>
        /// <param name="verticalResolution">Vertical resolution in pixels.</param>
        /// <param name="verticalRefresh">Vertical refresh rate in Hz</param>
        /// <param name="name">Name</param>
        internal MonitorResolutionInfo(int horizontalResolution, int verticalResolution, byte verticalRefresh, string name) : this(horizontalResolution, verticalResolution, verticalRefresh, false, name)
        {
        }
        #endregion

        #region [internal] MonitorResolutionInfo(int, int, byte, bool): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the <see cref="MonitorResolutionInfo" /> class.
        /// </summary>
        /// <param name="horizontalResolution">Horizontal resolution in pixels</param>
        /// <param name="verticalResolution">Vertical resolution in pixels.</param>
        /// <param name="verticalRefresh">Vertical refresh rate in Hz</param>
        /// <param name="reduceBlanking"><b>true</b> if flicker is reduced; <b>false</b> otherwise</param>
        /// <param name="name">Name</param>
        internal MonitorResolutionInfo(int horizontalResolution, int verticalResolution, byte verticalRefresh, bool reduceBlanking, string name) : this(horizontalResolution, verticalResolution, verticalRefresh, false, reduceBlanking, name)
        {
        }
        #endregion

        #region [internal] MonitorResolutionInfo(int, int, byte, bool, bool, string): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the <see cref="MonitorResolutionInfo" /> class.
        /// </summary>
        /// <param name="horizontalResolution">Horizontal resolution in pixels</param>
        /// <param name="verticalResolution">Vertical resolution in pixels.</param>
        /// <param name="verticalRefresh">Vertical refresh rate in Hz</param>
        /// <param name="interlaced"><b>true</b> if it is interlaced; <b>false</b> otherwise</param>
        /// <param name="reduceBlanking"><b>true</b> if flicker is reduced; <b>false</b> otherwise</param>
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

        #endregion

        #region interfaces

        #region public methods

        #region [public] (bool) Equals(MonitorResolutionInfo): Indicates whether the current object is equal to another object of the same type
        /// <inheritdoc />
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">Objeto que se va a comparar con este objeto.</param>
        /// <returns>
        /// Returns <b>true</b> if the current object is equal to the <c>other</c> parameter; otherwise, <b>false</b>.
        /// </returns>
        public bool Equals(MonitorResolutionInfo other) => other.Equals((object)this);
        #endregion

        #endregion

        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(MonitorResolutionInfo, MonitorResolutionInfo): Implements the equality operator (==)
        /// <summary>
        /// Implements the equality operator (==).
        /// </summary>
        /// <param name="deviceInfo1">Operand 1</param>
        /// <param name="deviceInfo2">Operand 2</param>
        /// <returns>
        /// Returns <b>true</b> if <c>deviceInfo1</c> is equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator ==(MonitorResolutionInfo deviceInfo1, MonitorResolutionInfo deviceInfo2) => deviceInfo1.Equals(deviceInfo2);
        #endregion

        #region [public] {static} (bool) operator !=(MonitorResolutionInfo, MonitorResolutionInfo): Implement the inequality operator (!=)
        /// <summary>
        /// Implement the inequality operator (!=).
        /// </summary>
        /// <param name="deviceInfo1">Operand 1</param>
        /// <param name="deviceInfo2">Operand 2</param>
        /// <returns>
        /// Returns <b>true</b> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator !=(MonitorResolutionInfo deviceInfo1, MonitorResolutionInfo deviceInfo2) => !deviceInfo1.Equals(deviceInfo2);
        #endregion

        #endregion

        #region public properties

        #region [public] (string) Name: Gets a value that represents the resolution name
        /// <summary>
        /// Gets a value that represents the resolution name.
        /// </summary>
        /// <value>
        /// Value represents the resolution name.
        /// </value>
        public string Name { get; }
        #endregion

        #region [public] (string) ApectRatio: Gets a value that represents the the aspect ratio
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
                double aspectRatio = Size.Width / (double)Size.Height;
                switch (aspectRatio)
                {
                    case (double)4/3:
                        return "4:3";
                    case (double)1.6:
                        return "16:10";
                    case (double)5 / 4:
                        return "5:4";
                    case (double)9 / 5:
                        return "9:5";
                    case (double)16 / 9:
                        return "16:9";
                    case (double)192 / 145:
                        return "192:145";
                    default:
                        return "1:1";
                }
            }
        }
        #endregion

        #region [public] (byte) Frequency: Gets a value that represents the frequency with which the video driver updates the monitor image
        /// <summary>
        /// Gets a value that represents the frequency with which the video driver updates the monitor image.
        /// </summary>
        /// <value>
        /// Frequency with which the video driver updates the monitor image.
        /// </value>
        public byte Frequency { get; }
        #endregion

        #region [public] (bool) Interlaced: Gets a value indicating whether this resolution is interlaced
        /// <summary>
        /// Gets a value indicating whether this resolution is interlaced.
        /// </summary>
        /// <value>
        /// <b>true</b> if it is linked; <b>false</b> otherwise.
        /// </value>
        public bool Interlaced { get; }
        #endregion

        #region [public] (bool) ReduceBlanking: Gets a value that indicates whether this resolution reduces flicker
        /// <summary>
        /// Gets a value that indicates whether this resolution reduces flicker.
        /// </summary>
        /// <value>
        /// <b>true</b> if it reduces flicker; <b>false</b> otherwise.
        /// </value>
        public bool ReduceBlanking { get; }
        #endregion

        #region [public] (Size) Size: Gets a value that represents the size in pixels of the video mode
        /// <summary>
        /// Gets a value that represents the size in pixels of the video mode.
        /// </summary>
        /// <value>
        /// Value representing the size in pixels of the video mode.
        /// </value>
        public Size Size => new Size(_horizontalResolution, _verticalResolution);
        #endregion

        #endregion

        #region public override methods        

        #region [public] {override} (int) GetHashCode(): Returns the hash code of the object
        /// <summary>
        /// Returns the hash code of the object.
        /// </summary>
        /// <returns>
        /// Hash code.
        /// </returns>
        public override int GetHashCode() => ToString().GetHashCode();
        #endregion

        #region [public] {override} (bool) Equals(object obj): Returns a value that indicates whether this object is equal to another
        /// <summary>
        /// Returns a value that indicates whether this object is equal to another.
        /// </summary>
        /// <param name="obj">Object with which to compare</param>
        /// <returns>
        /// Equality result.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is MonitorResolutionInfo))
            {
                return false;
            }

            var other = (MonitorResolutionInfo)obj;

            return 
                other.Size.Equals(Size) && 
                other.Frequency.Equals(Frequency) && 
                other.ReduceBlanking.Equals(ReduceBlanking) &&
                other.Interlaced.Equals(Interlaced);
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current class
        /// <summary>
        /// Returns a <see cref="string"/> that represents the current class.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents the <see cref="MonitorResolutionInfo" /> current class.
        /// </returns>
        public override string ToString() => ReduceBlanking ? $"{Size.Width} x {Size.Height}, {Frequency} Hz, Reduce Blanking" : $"{Size.Width} x {Size.Height}, {Frequency} Hz";
        #endregion

        #endregion
    }
}
