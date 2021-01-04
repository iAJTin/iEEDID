
namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId.Sections.DataBlocks.ComponentModel
{
    using iTin.Core.Hardware.Common;

    /// <summary>
    /// Available data blocks.
    /// </summary> 
    public enum DataBlockTag
    {
        /// <summary>
        /// <b>Product Identification</b> data block, for more information see <see cref ="ProductIdentificationDataBlock"/>.
        /// </summary>
        [PropertyType(typeof(ProductIdentificationDataBlock))]
        [PropertyName("Product Identification")]
        [PropertyDescription("Product Identification Data Block")]
        ProductIdentification13 = 0x00,

        ///// <summary>
        ///// <b>Display Parameters</b> data block, for more information see <see cref ="DisplayParametersDataBlock"/>.
        ///// </summary>
        //[PropertyType(typeof(DisplayParametersDataBlock))]
        //[PropertyName("Display Parameters")]
        //[PropertyDescription("Display Parameters Data Block")]
        //DisplayParameters = 0x01,

        ///// <summary>
        ///// <b>Color Characteristics</b> data block, for more information see <see cref ="ColorCharacteristicsDataBlock"/>.
        ///// </summary>
        //[PropertyType(typeof(ColorCharacteristicsDataBlock))]
        //[PropertyName("Color Characteristics")]
        //[PropertyDescription("Color Characteristics Data Block")]
        //ColorCharacteristics = 0x02,

        /// <summary>
        /// <b>Detailed Timing Type I</b> data block, for more information see <see cref ="DetailedTimingTypeIDataBlock"/>.
        /// </summary>
        [PropertyType(typeof(DetailedTimingTypeIDataBlock))]
        [PropertyName("Detailed Timing Type I")]
        [PropertyDescription("Detailed Timing Type I Data Block")]
        DetailedTimingTypeI = 0x03,

        /// <summary>
        /// <b>Product Identification</b> data block, for more information see <see cref ="ProductIdentificationDataBlock"/>.
        /// </summary>
        [PropertyType(typeof(ProductIdentificationDataBlock))]
        [PropertyName("Product Identification")]
        [PropertyDescription("Product Identification Data Block")]
        ProductIdentification = 0x20,

        /// <summary>
        /// <b>Dynamic Video Timing Range Limits</b> data block, for more information see <see cref ="DynamicVideoTimingRangeLimitsDataBlock"/>.
        /// </summary>
        [PropertyType(typeof(DynamicVideoTimingRangeLimitsDataBlock))]
        [PropertyName("Dynamic Video Timing Range Limits")]
        [PropertyDescription("Dynamic Video Timing Range Limits Data Block")]
        DynamicVideoTimingRangeLimits = 0x25,

        /// <summary>
        /// <b>Container ID</b> data block, for more information see <see cref ="ContainerIdDataBlock"/>.
        /// </summary>
        [PropertyType(typeof(ContainerIdDataBlock))]
        [PropertyName("Container ID")]
        [PropertyDescription("Container ID Data Block")]
        ContainerID = 0x29,

        /// <summary>
        /// <b>Vendor-Specific</b> data block, for more information see <see cref ="VendorSpecificDataBlock"/>.
        /// </summary>
        [PropertyType(typeof(VendorSpecificDataBlock))]
        [PropertyName("Vendor-Specific")]
        [PropertyDescription("Vendor-Specific Data Block")]
        VendorSpecific = 0x7f,

        ///// <summary>
        ///// <b>Product Identification</b> data block, for more information see <see cref ="ProductIdentification20DataBlock"/>.
        ///// </summary>
        //[PropertyType(typeof(ProductIdentification20DataBlock))]
        //[PropertyName("Product Identification")]
        //[PropertyDescription("Product Identification Data Block")]
        //ProductIdentification20 = 0x20,

        ///// <summary>
        ///// <b>Display Parameters</b> data block, for more information see <see cref ="DisplayParameters20DataBlock"/>.
        ///// </summary>
        //[PropertyType(typeof(DisplayParameters20DataBlock))]
        //[PropertyName("Display Parameters")]
        //[PropertyDescription("Display Parameters Data Block")]
        //DisplayParameters20 = 0x21,

        ///// <summary>
        ///// <b>Detailed Timing</b> data block, for more information see <see cref ="DetailedTimingDataBlock"/>.
        ///// </summary>
        //[PropertyType(typeof(DetailedTimingDataBlock))]
        //[PropertyName("Detailed Timing")]
        //[PropertyDescription("Detailed Timing Data Block")]
        //DetailedTiming = 0x22,

        ///// <summary>
        ///// <b>Enumerated Timing Code</b> data block, for more information see <see cref ="EnumeratedTimingCodeDataBlock"/>.
        ///// </summary>
        //[PropertyType(typeof(EnumeratedTimingCodeDataBlock))]
        //[PropertyName("Enumerated Timing Code")]
        //[PropertyDescription("Enumerated Timing Code Data Block")]
        //EnumeratedTimingCode = 0x23,

        ///// <summary>
        ///// <b>Enumerated Timing Code</b> data block, for more information see <see cref ="FormulaBasedTimingDataBlock"/>.
        ///// </summary>
        //[PropertyType(typeof(FormulaBasedTimingDataBlock))]
        //[PropertyName("Formula-based Timing")]
        //[PropertyDescription("Formula-based Timing Data Block")]
        //FormulaBasedTiming = 0x24,

        ///// <summary>
        ///// <b>Dynamic Video Timing Range Limits</b> data block, for more information see <see cref ="DynamicVideoTimingRangeLimitsDataBlock"/>.
        ///// </summary>
        //[PropertyType(typeof(DynamicVideoTimingRangeLimitsDataBlock))]
        //[PropertyName("Dynamic Video Timing Range Limits")]
        //[PropertyDescription("Dynamic Video Timing Range Limits Data Block")]
        //DynamicVideoTimingRangeLimits = 0x25,

        ///// <summary>
        ///// <b>Display Interface Features</b> data block, for more information see <see cref ="DisplayInterfaceFeaturesDataBlock"/>.
        ///// </summary>
        //[PropertyType(typeof(DisplayInterfaceFeaturesDataBlock))]
        //[PropertyName("Display Interface Features")]
        //[PropertyDescription("Display Interface Features Data Block")]
        //DisplayInterfaceFeatures = 0x26,

        ///// <summary>
        ///// <b>Stereo Display Interface</b> data block, for more information see <see cref ="StereoDisplayInterfaceDataBlock"/>.
        ///// </summary>
        //[PropertyType(typeof(StereoDisplayInterfaceDataBlock))]
        //[PropertyName("Stereo Display Interface")]
        //[PropertyDescription("Stereo Display Interface Data Block")]
        //StereoDisplayInterface = 0x27,

        ///// <summary>
        ///// <b>Tiled Display Topology</b> data block, for more information see <see cref ="TiledDisplayTopologyDataBlock"/>.
        ///// </summary>
        //[PropertyType(typeof(TiledDisplayTopologyDataBlock))]
        //[PropertyName("Tiled Display Topology")]
        //[PropertyDescription("Tiled Display Topology Data Block")]
        //TiledDisplayTopology = 0x28,

        ///// <summary>
        ///// <b>ContainerID</b> data block, for more information see <see cref ="ContainerIdDataBlock"/>.
        ///// </summary>
        //[PropertyType(typeof(ContainerIdDataBlock))]
        //[PropertyName("ContainerID")]
        //[PropertyDescription("ContainerID Data Block")]
        //ContainerID = 0x29,

        ///// <summary>
        ///// <b>CTA DisplayID</b> data block, for more information see <see cref ="CtaDisplayIdDataBlock"/>.
        ///// </summary>
        //[PropertyType(typeof(CtaDisplayIdDataBlock))]
        //[PropertyName("CTA DisplayID")]
        //[PropertyDescription("CTA DisplayID Data Block")]
        //CTADisplayID = 0x81,
    }
}
