
using System;
using System.Collections.ObjectModel;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections;

/* •————————————————•
   | CEA Data Block |
   |   · Tag code   |
   |   · Length     |
   |   · RawData    |
   •————————————————• */

/// <summary>
/// A <see cref="CeaDataBlock"/> structure that contains the raw information of the blocks of type <strong>AllocationDataBlock</strong>.
/// </summary> 
internal readonly struct CeaDataBlock
{
    #region private readonly members

    private readonly int _lenght;
    private readonly ReadOnlyCollection<byte> _dataBlock;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="CeaDataBlock"/> structure.
    /// </summary>
    /// <param name="dataBlock">Data from this block.</param>
    public CeaDataBlock(ReadOnlyCollection<byte> dataBlock)
    {
        _dataBlock = dataBlock;
        _lenght = _dataBlock[0x00] & 0x1f;
        Tag = (ShortDataBlockTag)((_dataBlock[0x00] & 0xe0) >> 5);
    }
           
    #endregion

    #region public properties

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

    /// <summary>
    /// Gets a value that represents the type of block.
    /// </summary>
    /// <value>
    /// One of the <see cref="ShortDataBlockTag"/> enumeration values that represents the block type.
    /// </value>
    public ShortDataBlockTag Tag { get; }

    #endregion
}
