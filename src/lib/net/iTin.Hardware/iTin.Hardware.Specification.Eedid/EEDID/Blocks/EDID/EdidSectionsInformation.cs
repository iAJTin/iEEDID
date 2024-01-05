
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections;

/// <summary>
/// Represents the set of <strong>sections</strong> available for the <see cref="KnownDataBlock.EDID"/> information of the <see cref="EEDID"/> specification.
/// </summary>
internal sealed class EdidSectionsInformation
{
    #region private readonly membrs
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly EdidDataSectionCollection _edidSections;
    #endregion

    #region private members
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

    /// <summary>
    /// Initialize a new instance of the <see cref="EdidSectionsInformation"/> with the information of the available sections of the <see cref="KnownDataBlock.EDID"/> block.
    /// </summary>
    /// <param name="edidSections">Information of available sections.</param>
    internal EdidSectionsInformation(EdidDataSectionCollection edidSections)
    {
        _edidSections = edidSections;
    }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value that contains the sections implemented for a block of type <see cref="KnownDataBlock.EDID"/>.
    /// </summary>
    /// <value>
    /// Sections implemented for a block of type <see cref="KnownDataBlock.EDID"/>
    /// </value>
    private ReadOnlyCollection<Enum> Sections => _availableSections ??= _edidSections.ImplementedSections;

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets a value that represents the <see cref="EedidProperty.Edid.Header"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
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
            var exitsSection = sections.Contains(EdidSection.Header);
            if (exitsSection)
            {
                _headerSection = _edidSections[EdidSection.Header];
            }

            return _headerSection;
        }
    }

    /// <summary>
    /// Gets a value that represents the <see cref="EedidProperty.Cea.DataBlock.Vendor"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
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
            var exitsSection = sections.Contains(EdidSection.Vendor);
            if (exitsSection)
            {
                _vendorSection = _edidSections[EdidSection.Vendor];
            }

            return _vendorSection;
        }
    }

    /// <summary>
    /// Gets a value that represents the <see cref="EdidSection.Version"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
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
            var exitsSection = sections.Contains(EdidSection.Version);
            if (exitsSection)
            {
                _versionSection = _edidSections[EdidSection.Version];
            }

            return _versionSection;
        }
    }

    /// <summary>
    /// Gets a value that represents the <see cref="EedidProperty.Edid.BasicDisplay"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
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
            var exitsSection = sections.Contains(EdidSection.BasicDisplay);
            if (exitsSection)
            {
                _basicDisplaySection = _edidSections[EdidSection.BasicDisplay];
            }

            return _basicDisplaySection;
        }
    }

    /// <summary>
    /// Gets a value that represents the <see cref="EedidProperty.Edid.ColorCharacteristics"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
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
            var exitsSection = sections.Contains(EdidSection.ColorCharacteristics);
            if (exitsSection)
            {
                _colorCharacteristicsSection = _edidSections[EdidSection.ColorCharacteristics];
            }

            return _colorCharacteristicsSection;
        }
    }

    /// <summary>
    /// Gets a value that represents the <see cref="EedidProperty.Edid.EstablishedTimings"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
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
            var exitsSection = sections.Contains(EdidSection.EstablishedTimings);
            if (exitsSection)
            {
                _establishedTimmingsSection = _edidSections[EdidSection.EstablishedTimings];
            }

            return _establishedTimmingsSection;
        }
    }

    /// <summary>
    /// Gets a value that represents the <see cref="EedidProperty.Edid.StandardTimings"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
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
            var exitsSection = sections.Contains(EdidSection.StandardTimings);
            if (exitsSection)
            {
                _standardTimmingsSection = _edidSections[EdidSection.StandardTimings];
            }

            return _standardTimmingsSection;
        }
    }

    /// <summary>
    /// Gets a value that represents the <see cref="EdidSection.DataBlocks"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
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
            var exitsSection = sections.Contains(EdidSection.DataBlocks);
            if (exitsSection)
            {
                _dataBlocks = _edidSections[EdidSection.DataBlocks];
            }

            return _dataBlocks;
        }
    }

    /// <summary>
    /// Gets a value that represents the <see cref="EedidProperty.Edid.ExtensionBlocks"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
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
            var exitsSection = sections.Contains(EdidSection.ExtensionBlocks);
            if (exitsSection)
            {
                _extensionBlocksSection = _edidSections[EdidSection.ExtensionBlocks];
            }

            return _extensionBlocksSection;
        }
    }

    /// <summary>
    /// Gets a value that represents the <see cref="EdidSection.Checksum"/> section of a <see cref="KnownDataBlock.EDID"/> block of the <see cref="EEDID"/> specification.
    /// </summary>
    /// <value>
    /// Object that represents the section.
    /// </value>
    public DataSection ChecksumSection
    {
        get
        {
            if (_checkSumSection != null)
            {
                return _checkSumSection;
            }

            var sections = Sections;
            var exitsSection = sections.Contains(EdidSection.Checksum);
            if (exitsSection)
            {
                _checkSumSection = _edidSections[EdidSection.Checksum];
            }

            return _checkSumSection;
        }
    }

    #endregion
}
