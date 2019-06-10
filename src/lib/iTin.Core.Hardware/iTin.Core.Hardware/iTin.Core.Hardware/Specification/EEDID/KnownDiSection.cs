
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Sections correspodientes to a block of type <see cref="DiBlock" />.
    /// </summary> 
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Di")]
    public enum KnownDiSection
    {
        /// <summary>
        /// 
        /// </summary>
        Revision,

        /// <summary>
        /// 
        /// </summary>
        Version,

        /// <summary>
        /// 
        /// </summary>
        CheckSum,
    }
}