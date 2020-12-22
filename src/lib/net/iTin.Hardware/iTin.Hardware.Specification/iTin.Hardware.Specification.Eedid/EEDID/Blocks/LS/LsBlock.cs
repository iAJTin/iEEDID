
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Specialization of the <see cref="BaseDataBlock"/> class.<br/>
    /// Representing the block <see cref="KnownDataBlock.LS"/> of the specification <see cref="EEDID"/>.
    /// </summary> 
    internal class LsBlock : BaseDataBlock
    {
        #region constructor/s

        #region [public] LsBlock(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="LsBlock"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="dataBlock">Raw data of this block.</param>
        /// <remarks>
        /// Create a <see cref="KnownDataBlock.LS"/> block (block 0) which belongs to the <see cref="EEDID"/> specification.
        /// </remarks>
        public LsBlock(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) InitSectionTable(Dictionary<Enum, BaseDataSection>): Initialize dictionary with the available data for the sections of this block
        /// <summary>
        /// Initialize dictionary with the available data for the sections of this block.
        /// </summary>
        /// <param name="sectionDictionary">Dictionary that contains the available data for the sections of this block</param>
        protected override void InitSectionTable(Dictionary<Enum, BaseDataSection> sectionDictionary)
        {
        }
        #endregion

        #endregion
    }
}
