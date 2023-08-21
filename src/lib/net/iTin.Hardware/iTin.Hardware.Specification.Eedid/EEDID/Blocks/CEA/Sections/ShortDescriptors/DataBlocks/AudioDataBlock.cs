
using System.Collections.Generic;
using System.Collections.ObjectModel;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors.DataBlocks;

/// <summary>
/// Structure <see cref="AudioDataBlock"/> that contains the logic to decode the data of a block of type <see cref="ShortAudioDescriptorSection"/>.
/// </summary> 
internal readonly struct AudioDataBlock 
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="AudioDataBlock"/> structure specifying the data of this audio block.
    /// </summary>
    /// <param name="audioDataBlock">Data of this audio block.</param>
    public AudioDataBlock(ReadOnlyCollection<byte> audioDataBlock)
    {
        var formatCode = (AudioFormatCode)(audioDataBlock[0x00] >> 3 & 0x0f);

        Format = AudioFormat((byte)formatCode);
        Channels = (ushort)(1 + (byte)(audioDataBlock[0x00] & 0x07));
        SamplingFrequencies = SamplingFrequenciesValue((byte)(audioDataBlock[0x01] & 0x7f));

        if (formatCode == AudioFormatCode.PCM)
        {
            MaxBitrate = -1;
            BitDepth = BitDepthValue((byte)(audioDataBlock[0x02] & 0x07));
        }
        else
        {
            BitDepth = new string[] { };
            MaxBitrate = audioDataBlock[0x02] << 3;
        }
    }

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets the audio bit depth.
    /// </summary>
    /// <value>
    /// String array containing the audio bit depth.
    /// </value>
    public string[] BitDepth { get; }

    /// <summary>
    /// Gets the audio channels.
    /// </summary>
    /// <value>
    /// A <see cref="ushort"/> containing the audio channels.
    /// </value>
    public ushort Channels { get; }

    /// <summary>
    /// Gets the audio format.
    /// </summary>
    /// <value>
    /// A <see cref="string"/> containing the audio format.
    /// </value>
    public string Format { get; }

    /// <summary>
    /// Gets the audio MaxBitrate. If not exist then returns <b>-1</b>.
    /// </summary>
    /// <value>
    /// A <see cref="int"/> containing the audio format.
    /// </value>
    public int MaxBitrate { get; }

    /// <summary>
    /// Gets the audio sampling frequencies. If not exist then returns an empty array.
    /// </summary>
    /// <value>
    /// Array string containing the audio sampling frequencies.
    /// </value>
    public string[] SamplingFrequencies { get; }

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

    private static string[] BitDepthValue(byte code)
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

        return (string[])items.ToArray().Clone();
    }

    private static string[] SamplingFrequenciesValue(byte code)
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

        return (string[])items.ToArray().Clone();
    }

    #endregion
}
