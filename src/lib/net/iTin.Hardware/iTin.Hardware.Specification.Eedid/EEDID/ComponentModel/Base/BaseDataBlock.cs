
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace iTin.Hardware.Specification.Eedid;

/// <summary>
/// Base class that represents a block of the <b>Extended display identification data (E-EDID)</b>.
/// </summary> 
internal abstract class BaseDataBlock
{
    #region private members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Dictionary<Enum, BaseDataSection> _sectionTable;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Dictionary<Enum, ReadOnlyCollection<byte>> _dataSectionTable;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of <see cref="BaseDataBlock"/> class with the data associated with this section.
    /// </summary>
    /// <param name="dataBlock">Data block</param>
    protected BaseDataBlock(ReadOnlyCollection<byte> dataBlock)
    {
        RawData = dataBlock;
    }

    #endregion

    #region protected properties

    /// <summary>
    ///  Gets or sets the current block version.
    /// </summary>
    /// <value>
    /// Current block version.
    /// </value>
    protected int BlockVersion { get; set; }

    #endregion

    #region protected readonly properties

    /// <summary>
    /// Gets a value that represents the raw data available for sections of the current block.
    /// </summary>
    /// <value>
    /// Dictionary that contains the section / Value unprocessed of the same.
    /// </value>
    protected Dictionary<Enum, ReadOnlyCollection<byte>> DataSectionTable
    {
        get
        {
            if (_dataSectionTable != null)
            {
                return _dataSectionTable;
            }

            _dataSectionTable = new Dictionary<Enum, ReadOnlyCollection<byte>>(0x0a);
            InitDataSectionTable(_dataSectionTable);
            return _dataSectionTable;
        }
    }

    /// <summary>
    /// Obtiene un valor que representa los datos a procesar.Gets a value that represents the data to be processed.
    /// </summary>
    /// <value>Data to process.</value>
    protected ReadOnlyCollection<byte> RawData { get; }

    #endregion

    #region private readonly properties

    /// <summary>
    /// Gets a value that represents the available sections of the current block.
    /// </summary>
    /// <value>
    /// Dictionary that contains the section Section / Value of it.
    /// </value>
    public Dictionary<Enum, BaseDataSection> SectionTable
    {
        get
        {
            if (_sectionTable != null)
            {
                return _sectionTable;
            }

            _sectionTable = new Dictionary<Enum, BaseDataSection>(0x0a);
            InitSectionTable(_sectionTable);

            return _sectionTable;
        }
    }

    #endregion

    #region public methods

    /// <summary>
    /// Returns current raw data block data.
    /// </summary>
    /// <returns>
    /// Raw data block data.
    /// </returns>
    public ReadOnlyCollection<byte> GetRawData() => RawData;

    #endregion

    #region protected virtual methods

    /// <summary>
    /// Initialize dictionary with raw data available for sections of the current block.
    /// </summary>
    /// <param name="dataSectionDictionary">Dictionary containing the raw data available for sections of the current block.</param>
    protected virtual void InitDataSectionTable(Dictionary<Enum, ReadOnlyCollection<byte>> dataSectionDictionary)
    {
    }

    /// <summary>
    /// Initialize dictionary with the sections available for the current block.
    /// </summary>
    /// <param name="sectionDictionary">Dictionary containing the sections available for the current block.</param>
    protected virtual void InitSectionTable(Dictionary<Enum, BaseDataSection> sectionDictionary)
    {
    }

    #endregion

    #region public override methods

    /// <summary>
    /// Returns a class <see cref="T:System.String"/> that represents the class.
    /// <see cref="BaseDataBlock"/> actual.
    /// </summary>
    /// <returns>
    /// A string representing the class <see cref="BaseDataBlock"/> current.
    /// </returns>
    /// <remarks>
    /// The <see cref="BaseDataBlock.ToString()"/> method returns a string that includes the number of available sections.
    /// </remarks>
    public override string ToString() => $"Sections = {SectionTable.Count}";

    #endregion
}
