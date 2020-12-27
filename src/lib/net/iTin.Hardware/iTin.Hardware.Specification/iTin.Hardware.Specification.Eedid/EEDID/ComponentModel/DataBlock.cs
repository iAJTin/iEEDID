
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    using Blocks.CEA.Sections;
    using Blocks.DI.Sections;
    using Blocks.DisplayId.Sections;
    using Blocks.EDID.Sections;

    /// <summary>
    /// Represents a data block
    /// </summary>
    public sealed class DataBlock
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataBlockCollection _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BaseDataSectionCollection _sections;
        #endregion

        #region constructor/s

        #region [internal] DataBlock(KeyValuePair<KnownDataBlock, BaseDataBlock>): Initialize a new instance of the class by specifying the key and data associated to the raw block
        /// <summary>
        /// Initialize a new instance of the class <see cref="DataBlockCollection"/> by specifying the key and data associated to the raw block.
        /// </summary>
        /// <param name="blockDictionaryEntry">Data associated with this block</param>
        internal DataBlock(KeyValuePair<KnownDataBlock, BaseDataBlock> blockDictionaryEntry)
        {
            Key = blockDictionaryEntry.Key;

            var targetBlock = blockDictionaryEntry.Value;
            RawData = new ReadOnlyCollection<byte>(targetBlock.GetRawData().ToList().Take(128).ToList());
            SectionTable = targetBlock.SectionTable;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (bool) HasSections: Gets a value that indicates if there are available sections
        /// <summary>
        /// Gets a value that indicates if there are available sections.
        /// </summary>
        /// <value>
        /// <b>true</b> if there are sections; otherwise, it is <b>false</b>.
        /// </value>
        public bool HasSections => SectionTable.Count > 0;
        #endregion

        #region [public] (KnownDataBlock) Key: Gets a value that represents the key of this datablock
        /// <summary>
        /// Gets a value that represents the key of this <see cref="DataBlock" />.
        /// </summary>
        /// <value>
        /// One of the values in the enumeration <see cref="KnownDataBlock" /> that represents the key of this <see cref="DataBlock" />.
        /// </value>
        [field: DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public KnownDataBlock Key { get; }
        #endregion

        #region [public] (DataBlockCollection) Parent: Gets a value that represents the collection to which this block belongs
        /// <summary>
        /// Gets a value that represents the collection <see cref="DataBlockCollection"/> to which this <see cref="DataBlock"/> belongs.
        /// </summary>
        /// <value>
        /// Collection <see cref="DataBlockCollection" /> to which this <see cref="DataBlock" /> belongs.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public DataBlockCollection Parent => _parent;
        #endregion

        #region [public] (ReadOnlyCollection<byte>) RawData: Gets current raw data block data
        /// <summary>
        /// Gets current raw data block data.
        /// </summary>
        /// <returns>
        /// Raw data block data.
        /// </returns>
        public ReadOnlyCollection<byte> RawData { get; }
        #endregion

        #region [public] (BaseDataSectionCollection) Sections: Gets the collection of sections available for this DataBlock
        /// <summary>
        /// Gets the collection of sections available for this <see cref="DataBlock" />.
        /// </summary>
        /// <value>
        /// Object <see cref="BaseDataSectionCollection" /> that contains the object collection <see cref="DataSection" /> for this <see cref="DataBlock" />.
        /// If there is no <see cref="DataSection" /> object, <b>null</b> is returned.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public BaseDataSectionCollection Sections
        {
            get
            {
                if (!HasSections)
                {
                    return _sections;
                }

                if (_sections != null)
                {
                    return _sections;
                }

                switch (Key)
                {
                    case KnownDataBlock.CEA:
                        _sections = new CeaDataSectionCollection(this);
                        break;

                    case KnownDataBlock.DI:
                        _sections = new DiDataSectionCollection(this);
                        break;

                    case KnownDataBlock.DisplayID:
                        _sections = new DisplayIdDataSectionCollection(this);
                        break;

                    case KnownDataBlock.EDID:
                        _sections = new EdidDataSectionCollection(this);
                        break;

                    case KnownDataBlock.LS:
                        _sections = new CeaDataSectionCollection(this);
                        break;

                    case KnownDataBlock.VTB:
                        _sections = new CeaDataSectionCollection(this);
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                return _sections;
            }
        }
        #endregion

        #endregion

        #region internal properties

        #region [internal] (Dictionary<Enum, BaseDataSection>) SectionTable: Gets a value that contains the available sections
        /// <summary>
        /// Gets a value that contains the available sections.
        /// </summary>
        /// <value>
        /// Dictionary that contains Section / Value of the section.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal Dictionary<Enum, BaseDataSection> SectionTable { get; }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (String) ToString(): Returns a string representing the current DataBlock object
        /// <summary>
        /// Returns a string representing the current <see cref="DataBlock" /> object.
        /// </summary>
        /// <returns>
        /// <see cref="T:System.String"/> representing the current <see cref="DataBlock" /> object.
        /// </returns>
        /// <remarks>
        /// The method <see cref="DataBlock.ToString ()" /> returns a string that includes the key of the current block.
        /// </remarks>   
        public override string ToString() => $"Key=\"{Key}\"";
        #endregion

        #endregion

        #region internal methods

        #region [internal] (void) SetParent(DataBlockCollection): Sets the object DataBlockCollection> to which this DataBlock belongs
        /// <summary>
        /// Sets the object <see cref="DataBlockCollection" /> to which this <see cref="DataBlock" /> belongs.
        /// </summary>
        /// <param name="parent">Object <see cref="DataBlockCollection" /> to which this <see cref="DataBlock" /> belongs.</param>
        internal void SetParent(DataBlockCollection parent)
        {
            _parent = parent;
        }
        #endregion

        #endregion
    }
}
