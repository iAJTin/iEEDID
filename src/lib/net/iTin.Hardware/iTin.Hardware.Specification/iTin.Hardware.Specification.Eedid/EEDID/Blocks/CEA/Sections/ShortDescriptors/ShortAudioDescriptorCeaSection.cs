
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the Short Audio Descriptor section of the Data Block Collection block.
    /// </summary> 
    sealed class ShortAudioDescriptorCeaSection : BaseDataSection
    {
        #region constructor/s

        #region [public] ShortAudioDescriptorCeaSection(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase.
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="ShortAudioDescriptorCeaSection"/>.
        /// </summary>
        /// <param name="sectionData">Datos de esta sección.</param>
        public ShortAudioDescriptorCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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
            var audioAllocationDataBlock = GetAudioAllocationDataBlocks(RawData);

            var i = 0;
            foreach (var allocationDataBlock in audioAllocationDataBlock)
            {
                //properties.Add("Descriptor " + i, allocationDataBlock.Properties);
                i++;
            }
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (IEnumerable<AudioAllocationDataBlock>) GetAudioAllocationDataBlocks(ReadOnlyCollection<byte>): Obtener la colección de estructuras de audio de este bloque.
        private static IEnumerable<AudioDataBlock> GetAudioAllocationDataBlocks(ReadOnlyCollection<byte> audioDataBlock)
        {
            var audioDataBlockArray = new byte[audioDataBlock.Count];
            audioDataBlock.CopyTo(audioDataBlockArray, 0);

            var audioAllocationDataBlocks = new List<AudioDataBlock>();
            for (var i = 0x00; i < audioDataBlock.Count; i += 3)
            {
                var audioAllocationDataBlockArray = new byte[0x03];

                Array.Copy(audioDataBlockArray, i, audioAllocationDataBlockArray, 0x00, 0x03);
                audioAllocationDataBlocks.Add(new AudioDataBlock(new ReadOnlyCollection<byte>(audioAllocationDataBlockArray)));
            }

            return audioAllocationDataBlocks;
        }
        #endregion

        #endregion
    }
}
