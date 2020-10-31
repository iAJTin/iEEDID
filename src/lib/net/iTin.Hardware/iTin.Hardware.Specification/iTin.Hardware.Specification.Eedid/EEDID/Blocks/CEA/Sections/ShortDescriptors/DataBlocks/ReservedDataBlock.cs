
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Structure <see cref="ReservedDataBlock"/> that contains the logic to decode the data of a block of type <see cref="ShortReservedDescriptorCeaSection"/>.
    /// </summary> 
    internal struct ReservedDataBlock
    {
        #region constructor/s

        #region [public] ReservedDataBlock(ReadOnlyCollection<byte>): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservedDataBlock"/> structure specifying the data for this reserved block.
        /// </summary>
        /// <param name="reservedDataBlock">Data of this reserved block.</param>
        public ReservedDataBlock(ReadOnlyCollection<byte> reservedDataBlock)
        {
            RawData = reservedDataBlock;
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (ReadOnlyCollection<byte>) RawData: Gets a value that represents the data in this reserved block
        /// <summary>
        /// Gets a value that represents the data in this reserved block.
        /// </summary>
        /// <value>
        /// Data of this reserved block.
        /// </value>
        public ReadOnlyCollection<byte> RawData { get; }
        #endregion

        #endregion
    }
}
