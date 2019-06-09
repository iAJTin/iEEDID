﻿
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Estructura <see cref="ReservedDataBlock"/> que contiene la lógica para decodificar los datos de un bloque del tipo <see cref="ShortReservedDescriptorCeaSection"/>.
    /// </summary> 
    struct ReservedDataBlock
    {
        #region constructor/s

        #region [public] ReservedDataBlock(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la estructura.
        /// <summary>
        /// Inicializa una nueva instancia de la estructura <see cref="ReservedDataBlock"/> especificando los datos de este bloque reservado.
        /// </summary>
        /// <param name="reservedDataBlock">Datos de este bloque reservado.</param>
        public ReservedDataBlock(ReadOnlyCollection<byte> reservedDataBlock)
        {
            RawData = reservedDataBlock;
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (ReadOnlyCollection<byte>) RawData: Obtiene un valor que representa los datos de este bloque reservado.
        /// <summary>
        /// Obtiene un valor que representa los datos de este bloque reservado.
        /// </summary>
        /// <value>Datos de este bloque reservado.</value>
        public ReadOnlyCollection<byte> RawData { get; }
        #endregion

        #endregion
    }
}
