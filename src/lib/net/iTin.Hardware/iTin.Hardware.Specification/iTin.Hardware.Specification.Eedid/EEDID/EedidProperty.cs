
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;

    using iTin.Core.Hardware.Common;

    using Blocks.CEA;
    using Blocks.DI;
    using Blocks.DisplayId;
    using Blocks.DisplayId.Sections.DataBlocks.ComponentModel;
    using Blocks.EDID;
    using Blocks.EDID.Sections.Descriptors;

    /// <summary>
    /// Definition of available keys for the <see cref="EEDID"/> specification of a monitor.
    /// </summary>
    public static class EedidProperty
    {
        #region [public] {static} (class) Edid: Definition of keys in the 'EDID' block
        /// <summary>
        /// Definition of keys in the <see cref="KnownDataBlock.EDID"/> block.
        /// </summary>
        public static class Edid
        {
            #region [public] {static} (class) Header: Definition of keys in the 'Header' section
            /// <summary>
            /// Definition of keys in the <see cref="EdidSection.Header"/> section.
            /// </summary>
            public static class Header
            {
                #region [public] {static} (IPropertyKey) Signature: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Contains the <b>EDID</b> header signature.<br/>
                /// Always returns (00 FF FF FF FF FF FF 00).
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.Header"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.Header.Signature"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Signature => new PropertyKey(EdidSection.Header, EdidProperty.Header.Signature);
                #endregion

                #region [public] {static} (IPropertyKey) IsValid: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if is a <see cref="EEDID"/> valid.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.Header"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.Header.IsValid"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsValid => new PropertyKey(EdidSection.Header, EdidProperty.Header.IsValid);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Vendor: Definition of keys in the 'Vendor and Product' section
            /// <summary>
            /// Definition of keys in the <see cref="EdidSection.Vendor"/> section.
            /// </summary>
            public static class Vendor
            {
                #region [public] {static} (IPropertyKey) IdManufacturerName: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// The ID manufacturer’s name.<br/>
                /// These codes are also called the ISA (Industry Standard Architecture) Plug and Play Device Identifier (PNPID).<br/>
                /// ISA Manufacturer PNPIDs are issued by Microsoft.<br/>
                /// For more information, please see http://www.microsoft.com/whdc/system/pnppwr/pnp/pnpid.mspx.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.Vendor"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.Vendor.IdManufacturerName"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey IdManufacturerName => new PropertyKey(EdidSection.Vendor, EdidProperty.Vendor.IdManufacturerName);
                #endregion

                #region [public] {static} (IPropertyKey) IdProductCode: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Vendor assigned code.<br/>
                /// This is used to differentiate between different models from the same manufacturer.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.Vendor"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.Vendor.IdProductCode"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="int"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey IdProductCode => new PropertyKey(EdidSection.Vendor, EdidProperty.Vendor.IdProductCode);
                #endregion

                #region [public] {static} (IPropertyKey) IdSerialNumber: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Contains a 32-bit serial number.<br/>
                /// The ID serial number is a 32-bit serial number used to differentiate between individual instances of the same display model.<br/>
                /// Its use is optional.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.Vendor"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.Vendor.IdSerialNumber"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="Nullable{T}"/> where <b>T</b> is <see cref="int"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey IdSerialNumber => new PropertyKey(EdidSection.Vendor, EdidProperty.Vendor.IdSerialNumber);
                #endregion

                #region [public] {static} (IPropertyKey) WeekOfManufactureOrModelYear: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Contains a week number or model year.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.Vendor"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.Vendor.WeekOfManufactureOrModelYear"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="Nullable{T}"/> where <b>T</b> is <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey WeekOfManufactureOrModelYear => new PropertyKey(EdidSection.Vendor, EdidProperty.Vendor.WeekOfManufactureOrModelYear);
                #endregion

                #region [public] {static} (IPropertyKey) YearOfManufactureOrModelYear: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Contains the manufacture year or model year.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.Vendor"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.Vendor.YearOfManufactureOrModelYear"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="Nullable{T}"/> where <b>T</b> is <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey YearOfManufactureOrModelYear => new PropertyKey(EdidSection.Vendor, EdidProperty.Vendor.YearOfManufactureOrModelYear);
                #endregion

                #region [public] {static} (IPropertyKey) ManufactureDate: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// The manufacuture data.<br/>
                /// See <see cref="ModelYearStrategy"/> property for known the strategy used.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.Vendor"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.Vendor.ManufactureDate"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ManufactureDate => new PropertyKey(EdidSection.Vendor, EdidProperty.Vendor.ManufactureDate);
                #endregion

                #region [public] {static} (IPropertyKey) ModelYearStrategy: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Returns a value indicating the strategy used for model year data.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.Vendor"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.Vendor.ModelYearStrategy"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="KnownModelYearStrategy"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ModelYearStrategy => new PropertyKey(EdidSection.Vendor, EdidProperty.Vendor.ModelYearStrategy);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Version: Definition of keys in the 'Version and Revision' section
            /// <summary>
            /// Definition of keys in the <see cref="EdidSection.Version"/> section.
            /// </summary>
            public static class Version
            {
                #region [public] {static} (IPropertyKey) Number: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Implemented version number.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.Version"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.Version.Number"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Number => new PropertyKey(EdidSection.Version, EdidProperty.Version.Number);
                #endregion

                #region [public] {static} (IPropertyKey) Revision: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Implemented revision number.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.Version"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.Version.Revision"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Revision => new PropertyKey(EdidSection.Version, EdidProperty.Version.Revision);
                #endregion
            }
            #endregion

            #region [public] {static} (class) BasicDisplay: Definition of keys in the 'Basic Display Parameters and Features' section
            /// <summary>
            /// Definition of keys in the <see cref="EdidSection.BasicDisplay"/> section.
            /// </summary>
            public static class BasicDisplay
            {
                #region public readonly properties

                #region [public] {static} (IPropertyKey) VideoInputDefinition: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Video Signal Interface.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.VideoInputDefinition"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey VideoInputDefinition => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.VideoInputDefinition);
                #endregion

                #region [public] {static} (IPropertyKey) HorizontalScreenSize: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Horizontal screen size.<br/>
                /// This value is measured in <see cref="PropertyUnit.cm"/>.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.HorizontalScreenSize"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.cm"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey HorizontalScreenSize => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.HorizontalScreenSize, PropertyUnit.cm);
                #endregion

                #region [public] {static} (IPropertyKey) VerticalScreenSize: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Vertical screen size.<br/>
                /// This value is measured in <see cref="PropertyUnit.cm"/>.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.VerticalScreenSize"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.cm"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey VerticalScreenSize => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.VerticalScreenSize, PropertyUnit.cm);
                #endregion

                #region [public] {static} (IPropertyKey) Gamma: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// The display transfer characteristic, referred to as <b>GAMMA</b>,<br/>
                /// The values in the range of 1.00 to 3.54 or it may be stored (using a transfer characteristic curve) in an optional extension block.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.Gamma"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="double"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Gamma => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.Gamma);
                #endregion

                #endregion


                #region nested classes

                #region [public] {static} (class) Analog: Definition of keys in the 'Analog' section
                /// <summary>
                /// Definition of keys in the <b>Analog</b> section.
                /// </summary>
                public static class Analog
                {
                    #region public readonly properties

                    #region [public] {static} (IPropertyKey) SignalLevelStandard: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Signal level standard.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                    ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.AnalogSignalLevelStandard"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="string"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey SignalLevelStandard => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.AnalogSignalLevelStandard);
                    #endregion

                    #region [public] {static} (IPropertyKey) VideoSetup: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Video setup. Blank level.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                    ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.AnalogVideoSetup"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="string"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey VideoSetup => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.AnalogVideoSetup);
                    #endregion

                    #region [public] {static} (IPropertyKey) VerticalSyncSupported: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Indicates if vertical synchronization is supported.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                    ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.AnalogVerticalSyncSupported"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey VerticalSyncSupported => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.AnalogVerticalSyncSupported);
                    #endregion

                    #region [public] {static} (IPropertyKey) DisplayColorType: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Analog display color type.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                    ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.AnalogDisplayColorType"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="string"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey DisplayColorType => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.AnalogDisplayColorType);
                    #endregion

                    #endregion


                    #region nested classes

                    #region [public] {static} (class) Syncrhonization: Definition of keys in the 'Syncrhonization Types' section
                    /// <summary>
                    /// Definition of keys in the <b>Syncrhonization Types</b> section.
                    /// </summary>
                    public static class Syncrhonization
                    {
                        #region [public] {static} (IPropertyKey) SeparateSyncSupported: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if vertical and horizontal signals separate are supported.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.AnalogSeparateSyncSupported"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey SeparateSyncSupported => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.AnalogSeparateSyncSupported);
                        #endregion

                        #region [public] {static} (IPropertyKey) CompositeSyncSignalHorizontalSupported: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if composite synchronization signal on horizontal is supported.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.AnalogCompositeSyncSignalHorizontalSupported"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey CompositeSyncSignalHorizontalSupported => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.AnalogCompositeSyncSignalHorizontalSupported);
                        #endregion

                        #region [public] {static} (IPropertyKey) CompositeSyncSignalGreenVideoSupported: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if composite synchronization signal on green video is supported.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.AnalogCompositeSyncSignalGreenVideoSupported"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey CompositeSyncSignalGreenVideoSupported => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.AnalogCompositeSyncSignalGreenVideoSupported);
                        #endregion
                    }
                    #endregion

                    #endregion
                }
                #endregion

                #region [public] {static} (class) Digital: Definition of keys in the 'Digital' section
                /// <summary>
                /// Definition of keys in the <b>Digital</b> section.
                /// </summary>
                public static class Digital
                {
                    #region [public] {static} (IPropertyKey) ColorBitDepth: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Color bit depth.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                    ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.DigitalColorBitDepth"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="string"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey ColorBitDepth => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.DigitalColorBitDepth);
                    #endregion

                    #region [public] {static} (IPropertyKey) VideoInterface: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Returns a <see cref="string"/> value indicating if is a digital or analog video interface.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                    ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.DigitalVideoInterface"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="string"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey VideoInterface => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.DigitalVideoInterface);
                    #endregion

                    #region [public] {static} (IPropertyKey) ColorEncodingFormat: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Supported color encoding format.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                    ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.DigitalColorEncodingFormat"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="string"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey ColorEncodingFormat => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.DigitalColorEncodingFormat);
                    #endregion
                }
                #endregion

                #region [public] {static} (class) Features: Definition of keys in the 'Features' section
                /// <summary>
                /// Definition of keys in the <b>Features</b> section.
                /// </summary>
                public static class Features
                {
                    #region [public] {static} (class) Other: Definición de claves de la sección 'Other Features'
                    /// <summary>
                    /// Definición de claves de la sección <b>Other Features</b>.
                    /// </summary>
                    public static class Other
                    {
                        #region [public] {static} (IPropertyKey) IsSrgbDefaultColorSpace: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if sRGB Standard is the default color space.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.SrgbDefaultColorSpace"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey IsSrgbDefaultColorSpace => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.SrgbDefaultColorSpace);
                        #endregion

                        #region [public] {static} (IPropertyKey) IncludePreferredTimingMode: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if preferred timing Mmde includes the native pixel format and preferred refresh rate of the display device.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.PreferredTimingMode"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey IncludePreferredTimingMode => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.PreferredTimingMode);
                        #endregion

                        #region [public] {static} (IPropertyKey) IsContinuousFrequency: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if display is continuous frequency.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.ContinuousFrequency"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey IsContinuousFrequency => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.ContinuousFrequency);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DisplayPowerManagement: Definición de claves de la sección 'Display Power Management'
                    /// <summary>
                    /// Definition of keys in the <b>Display Power Management</b> section.
                    /// </summary>
                    public static class DisplayPowerManagement
                    {
                        #region [public] {static} (IPropertyKey) StandbyModeSupported: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if standby mode is supported.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.StandbyModeSupported"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey StandbyModeSupported => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.StandbyModeSupported);
                        #endregion

                        #region [public] {static} (IPropertyKey) SuspendModeSupported: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if suspend mode is supported.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.SuspendModeSupported"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey SuspendModeSupported => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.SuspendModeSupported);
                        #endregion

                        #region [public] {static} (IPropertyKey) ActiveOffSupported: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if very low power is supported.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.BasicDisplay.ActiveOffSupported"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey ActiveOffSupported => new PropertyKey(EdidSection.BasicDisplay, EdidProperty.BasicDisplay.ActiveOffSupported);
                        #endregion
                    }
                    #endregion
                }
                #endregion

                #endregion
            }
            #endregion

            #region [public] {static} (class) ColorCharacteristics: Definition of keys in the 'Color Characteristics' section
            /// <summary>
            /// Definition of keys in the <see cref="EdidSection.ColorCharacteristics"/> section.
            /// </summary>
            public static class ColorCharacteristics
            {
                #region [public] {static} (IPropertyKey) Red: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Red chromaticity point.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.ColorCharacteristics"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.ColorCharacteristics.Red"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="PointF"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Red => new PropertyKey(EdidSection.ColorCharacteristics, EdidProperty.ColorCharacteristics.Red);
                #endregion

                #region [public] {static} (IPropertyKey) Green: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Green chromaticity point.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.ColorCharacteristics"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.ColorCharacteristics.Green"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="PointF"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Green => new PropertyKey(EdidSection.ColorCharacteristics, EdidProperty.ColorCharacteristics.Green);
                #endregion

                #region [public] {static} (IPropertyKey) Blue: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Blue chromaticity point.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.ColorCharacteristics"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.ColorCharacteristics.Blue"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="PointF"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Blue => new PropertyKey(EdidSection.ColorCharacteristics, EdidProperty.ColorCharacteristics.Blue);
                #endregion

                #region [public] {static} (IPropertyKey) White: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>White chromaticity point.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.ColorCharacteristics"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.ColorCharacteristics.White"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="PointF"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey White => new PropertyKey(EdidSection.ColorCharacteristics, EdidProperty.ColorCharacteristics.White);
                #endregion
            }
            #endregion

            #region [public] {static} (class) EstablishedTimings: Definition of keys in the 'Established Timings I, II' section
            /// <summary>
            /// Definition of keys in the <see cref="EdidSection.EstablishedTimings"/> section.
            /// </summary>
            public static class EstablishedTimings
            {
                #region [public] {static} (IPropertyKey) Resolutions: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Supported resolutions collection for established timmings.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.EstablishedTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.EstablishedTimings.Resolutions"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="MonitorResolutionInfo"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Resolutions => new PropertyKey(EdidSection.EstablishedTimings, EdidProperty.EstablishedTimings.Resolutions);
                #endregion
            }
            #endregion

            #region [public] {static} (class) StandardTimings: Definition of keys in the 'Standard Timings 16 Bytes' section
            /// <summary>
            /// Definition of keys in the <see cref="EdidSection.StandardTimings"/> section.
            /// </summary>
            public static class StandardTimings
            {
                #region [public] {static} (IPropertyKey) Timing1: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.StandardTiming.Timing1"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Timing1 => new PropertyKey(EdidSection.StandardTimings, EdidProperty.StandardTiming.Timing1);
                #endregion

                #region [public] {static} (IPropertyKey) Timing2: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.StandardTiming.Timing2"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Timing2 => new PropertyKey(EdidSection.StandardTimings, EdidProperty.StandardTiming.Timing2);
                #endregion

                #region [public] {static} (IPropertyKey) Timing3: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.StandardTiming.Timing3"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Timing3 => new PropertyKey(EdidSection.StandardTimings, EdidProperty.StandardTiming.Timing3);
                #endregion

                #region [public] {static} (IPropertyKey) Timing4: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.StandardTiming.Timing4"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Timing4 => new PropertyKey(EdidSection.StandardTimings, EdidProperty.StandardTiming.Timing4);
                #endregion

                #region [public] {static} (IPropertyKey) Timing5: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.StandardTiming.Timing5"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Timing5 => new PropertyKey(EdidSection.StandardTimings, EdidProperty.StandardTiming.Timing5);
                #endregion

                #region [public] {static} (IPropertyKey) Timing6: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.StandardTiming.Timing6"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Timing6 => new PropertyKey(EdidSection.StandardTimings, EdidProperty.StandardTiming.Timing6);
                #endregion

                #region [public] {static} (IPropertyKey) Timing7: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.StandardTiming.Timing7"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Timing7 => new PropertyKey(EdidSection.StandardTimings, EdidProperty.StandardTiming.Timing7);
                #endregion

                #region [public] {static} (IPropertyKey) Timing8: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.StandardTiming.Timing8"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Timing8 => new PropertyKey(EdidSection.StandardTimings, EdidProperty.StandardTiming.Timing8);
                #endregion
            }
            #endregion

            #region [public] {static} (class) DataBlock: Definition of keys in the '18 Byte Data Blocks Descriptors' section
            /// <summary>
            /// Definition of keys in the <see cref="EdidSection.DataBlocks"/> section.
            /// </summary>
            public static class DataBlock
            {
                #region public readonly properties

                #region [public] {static} (IPropertyKey) Descriptor1: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>DataBlock definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.DataBlock.Descriptor1"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                /// <para>Type: <see cref="KeyValuePair{TKey, TValue}"/> where <b>TKey</b> is <see cref="PropertyKey"/>, <b>TValue</b> is <see cref="ReadOnlyCollection{T}"/> and <b>T</b> is <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Descriptor1 => new PropertyKey(EdidSection.DataBlocks, EdidProperty.DataBlock.Descriptor1);
                #endregion

                #region [public] {static} (IPropertyKey) Descriptor2: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>DataBlock definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.DataBlock.Descriptor2"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                /// <para>Type: <see cref="KeyValuePair{TKey, TValue}"/> where <b>TKey</b> is <see cref="PropertyKey"/>, <b>TValue</b> is <see cref="ReadOnlyCollection{T}"/> and <b>T</b> is <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Descriptor2 => new PropertyKey(EdidSection.DataBlocks, EdidProperty.DataBlock.Descriptor2);
                #endregion

                #region [public] {static} (IPropertyKey) Descriptor3: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>DataBlock definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.DataBlock.Descriptor3"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                /// <para>Type: <see cref="KeyValuePair{TKey, TValue}"/> where <b>TKey</b> is <see cref="PropertyKey"/>, <b>TValue</b> is <see cref="ReadOnlyCollection{T}"/> and <b>T</b> is <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Descriptor3 => new PropertyKey(EdidSection.DataBlocks, EdidProperty.DataBlock.Descriptor3);
                #endregion

                #region [public] {static} (IPropertyKey) Descriptor4: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>DataBlock definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.DataBlock.Descriptor4"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                /// <para>Type: <see cref="KeyValuePair{TKey, TValue}"/> where <b>TKey</b> is <see cref="PropertyKey"/>, <b>TValue</b> is <see cref="ReadOnlyCollection{T}"/> and <b>T</b> is <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Descriptor4 => new PropertyKey(EdidSection.DataBlocks, EdidProperty.DataBlock.Descriptor4);
                #endregion

                #endregion


                #region nested classes

                #region [public] {static} (class) Definition: Definition of keys in the 'DataBlocks'.
                /// <summary>
                /// Definition of keys in the <see cref="EdidSection.DataBlocks"/>.
                /// </summary>
                public static class Definition
                {
                    #region [public] {static} (class) AlphanumericDataString: Definition of keys in the 'DataBlocks' of 'AlphaNumericDataString' type
                    /// <summary>
                    /// Definition of keys in the <b>DataBlock</b> of <see cref="EdidDataBlockDescriptor.AlphaNumericDataString" /> type.
                    /// </summary>
                    public static class AlphanumericDataString
                    {
                        #region [public] {static} (IPropertyKey) Data: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Represents alphanumeric datablock descriptor text.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.AlphaNumericDataString"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.AlphanumericDataStringDescriptor.Text"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="string"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Data => new PropertyKey(EdidDataBlockDescriptor.AlphaNumericDataString, EdidProperty.DataBlocks.Descriptors.AlphanumericDataStringDescriptor.Text);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) ColorManagementData: Definition of keys in the 'DataBlocks' of 'ColorManagementData' type
                    /// <summary>
                    /// Definition of keys in the <b>DataBlock</b> of <see cref="EdidDataBlockDescriptor.ColorManagementData" /> type.
                    /// </summary>
                    public static class ColorManagementData
                    {
                        #region public readonly properties

                        #region [public] {static} (IPropertyKey) VersionNumber: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Version Number.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.ColorManagementDataDescriptor.Version"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="byte"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey VersionNumber => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, EdidProperty.DataBlocks.Descriptors.ColorManagementDataDescriptor.Version);
                        #endregion

                        #region [public] {static} (IPropertyKey) Red: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains the display color management polynomial coefficient.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.ColorManagementDataDescriptor.Red"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="ColorManagementDataDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Red => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, EdidProperty.DataBlocks.Descriptors.ColorManagementDataDescriptor.Red);
                        #endregion

                        #region [public] {static} (IPropertyKey) Green: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains the display color management polynomial coefficient.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.ColorManagementDataDescriptor.Green"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="ColorManagementDataDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Green => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, EdidProperty.DataBlocks.Descriptors.ColorManagementDataDescriptor.Green);
                        #endregion

                        #region [public] {static} (IPropertyKey) Blue: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains the display color management polynomial coefficient.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.ColorManagementDataDescriptor.Blue"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="ColorManagementDataDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Blue => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, EdidProperty.DataBlocks.Descriptors.ColorManagementDataDescriptor.Blue);
                        #endregion

                        #endregion


                        #region nested classes
                        /// <summary>
                        /// Definition of keys for an element of a block of type <see cref="EdidDataBlockDescriptor.ColorManagementData"/>.
                        /// </summary>
                        public static class Item
                        {
                            #region [public] {static} (IPropertyKey) A2: Gets a value representing the key to retrieve the property value
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property value.</para>
                            /// <para>Contains the least significant byte.</para>
                            /// <para>
                            ///  <para><b>Key Composition</b></para>
                            ///  <list type="bullet">
                            ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></description></item>
                            ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DescriptorItems.ColorManagementDataDescriptorItem.A2"/></description></item>
                            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                            ///  </list>
                            /// </para>
                            /// <para>
                            ///  <para><b>Return Value</b></para>
                            /// <para>Type: <see cref="int"/>.</para>
                            /// </para>
                            /// <para>
                            ///  <para><b>Remarks</b></para>
                            ///  <para>1.4</para>
                            /// </para>
                            /// </summary>
                            public static IPropertyKey A2 => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, EdidProperty.DataBlocks.Descriptors.DescriptorItems.ColorManagementDataDescriptorItem.A2);
                            #endregion

                            #region [public] {static} (IPropertyKey) A3: Gets a value representing the key to retrieve the property value
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property value.</para>
                            /// <para>Contains the most significant byte.</para>
                            /// <para>
                            ///  <para><b>Key Composition</b></para>
                            ///  <list type="bullet">
                            ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></description></item>
                            ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DescriptorItems.ColorManagementDataDescriptorItem.A3"/></description></item>
                            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                            ///  </list>
                            /// </para>
                            /// <para>
                            ///  <para><b>Return Value</b></para>
                            /// <para>Type: <see cref="int"/>.</para>
                            /// </para>
                            /// <para>
                            ///  <para><b>Remarks</b></para>
                            ///  <para>1.4</para>
                            /// </para>
                            /// </summary>
                            public static IPropertyKey A3 => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, EdidProperty.DataBlocks.Descriptors.DescriptorItems.ColorManagementDataDescriptorItem.A3);
                            #endregion
                        }
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) ColorPointData: Definition of keys in the 'DataBlocks' of 'ColorPointData' type
                    /// <summary>
                    /// Definition of keys in the <b>DataBlock</b> of <see cref="EdidDataBlockDescriptor.ColorPointData" /> type.
                    /// </summary>
                    public static class ColorPointData
                    {
                        #region public readonly properties

                        #region [public] {static} (IPropertyKey) Point1: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains the additional point descriptor information.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorPointData"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.ColorPointDataDescriptor.Point1"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="ColorPointDataDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Point1 => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, EdidProperty.DataBlocks.Descriptors.ColorPointDataDescriptor.Point1);
                        #endregion

                        #region [public] {static} (IPropertyKey) Point2: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains the additional point descriptor information.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorPointData"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.ColorPointDataDescriptor.Point2"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="ColorPointDataDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Point2 => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, EdidProperty.DataBlocks.Descriptors.ColorPointDataDescriptor.Point2);
                        #endregion

                        #endregion


                        #region nested classes

                        #region [public] {static} (class) Item: Definition of keys for an element of a block of type 'ColorPointData'
                        /// <summary>
                        /// Definition of keys for an element of a block of type <see cref="EdidDataBlockDescriptor.ColorPointData"/>.
                        /// </summary>
                        public static class Item
                        {
                            #region [public] {static} (IPropertyKey) Index: Gets a value representing the key to retrieve the property value
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property value.</para>
                            /// <para>White point index number.</para>
                            /// <para>
                            ///  <para><b>Key Composition</b></para>
                            ///  <list type="bullet">
                            ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorPointData"/></description></item>
                            ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DescriptorItems.ColorPointDataDescriptorItem.Index"/></description></item>
                            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                            ///  </list>
                            /// </para>
                            /// <para>
                            ///  <para><b>Return Value</b></para>
                            /// <para>Type: <see cref="byte"/>.</para>
                            /// </para>
                            /// <para>
                            ///  <para><b>Remarks</b></para>
                            ///  <para>1.4</para>
                            /// </para>
                            /// </summary>
                            public static IPropertyKey Index => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, EdidProperty.DataBlocks.Descriptors.DescriptorItems.ColorPointDataDescriptorItem.Index);
                            #endregion

                            #region [public] {static} (IPropertyKey) White: Gets a value representing the key to retrieve the property value
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property value.</para>
                            /// <para>White point values.</para>
                            /// <para>
                            ///  <para><b>Key Composition</b></para>
                            ///  <list type="bullet">
                            ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorPointData"/></description></item>
                            ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DescriptorItems.ColorPointDataDescriptorItem.White"/></description></item>
                            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                            ///  </list>
                            /// </para>
                            /// <para>
                            ///  <para><b>Return Value</b></para>
                            /// <para>Type: <see cref="PointF"/>.</para>
                            /// </para>
                            /// <para>
                            ///  <para><b>Remarks</b></para>
                            ///  <para>1.4</para>
                            /// </para>
                            /// </summary>
                            public static IPropertyKey White => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, EdidProperty.DataBlocks.Descriptors.DescriptorItems.ColorPointDataDescriptorItem.White);
                            #endregion

                            #region [public] {static} (IPropertyKey) Gamma: Gets a value representing the key to retrieve the property value
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property value.</para>
                            /// <para>Gamma value.</para>
                            /// <para>
                            ///  <para><b>Key Composition</b></para>
                            ///  <list type="bullet">
                            ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorPointData"/></description></item>
                            ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DescriptorItems.ColorPointDataDescriptorItem.Gamma"/></description></item>
                            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                            ///  </list>
                            /// </para>
                            /// <para>
                            ///  <para><b>Return Value</b></para>
                            /// <para>Type: <see cref="Nullable{T}"/> where <b>T</b> is <see cref="double"/>.</para>
                            /// </para>
                            /// <para>
                            ///  <para><b>Remarks</b></para>
                            ///  <para>1.4</para>
                            /// </para>
                            /// </summary>
                            public static IPropertyKey Gamma => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, EdidProperty.DataBlocks.Descriptors.DescriptorItems.ColorPointDataDescriptorItem.Gamma);
                            #endregion
                        }
                        #endregion

                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) Cvt3ByteCode: Definition of keys in the 'DataBlocks' of 'Cvt3ByteCode' type
                    /// <summary>
                    /// Definition of keys in the <b>DataBlock</b> of <see cref="EdidDataBlockDescriptor.Cvt3ByteCode" /> type.
                    /// </summary>
                    public static class Cvt3ByteCode
                    {
                        #region public readonly properties

                        #region [public] {static} (IPropertyKey) VersionNumber: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Version number.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.Cvt3ByteCodeDescriptor.Version"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="byte"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey VersionNumber => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, EdidProperty.DataBlocks.Descriptors.Cvt3ByteCodeDescriptor.Version);
                        #endregion

                        #region [public] {static} (IPropertyKey) Priority1: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains CVT descriptor.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.Cvt3ByteCodeDescriptor.Priority1"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="Cvt3ByteCodeDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Priority1 => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, EdidProperty.DataBlocks.Descriptors.Cvt3ByteCodeDescriptor.Priority1);
                        #endregion

                        #region [public] {static} (IPropertyKey) Priority2: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains CVT descriptor.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.Cvt3ByteCodeDescriptor.Priority2"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="Cvt3ByteCodeDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Priority2 => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, EdidProperty.DataBlocks.Descriptors.Cvt3ByteCodeDescriptor.Priority2);
                        #endregion

                        #region [public] {static} (IPropertyKey) Priority3: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains CVT descriptor.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.Cvt3ByteCodeDescriptor.Priority3"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="Cvt3ByteCodeDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Priority3 => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, EdidProperty.DataBlocks.Descriptors.Cvt3ByteCodeDescriptor.Priority3);
                        #endregion

                        #region [public] {static} (IPropertyKey) Priority4: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains CVT descriptor.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.Cvt3ByteCodeDescriptor.Priority4"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="Cvt3ByteCodeDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Priority4 => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, EdidProperty.DataBlocks.Descriptors.Cvt3ByteCodeDescriptor.Priority4);
                        #endregion

                        #endregion


                        #region nested classes
                        /// <summary>
                        /// Definition of keys for an element of a block of type <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/>.
                        /// </summary>
                        public static class Item
                        {
                            #region public readonly properties

                            #region [public] {static} (IPropertyKey) AddressableVerticalLines: Gets a value representing the key to retrieve the property value
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property value.</para>
                            /// <para>
                            /// Number of addresable lines.<br/>
                            /// This value is measured in <see cref="PropertyUnit.Lines"/>.
                            /// </para>
                            /// <para>
                            ///  <para><b>Key Composition</b></para>
                            ///  <list type="bullet">
                            ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                            ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.AddressableVerticalLines"/></description></item>
                            ///   <item><description>Unit: <see cref="PropertyUnit.Lines"/></description></item>
                            ///  </list>
                            /// </para>
                            /// <para>
                            ///  <para><b>Return Value</b></para>
                            /// <para>Type: <see cref="int"/>.</para>
                            /// </para>
                            /// <para>
                            ///  <para><b>Remarks</b></para>
                            ///  <para>1.4</para>
                            /// </para>
                            /// </summary>
                            public static IPropertyKey AddressableVerticalLines => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.AddressableVerticalLines, PropertyUnit.Lines);
                            #endregion

                            #region [public] {static} (IPropertyKey) AspectRatio: Gets a value representing the key to retrieve the property value
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property value.</para>
                            /// <para>Aspect ratio value.</para>
                            /// <para>
                            ///  <para><b>Key Composition</b></para>
                            ///  <list type="bullet">
                            ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                            ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.AspectRatio"/></description></item>
                            ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                            ///  </list>
                            /// </para>
                            /// <para>
                            ///  <para><b>Return Value</b></para>
                            /// <para>Type: <see cref="string"/>.</para>
                            /// </para>
                            /// <para>
                            ///  <para><b>Remarks</b></para>
                            ///  <para>1.4</para>
                            /// </para>
                            /// </summary>
                            public static IPropertyKey AspectRatio => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.AspectRatio);
                            #endregion

                            #region [public] {static} (IPropertyKey) PreferredVerticalRate: Gets a value representing the key to retrieve the property value
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property value.</para>
                            /// <para>
                            /// Preferred vertical rate value.<br/>
                            /// This value is measured in <see cref="PropertyUnit.Hz"/>.
                            /// </para>
                            /// <para>
                            ///  <para><b>Key Composition</b></para>
                            ///  <list type="bullet">
                            ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                            ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.PreferredVerticalRate"/></description></item>
                            ///   <item><description>Unit: <see cref="PropertyUnit.Hz"/></description></item>
                            ///  </list>
                            /// </para>
                            /// <para>
                            ///  <para><b>Return Value</b></para>
                            /// <para>Type: <see cref="byte"/>.</para>
                            /// </para>
                            /// <para>
                            ///  <para><b>Remarks</b></para>
                            ///  <para>1.4</para>
                            /// </para>
                            /// </summary>
                            public static IPropertyKey PreferredVerticalRate => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.PreferredVerticalRate, PropertyUnit.Hz);
                            #endregion

                            #endregion


                            #region nested classes

                            #region [public] {static} (class) SupportedVerticalRateAndBlanking:  Definition of keys for 'Supported Vertical Rate And Blanking Style' section
                            /// <summary>
                            /// Definition of keys for <b>Supported Vertical Rate And Blanking Style</b> section.
                            /// </summary>
                            public static class SupportedVerticalRateAndBlanking
                            {
                                #region [public] {static} (IPropertyKey) IsSupported50HzWithStandardBlanking: Gets a value representing the key to retrieve the property value
                                /// <summary>
                                /// <para>Gets a value representing the key to retrieve the property value.</para>
                                /// <para>Indicates if is supported 50Hz with standard blanking.</para>
                                /// <para>
                                ///  <para><b>Key Composition</b></para>
                                ///  <list type="bullet">
                                ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                                ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.IsSupported50HzWithStandardBlanking"/></description></item>
                                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                                ///  </list>
                                /// </para>
                                /// <para>
                                ///  <para><b>Return Value</b></para>
                                /// <para>Type: <see cref="bool"/>.</para>
                                /// </para>
                                /// <para>
                                ///  <para><b>Remarks</b></para>
                                ///  <para>1.4</para>
                                /// </para>
                                /// </summary>
                                public static IPropertyKey IsSupported50HzWithStandardBlanking => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.IsSupported50HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (IPropertyKey) IsSupported60HzWithStandardBlanking: Gets a value representing the key to retrieve the property value
                                /// <summary>
                                /// <para>Gets a value representing the key to retrieve the property value.</para>
                                /// <para>Indicates if is supported 60Hz with standard blanking.</para>
                                /// <para>
                                ///  <para><b>Key Composition</b></para>
                                ///  <list type="bullet">
                                ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                                ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.IsSupported60HzWithStandardBlanking"/></description></item>
                                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                                ///  </list>
                                /// </para>
                                /// <para>
                                ///  <para><b>Return Value</b></para>
                                /// <para>Type: <see cref="bool"/>.</para>
                                /// </para>
                                /// <para>
                                ///  <para><b>Remarks</b></para>
                                ///  <para>1.4</para>
                                /// </para>
                                /// </summary>
                                public static IPropertyKey IsSupported60HzWithStandardBlanking => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.IsSupported60HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (IPropertyKey) IsSupported75HzWithStandardBlanking: Gets a value representing the key to retrieve the property value
                                /// <summary>
                                /// <para>Gets a value representing the key to retrieve the property value.</para>
                                /// <para>Indicates if is supported 75Hz with standard blanking.</para>
                                /// <para>
                                ///  <para><b>Key Composition</b></para>
                                ///  <list type="bullet">
                                ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                                ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.IsSupported75HzWithStandardBlanking"/></description></item>
                                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                                ///  </list>
                                /// </para>
                                /// <para>
                                ///  <para><b>Return Value</b></para>
                                /// <para>Type: <see cref="bool"/>.</para>
                                /// </para>
                                /// <para>
                                ///  <para><b>Remarks</b></para>
                                ///  <para>1.4</para>
                                /// </para>
                                /// </summary>
                                public static IPropertyKey IsSupported75HzWithStandardBlanking => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.IsSupported75HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (IPropertyKey) IsSupported85HzWithStandardBlanking: Gets a value representing the key to retrieve the property value
                                /// <summary>
                                /// <para>Gets a value representing the key to retrieve the property value.</para>
                                /// <para>Indicates if is supported 85Hz with standard blanking.</para>
                                /// <para>
                                ///  <para><b>Key Composition</b></para>
                                ///  <list type="bullet">
                                ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                                ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.IsSupported85HzWithStandardBlanking"/></description></item>
                                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                                ///  </list>
                                /// </para>
                                /// <para>
                                ///  <para><b>Return Value</b></para>
                                /// <para>Type: <see cref="bool"/>.</para>
                                /// </para>
                                /// <para>
                                ///  <para><b>Remarks</b></para>
                                ///  <para>1.4</para>
                                /// </para>
                                /// </summary>
                                public static IPropertyKey IsSupported85HzWithStandardBlanking => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.IsSupported85HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (IPropertyKey) IsSupported60HzWithReducedBlanking: Gets a value representing the key to retrieve the property value
                                /// <summary>
                                /// <para>Gets a value representing the key to retrieve the property value.</para>
                                /// <para>Indicates if is supported 60Hz with reduced blanking.</para>
                                /// <para>
                                ///  <para><b>Key Composition</b></para>
                                ///  <list type="bullet">
                                ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                                ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.IsSupported60HzWithReducedBlanking"/></description></item>
                                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                                ///  </list>
                                /// </para>
                                /// <para>
                                ///  <para><b>Return Value</b></para>
                                /// <para>Type: <see cref="bool"/>.</para>
                                /// </para>
                                /// <para>
                                ///  <para><b>Remarks</b></para>
                                ///  <para>1.4</para>
                                /// </para>
                                /// </summary>
                                public static IPropertyKey IsSupported60HzWithReducedBlanking => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, EdidProperty.DataBlocks.Descriptors.DescriptorItems.Cvt3ByteCodeDescriptorItem.IsSupported60HzWithReducedBlanking);
                                #endregion
                            }
                            #endregion

                            #endregion
                        }
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DetailedTimingMode: Definition of keys in the 'DataBlocks' of 'DetailedTimingMode' type
                    /// <summary>
                    /// Definition of keys in the <b>DataBlock</b> of <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/> type.
                    /// </summary>
                    public static class DetailedTimingMode
                    {
                        #region [public] {static} (IPropertyKey) PixelClock: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Pixel clock value.<br/>
                        /// This value is measured in <see cref="PropertyUnit.KHz"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.PixelClock"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.KHz"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey PixelClock => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.PixelClock, PropertyUnit.KHz);
                        #endregion

                        #region [public] {static} (IPropertyKey) HorizontalResolution: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Horizontal resolution.<br/>
                        /// This value is measured in <see cref="PropertyUnit.Pixels"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.HorizontalResolution"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.Pixels"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey HorizontalResolution => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.HorizontalResolution, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (IPropertyKey) HorizontalBlanking: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Horizontal blanking value.<br/>
                        /// This value is measured in <see cref="PropertyUnit.Pixels"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.HorizontalResolution"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.Pixels"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey HorizontalBlanking => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.HorizontalBlanking, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (IPropertyKey) VerticalLines: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Vertical lines value.<br/>
                        /// This value is measured in <see cref="PropertyUnit.Lines"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.VerticalLines"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.Lines"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey VerticalLines => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.VerticalLines, PropertyUnit.Lines);
                        #endregion

                        #region [public] {static} (IPropertyKey) VerticalBlanking: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Vertical blanking.<br/>
                        /// This value is measured in <see cref="PropertyUnit.Lines"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.VerticalBlanking"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.Lines"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey VerticalBlanking => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.VerticalBlanking, PropertyUnit.Lines);
                        #endregion

                        #region [public] {static} (IPropertyKey) HorizontalFrontPorch: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Horizontal front porch.<br/>
                        /// This value is measured in <see cref="PropertyUnit.Pixels"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.HorizontalFrontPorch"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.Pixels"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey HorizontalFrontPorch => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.HorizontalFrontPorch, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (IPropertyKey) HorizontalSyncPulseWidth: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Horizontal sync pulse width.<br/>
                        /// This value is measured in <see cref="PropertyUnit.Pixels"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.HorizontalSyncPulseWidth"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.Pixels"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey HorizontalSyncPulseWidth => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.HorizontalSyncPulseWidth, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (IPropertyKey) VerticalFrontPorch: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Vertical front porch.<br/>
                        /// This value is measured in <see cref="PropertyUnit.Lines"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.VerticalFrontPorch"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.Lines"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey VerticalFrontPorch => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.VerticalFrontPorch, PropertyUnit.Lines);
                        #endregion

                        #region [public] {static} (IPropertyKey) VerticalSyncPulseWidth: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Vertical sync pulse width value.<br/>
                        /// This value is measured in <see cref="PropertyUnit.Lines"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.VerticalSyncPulseWidth"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.Lines"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey VerticalSyncPulseWidth => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.VerticalSyncPulseWidth, PropertyUnit.Lines);
                        #endregion

                        #region [public] {static} (IPropertyKey) HorizontalImageSize: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Horizontal image size value.<br/>
                        /// This value is measured in <see cref="PropertyUnit.mm"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.HorizontalImageSize"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.mm"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey HorizontalImageSize => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.HorizontalImageSize, PropertyUnit.mm);
                        #endregion

                        #region [public] {static} (IPropertyKey) VerticalImageSize: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Vertical image size value.<br/>
                        /// This value is measured in <see cref="PropertyUnit.mm"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.VerticalImageSize"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.mm"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey VerticalImageSize => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.VerticalImageSize, PropertyUnit.mm);
                        #endregion

                        #region [public] {static} (IPropertyKey) HorizontalBorder: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Horizontal border value.<br/>
                        /// This value is measured in <see cref="PropertyUnit.Pixels"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.HorizontalBorder"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.Pixels"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="byte"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey HorizontalBorder => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.HorizontalBorder, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (IPropertyKey) VerticalBorder: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Vertical border value.<br/>
                        /// This value is measured in <see cref="PropertyUnit.Pixels"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.VerticalBorder"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.Pixels"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="byte"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey VerticalBorder => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.VerticalBorder, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (IPropertyKey) IsInterlaced: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if is interlaced.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.Interlaced"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey IsInterlaced => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.Interlaced);
                        #endregion

                        #region [public] {static} (IPropertyKey) StereoViewingSupport: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Stereo viewing support value.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.StereoViewingSupport"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="string"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey StereoViewingSupport => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.StereoViewingSupport);
                        #endregion

                        #region [public] {static} (IPropertyKey) SyncSignalType: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Sync signal type.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.SyncSignalType"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="string"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey SyncSignalType => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, EdidProperty.DataBlocks.Descriptors.DetailedTimingModeDescriptor.SyncSignalType);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DisplayProductName: Definition of keys in the 'DataBlock' of 'DisplayProductName' type
                    /// <summary>
                    /// Definition of keys in the <b>DataBlock</b> of <see cref="EdidDataBlockDescriptor.DisplayProductName"/> type.
                    /// </summary>
                    public static class DisplayProductName
                    {
                        #region [public] {static} (IPropertyKey) Data: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Display product name text.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DisplayProductName"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DisplayProductNameDescriptor.Text"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="string"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Data => new PropertyKey(EdidDataBlockDescriptor.DisplayProductName, EdidProperty.DataBlocks.Descriptors.DisplayProductNameDescriptor.Text);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DisplayProductSerialNumber: Definition of keys in the 'DataBlock' of 'DisplayProductSerialNumber' type
                    /// <summary>
                    /// Definition of keys in the <b>DataBlock</b> of <see cref="EdidDataBlockDescriptor.DisplayProductSerialNumber"/> type.
                    /// </summary>
                    public static class DisplayProductSerialNumber
                    {
                        #region [public] {static} (IPropertyKey) Data: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Display product serial number value.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DisplayProductSerialNumber"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DisplayProductSerialNumberDescriptor.Text"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="string"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Data => new PropertyKey(EdidDataBlockDescriptor.DisplayProductSerialNumber, EdidProperty.DataBlocks.Descriptors.DisplayProductSerialNumberDescriptor.Text);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DisplayRangeLimits: Definition of keys in the 'DataBlock' of 'DisplayRangeLimits' type
                    /// <summary>
                    /// Definition of keys in the <b>DataBlock</b> of <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/> type.
                    /// </summary>
                    public static class DisplayRangeLimits
                    {
                        #region [public] {static} (IPropertyKey) MinimumVerticalRate: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Minimum vertical rate value.<br/>
                        /// This value is measured in <see cref="PropertyUnit.Hz"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DisplayRangeLimitsDescriptor.MinimumVerticalRate"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.Hz"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey MinimumVerticalRate => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, EdidProperty.DataBlocks.Descriptors.DisplayRangeLimitsDescriptor.MinimumVerticalRate, PropertyUnit.Hz);
                        #endregion

                        #region [public] {static} (IPropertyKey) MaximumVerticalRate: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Maximum vertical rate value.<br/>
                        /// This value is measured in <see cref="PropertyUnit.Hz"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DisplayRangeLimitsDescriptor.MaximumVerticalRate"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.Hz"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey MaximumVerticalRate => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, EdidProperty.DataBlocks.Descriptors.DisplayRangeLimitsDescriptor.MaximumVerticalRate, PropertyUnit.Hz);
                        #endregion

                        #region [public] {static} (IPropertyKey) MinimumHorizontalRate: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Minimim horizontal rate value.<br/>
                        /// This value is measured in <see cref="PropertyUnit.Hz"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DisplayRangeLimitsDescriptor.MinimumHorizontalRate"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.KHz"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey MinimumHorizontalRate => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, EdidProperty.DataBlocks.Descriptors.DisplayRangeLimitsDescriptor.MinimumHorizontalRate, PropertyUnit.KHz);
                        #endregion

                        #region [public] {static} (IPropertyKey) MaximumHorizontalRate: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Maximum horizontal rate value.<br/>
                        /// This value is measured in <see cref="PropertyUnit.Hz"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DisplayRangeLimitsDescriptor.MaximumHorizontalRate"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.KHz"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey MaximumHorizontalRate => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, EdidProperty.DataBlocks.Descriptors.DisplayRangeLimitsDescriptor.MaximumHorizontalRate, PropertyUnit.KHz);
                        #endregion

                        #region [public] {static} (IPropertyKey) MaximumPixelClock: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>
                        /// Maximum pixel clock value.<br/>
                        /// This value is measured in <see cref="PropertyUnit.MHz"/>.
                        /// </para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DisplayRangeLimitsDescriptor.MaximumPixelClock"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.MHz"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="int"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        ///
                        public static IPropertyKey MaximumPixelClock => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, EdidProperty.DataBlocks.Descriptors.DisplayRangeLimitsDescriptor.MaximumPixelClock, PropertyUnit.MHz);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DummyData: Definition of keys in the 'DataBlock' of 'DummyData' type
                    /// <summary>
                    /// Definition of keys in the <b>DataBlock</b> of <see cref="EdidDataBlockDescriptor.DummyData"/> type.
                    /// </summary>
                    public static class DummyData
                    {
                        #region [public] {static} (IPropertyKey) OriginalData: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Original data value.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DummyData"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DummyDataDescriptor.OriginalData"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="string"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey OriginalData => new PropertyKey(EdidDataBlockDescriptor.DummyData, EdidProperty.DataBlocks.Descriptors.DummyDataDescriptor.OriginalData);
                        #endregion

                        #region [public] {static} (IPropertyKey) PrintableData: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Printable data value.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DummyData"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.DummyDataDescriptor.PrintableData"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="string"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey PrintableData => new PropertyKey(EdidDataBlockDescriptor.DummyData, EdidProperty.DataBlocks.Descriptors.DummyDataDescriptor.PrintableData);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) EstablishedTimingsIII: Definition of keys in the 'DataBlock' of 'EstablishedTimingsIII' type
                    /// <summary>
                    /// Definition of keys in the <b>DataBlock</b> of <see cref="EdidDataBlockDescriptor.EstablishedTimingsIII"/> type.
                    /// </summary>
                    public static class EstablishedTimingsIII
                    {
                        #region [public] {static} (IPropertyKey) Revision: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Revision value.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.EstablishedTimingsIII"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.EstablishedTimingsIIIDescriptor.Revision"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="byte"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Revision => new PropertyKey(EdidDataBlockDescriptor.EstablishedTimingsIII, EdidProperty.DataBlocks.Descriptors.EstablishedTimingsIIIDescriptor.Revision);
                        #endregion

                        #region [public] {static} (IPropertyKey) Resolutions:Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Supported resolutions collection for established timmings iii descriptor.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.EstablishedTimingsIII"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.EstablishedTimingsIIIDescriptor.Resolutions"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="MonitorResolutionInfo"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Resolutions => new PropertyKey(EdidDataBlockDescriptor.EstablishedTimingsIII, EdidProperty.DataBlocks.Descriptors.EstablishedTimingsIIIDescriptor.Resolutions);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) ManufacturerSpecifiedData: Definition of keys in the 'DataBlock' of 'ManufacturerSpecifiedData' type
                    /// <summary>
                    /// Definition of keys in the <b>DataBlock</b> of <see cref="EdidDataBlockDescriptor.ManufacturerSpecifiedData00"/> type.
                    /// </summary>
                    public static class ManufacturerSpecifiedData
                    {
                        #region [public] {static} (IPropertyKey) Data: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>A byte collection containing the specific manufacturer data.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ManufacturerSpecifiedData00"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.ManufacturerSpecifiedDataDescriptor.Data"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Data => new PropertyKey(EdidDataBlockDescriptor.ManufacturerSpecifiedData00, EdidProperty.DataBlocks.Descriptors.ManufacturerSpecifiedDataDescriptor.Data);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) StandardTimingIdentifier: Definition of keys in the 'DataBlock' of 'StandardTimingIdentifier' type
                    /// <summary>
                    /// Definition of keys in the <b>DataBlock</b> of <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/> type.
                    /// </summary>
                    public static class StandardTimingIdentifier
                    {
                        #region [public] {static} (IPropertyKey) Timing9: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Standard timming definition.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.StandardTimingIdentifierDescriptor.Timing9"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Timing9 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, EdidProperty.DataBlocks.Descriptors.StandardTimingIdentifierDescriptor.Timing9);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing10: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Standard timming definition.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.StandardTimingIdentifierDescriptor.Timing10"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Timing10 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, EdidProperty.DataBlocks.Descriptors.StandardTimingIdentifierDescriptor.Timing10);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing11: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Standard timming definition.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.StandardTimingIdentifierDescriptor.Timing11"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Timing11 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, EdidProperty.DataBlocks.Descriptors.StandardTimingIdentifierDescriptor.Timing11);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing12: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Standard timming definition.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.StandardTimingIdentifierDescriptor.Timing12"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Timing12 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, EdidProperty.DataBlocks.Descriptors.StandardTimingIdentifierDescriptor.Timing12);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing13: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Standard timming definition.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.StandardTimingIdentifierDescriptor.Timing13"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Timing13 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, EdidProperty.DataBlocks.Descriptors.StandardTimingIdentifierDescriptor.Timing13);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing14: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Standard timming definition.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></description></item>
                        ///   <item><description>Property: <see cref="EdidProperty.DataBlocks.Descriptors.StandardTimingIdentifierDescriptor.Timing14"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Timing14 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, EdidProperty.DataBlocks.Descriptors.StandardTimingIdentifierDescriptor.Timing14);
                        #endregion
                    }
                    #endregion
                }
                #endregion

                #region [public] {static} (class) Descriptor: Definition of keys that identify the descriptors
                /// <summary>
                /// Definition of keys that identify the descriptors.
                /// </summary>
                public static class Descriptor
                {
                    #region [public] {static} (IPropertyKey) AlphaNumericDataString: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the alphanumeric datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                    ///   <item><description>Property: <see cref="EdidDataBlockDescriptor.AlphaNumericDataString"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="AlphaNumericDataStringDescriptor"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey AlphaNumericDataString => new PropertyKey(EdidSection.DataBlocks, EdidDataBlockDescriptor.AlphaNumericDataString);
                    #endregion

                    #region [public] {static} (IPropertyKey) ColorManagementData: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the color management datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                    ///   <item><description>Property: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="ColorManagementDataDescriptor"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey ColorManagementData => new PropertyKey(EdidSection.DataBlocks, EdidDataBlockDescriptor.ColorManagementData);
                    #endregion

                    #region [public] {static} (IPropertyKey) ColorPointData: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the color point data datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                    ///   <item><description>Property: <see cref="EdidDataBlockDescriptor.ColorPointData"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="ColorPointDataDescriptor"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey ColorPointData => new PropertyKey(EdidSection.DataBlocks, EdidDataBlockDescriptor.ColorPointData);
                    #endregion

                    #region [public] {static} (IPropertyKey) CVT3ByteCode: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the CVT3 byte code datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                    ///   <item><description>Property: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="Cvt3ByteCodeDescriptor"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey CVT3ByteCode => new PropertyKey(EdidSection.DataBlocks, EdidDataBlockDescriptor.Cvt3ByteCode);
                    #endregion

                    #region [public] {static} (IPropertyKey) DetailedTimingMode: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the detailed timming mode datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                    ///   <item><description>Property: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="DetailedTimingModeDescriptor"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey DetailedTimingMode => new PropertyKey(EdidSection.DataBlocks, EdidDataBlockDescriptor.DetailedTimingMode);
                    #endregion

                    #region [public] {static} (IPropertyKey) DisplayProductName: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the display product name datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                    ///   <item><description>Property: <see cref="EdidDataBlockDescriptor.DisplayProductName"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="DisplayProductNameDescriptor"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey DisplayProductName => new PropertyKey(EdidSection.DataBlocks, EdidDataBlockDescriptor.DisplayProductName);
                    #endregion

                    #region [public] {static} (IPropertyKey) DisplayProductSerialNumber: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the display product serial number datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                    ///   <item><description>Property: <see cref="EdidDataBlockDescriptor.DisplayProductSerialNumber"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="DisplayProductSerialNumberDescriptor"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey DisplayProductSerialNumber => new PropertyKey(EdidSection.DataBlocks, EdidDataBlockDescriptor.DisplayProductSerialNumber);
                    #endregion

                    #region [public] {static} (IPropertyKey) DisplayRangeLimits: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the display range limit datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                    ///   <item><description>Property: <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="DisplayRangeLimitsDescriptor"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey DisplayRangeLimits => new PropertyKey(EdidSection.DataBlocks, EdidDataBlockDescriptor.DisplayRangeLimits);
                    #endregion

                    #region [public] {static} (IPropertyKey) DummyData: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the dummy data datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                    ///   <item><description>Property: <see cref="EdidDataBlockDescriptor.DummyData"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="DummyDataDescriptor"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey DummyData => new PropertyKey(EdidSection.DataBlocks, EdidDataBlockDescriptor.DummyData);
                    #endregion

                    #region [public] {static} (IPropertyKey) EstablishedTimingsIII: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the established timmings III datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                    ///   <item><description>Property: <see cref="EdidDataBlockDescriptor.EstablishedTimingsIII"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="EstablishedTimingsIIIDescriptor"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey EstablishedTimingsIII => new PropertyKey(EdidSection.DataBlocks, EdidDataBlockDescriptor.EstablishedTimingsIII);
                    #endregion

                    #region [public] {static} (IPropertyKey) ManufacturerSpecifiedData00: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the manufacturer specified data datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                    ///   <item><description>Property: <see cref="EdidDataBlockDescriptor.ManufacturerSpecifiedData00"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="ManufacturerSpecifiedDataDescriptor"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey ManufacturerSpecifiedData00 => new PropertyKey(EdidSection.DataBlocks, EdidDataBlockDescriptor.ManufacturerSpecifiedData00);
                    #endregion

                    #region [public] {static} (IPropertyKey) StandardTimingIdentifier: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the standard timing identifier datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="EdidSection.DataBlocks"/></description></item>
                    ///   <item><description>Property: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="StandardTimingIdentifierDescriptor"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey StandardTimingIdentifier => new PropertyKey(EdidSection.DataBlocks, EdidDataBlockDescriptor.StandardTimingIdentifier);
                    #endregion
                }
                #endregion

                #endregion
            }
            #endregion

            #region [public] {static} (class) ExtensionBlocks: Definition of keys in the 'ExtensionBlocks' section
            /// <summary>
            /// Definition of keys in the <see cref="EdidSection.ExtensionBlocks"/> section.
            /// </summary>
            public static class ExtensionBlocks
            {
                #region [public] {static} (IPropertyKey) Count: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Number of availables extensions blocks.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.ExtensionBlocks"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.ExtensionBlocks.Count"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                /// <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Count => new PropertyKey(EdidSection.ExtensionBlocks, EdidProperty.ExtensionBlocks.Count);
                #endregion

                #region [public] {static} (IPropertyKey) HasBlocks: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if has availables extension blocks.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.ExtensionBlocks"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.ExtensionBlocks.HasBlocks"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                /// <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey HasBlocks => new PropertyKey(EdidSection.ExtensionBlocks, EdidProperty.ExtensionBlocks.HasBlocks);
                #endregion
            }
            #endregion

            #region [public] {static} (class) CheckSum: Definition of keys in the 'CheckSum' section
            /// <summary>
            /// Definition of keys in the <see cref="EdidSection.Checksum"/> section.
            /// </summary>
            public static class CheckSum
            {
                #region [public] {static} (IPropertyKey) OK: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if is a valid <see cref="EEDID"/> structure.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.Checksum"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.Checksum.Ok"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Ok => new PropertyKey(EdidSection.Checksum, EdidProperty.Checksum.Ok);
                #endregion

                #region [public] {static} (IPropertyKey) Value: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Contains checksum byte block value.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="EdidSection.Checksum"/></description></item>
                ///   <item><description>Property: <see cref="EdidProperty.Checksum.Value"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Value => new PropertyKey(EdidSection.Checksum, EdidProperty.Checksum.Value);
                #endregion
            }
            #endregion
        }
        #endregion

        #region [public] {static} (class) Cea: Definition of keys in the 'CEA' block
        /// <summary>
        /// Definition of keys in the <see cref="KnownDataBlock.CEA"/> block.
        /// </summary>
        public static class Cea
        {
            #region [public] {static} (class) Information: Definition of keys in the 'Information' section
            /// <summary>
            /// Definition of keys in the <see cref="CeaSection.Information"/> section.
            /// </summary>
            public static class Information
            {
                #region [public] {static} (IPropertyKey) Revision: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Implemented revision number.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="CeaSection.Information"/></description></item>
                ///   <item><description>Property: <see cref="CeaProperty.Information.Revision"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Revision => new PropertyKey(CeaSection.Information, CeaProperty.Information.Revision);
                #endregion

                #region [public] {static} (IPropertyKey) Implemented: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Implemented version.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="CeaSection.Information"/></description></item>
                ///   <item><description>Property: <see cref="CeaProperty.Information.Implemented"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Implemented => new PropertyKey(CeaSection.Information, CeaProperty.Information.Implemented);
                #endregion
            }
            #endregion

            #region [public] {static} (class) MonitorSupport: Definition of keys in the 'MonitorSupport' section
            /// <summary>
            /// Definition of keys in the <see cref="CeaSection.MonitorSupport"/> section.
            /// </summary>
            public static class MonitorSupport
            {
                #region [public] {static} (IPropertyKey) IsDvtUnderscan: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if dvt underscan.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="CeaSection.MonitorSupport"/></description></item>
                ///   <item><description>Property: <see cref="CeaProperty.MonitorSupport.IsDvtUnderscan"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey IsDvtUnderscan => new PropertyKey(CeaSection.MonitorSupport, CeaProperty.MonitorSupport.IsDvtUnderscan);
                #endregion

                #region [public] {static} (IPropertyKey) BasicAudioSupported: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if basic audio is supported.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="CeaSection.MonitorSupport"/></description></item>
                ///   <item><description>Property: <see cref="CeaProperty.MonitorSupport.BasicAudioSupported"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey BasicAudioSupported => new PropertyKey(CeaSection.MonitorSupport, CeaProperty.MonitorSupport.BasicAudioSupported);
                #endregion

                #region [public] {static} (IPropertyKey) YCbCr444Supported: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if is supported the Ycbcr444.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="CeaSection.MonitorSupport"/></description></item>
                ///   <item><description>Property: <see cref="CeaProperty.MonitorSupport.YCbCr444Supported"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey YCbCr444Supported => new PropertyKey(CeaSection.MonitorSupport, CeaProperty.MonitorSupport.YCbCr444Supported);
                #endregion

                #region [public] {static} (IPropertyKey) YCbCr422Supported: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if is supported the Ycbcr422.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="CeaSection.MonitorSupport"/></description></item>
                ///   <item><description>Property: <see cref="CeaProperty.MonitorSupport.YCbCr422Supported"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey YCbCr422Supported => new PropertyKey(CeaSection.MonitorSupport, CeaProperty.MonitorSupport.YCbCr422Supported);
                #endregion  
            }
            #endregion

            #region [public] {static} (class) DetailedTiming: Definition of keys in the 'DetailedTimings' section
            /// <summary>
            /// Definition of keys in the <see cref="CeaSection.DetailedTiming"/> section.
            /// </summary>
            public static class DetailedTiming
            {
                #region [public] {static} (IPropertyKey) Timings: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>The timmings collection.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                ///   <item><description>Property: <see cref="CeaProperty.DetailedTiming.Timings"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="List{T}"/> where <b>T</b> is <see cref="SectionPropertiesTable"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Timings => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTiming.Timings);
                #endregion


                #region nested classes

                #region [public] {static} (class) Descriptor: Definition of keys in the 'Descriptor' section of a 'DetailedTiming' Section
                /// <summary>
                /// Definition of keys in the <b>Descriptor</b> section of a <b>DetailedTiming</b> Section.
                /// </summary>
                public static class Descriptor
                {
                    #region [public] {static} (IPropertyKey) PixelClock: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>
                    /// Pixel clock value.<br/>
                    /// This value is measured in <see cref="PropertyUnit.KHz"/>.
                    /// </para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.PixelClock"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.KHz"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey PixelClock => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.PixelClock, PropertyUnit.KHz);
                    #endregion

                    #region [public] {static} (IPropertyKey) HorizontalResolution: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>
                    /// Horizontal resolution.<br/>
                    /// This value is measured in <see cref="PropertyUnit.Pixels"/>.
                    /// </para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.HorizontalResolution"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.Pixels"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey HorizontalResolution => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.HorizontalResolution, PropertyUnit.Pixels);
                    #endregion

                    #region [public] {static} (IPropertyKey) HorizontalBlanking: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>
                    /// Horizontal blanking value.<br/>
                    /// This value is measured in <see cref="PropertyUnit.Pixels"/>.
                    /// </para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.HorizontalBlanking"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.Pixels"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey HorizontalBlanking => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.HorizontalBlanking, PropertyUnit.Pixels);
                    #endregion

                    #region [public] {static} (IPropertyKey) VerticalLines: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>
                    /// Vertical lines value.<br/>
                    /// This value is measured in <see cref="PropertyUnit.Lines"/>.
                    /// </para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.VerticalLines"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.Lines"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey VerticalLines => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.VerticalLines, PropertyUnit.Lines);
                    #endregion

                    #region [public] {static} (IPropertyKey) VerticalBlanking: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>
                    /// Vertical blanking.<br/>
                    /// This value is measured in <see cref="PropertyUnit.Lines"/>.
                    /// </para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.VerticalBlanking"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.Lines"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey VerticalBlanking => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.VerticalBlanking, PropertyUnit.Lines);
                    #endregion

                    #region [public] {static} (IPropertyKey) HorizontalFrontPorch: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>
                    /// Horizontal front porch.<br/>
                    /// This value is measured in <see cref="PropertyUnit.Pixels"/>.
                    /// </para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.HorizontalFrontPorch"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.Pixels"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey HorizontalFrontPorch => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.HorizontalFrontPorch, PropertyUnit.Pixels);
                    #endregion

                    #region [public] {static} (IPropertyKey) HorizontalSyncPulseWidth: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>
                    /// Horizontal sync pulse width.<br/>
                    /// This value is measured in <see cref="PropertyUnit.Pixels"/>.
                    /// </para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.HorizontalSyncPulseWidth"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.Pixels"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey HorizontalSyncPulseWidth => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.HorizontalSyncPulseWidth, PropertyUnit.Pixels);
                    #endregion

                    #region [public] {static} (IPropertyKey) VerticalFrontPorch: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>
                    /// Vertical front porch.<br/>
                    /// This value is measured in <see cref="PropertyUnit.Lines"/>.
                    /// </para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.VerticalFrontPorch"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.Lines"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey VerticalFrontPorch => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.VerticalFrontPorch, PropertyUnit.Lines);
                    #endregion

                    #region [public] {static} (IPropertyKey) VerticalSyncPulseWidth: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>
                    /// Vertical sync pulse width value.<br/>
                    /// This value is measured in <see cref="PropertyUnit.Lines"/>.
                    /// </para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.VerticalSyncPulseWidth"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.Lines"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey VerticalSyncPulseWidth => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.VerticalSyncPulseWidth, PropertyUnit.Lines);
                    #endregion

                    #region [public] {static} (IPropertyKey) HorizontalImageSize: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>
                    /// Horizontal image size value.<br/>
                    /// This value is measured in <see cref="PropertyUnit.mm"/>.
                    /// </para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.HorizontalImageSize"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.mm"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey HorizontalImageSize => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.HorizontalImageSize, PropertyUnit.mm);
                    #endregion

                    #region [public] {static} (IPropertyKey) VerticalImageSize: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>
                    /// Vertical image size value.<br/>
                    /// This value is measured in <see cref="PropertyUnit.mm"/>.
                    /// </para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.VerticalImageSize"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.mm"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey VerticalImageSize => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.VerticalImageSize, PropertyUnit.mm);
                    #endregion

                    #region [public] {static} (IPropertyKey) HorizontalBorder: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>
                    /// Horizontal border value.<br/>
                    /// This value is measured in <see cref="PropertyUnit.Pixels"/>.
                    /// </para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.HorizontalBorder"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.Pixels"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="byte"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey HorizontalBorder => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.HorizontalBorder, PropertyUnit.Pixels);
                    #endregion

                    #region [public] {static} (IPropertyKey) VerticalBorder: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>
                    /// Vertical border value.<br/>
                    /// This value is measured in <see cref="PropertyUnit.Pixels"/>.
                    /// </para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.VerticalBorder"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.Pixels"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="byte"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey VerticalBorder => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.VerticalBorder, PropertyUnit.Pixels);
                    #endregion

                    #region [public] {static} (IPropertyKey) IsInterlaced: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Indicates if is interlaced.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.Interlaced"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey IsInterlaced => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.Interlaced);
                    #endregion

                    #region [public] {static} (IPropertyKey) StereoViewingSupport: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Stereo viewing support value.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.StereoViewingSupport"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="string"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey StereoViewingSupport => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.StereoViewingSupport);
                    #endregion

                    #region [public] {static} (IPropertyKey) SyncSignalType: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Sync signal type.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DetailedTimingDescriptor.SyncSignalType"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    /// <para>Type: <see cref="string"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey SyncSignalType => new PropertyKey(CeaSection.DetailedTiming, CeaProperty.DetailedTimingDescriptor.SyncSignalType);
                    #endregion
                }
                #endregion

                #endregion
            }
            #endregion

            #region [public] {static} (class) DataBlock: Definition of keys in the 'DataBlockCollection' section
            /// <summary>
            /// Definition of keys in the <see cref="CeaSection.DataBlockCollection"/> section.
            /// </summary>
            public static class DataBlock
            {
                #region nested classes

                #region [public] {static} (class) Tags: Definition of Tags keys in the 'DataBlockCollection' section
                /// <summary>
                /// Definition of <b>Tags</b> keys in the <b>DataBlockCollection</b> section.
                /// </summary>
                public static class Tags
                {
                    #region public readonly properties

                    #region [public] {static} (IPropertyKey) Audio: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>CEA Short Audio Data Block (SADB).</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DataBlockTags.Audio"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="SectionPropertiesTable"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Audio => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.DataBlockTags.Audio);
                    #endregion

                    #region [public] {static} (IPropertyKey) Extended: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Data Block Extended Tag.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DataBlockTags.Extended"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="SectionPropertiesTable"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Extended => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.DataBlockTags.Extended);
                    #endregion

                    #region [public] {static} (IPropertyKey) Reserved: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Data Block Reserved Tag.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DataBlockTags.Reserved"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="SectionPropertiesTable"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Reserved => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.DataBlockTags.Reserved);
                    #endregion

                    #region [public] {static} (IPropertyKey) Speaker: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>CEA Short Speaker Data Block (SKDB).</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DataBlockTags.Speaker"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="SectionPropertiesTable"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Speaker => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.DataBlockTags.Speaker);
                    #endregion

                    #region [public] {static} (IPropertyKey) Vendor: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>CEA Short Vendor Data Block (SRDB).</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DataBlockTags.Vendor"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="SectionPropertiesTable"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Vendor => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.DataBlockTags.Vendor);
                    #endregion

                    #region [public] {static} (IPropertyKey) VESA: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Data Block VESA Tag.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DataBlockTags.VESA"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="SectionPropertiesTable"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey VESA => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.DataBlockTags.VESA);
                    #endregion

                    #region [public] {static} (IPropertyKey) Video: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>CEA Short Video Data Block (SVDB).</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.DataBlockTags.Video"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="SectionPropertiesTable"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Video => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.DataBlockTags.Video);
                    #endregion

                    #endregion
                }
                #endregion


                #region [public] {static} (class) Audio: Definition of keys in the 'Audio' section
                /// <summary>
                /// Definition of keys in the <b>Audio</b> section.
                /// </summary>
                public static class Audio
                {
                    #region [public] {static} (IPropertyKey) Descriptor: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Audio Descriptor Index</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.AudioDataBlock.Descriptor"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="byte"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Descriptor => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.AudioDataBlock.Descriptor);
                    #endregion

                    #region [public] {static} (IPropertyKey) BitDepth: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Audio Bit Depth</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.AudioDataBlock.BitDepth"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey BitDepth => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.AudioDataBlock.BitDepth);
                    #endregion

                    #region [public] {static} (IPropertyKey) Channels: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Audio Channels</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.AudioDataBlock.Channels"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="ushort"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Channels => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.AudioDataBlock.Channels);
                    #endregion

                    #region [public] {static} (IPropertyKey) Format: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Audio Format</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.AudioDataBlock.Format"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="string"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Format => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.AudioDataBlock.Format);
                    #endregion

                    #region [public] {static} (IPropertyKey) MaxBitrate: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Audio Max Bitrate</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.AudioDataBlock.Format"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey MaxBitrate => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.AudioDataBlock.MaxBitrate);
                    #endregion

                    #region [public] {static} (IPropertyKey) SamplingFrequencies: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Audio Sampling Frequencies</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.AudioDataBlock.SamplingFrequencies"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey SamplingFrequencies => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.AudioDataBlock.SamplingFrequencies);
                    #endregion
                }
                #endregion

                #region [public] {static} (class) Extended: Definition of keys in the 'Extended' section
                /// <summary>
                /// Definition of keys in the <b>Extended</b> section.
                /// </summary>
                public static class Extended
                {
                    #region nested classes

                    #region [public] {static} (class) Colorimetry: Definition of keys in the 'Colorimetry' section
                    /// <summary>
                    /// Definition of keys in the <b>Colorimetry</b> section.
                    /// </summary>
                    public static class Colorimetry
                    {
                        #region [public] {static} (IPropertyKey) AdobeRGB: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Adobe RGB.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaProperty.ExtendedColorimetryDataBlock.AdobeRGB"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey AdobeRGB => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.ExtendedColorimetryDataBlock.AdobeRGB);
                        #endregion

                        #region [public] {static} (IPropertyKey) AdobeYCC601: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Adobe YCC601.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaProperty.ExtendedColorimetryDataBlock.AdobeYCC601"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey AdobeYCC601 => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.ExtendedColorimetryDataBlock.AdobeYCC601);
                        #endregion

                        #region [public] {static} (IPropertyKey) sYCC601: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>sYCC601.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaProperty.ExtendedColorimetryDataBlock.sYCC601"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey sYCC601 => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.ExtendedColorimetryDataBlock.sYCC601);
                        #endregion

                        #region [public] {static} (IPropertyKey) xvYCC709: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>xvYCC709.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaProperty.ExtendedColorimetryDataBlock.xvYCC709"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey xvYCC709 => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.ExtendedColorimetryDataBlock.xvYCC709);
                        #endregion

                        #region [public] {static} (IPropertyKey) xvYCC601: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>xvYCC601.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaProperty.ExtendedColorimetryDataBlock.xvYCC601"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="bool"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey xvYCC601 => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.ExtendedColorimetryDataBlock.xvYCC601);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) MiscellaneousAudioFields: Definition of keys in the 'MiscellaneousAudioFields' section
                    /// <summary>
                    /// Definition of keys in the <b>MiscellaneousAudioFields</b> section.
                    /// </summary>
                    public static class MiscellaneousAudioFields
                    {
                    }
                    #endregion

                    #region [public] {static} (class) VendorSpecificAudio: Definition of keys in the 'VendorSpecificAudio' section
                    /// <summary>
                    /// Definition of keys in the <b>VendorSpecificAudio</b> section.
                    /// </summary>
                    public static class VendorSpecificAudio
                    {
                    }
                    #endregion

                    #region [public] {static} (class) VendorSpecificVideo: Definition of keys in the 'VendorSpecificVideo' section
                    /// <summary>
                    /// Definition of keys in the <b>VendorSpecificVideo</b> section.
                    /// </summary>
                    public static class VendorSpecificVideo
                    {
                    }
                    #endregion

                    #region [public] {static} (class) VideoCapability: Definition of keys in the 'VideoCapability' section
                    /// <summary>
                    /// Definition of keys in the <b>VideoCapability</b> section.
                    /// </summary>
                    public static class VideoCapability
                    {
                        #region [public] {static} (IPropertyKey) CEOverscan: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>CE Overscan/Underscan.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaProperty.ExtendedVideoCapabilityDataBlock.CEOverscan"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="string"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey CEOverscan => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.ExtendedVideoCapabilityDataBlock.CEOverscan);
                        #endregion

                        #region [public] {static} (IPropertyKey) ITOverscan: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>IT Overscan/Underscan.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaProperty.ExtendedVideoCapabilityDataBlock.ITOverscan"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="string"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey ITOverscan => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.ExtendedVideoCapabilityDataBlock.ITOverscan);
                        #endregion

                        #region [public] {static} (IPropertyKey) PTOverscan: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>PT Overscan Overscan/Underscan.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaProperty.ExtendedVideoCapabilityDataBlock.PTOverscan"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="string"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey PTOverscan => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.ExtendedVideoCapabilityDataBlock.PTOverscan);
                        #endregion

                        #region [public] {static} (IPropertyKey) QuantizationRangeRGB: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Quantization Range RGB.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaProperty.ExtendedVideoCapabilityDataBlock.QuantizationRangeRGB"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="string"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey QuantizationRangeRGB => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.ExtendedVideoCapabilityDataBlock.QuantizationRangeRGB);
                        #endregion

                        #region [public] {static} (IPropertyKey) QuantizationRangeYCC: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Quantization Range YCC.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaProperty.ExtendedVideoCapabilityDataBlock.QuantizationRangeYCC"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="string"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey QuantizationRangeYCC => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.ExtendedVideoCapabilityDataBlock.QuantizationRangeYCC);
                        #endregion
                    }
                    #endregion

                    #endregion
                }
                #endregion

                #region [public] {static} (class) Reserved: Definition of keys in the 'Reserved' section
                /// <summary>
                /// Definition of keys in the <b>Reserved</b> section.
                /// </summary>
                public static class Reserved
                {
                    #region [public] {static} (IPropertyKey) Data: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Raw data.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.ReservedDataBlock.Data"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Data => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.ReservedDataBlock.Data);
                    #endregion
                }
                #endregion

                #region [public] {static} (class) Speaker: Definition of keys in the 'Speaker' section
                /// <summary>
                /// Definition of keys in the <b>Speaker</b> section.
                /// </summary>
                public static class Speaker
                {
                    #region [public] {static} (IPropertyKey) FrontLeftRightHigh: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Front Left/Right High.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.SpeakerDataBlock.FrontLeftRightHigh"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey FrontLeftRightHigh => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.SpeakerDataBlock.FrontLeftRightHigh);
                    #endregion

                    #region [public] {static} (IPropertyKey) FrontLeftRightWide: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Front Left/Right Wide.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.SpeakerDataBlock.FrontLeftRightWide"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey FrontLeftRightWide => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.SpeakerDataBlock.FrontLeftRightWide);
                    #endregion

                    #region [public] {static} (IPropertyKey) RearLeftRightCenter: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Rear Left/Right Center.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.SpeakerDataBlock.RearLeftRightCenter"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey RearLeftRightCenter => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.SpeakerDataBlock.RearLeftRightCenter);
                    #endregion

                    #region [public] {static} (IPropertyKey) FrontLeftRightCenter: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Front Left/Right Center.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.SpeakerDataBlock.FrontLeftRightCenter"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey FrontLeftRightCenter => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.SpeakerDataBlock.FrontLeftRightCenter);
                    #endregion

                    #region [public] {static} (IPropertyKey) RearCenter: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Rear Center.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.SpeakerDataBlock.RearCenter"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey RearCenter => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.SpeakerDataBlock.RearCenter);
                    #endregion

                    #region [public] {static} (IPropertyKey) RearLeftRight: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Rear Left/Right.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.SpeakerDataBlock.RearLeftRight"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey RearLeftRight => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.SpeakerDataBlock.RearLeftRight);
                    #endregion

                    #region [public] {static} (IPropertyKey) FrontCenter: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Front Center.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.SpeakerDataBlock.FrontCenter"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey FrontCenter => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.SpeakerDataBlock.FrontCenter);
                    #endregion

                    #region [public] {static} (IPropertyKey) LFEChannel: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>LFE Channel.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.SpeakerDataBlock.LFEChannel"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey LFEChannel => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.SpeakerDataBlock.LFEChannel);
                    #endregion

                    #region [public] {static} (IPropertyKey) FrontLeftRight: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Front Left/Right.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.SpeakerDataBlock.FrontLeftRight"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey FrontLeftRight => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.SpeakerDataBlock.FrontLeftRight);
                    #endregion

                    #region [public] {static} (IPropertyKey) TopCenter: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Top Center.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.SpeakerDataBlock.TopCenter"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey TopCenter => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.SpeakerDataBlock.TopCenter);
                    #endregion

                    #region [public] {static} (IPropertyKey) FrontCenterHigh: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Front Center High.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.SpeakerDataBlock.FrontCenterHigh"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey FrontCenterHigh => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.SpeakerDataBlock.FrontCenterHigh);
                    #endregion
                }
                #endregion

                #region [public] {static} (class) Vendor: Definition of keys in the 'Vendor' section
                /// <summary>
                /// Definition of keys in the <b>Vendor</b> section.
                /// </summary>
                public static class Vendor
                {
                    #region [public] {static} (IPropertyKey) IEEERegistrationIdentifier: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>IEEE Registration Identifier.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.VendorDataBlock.IEEERegistrationIdentifier"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey IEEERegistrationIdentifier => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.VendorDataBlock.IEEERegistrationIdentifier);
                    #endregion

                    #region [public] {static} (IPropertyKey) PhysicalAddress: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Consumer Electronics Control (CEC) physical address.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.VendorDataBlock.PhysicalAddress"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey PhysicalAddress => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.VendorDataBlock.PhysicalAddress);
                    #endregion

                    #region [public] {static} (IPropertyKey) Flags: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Flags.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.VendorDataBlock.Flags"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Flags => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.VendorDataBlock.Flags);
                    #endregion

                    #region [public] {static} (IPropertyKey) MaxClock: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Maximum TMDS clock.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.VendorDataBlock.MaxClock"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="int"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey MaxClock => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.VendorDataBlock.MaxClock);
                    #endregion

                    #region [public] {static} (IPropertyKey) VendorPayload: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Maximum TMDS clock.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.VendorDataBlock.VendorPayload"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey VendorPayload => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.VendorDataBlock.VendorPayload);
                    #endregion
                }
                #endregion

                #region [public] {static} (class) Video: Definition of keys in the 'Video' section
                /// <summary>
                /// Definition of keys in the <b>Video</b> section.
                /// </summary>
                public static class Video
                {
                    #region [public] {static} (IPropertyKey) SupportedTimings: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Supported timings.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="CeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaProperty.VideoDataBlock.SupportedTimings"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="string"/>.</para>
                    /// </para>
                    /// <para>
                    ///  <para><b>Remarks</b></para>
                    ///  <para>1.4</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey SupportedTimings => new PropertyKey(CeaSection.DataBlockCollection, CeaProperty.VideoDataBlock.SupportedTimings);
                    #endregion
                }
                #endregion

                #endregion
            }
            #endregion

            #region [public] {static} (class) Checksum: Definition of keys in the 'CheckSum' section
            /// <summary>
            /// Definition of keys in the <see cref="CeaSection.Checksum"/> section.
            /// </summary>
            public static class CheckSum
            {
                #region [public] {static} (IPropertyKey) Ok: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if is a valid <see cref="Cea"/> structure.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="CeaSection.Checksum"/></description></item>
                ///   <item><description>Property: <see cref="CeaProperty.Checksum.Ok"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Ok => new PropertyKey(CeaSection.Checksum, CeaProperty.Checksum.Ok);
                #endregion

                #region [public] {static} (IPropertyKey) Value: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Contains checksum byte block value.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="CeaSection.Checksum"/></description></item>
                ///   <item><description>Property: <see cref="CeaProperty.Checksum.Value"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Value => new PropertyKey(CeaSection.Checksum, CeaProperty.Checksum.Value);
                #endregion
            }
            #endregion
        }
        #endregion

        #region [public] {static} (class) DI: Definition of keys in the 'DI' block
        /// <summary>
        /// Definition of keys in the <see cref="KnownDataBlock.DI"/> block.
        /// </summary>
        public static class DI
        {
            #region [public] {static} (class) Information: Definition of keys in the 'Information' section
            /// <summary>
            /// Definition of keys in the <see cref="DiSection.Information"/> section.
            /// </summary>
            public static class Information
            {
                #region [public] {static} (IPropertyKey) VersionNumber: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>The Version Number for the <b>DI-EXT</b> Block Data Structure.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.Information"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.Information.VersionNumber"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// <para>
                ///  <para><b>Remarks</b></para>
                ///  <para>1.4</para>
                /// </para>
                /// </summary>
                public static IPropertyKey VersionNumber => new PropertyKey(DiSection.Information, DiProperty.Information.VersionNumber);
                #endregion
            }
            #endregion

            #region [public] {static} (class) DigitalInterface: Definition of keys in the 'Digital Interface' section
            /// <summary>
            /// Definition of keys in the <see cref="DiSection.DigitalInterface"/> section.
            /// </summary>
            public static class DigitalInterface
            {
                #region [public] {static} (IPropertyKey) SupportedDigitalInterface: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>This section indicates if the display is compatible with a Digital Interface Standard/Specification.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DigitalInterface.SupportedDigitalInterface"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedDigitalInterface => new PropertyKey(DiSection.DigitalInterface, DiProperty.DigitalInterface.SupportedDigitalInterface);
                #endregion

                #region [public] {static} (IPropertyKey) DataEnableSignalUsageAvailable: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Data Enable Signal Usage Available.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DigitalInterface.DataEnableSignalUsageAvailable"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DataEnableSignalUsageAvailable => new PropertyKey(DiSection.DigitalInterface, DiProperty.DigitalInterface.DataEnableSignalUsageAvailable);
                #endregion

                #region [public] {static} (IPropertyKey) DataEnableSignalHighOrLow: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Data Enable Signal High or Low.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DigitalInterface.DataEnableSignalHighOrLow"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DataEnableSignalHighOrLow => new PropertyKey(DiSection.DigitalInterface, DiProperty.DigitalInterface.DataEnableSignalHighOrLow);
                #endregion

                #region [public] {static} (IPropertyKey) EdgeOfShiftClock: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Edge of Shift Clock Usage.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DigitalInterface.EdgeOfShiftClock"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey EdgeOfShiftClock => new PropertyKey(DiSection.DigitalInterface, DiProperty.DigitalInterface.EdgeOfShiftClock);
                #endregion

                #region [public] {static} (IPropertyKey) HdcpSupport: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>HDCP Support.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DigitalInterface.HdcpSupport"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey HdcpSupport => new PropertyKey(DiSection.DigitalInterface, DiProperty.DigitalInterface.HdcpSupport);
                #endregion

                #region [public] {static} (IPropertyKey) DoubleClockingOfInputData: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Double Clocking Of Input Data.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DigitalInterface.DoubleClockingOfInputData"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DoubleClockingOfInputData => new PropertyKey(DiSection.DigitalInterface, DiProperty.DigitalInterface.DoubleClockingOfInputData);
                #endregion

                #region [public] {static} (IPropertyKey) SupportForPacketizedDigitalVideoSupport: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Support For Packetized Digital Video Support.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DigitalInterface.SupportForPacketizedDigitalVideoSupport"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportForPacketizedDigitalVideoSupport => new PropertyKey(DiSection.DigitalInterface, DiProperty.DigitalInterface.SupportForPacketizedDigitalVideoSupport);
                #endregion

                #region [public] {static} (IPropertyKey) DataFormats: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Data Formats.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DigitalInterface.DataFormats"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DataFormats => new PropertyKey(DiSection.DigitalInterface, DiProperty.DigitalInterface.DataFormats);
                #endregion

                #region [public] {static} (IPropertyKey) MinimumPixelClockFrequencyPerLink: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Minimum Pixel Clock Frequency Per Link. It is expressed in <see cref="PropertyUnit.MHz"/>.</para>
                /// <para>The possible values are shown below:</para>
                /// <para>
                ///  <list type="bullet">
                ///   <item><description>00h  Display has an Analog Video Input.</description></item>
                ///   <item><description>01h - FEh  Frequency value.</description></item>
                ///   <item><description>FFh  Reserved.</description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DigitalInterface.MinimumPixelClockFrequencyPerLink"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.MHz"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey MinimumPixelClockFrequencyPerLink => new PropertyKey(DiSection.DigitalInterface, DiProperty.DigitalInterface.MinimumPixelClockFrequencyPerLink, PropertyUnit.MHz);
                #endregion

                #region [public] {static} (IPropertyKey) MaximumPixelClockFrequencyPerLink: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Maximum Pixel Clock Frequency Per Link. It is expressed in <see cref="PropertyUnit.MHz"/>.</para>
                /// <para>The possible values are shown below:</para>
                /// <para>
                ///  <list type="bullet">
                ///   <item><description>0000h  Display has an Analog Video Input.</description></item>
                ///   <item><description>0001h - FFFEh  Frequency value.</description></item>
                ///   <item><description>FFFFh  Reserved.</description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DigitalInterface.MaximumPixelClockFrequencyPerLink"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.MHz"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="int"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey MaximumPixelClockFrequencyPerLink => new PropertyKey(DiSection.DigitalInterface, DiProperty.DigitalInterface.MaximumPixelClockFrequencyPerLink, PropertyUnit.MHz);
                #endregion

                #region [public] {static} (IPropertyKey) CrossoverFrequency: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Crossover Frequency. It is expressed in <see cref="PropertyUnit.MHz"/>.</para>
                /// <para>The possible values are shown below:</para>
                /// <para>
                ///  <list type="bullet">
                ///   <item><description>0000h  Indicates display has an Analog Video Input.</description></item>
                ///   <item><description>0001h - FFFEh  Frequency value.</description></item>
                ///   <item><description>FFFFh  Single Link.</description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DigitalInterface.CrossoverFrequency"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.MHz"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="int"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey CrossoverFrequency => new PropertyKey(DiSection.DigitalInterface, DiProperty.DigitalInterface.CrossoverFrequency, PropertyUnit.MHz);
                #endregion
            }
            #endregion

            #region [public] {static} (class) DisplayDevice: Definition of keys in the 'Display Device' section
            /// <summary>
            /// Definition of keys in the <see cref="DiSection.DisplayDevice"/> section.
            /// </summary>
            public static class DisplayDevice
            {
                #region [public] {static} (IPropertyKey) SubPixelLayout: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Sub-Pixel Layout.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayDevice.SubPixelLayout"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SubPixelLayout => new PropertyKey(DiSection.DisplayDevice, DiProperty.DisplayDevice.SubPixelLayout);
                #endregion

                #region [public] {static} (IPropertyKey) SubPixelConfiguration: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Sub-Pixel Configuration.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayDevice.SubPixelConfiguration"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SubPixelConfiguration => new PropertyKey(DiSection.DisplayDevice, DiProperty.DisplayDevice.SubPixelConfiguration);
                #endregion

                #region [public] {static} (IPropertyKey) SubPixelShape: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Sub-Pixel Shape.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayDevice.SubPixelShape"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SubPixelShape => new PropertyKey(DiSection.DisplayDevice, DiProperty.DisplayDevice.SubPixelShape);
                #endregion

                #region [public] {static} (IPropertyKey) HorizontalDotPixelPitch: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Horizontal Dot/Pixel Pitch.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayDevice.HorizontalDotPixelPitch"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.mm"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey HorizontalDotPixelPitch => new PropertyKey(DiSection.DisplayDevice, DiProperty.DisplayDevice.HorizontalDotPixelPitch, PropertyUnit.mm);
                #endregion

                #region [public] {static} (IPropertyKey) VerticalDotPixelPitch: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Vertical Dot/Pixel Pitch.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayDevice.VerticalDotPixelPitch"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.mm"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey VerticalDotPixelPitch => new PropertyKey(DiSection.DisplayDevice, DiProperty.DisplayDevice.VerticalDotPixelPitch, PropertyUnit.mm);
                #endregion

                #region [public] {static} (IPropertyKey) FixedPixelFormat: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Fixed Pixel Format.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayDevice.FixedPixelFormat"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey FixedPixelFormat => new PropertyKey(DiSection.DisplayDevice, DiProperty.DisplayDevice.FixedPixelFormat);
                #endregion

                #region [public] {static} (IPropertyKey) ViewDirection: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>View Direction.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayDevice.ViewDirection"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ViewDirection => new PropertyKey(DiSection.DisplayDevice, DiProperty.DisplayDevice.ViewDirection);
                #endregion

                #region [public] {static} (IPropertyKey) DisplayBackground: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Display Background.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayDevice.DisplayBackground"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DisplayBackground => new PropertyKey(DiSection.DisplayDevice, DiProperty.DisplayDevice.DisplayBackground);
                #endregion

                #region [public] {static} (IPropertyKey) PhysicalImplementation: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Physical Implementation.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayDevice.PhysicalImplementation"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey PhysicalImplementation => new PropertyKey(DiSection.DisplayDevice, DiProperty.DisplayDevice.PhysicalImplementation);
                #endregion

                #region [public] {static} (IPropertyKey) DDC: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>DDC/CI.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayDevice.DDC"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DDC => new PropertyKey(DiSection.DisplayDevice, DiProperty.DisplayDevice.DDC);
                #endregion
            }
            #endregion

            #region [public] {static} (class) DisplayCapabilitiesAndFeatureSupportSet: Definition of keys in the 'Display Capabilities & Feature Support Set' section
            /// <summary>
            /// Definition of keys in the <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/> section.
            /// </summary>
            public static class DisplayCapabilitiesAndFeatureSupportSet
            {
                #region [public] {static} (IPropertyKey) LegacyModes: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Legacy Modes.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.LegacyModes"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey LegacyModes => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.LegacyModes);
                #endregion

                #region [public] {static} (IPropertyKey) StereoVideo: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Stereo Video.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.StereoVideo"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey StereoVideo => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.StereoVideo);
                #endregion

                #region [public] {static} (IPropertyKey) ScalerOnBoard: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Scaler On Board.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.ScalerOnBoard"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ScalerOnBoard => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.ScalerOnBoard);
                #endregion

                #region [public] {static} (IPropertyKey) ImageCentering: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Image Centering.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.ImageCentering"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ImageCentering => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.ImageCentering);
                #endregion

                #region [public] {static} (IPropertyKey) ConditionalUpdate: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Conditional Update.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.ConditionalUpdate"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ConditionalUpdate => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.ConditionalUpdate);
                #endregion

                #region [public] {static} (IPropertyKey) InterlacedVideo: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Interlaced Video.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.InterlacedVideo"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey InterlacedVideo => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.InterlacedVideo);
                #endregion

                #region [public] {static} (IPropertyKey) FrameLock: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Frame Lock.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.FrameLock"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey FrameLock => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.FrameLock);
                #endregion

                #region [public] {static} (IPropertyKey) FrameRateConversion: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Frame Rate Conversion.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.FrameRateConversion"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey FrameRateConversion => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.FrameRateConversion);
                #endregion

                #region [public] {static} (IPropertyKey) VerticalFrequency: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Vertical Frequency.</para>
                /// <para>The possible values are shown below:</para>
                /// <para>
                ///  <list type="bullet">
                ///   <item><description>0000h  Not available.</description></item>
                ///   <item><description>0001h - FFFEh  Frequency value.</description></item>
                ///   <item><description>FFFFh  Reserved.</description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.VerticalFrequency"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Hz"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="int"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey VerticalFrequency => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.VerticalFrequency, PropertyUnit.Hz);
                #endregion

                #region [public] {static} (IPropertyKey) HorizontalFrequency: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Horizontal Frequency.</para>
                /// <para>The possible values are shown below:</para>
                /// <para>
                ///  <list type="bullet">
                ///   <item><description>0000h  Not available.</description></item>
                ///   <item><description>0001h - FFFEh  Frequency value.</description></item>
                ///   <item><description>FFFFh  Reserved.</description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.HorizontalFrequency"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Hz"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="int"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey HorizontalFrequency => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.HorizontalFrequency, PropertyUnit.Hz);
                #endregion

                #region [public] {static} (IPropertyKey) DisplayScanOrientationType: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Display/Scan Orientation Definition Type.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.DisplayScanOrientationType"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DisplayScanOrientationType => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.DisplayScanOrientationType);
                #endregion

                #region [public] {static} (IPropertyKey) ScreenOrientation: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Screen Orientation.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.ScreenOrientation"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ScreenOrientation => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.ScreenOrientation);
                #endregion

                #region [public] {static} (IPropertyKey) ZeroPixelLocation: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Zero Pixel Location.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.ZeroPixelLocation"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ZeroPixelLocation => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.ZeroPixelLocation);
                #endregion

                #region [public] {static} (IPropertyKey) ScanDirection: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Scan Direction.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.ScanDirection"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ScanDirection => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.ScanDirection);
                #endregion

                #region [public] {static} (IPropertyKey) StandaloneProjector: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standalone Projector.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.StandaloneProjector"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey StandaloneProjector => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.StandaloneProjector);
                #endregion

                #region [public] {static} (IPropertyKey) DefaultColorLuminanceDecoding: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Default Color/Luminance Decoding.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.DefaultColorLuminanceDecoding"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DefaultColorLuminanceDecoding => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.DefaultColorLuminanceDecoding);
                #endregion

                #region [public] {static} (IPropertyKey) PreferredColorLuminanceDecoder: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Preferred Color/Luminance Decoding.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.PreferredColorLuminanceDecoder"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey PreferredColorLuminanceDecoder => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.PreferredColorLuminanceDecoder);
                #endregion

                #region [public] {static} (IPropertyKey) ColorLuminanceDecodingCapabilities: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Color/Luminance Decoding Capabilities.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.ColorLuminanceDecodingCapabilities"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>[].</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ColorLuminanceDecodingCapabilities => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.ColorLuminanceDecodingCapabilities);
                #endregion

                #region [public] {static} (IPropertyKey) Dithering: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Dithering.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.Dithering"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Dithering => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.Dithering);
                #endregion

                #region [public] {static} (IPropertyKey) SupportedColorBitDepthSubChannel0Blue: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Supported Color Bit-Depth of Sub-Channel 0 (Blue).</para>
                /// <para>The possible values are shown below:</para>
                /// <para>
                ///  <list type="bullet">
                ///   <item><description>00h  No Information.</description></item>
                ///   <item><description>01h - 10h  Bits per color value.</description></item>
                ///   <item><description>11h - FFh  Reserved.</description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0Blue"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedColorBitDepthSubChannel0Blue => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0Blue, PropertyUnit.Bits);
                #endregion

                #region [public] {static} (IPropertyKey) SupportedColorBitDepthSubChannel1Green: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Supported Color Bit-Depth of Sub-Channel 1 (Green).</para>
                /// <para>The possible values are shown below:</para>
                /// <para>
                ///  <list type="bullet">
                ///   <item><description>00h  No Information.</description></item>
                ///   <item><description>01h - 10h  Bits per color value.</description></item>
                ///   <item><description>11h - FFh  Reserved.</description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Green"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedColorBitDepthSubChannel1Green => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Green, PropertyUnit.Bits);
                #endregion

                #region [public] {static} (IPropertyKey) SupportedColorBitDepthSubChannel2Red: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Supported Color Bit-Depth of Sub-Channel 1 (Green).</para>
                /// <para>The possible values are shown below:</para>
                /// <para>
                ///  <list type="bullet">
                ///   <item><description>00h  No Information.</description></item>
                ///   <item><description>01h - 10h  Bits per color value.</description></item>
                ///   <item><description>11h - FFh  Reserved.</description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2Red"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedColorBitDepthSubChannel2Red => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2Red, PropertyUnit.Bits);
                #endregion

                #region [public] {static} (IPropertyKey) SupportedColorBitDepthSubChannel0CbPb: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Supported Color Bit-Depth of Sub-Channel 0 (Cb/Pb).</para>
                /// <para>The possible values are shown below:</para>
                /// <para>
                ///  <list type="bullet">
                ///   <item><description>00h  No Information.</description></item>
                ///   <item><description>01h - 10h  Bits per color value.</description></item>
                ///   <item><description>11h - FFh  Reserved.</description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0CbPb"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedColorBitDepthSubChannel0CbPb => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0CbPb, PropertyUnit.Bits);
                #endregion

                #region [public] {static} (IPropertyKey) SupportedColorBitDepthSubChannel1Y: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Supported Color Bit-Depth of Sub-Channel 1 (Y).</para>
                /// <para>The possible values are shown below:</para>
                /// <para>
                ///  <list type="bullet">
                ///   <item><description>00h  No Information.</description></item>
                ///   <item><description>01h - 10h  Bits per color value.</description></item>
                ///   <item><description>11h - FFh  Reserved.</description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Y"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedColorBitDepthSubChannel1Y => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Y, PropertyUnit.Bits);
                #endregion

                #region [public] {static} (IPropertyKey) SupportedColorBitDepthSubChannel2CrPr: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Supported Color Bit-Depth of Sub-Channel 2 (Cr/Pr).</para>
                /// <para>The possible values are shown below:</para>
                /// <para>
                ///  <list type="bullet">
                ///   <item><description>00h  No Information.</description></item>
                ///   <item><description>01h - 10h  Bits per color value.</description></item>
                ///   <item><description>11h - FFh  Reserved.</description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2CrPr"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedColorBitDepthSubChannel2CrPr => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2CrPr, PropertyUnit.Bits);
                #endregion

                #region [public] {static} (IPropertyKey) AspectRatioConversionModes: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Aspect Ratio Conversion Modes.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.AspectRatioConversionModes"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey AspectRatioConversionModes => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.AspectRatioConversionModes);
                #endregion

                #region [public] {static} (IPropertyKey) PacketizedDigitalVideoSupportInformation: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Aspect Ratio Conversion Modes. All 16 Bytes are reserved (must be set to 00h).<br/>
                /// These Bytes will be defined in a future revision to the DI-EXT Standard
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayCapabilitiesAndFeatureSupportSet.PacketizedDigitalVideoSupportInformation"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey PacketizedDigitalVideoSupportInformation => new PropertyKey(DiSection.DisplayCapabilitiesAndFeatureSupportSet, DiProperty.DisplayCapabilitiesAndFeatureSupportSet.PacketizedDigitalVideoSupportInformation);
                #endregion
            }
            #endregion

            #region [public] {static} (class) UnusedBytes: Definition of keys in the 'Unused Bytes' section
            /// <summary>
            /// Definition of keys in the <see cref="DiSection.UnusedBytes"/> section.
            /// </summary>
            public static class UnusedBytes
            {
                #region [public] {static} (IPropertyKey) Data: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Aspect Ratio Conversion Modes. All 17 Bytes are reserved (must be set to 00h).<br/>
                /// These Bytes will be defined in a future revision to the DI-EXT Standard.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.UnusedBytes"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.UnusedBytes.Data"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Data => new PropertyKey(DiSection.UnusedBytes, DiProperty.UnusedBytes.Data);
                #endregion
            }
            #endregion

            #region [public] {static} (class) AudioSupport: Definition of keys in the 'Audio Support' section
            /// <summary>
            /// Definition of keys in the <see cref="DiSection.AudioSupport"/> section.
            /// </summary>
            public static class AudioSupport
            {
                #region [public] {static} (IPropertyKey) Data: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>
                /// Aspect Ratio Conversion Modes. All 9 Bytes are reserved (must be set to 00h).<br/>
                /// These Bytes will be defined in a future revision to the DI-EXT Standard.
                /// </para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.AudioSupport"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.AudioSupport.Data"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Data => new PropertyKey(DiSection.AudioSupport, DiProperty.UnusedBytes.Data);
                #endregion
            }
            #endregion

            #region [public] {static} (class) DisplayTransferCharacteristic: Definition of keys in the 'Display Transfer Characteristic' section
            /// <summary>
            /// Definition of keys in the <see cref="DiSection.DisplayTransferCharacteristic "/> section.
            /// </summary>
            public static class DisplayTransferCharacteristic
            {
                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Combined (White) or Separate (RGB) Sub-Channels.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayTransferCharacteristic"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayTransferCharacteristic.Status"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(DiSection.DisplayTransferCharacteristic, DiProperty.DisplayTransferCharacteristic.Status);
                #endregion

                #region [public] {static} (IPropertyKey) NumberLuminanceEntries: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Number of Luminance Entries.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DiSection.DisplayTransferCharacteristic"/></description></item>
                ///   <item><description>Property: <see cref="DiProperty.DisplayTransferCharacteristic.NumberLuminanceEntries"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey NumberLuminanceEntries => new PropertyKey(DiSection.DisplayTransferCharacteristic, DiProperty.DisplayTransferCharacteristic.NumberLuminanceEntries);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Miscellaneous: Definition of keys in the 'Miscellaneous Items' section
            /// <summary>
            /// Definition of keys in the <see cref="DiSection.Miscellaneous"/> section.
            /// </summary>
            public static class Miscellaneous
            {
                /// <summary>
                /// 
                /// </summary>
                public static class Checksum
                {
                    #region [public] {static} (IPropertyKey) Ok: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Indicates if is a valid <see cref="DI"/> structure.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="DiSection.Miscellaneous"/></description></item>
                    ///   <item><description>Property: <see cref="DiProperty.Miscellaneous.Checksum.Ok"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Ok => new PropertyKey(DiSection.Miscellaneous, DiProperty.Miscellaneous.Checksum.Ok);
                    #endregion

                    #region [public] {static} (IPropertyKey) Value: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Contains checksum byte block value.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="DiSection.Miscellaneous"/></description></item>
                    ///   <item><description>Property: <see cref="DiProperty.Miscellaneous.Checksum.Value"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="byte"/>.</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Value => new PropertyKey(DiSection.Miscellaneous, DiProperty.Miscellaneous.Checksum.Value);
                    #endregion
                }
            }
            #endregion
        }
        #endregion

        #region [public] {static} (class) DisplayID: Definition of keys in the 'DisplayID' block
        /// <summary>
        /// Definition of keys in the <see cref="KnownDataBlock.DisplayID"/> block.
        /// </summary>
        public static class DisplayID
        {
            #region [public] {static} (class) General: Definition of keys in the 'General' section
            /// <summary>
            /// Definition of keys in the <see cref="DisplayIdSection.General"/> section.
            /// </summary>
            public static class General
            {
                #region [public] {static} (IPropertyKey) DisplayProduct: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Display Product Type Identifier.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DisplayIdSection.General"/></description></item>
                ///   <item><description>Property: <see cref="DisplayIdProperty.General.Data.DisplayProduct"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DisplayProduct => new PropertyKey(DisplayIdSection.General, DisplayIdProperty.General.Data.DisplayProduct);
                #endregion

                #region [public] {static} (IPropertyKey) ExtensionCount: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Extension Count.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DisplayIdSection.General"/></description></item>
                ///   <item><description>Property: <see cref="DisplayIdProperty.General.Data.ExtensionCount"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ExtensionCount => new PropertyKey(DisplayIdSection.General, DisplayIdProperty.General.Data.ExtensionCount);
                #endregion

                #region [public] {static} (IPropertyKey) Version: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Implemented version number.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DisplayIdSection.General"/></description></item>
                ///   <item><description>Property: <see cref="DisplayIdProperty.General.Version.Number"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Version => new PropertyKey(DisplayIdSection.General, DisplayIdProperty.General.Version.Number);
                #endregion

                #region [public] {static} (IPropertyKey) Revision: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Implemented revision number.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DisplayIdSection.General"/></description></item>
                ///   <item><description>Property: <see cref="DisplayIdProperty.General.Version.Revision"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Revision => new PropertyKey(DisplayIdSection.General, DisplayIdProperty.General.Version.Revision);
                #endregion
            }
            #endregion

            #region [public] {static} (class) DataBlocks: Definition of keys in the 'DataBlocks' section
            /// <summary>
            /// Definition of keys in the <see cref="DisplayIdSection.DataBlocks"/> section.
            /// </summary>
            public static class DataBlocks
            {
                #region [public] {static} (IPropertyKey) ImplementedBlocks: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Implemented Data Blocks.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="DisplayIdSection.DataBlocks"/></description></item>
                ///   <item><description>Property: <see cref="DisplayIdProperty.DataBlocks.Implemented.ImplementedBlocks"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="DataBlockData"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ImplementedBlocks => new PropertyKey(DisplayIdSection.DataBlocks, DisplayIdProperty.DataBlocks.Implemented.ImplementedBlocks);
                #endregion


                #region [public] {static} (class) Blocks: Definition of keys for a known data blocks
                /// <summary>
                /// Definition of properties for a known data blocks.
                /// </summary>
                public static class Blocks
                {
                    #region [public] {static} (class) VendorSpecific: Definition of keys for a 'Vendor Specific' data block
                    /// <summary>
                    /// Definition of properties for a <b>Vendor Specific</b> data block.
                    /// </summary>
                    public static class VendorSpecific
                    {
                        #region [public] {static} (IPropertyKey) Data: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Vendor-Specific data.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="DisplayIdSection.DataBlocks"/></description></item>
                        ///   <item><description>Property: <see cref="DisplayIdProperty.DataBlocks.Blocks.VendorSpecific.Data"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/>.</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Data => new PropertyKey(DisplayIdSection.DataBlocks, DisplayIdProperty.DataBlocks.Blocks.VendorSpecific.Data);
                        #endregion

                        #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Manufacturer/Vendor ID.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="DisplayIdSection.DataBlocks"/></description></item>
                        ///   <item><description>Property: <see cref="DisplayIdProperty.DataBlocks.Blocks.VendorSpecific.Manufacturer"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        ///  <para>Type: <see cref="string"/>.</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Manufacturer => new PropertyKey(DisplayIdSection.DataBlocks, DisplayIdProperty.DataBlocks.Blocks.VendorSpecific.Manufacturer);
                        #endregion

                    }
                    #endregion
                }
                #endregion
            }
            #endregion

            #region [public] {static} (class) Miscellaneous: Definition of keys in the 'Miscellaneous' section
            /// <summary>
            /// Definition of keys in the <see cref="DisplayIdSection.Miscellaneous"/> section.
            /// </summary>
            public static class Miscellaneous
            {
                #region [public] {static} (class) CheckSum: Definition of keys in the 'CheckSum' section
                /// <summary>
                /// Definition of keys in the <b>CheckSum</b> section.
                /// </summary>
                public static class CheckSum
                {
                    #region [public] {static} (IPropertyKey) Ok: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Indicates if is a valid <see cref="DisplayID"/> structure.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="DisplayIdSection.Miscellaneous"/></description></item>
                    ///   <item><description>Property: <see cref="DisplayIdProperty.Miscellaneous.CheckSum.Ok"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Ok => new PropertyKey(DisplayIdSection.Miscellaneous, DisplayIdProperty.Miscellaneous.CheckSum.Ok);
                    #endregion

                    #region [public] {static} (IPropertyKey) Value: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Contains checksum byte block value.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="DisplayIdSection.Miscellaneous"/></description></item>
                    ///   <item><description>Property: <see cref="DisplayIdProperty.Miscellaneous.CheckSum.Value"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="byte"/>.</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Value => new PropertyKey(DisplayIdSection.Miscellaneous, DisplayIdProperty.Miscellaneous.CheckSum.Value);
                    #endregion
                }
                #endregion
            }
            #endregion
        }
        #endregion
    }
}
