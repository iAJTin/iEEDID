
namespace iTin.Hardware.Specification.Eedid
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using iTin.Core;
    using iTin.Core.Collections;
    using iTin.Core.Helpers.Enumerations;

    /// <summary>
    /// Structure <see cref="AudioDataBlock"/> that contains the logic to decode the data of a block of type <see cref="ShortAudioDescriptorCeaSection"/>.
    /// </summary> 
    internal struct AudioDataBlock 
    {
        #region constructor/s

        #region [public] AudioDataBlock(ReadOnlyCollection<byte>): Initializes a new instance of the structure
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioDataBlock"/> structure specifying the data of this audio block.
        /// </summary>
        /// <param name="audioDataBlock">Data of this audio block.</param>
        public AudioDataBlock(ReadOnlyCollection<byte> audioDataBlock)
        {
            var formatCode = (KnownAudioFormatCode)(audioDataBlock[0x00] >> 3 & 0x0f);
            Properties = new NameObjectCollection
            {
                {"Format", AudioFormat((byte)formatCode) },
                {"Channels", 1 + (byte) (audioDataBlock[0x00] & 0x07) },
                {"Sampling Frequencies", SamplingFrequencies((byte) (audioDataBlock[0x01] & 0x7f)) }
            };

            if (formatCode == KnownAudioFormatCode.PCM)
            {
                Properties.Add("Bit Depth", BitDepth((byte)(audioDataBlock[0x02] & 0x07)));
            }
            else
            {
                Properties.Add("Max Bitrate", $"{audioDataBlock[0x02] << 3} Khz");
            }
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (NameObjectCollection) Properties: Gets a value that represents the collection of properties available to this block
        /// <summary>
        /// Gets a value that represents the collection of properties available to this block.
        /// </summary>
        /// <value>
        /// Collection of properties available for this block.
        /// </value>
        public NameObjectCollection Properties { get; }
        #endregion

        #endregion

        #region private static methods

        private static string AudioFormat(byte code)
        {
            var items = new[]
            {
                "Reserved",
                "Linear Pulse Code Modulation (LPCM)",
                "AC-3",
                "MPEG-1 (Layers 1 & 2)",
                "MP3 (MPEG1 Layer 3)",
                "MPEG2 (Multichannel)",
                "AAC",
                "DTS",
                "ATRAC",
                "One-bit audio aka SACD",
                "DD+",
                "DTS-HD",
                "MLP/Dolby TrueHD",
                "DTS",
                "Microsoft WMA Pro",
                "Reserved"
            };

            return items[code];
        }

        private static ReadOnlyCollection<string> BitDepth(byte code)
        {
            var value = new[]
            {
                "16 bit", //0x00
                "20 bit",
                "24 bit", //0x02
            };

            var items = new List<string>();
            for (byte i = 0x00; i <= 0x02; i++)
            {
                var addDepth = code.CheckBit((Bits)i);
                if (addDepth)
                {
                    items.Add(value[i]);
                }
            }

            return items.AsReadOnly();
        }

        private static ReadOnlyCollection<string> SamplingFrequencies(byte code)
        {
            var value = new[]
            {
                "32KHz",     // 0x00
                "44KHz",
                "48KHz",
                "88KHz",
                "96KHz",
                "176KHz",
                "192KHz"     // 0x06
            };

            var items = new List<string>();
            for (byte i = 0x00; i <= 0x06; i++)
            {
                var addFrequency = code.CheckBit((Bits) i);
                if (addFrequency)
                {
                    items.Add(value[i]);
                }
            }

            return items.AsReadOnly();
        }

        #endregion
    }
}
