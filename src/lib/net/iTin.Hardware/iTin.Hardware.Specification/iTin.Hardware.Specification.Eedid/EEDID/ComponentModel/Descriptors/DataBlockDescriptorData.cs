
using System.Collections.Generic;

namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    using iTin.Core;
    using iTin.Core.Hardware.Common;

    /// <summary>
    /// Defines header data block descriptor.
    /// </summary>
    public struct DataBlockDescriptorData :  IEquatable<DataBlockDescriptorData>
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ReadOnlyCollection<byte> _blockData;
        #endregion

        #region constructor/s

        #region [internal] DataBlockDescriptorData(ReadOnlyCollection<byte>): Initialize a new instance of the structure with the data of one of the Data Block Descriptor untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="DataBlockDescriptorData" /> structure with the data of one of the <see cref="KnownEdidSection.DataBlocks" /> Descriptor untreated.
        /// </summary>
        /// <param name="blockData">Raw data of this block</param>
        internal DataBlockDescriptorData(ReadOnlyCollection<byte> blockData)
        {
            _blockData = blockData;
        }
        #endregion

        #endregion

        #region interfaces

        #region public methods

        #region [public] (bool) Equals(DataBlockDescriptorData): Indicates whether the current object is equal to another object of the same type
        /// <inheritdoc />
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">Objeto que se va a comparar con este objeto.</param>
        /// <returns>
        /// Returns <b>true</b> if the current object is equal to the <c>other</c> parameter; otherwise, <b>false</b>.
        /// </returns>
        public bool Equals(DataBlockDescriptorData other) => other.Equals((object)this);
        #endregion

        #endregion

        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(DataBlockDescriptorData, DataBlockDescriptorData): Implements the equality operator (==)
        /// <summary>
        /// Implements the equality operator (==).
        /// </summary>
        /// <param name="headerDataBlockDescriptor1">Operand 1</param>
        /// <param name="headerDataBlockDescriptor2">Operand 2</param>
        /// <returns>
        /// Returns <b>true</b> if <c>headerDataBlockDescriptor1</c> is equal to <c>headerDataBlockDescriptor2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator ==(DataBlockDescriptorData headerDataBlockDescriptor1, DataBlockDescriptorData headerDataBlockDescriptor2) => headerDataBlockDescriptor1.Equals(headerDataBlockDescriptor2);
        #endregion

        #region [public] {static} (bool) operator !=(DataBlockDescriptorData, DataBlockDescriptorData): Implement the inequality operator (!=)
        /// <summary>
        /// Implement the inequality operator (!=).
        /// </summary>
        /// <param name="headerDataBlockDescriptor1">Operand 1</param>
        /// <param name="headerDataBlockDescriptor2">Operand 2</param>
        /// <returns>
        /// Returns <b>true</b> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator !=(DataBlockDescriptorData headerDataBlockDescriptor1, DataBlockDescriptorData headerDataBlockDescriptor2) => !headerDataBlockDescriptor1.Equals(headerDataBlockDescriptor2);
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (EdidDataBlockDescriptor) DescriptorType: Gets a value that represents the type of Data Block
        /// <summary>
        /// Gets a value that represents the type of Data Block.
        /// </summary>
        /// <value>
        /// Type of Data block Descriptor.
        /// </value>
        public EdidDataBlockDescriptor DescriptorType
        {
            get
            {
                int displayDescriptorIndicator = _blockData.GetWord(0x00);
                byte usedAsDisplayDescriptor = _blockData[0x02];
                var tag = (EdidDataBlockDescriptor)_blockData[0x03];
                byte reserved = _blockData[0x04];

                if (displayDescriptorIndicator == 0x0000)
                {
                    if (usedAsDisplayDescriptor == 0x00)
                    {
                        if (tag != EdidDataBlockDescriptor.DisplayRangeLimits)
                        {
                            if (reserved != 0x00)
                            {
                                tag = EdidDataBlockDescriptor.Reserved;
                            }
                        }
                    }
                }
                else
                {
                    tag = EdidDataBlockDescriptor.DetailedTimingMode;
                }    

                return tag;
            }
        }
        #endregion

        #region [public] (ReadOnlyCollection<byte>) RawData: Get the raw data from a block descriptor
        /// <summary>
        /// Get the raw data from a block descriptor
        /// </summary>
        /// <value>
        /// Raw data.
        /// </value>
        public ReadOnlyCollection<byte> RawData
        {
            get
            {
                ReadOnlyCollection<byte> result = _blockData;
                EdidDataBlockDescriptor tag = DescriptorType;

                return result;

                if (tag == EdidDataBlockDescriptor.DetailedTimingMode || tag == EdidDataBlockDescriptor.DisplayRangeLimits)
                {
                    return result;
                }

                var rawDataArray = new byte[0x0d];
                byte[] blockDataArray = _blockData.ToArray();

                Array.Copy(blockDataArray, 0x05, rawDataArray, 0x00, 0x0d);
                result = new ReadOnlyCollection<byte>(rawDataArray);

                return result;
            }
        }
        #endregion

        public IEnumerable<IPropertyKey> ImplementedProperties => Properties.Keys;

        private SectionPropertiesTable Properties => DataBlockDescriptorFactory.GetDataBlockDescription(this).Properties;

        #endregion

        #region public methods

        #region [public] (QueryPropertyResult) GetProperty(IPropertyKey): Returns the value of specified property. Always returns the first appearance of the property
        /// <summary>
        /// Returns the value of specified property. Always returns the first appearance of the property.
        /// </summary>
        /// <param name="propertyKey">Key to the property to obtain</param>
        /// <returns>
        /// <para>
        /// A <see cref="QueryPropertyResult"/> reference that contains the result of the operation, to check if the operation is correct, the <b>Success</b>
        /// property will be <b>true</b> and the <b>Value</b> property will contain the value; Otherwise, the the <b>Success</b> property
        /// will be false and the <b>Errors</b> property will contain the errors associated with the operation, if they have been filled in.
        /// </para>
        /// <para>
        /// The type of the <b>Value</b> property is <see cref="PropertyItem"/>. Contains the result of the operation.
        /// </para>
        /// <para>
        /// </para>
        /// </returns>
        public QueryPropertyResult GetProperty(IPropertyKey propertyKey)
            => !Properties.ContainsKey(propertyKey)
                ? QueryPropertyResult.CreateErroResult("Can not found specified property key")
                : QueryPropertyResult.CreateSuccessResult(((IEnumerable<PropertyItem>)Properties[propertyKey]).FirstOrDefault());
        #endregion

        #region [public] (IPropertyKey) GetDescriptorKeyFromType(EdidDataBlockDescriptorTag): Returns a value that represents the unique key that identifies the specified descriptor
        /// <summary>
        /// Returns a value that represents the unique key that identifies the specified descriptor.
        /// </summary>
        /// <param name="descriptorType">Descriptor type.</param>
        /// <returns>
        /// Unique key that identifies the Data Block.
        /// </returns>
        public IPropertyKey GetDescriptorKeyFromType(EdidDataBlockDescriptor descriptorType)
        {
            var tag = descriptorType;
            var descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.AlphaNumericDataString; 

            switch (tag)
            {
                case EdidDataBlockDescriptor.AlphaNumericDataString:
                    break;

                case EdidDataBlockDescriptor.ColorManagementData:
                    descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.ColorManagementData;
                    break;

                case EdidDataBlockDescriptor.ColorPointData:
                    descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.ColorPointData;
                    break;

                case EdidDataBlockDescriptor.Cvt3ByteCode:
                    descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.CVT3ByteCode;
                    break;

                case EdidDataBlockDescriptor.DetailedTimingMode:
                    descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.DetailedTimingMode;
                    break;

                case EdidDataBlockDescriptor.DisplayProductName:
                    descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.DisplayProductName;
                    break;

                case EdidDataBlockDescriptor.DisplayProductSerialNumber:
                    descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.DisplayProductSerialNumber;
                    break;

                case EdidDataBlockDescriptor.DisplayRangeLimits:
                    descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.DisplayRangeLimits;
                    break;

                case EdidDataBlockDescriptor.DummyData:
                    descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.DummyData;
                    break;

                case EdidDataBlockDescriptor.EstablishedTimingsIII:
                    descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.EstablishedTimingsIII;
                    break;

                case EdidDataBlockDescriptor.ManufacturerSpecifiedData15:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData14:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData13:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData12:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData11:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData10:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData09:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData08:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData07:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData06:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData05:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData04:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData03:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData02:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData01:
                case EdidDataBlockDescriptor.ManufacturerSpecifiedData00:
                    descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.ManufacturerSpecifiedData00;
                    break;

                case EdidDataBlockDescriptor.StandardTimingIdentifier:
                    descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.StandardTimingIdentifier;
                    break;
            }

            return descriptorKey;
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (int) GetHashCode(): Returns the hash code of the object
        /// <summary>
        /// Returns the hash code of the object.
        /// </summary>
        /// <returns>
        /// Hash code.
        /// </returns>
        public override int GetHashCode() => ToString().GetHashCode();
        #endregion

        #region [public] {override} (bool) Equals(object obj): Returns a value that indicates whether this object is equal to another
        /// <summary>
        /// Returns a value that indicates whether this object is equal to another.
        /// </summary>
        /// <param name="obj">Object with which to compare</param>
        /// <returns>
        /// Equality result.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is DataBlockDescriptorData))
            {
                return false;
            }

            var other = (DataBlockDescriptorData)obj;

            return other.DescriptorType.Equals(DescriptorType);
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current class
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents the current class.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the <see cref="DataBlockDescriptorData" /> current class.
        /// </returns>
        public override string ToString() => DescriptorType.ToString();
        #endregion

        #endregion
    }
}
