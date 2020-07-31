
namespace iTin.Core.Hardware.Specification.Eedid
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

        #region [public] DataBlockCollectionCeaSection(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de esta sección sin tratar.
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DataBlockCollectionCeaSection"/> con los datos de esta sección sin tratar.
        /// </summary>
        /// <param name="sectionData">Datos de esta sección sin tratar.</param>
        public DataBlockCollectionCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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
            var shortDataBlocks = GetDataBlockCollection(RawData);
            foreach (var shortDataBlock in shortDataBlocks)
            {
                //var key = shortDataBlock.Tag.ToString();
                //var exist = shortDataBlock.Tag != KnownShortDataBlockTag.ExtendedTag && properties.ContainsKey(key);

                //if (!exist)
                //{
                //    switch (shortDataBlock.Tag)
                //    {
                //        case KnownShortDataBlockTag.Audio:
                //            properties.Add(key, new ShortAudioDescriptorCeaSection(shortDataBlock.RawData).Properties);
                //            break;

                //        case KnownShortDataBlockTag.Video:
                //            properties.Add(key, new ShortVideoDescriptorCeaSection(shortDataBlock.RawData).Properties);
                //            break;

                //        case KnownShortDataBlockTag.Vendor:
                //            properties.Add(key, new ShortVendorDescriptorCeaSection(shortDataBlock.RawData).Properties);
                //            break;

                //        case KnownShortDataBlockTag.Speaker:
                //            properties.Add(key, new ShortSpeakerDescriptorCeaSection(shortDataBlock.RawData).Properties);
                //            break;

                //        case KnownShortDataBlockTag.VESA:
                //            properties.Add(key, new ShortSpeakerDescriptorCeaSection(shortDataBlock.RawData).Properties);
                //            break;

                //        case KnownShortDataBlockTag.ExtendedTag:
                //            properties.Add(key, new ShortExtendedTagDescriptorCeaSection(shortDataBlock.RawData).Properties);
                //            break;

                //        default:
                //            properties.Add(key, new ShortReservedDescriptorCeaSection(shortDataBlock.RawData).Properties);
                //            break;
                //    }
                //}
            }
            #endregion
        }
        #endregion

        #region private static methods

        #region [private] {static} (IEnumerable<CeaDataBlock>) GetDataBlockCollection(ReadOnlyCollection<byte>): Obtiene una colección de estructuras Short Data Block Collection sin procesar de una estructura de tipo Data Block Collection.
        /// <summary>
        /// Obtiene una colección de estructuras Short Data Block Collection sin procesar de una estructura de tipo Data Block Collection.
        /// </summary>
        /// <param name="dataBlocks">Array que contiene la estructura Data Block Collection de este bloque CEA sin procesar.</param>
        /// <returns>Colección de estructuras Short Data Blocks disponibles en la estructura sin procesar.</returns>
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
