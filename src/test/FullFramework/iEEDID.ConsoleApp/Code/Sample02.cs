﻿
using iTin.Logging.ComponentModel;

using iTin.Hardware.Specification;

using iEEDID.ComponentModel.Parser;

namespace iEEDID.Code;

/// <summary>
/// Parse EEDID Information From Byte Array Data.
/// </summary>
internal class Sample02
{
    public static void Generate(ILogger logger)
    {
        var instance = EEDID.Parse(MacBookPro2018.IntegratedLaptopPanelEdidTable);

        var parser = new RawParser { Logger = logger };
        parser.Parse(instance);
    }


    private class MacBookPro2018
    {
        public static readonly byte[] IntegratedLaptopPanelEdidTable =
        {
            0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00,
            0x1e, 0x6d, 0x07, 0x77, 0x07, 0x23, 0x05, 0x00,
            0x06, 0x1e, 0x01, 0x04, 0xb5, 0x3c, 0x22, 0x78,
            0x9e, 0x3e, 0x31, 0xae, 0x50, 0x47, 0xac, 0x27,
            0x0c, 0x50, 0x54, 0x21, 0x08, 0x00, 0x71, 0x40,
            0x81, 0x80, 0x81, 0xc0, 0xa9, 0xc0, 0xd1, 0xc0,
            0x81, 0x00, 0x01, 0x01, 0x01, 0x01, 0x4d, 0xd0,
            0x00, 0xa0, 0xf0, 0x70, 0x3e, 0x80, 0x30, 0x20,
            0x65, 0x0c, 0x58, 0x54, 0x21, 0x00, 0x00, 0x1a,
            0x28, 0x68, 0x00, 0xa0, 0xf0, 0x70, 0x3e, 0x80,
            0x08, 0x90, 0x65, 0x0c, 0x58, 0x54, 0x21, 0x00,
            0x00, 0x1a, 0x00, 0x00, 0x00, 0xfd, 0x00, 0x38,
            0x3d, 0x1e, 0x87, 0x38, 0x00, 0x0a, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20, 0x00, 0x00, 0x00, 0xfc,
            0x00, 0x4c, 0x47, 0x20, 0x48, 0x44, 0x52, 0x20,
            0x34, 0x4b, 0x0a, 0x20, 0x20, 0x20, 0x01, 0x39,
            0x02, 0x03, 0x19, 0x71, 0x44, 0x90, 0x04, 0x03,
            0x01, 0x23, 0x09, 0x07, 0x07, 0x83, 0x01, 0x00,
            0x00, 0xe3, 0x05, 0xc0, 0x00, 0xe3, 0x06, 0x05,
            0x01, 0x02, 0x3a, 0x80, 0x18, 0x71, 0x38, 0x2d,
            0x40, 0x58, 0x2c, 0x45, 0x00, 0x58, 0x54, 0x21,
            0x00, 0x00, 0x1e, 0x56, 0x5e, 0x00, 0xa0, 0xa0,
            0xa0, 0x29, 0x50, 0x30, 0x20, 0x35, 0x00, 0x58,
            0x54, 0x21, 0x00, 0x00, 0x1a, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x29
        };

        public static readonly byte[] IntegratedLaptopPanelEdidTable2 =
        {
            0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00,
            0x06, 0x10, 0x1d, 0xae, 0x88, 0x54, 0x67, 0xed,
            0x33, 0x1a, 0x01, 0x04, 0xb5, 0x3c, 0x22, 0x78,
            0x20, 0x07, 0x61, 0xae, 0x51, 0x41, 0xb2, 0x26,
            0x0d, 0x50, 0x54, 0x00, 0x00, 0x00, 0x01, 0x01,
            0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01,
            0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x4d, 0xd0,
            0x00, 0xa0, 0xf0, 0x70, 0x3e, 0x80, 0x30, 0x20,
            0x35, 0x00, 0x55, 0x50, 0x21, 0x00, 0x00, 0x1a,
            0x56, 0x5e, 0x00, 0xa0, 0xa0, 0xa0, 0x29, 0x50,
            0x30, 0x20, 0x35, 0x00, 0x55, 0x50, 0x21, 0x00,
            0x00, 0x1a, 0x00, 0x00, 0x00, 0xfc, 0x00, 0x69,
            0x4d, 0x61, 0x63, 0x0a, 0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20, 0x00, 0x00, 0x00, 0xff,
            0x00, 0x37, 0x36, 0x30, 0x42, 0x38, 0x45, 0x33,
            0x38, 0x38, 0x35, 0x34, 0x32, 0x37, 0x01, 0xb4,
            0x02, 0x03, 0x27, 0xc0, 0x23, 0x09, 0x07, 0x07,
            0x83, 0x01, 0x00, 0x00, 0x70, 0xfa, 0x10, 0x00,
            0x00, 0x12, 0x76, 0x31, 0xfc, 0x78, 0xfb, 0xff,
            0x02, 0x10, 0x88, 0x62, 0xd3, 0x69, 0xfa, 0x10,
            0x00, 0xfa, 0xf8, 0xf8, 0xfe, 0xff, 0xff, 0xcd,
            0x91, 0x80, 0xa0, 0xc0, 0x08, 0x34, 0x70, 0x30,
            0x20, 0x35, 0x00, 0x55, 0x50, 0x21, 0x00, 0x00,
            0x1a, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x3e
        };

        public static readonly byte[] IntegratedLaptopPanelEdidTable3 =
        {
            0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00,
            0x06, 0x10, 0x11, 0xae, 0x95, 0x51, 0xf6, 0x61,
            0x0a, 0x1a, 0x01, 0x04, 0xb5, 0x3c, 0x22, 0x78,
            0x20, 0x0f, 0x35, 0xae, 0x52, 0x43, 0xb0, 0x26,
            0x0d, 0x4f, 0x54, 0x00, 0x00, 0x00, 0x01, 0x01,
            0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01,
            0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x4d, 0xd0,
            0x00, 0xa0, 0xf0, 0x70, 0x3e, 0x80, 0x30, 0x20,
            0x35, 0x00, 0x55, 0x50, 0x21, 0x00, 0x00, 0x1a,
            0x56, 0x5e, 0x00, 0xa0, 0xa0, 0xa0, 0x29, 0x50,
            0x30, 0x20, 0x35, 0x00, 0x55, 0x50, 0x21, 0x00,
            0x00, 0x1a, 0x00, 0x00, 0x00, 0xfc, 0x00, 0x69,
            0x4d, 0x61, 0x63, 0x0a, 0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20, 0x00, 0x00, 0x00, 0xff,
            0x00, 0x37, 0x39, 0x30, 0x38, 0x35, 0x34, 0x46,
            0x39, 0x35, 0x35, 0x31, 0x33, 0x36, 0x01, 0x0d,
            0x02, 0x03, 0x27, 0xc0, 0x23, 0x09, 0x07, 0x07,
            0x83, 0x01, 0x00, 0x00, 0x70, 0xfa, 0x10, 0x00,
            0x00, 0x12, 0x76, 0x31, 0xfc, 0x78, 0xfb, 0xff,
            0x02, 0x10, 0x88, 0x62, 0xd3, 0x69, 0xfa, 0x10,
            0x00, 0xfa, 0xf8, 0xf8, 0xfe, 0xff, 0xff, 0xcd,
            0x91, 0x80, 0xa0, 0xc0, 0x08, 0x34, 0x70, 0x30,
            0x20, 0x35, 0x00, 0x55, 0x50, 0x21, 0x00, 0x00,
            0x1a, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x3e
        };
    }
}
