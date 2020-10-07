
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    /// <summary>
    /// Represents the set of <b>sections</b> available for the <see cref="KnownDataBlock.EDID"/> information of the <see cref="EEDID"/> specification.
    /// </summary>
    internal sealed class EdidSections
    {
        #region private readonly membrs
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly EdidDataSectionCollection _edidSections;
        #endregion

        #region private membrs
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

        #region constructor/s

        #region [internal] EdidSections(EdidDataSectionCollection): Initialize a new instance of class with the information of the available sections of the 'EDID'
        /// <summary>
        /// Initialize a new instance of the <see cref="EdidSections"/> with the information of the available sections of the <see cref="KnownDataBlock.EDID"/> block.
        /// </summary>
        /// <param name="edidSections">Information of available sections.</param>
        internal EdidSections(EdidDataSectionCollection edidSections)
        {
            _edidSections = edidSections;
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (ReadOnlyCollection<Enum>) Sections: Gets a value that contains the sections implemented for a block of type 'EDID'
        /// <summary>
        /// Gets a value that contains the sections implemented for a block of type <see cref="KnownDataBlock.EDID"/>.
        /// </summary>
        /// <value>
        /// Sections implemented for a block of type <see cref="KnownDataBlock.EDID"/>
        /// </value>
        private ReadOnlyCollection<Enum> Sections => _availableSections ?? (_availableSections = _edidSections.ImplementedSections);

        #endregion

        #endregion

        #region public readonly properties

        #region [public] (DataSection) HeaderSection: Gets a value that represents the 'Header' section of a 'EDID' block of the 'EEDID' specification
        /// <summary>
        /// Gets a value that represents the <see cref="KnownEdidSection.Header"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
        /// </summary>
        /// <value>
        /// Object that represents the section.
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

        #region [public] (DataSection) VendorSection: Gets a value that represents the 'Vendor' section of a 'EDID' block of the 'EEDID' specification
        /// <summary>
        /// Gets a value that represents the <see cref="KnownEdidSection.Vendor"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
        /// </summary>
        /// <value>
        /// Object that represents the section.
        /// </value>
        public DataSection VendorSection
        {
            get
            {
                if (_vendorSection != null)
                {
                    return _vendorSection;
                }

                var sections = Sections;
                var exitsSection = sections.Contains(KnownEdidSection.Vendor);
                if (exitsSection)
                {
                    _vendorSection = _edidSections[KnownEdidSection.Vendor];
                }

                return _vendorSection;
            }
        }
        #endregion

        #region [public] (DataSection) VersionSection: Gets a value that represents the 'Version' section of a 'EDID' block of the 'EEDID' specification
        /// <summary>
        /// Gets a value that represents the <see cref="KnownEdidSection.Version"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
        /// </summary>
        /// <value>
        /// Object that represents the section.
        /// </value>
        public DataSection VersionSection
        {
            get
            {
                if (_versionSection != null)
                {
                    return _versionSection;
                }

                var sections = Sections;
                var exitsSection = sections.Contains(KnownEdidSection.Version);
                if (exitsSection)
                {
                    _versionSection = _edidSections[KnownEdidSection.Version];
                }

                return _versionSection;
            }
        }
        #endregion

        #region [public] (DataSection) BasicDisplaySection: Gets a value that represents the 'BasicDisplay' section of a 'EDID' block of the 'EEDID' specification
        /// <summary>
        /// Gets a value that represents the <see cref="KnownEdidSection.BasicDisplay"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
        /// </summary>
        /// <value>
        /// Object that represents the section.
        /// </value>
        public DataSection BasicDisplaySection
        {
            get
            {
                if (_basicDisplaySection != null)
                {
                    return _basicDisplaySection;
                }

                var sections = Sections;
                var exitsSection = sections.Contains(KnownEdidSection.BasicDisplay);
                if (exitsSection)
                {
                    _basicDisplaySection = _edidSections[KnownEdidSection.BasicDisplay];
                }

                return _basicDisplaySection;
            }
        }
        #endregion

        #region [public] (DataSection) ColorCharacteristicsSection: Gets a value that represents the 'ColorCharacteristics' section of a 'EDID' block of the 'EEDID' specification
        /// <summary>
        /// Gets a value that represents the <see cref="KnownEdidSection.ColorCharacteristics"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
        /// </summary>
        /// <value>
        /// Object that represents the section.
        /// </value>
        public DataSection ColorCharacteristicsSection
        {
            get
            {
                if (_colorCharacteristicsSection != null)
                {
                    return _colorCharacteristicsSection;
                }

                var sections = Sections;
                var exitsSection = sections.Contains(KnownEdidSection.ColorCharacteristics);
                if (exitsSection)
                {
                    _colorCharacteristicsSection = _edidSections[KnownEdidSection.ColorCharacteristics];
                }

                return _colorCharacteristicsSection;
            }
        }
        #endregion

        #region [public] (DataSection) EstablishedTimingsSection: Gets a value that represents the 'EstablishedTimings' section of a 'EDID' block of the 'EEDID' specification
        /// <summary>
        /// Gets a value that represents the <see cref="KnownEdidSection.EstablishedTimings"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
        /// </summary>
        /// <value>
        /// Object that represents the section.
        /// </value>
        public DataSection EstablishedTimingsSection
        {
            get
            {
                if (_establishedTimmingsSection != null)
                {
                    return _establishedTimmingsSection;
                }

                var sections = Sections;
                var exitsSection = sections.Contains(KnownEdidSection.EstablishedTimings);
                if (exitsSection)
                {
                    _establishedTimmingsSection = _edidSections[KnownEdidSection.EstablishedTimings];
                }

                return _establishedTimmingsSection;
            }
        }
        #endregion

        #region [public] (DataSection) StandardTimingsSection: Gets a value that represents the 'StandardTimings' section of a 'EDID' block of the 'EEDID' specification
        /// <summary>
        /// Gets a value that represents the <see cref="KnownEdidSection.StandardTimings"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
        /// </summary>
        /// <value>
        /// Object that represents the section.
        /// </value>
        public DataSection StandardTimingsSection
        {
            get
            {
                if (_standardTimmingsSection != null)
                {
                    return _standardTimmingsSection;
                }

                var sections = Sections;
                var exitsSection = sections.Contains(KnownEdidSection.StandardTimings);
                if (exitsSection)
                {
                    _standardTimmingsSection = _edidSections[KnownEdidSection.StandardTimings];
                }

                return _standardTimmingsSection;
            }
        }
        #endregion

        #region [public] (DataSection) DataBlocksSection: Gets a value that represents the 'DataBlocks' section of a 'EDID' block of the 'EEDID' specification
        /// <summary>
        /// Gets a value that represents the <see cref="KnownEdidSection.DataBlocks"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
        /// </summary>
        /// <value>
        /// Object that represents the section.
        /// </value>
        public DataSection DataBlocksSection
        {
            get
            {
                if (_dataBlocks != null)
                {
                    return _dataBlocks;
                }

                var sections = Sections;
                var exitsSection = sections.Contains(KnownEdidSection.DataBlocks);
                if (exitsSection)
                {
                    _dataBlocks = _edidSections[KnownEdidSection.DataBlocks];
                }

                return _dataBlocks;
            }
        }
        #endregion

        #region [public] (DataSection) ExtensionBlocks: Gets a value that represents the 'ExtensionBlocks' section of a 'EDID' block of the 'EEDID' specification
        /// <summary>
        /// Gets a value that represents the <see cref="KnownEdidSection.ExtensionBlocks"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
        /// </summary>
        /// <value>
        /// Object that represents the section.
        /// </value>
        public DataSection ExtensionBlocksSection
        {
            get
            {
                if (_extensionBlocksSection != null)
                {
                    return _extensionBlocksSection;
                }

                var sections = Sections;
                var exitsSection = sections.Contains(KnownEdidSection.ExtensionBlocks);
                if (exitsSection)
                {
                    _extensionBlocksSection = _edidSections[KnownEdidSection.ExtensionBlocks];
                }

                return _extensionBlocksSection;
            }
        }
        #endregion

        #region [public] (DataSection) CheckSumSection: Gets a value that represents the 'CheckSum' section of a 'EDID' block of the 'EEDID' specification
        /// <summary>
        /// Gets a value that represents the <see cref="KnownEdidSection.CheckSum"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
        /// </summary>
        /// <value>
        /// Object that represents the section.
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
                var exitsSection = sections.Contains(KnownEdidSection.CheckSum);
                if (exitsSection)
                {
                    _checkSumSection = _edidSections[KnownEdidSection.CheckSum];
                }

                return _checkSumSection;
            }
        }
        #endregion

        #endregion
    }
}
