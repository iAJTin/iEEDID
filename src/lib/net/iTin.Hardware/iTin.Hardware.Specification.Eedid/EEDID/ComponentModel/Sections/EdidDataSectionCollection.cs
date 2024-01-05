
using System.ComponentModel;
using System.Linq;

using iTin.Core.Helpers;

namespace iTin.Hardware.Specification.Eedid.Blocks.EDID.Sections;

/// <summary>
/// Specialization of the class <see cref="BaseDataSectionCollection"/>.<br/>
/// Representing a collection of objects <see cref="DataSection"/> for a <see cref="DataBlock"/> of type <see cref="KnownDataBlock.EDID"/>.
/// </summary>
sealed class EdidDataSectionCollection : BaseDataSectionCollection
{
    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the <see cref="EdidDataSectionCollection"/> class specifying the data of the untreated block.
    /// </summary>
    /// <param name="datablock">Raw block data.</param>
    internal EdidDataSectionCollection(DataBlock datablock) : base(datablock, true)
    {                
    }

    #endregion

    #region public readonly properties

    /// <summary>
    /// Gets the section with the specified key.
    /// </summary>
    /// <value>
    /// Object <see cref="DataSection"/> specified by its key.
    /// </value>
    /// <remarks>
    /// If the element does not exist, <see langword="null"/> is returned.
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

    #region public methods

    /// <summary>
    /// Determines whether the element with the specified key is in the <see cref="EdidDataSectionCollection"/> collection.
    /// </summary>
    /// <param name="valueKey">One of the values of <see cref="EdidSection"/> that represents the key of the object <see cref="DataSection"/> to search</param>
    /// <returns>
    /// <strong>true</strong> if the <see cref="DataSection"/> object with the <strong>valueKey</strong> is in the <see cref="EdidDataSectionCollection"/> collection; otherwise <strong>false</strong>.
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

    /// <summary>
    /// Search for the object with the specified key and return the zero-based index of the first occurrence in the entire <see cref="EdidDataSectionCollection"/> collection.
    /// </summary>
    /// <param name="valueKey">One of the values of <see cref="EdidSection"/> that represents the key of the object to be searched in <see cref="EdidDataSectionCollection"/></param>
    /// <returns>
    /// Zero-base index of the first occurrence of item in the whole of <see cref="EdidDataSectionCollection"/>, if found; otherwise <strong>-1</strong>.
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

    #region private static methods

    /// <summary>
    /// Determines whether the specified key is a valid key of the <see cref="EdidSection"/> enumeration.
    /// </summary>
    /// <param name="value">Key to check</param>
    /// <returns>
    /// <strong>true</strong> if the value belongs to the enumeration <see cref="EdidSection"/>; otherwise <strong>false</strong>.
    /// </returns>
    private static bool IsValidSection(EdidSection value) => SentinelHelper.IsEnumValid(value);

    #endregion
}
