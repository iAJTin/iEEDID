
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    // CEA Section: Data Block Collection Information
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="KnownCeaSection.DataBlockCollection"/> section of this block <see cref="KnownDataBlock.CEA"/>.
    /// </summary> 
    internal sealed class DataBlockCollectionCeaSection : BaseDataSection
    {
        #region constructor/s

        #region [public] DataBlockCollectionCeaSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="DataBlockCollectionCeaSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public DataBlockCollectionCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
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
            var shortDataBlocks = GetDataBlockCollection(RawData);
            foreach (var shortDataBlock in shortDataBlocks)
            {
                var key = shortDataBlock.Tag.ToString();
                var exist = shortDataBlock.Tag != KnownShortDataBlockTag.ExtendedTag; // && properties.ContainsKey(key);

                if (exist)
                {
                    var propertiesToAdd = new SectionPropertiesTable();
                    switch (shortDataBlock.Tag)
                    {
                        case KnownShortDataBlockTag.Audio:
                            var descriptor = new ShortAudioDescriptorCeaSection(shortDataBlock.RawData);
                            var hasProperties = descriptor.Properties.Any();
                            if (hasProperties)
                            {
                                propertiesToAdd.Add(EedidProperty.Cea.DataBlock.Tags.Audio, descriptor.Properties.FirstOrDefault().Value);
                            }
                            break;

                        case KnownShortDataBlockTag.Video:
                            propertiesToAdd.Add(EedidProperty.Cea.DataBlock.Tags.Video, new ShortVideoDescriptorCeaSection(shortDataBlock.RawData).Properties);
                            break;

                        case KnownShortDataBlockTag.Vendor:
                            propertiesToAdd.Add(EedidProperty.Cea.DataBlock.Tags.Vendor, new ShortVendorDescriptorCeaSection(shortDataBlock.RawData).Properties);
                            break;

                        case KnownShortDataBlockTag.Speaker:
                            propertiesToAdd.Add(EedidProperty.Cea.DataBlock.Tags.Speaker, new ShortSpeakerDescriptorCeaSection(shortDataBlock.RawData).Properties);
                            break;

                        case KnownShortDataBlockTag.VESA:
                            propertiesToAdd.Add(EedidProperty.Cea.DataBlock.Tags.VESA, new ShortSpeakerDescriptorCeaSection(shortDataBlock.RawData).Properties);
                            break;

                        case KnownShortDataBlockTag.ExtendedTag:
                            propertiesToAdd.Add(EedidProperty.Cea.DataBlock.Tags.Extended, new ShortExtendedTagDescriptorCeaSection(shortDataBlock.RawData).Properties);
                            break;

                        default:
                            propertiesToAdd.Add(EedidProperty.Cea.DataBlock.Tags.Reserved, new ShortReservedDescriptorCeaSection(shortDataBlock.RawData).Properties);
                            break;
                    }

                    foreach (var property in propertiesToAdd)
                    {
                        properties.Add(property);
                    }
                }
            }
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (IEnumerable<CeaDataBlock>) GetDataBlockCollection(ReadOnlyCollection<byte>): Gets a collection of raw Short Data Block Collection structures from a structure of type Data Block Collection
        /// <summary>
        /// Gets a collection of raw Short Data Block Collection structures from a structure of type Data Block Collection.
        /// </summary>
        /// <param name="dataBlocks">Array containing the Data Block Collection structure of this raw CEA block.</param>
        /// <returns>
        /// Collection of Short Data Blocks structures available in the raw structure.
        /// </returns>
        private static IEnumerable<CeaDataBlock> GetDataBlockCollection(ReadOnlyCollection<byte> dataBlocks)
        {
            var dataBlocksArray = dataBlocks.ToArray();
            var dataBlocksCollection = new List<CeaDataBlock>();
            for (int i = 0; i < dataBlocks.Count; i += 1 + (dataBlocks[i] & 0x1f))
            {
                var dataBlockArray = new byte[1 + (dataBlocks[i] & 0x1f)];

                Array.Copy(dataBlocksArray, i, dataBlockArray, 0x00, 1 + (dataBlocks[i] & 0x1f));
                dataBlocksCollection.Add(new CeaDataBlock(new ReadOnlyCollection<byte>(dataBlockArray)));
            }

            return dataBlocksCollection;
        }
        #endregion

        #endregion
    }
}
