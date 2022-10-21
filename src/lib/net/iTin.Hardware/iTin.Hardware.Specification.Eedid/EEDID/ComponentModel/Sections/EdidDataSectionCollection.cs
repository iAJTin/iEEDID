
using System.ComponentModel;
using System.Linq;

using iTin.Core.Helpers;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections
{
    /// <summary>
    /// Specialization of the class <see cref="BaseDataSectionCollection"/>.<br/>
    /// Representing a collection of objects <see cref="DataSection"/> for a <see cref="DataBlock"/> of type <see cref="KnownDataBlock.EDID"/>.
    /// </summary>
    sealed class EdidDataSectionCollection : BaseDataSectionCollection
    {
        #region constructor/s

        #region [internal] EdidDataSectionCollection(): Initializes a new instance of the class specifying the data of the untreated block
        /// <summary>
        /// Initializes a new instance of the <see cref="EdidDataSectionCollection"/> class specifying the data of the untreated block.
        /// </summary>
        /// <param name="datablock">Data of the untreated block.</param>
        internal EdidDataSectionCollection(DataBlock datablock) : base(datablock, true)
        {                
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (DataSection) this[EdidSection]: Gets the section with the specified key
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
        public DataSection this[EdidSection valueKey]
        {
            get
            {
                var knownBlockValid = IsValidSection(valueKey);
                if (!knownBlockValid)
                {
                    throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(EdidSection));
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

        #region [public] (bool) Contains(EdidSection): Determines whether the element with the specified key is in the collection 'EdidDataSectionCollection'
        /// <summary>
        /// Determines whether the element with the specified key is in the <see cref="EdidDataSectionCollection"/> collection.
        /// </summary>
        /// <param name="valueKey">One of the values of <see cref="EdidSection"/> that represents the key of the object <see cref="DataSection"/> to search</param>
        /// <returns>
        /// <b>true</b> if the <see cref="DataSection"/> object with the <b>valueKey</b> is in the <see cref="EdidDataSectionCollection"/> collection; otherwise, it is <b>false</b>.
        /// </returns>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public bool Contains(EdidSection valueKey)
        {
            var knownSectionValid = IsValidSection(valueKey);
            if (!knownSectionValid)
            {
                throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(EdidSection));
            }

            return ImplementedSections.Contains(valueKey);
        }
        #endregion

        #region [public] (int) IndexOf(EdidSection): Search for the object with the specified key and return the zero-based index of the first occurrence in the entire 'EdidDataSectionCollection' collection
        /// <summary>
        /// Search for the object with the specified key and return the zero-based index of the first occurrence in the entire <see cref="EdidDataSectionCollection"/> collection.
        /// </summary>
        /// <param name="valueKey">One of the values of <see cref="EdidSection"/> that represents the key of the object to be searched in <see cref="EdidDataSectionCollection"/></param>
        /// <returns>
        /// Zero-base index of the first occurrence of item in the whole of <see cref="EdidDataSectionCollection"/>, if found; otherwise, <b>-1</b>.
        /// </returns>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public int IndexOf(EdidSection valueKey)
        {
            var knownSectionValid = IsValidSection(valueKey);
            if (!knownSectionValid)
            {
                throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(EdidSection));
            }

            var section = Sections.FirstOrDefault(item => (EdidSection) item.Key == valueKey);
            return IndexOf(section);
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (bool) IsValidSection(EdidSection): Determines whether the specified key is a valid key of the 'KnownEdidSection' enumeration
        /// <summary>
        /// Determines whether the specified key is a valid key of the <see cref="EdidSection"/> enumeration.
        /// </summary>
        /// <param name="value">Key to check</param>
        /// <returns>
        /// <b>true</b> if the value belongs to the enumeration <see cref="EdidSection"/>; otherwise, it is <b>false</b>.
        /// </returns>
        private static bool IsValidSection(EdidSection value) => SentinelHelper.IsEnumValid(value);
        #endregion

        #endregion
    }
}
