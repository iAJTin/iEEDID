
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Eedid.Blocks.DI.Sections
{
    // DI Section: Display Transfer Characteristic
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                                                                   |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h                                                                                                                                              |
    // •——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="DiSection.DisplayTransferCharacteristic"/> section of this block <see cref="KnownDataBlock.DI"/>.
    /// </summary> 
    internal sealed class DisplayTransferCharacteristicSection : BaseDataSection
    {
        #region constructor/s

        #region [public] DisplayTransferCharacteristicSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayTransferCharacteristicSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public DisplayTransferCharacteristicSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) StatusAndNumberLuminanceEntries: Gets a value representing the 'Status And Entries' field
        /// <summary>
        /// Gets a value representing the <b>Status And Entries</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte StatusAndNumberLuminanceEntries => RawData[0x00];
        #endregion

        #region [private] (byte) Status: Gets a value representing the 'Combined (White) or Separate (RGB) Sub-Channels' field
        /// <summary>
        /// Gets a value representing the <b>Combined (White) or Separate (RGB) Sub-Channels</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Status => (byte) (StatusAndNumberLuminanceEntries >> 0x06 & 0x03);
        #endregion

        #region [private] (byte) NumberLuminanceEntries: Gets a value representing the 'Number of Luminance Entries' field
        /// <summary>
        /// Gets a value representing the <b>Number of Luminance Entries</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte NumberLuminanceEntries => (byte) (StatusAndNumberLuminanceEntries & 0x3f);
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
            properties.Add(EedidProperty.DI.DisplayTransferCharacteristic.Status, GetStatus(Status));
            properties.Add(EedidProperty.DI.DisplayTransferCharacteristic.NumberLuminanceEntries, NumberLuminanceEntries);
        }
        #endregion

        #endregion


        #region VESA Display Information Extension Block Standard

        private static string GetStatus(byte code)
        {
            if (code == 0x00)
            {
                return "No Display Transfer Characteristics";
            }

            if (code > 0x02)
            {
                return "Reserved";
            }

            return "Contains Display Transfer Characteristics";
        }

        #endregion
    }
}
