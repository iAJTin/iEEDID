
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the Short Audio Descriptor section of the Data Block Collection block.
    /// </summary> 
    sealed class ShortAudioDescriptorCeaSection : BaseDataSection
    {
        #region constructor/s

        #region [public] ShortAudioDescriptorCeaSection(ReadOnlyCollection<byte>): Initialize a new instance of the class
        /// <summary>
        /// Initialize a new instance of the <see cref="ShortAudioDescriptorCeaSection"/> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Raw data of this section.</param>
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
            var audioDescriptors = new List<SectionPropertiesTable>();
            foreach (var allocationDataBlock in audioAllocationDataBlock)
            {
                var descriptor = new SectionPropertiesTable                
                {
                    {EedidProperty.Cea.DataBlock.Audio.Descriptor, (byte)i},
                    {EedidProperty.Cea.DataBlock.Audio.BitDepth, allocationDataBlock.BitDepth.ToList().AsReadOnly()},
                    {EedidProperty.Cea.DataBlock.Audio.Channels, allocationDataBlock.Channels},
                    {EedidProperty.Cea.DataBlock.Audio.Format, allocationDataBlock.Format},
                };

                if (allocationDataBlock.MaxBitrate != -1)
                {
                    descriptor.Add(EedidProperty.Cea.DataBlock.Audio.MaxBitrate, allocationDataBlock.MaxBitrate);
                }

                if (allocationDataBlock.SamplingFrequencies.Length > 0)
                {
                    descriptor.Add(EedidProperty.Cea.DataBlock.Audio.SamplingFrequencies, allocationDataBlock.SamplingFrequencies.ToList().AsReadOnly());
                }

                audioDescriptors.Add(descriptor);
                i++;
            }

            properties.Add(EedidProperty.Cea.DataBlock.Tags.Audio, audioDescriptors);
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (IEnumerable<AudioAllocationDataBlock>) GetAudioAllocationDataBlocks(ReadOnlyCollection<byte>): Get the collection of audio structures from this block
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
