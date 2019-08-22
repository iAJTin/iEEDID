
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.ObjectModel;

    /* •————————————————•
       | CEA Data Block |
       |   · Tag code   |
       |   · Lenght     |
       |   · RawData    |
       •————————————————• */

    /// <summary>
    /// Estructura <see cref="CeaDataBlock"/> que contiene la información sin procesar de los bloques de tipo <b>AllcationDataBlock</b>.
    /// </summary> 
    internal struct CeaDataBlock
    {
        #region constructor/s

        #region [public] CeaDataBlock(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la estructura.
        /// <summary>
        /// Inicializa una nueva instancia de la estructura <see cref="CeaDataBlock"/>.
        /// </summary>
        /// <param name="dataBlock">Datos de este bloque.</param>
        public CeaDataBlock(ReadOnlyCollection<byte> dataBlock)
        {
            _dataBlock = dataBlock;
            _lenght = _dataBlock[0x00] & 0x1f;
            Tag = (KnownShortDataBlockTag)((_dataBlock[0x00] & 0xe0) >> 5);
        }
        #endregion
           
        #endregion

        #region private readonly members
        private readonly int _lenght;
        private readonly ReadOnlyCollection<byte> _dataBlock;
        #endregion

        #region public properties

        #region [public] (ReadOnlyCollection<byte>) RawData: Obtiene un array con la información de este bloque sin procesar.
        /// <summary>
        /// Obtiene un array con la información de este bloque sin procesar.
        /// </summary>
        /// <value>
        /// Array con la información del bloque sin procesar.
        /// </value>
        public ReadOnlyCollection<byte> RawData
        {
            get
            {
                var dataBlockArray = new byte[_dataBlock.Count];
                _dataBlock.CopyTo(dataBlockArray, 0);

                var rawData = new byte[_lenght];
                Array.Copy(dataBlockArray, 0x01,rawData, 0x00, _lenght);

                return new ReadOnlyCollection<byte>(rawData);
            }
        }
        #endregion

        #region [public] (ShortDataBlockTag) Tag: Obtiene un valor que representa el tipo de bloque.
        /// <summary>
        /// Obtiene un valor que representa el tipo de bloque.
        /// </summary>
        /// <value>
        /// 	<para>Uno de los valores de la enumeración <see cref="KnownShortDataBlockTag"/> que representa el tipo de bloque.</para>
        /// </value>
        public KnownShortDataBlockTag Tag { get; }
        #endregion

        #endregion
    }
}
