﻿
namespace iTin.Hardware.Specification.Eedid.Blocks.DI.Sections
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core;
    using iTin.Core.Helpers.Enumerations;

    // DI Section: Digital Interface
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                                                                   |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Digital Interface         BYTE            Value  Description                                                                        |
    // |              Standard/Specification                      00h  Display has an Analog Video Input (See NOTE 1)                                     |
    // |                                                          01h  Display has a Digital Video Input but the Standard/Specification cannot be defined |
    // |                                                          02h  Digital Visual Interface (DVI) - Single Link                                       |
    // |                                                          03h  Digital Visual Interface (DVI) - Dual Link - High Resolution                       |
    // |                                                          04h  Digital Visual Interface (DVI) - Dual Link - High Color                            |
    // |                                                          05h  Digital Visual Interface (DVI) - For Consumer Electronics                          |
    // |                                                          06h  Plug & Display (P&D)                                                               |
    // |                                                          07h  Digital Flat Panel (DFP)                                                           |
    // |                                                          08h  Open LDI (National Semiconductor) - Single Link                                    |
    // |                                                          09h  Open LDI (National Semiconductor) - Dual Link                                      |
    // |                                                          0Ah  Open LDI (National Semiconductor) - For Consumer Electronics                       |
    // |                                                    0Bh - FFh  Reserved (Do Not Use)                                                              |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Type Definition           BYTE                                                                                                      |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Version/Release Number    BYTE                                                                                                      |
    // |              Letter Designation                                                                                                                  |
    // |              or Year Code                                                                                                                        |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          Revision Number           BYTE                                                                                                      |
    // |              or Month Code                                                                                                                       |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Revision Number           BYTE                                                                                                      |
    // |              or Day Code                                                                                                                         |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 05h          Digital Interface Data    BYTE                                                                                                      |
    // |              Format Description                                                                                                                  |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Digital Interface         BYTE                                                                                                      |
    // |              Standard Data Formats                                                                                                               |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 07h          Minimum Pixel Clock       BYTE                                                                                                      |
    // |              Frequency Per Link                                                                                                                  |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Maximum Pixel Clock       WORD                                                                                                      |
    // |              Frequency Per Link                                                                                                                  |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0Ah          Crossover Frequency       WORD                                                                                                      |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="DiSection.DigitalInterface"/> section of this block <see cref="KnownDataBlock.DI"/>.
    /// </summary> 
    internal sealed class DigitalInterfaceSection : BaseDataSection
    {
        #region constructor/s

        #region [public] DigitalInterfaceSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="DigitalInterfaceSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public DigitalInterfaceSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) DigitalInterface: Gets a value representing the 'Digital Interface' field
        /// <summary>
        /// Gets a value representing the <b>Digital Interface</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DigitalInterface => RawData[0x00];

        #endregion

        #region [private] (byte) TypeDefinition: Gets a value representing the 'Type Definition' field
        /// <summary>
        /// Gets a value representing the <b>Type Definition</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte TypeDefinition => RawData[0x01];
        #endregion

        #region [private] (byte) DataFormatDescription: Gets a value representing the 'Data Format Description' field
        /// <summary>
        /// Gets a value representing the <b>Data Format Description</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DataFormatDescription => RawData[0x05];
        #endregion

        #region [private] (byte) EdgeOfShiftClockUsage: Gets a value representing the 'Edge Of Shift Clock Usage' field
        /// <summary>
        /// Gets a value representing the <b>Edge Of Shift Clock Usage</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte EdgeOfShiftClockUsage => (byte) ((DataFormatDescription >> 4) & 0x03);
        #endregion

        #region [private] (byte) DataFormats: Gets a value representing the 'Data Formats' field
        /// <summary>
        /// Gets a value representing the <b>Data Formats</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DataFormats => RawData[0x06];
        #endregion

        #region [private] (byte) MinimumPixelClockFrequencyPerLink: Gets a value representing the 'Minimum Pixel Clock Frequency Per Link' field
        /// <summary>
        /// Gets a value representing the <b>Minimum Pixel Clock Frequency Per Link</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MinimumPixelClockFrequencyPerLink => RawData[0x07];
        #endregion

        #region [private] (int) MaximumPixelClockFrequencyPerLink: Gets a value representing the 'Maximum Pixel Clock Frequency Per Link' field
        /// <summary>
        /// Gets a value representing the <b>Maximum Pixel Clock Frequency Per Link</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int MaximumPixelClockFrequencyPerLink => RawData.GetWord(0x08);
        #endregion

        #region [private] (int) CrossoverFrequency: Gets a value representing the 'Crossover Frequency' field
        /// <summary>
        /// Gets a value representing the <b>Crossover Frequency</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int CrossoverFrequency => RawData.GetWord(0x0a);
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
            properties.Add(EedidProperty.DI.DigitalInterface.SupportedDigitalInterface, GetSupportedDigitalInterface(DigitalInterface));

            var dataEnableSignalUsageAvailable = DataFormatDescription.CheckBit(Bits.Bit07);
            properties.Add(EedidProperty.DI.DigitalInterface.DataEnableSignalUsageAvailable, dataEnableSignalUsageAvailable);
            if (dataEnableSignalUsageAvailable)
            {
                properties.Add(EedidProperty.DI.DigitalInterface.DataEnableSignalHighOrLow, GetDataEnableSignalHighOrLow(DataFormatDescription.CheckBit(Bits.Bit06)));
            }

            properties.Add(EedidProperty.DI.DigitalInterface.EdgeOfShiftClock, GetEdgeOfShiftClockUsage(EdgeOfShiftClockUsage));
            properties.Add(EedidProperty.DI.DigitalInterface.HdcpSupport, DataFormatDescription.CheckBit(Bits.Bit03));
            properties.Add(EedidProperty.DI.DigitalInterface.DoubleClockingOfInputData, DataFormatDescription.CheckBit(Bits.Bit02));
            properties.Add(EedidProperty.DI.DigitalInterface.SupportForPacketizedDigitalVideoSupport, DataFormatDescription.CheckBit(Bits.Bit01));
            properties.Add(EedidProperty.DI.DigitalInterface.DataFormats, GetDataFormats(DataFormats));
            properties.Add(EedidProperty.DI.DigitalInterface.MinimumPixelClockFrequencyPerLink, MinimumPixelClockFrequencyPerLink);
            properties.Add(EedidProperty.DI.DigitalInterface.MaximumPixelClockFrequencyPerLink, MaximumPixelClockFrequencyPerLink);
            properties.Add(EedidProperty.DI.DigitalInterface.CrossoverFrequency, CrossoverFrequency);
        }
        #endregion

        #endregion


        #region VESA Display Information Extension Block Standard

        private static string GetDataEnableSignalHighOrLow(bool isHigh)
        {
            return isHigh
                ? "Data enabled when the DE signal is high"
                : "Data enabled when the DE signal is low";
        }

        private static string GetDataFormats(byte value)
        {
            switch(value)
            {
                case 0x00:
                    return "Display has an Analog Video Input";

                case 0x15:
                    return "8-Bit Over 8-Bit RGB";

                case 0x19:
                    return "12-Bit Over 12-Bit RGB";

                case 0x24:
                    return "24-Bit MSB-Aligned RGB (Single Link)";

                case 0x48:
                    return "48-Bit MSB-Aligned RGB (Dual Link, Hi-Resolution)";

                case 0x49:
                    return "48-Bit MSB-Aligned RGB (Dual Link, Hi-Color)";

                default:
                    return "Reserved";
            }
        }

        private static string GetEdgeOfShiftClockUsage(byte code)
        {
            var items = new List<string>
            {
                "Not specified",                    // 0x00
                "Use rising edge of shift clock",
                "Use falling edge of shift clock",
                "Use both edges of shift clock"     // 0x03
            };

            return code > 0x03
                ? "Unknown"
                : items[code];
        }

        private static string GetSupportedDigitalInterface(byte code)
        {
            var items = new List<string>
            {
                "Display has an Analog Video Input",                                                  // 0x00
                "Display has a Digital Video Input but the Standard/Specification cannot be defined",
                "DVI Single Link",
                "DVI Dual Link High Resolution",
                "DVI Dual Link High Color",
                "DVI For Consumer Electronics",
                "Plug & Display",
                "Digital Flat Panel",
                "Open LDI Single Link",
                "Open LDI Dual Link",
                "Open LDI For Consumer Electronics"                                                   // 0x0a
            };

            return code > 0x0a
                ? "Reserved"
                : items[code];
        }

        #endregion
    }
}
