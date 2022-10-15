
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections
{
    /// <summary>
    /// Represents the set of <b>sections</b> available for the <see cref="KnownDataBlock.CEA"/> information of the <see cref="EEDID"/> specification.
    /// </summary>
    internal sealed class CeaSectionsInformation
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly CeaDataSectionCollection _ceaSections;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ReadOnlyCollection<Enum> _availableSections;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _informationSection;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _monitorSupportSection;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _detailedTimingSection;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _dataBlocksCollectionSection;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataSection _checkSumSection;
        #endregion

        #region constructor/s

        #region [internal] CeaSectionsInformation(CeaDataSectionCollection): Inicializa una nueva instancia de la clase con la información de las secciones del bloque 'CEA' disponibles.
        /// <summary>
        /// Inicializa una nueva instancia de la <see cref="CeaSectionsInformation"/> con la información de las secciones del bloque <see cref="KnownDataBlock.CEA"/> disponibles.
        /// </summary>
        /// <param name="ceaSections">Información de las secciones disponibles.</param>
        internal CeaSectionsInformation(CeaDataSectionCollection ceaSections)
        {
            _ceaSections = ceaSections;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (DataSection) InformationSection: Obtiene un valor que representa a la sección 'Information' de un bloque 'CEA' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="CeaSection.Information"/> de un bloque <see cref="KnownDataBlock.CEA"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection InformationSection
        {
            get
            {
                if (_informationSection != null)
                {
                    return _informationSection;
                }

                var sections = Sections;
                var exitsSection = sections.Contains(CeaSection.Information);
                if (exitsSection)
                {
                    _informationSection = _ceaSections[CeaSection.Information];
                }

                return _informationSection;
            }
        }
        #endregion

        #region [public] (DataSection) MonitorSupportSection: Obtiene un valor que representa a la sección 'MonitorSupport' de un bloque 'CEA' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="CeaSection.MonitorSupport"/> de un bloque <see cref="KnownDataBlock.CEA"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection MonitorSupportSection
        {
            get
            {
                if (_monitorSupportSection != null)
                {
                    return _monitorSupportSection;
                }

                var sections = Sections;
                var exitsSection = sections.Contains(CeaSection.MonitorSupport);
                if (exitsSection)
                {
                    _monitorSupportSection = _ceaSections[CeaSection.MonitorSupport];
                }

                return _monitorSupportSection;
            }
        }
        #endregion

        #region [public] (DataSection) DetailedTimingSection: Obtiene un valor que representa a la sección 'DetailedTiming' de un bloque 'CEA' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="CeaSection.DetailedTiming"/> de un bloque <see cref="KnownDataBlock.CEA"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection DetailedTimingSection
        {
            get
            {
                if (_detailedTimingSection != null)
                {
                    return _detailedTimingSection;
                }

                var sections = Sections;
                var exitsSection = sections.Contains(CeaSection.DetailedTiming);
                if (exitsSection)
                {
                    _detailedTimingSection = _ceaSections[CeaSection.DetailedTiming];
                }

                return _detailedTimingSection;
            }
        }
        #endregion

        #region [public] (DataSection) DataBlocksSection: Obtiene un valor que representa a la sección 'DataBlockCollection' de un bloque 'CEA' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="CeaSection.DataBlockCollection"/> de un bloque <see cref="KnownDataBlock.CEA"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection DataBlockCollectionSection
        {
            get
            {
                if (_dataBlocksCollectionSection != null)
                {
                    return _dataBlocksCollectionSection;
                }

                var sections = Sections;
                var exitsSection = sections.Contains(CeaSection.DataBlockCollection);
                if (exitsSection)
                {
                    _dataBlocksCollectionSection = _ceaSections[CeaSection.DataBlockCollection];
                }

                return _dataBlocksCollectionSection;
            }
        }
        #endregion

        #region [public] (DataSection) DataBlocksSection: Obtiene un valor que representa a la sección 'CheckSum' de un bloque 'CEA' de la especificación 'EEDID'.
        /// <summary>
        /// Obtiene un valor que representa la sección <see cref="CeaSection.Checksum"/> de un bloque <see cref="KnownDataBlock.CEA"/> de la especificación <see cref="EEDID"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="DataSection"/></para>
        ///   <para>Objeto que representa la sección.</para>
        /// </value>
        public DataSection CheckSumSection
        {
            get
            {
                if (_checkSumSection != null)
                {
                    return _checkSumSection;
                }

                var sections = Sections;
                var exitsSection = sections.Contains(CeaSection.Checksum);
                if (exitsSection)
                {
                    _checkSumSection = _ceaSections[CeaSection.Checksum];
                }

                return _checkSumSection;
            }
        }
        #endregion

        #endregion

        #region private members

        #region [private] (ReadOnlyCollection<Enum>) Sections: Obtiene un valor que contiene las secciones implementadas para un bloque de tipo 'CEA'.
        /// <summary>
        /// Obtiene un valor que contiene las secciones implementadas para un bloque de tipo <see cref="KnownDataBlock.CEA"/>.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="ReadOnlyCollection{Enum}"/></para>
        ///   <para>Secciones implementadas para un bloque de tipo <see cref="KnownDataBlock.CEA"/>.</para>
        /// </value>
        private ReadOnlyCollection<Enum> Sections => _availableSections ?? (_availableSections = _ceaSections.ImplementedSections);
        #endregion

        #endregion
    }
}
