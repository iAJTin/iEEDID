
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Sections corresponding to a block of type <see cref="LsBlock" />.
    /// </summary>
    [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Ls")]
    public enum KnownLsSection
    {
        /// <summary>
        /// Section Version, For more information see <see cref="VersionLsSection" />.
        /// </summary>
        Version,
    }
}
