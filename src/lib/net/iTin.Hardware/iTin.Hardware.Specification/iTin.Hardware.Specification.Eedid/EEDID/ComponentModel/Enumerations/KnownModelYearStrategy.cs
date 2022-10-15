
using iTin.Core.Hardware.Common;

namespace iTin.Hardware.Specification.Eedid
{
    /// <summary>
    /// Model strategy for a <c>EDID Block</c> <c>Vendor</c> section.
    /// </summary>
    public enum KnownModelYearStrategy
    {
        /// <summary>
        ///  Year of manufacture strategy
        /// </summary>
        [PropertyName("Year Of Manufacture")]
        [PropertyDescription("Year Of Manufacture")]
        YearOfManufacture,

        /// <summary>
        ///   Model year strategy
        /// </summary>
        [PropertyName("Model Year")]
        [PropertyDescription("Model Year")]
        ModelYear,
    }
}
