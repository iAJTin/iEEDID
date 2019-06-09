﻿
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Especialización de la clase <see cref="BaseDataBlock"/> que representa al bloque <see cref="KnownDataBlock.DI"/> de la especificación <see cref="EEDID"/>.
    /// </summary> 
    internal class DiBlock : BaseDataBlock
    {
        #region constructor/s

        #region [public] DiBlock(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de esta sección sin tratar.
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.DiBlock" /> con los datos de esta sección sin tratar.
        /// </summary>
        /// <param name="dataBlock">Datos sin tratar de este bloque.</param>
        /// <remarks>
        /// Crear bloque <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.DI" /> que pertenece a la especificación <see cref="T:iTin.Core.Hardware.Specification.EEDID" />.
        /// </remarks>
        public DiBlock(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) InitSectionTable(Dictionary<Enum, BaseDataSection>): Inicializar diccionario con las secciones disponibles para este bloque.
        /// <inheritdoc />
        /// <summary>
        /// Inicializar diccionario con las secciones disponibles para este bloque.
        /// </summary>
        /// <param name="sectionDictionary">Diccionario que contiene las secciones disponibles para este bloque.</param>
        protected override void InitSectionTable(Dictionary<Enum, BaseDataSection> sectionDictionary)
        {
            sectionDictionary.Add(KnownDiSection.Revision, new VersionDiSection(RawData));
        }
        #endregion

        #endregion
    }
}
