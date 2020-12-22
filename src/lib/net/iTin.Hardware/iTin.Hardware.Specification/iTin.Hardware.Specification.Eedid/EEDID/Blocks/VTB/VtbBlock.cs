
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Specialization of the <see cref="BaseDataBlock"/> class.<br/>
    /// Representing the block <see cref="KnownDataBlock.VTB"/> of the specification <see cref="EEDID"/>.
    /// </summary> 
    internal class VtbBlock : BaseDataBlock
    {
        #region constructor/s

        #region [public] VtbBlock(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="VtbBlock"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="dataBlock">Raw data of this block.</param>
        /// <remarks>
        /// Create a <see cref="KnownDataBlock.VTB"/> block (block 0) which belongs to the <see cref="EEDID"/> specification.
        /// </remarks>
        public VtbBlock(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) InitSectionTable(Dictionary<Enum, BaseDataSection>): Initialize dictionary with the sections available for this block
        /// <inheritdoc />
        /// <summary>
        /// Initialize dictionary with the sections available for this block.
        /// </summary>
        /// <param name="sectionDictionary">Dictionary containing the sections available for this block</param>
        protected override void InitSectionTable(Dictionary<Enum, BaseDataSection> sectionDictionary)
        {
        }
        #endregion

        #endregion
    }
}
