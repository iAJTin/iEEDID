
namespace iEEDID.ComponentModel.Parser
{
    using iTin.Logging.ComponentModel;

    using iTin.Hardware.Specification;
    using iTin.Hardware.Specification.Eedid;
    
    /// <summary>
    /// Specialization of the <see cref="IParser"/> interface.<br/>
    /// Defines a custom parser for <see cref="EEDID"/> instances.
    /// </summary> 
    internal class TechParser : IParser
    {
        /// <summary>
        /// Gets or sets the logger to use
        /// </summary>
        /// <value>
        /// A <see cref="ILogger"/> reference.
        /// </value>
        public ILogger Logger { get; set; }

        /// <summary>
        /// Parse the <see cref="EEDID"/> given.
        /// </summary>
        /// <param name="instance"><see cref="EEDID"/> instance to parse.</param>
        public void Parse(EEDID instance)
        {
            // Prints raw data.
            ParserHelper.PrintsRawData(Logger, instance.GetRawData());

            // Prints blocks.
            DataBlockCollection blocks = instance.Blocks;
            foreach (DataBlock block in blocks)
            {
                ParserHelper.PrintsBlock(Logger, block);
            }
        }
    }
}
