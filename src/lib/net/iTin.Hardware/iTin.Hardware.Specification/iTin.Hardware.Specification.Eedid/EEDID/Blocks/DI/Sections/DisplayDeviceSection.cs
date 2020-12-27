
namespace iTin.Hardware.Specification.Eedid.Blocks.DI.Sections
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    // DI Section: Display Device
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                                                                   |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Sub-Pixel Layout          BYTE                                                                                                      |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Sub-Pixel Configuration   BYTE                                                                                                      |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Sub-Pixel Shape           BYTE                                                                                                      |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          HPP                       BYTE                                                                                                      |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          VPP                       BYTE                                                                                                      |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Major Display Device      BYTE                                                                                                      |
    // |              Characteristics                                                                                                                     |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="DiSection.DisplayDevice"/> section of this block <see cref="KnownDataBlock.DI"/>.
    /// </summary> 
    internal sealed class DisplayDeviceSection : BaseDataSection
    {
        #region constructor/s

        #region [public] DisplayDeviceSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayDeviceSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public DisplayDeviceSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) SubPixelLayout: Gets a value representing the 'Sub-Pixel Layout' field
        /// <summary>
        /// Gets a value representing the <b>Sub-Pixel Layout</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SubPixelLayout => RawData[0x00];
        #endregion

        #region [private] (byte) SubPixelConfiguration: Gets a value representing the 'Sub-Pixel Configuration' field
        /// <summary>
        /// Gets a value representing the <b>Sub-Pixel Configuration</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SubPixelConfiguration => RawData[0x01];
        #endregion

        #region [private] (byte) SubPixelShape: Gets a value representing the 'Sub-Pixel Shape' field
        /// <summary>
        /// Gets a value representing the <b>Sub-Pixel Shape</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte SubPixelShape => RawData[0x02];
        #endregion

        #region [private] (float) HorizontalDotPixelPitch: Gets a value representing the 'Horizontal Dot/Pixel Pitch' field
        /// <summary>
        /// Gets a value representing the <b>Horizontal Dot/Pixel Pitch</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private float HorizontalDotPixelPitch => RawData[0x03] / 100.0f;
        #endregion

        #region [private] (float) VerticalDotPixelPitch: Gets a value representing the 'Vertical Dot/Pixel Pitch' field
        /// <summary>
        /// Gets a value representing the <b>Vertical Dot/Pixel Pitch</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private float VerticalDotPixelPitch => RawData[0x04] / 100.0f;
        #endregion

        #region [private] (byte) MajorDisplayDeviceCharacteristics: Gets a value representing the 'Major Display Device Characteristics' field
        /// <summary>
        /// Gets a value representing the <b>Major Display Device Characteristics</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MajorDisplayDeviceCharacteristics => RawData[0x05];
        #endregion

        #region [private] (byte) ViewDirection: Gets a value representing the 'View Direction' field
        /// <summary>
        /// Gets a value representing the <b>View Direction</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ViewDirection => (byte)((MajorDisplayDeviceCharacteristics >> 5) & 0x03);
        #endregion

        #region [private] (byte) PhysicalImplementation: Gets a value representing the 'Physical Implementation' field
        /// <summary>
        /// Gets a value representing the <b>Physical Implementation</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte PhysicalImplementation => (byte)((MajorDisplayDeviceCharacteristics >> 2) & 0x03);
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
            properties.Add(EedidProperty.DI.DisplayDevice.SubPixelLayout, GetSubPixelLayout(SubPixelLayout));
            properties.Add(EedidProperty.DI.DisplayDevice.SubPixelConfiguration, GetSubPixelConfiguration(SubPixelConfiguration));
            properties.Add(EedidProperty.DI.DisplayDevice.SubPixelShape, GetSubPixelShape(SubPixelShape));
            properties.Add(EedidProperty.DI.DisplayDevice.HorizontalDotPixelPitch, HorizontalDotPixelPitch);
            properties.Add(EedidProperty.DI.DisplayDevice.VerticalDotPixelPitch, VerticalDotPixelPitch);
            properties.Add(EedidProperty.DI.DisplayDevice.FixedPixelFormat, MajorDisplayDeviceCharacteristics.CheckBit(Bits.Bit07));
            properties.Add(EedidProperty.DI.DisplayDevice.ViewDirection, GetViewDirection(ViewDirection));
            properties.Add(EedidProperty.DI.DisplayDevice.DisplayBackground, MajorDisplayDeviceCharacteristics.CheckBit(Bits.Bit04));
            properties.Add(EedidProperty.DI.DisplayDevice.PhysicalImplementation, GetPhysicalImplementation(PhysicalImplementation));
            properties.Add(EedidProperty.DI.DisplayDevice.DDC, MajorDisplayDeviceCharacteristics.CheckBit(Bits.Bit01));
        }
        #endregion

        #endregion


        #region VESA Display Information Extension Block Standard

        private static string GetPhysicalImplementation(byte code)
        {
            var items = new List<string>
            {
                "Not specified",                        // 0x00
                "Large Image device for group viewing",
                "Desktop or personal display",
                "Eyepiece type personal display"        // 0x03
            };

            return code > 0x03
                ? "Unknown"
                : items[code];
        }

        private static string GetSubPixelConfiguration(byte code)
        {
            var items = new List<string>
            {
                "Not defined",   // 0x00
                "Delta (Tri-ad)",
                "Stripe",
                "Stripe Offset",
                "Quad Pixel"     // 0x04
            };

            return code > 0x04
                ? "Reserved"
                : items[code];
        }

        private static string GetSubPixelLayout(byte code)
        {
            var items = new List<string>
            {
                "Not defined",                               // 0x00
                "RGB",
                "BGR",
                "Quad Pixel - G at bottom left & top right",
                "Quad Pixel - G at bottom right & top left"  // 0x04
            };

            return code > 0x04
                ? "Reserved"
                : items[code];
        }

        private static string GetSubPixelShape(byte code)
        {
            var items = new List<string>
            {
                "Not defined",   // 0x00
                "Round",
                "Square",
                "Rectangular",
                "Oval",
                "Elliptical"     // 0x05
            };

            return code > 0x05
                ? "Reserved"
                : items[code];
        }

        private static string GetViewDirection(byte code)
        {
            var items = new List<string>
            {
                "Not specified",          // 0x00
                "Direct View",
                "Reflected View",
                "Direct & Reflected View" // 0x03
            };

            return code > 0x03
                ? "Unknown"
                : items[code];
        }

        #endregion
    }
}
