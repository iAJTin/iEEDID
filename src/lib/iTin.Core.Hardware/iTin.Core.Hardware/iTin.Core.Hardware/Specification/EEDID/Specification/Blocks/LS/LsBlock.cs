
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataBlock" /> que representa al bloque <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.LS" /> de la especificación <see cref="T:iTin.Core.Hardware.Specification.EEDID" />.
    /// </summary> 
    internal class LsBlock : BaseDataBlock
    {
        #region constructor/s

        #region [public] LsBlock(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de este bloque sin tratar.
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.LsBlock" /> con los datos de este bloque sin tratar.
        /// </summary>
        /// <param name="dataBlock">Datos de este bloque sin tratar.</param>
        /// <remarks>
        /// Crear bloque <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.LS" /> que pertenece a la especificación <see cref="T:iTin.Core.Hardware.Specification.EEDID" />.
        /// </remarks>
        public LsBlock(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
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
            sectionDictionary.Add(KnownDiSection.Revision, new VersionLsSection(RawData));
        }
        #endregion

        #endregion
    }
}
