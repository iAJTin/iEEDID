
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using Helpers.Enumerations;

    /// <summary>
    /// Estructura <see cref="VideoDataBlock"/> que contiene la lógica para decodificar los datos de un bloque del tipo <see cref="ShortVideoDescriptorCeaSection"/>.
    /// </summary> 
    struct VideoDataBlock
    {
        #region private readonly members
        private readonly ReadOnlyCollection<byte> _videoDataBlock;
        #endregion

        #region constructor/s

        #region [public] VideoDataBlock(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la estructura.
        /// <summary>
        /// Inicializa una nueva instancia de la estructura <see cref="VideoDataBlock"/> especificando los datos de este bloque de video.
        /// </summary>
        /// <param name="videoDataBlock">Datos de este bloque de video.</param>
        public VideoDataBlock(ReadOnlyCollection<byte> videoDataBlock)
        {
            _videoDataBlock = videoDataBlock;
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (string[]) GetSupportTimmings(): Obtiene la lista de resoluciones/timmings soportados.
        /// <summary>
        /// Obtiene la lista de resoluciones/timmings soportados.
        /// </summary>
        /// <returns>Lista de resoluciones/timmings soportados.</returns>
        public string[] GetSupportTimmings()
        {
            var values = new List<string>();

            for (var i = 0; i <= _videoDataBlock.Count - 1; i++)
            {
                values.Add(string.Concat(TableModes(_videoDataBlock[i]), " ", _videoDataBlock[i].CheckBit(Bits.Bit07) ? "[Native]" : string.Empty));
            }

            return values.ToArray();
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (string) TableModes(byte): Obtiene un valor que representa la resolución/timming standard de la tabla de resoluciones para el valor especificado.
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

        #endregion
    }
}
