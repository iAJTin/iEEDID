
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    /// <summary>
    /// Representa al conjunto de <strong>secciones</strong> disponibles para la información <see cref="KnownDataBlock.EDID"/> de la especificación <see cref="EEDID"/>.
    /// </summary>
    sealed class EdidSectionsInformation
    {
        #region Declaraciones
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly EdidDataSectionCollection _edidSections;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ReadOnlyCollection<Enum> _availableSections;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _headerSection;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _vendorSection;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _versionSection;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _basicDisplaySection;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _colorCharacteristicsSection;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _establishedTimmingsSection;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _standardTimmingsSection;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _dataBlocks;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _extensionBlocksSection;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _checkSumSection;
        #endregion

        #region Constructor/es

        #region [internal] EdidSectionsInformation(EdidDataSectionCollection): Inicializa una nueva instancia de la clase con la información de las secciones del bloque 'EDID' disponibles.
        /// <summary>
        /// Inicializa una nueva instancia de la <see cref="EdidSectionsInformation"/> con la información de las secciones del bloque <see cref="KnownDataBlock.EDID"/> disponibles.
        /// </summary>
        /// <param name="edidSections">Información de las secciones disponibles.</param>
        internal EdidSectionsInformation(EdidDataSectionCollection edidSections)
        {
            _edidSections = edidSections;
        }
        #endregion

        #endregion

        #region Propiedades

        #region [public] (DataSection) HeaderSection: Obtiene un valor que representa a la sección 'Header' de un bloque 'EDID' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="KnownEdidSection.Header"/> de un bloque <see cref="KnownDataBlock.EDID"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection HeaderSection
        {
            get
            {
                if (_headerSection != null)
                {
                    return _headerSection;
                }

                var sections = Sections;
                var exitsSection = sections.Contains(KnownEdidSection.Header);
                if (exitsSection)
                {
                    _headerSection = _edidSections[KnownEdidSection.Header];
                }

                return _headerSection;
            }
        }
        #endregion

        #region [public] (DataSection) VendorSection: Obtiene un valor que representa a la sección 'Vendor' de un bloque 'EDID' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="KnownEdidSection.Vendor"/> de un bloque <see cref="KnownDataBlock.EDID"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection VendorSection
        {
            get
            {
                if (_vendorSection == null)
                {
                    var sections = Sections;
                    var exitsSection = sections.Contains(KnownEdidSection.Vendor);

                    if (exitsSection)
                        _vendorSection = _edidSections[KnownEdidSection.Vendor];
                }
                return _vendorSection;
            }
        }
        #endregion

        #region [public] (DataSection) VersionSection: Obtiene un valor que representa a la sección 'Version' de un bloque 'EDID' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="KnownEdidSection.Version"/> de un bloque <see cref="KnownDataBlock.EDID"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection VersionSection
        {
            get
            {
                if (_versionSection == null)
                {
                    var sections = Sections;
                    var exitsSection = sections.Contains(KnownEdidSection.Version);

                    if (exitsSection)
                        _versionSection = _edidSections[KnownEdidSection.Version];
                }
                return _versionSection;
            }
        }
        #endregion

        #region [public] (DataSection) BasicDisplaySection: Obtiene un valor que representa a la sección 'BasicDisplay' de un bloque 'EDID' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="KnownEdidSection.BasicDisplay"/> de un bloque <see cref="KnownDataBlock.EDID"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection BasicDisplaySection
        {
            get
            {
                if (_basicDisplaySection == null)
                {
                    var sections = Sections;
                    var exitsSection = sections.Contains(KnownEdidSection.BasicDisplay);

                    if (exitsSection)
                        _basicDisplaySection = _edidSections[KnownEdidSection.BasicDisplay];
                }
                return _basicDisplaySection;
            }
        }
        #endregion

        #region [public] (DataSection) ColorCharacteristicsSection: Obtiene un valor que representa a la sección 'ColorCharacteristics' de un bloque 'EDID' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="KnownEdidSection.ColorCharacteristics"/> de un bloque <see cref="KnownDataBlock.EDID"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection ColorCharacteristicsSection
        {
            get
            {
                if (_colorCharacteristicsSection == null)
                {
                    var sections = Sections;
                    var exitsSection = sections.Contains(KnownEdidSection.ColorCharacteristics);

                    if (exitsSection)
                        _colorCharacteristicsSection = _edidSections[KnownEdidSection.ColorCharacteristics];
                }
                return _colorCharacteristicsSection;
            }
        }
        #endregion

        #region [public] (DataSection) EstablishedTimingsSection: Obtiene un valor que representa a la sección 'EstablishedTimings' de un bloque 'EDID' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="KnownEdidSection.EstablishedTimings"/> de un bloque <see cref="KnownDataBlock.EDID"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection EstablishedTimingsSection
        {
            get
            {
                if (_establishedTimmingsSection == null)
                {
                    var sections = Sections;
                    var exitsSection = sections.Contains(KnownEdidSection.EstablishedTimings);

                    if (exitsSection)
                        _establishedTimmingsSection = _edidSections[KnownEdidSection.EstablishedTimings];
                }
                return _establishedTimmingsSection;
            }
        }
        #endregion

        #region [public] (DataSection) StandardTimingsSection: Obtiene un valor que representa a la sección 'StandardTimings' de un bloque 'EDID' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="KnownEdidSection.StandardTimings"/> de un bloque <see cref="KnownDataBlock.EDID"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection StandardTimingsSection
        {
            get
            {
                if (_standardTimmingsSection == null)
                {
                    var sections = Sections;
                    var exitsSection = sections.Contains(KnownEdidSection.StandardTimings);

                    if (exitsSection)
                        _standardTimmingsSection = _edidSections[KnownEdidSection.StandardTimings];
                }
                return _standardTimmingsSection;
            }
        }
        #endregion

        #region [public] (DataSection) DataBlocksSection: Obtiene un valor que representa a la sección 'DataBlocks' de un bloque 'EDID' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="KnownEdidSection.DataBlocks"/> de un bloque <see cref="KnownDataBlock.EDID"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection DataBlocksSection
        {
            get
            {
                if (_dataBlocks == null)
                {
                    var sections = Sections;
                    var exitsSection = sections.Contains(KnownEdidSection.DataBlocks);

                    if (exitsSection)
                        _dataBlocks = _edidSections[KnownEdidSection.DataBlocks];
                }
                return _dataBlocks;
            }
        }
        #endregion

        #region [public] (DataSection) DataBlocksSection: Obtiene un valor que representa a la sección 'ExtensionBlockCount' de un bloque 'EDID' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="KnownEdidSection.ExtensionBlocks"/> de un bloque <see cref="KnownDataBlock.EDID"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection ExtensionBlocksSection
        {
            get
            {
                if (_extensionBlocksSection == null)
                {
                    var sections = Sections;
                    var exitsSection = sections.Contains(KnownEdidSection.ExtensionBlocks);

                    if (exitsSection)
                        _extensionBlocksSection = _edidSections[KnownEdidSection.ExtensionBlocks];
                }
                return _extensionBlocksSection;
            }
        }
        #endregion

        #region [public] (DataSection) CheckSumSection: Obtiene un valor que representa a la sección 'CheckSum' de un bloque 'EDID' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="KnownEdidSection.CheckSum"/> de un bloque <see cref="KnownDataBlock.EDID"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection CheckSumSection
        {
            get
            {
                if (_checkSumSection == null)
                {
                    var sections = Sections;
                    var exitsSection = sections.Contains(KnownEdidSection.CheckSum);

                    if (exitsSection)
                        _checkSumSection = _edidSections[KnownEdidSection.CheckSum];
                }
                return _checkSumSection;
            }
        }
        #endregion

        #endregion

        #region Miembros privados

        #region [private] (ReadOnlyCollection<Enum>) Sections: Obtiene un valor que contiene las secciones implementadas para un bloque de tipo 'EDID'.
        /// <summary>
        /// Obtiene un valor que contiene las secciones implementadas para un bloque de tipo <see cref="KnownDataBlock.EDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="ReadOnlyCollection{Enum}"/></para>
        ///   <para>Secciones implementadas para un bloque de tipo <see cref="KnownDataBlock.EDID"/>.</para>
        /// </value>
        private ReadOnlyCollection<Enum> Sections
        {
            get
            {
                if (_availableSections == null)
                    _availableSections = _edidSections.ImplementedSections;

                return _availableSections;
            }
        }
        #endregion

        #endregion
    }
}