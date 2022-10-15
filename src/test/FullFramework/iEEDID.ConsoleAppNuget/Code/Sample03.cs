
namespace iEEDID.Code
{
    using iTin.Logging.ComponentModel;

    using iTin.Hardware.Specification;

    using iEEDID.ComponentModel.Parser;

    /// <summary>
    /// Parse EEDID Information From Current System.
    /// </summary>
    internal class Sample03
    {
        public static void Generate(ILogger logger)
        {
            var parser = new TechParser { Logger = logger };

            EEDID[] instances = EEDID.Instance;
            foreach (var instance in instances)
            {
                parser.Parse(instance);
            }
        }
    }
}
