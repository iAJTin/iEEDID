
using System.ComponentModel;
using System.Linq;

using iTin.Core.Helpers;

namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections
{
    /// <summary>
    /// Specialization of the class <see cref="BaseDataSectionCollection"/>.<br/>
    /// Representing a collection of objects <see cref="DataSection"/> for a <see cref="DataBlock"/> of type <see cref="KnownDataBlock.DisplayID"/>.
    /// </summary>
    internal sealed class DisplayIdDataSectionCollection : BaseDataSectionCollection
    {
        #region constructor/s

        #region [internal] DisplayIdDataSectionCollection(): Initializes a new instance of the class specifying the data of the untreated block
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayIdDataSectionCollection"/> class specifying the data of the untreated block.
        /// </summary>
        /// <param name="datablock">Datos del bloque sin tratar.</param>
        internal DisplayIdDataSectionCollection(DataBlock datablock) : base(datablock, true)
        {                
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (DataSection) this[DisplayIdSection]: Gets the section with the specified key
        /// <summary>
        /// Gets the section with the specified key.
        /// </summary>
        /// <value>
        /// Object <see cref="DataSection"/> specified by its key.
        /// </value>
        /// <remarks>
        /// If the element does not exist, <b>null</b> is returned.
        /// </remarks>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public DataSection this[DisplayIdSection valueKey]
        {
            get
            {
                var knownBlockValid = IsValidSection(valueKey);
                if (!knownBlockValid)
                {
                    throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(DisplayIdSection));
                }

                var sectionIndex = IndexOf(valueKey);
                if (sectionIndex != -1)
                {
                    return this[sectionIndex];
                }

                return null;
            }
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (bool) Contains(DisplayIdSection): Determines whether the element with the specified key is in the collection 'DisplayIdDataSectionCollection'
        /// <summary>
        /// Determines whether the element with the specified key is in the <see cref="DisplayIdDataSectionCollection"/> collection.
        /// </summary>
        /// <param name="valueKey">One of the values of <see cref="DisplayIdSection"/> that represents the key of the object <see cref="DataSection"/> to search</param>
        /// <returns>
        /// <b>true</b> if the <see cref="DataSection"/> object with the <b>valueKey</b> is in the <see cref="DisplayIdDataSectionCollection"/> collection; otherwise, it is <b>false</b>.
        /// </returns>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public bool Contains(DisplayIdSection valueKey)
        {
            var knownSectionValid = IsValidSection(valueKey);
            if (!knownSectionValid)
            {
                throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(DisplayIdSection));
            }

            return ImplementedSections.Contains(valueKey);
        }
        #endregion

        #region [public] (int) IndexOf(DisplayIdSection): Search for the object with the specified key and return the zero-based index of the first occurrence in the entire 'DisplayIdDataSectionCollection' collection
        /// <summary>
        /// Search for the object with the specified key and return the zero-based index of the first occurrence in the entire <see cref="DisplayIdDataSectionCollection"/> collection.
        /// </summary>
        /// <param name="valueKey">One of the values of <see cref="DisplayIdSection"/> that represents the key of the object to be searched in <see cref="DisplayIdDataSectionCollection"/></param>
        /// <returns>
        /// Zero-base index of the first occurrence of item in the whole of <see cref="DisplayIdDataSectionCollection"/>, if found; otherwise, <b>-1</b>.
        /// </returns>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public int IndexOf(DisplayIdSection valueKey)
        {
            var knownSectionValid = IsValidSection(valueKey);
            if (!knownSectionValid)
            {
                throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(DisplayIdSection));
            }

            var section = Sections.FirstOrDefault(item => (DisplayIdSection) item.Key == valueKey);
            return IndexOf(section);
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (bool) IsValidSection(DisplayIdSection): Determines whether the specified key is a valid key of the 'DisplayIdSection' enumeration
        /// <summary>
        /// Determines whether the specified key is a valid key of the <see cref="DisplayIdSection"/> enumeration.
        /// </summary>
        /// <param name="value">Key to check</param>
        /// <returns>
        /// <b>true</b> if the value belongs to the enumeration <see cref="DisplayIdSection"/>; otherwise, it is <b>false</b>.
        /// </returns>
        private static bool IsValidSection(DisplayIdSection value) => SentinelHelper.IsEnumValid(value);
        #endregion

        #endregion
    }
}
