
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    // EDID Section: 18 Byte Data Blocks Descriptors - 72 Bytes
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                      |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          First 18 Byte Descriptor  18 BYTEs    Descriptor 1.                                    |
    // |                                                    Note: See Descriptor(KnownEdidDataBlockProperty) |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 17h          Second 18 Byte Descriptor 18 BYTEs    Descriptor 2.                                    |
    // |                                                    Note: See Descriptor(KnownEdidDataBlockProperty) |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 23h          Third 18 Byte Descriptor  18 BYTEs    Descriptor 3.                                    |
    // |                                                    Note: See Descriptor(KnownEdidDataBlockProperty) |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 35h          Fourth 18 Byte Descriptor 18 BYTEs    Descriptor 4.                                    |
    // |                                                    Note: See Descriptor(KnownEdidDataBlockProperty) |
    // •—————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> class that represents the <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownEdidSection.DataBlocks" /> section of this block <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.EDID" />.
    /// </summary> 
    sealed class DataBlocksEdidSection : BaseDataSection
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<PropertyKey> _keyList;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<ReadOnlyCollection<byte>> _dataList;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IDictionary<KnownEdidDataBlockProperty, KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>> _descriptorTable;
        #endregion

        #region constructor/s

        #region [public] VendorEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.DataBlocksEdidSection" /> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public DataBlocksEdidSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (IList<ReadOnlyCollection<byte>>) DataList: Gets a value that represents a collection with the untreated information of each descriptor
        /// <summary>
        /// Gets a value that represents a collection with the untreated information of each descriptor.
        /// </summary>
        /// <value>
        /// Untreated information of each descriptor.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<ReadOnlyCollection<byte>> DataList
        {
            get
            {
                if (_dataList != null)
                {
                    return _dataList;
                }

                _dataList = new List<ReadOnlyCollection<byte>>();
                GetDataList(_dataList);

                return _dataList;
            }
        }
        #endregion

        #region [private] (IDictionary<KnownEdidDataBlockProperty, KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>>) DescriptorTable: Gets a value that represents a dictionary of descriptors
        /// <summary>
        /// Gets a value that represents a dictionary of descriptors.
        /// </summary>
        /// <value>
        /// Dictionary containing the Descriptor / Value.
        /// </value>e>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IDictionary<KnownEdidDataBlockProperty, KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>> DescriptorTable
        {
            get
            {
                if (_descriptorTable != null)
                {
                    return _descriptorTable;
                }

                _descriptorTable = new Dictionary<KnownEdidDataBlockProperty, KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>>();
                GetDescriptorTable(_descriptorTable);
                return _descriptorTable;
            }
        }
        #endregion

        #region [private] (IList<PropertyKey>) KeyList: Gets a value that represents a collection with the keys of each descriptor
        /// <summary>
        /// Gets a value that represents a collection with the keys of each descriptor.
        /// </summary>
        /// <value>
        /// Keys of each descriptor.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IList<PropertyKey> KeyList
        {
            get
            {
                if (_keyList != null)
                {
                    return _keyList;
                }

                _keyList = new List<PropertyKey>();
                GetKeyList(_keyList);
                return _keyList;
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
            var propertyId = (KnownEdidDataBlockProperty)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x01] - [Descriptor 1] - [KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>]
                case KnownEdidDataBlockProperty.Descriptor1:
                    value = Descriptor(KnownEdidDataBlockProperty.Descriptor1);
                    break;
                #endregion

                #region [0x02] - [Descriptor 2] - [KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>]
                case KnownEdidDataBlockProperty.Descriptor2:
                    value = Descriptor(KnownEdidDataBlockProperty.Descriptor2);
                    break;
                #endregion

                #region [0x03] - [Descriptor 3] - [KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>]
                case KnownEdidDataBlockProperty.Descriptor3:
                    value = Descriptor(KnownEdidDataBlockProperty.Descriptor3);
                    break;
                #endregion

                #region [0x04] - [Descriptor 4] - [KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>]
                case KnownEdidDataBlockProperty.Descriptor4:
                    value = Descriptor(KnownEdidDataBlockProperty.Descriptor4);
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
            items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor1, Descriptor(KnownEdidDataBlockProperty.Descriptor1));
            items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor2, Descriptor(KnownEdidDataBlockProperty.Descriptor2));
            items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor3, Descriptor(KnownEdidDataBlockProperty.Descriptor3));
            items.Add(KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor4, Descriptor(KnownEdidDataBlockProperty.Descriptor4));
            #endregion
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>) Descriptor(KnownEdidDataBlockProperty): Returns the value that contains the specified key
        /// <summary>
        /// Returns the value that contains the specified key.
        /// </summary>
        /// <param name="descriptor">Descriptor to recover</param>
        /// <returns>
        /// Descriptor value
        /// </returns>
        private KeyValuePair<PropertyKey, ReadOnlyCollection<byte>> Descriptor(KnownEdidDataBlockProperty descriptor) => DescriptorTable[descriptor];
        #endregion

        #region [private] (void) GetDataList(ICollection<ReadOnlyCollection<byte>>): Returns a value that represents a list with the untreated information of each descriptor
        /// <summary>
        /// Returns a value that represents a list with the untreated information of each descriptor.
        /// </summary>
        /// <param name="dataList">Untreated list information of each descriptor</param>
        private void GetDataList(ICollection<ReadOnlyCollection<byte>> dataList)
        {
            var sectionDataArray = RawData.ToArray();

            for (var i = 0x00; i < 0x48; i += 0x12)
            {
                var descriptorArray = new byte[0x12];
                Array.Copy(sectionDataArray, i, descriptorArray, 0x00, 0x12);

                var descriptorCollection = new ReadOnlyCollection<byte>(descriptorArray);
                var headerDataBlockDescriptor = new HeaderDataBlockDescriptor(descriptorCollection);

                var rawData = headerDataBlockDescriptor.RawData;

                dataList.Add(rawData);
            }
        }
        #endregion

        #region [private] (void) GetDescriptorTable(IDictionary<KnownEdidDataBlockProperty, KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>>): Returns a value that represents the dictionary of descriptors
        /// <summary>
        /// Returns a value that represents the dictionary of descriptors.
        /// </summary>
        /// <param name="descriptorDictionary">Dictionary descriptors</param>
        private void GetDescriptorTable(IDictionary<KnownEdidDataBlockProperty, KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>> descriptorDictionary)
        {
            var keyList = KeyList;
            var dataList = DataList;

            for (var i = 0; i <= keyList.Count - 1; i++)
            {
                descriptorDictionary.Add((KnownEdidDataBlockProperty)i, new KeyValuePair<PropertyKey, ReadOnlyCollection<byte>>(keyList[i], dataList[i]));
            }
        }
        #endregion

        #region [private] (void) GetKeyList(ICollection<PropertyKey>): Populates key list
        /// <summary>
        /// Populates key list.
        /// </summary>
        /// <param name="keyList">Key list</param>
        private void GetKeyList(ICollection<PropertyKey> keyList)
        {
            var sectionDataArray = RawData.ToArray();

            for (var i = 0x00; i < 0x48; i += 0x12)
            {
                var descriptorArray = new byte[0x12];
                Array.Copy(sectionDataArray, i, descriptorArray, 0x00, 0x12);

                var descriptorCollection = new ReadOnlyCollection<byte>(descriptorArray);
                var headerDataBlockDescriptor = new HeaderDataBlockDescriptor(descriptorCollection);
                var dataBlockTag = headerDataBlockDescriptor.DescriptorType;
                var descriptorKey = headerDataBlockDescriptor.GetDescriptorKeyFromType(dataBlockTag);

                keyList.Add(descriptorKey);
            }
        }
        #endregion

        #endregion
    }
}
