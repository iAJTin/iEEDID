
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    /// Defines header data block descriptor.
    /// </summary>
    struct HeaderDataBlockDescriptor :  IEquatable<HeaderDataBlockDescriptor>
    {
        #region private readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ReadOnlyCollection<byte> _blockData;
        #endregion

        #region constructor/s

        #region [internal] HeaderDataBlockDescriptor(ReadOnlyCollection<byte>): Initialize a new instance of the structure with the data of one of the Data Block Descriptor untreated
        /// <summary>
        /// Initialize a new instance of the <see cref="HeaderDataBlockDescriptor" /> structure with the data of one of the <see cref="KnownEdidSection.DataBlocks" /> Descriptor untreated.
        /// </summary>
        /// <param name="blockData">Raw data of this block</param>
        internal HeaderDataBlockDescriptor(ReadOnlyCollection<byte> blockData)
        {
            _blockData = blockData;
        }
        #endregion

        #endregion

        #region interfaces

        #region public methods

        #region [public] (bool) Equals(HeaderDataBlockDescriptor): Indicates whether the current object is equal to another object of the same type
        /// <inheritdoc />
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">Objeto que se va a comparar con este objeto.</param>
        /// <returns>
        /// Returns <b>true</b> if the current object is equal to the <c>other</c> parameter; otherwise, <b>false</b>.
        /// </returns>
        public bool Equals(HeaderDataBlockDescriptor other) => other.Equals((object)this);
        #endregion

        #endregion

        #endregion

        #region public operators

        #region [public] {static} (bool) operator ==(HeaderDataBlockDescriptor, HeaderDataBlockDescriptor): Implements the equality operator (==)
        /// <summary>
        /// Implements the equality operator (==).
        /// </summary>
        /// <param name="headerDataBlockDescriptor1">Operand 1</param>
        /// <param name="headerDataBlockDescriptor2">Operand 2</param>
        /// <returns>
        /// Returns <b>true</b> if <c>headerDataBlockDescriptor1</c> is equal to <c>headerDataBlockDescriptor2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator ==(HeaderDataBlockDescriptor headerDataBlockDescriptor1, HeaderDataBlockDescriptor headerDataBlockDescriptor2) => headerDataBlockDescriptor1.Equals(headerDataBlockDescriptor2);
        #endregion

        #region [public] {static} (bool) operator !=(HeaderDataBlockDescriptor, HeaderDataBlockDescriptor): Implement the inequality operator (!=)
        /// <summary>
        /// Implement the inequality operator (!=).
        /// </summary>
        /// <param name="headerDataBlockDescriptor1">Operand 1</param>
        /// <param name="headerDataBlockDescriptor2">Operand 2</param>
        /// <returns>
        /// Returns <b>true</b> if <c>deviceInfo1</c> is not equal to <c>deviceInfo2</c>; <b>false</b> otherwise.
        /// </returns>
        public static bool operator !=(HeaderDataBlockDescriptor headerDataBlockDescriptor1, HeaderDataBlockDescriptor headerDataBlockDescriptor2) => !headerDataBlockDescriptor1.Equals(headerDataBlockDescriptor2);
        #endregion

        #endregion

        #region public properties

        #region [public] (KnownEdidDataBlockDescriptor) DescriptorType: Obtiene un valor que representa el tipo de Data Block.
        /// <summary>
        /// Obtiene un valor que representa el tipo de Data Block.
        /// </summary>
        /// <value>
        /// Tipo de Data block Descriptor.
        /// </value>
        public KnownEdidDataBlockDescriptor DescriptorType
        {
            get
            {
                int displayDescriptorIndicator = _blockData.GetWord(0x00);
                byte usedAsDisplayDescriptor = _blockData[0x02];
                var tag = (KnownEdidDataBlockDescriptor)_blockData[0x03];
                byte reserved = _blockData[0x04];

                if (displayDescriptorIndicator == 0x0000)
                {
                    if (usedAsDisplayDescriptor == 0x00)
                    {
                        if (tag != KnownEdidDataBlockDescriptor.DisplayRangeLimits)
                        {
                            if (reserved != 0x00)
                            {
                                tag = KnownEdidDataBlockDescriptor.Reserved;
                            }
                        }
                    }
                }
                else
                {
                    tag = KnownEdidDataBlockDescriptor.DetailedTimingMode;
                }    

                return tag;
            }
        }
        #endregion

        #region [public] (ReadOnlyCollection<byte>) RawData: Obtiene un valor que representa el tipo de Data Block.
        /// <summary>
        /// Obtiene un valor que representa el tipo de Data Block.
        /// </summary>
        /// <value>
        /// Tipo de Data block Descriptor.
        /// </value>
        public ReadOnlyCollection<byte> RawData
        {
            get
            {
                ReadOnlyCollection<byte> result = _blockData;
                KnownEdidDataBlockDescriptor tag = DescriptorType;

                if (tag == KnownEdidDataBlockDescriptor.DetailedTimingMode || tag == KnownEdidDataBlockDescriptor.DisplayRangeLimits)
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

        #endregion

        #region public methods

        #region [public] (PropertyKey) GetDescriptorKeyFromType(KnownEdidDataBlockDescriptorTag): Returns a value that represents the unique key that identifies the specified descriptor
        /// <summary>
        /// Returns a value that represents the unique key that identifies the specified descriptor.
        /// </summary>
        /// <param name="descriptorType">Descriptor type.</param>
        /// <returns>
        /// Unique key that identifies the Data Block.
        /// </returns>
        public PropertyKey GetDescriptorKeyFromType(KnownEdidDataBlockDescriptor descriptorType)
        {
            var tag = descriptorType;
            var descriptorKey = KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.AlphaNumericDataString; 

            switch (tag)
            {
                case KnownEdidDataBlockDescriptor.AlphaNumericDataString:
                    break;

                case KnownEdidDataBlockDescriptor.ColorManagementData:
                    descriptorKey = KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.ColorManagementData;
                    break;

                case KnownEdidDataBlockDescriptor.ColorPointData:
                    descriptorKey = KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.ColorPointData;
                    break;

                case KnownEdidDataBlockDescriptor.Cvt3ByteCode:
                    descriptorKey = KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.CVT3ByteCode;
                    break;

                case KnownEdidDataBlockDescriptor.DetailedTimingMode:
                    descriptorKey = KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DetailedTimingMode;
                    break;

                case KnownEdidDataBlockDescriptor.DisplayProductName:
                    descriptorKey = KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DisplayProductName;
                    break;

                case KnownEdidDataBlockDescriptor.DisplayProductSerialNumber:
                    descriptorKey = KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DisplayProductSerialNumber;
                    break;

                case KnownEdidDataBlockDescriptor.DisplayRangeLimits:
                    descriptorKey = KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DisplayRangeLimits;
                    break;

                case KnownEdidDataBlockDescriptor.DummyData:
                    descriptorKey = KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.DummyData;
                    break;

                case KnownEdidDataBlockDescriptor.EstablishedTimingsIII:
                    descriptorKey = KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.EstablishedTimingsIII;
                    break;

                case KnownEdidDataBlockDescriptor.ManufacturerSpecifiedData:
                    descriptorKey = KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.ManufacturerSpecifiedData;
                    break;

                case KnownEdidDataBlockDescriptor.StandardTimingIdentifier:
                    descriptorKey = KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor.StandardTimingIdentifier;
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

            if (!(obj is HeaderDataBlockDescriptor))
            {
                return false;
            }

            var other = (HeaderDataBlockDescriptor)obj;

            return other.DescriptorType == DescriptorType;
        }
        #endregion

        #region [public] {override} (string) ToString(): Returns a string that represents the current class
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents the current class.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the <see cref="HeaderDataBlockDescriptor" /> current class.
        /// </returns>
        public override string ToString() => DescriptorType.ToString();
        #endregion

        #endregion
    }
}
