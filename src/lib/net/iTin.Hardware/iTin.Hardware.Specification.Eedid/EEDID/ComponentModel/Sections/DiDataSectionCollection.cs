
using System.ComponentModel;
using System.Linq;

using iTin.Core.Helpers;

namespace iTin.Hardware.Specification.Eedid.Blocks.DI.Sections
{
    /// <summary>
    /// Specialization of the class <see cref="BaseDataSectionCollection"/>.<br/>
    /// Representing a collection of objects <see cref="DataSection"/> for a <see cref="DataBlock"/> of type <see cref="KnownDataBlock.DI"/>.
    /// </summary>
    internal sealed class DiDataSectionCollection : BaseDataSectionCollection
    {
        #region constructor/s

        #region [internal] DiDataSectionCollection(): Initializes a new instance of the class specifying the data of the untreated block
        /// <summary>
        /// Initializes a new instance of the <see cref="DiDataSectionCollection" /> class specifying the data of the untreated block.
        /// </summary>
        /// <param name="datablock">Datos del bloque sin tratar.</param>
        internal DiDataSectionCollection(DataBlock datablock) : base(datablock, true)
        {                
        }
        #endregion

        #endregion

        #region public readonly properties

        #region [public] (DataSection) this[DiSection]: Gets the section with the specified key
        /// <summary>
        /// Gets the section with the specified key.
        /// </summary>
        /// <value>
        /// Object <see cref="DataSection" /> specified by its key.
        /// </value>
        /// <remarks>
        /// If the element does not exist, <b>null</b> is returned.
        /// </remarks>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public DataSection this[DiSection valueKey]
        {
            get
            {
                var knownBlockValid = IsValidSection(valueKey);
                if (!knownBlockValid)
                {
                    throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(DiSection));
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

        #region [public] (bool) Contains(DiSection): Determines whether the element with the specified key is in the collection 'DiDataSectionCollection'
        /// <summary>
        /// Determines whether the element with the specified key is in the <see cref="DiDataSectionCollection"/> collection.
        /// </summary>
        /// <param name="valueKey">One of the values of <see cref="DiSection"/> that represents the key of the object <see cref="DataSection"/> to search</param>
        /// <returns>
        /// <b>true</b> if the <see cref="DataSection"/> object with the <b>valueKey</b> is in the <see cref="DiDataSectionCollection"/> collection; otherwise, it is <b>false</b>.
        /// </returns>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public bool Contains(DiSection valueKey)
        {
            var knownSectionValid = IsValidSection(valueKey);
            if (!knownSectionValid)
            {
                throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(DiSection));
            }

            return ImplementedSections.Contains(valueKey);
        }
        #endregion

        #region [public] (int) IndexOf(DiSection): Search for the object with the specified key and return the zero-based index of the first occurrence in the entire 'DiDataSectionCollection' collection
        /// <summary>
        /// Search for the object with the specified key and return the zero-based index of the first occurrence in the entire <see cref="DiDataSectionCollection"/> collection.
        /// </summary>
        /// <param name="valueKey">One of the values of <see cref="DiSection"/> that represents the key of the object to be searched in <see cref="DiDataSectionCollection"/></param>
        /// <returns>
        /// Zero-base index of the first occurrence of item in the whole of <see cref="DiDataSectionCollection"/>, if found; otherwise, <b>-1</b>.
        /// </returns>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public int IndexOf(DiSection valueKey)
        {
            var knownSectionValid = IsValidSection(valueKey);
            if (!knownSectionValid)
            {
                throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(DiSection));
            }

            var section = Sections.FirstOrDefault(item => (DiSection) item.Key == valueKey);
            return IndexOf(section);

            #region Versión sin utilizar LINQ.
            //DataSection section = null;
            //foreach (var item in Sections)
            //{
            //    if ((DiSection)item.Key == valueKey)
            //    {
            //        section = item;
            //        break;
            //    }
            //}

            //return IndexOf(section);
            #endregion
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (bool) IsValidSection(DiSection): Determines whether the specified key is a valid key of the 'DiSection' enumeration
        /// <summary>
        /// Determines whether the specified key is a valid key of the <see cref="DiSection"/> enumeration.
        /// </summary>
        /// <param name="value">Key to check</param>
        /// <returns>
        /// <b>true</b> if the value belongs to the enumeration <see cref="DiSection"/>; otherwise, it is <b>false</b>.
        /// </returns>
        private static bool IsValidSection(DiSection value)
        {
            return SentinelHelper.IsEnumValid(value);
        }
        #endregion

        #endregion
    }
}
