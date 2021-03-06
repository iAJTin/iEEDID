﻿
namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    
    using iTin.Core.Hardware.Common;

    /// <summary>
    /// Defines header data block descriptor.
    /// </summary>
    public struct DataBlockData : IEquatable<DataBlockData>
    {
        #region private readonly members

        #endregion

        #region constructor/s

        #region [internal] DataBlockData(ReadOnlyCollection<byte>, int? = null): Initialize a new instance of the structure with the data of one of the data block untreated with version block
        /// <summary>
        /// Initialize a new instance of the <see cref="DataBlockData" /> structure with the data of one of the <see cref="DisplayIdSection.DataBlocks"/> untreated with version block.
        /// </summary>
        /// <param name="blockData">Raw data of this block</param>
        /// <param name="version">Block version.</param>
        internal DataBlockData(ReadOnlyCollection<byte> blockData, int? version = null)
        {
            RawData = blockData;
            StructureVersion = version;
        }
        #endregion

        #endregion

        #region interfaces

        #region public methods

        #region [public] (bool) Equals(DataBlockData): Indicates whether the current object is equal to another object of the same type
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">Objeto que se va a comparar con este objeto.</param>
        /// <returns>
        /// Returns <b>true</b> if the current object is equal to the <c>other</c> parameter; otherwise, <b>false</b>.
        /// </returns>
        public bool Equals(DataBlockData other) => other.Equals((object)this);
        #endregion

        #endregion

        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(DataBlockData, DataBlockData): Implements the equality operator (==)
        /// <summary>
        /// Implements the equality operator (==).
        /// </summary>
        /// <param name="left">Operand 1</param>
        /// <param name="right">Operand 2</param>
        /// <returns>
        /// Returns <b>true</b> if <c>left</c> is equal to <c>right</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator ==(DataBlockData left, DataBlockData right) => left.Equals(right);
        #endregion

        #region [public] {static} (bool) operator !=(DataBlockData, DataBlockData): Implement the inequality operator (!=)
        /// <summary>
        /// Implement the inequality operator (!=).
        /// </summary>
        /// <param name="left">Operand 1</param>
        /// <param name="right">Operand 2</param>
        /// <returns>
        /// Returns <b>true</b> if <c>left</c> is not equal to <c>right</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator !=(DataBlockData left, DataBlockData right) => !left.Equals(right);
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (byte) BlockRevision: Gets a value that represents block revision
        /// <summary>
        /// Gets a value that represents block revision.
        /// </summary>
        /// <value>
        /// Block revision.
        /// </value>
        public byte BlockRevision => (byte)(RawData[1] & 0x07);
        #endregion

        #region [public] (DataBlockTag) BlockTag: Gets a value that represents the type of data block
        /// <summary>
        /// Gets a value that represents the type of data block.
        /// </summary>
        /// <value>
        /// Type of data block.
        /// </value>
        public DataBlockTag BlockTag => (DataBlockTag) RawData[0];
        #endregion

        #region [public] (IEnumerable<IPropertyKey>) ImplementedProperties: Gets a value containing the implemented properties for this data block
        /// <summary>
        /// Gets a value containing the implemented properties for this data block.
        /// </summary>
        /// <value>
        /// A property collection.
        /// </value>
        public IEnumerable<IPropertyKey> ImplementedProperties => Properties.Keys;
        #endregion

        #region [public] (ReadOnlyCollection<byte>) RawData: Get the raw data from a data block
        /// <summary>
        /// Get the raw data from a data block.
        /// </summary>
        /// <value>
        /// Raw data.
        /// </value>
        public ReadOnlyCollection<byte> RawData { get; }
        #endregion

        #region [public] (int?) StructureVersion: Gets a value that represents the structure version
        /// <summary>
        /// Gets a value that represents the structure version.
        /// </summary>
        /// <value>
        /// The structure version.
        /// </value>
        public int? StructureVersion { get; }
        #endregion

        #endregion

        #region private readonly properties

        private SectionPropertiesTable Properties => DataBlockFactory.GetDataBlockData(this).Properties;

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

        //#region [public] (IPropertyKey) GetDescriptorKeyFromType(EdidDataBlockDescriptorTag): Returns a value that represents the unique key that identifies the specified descriptor
        ///// <summary>
        ///// Returns a value that represents the unique key that identifies the specified descriptor.
        ///// </summary>
        ///// <param name="descriptorType">Descriptor type.</param>
        ///// <returns>
        ///// Unique key that identifies the Data Block.
        ///// </returns>
        //public IPropertyKey GetDescriptorKeyFromType(EdidDataBlockDescriptor descriptorType)
        //{
        //    var tag = descriptorType;
        //    var descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.AlphaNumericDataString;

        //    switch (tag)
        //    {
        //        case EdidDataBlockDescriptor.AlphaNumericDataString:
        //            break;

        //        case EdidDataBlockDescriptor.ColorManagementData:
        //            descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.ColorManagementData;
        //            break;

        //        case EdidDataBlockDescriptor.ColorPointData:
        //            descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.ColorPointData;
        //            break;

        //        case EdidDataBlockDescriptor.Cvt3ByteCode:
        //            descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.CVT3ByteCode;
        //            break;

        //        case EdidDataBlockDescriptor.DetailedTimingMode:
        //            descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.DetailedTimingMode;
        //            break;

        //        case EdidDataBlockDescriptor.DisplayProductName:
        //            descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.DisplayProductName;
        //            break;

        //        case EdidDataBlockDescriptor.DisplayProductSerialNumber:
        //            descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.DisplayProductSerialNumber;
        //            break;

        //        case EdidDataBlockDescriptor.DisplayRangeLimits:
        //            descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.DisplayRangeLimits;
        //            break;

        //        case EdidDataBlockDescriptor.DummyData:
        //            descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.DummyData;
        //            break;

        //        case EdidDataBlockDescriptor.EstablishedTimingsIII:
        //            descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.EstablishedTimingsIII;
        //            break;

        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData15:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData14:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData13:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData12:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData11:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData10:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData09:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData08:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData07:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData06:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData05:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData04:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData03:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData02:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData01:
        //        case EdidDataBlockDescriptor.ManufacturerSpecifiedData00:
        //            descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.ManufacturerSpecifiedData00;
        //            break;

        //        case EdidDataBlockDescriptor.StandardTimingIdentifier:
        //            descriptorKey = EedidProperty.Edid.DataBlock.Descriptor.StandardTimingIdentifier;
        //            break;
        //    }

        //    return descriptorKey;
        //}
        //#endregion

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

            if (!(obj is DataBlockData))
            {
                return false;
            }

            var other = (DataBlockData)obj;

            return other.BlockTag.Equals(BlockTag);
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current class
        /// <summary>
        /// Returns a <see cref="string"/> that represents the current class.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> that represents the <see cref="DataBlockData"/> current class.
        /// </returns>
        public override string ToString() => $"{BlockTag} Rev. {BlockRevision}";
        #endregion

        #endregion
    }
}
