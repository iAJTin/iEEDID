
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.ObjectModel;

    /* •————————————————•
       | CEA Data Block |
       |   · Tag code   |
       |   · Lenght     |
       |   · RawData    |
       •————————————————• */

    /// <summary>
    /// A <see cref = "CeaDataBlock"/> structure that contains the raw information of the blocks of type <b>AllcationDataBlock</b>.
    /// </summary> 
    internal struct CeaDataBlock
    {
        #region constructor/s

        #region [public] CeaDataBlock(ReadOnlyCollection<byte>): Initializes a new instance of the structure
        /// <summary>
        /// Initializes a new instance of the <see cref="CeaDataBlock"/> structure.
        /// </summary>
        /// <param name="dataBlock">Data from this block.</param>
        public CeaDataBlock(ReadOnlyCollection<byte> dataBlock)
        {
            _dataBlock = dataBlock;
            _lenght = _dataBlock[0x00] & 0x1f;
            Tag = (KnownShortDataBlockTag)((_dataBlock[0x00] & 0xe0) >> 5);
        }
        #endregion
           
        #endregion

        #region private readonly members
        private readonly int _lenght;
        private readonly ReadOnlyCollection<byte> _dataBlock;
        #endregion

        #region public properties

        #region [public] (ReadOnlyCollection<byte>) RawData: Gets an array with the information of this raw block
        /// <summary>
        /// Gets an array with the information of this raw block.
        /// </summary>
        /// <value>
        /// Array with the raw block information.
        /// </value>
        public ReadOnlyCollection<byte> RawData
        {
            get
            {
                var dataBlockArray = new byte[_dataBlock.Count];
                _dataBlock.CopyTo(dataBlockArray, 0);

                var rawData = new byte[_lenght];
                Array.Copy(dataBlockArray, 0x01,rawData, 0x00, _lenght);

                return new ReadOnlyCollection<byte>(rawData);
            }
        }
        #endregion

        #region [public] (ShortDataBlockTag) Tag: Gets a value that represents the type of block
        /// <summary>
        /// Gets a value that represents the type of block.
        /// </summary>
        /// <value>
        /// One of the <see cref="KnownShortDataBlockTag"/> enumeration values that represents the block type.
        /// </value>
        public KnownShortDataBlockTag Tag { get; }
        #endregion

        #endregion
    }
}
