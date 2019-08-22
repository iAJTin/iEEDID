
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Helpers.Enumerations;

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

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> que representa la sección <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownCeaSection.MonitorSupport" /> de este bloque <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.CEA" />.
    /// </summary> 
    internal sealed class MonitorSupportCeaSection : BaseDataSection
    {
        #region constructor/s

        #region [public] MonitorSupportCeaSection(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de esta sección sin tratar.
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="MonitorSupportCeaSection"/> con los datos de esta sección sin tratar.
        /// </summary>
        /// <param name="sectionData">Datos de esta sección sin tratar.</param>
        public MonitorSupportCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) MonitorSupport: Obtiene un valor que representa al campo 'Monitor Support'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Monitor Support</c>'.
        /// </summary>
        /// <value>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte MonitorSupport => RawData[0x00];
        #endregion

        #region [private] (bool) IsDvtUnderscan: Obtiene un valor que representa la característica 'DVT Underscan' del campo 'Monitor Support'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>DVT Underscan</c>' del campo '<c>Monitor Support</c>'.
        /// </summary>
        /// <value>
        ///   <para>Valor de la propiedad.</para>
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

        #region [private] (bool) BasicAudioSupported: Obtiene un valor que representa la característica 'Basic Audio Supported' del campo 'Monitor Support'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>Basic Audio Supported</c>' del campo '<c>Monitor Support</c>'.
        /// </summary>
        /// <value>
        ///   <para>Valor de la propiedad.</para>
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

        #region [private] (bool) YCbCr444Supported: Obtiene un valor que representa la característica 'YCbCr 4:4:4' del campo 'Monitor Support'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>YCbCr 4:4:4</c>' del campo '<c>Monitor Support</c>'.
        /// </summary>
        /// <value>
        ///   <para>Valor de la propiedad.</para>
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

        #region [private] (bool) YCbCr422Supported: Obtiene un valor que representa la característica 'YCbCr 4:2:2' del campo 'Monitor Support'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>YCbCr 4:2:2</c>' del campo '<c>Monitor Support</c>'.
        /// </summary>
        /// <value>
        ///   <para>Valor de la propiedad.</para>
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
        /// <inheritdoc />
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
