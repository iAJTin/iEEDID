
using System.Collections.ObjectModel;
using System.Diagnostics;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections
{
    // CEA Section: Monitor Support Information
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Total number of native    BYTE        Número de versión implementada.                     |
    // |              Detailed Timing                       Note: Please see, Number                            |
    // |              Descriptors in entire                                                                     |
    // |              E-EDID structure. Also,                                                                   |
    // |              indication of underscan                                                                   |
    // |              support,audio support,                                                                    |
    // |              and support of YCBCR is                                                                   |
    // |              included                                                                                  |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="CeaSection.MonitorSupport"/> section of this block <see cref="KnownDataBlock.CEA"/>.
    /// </summary> 
    internal sealed class MonitorSupportSection : BaseDataSection
    {
        #region constructor/s

        #region [public] MonitorSupportSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorSupportSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public MonitorSupportSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) MonitorSupport: Gets a value representing the 'Monitor Support' field
        /// <summary>
        /// Gets a value representing the <b>Monitor Support</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MonitorSupport => RawData[0x00];
        #endregion

        #region [private] (bool) IsDvtUnderscan: Gets a value representing the 'DVT Underscan' characteristic of 'Monitor Support' field
        /// <summary>
        /// Gets a value representing the <b>DVT Underscan</b> characteristic of <b>Monitor Support</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsDvtUnderscan
        {
            get
            {
                byte monitorSupport = MonitorSupport;
                bool isDvtUnderscan = monitorSupport.CheckBit(Bits.Bit07);

                return isDvtUnderscan;
            }
        }
        #endregion

        #region [private] (bool) BasicAudioSupported: Gets a value representing the 'Basic Audio Supported' characteristic of 'Monitor Support' field
        /// <summary>
        /// Gets a value representing the <b>Basic Audio Supported</b> characteristic of <b>Monitor Support</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool BasicAudioSupported
        {
            get
            {
                byte monitorSupport = MonitorSupport;
                bool basicAudioSupported = monitorSupport.CheckBit(Bits.Bit06);

                return basicAudioSupported;
            }
        }
        #endregion

        #region [private] (bool) YCbCr444Supported: Gets a value representing the 'YCbCr 4:4:4' characteristic of 'Monitor Support' field
        /// <summary>
        /// Gets a value representing the <b>YCbCr 4:4:4</b> characteristic of <b>Monitor Support</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool YCbCr444Supported
        {
            get
            {
                byte monitorSupport = MonitorSupport;
                bool yCbCr444Supported = monitorSupport.CheckBit(Bits.Bit05);

                return yCbCr444Supported;
            }
        }
        #endregion

        #region [private] (bool) YCbCr422Supported: Gets a value representing the 'YCbCr 4:2:2' characteristic of 'Monitor Support' field
        /// <summary>
        /// Gets a value representing the <b>YCbCr 4:2:2</b> characteristic of <b>Monitor Support</b> field.
        /// </summary>
        /// <value>
        /// Property value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool YCbCr422Supported
        {
            get
            {
                byte monitorSupport = MonitorSupport;
                bool yCbCr422Supported = monitorSupport.CheckBit(Bits.Bit04);

                return yCbCr422Supported;
            }
        }
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
            properties.Add(EedidProperty.Cea.MonitorSupport.IsDvtUnderscan, IsDvtUnderscan);
            properties.Add(EedidProperty.Cea.MonitorSupport.BasicAudioSupported, BasicAudioSupported);
            properties.Add(EedidProperty.Cea.MonitorSupport.YCbCr444Supported, YCbCr444Supported);
            properties.Add(EedidProperty.Cea.MonitorSupport.YCbCr422Supported, YCbCr422Supported);
        }
        #endregion

        #endregion
    }
}
