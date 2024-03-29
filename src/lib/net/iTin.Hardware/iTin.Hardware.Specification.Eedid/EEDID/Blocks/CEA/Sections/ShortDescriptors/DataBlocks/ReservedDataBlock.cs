﻿
using System.Collections.ObjectModel;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors.DataBlocks;

/// <summary>
/// Structure <see cref="ReservedDataBlock"/> that contains the logic to decode the data of a block of type <see cref="ShortReservedDescriptorSection"/>.
/// </summary> 
internal readonly struct ReservedDataBlock
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="ReservedDataBlock"/> structure specifying the data for this reserved block.
    /// </summary>
    /// <param name="reservedDataBlock">Data of this reserved block.</param>
    public ReservedDataBlock(ReadOnlyCollection<byte> reservedDataBlock)
    {
        RawData = reservedDataBlock;
    }

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets a value that represents the data in this reserved block.
    /// </summary>
    /// <value>
    /// Data of this reserved block.
    /// </value>
    public ReadOnlyCollection<byte> RawData { get; }

    #endregion
}
