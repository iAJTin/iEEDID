
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    // CEA Section: Data Block Collection Information
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
  
    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> que representa la sección <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownCeaSection.DataBlockCollection" /> de este bloque <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.CEA" />.
    /// </summary> 
    sealed class DataBlockCollectionCeaSection : BaseDataSection
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

        #region [protected] {override} (void) Parse(Hashtable): Obtiene la colección de items de esta sección.
        /// <summary>
        /// Obtiene la colección de items de esta sección.
        /// </summary>
        /// <param name="items">Colección de items de esta sección.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        protected override void Parse(Hashtable items)
        {
            #region Comprobar parámetro/s.
            base.Parse(items);
            #endregion

            #region Diccionario de propiedades (PropertyKey / Value).
            var shortDataBlocks = GetDataBlockCollection(RawData);
            foreach (var shortDataBlock in shortDataBlocks)
            {
                var key = shortDataBlock.Tag.ToString();
                var exist = shortDataBlock.Tag != KnownShortDataBlockTag.ExtendedTag && items.ContainsKey(key);

                if (!exist)
                {
                    switch (shortDataBlock.Tag)
                    {
                        case KnownShortDataBlockTag.Audio:
                            items.Add(key, new ShortAudioDescriptorCeaSection(shortDataBlock.RawData).Items);
                            break;

                        case KnownShortDataBlockTag.Video:
                            items.Add(key, new ShortVideoDescriptorCeaSection(shortDataBlock.RawData).Items);
                            break;

                        case KnownShortDataBlockTag.Vendor:
                            items.Add(key, new ShortVendorDescriptorCeaSection(shortDataBlock.RawData).Items);
                            break;

                        case KnownShortDataBlockTag.Speaker:
                            items.Add(key, new ShortSpeakerDescriptorCeaSection(shortDataBlock.RawData).Items);
                            break;

                        case KnownShortDataBlockTag.VESA:
                            items.Add(key, new ShortSpeakerDescriptorCeaSection(shortDataBlock.RawData).Items);
                            break;

                        case KnownShortDataBlockTag.ExtendedTag:
                            items.Add(key, new ShortExtendedTagDescriptorCeaSection(shortDataBlock.RawData).Items);
                            break;

                        default:
                            items.Add(key, new ShortReservedDescriptorCeaSection(shortDataBlock.RawData).Items);
                            break;
                    }
                }
            }
            #endregion
        }
        #endregion

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
