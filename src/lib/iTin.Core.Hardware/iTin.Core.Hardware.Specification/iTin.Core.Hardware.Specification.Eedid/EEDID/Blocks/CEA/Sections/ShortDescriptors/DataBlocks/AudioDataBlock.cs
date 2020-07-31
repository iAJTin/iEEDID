
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using Collections;
    using Helpers.Enumerations;

    /// <summary>
    /// Structure <see cref="AudioDataBlock"/> that contains the logic to decode the data of a block of type <see cref="ShortAudioDescriptorCeaSection"/>.
    /// </summary> 
    internal struct AudioDataBlock 
    {
        #region constructor/s

        #region [public] AudioDataBlock(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la estructura.
        /// <summary>
        /// Inicializa una nueva instancia de la estructura <see cref="AudioDataBlock"/> especificando los datos de este bloque de audio.
        /// </summary>
        /// <param name="audioDataBlock">Datos de este bloque de audio.</param>
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

        #region [public] (NameObjectCollection) Properties: Obtiene un valor que representa la colección de propiedades disponibles para este bloque.
        /// <summary>
        ///Obtiene un valor que representa la colección de propiedades disponibles para este bloque.
        /// </summary>
        /// <value>Colección de propiedades disponibles para este bloque.</value>
        public NameObjectCollection Properties { get; }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (string) AudioFormat(byte): Obtiene el formato de audio.
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
        #endregion

        #region [private] {static} (ReadOnlyCollection<string>) BitDepth(): Obtiene la resolución de un formato de audio sin compresión.
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
        #endregion 

        #region [private] {static} (ReadOnlyCollection<string>) SamplingFrequencies(byte): Obtiene las frecuencias de muestreo.
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

        #endregion
    }
}
