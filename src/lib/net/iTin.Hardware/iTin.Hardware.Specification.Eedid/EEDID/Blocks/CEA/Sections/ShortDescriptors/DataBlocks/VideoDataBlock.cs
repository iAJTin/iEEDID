
using System.Collections.Generic;
using System.Collections.ObjectModel;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors.DataBlocks;

/// <summary>
/// Structure <see cref="VideoDataBlock"/> that contains the logic to decode the data of a block of type <see cref="ShortVideoDescriptorSection"/>.
/// </summary> 
internal readonly struct VideoDataBlock
{
    #region private readonly members

    private readonly ReadOnlyCollection<byte> _videoDataBlock;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="VideoDataBlock"/> structure specifying the data of this video block.
    /// </summary>
    /// <param name="videoDataBlock">Data of this video block.</param>
    public VideoDataBlock(ReadOnlyCollection<byte> videoDataBlock)
    {
        _videoDataBlock = videoDataBlock;
    }

    #endregion

    #region public methods

    /// <summary>
    /// Gets the list of supported resolutions/timings.
    /// </summary>
    /// <returns>
    /// List of supported resolutions/timings.
    /// </returns>
    public string[] GetSupportTimmings()
    {
        var values = new List<string>();

        for (var i = 0; i <= _videoDataBlock.Count - 1; i++)
        {
            values.Add(string.Concat(TableModes(_videoDataBlock[i]), " ", _videoDataBlock[i].CheckBit(Bits.Bit07) ? "[Native]" : string.Empty));
        }

        return [.. values];
    }

    #endregion

    #region private static methods

    private static string TableModes(byte code)
    {
        var items = new[]
        {
            "640x480p@60Hz 4:3",
            "720x480p@60Hz 4:3",
            "720x480p@60Hz 16:9",
            "1280x720p@60Hz 16:9",
            "1920x1080i@60Hz 16:9",
            "720x480i@60Hz 4:3",
            "720x480i@60Hz 16:9",
            "720x240p@60Hz 4:3",
            "720x240p@60Hz 16:9",
            "2880x480i@60Hz 4:3",
            "2880x480i@60Hz 16:9",
            "2880x240p@60Hz 4:3",
            "2880x240p@60Hz 16:9",
            "1440x480p@60Hz 4:3",
            "1440x480p@60Hz 16:9",
            "1920x1080p@60Hz 16:9",
            "720x576p@50Hz 4:3",
            "720x576p@50Hz 16:9",
            "1280x720p@50Hz 16:9",
            "1920x1080i (1125)@50Hz 16:9",
            "720x576i@50Hz 4:3",
            "720x576i@50Hz 16:9",
            "720x288p@50Hz 4:3",
            "720x288p@50Hz 16:9",
            "2880x576i@50Hz 4:3",
            "2880x576i@50Hz 16:9",
            "2880x288p@50Hz 4:3",
            "2880x288p@50Hz 16:9",
            "1440x576p@50Hz 4:3",
            "1440x576p@50Hz 16:9",
            "1920x1080p@50Hz 16:9",
            "1920x1080p@24Hz 16:9",
            "1920x1080p@25Hz 16:9",
            "1920x1080p@30Hz 16:9",
            "2880x480p@60Hz 4:3",
            "2880x480p@60Hz 16:9",
            "2880x576p@50Hz 4:3",
            "2880x576p@50Hz 16:9",
            "1920x1080i(1250 Total)@50Hz 16:9",
            "1920x1080i@100Hz 16:9",
            "1280x720p@100Hz 16:9",
            "720x576p@100Hz 4:3",
            "720x576p@100Hz 16:9",
            "720(1440)x576i@100Hz 4:3",
            "720(1440)x576i@100Hz 16:9",
            "1920x1080i@120Hz 16:9",
            "1280x720p@120Hz 16:9",
            "720x480p@120Hz 4:3",
            "720x480p@120Hz 16:9",
            "720(1440)x480i@120Hz 4:3",
            "720(1440)x480i@120Hz 16:9",
            "720x576p@200Hz 4:3",
            "720x576p@200Hz 16:9",
            "720(1440)x576i@200Hz 4:3",
            "720(1440)x576i@200Hz 16:9",
            "720x480p@240Hz 4:3",
            "720x480p@240Hz 16:9",
            "720(1440)x480i@240Hz 4:3",
            "720(1440)x480i@240Hz 16:9",
            "1280x720p@24Hz 16:9",
            "1280x720p@25Hz 16:9",
            "1280x720p@30Hz 16:9",
            "1920x1080p@120Hz 16:9",
            "1920x1080p@100Hz 16:9"
        };

        if ((code & 0x7f) <= items.Length)
        {
            return items[(code & 0x7f) - 1];
        }

        return "Unknown";
    }

    #endregion
}
