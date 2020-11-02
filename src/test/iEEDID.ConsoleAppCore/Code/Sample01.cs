
namespace iEEDID.Code
{
    using iTin.Logging.ComponentModel;

    using iTin.Hardware.Specification;

    using ComponentModel;

    /// <summary>
    /// Parse EEDID Information From Current System.
    /// </summary>
    internal class Sample01
    {
        public static void Generate(ILogger logger)
        {
            var parser = new Parser { Logger = logger };

            EEDID[] instances = EEDID.Instance;
            foreach (var instance in instances)
            {
                parser.Parse(instance);
            }
        }
    }
}

//logger.Info("");
//logger.Info(@" > Gets A Single Property Directly From Parsed EDID Data");
//EEDID parsed = EEDID.Parse(MacBookPro2018.IntegratedLaptopPanelEdidTable);
//DataBlock edidBlock = parsed.Blocks[KnownDataBlock.EDID];
//BaseDataSectionCollection edidSections = edidBlock.Sections;
//DataSection basicDisplaySection = edidSections[(int)KnownEdidSection.BasicDisplay];
//QueryPropertyResult gammaResult = basicDisplaySection.GetProperty(EedidProperty.Edid.BasicDisplay.Gamma);
//if (gammaResult.Success)
//{
//    logger.Info($@"   > Gamma > {gammaResult.Value.Value}");
//}
