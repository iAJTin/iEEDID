
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections;

// CEA Section: Data Block Collection Information
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•
// | Offset       Name                      Length      Description                                         |
// •————————————————————————————————————————————————————————————————————————————————————————————————————————•

/// <summary>
/// Specialization of the <see cref="BaseDataSection"/> class.<br/>
/// Represents the <see cref="CeaSection.DataBlockCollection"/> section of this block <see cref="KnownDataBlock.CEA"/>.
/// </summary> 
internal sealed class DataBlockCollectionSection : BaseDataSection
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="DataBlockCollectionSection"/> class with the data from this raw section.
    /// </summary>
    /// <param name="sectionData">Data from this section untreated.</param>
    public DataBlockCollectionSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
    {
    }

    #endregion

    #region protected override methods

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

            var exist = shortDataBlock.Tag != ShortDataBlockTag.ExtendedTag; // && properties.ContainsKey(key);
            if (!exist)
            {
                continue;
            }

            var propertiesToAdd = new SectionPropertiesTable();
            switch (shortDataBlock.Tag)
            {
                case ShortDataBlockTag.Audio:
                    var descriptor = new ShortAudioDescriptorSection(shortDataBlock.RawData);
                    var hasProperties = descriptor.Properties.Any();
                    if (hasProperties)
                    {
                        propertiesToAdd.Add(EedidProperty.Cea.DataBlock.Tags.Audio, descriptor.Properties.FirstOrDefault()?.Value);
                    }
                    break;

                case ShortDataBlockTag.Video:
                    propertiesToAdd.Add(EedidProperty.Cea.DataBlock.Tags.Video, new ShortVideoDescriptorSection(shortDataBlock.RawData).Properties);
                    break;

                case ShortDataBlockTag.Vendor:
                    propertiesToAdd.Add(EedidProperty.Cea.DataBlock.Tags.Vendor, new ShortVendorDescriptorSection(shortDataBlock.RawData).Properties);
                    break;

                case ShortDataBlockTag.Speaker:
                    propertiesToAdd.Add(EedidProperty.Cea.DataBlock.Tags.Speaker, new ShortSpeakerDescriptorSection(shortDataBlock.RawData).Properties);
                    break;

                case ShortDataBlockTag.VESA:
                    propertiesToAdd.Add(EedidProperty.Cea.DataBlock.Tags.VESA, new ShortSpeakerDescriptorSection(shortDataBlock.RawData).Properties);
                    break;

                case ShortDataBlockTag.ExtendedTag:
                    propertiesToAdd.Add(EedidProperty.Cea.DataBlock.Tags.Extended, new ShortExtendedTagDescriptorSection(shortDataBlock.RawData).Properties);
                    break;

                default:
                    propertiesToAdd.Add(EedidProperty.Cea.DataBlock.Tags.Reserved, new ShortReservedDescriptorSection(shortDataBlock.RawData).Properties);
                    break;
            }

            foreach (var property in propertiesToAdd)
            {
                properties.Add(property);
            }
        }
    }

    #endregion

    #region private static methods

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
        for (var i = 0; i < dataBlocks.Count; i += 1 + (dataBlocks[i] & 0x1f))
        {
            var dataBlockArray = new byte[1 + (dataBlocks[i] & 0x1f)];

            Array.Copy(dataBlocksArray, i, dataBlockArray, 0x00, 1 + (dataBlocks[i] & 0x1f));
            dataBlocksCollection.Add(new CeaDataBlock(new ReadOnlyCollection<byte>(dataBlockArray)));
        }

        return dataBlocksCollection;
    }

    #endregion
}
