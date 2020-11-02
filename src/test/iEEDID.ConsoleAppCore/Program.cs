
namespace iEEDID
{
    using System;

    using iTin.Logging;
    using iTin.Logging.ComponentModel;

    using Code;
    using ComponentModel;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = Constants.AppName;

            ILogger logger = new Logger(Constants.AppName, new ILog[] { new ColoredConsoleLog() }) { Deep = LogDeep.OnlyApplicationCalls, Status = LogStatus.Running };
            logger.Debug(">Start Logging<");

            logger.Info("");
            logger.Info("> Start EEDID Sample 1");
            logger.Info("  · Parse EEDID Information From Current System");
            Sample01.Generate(logger);

            logger.Info("");
            logger.Info("> Start EEDID Sample 2");
            logger.Info("  · Parse EEDID Information From Byte Array Data");
            Sample01.Generate(logger);

            logger.Info("");
            logger.Debug(">End Logging<");

            logger.Info("");
            logger.Info("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
