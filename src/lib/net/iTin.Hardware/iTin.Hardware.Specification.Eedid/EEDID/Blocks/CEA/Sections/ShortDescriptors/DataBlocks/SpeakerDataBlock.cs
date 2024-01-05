
using System.Collections.ObjectModel;

using iTin.Core;
using iTin.Core.Helpers.Enumerations;

namespace iTin.Hardware.Specification.Eedid.Blocks.CEA.Sections.Descriptors.DataBlocks;

/// <summary>
/// Structure <see cref="SpeakerDataBlock"/> that contains the logic to decode the data of a block of type <see cref="ShortSpeakerDescriptorSection"/>.
/// </summary> 
internal readonly struct SpeakerDataBlock
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="SpeakerDataBlock"/> structure specifying the data for this speaker setup block.
    /// </summary>
    /// <param name="speakerDataBlock">Data for this speaker configuration block.</param>
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

    #region public readonly properties

    /// <summary>
    /// Obtiene un valor que indica si estan presentes los altavoces trasero izquierdo/central.
    /// </summary>
    /// <value>
    /// Es <strong>true</strong> si estan presentes; en caso contrario, es <strong>false</strong>.
    /// </value>
    public bool RearLeftRearCenter { get; }

    /// <summary>
    /// Obtiene un valor que indica si estan presentes los altavoces delantero izquierdo wide y delantero derecho wide.
    /// </summary>
    /// <value>
    ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
    ///   <para>Es <strong>true</strong> si estan presentes; en caso contrario, es <strong>false</strong>.</para>
    /// </value>
    public bool FrontLeftRightWide { get; }

    /// <summary>
    /// Obtiene un valor que indica si estan presentes los altavoces delantero izquierdo high y delantero derecho high.
    /// </summary>
    /// <value>
    ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
    ///   <para>Es <strong>true</strong> si estan presentes; en caso contrario, es <strong>false</strong>.</para>
    /// </value>
    public bool FrontLeftRightHigh { get; }

    /// <summary>
    /// Obtiene un valor que indica si estan presentes los altavoces delantero izquierdo y central derecho.
    /// </summary>
    /// <value>
    ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
    ///   <para>Es <strong>true</strong> si estan presentes; en caso contrario, es <strong>false</strong>.</para>
    /// </value>
    public bool FrontLeftRightCenter { get; }

    /// <summary>
    /// Obtiene un valor que indica si esta presente el altavoz central trasero.
    /// </summary>
    /// <value>
    ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
    ///   <para>Es <strong>true</strong> si esta presente; en caso contrario, es <strong>false</strong>.</para>
    /// </value>
    public bool RearCenter { get; }

    /// <summary>
    /// Obtiene un valor que indica si estan presentes los altavoces traseros derecho e izquierdo.      
    /// </summary>
    /// <value>
    ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
    ///   <para>Es <strong>true</strong> si estan presentes; en caso contrario, es <strong>false</strong>.</para>
    /// </value>
    public bool RearLeftRight { get; }

    /// <summary>
    /// Obtiene un valor que indica si esta presente el altavoz central delantero.
    /// </summary>
    /// <value>
    ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
    ///   <para>Es <strong>true</strong> si esta presente; en caso contrario, es <strong>false</strong>.</para>
    /// </value>
    public bool FrontCenter { get; }

    /// <summary>
    /// Obtiene un valor que indica si esta presente el canal de efectos de baja frecuencia (LFE).
    /// </summary>
    /// <value>
    ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
    ///   <para>Es <strong>true</strong> si esta presente; en caso contrario, es <strong>false</strong>.</para>
    /// </value>
    /// <remarks>
    /// Para más información ver: http://en.wikipedia.org/wiki/Surround_sound.
    /// </remarks>
    public bool LFEChannel { get; }

    /// <summary>
    /// Obtiene un valor que indica si estan presentes los altavoces delanteros derecho e izquierdo.      
    /// </summary>
    /// <value>
    ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
    ///   <para>Es <strong>true</strong> si estan presentes; en caso contrario, es <strong>false</strong>.</para>
    /// </value>
    public bool FrontLeftRight { get; }

    /// <summary>
    /// Obtiene un valor que indica si esta presente el altavoz central superior.
    /// </summary>
    /// <value>
    ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
    ///   <para>Es <strong>true</strong> si esta presente; en caso contrario, es <strong>false</strong>.</para>
    /// </value>
    public bool TopCenter { get; }

    /// <summary>
    /// Obtiene un valor que indica si esta presente el altavoz central delantero high.
    /// </summary>
    /// <value>
    ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
    ///   <para>Es <strong>true</strong> si estan presentes; en caso contrario, es <strong>false</strong>.</para>
    /// </value>
    public bool FrontCenterHigh { get; }

    #endregion
}
