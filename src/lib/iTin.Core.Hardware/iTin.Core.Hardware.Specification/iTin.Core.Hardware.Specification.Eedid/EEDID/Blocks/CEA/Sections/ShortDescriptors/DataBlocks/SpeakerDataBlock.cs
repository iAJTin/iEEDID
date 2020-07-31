
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;

    using Helpers.Enumerations;

    /// <summary>
    /// Structure <see cref="SpeakerDataBlock"/> that contains the logic to decode the data of a block of type <see cref="ShortSpeakerDescriptorCeaSection"/>.
    /// </summary> 
    internal struct SpeakerDataBlock
    {
        #region constructor/s

        #region [public] SpeakerDataBlock(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la estructura.
        /// <summary>
        /// Inicializa una nueva instancia de la estructura <see cref="SpeakerDataBlock"/> especificando los datos de este bloque de configuración de altavoces.
        /// </summary>
        /// <param name="speakerDataBlock">Datos de este bloque de configuración de altavoces.</param>
        public SpeakerDataBlock(ReadOnlyCollection<byte> speakerDataBlock)
        {
            FrontLeftRightWide = speakerDataBlock[0x00].CheckBit(Bits.Bit07);
            RearLeftRearCenter = speakerDataBlock[0x00].CheckBit(Bits.Bit06);
            FrontLeftRightCenter = speakerDataBlock[0x00].CheckBit(Bits.Bit05);
            RearCenter = speakerDataBlock[0x00].CheckBit(Bits.Bit04);
            RearLeftRight = speakerDataBlock[0x00].CheckBit(Bits.Bit03);
            FrontCenter = speakerDataBlock[0x00].CheckBit(Bits.Bit02);
            LFEChannel = speakerDataBlock[0x00].CheckBit(Bits.Bit01);
            FrontLeftRight = speakerDataBlock[0x00].CheckBit(Bits.Bit00);

            FrontCenterHigh = speakerDataBlock[0x01].CheckBit(Bits.Bit02);
            TopCenter = speakerDataBlock[0x01].CheckBit(Bits.Bit01);
            FrontLeftRightHigh = speakerDataBlock[0x01].CheckBit(Bits.Bit00);
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (bool) RearLeftRearCenter: Obtiene un valor que indica si estan presentes los altavoces trasero izquierdo/central.
        /// <summary>
        /// Obtiene un valor que indica si estan presentes los altavoces trasero izquierdo/central.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Es <b>true</b> si estan presentes; en caso contrario, es <b>false</b>.</para>
        /// </value>
        public bool RearLeftRearCenter { get; }
        #endregion

        #region [public] (bool) FrontLeftRightWide: Obtiene un valor que indica si estan presentes los altavoces delantero izquierdo wide y delantero derecho wide.
        /// <summary>
        /// Obtiene un valor que indica si estan presentes los altavoces delantero izquierdo wide y delantero derecho wide.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Es <b>true</b> si estan presentes; en caso contrario, es <b>false</b>.</para>
        /// </value>
        public bool FrontLeftRightWide { get; }
        #endregion

        #region [public] (bool) FrontLeftRightHigh: Obtiene un valor que indica si estan presentes los altavoces delantero izquierdo high y delantero derecho high.
        /// <summary>
        /// Obtiene un valor que indica si estan presentes los altavoces delantero izquierdo high y delantero derecho high.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Es <b>true</b> si estan presentes; en caso contrario, es <b>false</b>.</para>
        /// </value>
        public bool FrontLeftRightHigh { get; }
        #endregion

        #region [public] (bool) FrontLeftRightCenter: Obtiene un valor que indica si estan presentes los altavoces delantero izquierdo y central derecho.
        /// <summary>
        /// Obtiene un valor que indica si estan presentes los altavoces delantero izquierdo y central derecho.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Es <b>true</b> si estan presentes; en caso contrario, es <b>false</b>.</para>
        /// </value>
        public bool FrontLeftRightCenter { get; }
        #endregion

        #region [public] (bool) RearCenter: Obtiene un valor que indica si esta presente el altavoz central trasero.
        /// <summary>
        /// Obtiene un valor que indica si esta presente el altavoz central trasero.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Es <b>true</b> si esta presente; en caso contrario, es <b>false</b>.</para>
        /// </value>
        public bool RearCenter { get; }
        #endregion

        #region [public] (bool) RearLeftRight: Obtiene un valor que indica si estan presentes los altavoces traseros derecho e izquierdo.
        /// <summary>
        /// Obtiene un valor que indica si estan presentes los altavoces traseros derecho e izquierdo.      
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Es <b>true</b> si estan presentes; en caso contrario, es <b>false</b>.</para>
        /// </value>
        public bool RearLeftRight { get; }
        #endregion

        #region [public] (bool) FrontCenter: Obtiene un valor que indica si esta presente el altavoz central delantero.
        /// <summary>
        /// Obtiene un valor que indica si esta presente el altavoz central delantero.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Es <b>true</b> si esta presente; en caso contrario, es <b>false</b>.</para>
        /// </value>
        public bool FrontCenter { get; }
        #endregion

        #region [public] (bool) LFEChannel: Obtiene un valor que indica si esta presente el canal de efectos de baja frecuencia (LFE).
        /// <summary>
        /// Obtiene un valor que indica si esta presente el canal de efectos de baja frecuencia (LFE).
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Es <b>true</b> si esta presente; en caso contrario, es <b>false</b>.</para>
        /// </value>
        /// <remarks>
        /// Para más información ver: http://en.wikipedia.org/wiki/Surround_sound.
        /// </remarks>
        public bool LFEChannel { get; }
        #endregion

        #region [public] (bool) FrontLeftRight: Obtiene un valor que indica si estan presentes los altavoces delanteros derecho e izquierdo.
        /// <summary>
        /// Obtiene un valor que indica si estan presentes los altavoces delanteros derecho e izquierdo.      
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Es <b>true</b> si estan presentes; en caso contrario, es <b>false</b>.</para>
        /// </value>
        public bool FrontLeftRight { get; }
        #endregion

        #region [public] (bool) TopCenter: Obtiene un valor que indica si esta presente el altavoz central superior.
        /// <summary>
        /// Obtiene un valor que indica si esta presente el altavoz central superior.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Es <b>true</b> si esta presente; en caso contrario, es <b>false</b>.</para>
        /// </value>
        public bool TopCenter { get; }
        #endregion

        #region [public] (bool) FrontCenterHigh: Obtiene un valor que indica si esta presente el altavoz central delantero high.
        /// <summary>
        /// Obtiene un valor que indica si esta presente el altavoz central delantero high.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Es <b>true</b> si estan presentes; en caso contrario, es <b>false</b>.</para>
        /// </value>
        public bool FrontCenterHigh { get; }
        #endregion

        #endregion
    }
}
