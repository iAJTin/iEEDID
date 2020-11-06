
using iTin.Core;

namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    // Data Block Descriptor: Standard Timings Identifier Descriptor Definition
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                            |
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Standard Timing 9         WORD        Note: See Timing(KnownStandardTiming)  |
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Standard Timing 10        WORD        Note: See Timing(KnownStandardTiming)  |
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Standard Timing 11        WORD        Note: See Timing(KnownStandardTiming)  |
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Standard Timing 12        WORD        Note: See Timing(KnownStandardTiming)  |
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Standard Timing 13        WORD        Note: See Timing(KnownStandardTiming)  |
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | 0ah          Standard Timing 14        WORD        Note: See Timing(KnownStandardTiming)  |
    // •———————————————————————————————————————————————————————————————————————————————————————————•
    // | 0ch          Line Feed                 BYTE        0ah, all other values are reserved     |
    // •———————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="KnownEdidSection.DataBlocks"/> section of type this block <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/>.
    /// </summary> 
    internal class StandardTimingIdentifierDescriptor : BaseDataSection
    {
        #region private enumerations

        #region [private] (enum) KnownStandardTiming: Known timings for this block
        /// <summary>
        /// Known timings for this block.
        /// </summary> 
        enum KnownStandardTiming
        {
            /// <summary>
            /// Timing 9.
            /// </summary>
            Timing9,

            /// <summary>
            /// Timing 10.
            /// </summary>
            Timing10,

            /// <summary>
            /// Timing 11.
            /// </summary>
            Timing11,

            /// <summary>
            /// Timing 12.
            /// </summary>
            Timing12,

            /// <summary>
            /// Timing 13.
            /// </summary>
            Timing13,

            /// <summary>
            /// Timing 14.
            /// </summary>
            Timing14,
        }
        #endregion

        #endregion

        #region private memebrs
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem> _timingTable;
        #endregion

        #region constructor/s

        #region [public] StandardTimingIdentifierDescriptor(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data of this block untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="StandardTimingIdentifierDescriptor"/> class with the data of this block untreated.
        /// </summary>
        /// <param name="dataBlock">Unprocessed data in this block</param>
        public StandardTimingIdentifierDescriptor(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (Dictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem>) TimingTable: Gets a value that represents a dictionary of Timings dictionary
        /// <summary>
        /// Gets a value that represents a dictionary of Timings dictionary.
        /// </summary>
        /// <value>
        /// Dictionary containing the pair Timing / Value.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem> TimingTable
        {
            get
            {
                if (_timingTable != null)
                {
                    return _timingTable;
                }

                _timingTable = new Dictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem>();
                PopulatesTimingsTable(_timingTable);
                return _timingTable;
            }
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
            properties.Add(EedidProperty.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing9, Timing(KnownStandardTiming.Timing9));
            properties.Add(EedidProperty.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing10, Timing(KnownStandardTiming.Timing10));
            properties.Add(EedidProperty.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing11, Timing(KnownStandardTiming.Timing11));
            properties.Add(EedidProperty.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing12, Timing(KnownStandardTiming.Timing12));
            properties.Add(EedidProperty.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing13, Timing(KnownStandardTiming.Timing13));
            properties.Add(EedidProperty.Edid.DataBlock.Definition.StandardTimingIdentifier.Timing14, Timing(KnownStandardTiming.Timing14));
        }
        #endregion

        #endregion


        #region EDID 1.4 Specification

        #region [private] (void) PopulatesTimingsTable(IDictionary<KnownStandardTimming, StandardTimingIdentifierDescriptorItem>): Returns a value that represents the timmings dictionary
        /// <summary>
        /// Returns a value that represents the timmings dictionary.
        /// </summary>
        /// <param name="timingDictionary">Timmings dictionary.</param>
        private void PopulatesTimingsTable(IDictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem> timingDictionary)
        {
            byte[] sectionDataArray = RawData.ToArray();
            for (byte n = 0, i = 0x00; i < 0x10; n++, i += 0x02)
            {
                byte[] rawTimming = sectionDataArray.Extract(i, (byte)0x02).ToArray();
                bool unUsedTimming = rawTimming.SequenceEqual(new byte[] { 0x01, 0x01 });
                if (unUsedTimming)
                {
                    continue;
                }

                timingDictionary.Add((KnownStandardTiming)n, new StandardTimingIdentifierDescriptorItem(rawTimming));
            }
        }
        #endregion

        #region [private] (StandardTimingIdentifierDescriptorItem) Timing(KnownStandardTiming): Returns the value that contains the specified key
        /// <summary>
        /// Returns the value that contains the specified key.
        /// </summary>
        /// <param name="timing">Timing to be recovere.</param>
        /// <returns>
        /// Value of the specified timing
        /// </returns>
        private StandardTimingIdentifierDescriptorItem Timing(KnownStandardTiming timing)
        {
            StandardTimingIdentifierDescriptorItem result;

            try
            {
                result = TimingTable[timing];                        
            }
            catch (KeyNotFoundException)
            {
                return null;
            }

            return result;
        }
        #endregion

        #endregion
    }
}
