
namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using iTin.Core;

    // Display Structure Section: Version & Revision Information
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                                 |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Version                   BYTE        Implemented version and revision number.                    |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Bytes in section          BYTE        Total bytes in section. Max. Value FBh                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Display Product Type      BYTE            Value  Description                                      |
    // |                                                          00h  Extension Section                                |
    // |                                                          01h  Test Structure; test equipment only              |
    // |                                                          02h  Display panel or other transducer, LCD           |
    // |                                                               or PDP module, etc.                              |
    // |                                                          03h  Standalone display devices, desktop              |
    // |                                                               monitor, TV monitor, etc.; that may              |
    // |                                                               include scaling and/or frame-rate conversion     |
    // |                                                               capabilities, but cannot receive/decode/         |
    // |                                                               demodulate RF signals.                           |
    // |                                                          04h  Television receiver; a display product capable   |
    // |                                                               of receiving/decoding/demodulating RF signals    |
    // |                                                          05h  Repeater/translator; that is not itself intended |
    // |                                                               as a display device.                             |
    // |                                                          06h  DIRECT DRIVE monitor                             |
    // |                                                    07h - 0Fh  Reserved                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 03h          Extension Count           BYTE        Extension Count Number.                                     |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="DisplayIdSection.General"/> section of this block <see cref="KnownDataBlock.DisplayID"/>.
    /// </summary> 
    internal sealed class GeneralSection : BaseDataSection
    {
        #region constructor/s

        #region [public] GeneralSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="GeneralSection"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public GeneralSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (byte[]) VersionRawData: Gets a value representing the 'Version & Revision Raw Data' field
        /// <summary>
        /// Gets a value representing the <c>Version and Revision Raw Data</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte[] VersionRawData => RawData[0x00].ToNibbles();
        #endregion

        #region [private] (byte) Version: Gets a value representing the 'Version' field
        /// <summary>
        /// Gets a value representing the <c>Version</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Version => VersionRawData[0];
        #endregion

        #region [private] (byte) Revision: Gets a value representing the 'Revision' field
        /// <summary>
        /// Gets a value representing the <c>Revision</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Revision => VersionRawData[1];
        #endregion

        #region [private] (byte) DisplayProductType: Gets a value representing the 'Display Product Type Identifier' field
        /// <summary>
        /// Gets a value representing the <c>Display Product Type Identifier</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte DisplayProductType => RawData[2];
        #endregion

        #region [private] (byte) ExtensionCount: Gets a value representing the 'Extension Count' field
        /// <summary>
        /// Gets a value representing the <c>Extension Count</c> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ExtensionCount => RawData[3];
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
            properties.Add(EedidProperty.DisplayID.General.Version, Version);
            properties.Add(EedidProperty.DisplayID.General.Revision, Revision);
            properties.Add(EedidProperty.DisplayID.General.ExtensionCount, ExtensionCount);
            properties.Add(EedidProperty.DisplayID.General.DisplayProductType, GetDisplayProductType(DisplayProductType));
        }
        #endregion

        #endregion


        #region VESA Display Identification Data (DisplayID)

        private static string GetDisplayProductType(byte code)
        {
            var items = new List<string>
            {
                "Extension Section",         // 0x00
                "Test Structure",
                "Display panel",
                "Standalone display device",
                "Television receiver",
                "Repeater/translator",
                "Direct drive monitor"       // 0x06
            };

            return code > 0x06
                ? "Reserved"
                : items[code];
        }

        #endregion
    }
}
