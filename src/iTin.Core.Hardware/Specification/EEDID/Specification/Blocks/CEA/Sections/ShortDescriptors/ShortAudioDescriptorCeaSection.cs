
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> que representa la sección Short Audio Descriptor del bloque Data Block Collection.
    /// </summary> 
    sealed class ShortAudioDescriptorCeaSection : BaseDataSection
    {
        #region constructor/s

        #region [public] ShortAudioDescriptorCeaSection(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase.
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.ShortAudioDescriptorCeaSection" />.
        /// </summary>
        /// <param name="sectionData">Datos de esta sección.</param>
        public ShortAudioDescriptorCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
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
            var audioAllocationDataBlock = GetAudioAllocationDataBlocks(RawData);

            var i = 0;
            foreach (var allocationDataBlock in audioAllocationDataBlock)
            {
                items.Add("Descriptor " + i, allocationDataBlock.Properties);
                i++;
            }
            #endregion
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
