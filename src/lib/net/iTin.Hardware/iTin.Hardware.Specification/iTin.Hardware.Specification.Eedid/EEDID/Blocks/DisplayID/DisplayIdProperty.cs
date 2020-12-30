
namespace iTin.Hardware.Specification.Eedid.Blocks.DisplayId
{
    using System.Collections.Generic;

    using iTin.Core.Hardware.Common;

    using Sections.DataBlocks.ComponentModel;

    /// <summary>
    /// Contains all availables section properties for a <see cref="DisplayIdBlock"/> block.
    /// </summary>
    internal static class DisplayIdProperty
    {

        #region [public] {static} (class) General: Definition of properties for a section of type 'General'
        /// <summary>
        /// Definition of properties for a section of type <see cref="DisplayIdSection.General"/>.
        /// </summary>
        public static class General
        {
            /// <summary>
            /// Definition of properties for a <b>Data</b> section.
            /// </summary>
            public enum Data
            {
                [PropertyName("Display Product")]
                [PropertyDescription("Display Product Type Identifier")]
                [PropertyType(typeof(string))]
                DisplayProduct,

                [PropertyName("Extension Count")]
                [PropertyDescription("Extension Count")]
                [PropertyType(typeof(byte))]
                ExtensionCount
            }

            /// <summary>
            /// Definition of properties for a <b>Version</b> section.
            /// </summary>
            public enum Version
            {
                [PropertyName("Version Number")]
                [PropertyDescription("The Version Number for the DisplayID Block Data Structure")]
                [PropertyType(typeof(byte))]
                Number,

                [PropertyName("Version Revision")]
                [PropertyDescription("The Revision Number for the DisplayID Block Data Structure")]
                [PropertyType(typeof(byte))]
                Revision,
            }
        }
        #endregion

        #region [public] {static} (class) DataBlocks: Definition of properties for a section of type 'Data Blocks'
        /// <summary>
        /// Definition of properties for a section of type <see cref="DisplayIdSection.DataBlocks"/>.
        /// </summary>
        public static class DataBlocks
        {
            /// <summary>
            /// Definition of properties for a <b>Data Blocks</b> section.
            /// </summary>
            public enum Implemented
            {
                [PropertyName("Implemented Blocks")]
                [PropertyDescription("DImplemented Blocks")]
                [PropertyType(typeof(IEnumerable<DataBlockData>))]
                ImplementedBlocks
            }

            /// <summary>
            /// Definition of properties for a known data blocks.
            /// </summary>
            public static class Blocks
            {
                /// <summary>
                /// Definition of properties for a <b>Vendor Specific</b> data block.
                /// </summary>
                public enum VendorSpecific
                {
                    [PropertyName("Vendor-Specific data")]
                    [PropertyDescription("Vendor-Specific data")]
                    [PropertyType(typeof(IEnumerable<byte>))]
                    Data,

                    [PropertyName("Manufacturer")]
                    [PropertyDescription("Manufacturer/Vendor ID")]
                    [PropertyType(typeof(string))]
                    Manufacturer
                }
            }
        }
        #endregion

        #region [public] {static} (class) Miscellaneous: Definition of properties for a section of type 'Miscellaneous'
        /// <summary>
        /// Definition of properties for a section of type <see cref="DisplayIdSection.Miscellaneous"/>.
        /// </summary>
        public static class Miscellaneous
        {
            /// <summary>
            /// Definition of properties for a <b>CheckSum</b> section.
            /// </summary>
            public enum CheckSum
            {
                [PropertyName("Status")]
                [PropertyDescription("Status")]
                [PropertyType(typeof(bool))]
                Ok,

                [PropertyDescription("Checksum datablock value")]
                [PropertyType(typeof(byte))]
                [PropertyName("Value")]
                Value,
            }
        }
        #endregion
    }
}
