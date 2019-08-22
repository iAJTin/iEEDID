
namespace iTin.Core.Hardware.Specification.Eedid
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
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.MonitorResolutionInfo" /> class.
        /// </summary>
        /// <param name="horizontalResolution">Horizontal resolution in pixels</param>
        /// <param name="verticalResolution">Vertical resolution in pixels.</param>
        /// <param name="verticalRefresh">Vertical refresh rate in Hz</param>
        internal MonitorResolutionInfo(int horizontalResolution, int verticalResolution, byte verticalRefresh) : this(horizontalResolution, verticalResolution, verticalRefresh, false)
        {
        }
        #endregion

        #region [internal] MonitorResolutionInfo(int, int, byte, bool): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.MonitorResolutionInfo" /> class.
        /// </summary>
        /// <param name="horizontalResolution">Horizontal resolution in pixels</param>
        /// <param name="verticalResolution">Vertical resolution in pixels.</param>
        /// <param name="verticalRefresh">Vertical refresh rate in Hz</param>
        /// <param name="reduceBlanking"><strong>true</strong> if flicker is reduced; <strong>false</strong> otherwise</param>
        internal MonitorResolutionInfo(int horizontalResolution, int verticalResolution, byte verticalRefresh, bool reduceBlanking) : this(horizontalResolution, verticalResolution, verticalRefresh, false,reduceBlanking)
        {
        }
        #endregion

        #region [internal] MonitorResolutionInfo(int, int, byte, bool, bool): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.MonitorResolutionInfo" /> class.
        /// </summary>
        /// <param name="horizontalResolution">Horizontal resolution in pixels</param>
        /// <param name="verticalResolution">Vertical resolution in pixels.</param>
        /// <param name="verticalRefresh">Vertical refresh rate in Hz</param>
        /// <param name="interlaced"><strong>true</strong> if it is interlaced; <strong>false</strong> otherwise</param>
        /// <param name="reduceBlanking"><strong>true</strong> if flicker is reduced; <strong>false</strong> otherwise</param>
        internal MonitorResolutionInfo(int horizontalResolution, int verticalResolution, byte verticalRefresh, bool interlaced, bool reduceBlanking)
        {
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
        /// <strong>true</strong> if it is linked; <strong>false</strong> otherwise.
        /// </value>
        public bool Interlaced { get; }
        #endregion

        #region [public] (bool) ReduceBlanking: Gets a value that indicates whether this resolution reduces flicker
        /// <summary>
        /// Gets a value that indicates whether this resolution reduces flicker.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if it reduces flicker; <strong>false</strong> otherwise.
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
        /// Returns a <see cref="T:System.String" /> that represents the current class.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the <see cref="MonitorResolutionInfo" /> current class.
        /// </returns>
        public override string ToString() => ReduceBlanking ? $"{Size.Width} x {Size.Height}, {Frequency} Hz, Reduce Blanking" : $"{Size.Width} x {Size.Height}, {Frequency} Hz";
        #endregion

        #endregion
    }
}
