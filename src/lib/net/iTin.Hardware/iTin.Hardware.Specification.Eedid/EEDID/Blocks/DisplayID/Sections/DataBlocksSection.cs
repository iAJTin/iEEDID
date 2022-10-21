
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using iTin.Core;

using iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel;

namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections
{
    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="DisplayIdSection.DataBlocks"/> section of this block <see cref="KnownDataBlock.DisplayID"/>.
    /// </summary> 
    internal sealed class DataBlocksSection : BaseDataSection
    {
        #region constructor/s

        #region [public] DataBlocksSection(ReadOnlyCollection<byte>, int? = null): Initializes a new instance of the class with the data from this raw section with version block
        /// <summary>
        /// Initializes a new instance of the class <see cref="BaseDataSection"/> with the raw data of this section with version block.
        /// </summary>
        /// <param name="sectionData">Raw data section.</param>
        /// <param name="version">Block version.</param>
        public DataBlocksSection(ReadOnlyCollection<byte> sectionData, int? version = null) : base(sectionData, version)
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
            properties.Add(EedidProperty.DisplayID.DataBlocks.ImplementedBlocks, GetImplementedDataBlocks());
        }
        #endregion

        #endregion


        #region VESA Display Identification Data (DisplayID)

        private IEnumerable<DataBlockData> GetImplementedDataBlocks()
        {
            byte offset = 0x00;
            byte[] sectionDataArray = RawData.ToArray();
            var data = new Collection<DataBlockData>();
            for (byte i = 0x00; i < sectionDataArray.Length; i += offset)
            {
                byte payLoadBytes = sectionDataArray[i + 0x02];
                if (payLoadBytes == 0x00)
                {
                    break;
                }

                byte[] dataBlockBytes = sectionDataArray.Extract(i, payLoadBytes + 0x03).ToArray();
                var dataBlockData = new ReadOnlyCollection<byte>(dataBlockBytes);
                data.Add(new DataBlockData(dataBlockData, Version));

                i += (byte) (payLoadBytes + 0x03);
            }

            return data;
        }

        #endregion
    }
}
