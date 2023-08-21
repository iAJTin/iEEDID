
using iTin.Logging.ComponentModel;

using iTin.Hardware.Specification;

using iEEDID.ComponentModel.Parser;

namespace iEEDID.Code;

/// <summary>
/// Parse EEDID Information From Current System.
/// </summary>
internal class Sample01
{
    public static void Generate(ILogger logger)
    {
        var parser = new RawParser { Logger = logger };

        EEDID[] instances = EEDID.Instance;
        foreach (var instance in instances)
        {
            parser.Parse(instance);
        }
    }
}
