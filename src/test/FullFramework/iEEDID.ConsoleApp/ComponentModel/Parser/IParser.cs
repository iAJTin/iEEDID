
using iTin.Logging.ComponentModel;

using iTin.Hardware.Specification;

namespace iEEDID.ComponentModel.Parser;

/// <summary>
/// Defines a generic parser for <see cref="EEDID"/> instances.
/// </summary>
internal interface IParser
{
    /// <summary>
    /// Gets or sets the logger to use
    /// </summary>
    /// <value>
    /// A <see cref="ILogger"/> reference.
    /// </value>
    ILogger Logger { get; set; }

    /// <summary>
    /// Parse the <see cref="EEDID"/> given.
    /// </summary>
    /// <param name="instance"><see cref="EEDID"/> instance to parse.</param>
    void Parse(EEDID instance);
}
