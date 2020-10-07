
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Especialización de la clase <see cref="BaseDataBlock"/> que representa al bloque <see cref="KnownDataBlock.VTB"/> de la especificación <see cref="EEDID"/>.
    /// </summary> 
    internal class VtbBlock : BaseDataBlock
    {
        #region constructor/s

        #region [public] VtbBlock(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de este bloque sin tratar.
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Hardware.Specification.Eedid.VtbBlock" /> con los datos de este bloque sin tratar.
        /// </summary>
        /// <param name="dataBlock">Datos de este bloque sin tratar.</param>
        /// <remarks>
        /// Crear bloque <see cref="F:iTin.Hardware.Specification.Eedid.KnownDataBlock.VTB" /> que pertenece a la especificación <see cref="T:iTin.Hardware.Specification.EEDID" />.
        /// </remarks>
        public VtbBlock(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
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
            sectionDictionary.Add(KnownDiSection.Revision, new VersionVtbSection(RawData));
        }
        #endregion

        #endregion
    }
}
