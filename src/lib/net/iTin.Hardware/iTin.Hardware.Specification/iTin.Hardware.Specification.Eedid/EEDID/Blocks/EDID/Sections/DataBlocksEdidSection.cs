
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    using iTin.Core;
    using iTin.Core.Hardware.Common;

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

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="KnownEdidSection.DataBlocks"/> section of this block <see cref="KnownDataBlock.EDID"/>.
    /// </summary> 
    internal sealed class DataBlocksEdidSection : BaseDataSection
    {
        #region constructor/s

        #region [public] DataBlocksEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="DataBlocksEdidSection"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public DataBlocksEdidSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
            IEnumerable<DataBlockDescriptorData> descriptors = DataBlockDescriptorsData();
            foreach (var descriptor in descriptors)
            {
                EdidDataBlockDescriptor tag = descriptor.DescriptorType;
                IPropertyKey descriptorKey = descriptor.GetDescriptorKeyFromType(tag);
                BaseDataSection dataBlockDescription = DataBlockDescriptorFactory.GetDataBlockDescription(descriptor);
                properties.Add(descriptorKey, dataBlockDescription.Properties);
            }
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (IEnumerable<DataBlockDescriptorData>) DataBlockDescriptorKeys(): Returns an implemented datablock related data
        /// <summary>
        /// Returns an implemented datablock related datat.
        /// </summary>
        /// <returns>
        /// Collection of datablock related data.
        /// </returns>
        private IEnumerable<DataBlockDescriptorData> DataBlockDescriptorsData()
        {
            byte[] sectionDataArray = RawData.ToArray();

            var data = new Collection<DataBlockDescriptorData>();
            for (byte i = 0x00; i < 0x48; i += 0x12)
            {
                byte[] descriptor = sectionDataArray.Extract(i, (byte)0x12).ToArray();
                var readonlyDescriptor = new ReadOnlyCollection<byte>(descriptor);
                data.Add(new DataBlockDescriptorData(readonlyDescriptor));
            }

            return data;
        }
        #endregion

        #endregion
    }
}
