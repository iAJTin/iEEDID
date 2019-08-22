
namespace iTin.Core.Hardware.Specification.Eedid
{
    /// <summary>
    /// Representa una colección de propiedades de un objeto que implemente la clase <see cref="BaseDataSectionCollection"/>.
    /// </summary>
    public class SectionProperties
    {
        #region constructor/s

        #region [internal] SectionProperties(Hashtable): Inicializa una nueva instancia de la clase.
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="SectionProperties"/>.
        /// </summary>
        /// <param name="items">Colección de items.</param>
        internal SectionProperties(SectionPropertiesTable items)
        {
            Values = items;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (SectionPropertiesTable) Values: Obtiene los items disponibles.
        /// <summary>
        /// Obtiene los items disponibles.
        /// </summary>
        /// <value>Items disponibles.</value>
        public SectionPropertiesTable Values { get; }

        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (String) ToString: Devuelve una cadena que representa al objeto actual.
        /// <summary>
        /// Devuelve una cadena que representa al objeto <see cref="SectionProperties"/> actual.
        /// </summary>
        /// <returns>
        ///   <para>Cadena que representa al objeto <see cref="SectionProperties"/> actual.</para>
        /// </returns>
        /// <remarks>
        /// El método <see cref="SectionProperties.ToString()"/> devuelve una cadena que incluye el número de items disponibles.
        /// </remarks>   
        public override string ToString() => $"Count = {Values.Count}";
        #endregion

        #endregion
    }
}
