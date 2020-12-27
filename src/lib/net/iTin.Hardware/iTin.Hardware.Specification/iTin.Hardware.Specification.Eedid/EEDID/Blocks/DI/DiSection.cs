
namespace iTin.Hardware.Specification.Eedid.Blocks.DI
{
    using iTin.Core.Hardware.Common;

    /// <summary>
    /// Sections correspodientes to a block of type <see cref="DiBlock"/>.
    /// </summary> 
    public enum DiSection
    {
        /// <summary>
        /// General Information 
        /// </summary>
        [PropertyName("General Information")]
        [PropertyDescription("General Information Section")]
        Information,

        /// <summary>
        /// Digital Interface
        /// </summary>
        [PropertyName("Digital Interface")]
        [PropertyDescription("Digital Interface Section")]
        DigitalInterface,

        /// <summary>
        /// Display Device 
        /// </summary>
        [PropertyName("Display Device")]
        [PropertyDescription("Display Device Section")]
        DisplayDevice,

        /// <summary>
        /// Display Capabilities And Feature Support Set  
        /// </summary>
        [PropertyName("Display Capabilities & Feature Support Set")]
        [PropertyDescription("Display Capabilities & Feature Support Set Section")]
        DisplayCapabilitiesAndFeatureSupportSet,

        /// <summary>
        /// Unused Bytes (Reserved)   
        /// </summary>
        [PropertyName("Unused Bytes")]
        [PropertyDescription("Unused Bytes Section")]
        UnusedBytes,

        /// <summary>
        /// Audio Support (Reserved) 
        /// </summary>
        [PropertyName("Audio Support")]
        [PropertyDescription("Audio Support Section")]
        AudioSupport,

        /// <summary>
        /// Display Transfer Characteristic – Gamma
        /// </summary>
        [PropertyName("Display Transfer Characteristic")]
        [PropertyDescription("Display Transfer Characteristic Section")]
        DisplayTransferCharacteristic,

        /// <summary>
        /// Miscellaneous Items
        /// </summary>
        [PropertyName("Miscellaneous")]
        [PropertyDescription("Miscellaneous Section")]
        Miscellaneous
    }
}
