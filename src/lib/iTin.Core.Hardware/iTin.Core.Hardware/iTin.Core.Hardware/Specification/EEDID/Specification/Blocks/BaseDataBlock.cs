
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Clase base que representa un bloque de la especificación <b>Extended display identification data (E-EDID)</b>.
    /// </summary> 
    abstract class BaseDataBlock
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<Enum, BaseDataSection> _sectionTable;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<Enum, ReadOnlyCollection<byte>> _dataSectionTable;
        #endregion

        #region constructor/s

        #region [protected] BaseDataBlock(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase.
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="BaseDataBlock"/>.
        /// </summary>
        /// <param name="dataBlock">Datos del bloque.</param>
        protected BaseDataBlock(ReadOnlyCollection<byte> dataBlock)
        {
            RawData = dataBlock;
        }
        #endregion

        #endregion

        #region protected readonly properties

        #region [protected] (Dictionary<Enum, ReadOnlyCollection<byte>>) DataSectionTable: Obtiene un valor que representa los datos disponibles sin procesar para las secciones del bloque actual.
        /// <summary>
        /// Obtiene un valor que representa los datos disponibles sin procesar para las secciones del bloque actual.
        /// </summary>
        /// <value>
        /// Diccionario que contiene el par Sección / Valor sin procesar de la misma.
        /// </value>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        protected Dictionary<Enum, ReadOnlyCollection<byte>> DataSectionTable
        {
            get
            {
                if (_dataSectionTable != null)
                {
                    return _dataSectionTable;
                }

                _dataSectionTable = new Dictionary<Enum, ReadOnlyCollection<byte>>(0x0a);
                InitDataSectionTable(_dataSectionTable);
                return _dataSectionTable;
            }
        }
        #endregion

        #region [protected] (ReadOnlyCollection<byte>) RawData: Obtiene un valor que representa los datos a procesar.
        /// <summary>
        /// Obtiene un valor que representa los datos a procesar.
        /// </summary>
        /// <value>Datos a procesar.</value>
        protected ReadOnlyCollection<byte> RawData { get; }
        #endregion

        #endregion

        #region private properties

        #region [private] (Dictionary<Enum, BaseDataSection>) SectionTable: Obtiene un valor que representa las secciones disponibles del bloque actual.
        /// <summary>
        /// Obtiene un valor que representa las secciones disponibles del bloque actual.
        /// </summary>
        /// <value>
        /// Diccionario que contiene el par Sección / Valor de la misma.
        /// </value>
        public Dictionary<Enum, BaseDataSection> SectionTable
        {
            get
            {
                if (_sectionTable != null)
                {
                    return _sectionTable;
                }

                _sectionTable = new Dictionary<Enum, BaseDataSection>(0x0a);
                InitSectionTable(_sectionTable);

                return _sectionTable;
            }
        }
        #endregion

        #endregion

        #region protected virtual methods

        #region [protected] {virtual} (void) InitDataSectionTable(Dictionary<Enum, ReadOnlyCollection<byte>>): Inicializar diccionario con los datos disponibles sin procesar para las secciones del bloque actual.
        /// <summary>
        /// Inicializar diccionario con los datos disponibles sin procesar para las secciones del bloque actual.
        /// </summary>
        /// <param name="dataSectionDictionary">Diccionario que contiene los datos disponibles sin procesar para las secciones del bloque actual.</param>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        protected virtual void InitDataSectionTable(Dictionary<Enum, ReadOnlyCollection<byte>> dataSectionDictionary)
        {
        }
        #endregion

        #region [protected] {virtual} (void) InitSectionTable(IDictionary<Enum, BaseDataSection>): Inicializar diccionario con las secciones disponibles para el bloque actual.
        /// <summary>
        /// Inicializar diccionario con las secciones disponibles para el bloque actual.
        /// </summary>
        /// <param name="sectionDictionary">Diccionario que contiene las secciones disponibles para el bloque actual.</param>
        protected virtual void InitSectionTable(Dictionary<Enum, BaseDataSection> sectionDictionary)
        {
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Devuelve una clase string que representa la clase actual.
        /// <summary>
        /// Devuelve una clase <see cref="T:System.String"/> que representa la clase
        /// <see cref="BaseDataBlock"/> actual.
        /// </summary>
        /// <returns>
        ///   <para>Una cadena que representa la clase <see cref="BaseDataBlock"/> actual.</para>
        /// </returns>
        /// <remarks>
        ///   El método <see cref="BaseDataBlock.ToString()"/> devuelve una cadena que 
        ///   incluye el número de secciones disponibles.           
        /// </remarks>
        public override string ToString() => $"Sections = {SectionTable.Count}";
        #endregion

        #endregion
    }
}
