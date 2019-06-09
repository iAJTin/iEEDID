
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    using Helpers;

    // EDID Section: Standard Timings 16 Bytes
    // •————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                             |
    // •————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Standard Timing 1         WORD        Note:  See Timing(KnownStandardTiming)  |
    // •————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Standard Timing 2         WORD        Note:  See Timing(KnownStandardTiming)  |
    // •————————————————————————————————————————————————————————————————————————————————————————————•
    // | 04h          Standard Timing 3         WORD        Note:  See Timing(KnownStandardTiming)  |
    // •————————————————————————————————————————————————————————————————————————————————————————————•
    // | 06h          Standard Timing 4         WORD        Note:  See Timing(KnownStandardTiming)  |
    // •————————————————————————————————————————————————————————————————————————————————————————————•
    // | 08h          Standard Timing 5         WORD        Note:  See Timing(KnownStandardTiming)  |
    // •————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0ah          Standard Timing 6         WORD        Note:  See Timing(KnownStandardTiming)  |
    // •————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0ch          Standard Timing 7         WORD        Note:  See Timing(KnownStandardTiming)  |
    // •————————————————————————————————————————————————————————————————————————————————————————————•
    // | 0eh          Standard Timing 8         WORD        Note:  See Timing(KnownStandardTiming)  |
    // •————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> class that represents the <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownEdidSection.StandardTimings" /> section of this block <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.EDID" />.
    /// </summary> 
    sealed class StandardTimingsEdidSection : BaseDataSection
    {
        #region private enumerations

        #region [private] (enum) KnownStandardTiming: Known timings for this block
        /// <summary>
        /// Known timings for this block.
        /// </summary> 
        enum KnownStandardTiming
        {
            /// <summary>
            /// Timing 1.
            /// </summary>
            Timing1,

            /// <summary>
            /// Timing 2.
            /// </summary>
            Timing2,

            /// <summary>
            /// Timing 3.
            /// </summary>
            Timing3,

            /// <summary>
            /// Timing 4.
            /// </summary>
            Timing4,

            /// <summary>
            /// Timing 5.
            /// </summary>
            Timing5,

            /// <summary>
            /// Timing 6.
            /// </summary>
            Timing6,

            /// <summary>
            /// Timing 7.
            /// </summary>
            Timing7,

            /// <summary>
            /// Timing 8.
            /// </summary>
            Timing8,
        }
        #endregion

        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem> _timingTable;
        #endregion

        #region constructor/s

        #region [public] StandardTimingsEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.StandardTimingsEdidSection" /> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public StandardTimingsEdidSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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
                GetTimingsTable(_timingTable);
                return _timingTable;
            }
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Returns a value that represents the value of the specified property
        /// <inheritdoc />
        /// <summary>
        /// Returns a value that represents the value of the specified property.
        /// </summary>
        /// <param name="propertyKey">Property key to be obtained.</param>
        /// <returns>
        /// Property value.
        /// </returns>
        protected override object GetValueTypedProperty(PropertyKey propertyKey)
        {
            object value = null;
            var propertyId = (KnownEdidStandardTimingProperty)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x00] - [Timing 1] - [byte]
                case KnownEdidStandardTimingProperty.Timing1:
                    value = Timing(KnownStandardTiming.Timing1);
                    break;
                #endregion

                #region [0x01] - [Timing 2] - [byte]
                case KnownEdidStandardTimingProperty.Timing2:
                    value = Timing(KnownStandardTiming.Timing2);
                    break;
                #endregion

                #region [0x02] - [Timing 3] - [byte]
                case KnownEdidStandardTimingProperty.Timing3:
                    value = Timing(KnownStandardTiming.Timing3);
                    break;
                #endregion

                #region [0x03] - [Timing 4] - [byte]
                case KnownEdidStandardTimingProperty.Timing4:
                    value = Timing(KnownStandardTiming.Timing4);
                    break;
                #endregion

                #region [0x04] - [Timing 5] - [byte]
                case KnownEdidStandardTimingProperty.Timing5:
                    value = Timing(KnownStandardTiming.Timing5);
                    break;
                #endregion

                #region [0x05] - [Timing 6] - [byte]
                case KnownEdidStandardTimingProperty.Timing6:
                    value = Timing(KnownStandardTiming.Timing6);
                    break;
                #endregion

                #region [0x06] - [Timing 7] - [byte]
                case KnownEdidStandardTimingProperty.Timing7:
                    value = Timing(KnownStandardTiming.Timing7);
                    break;
                #endregion

                #region [0x07] - [Timing 8] - [byte]
                case KnownEdidStandardTimingProperty.Timing8:
                    value = Timing(KnownStandardTiming.Timing8);
                    break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(Hashtable): Populates the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="items">Collection of properties of this structure</param>
        protected override void Parse(Hashtable items)
        {
            #region validate parameter/s
            base.Parse(items);
            #endregion

            #region items
            items.Add(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing1, Timing(KnownStandardTiming.Timing1));
            items.Add(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing2, Timing(KnownStandardTiming.Timing2));
            items.Add(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing3, Timing(KnownStandardTiming.Timing3));
            items.Add(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing4, Timing(KnownStandardTiming.Timing4));
            items.Add(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing5, Timing(KnownStandardTiming.Timing5));
            items.Add(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing6, Timing(KnownStandardTiming.Timing6));
            items.Add(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing7, Timing(KnownStandardTiming.Timing7));
            items.Add(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing8, Timing(KnownStandardTiming.Timing8));
            #endregion
        }
        #endregion

        #endregion


        #region EDID 1.4 Specification

        #region [private] (void) GetTimingsTable(IDictionary<KnownStandardTimming, StandardTimingIdentifierDescriptorItem>): Returns a value that represents the timmings dictionary
        /// <summary>
        /// Returns a value that represents the timmings dictionary.
        /// </summary>
        /// <param name="timingDictionary">Timmings dictionary.</param>
        private void GetTimingsTable(IDictionary<KnownStandardTiming, StandardTimingIdentifierDescriptorItem> timingDictionary)
        {
            var sectionDataArray = RawData.ToArray();

            for (int n = 0, i = 0x00; i < 0x0a; i += 0x02)
            {
                if (LogicHelper.Word(RawData[i + 1], RawData[i]) > 0x0101)
                {
                    var timingArray = new byte[0x02];
                    Array.Copy(sectionDataArray, i, timingArray, 0x00, 0x02);

                    var timing = new StandardTimingIdentifierDescriptorItem(timingArray);
                    timingDictionary.Add((KnownStandardTiming)n, timing);
                    n++;
                }
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
