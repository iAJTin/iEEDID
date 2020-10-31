
namespace iTin.Hardware.Specification.Eedid
{
    /// <summary>
    /// Represents a collection of properties of an object that implements the <see cref="BaseDataSectionCollection"/> class.
    /// </summary>
    public class SectionProperties
    {
        #region constructor/s

        #region [internal] SectionProperties(Hashtable): Initializes a new instance of the class
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionProperties"/> class.
        /// </summary>
        /// <param name="items">Collection of items.</param>
        internal SectionProperties(SectionPropertiesTable items)
        {
            Values = items;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (SectionPropertiesTable) Values: Gets the available items
        /// <summary>
        /// Gets the available items
        /// </summary>
        /// <value>
        /// Items available.
        /// </value>
        public SectionPropertiesTable Values { get; }

        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (String) ToString: Returns a string representing the current object.
        /// <summary>
        /// Returns a string representing the current <see cref="SectionProperties"/> object.
        /// </summary>
        /// <returns>
        /// A <see cref="string"/> representing the current <see cref="SectionProperties"/> object.
        /// </returns>
        public override string ToString() => $"Count = {Values.Count}";
        #endregion

        #endregion
    }
}
