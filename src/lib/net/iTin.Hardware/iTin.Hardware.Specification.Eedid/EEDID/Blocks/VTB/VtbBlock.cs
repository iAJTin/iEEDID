﻿
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace iTin.Hardware.Specification.Eedid.Blocks;

/// <summary>
/// Specialization of the <see cref="BaseDataBlock"/> class.<br/>
/// Representing the block <see cref="KnownDataBlock.VTB"/> of the specification <see cref="EEDID"/>.
/// </summary> 
internal class VtbBlock : BaseDataBlock
{
    #region constructor/s

    /// <summary>
    /// Initialize a new instance of the <see cref="VtbBlock"/> class with the data in this section untreated.
    /// </summary>
    /// <param name="dataBlock">Raw data of this block.</param>
    /// <remarks>
    /// Create a <see cref="KnownDataBlock.VTB"/> block (block 0) which belongs to the <see cref="EEDID"/> specification.
    /// </remarks>
    public VtbBlock(ReadOnlyCollection<byte> dataBlock) 
        : base(dataBlock)
    {
    }

    #endregion

    #region protected override methods

    /// <inheritdoc />
    protected override void InitDataSectionTable(Dictionary<Enum, ReadOnlyCollection<byte>> dataSectionDictionary)
    {
        var dataArray = RawData.ToArray();
    }

    /// <inheritdoc />
    protected override void InitSectionTable(Dictionary<Enum, BaseDataSection> sectionDictionary)
    {
    }

    #endregion
}
