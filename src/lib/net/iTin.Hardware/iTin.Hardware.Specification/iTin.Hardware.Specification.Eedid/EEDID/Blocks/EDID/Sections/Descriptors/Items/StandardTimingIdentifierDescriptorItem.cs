
namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections.Descriptors
{
    using System.Collections.Generic;
    using System.Diagnostics;
    
    // Data Block Descriptor -> Descriptor Item : Standard Timing Identifier Descriptor Item Definition
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name          Lenght      Descriptin                                                                 |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Byte 1        BYTE        Range                                                                      |
    // |                                        —————                                                                      |
    // |                                              00h Reserved                                                         |
    // |                                        01h - ffh Value Stored (in hex) = (Horizontal addressable pixels ÷ 8) – 31 |
    // |                                                  Range: 256 pixels → 2288 pixels, in increments of 8 pixels       |
    // |                                                  Note:  See HorizontalPixels                                      |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Byte 2        BYTE        Bits 07:06 - Image Aspect Ratio                                            |
    // |                                                     00h - 16 : 10 AR                                              |
    // |                                                     01h -  4 :  3 AR                                              |
    // |                                                     02h -  5 :  4 AR                                              |
    // |                                                     03h - 16 :  9 AR                                              |
    // |                                                     Note:  See AspectRatio                                        |
    // |                                                                                                                   |
    // |                                                     Bits 05:00 - Field Refresh Rate                               |
    // |                                                                  Value Stored = Field Refresh Rate (in Hz) – 60   |
    // |                                                     Note:  See RefreshRate                                        |
    // •———————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Represents an item of the <see cref="StandardTimingIdentifierDescriptor"/>.
    /// </summary>
    public sealed class StandardTimingIdentifierDescriptorItem
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly IList<byte> _sectionData;
        #endregion

        #region constructor/s

        #region [internal] StandardTimingIdentifierDescriptorItem(IList<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="StandardTimingIdentifierDescriptorItem"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        internal StandardTimingIdentifierDescriptorItem(IList<byte> sectionData)
        {
            _sectionData = sectionData;
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (byte) Byte1: Gets a value representing the 'Byte 1' field
        /// <summary>
        /// Gets a value representing the <c>Byte 1</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Byte1 => _sectionData[0x00];
        #endregion

        #region [private] (byte) Byte2: Gets a value representing the 'Byte 1' field
        /// <summary>
        /// Gets a value representing the <c>Byte 1</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Byte2 => _sectionData[0x01];
        #endregion

        #region [private] (byte) FieldAspectRatio: Gets a value representing the 'Aspect Ratio' field
        /// <summary>
        /// Gets a value representing the <c>Aspect Ratio</c>field
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        private byte FieldAspectRatio => (byte) (Byte2 >> 6 & 0x03);
        #endregion

        #endregion

        #region public readonly properties 

        #region [public] (string) AspectRatio: Gets a value that represents the aspect ratio in this way
        /// <summary>
        /// Gets a value that represents the aspect ratio in this way.
        /// </summary>
        /// <value>
        /// Aspect ratio.
        /// </value>
        public string AspectRatio => GetAspectRatio(FieldAspectRatio);
        #endregion

        #region [public] (int) HorizontalPixels: Gets the number of horizontal pixels in this way
        /// <summary>
        /// Gets the number of horizontal pixels in this way.
        /// </summary>
        /// <value>
        /// Number of horizontal pixels
        /// </value>
        public int HorizontalPixels => (Byte1 + 31) << 3;
        #endregion

        #region [public] (int) RefreshRate: Gets the vertical refresh rate in Hertz in this way
        /// <summary>
        /// Gets the vertical refresh rate in Hertz in this way.
        /// </summary>
        /// <value>
        /// Vertical refresh rate.
        /// </value>
        public int RefreshRate => (Byte2 & 0x3f) + 60;
        #endregion

        #region [public] (int) VerticalPixels: Gets the number of vertical pixels in this way
        /// <summary>
        /// Gets the number of vertical pixels in this way.
        /// </summary>
        /// <value>
        /// Number of horizontal pixels
        /// </value>
        public double VerticalPixels => HorizontalPixels / GetAspectRatioValue(FieldAspectRatio);
        #endregion

        #endregion

        #region public override methods    

        #region [public] {override} (string) ToString(): Returns a string that represents the current class
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents the current class.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the <see cref="StandardTimingIdentifierDescriptorItem" /> current class.
        /// </returns>
        public override string ToString() => $"{HorizontalPixels} x {VerticalPixels}, {RefreshRate} Hz";
        #endregion

        #endregion


        #region EDID 1.4 Specification

        #region [private] {static} (string) GetAspectRatio(byte) : Returns the specified aspect ratio
        /// <summary>
        /// Returns the specified aspect ratio
        /// </summary>
        /// <param name="code">Value to analyze</param>
        /// <returns>
        /// Aspect ratio
        /// </returns>
        private static string GetAspectRatio(byte code)
        {
            var items = new[]
            {
                "16:10",
                "4:3",
                "5:4",
                "16:9"
            };

            return items[code];
        }
        #endregion

        #region [private] {static} (double) GetAspectRatioValue(byte): Gets the conversion factor of the indicated aspect ratio
        /// <summary>
        /// Gets the conversion factor of the indicated aspect ratio.
        /// </summary>
        /// <param name="aspectRatio">Value to analyze</param>
        /// <returns>
        /// Aspect ratio conversion factor
        /// </returns>
        private static double GetAspectRatioValue(byte aspectRatio)
        {
            double retval = 1.0;

            switch (aspectRatio)
            {
                case 0x00:
                    retval = 1.6;
                    break;

                case 0x01:
                    retval = (double)4 / 3;
                    break;

                case 0x02:
                    retval = 1.25;
                    break;

                case 0x03:
                    retval = (double)16 / 9;
                    break;
            }

            return retval;
        }
        #endregion

        #endregion
    }
}
