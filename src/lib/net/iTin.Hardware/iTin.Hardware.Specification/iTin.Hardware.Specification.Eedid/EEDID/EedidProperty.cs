
namespace iTin.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;

    using iTin.Core.Hardware.Common;

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
            /// Definition of keys in the <see cref="KnownEdidSection.Header"/> section.
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.Header"/></description></item>
                ///   <item><description>Property: <see cref="EdidHeaderProperty.Signature"/></description></item>
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
                public static IPropertyKey Signature => new PropertyKey(KnownEdidSection.Header, EdidHeaderProperty.Signature);
                #endregion

                #region [public] {static} (IPropertyKey) IsValid: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if is a <see cref="EEDID"/> valid.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.Header"/></description></item>
                ///   <item><description>Property: <see cref="EdidHeaderProperty.IsValid"/></description></item>
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
                public static IPropertyKey IsValid => new PropertyKey(KnownEdidSection.Header, EdidHeaderProperty.IsValid);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Vendor: Definition of keys in the 'Vendor and Product' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.Vendor"/> section.
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.Vendor"/></description></item>
                ///   <item><description>Property: <see cref="EdidVendorProperty.IdManufacturerName"/></description></item>
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
                public static IPropertyKey IdManufacturerName => new PropertyKey(KnownEdidSection.Vendor, EdidVendorProperty.IdManufacturerName);
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.Vendor"/></description></item>
                ///   <item><description>Property: <see cref="EdidVendorProperty.IdProductCode"/></description></item>
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
                public static IPropertyKey IdProductCode => new PropertyKey(KnownEdidSection.Vendor, EdidVendorProperty.IdProductCode);
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.Vendor"/></description></item>
                ///   <item><description>Property: <see cref="EdidVendorProperty.IdSerialNumber"/></description></item>
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
                public static IPropertyKey IdSerialNumber => new PropertyKey(KnownEdidSection.Vendor, EdidVendorProperty.IdSerialNumber);
                #endregion

                #region [public] {static} (IPropertyKey) WeekOfManufactureOrModelYear: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Contains a week number or model year.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.Vendor"/></description></item>
                ///   <item><description>Property: <see cref="EdidVendorProperty.WeekOfManufactureOrModelYear"/></description></item>
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
                public static IPropertyKey WeekOfManufactureOrModelYear => new PropertyKey(KnownEdidSection.Vendor, EdidVendorProperty.WeekOfManufactureOrModelYear);
                #endregion

                #region [public] {static} (IPropertyKey) YearOfManufactureOrModelYear: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Contains the manufacture year or model year.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.Vendor"/></description></item>
                ///   <item><description>Property: <see cref="EdidVendorProperty.YearOfManufactureOrModelYear"/></description></item>
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
                public static IPropertyKey YearOfManufactureOrModelYear => new PropertyKey(KnownEdidSection.Vendor, EdidVendorProperty.YearOfManufactureOrModelYear);
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.Vendor"/></description></item>
                ///   <item><description>Property: <see cref="EdidVendorProperty.ManufactureDate"/></description></item>
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
                public static IPropertyKey ManufactureDate => new PropertyKey(KnownEdidSection.Vendor, EdidVendorProperty.ManufactureDate);
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.Vendor"/></description></item>
                ///   <item><description>Property: <see cref="EdidVendorProperty.ModelYearStrategy"/></description></item>
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
                public static IPropertyKey ModelYearStrategy => new PropertyKey(KnownEdidSection.Vendor, EdidVendorProperty.ModelYearStrategy);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Version: Definition of keys in the 'Version and Revision' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.Version"/> section.
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.Version"/></description></item>
                ///   <item><description>Property: <see cref="EdidVersionProperty.Version"/></description></item>
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
                public static IPropertyKey Number => new PropertyKey(KnownEdidSection.Version, EdidVersionProperty.Version);
                #endregion

                #region [public] {static} (IPropertyKey) Revision: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Implemented revision number.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.Version"/></description></item>
                ///   <item><description>Property: <see cref="EdidVersionProperty.Revision"/></description></item>
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
                public static IPropertyKey Revision => new PropertyKey(KnownEdidSection.Version, EdidVersionProperty.Revision);
                #endregion
            }
            #endregion

            #region [public] {static} (class) BasicDisplay: Definition of keys in the 'Basic Display Parameters and Features' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.BasicDisplay"/> section.
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.VideoInputDefinition"/></description></item>
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
                public static IPropertyKey VideoInputDefinition => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.VideoInputDefinition);
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.HorizontalScreenSize"/></description></item>
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
                public static IPropertyKey HorizontalScreenSize => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.HorizontalScreenSize, PropertyUnit.cm);
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.VerticalScreenSize"/></description></item>
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
                public static IPropertyKey VerticalScreenSize => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.VerticalScreenSize, PropertyUnit.cm);
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.Gamma"/></description></item>
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
                public static IPropertyKey Gamma => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.Gamma);
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
                    ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                    ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.AnalogSignalLevelStandard"/></description></item>
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
                    public static IPropertyKey SignalLevelStandard => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.AnalogSignalLevelStandard);
                    #endregion

                    #region [public] {static} (IPropertyKey) VideoSetup: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Video setup. Blank level.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                    ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.AnalogVideoSetup"/></description></item>
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
                    public static IPropertyKey VideoSetup => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.AnalogVideoSetup);
                    #endregion

                    #region [public] {static} (IPropertyKey) VerticalSyncSupported: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Indicates if vertical synchronization is supported.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                    ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.AnalogVerticalSyncSupported"/></description></item>
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
                    public static IPropertyKey VerticalSyncSupported => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.AnalogVerticalSyncSupported);
                    #endregion

                    #region [public] {static} (IPropertyKey) DisplayColorType: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Analog display color type.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                    ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.AnalogDisplayColorType"/></description></item>
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
                    public static IPropertyKey DisplayColorType => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.AnalogDisplayColorType);
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
                        ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.AnalogSeparateSyncSupported"/></description></item>
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
                        public static IPropertyKey SeparateSyncSupported => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.AnalogSeparateSyncSupported);
                        #endregion

                        #region [public] {static} (IPropertyKey) CompositeSyncSignalHorizontalSupported: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if composite synchronization signal on horizontal is supported.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.AnalogCompositeSyncSignalHorizontalSupported"/></description></item>
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
                        public static IPropertyKey CompositeSyncSignalHorizontalSupported => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.AnalogCompositeSyncSignalHorizontalSupported);
                        #endregion

                        #region [public] {static} (IPropertyKey) CompositeSyncSignalGreenVideoSupported: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if composite synchronization signal on green video is supported.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.AnalogCompositeSyncSignalGreenVideoSupported"/></description></item>
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
                        public static IPropertyKey CompositeSyncSignalGreenVideoSupported => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.AnalogCompositeSyncSignalGreenVideoSupported);
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
                    ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                    ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.DigitalColorBitDepth"/></description></item>
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
                    public static IPropertyKey ColorBitDepth => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.DigitalColorBitDepth);
                    #endregion

                    #region [public] {static} (IPropertyKey) VideoInterface: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Returns a <see cref="string"/> value indicating if is a digital or analog video interface.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                    ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.DigitalVideoInterface"/></description></item>
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
                    public static IPropertyKey VideoInterface => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.DigitalVideoInterface);
                    #endregion

                    #region [public] {static} (IPropertyKey) ColorEncodingFormat: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Supported color encoding format.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                    ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.DigitalColorEncodingFormat"/></description></item>
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
                    public static IPropertyKey ColorEncodingFormat => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.DigitalColorEncodingFormat);
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
                        ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.SrgbDefaultColorSpace"/></description></item>
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
                        public static IPropertyKey IsSrgbDefaultColorSpace => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.SrgbDefaultColorSpace);
                        #endregion

                        #region [public] {static} (IPropertyKey) IncludePreferredTimingMode: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if preferred timing Mmde includes the native pixel format and preferred refresh rate of the display device.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.PreferredTimingMode"/></description></item>
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
                        public static IPropertyKey IncludePreferredTimingMode => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.PreferredTimingMode);
                        #endregion

                        #region [public] {static} (IPropertyKey) IsContinuousFrequency: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if display is continuous frequency.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.ContinuousFrequency"/></description></item>
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
                        public static IPropertyKey IsContinuousFrequency => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.ContinuousFrequency);
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
                        ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.StandbyModeSupported"/></description></item>
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
                        public static IPropertyKey StandbyModeSupported => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.StandbyModeSupported);
                        #endregion

                        #region [public] {static} (IPropertyKey) SuspendModeSupported: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if suspend mode is supported.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.SuspendModeSupported"/></description></item>
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
                        public static IPropertyKey SuspendModeSupported => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.SuspendModeSupported);
                        #endregion

                        #region [public] {static} (IPropertyKey) ActiveOffSupported: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if very low power is supported.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="KnownEdidSection.BasicDisplay"/></description></item>
                        ///   <item><description>Property: <see cref="EdidBasicDisplayProperty.ActiveOffSupported"/></description></item>
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
                        public static IPropertyKey ActiveOffSupported => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.ActiveOffSupported);
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
            /// Definition of keys in the <see cref="KnownEdidSection.ColorCharacteristics"/> section.
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.ColorCharacteristics"/></description></item>
                ///   <item><description>Property: <see cref="EdidColorCharacteristicsProperty.Red"/></description></item>
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
                public static IPropertyKey Red => new PropertyKey(KnownEdidSection.ColorCharacteristics, EdidColorCharacteristicsProperty.Red);
                #endregion

                #region [public] {static} (IPropertyKey) Green: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Green chromaticity point.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.ColorCharacteristics"/></description></item>
                ///   <item><description>Property: <see cref="EdidColorCharacteristicsProperty.Green"/></description></item>
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
                public static IPropertyKey Green => new PropertyKey(KnownEdidSection.ColorCharacteristics, EdidColorCharacteristicsProperty.Green);
                #endregion

                #region [public] {static} (IPropertyKey) Blue: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Blue chromaticity point.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.ColorCharacteristics"/></description></item>
                ///   <item><description>Property: <see cref="EdidColorCharacteristicsProperty.Blue"/></description></item>
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
                public static IPropertyKey Blue => new PropertyKey(KnownEdidSection.ColorCharacteristics, EdidColorCharacteristicsProperty.Blue);
                #endregion

                #region [public] {static} (IPropertyKey) White: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>White chromaticity point.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.ColorCharacteristics"/></description></item>
                ///   <item><description>Property: <see cref="EdidColorCharacteristicsProperty.White"/></description></item>
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
                public static IPropertyKey White => new PropertyKey(KnownEdidSection.ColorCharacteristics, EdidColorCharacteristicsProperty.White);
                #endregion
            }
            #endregion

            #region [public] {static} (class) EstablishedTimings: Definition of keys in the 'Established Timings I, II' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.EstablishedTimings"/> section.
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.EstablishedTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidEstablishedTimingsProperty.Resolutions"/></description></item>
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
                public static IPropertyKey Resolutions => new PropertyKey(KnownEdidSection.EstablishedTimings, EdidEstablishedTimingsProperty.Resolutions);
                #endregion
            }
            #endregion

            #region [public] {static} (class) StandardTimings: Definition of keys in the 'Standard Timings 16 Bytes' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.StandardTimings"/> section.
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidStandardTimingProperty.Timing1"/></description></item>
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
                public static IPropertyKey Timing1 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing1);
                #endregion

                #region [public] {static} (IPropertyKey) Timing2: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidStandardTimingProperty.Timing2"/></description></item>
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
                public static IPropertyKey Timing2 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing2);
                #endregion

                #region [public] {static} (IPropertyKey) Timing3: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidStandardTimingProperty.Timing3"/></description></item>
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
                public static IPropertyKey Timing3 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing3);
                #endregion

                #region [public] {static} (IPropertyKey) Timing4: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidStandardTimingProperty.Timing4"/></description></item>
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
                public static IPropertyKey Timing4 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing4);
                #endregion

                #region [public] {static} (IPropertyKey) Timing5: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidStandardTimingProperty.Timing5"/></description></item>
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
                public static IPropertyKey Timing5 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing5);
                #endregion

                #region [public] {static} (IPropertyKey) Timing6: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidStandardTimingProperty.Timing6"/></description></item>
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
                public static IPropertyKey Timing6 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing6);
                #endregion

                #region [public] {static} (IPropertyKey) Timing7: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidStandardTimingProperty.Timing7"/></description></item>
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
                public static IPropertyKey Timing7 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing7);
                #endregion

                #region [public] {static} (IPropertyKey) Timing8: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standard timming definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.StandardTimings"/></description></item>
                ///   <item><description>Property: <see cref="EdidStandardTimingProperty.Timing8"/></description></item>
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
                public static IPropertyKey Timing8 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing8);
                #endregion
            }
            #endregion

            #region [public] {static} (class) DataBlock: Definition of keys in the '18 Byte Data Blocks Descriptors' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.DataBlocks"/> section.
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
                ///   <item><description>Property: <see cref="EdidDataBlockProperty.Descriptor1"/></description></item>
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
                public static IPropertyKey Descriptor1 => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockProperty.Descriptor1);
                #endregion

                #region [public] {static} (IPropertyKey) Descriptor2: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>DataBlock definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
                ///   <item><description>Property: <see cref="EdidDataBlockProperty.Descriptor2"/></description></item>
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
                public static IPropertyKey Descriptor2 => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockProperty.Descriptor2);
                #endregion

                #region [public] {static} (IPropertyKey) Descriptor3: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>DataBlock definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
                ///   <item><description>Property: <see cref="EdidDataBlockProperty.Descriptor3"/></description></item>
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
                public static IPropertyKey Descriptor3 => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockProperty.Descriptor3);
                #endregion

                #region [public] {static} (IPropertyKey) Descriptor4: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>DataBlock definition.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
                ///   <item><description>Property: <see cref="EdidDataBlockProperty.Descriptor4"/></description></item>
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
                public static IPropertyKey Descriptor4 => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockProperty.Descriptor4);
                #endregion

                #endregion


                #region nested classes

                #region [public] {static} (class) Definition: Definition of keys in the 'DataBlocks'.
                /// <summary>
                /// Definition of keys in the <see cref="KnownEdidSection.DataBlocks"/>.
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
                        ///   <item><description>Property: <see cref="AlphanumericDataStringDescriptorProperty.Text"/></description></item>
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
                        public static IPropertyKey Data => new PropertyKey(EdidDataBlockDescriptor.AlphaNumericDataString, AlphanumericDataStringDescriptorProperty.Text);
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
                        ///   <item><description>Property: <see cref="ColorManagementDataDescriptorProperty.Version"/></description></item>
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
                        public static IPropertyKey VersionNumber => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, ColorManagementDataDescriptorProperty.Version);
                        #endregion

                        #region [public] {static} (IPropertyKey) Red: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains the display color management polynomial coefficient.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></description></item>
                        ///   <item><description>Property: <see cref="ColorManagementDataDescriptorProperty.Red"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="ColorManagementDataDescriptorItemProperty"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Red => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, ColorManagementDataDescriptorProperty.Red);
                        #endregion

                        #region [public] {static} (IPropertyKey) Green: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains the display color management polynomial coefficient.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></description></item>
                        ///   <item><description>Property: <see cref="ColorManagementDataDescriptorProperty.Green"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="ColorManagementDataDescriptorItemProperty"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Green => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, ColorManagementDataDescriptorProperty.Green);
                        #endregion

                        #region [public] {static} (IPropertyKey) Blue: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains the display color management polynomial coefficient.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></description></item>
                        ///   <item><description>Property: <see cref="ColorManagementDataDescriptorProperty.Blue"/></description></item>
                        ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                        ///  </list>
                        /// </para>
                        /// <para>
                        ///  <para><b>Return Value</b></para>
                        /// <para>Type: <see cref="ColorManagementDataDescriptorItemProperty"/>.</para>
                        /// </para>
                        /// <para>
                        ///  <para><b>Remarks</b></para>
                        ///  <para>1.4</para>
                        /// </para>
                        /// </summary>
                        public static IPropertyKey Blue => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, ColorManagementDataDescriptorProperty.Blue);
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
                            ///   <item><description>Property: <see cref="ColorManagementDataDescriptorItemProperty.A2"/></description></item>
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
                            public static IPropertyKey A2 => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, ColorManagementDataDescriptorItemProperty.A2);
                            #endregion

                            #region [public] {static} (IPropertyKey) A3: Gets a value representing the key to retrieve the property value
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property value.</para>
                            /// <para>Contains the most significant byte.</para>
                            /// <para>
                            ///  <para><b>Key Composition</b></para>
                            ///  <list type="bullet">
                            ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></description></item>
                            ///   <item><description>Property: <see cref="ColorManagementDataDescriptorItemProperty.A3"/></description></item>
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
                            public static IPropertyKey A3 => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, ColorManagementDataDescriptorItemProperty.A3);
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
                        ///   <item><description>Property: <see cref="ColorPointDataDescriptorProperty.Point1"/></description></item>
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
                        public static IPropertyKey Point1 => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, ColorPointDataDescriptorProperty.Point1);
                        #endregion

                        #region [public] {static} (IPropertyKey) Point2: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains the additional point descriptor information.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorPointData"/></description></item>
                        ///   <item><description>Property: <see cref="ColorPointDataDescriptorProperty.Point2"/></description></item>
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
                        public static IPropertyKey Point2 => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, ColorPointDataDescriptorProperty.Point2);
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
                            ///   <item><description>Property: <see cref="ColorPointDataDescriptorItemProperty.Index"/></description></item>
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
                            public static IPropertyKey Index => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, ColorPointDataDescriptorItemProperty.Index);
                            #endregion

                            #region [public] {static} (IPropertyKey) White: Gets a value representing the key to retrieve the property value
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property value.</para>
                            /// <para>White point values.</para>
                            /// <para>
                            ///  <para><b>Key Composition</b></para>
                            ///  <list type="bullet">
                            ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorPointData"/></description></item>
                            ///   <item><description>Property: <see cref="ColorPointDataDescriptorItemProperty.White"/></description></item>
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
                            public static IPropertyKey White => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, ColorPointDataDescriptorItemProperty.White);
                            #endregion

                            #region [public] {static} (IPropertyKey) Gamma: Gets a value representing the key to retrieve the property value
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property value.</para>
                            /// <para>Gamma value.</para>
                            /// <para>
                            ///  <para><b>Key Composition</b></para>
                            ///  <list type="bullet">
                            ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.ColorPointData"/></description></item>
                            ///   <item><description>Property: <see cref="ColorPointDataDescriptorItemProperty.Gamma"/></description></item>
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
                            public static IPropertyKey Gamma => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, ColorPointDataDescriptorItemProperty.Gamma);
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
                        ///   <item><description>Property: <see cref="Cvt3ByteCodeDescriptorProperty.Version"/></description></item>
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
                        public static IPropertyKey VersionNumber => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorProperty.Version);
                        #endregion

                        #region [public] {static} (IPropertyKey) Priority1: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains CVT descriptor.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                        ///   <item><description>Property: <see cref="Cvt3ByteCodeDescriptorProperty.Priority1"/></description></item>
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
                        public static IPropertyKey Priority1 => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorProperty.Priority1);
                        #endregion

                        #region [public] {static} (IPropertyKey) Priority2: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains CVT descriptor.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                        ///   <item><description>Property: <see cref="Cvt3ByteCodeDescriptorProperty.Priority2"/></description></item>
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
                        public static IPropertyKey Priority2 => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorProperty.Priority2);
                        #endregion

                        #region [public] {static} (IPropertyKey) Priority3: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains CVT descriptor.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                        ///   <item><description>Property: <see cref="Cvt3ByteCodeDescriptorProperty.Priority3"/></description></item>
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
                        public static IPropertyKey Priority3 => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorProperty.Priority3);
                        #endregion

                        #region [public] {static} (IPropertyKey) Priority4: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Contains CVT descriptor.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                        ///   <item><description>Property: <see cref="Cvt3ByteCodeDescriptorProperty.Priority4"/></description></item>
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
                        public static IPropertyKey Priority4 => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorProperty.Priority4);
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
                            ///   <item><description>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.AddressableVerticalLines"/></description></item>
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
                            public static IPropertyKey AddressableVerticalLines => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.AddressableVerticalLines, PropertyUnit.Lines);
                            #endregion

                            #region [public] {static} (IPropertyKey) AspectRatio: Gets a value representing the key to retrieve the property value
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property value.</para>
                            /// <para>Aspect ratio value.</para>
                            /// <para>
                            ///  <para><b>Key Composition</b></para>
                            ///  <list type="bullet">
                            ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                            ///   <item><description>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.AspectRatio"/></description></item>
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
                            public static IPropertyKey AspectRatio => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.AspectRatio);
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
                            ///   <item><description>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.PreferredVerticalRate"/></description></item>
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
                            public static IPropertyKey PreferredVerticalRate => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.PreferredVerticalRate, PropertyUnit.Hz);
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
                                ///   <item><description>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.IsSupported50HzWithStandardBlanking"/></description></item>
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
                                public static IPropertyKey IsSupported50HzWithStandardBlanking => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.IsSupported50HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (IPropertyKey) IsSupported60HzWithStandardBlanking: Gets a value representing the key to retrieve the property value
                                /// <summary>
                                /// <para>Gets a value representing the key to retrieve the property value.</para>
                                /// <para>Indicates if is supported 60Hz with standard blanking.</para>
                                /// <para>
                                ///  <para><b>Key Composition</b></para>
                                ///  <list type="bullet">
                                ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                                ///   <item><description>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.IsSupported60HzWithStandardBlanking"/></description></item>
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
                                public static IPropertyKey IsSupported60HzWithStandardBlanking => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.IsSupported60HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (IPropertyKey) IsSupported75HzWithStandardBlanking: Gets a value representing the key to retrieve the property value
                                /// <summary>
                                /// <para>Gets a value representing the key to retrieve the property value.</para>
                                /// <para>Indicates if is supported 75Hz with standard blanking.</para>
                                /// <para>
                                ///  <para><b>Key Composition</b></para>
                                ///  <list type="bullet">
                                ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                                ///   <item><description>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.IsSupported75HzWithStandardBlanking"/></description></item>
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
                                public static IPropertyKey IsSupported75HzWithStandardBlanking => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.IsSupported75HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (IPropertyKey) IsSupported85HzWithStandardBlanking: Gets a value representing the key to retrieve the property value
                                /// <summary>
                                /// <para>Gets a value representing the key to retrieve the property value.</para>
                                /// <para>Indicates if is supported 85Hz with standard blanking.</para>
                                /// <para>
                                ///  <para><b>Key Composition</b></para>
                                ///  <list type="bullet">
                                ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                                ///   <item><description>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.IsSupported85HzWithStandardBlanking"/></description></item>
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
                                public static IPropertyKey IsSupported85HzWithStandardBlanking => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.IsSupported85HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (IPropertyKey) IsSupported60HzWithReducedBlanking: Gets a value representing the key to retrieve the property value
                                /// <summary>
                                /// <para>Gets a value representing the key to retrieve the property value.</para>
                                /// <para>Indicates if is supported 60Hz with reduced blanking.</para>
                                /// <para>
                                ///  <para><b>Key Composition</b></para>
                                ///  <list type="bullet">
                                ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></description></item>
                                ///   <item><description>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.IsSupported60HzWithReducedBlanking"/></description></item>
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
                                public static IPropertyKey IsSupported60HzWithReducedBlanking => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.IsSupported60HzWithReducedBlanking);
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
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.PixelClock"/></description></item>
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
                        public static IPropertyKey PixelClock => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.PixelClock, PropertyUnit.KHz);
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
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.HorizontalResolution"/></description></item>
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
                        public static IPropertyKey HorizontalResolution => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.HorizontalResolution, PropertyUnit.Pixels);
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
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.HorizontalResolution"/></description></item>
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
                        public static IPropertyKey HorizontalBlanking => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.HorizontalBlanking, PropertyUnit.Pixels);
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
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.VerticalLines"/></description></item>
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
                        public static IPropertyKey VerticalLines => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.VerticalLines, PropertyUnit.Lines);
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
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.VerticalBlanking"/></description></item>
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
                        public static IPropertyKey VerticalBlanking => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.VerticalBlanking, PropertyUnit.Lines);
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
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.HorizontalFrontPorch"/></description></item>
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
                        public static IPropertyKey HorizontalFrontPorch => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.HorizontalFrontPorch, PropertyUnit.Pixels);
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
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.HorizontalSyncPulseWidth"/></description></item>
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
                        public static IPropertyKey HorizontalSyncPulseWidth => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.HorizontalSyncPulseWidth, PropertyUnit.Pixels);
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
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.VerticalFrontPorch"/></description></item>
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
                        public static IPropertyKey VerticalFrontPorch => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.VerticalFrontPorch, PropertyUnit.Lines);
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
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.VerticalSyncPulseWidth"/></description></item>
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
                        public static IPropertyKey VerticalSyncPulseWidth => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.VerticalSyncPulseWidth, PropertyUnit.Lines);
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
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.HorizontalImageSize"/></description></item>
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
                        public static IPropertyKey HorizontalImageSize => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.HorizontalImageSize, PropertyUnit.mm);
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
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.VerticalImageSize"/></description></item>
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
                        public static IPropertyKey VerticalImageSize => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.VerticalImageSize, PropertyUnit.mm);
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
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.HorizontalBorder"/></description></item>
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
                        public static IPropertyKey HorizontalBorder => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.HorizontalBorder, PropertyUnit.Pixels);
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
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.VerticalBorder"/></description></item>
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
                        public static IPropertyKey VerticalBorder => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.VerticalBorder, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (IPropertyKey) IsInterlaced: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Indicates if is interlaced.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.Interlaced"/></description></item>
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
                        public static IPropertyKey IsInterlaced => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.Interlaced);
                        #endregion

                        #region [public] {static} (IPropertyKey) StereoViewingSupport: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Stereo viewing support value.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.StereoViewingSupport"/></description></item>
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
                        public static IPropertyKey StereoViewingSupport => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.StereoViewingSupport);
                        #endregion

                        #region [public] {static} (IPropertyKey) SyncSignalType: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Sync signal type.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></description></item>
                        ///   <item><description>Property: <see cref="DetailedTimingModeDescriptorProperty.SyncSignalType"/></description></item>
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
                        public static IPropertyKey SyncSignalType => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.SyncSignalType);
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
                        ///   <item><description>Property: <see cref="DisplayProductNameDescriptorProperty.Text"/></description></item>
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
                        public static IPropertyKey Data => new PropertyKey(EdidDataBlockDescriptor.DisplayProductName, DisplayProductNameDescriptorProperty.Text);
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
                        ///   <item><description>Property: <see cref="DisplayProductSerialNumberDescriptorProperty.Text"/></description></item>
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
                        public static IPropertyKey Data => new PropertyKey(EdidDataBlockDescriptor.DisplayProductSerialNumber, DisplayProductSerialNumberDescriptorProperty.Text);
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
                        ///   <item><description>Property: <see cref="DisplayRangeLimitsDescriptorProperty.MinimumVerticalRate"/></description></item>
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
                        public static IPropertyKey MinimumVerticalRate => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, DisplayRangeLimitsDescriptorProperty.MinimumVerticalRate, PropertyUnit.Hz);
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
                        ///   <item><description>Property: <see cref="DisplayRangeLimitsDescriptorProperty.MaximumVerticalRate"/></description></item>
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
                        public static IPropertyKey MaximumVerticalRate => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, DisplayRangeLimitsDescriptorProperty.MaximumVerticalRate, PropertyUnit.Hz);
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
                        ///   <item><description>Property: <see cref="DisplayRangeLimitsDescriptorProperty.MinimumHorizontalRate"/></description></item>
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
                        public static IPropertyKey MinimumHorizontalRate => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, DisplayRangeLimitsDescriptorProperty.MinimumHorizontalRate, PropertyUnit.KHz);
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
                        ///   <item><description>Property: <see cref="DisplayRangeLimitsDescriptorProperty.MaximumHorizontalRate"/></description></item>
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
                        public static IPropertyKey MaximumHorizontalRate => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, DisplayRangeLimitsDescriptorProperty.MaximumHorizontalRate, PropertyUnit.KHz);
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
                        ///   <item><description>Property: <see cref="DisplayRangeLimitsDescriptorProperty.MaximumPixelClock"/></description></item>
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
                        public static IPropertyKey MaximumPixelClock => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, DisplayRangeLimitsDescriptorProperty.MaximumPixelClock, PropertyUnit.MHz);
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
                        ///   <item><description>Property: <see cref="DummyDataDescriptorProperty.OriginalData"/></description></item>
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
                        public static IPropertyKey OriginalData => new PropertyKey(EdidDataBlockDescriptor.DummyData, DummyDataDescriptorProperty.OriginalData);
                        #endregion

                        #region [public] {static} (IPropertyKey) PrintableData: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Printable data value.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.DummyData"/></description></item>
                        ///   <item><description>Property: <see cref="DummyDataDescriptorProperty.PrintableData"/></description></item>
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
                        public static IPropertyKey PrintableData => new PropertyKey(EdidDataBlockDescriptor.DummyData, DummyDataDescriptorProperty.PrintableData);
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
                        ///   <item><description>Property: <see cref="EstablishedTimingsIIIDescriptorProperty.Revision"/></description></item>
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
                        public static IPropertyKey Revision => new PropertyKey(EdidDataBlockDescriptor.EstablishedTimingsIII, EstablishedTimingsIIIDescriptorProperty.Revision);
                        #endregion

                        #region [public] {static} (IPropertyKey) Resolutions:Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Supported resolutions collection for established timmings iii descriptor.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.EstablishedTimingsIII"/></description></item>
                        ///   <item><description>Property: <see cref="EstablishedTimingsIIIDescriptorProperty.Resolutions"/></description></item>
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
                        public static IPropertyKey Resolutions => new PropertyKey(EdidDataBlockDescriptor.EstablishedTimingsIII, EstablishedTimingsIIIDescriptorProperty.Resolutions);
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
                        ///   <item><description>Property: <see cref="ManufacturerSpecifiedDataDescriptorProperty.Data"/></description></item>
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
                        public static IPropertyKey Data => new PropertyKey(EdidDataBlockDescriptor.ManufacturerSpecifiedData00, ManufacturerSpecifiedDataDescriptorProperty.Data);
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
                        ///   <item><description>Property: <see cref="StandardTimingIdentifierDescriptorProperty.Timing9"/></description></item>
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
                        public static IPropertyKey Timing9 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, StandardTimingIdentifierDescriptorProperty.Timing9);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing10: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Standard timming definition.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></description></item>
                        ///   <item><description>Property: <see cref="StandardTimingIdentifierDescriptorProperty.Timing10"/></description></item>
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
                        public static IPropertyKey Timing10 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, StandardTimingIdentifierDescriptorProperty.Timing10);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing11: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Standard timming definition.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></description></item>
                        ///   <item><description>Property: <see cref="StandardTimingIdentifierDescriptorProperty.Timing11"/></description></item>
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
                        public static IPropertyKey Timing11 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, StandardTimingIdentifierDescriptorProperty.Timing11);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing12: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Standard timming definition.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></description></item>
                        ///   <item><description>Property: <see cref="StandardTimingIdentifierDescriptorProperty.Timing12"/></description></item>
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
                        public static IPropertyKey Timing12 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, StandardTimingIdentifierDescriptorProperty.Timing12);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing13: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Standard timming definition.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></description></item>
                        ///   <item><description>Property: <see cref="StandardTimingIdentifierDescriptorProperty.Timing13"/></description></item>
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
                        public static IPropertyKey Timing13 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, StandardTimingIdentifierDescriptorProperty.Timing13);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing14: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Standard timming definition.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></description></item>
                        ///   <item><description>Property: <see cref="StandardTimingIdentifierDescriptorProperty.Timing14"/></description></item>
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
                        public static IPropertyKey Timing14 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, StandardTimingIdentifierDescriptorProperty.Timing14);
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
                    ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
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
                    public static IPropertyKey AlphaNumericDataString => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.AlphaNumericDataString);
                    #endregion

                    #region [public] {static} (IPropertyKey) ColorManagementData: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the color management datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
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
                    public static IPropertyKey ColorManagementData => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.ColorManagementData);
                    #endregion

                    #region [public] {static} (IPropertyKey) ColorPointData: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the color point data datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
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
                    public static IPropertyKey ColorPointData => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.ColorPointData);
                    #endregion

                    #region [public] {static} (IPropertyKey) CVT3ByteCode: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the CVT3 byte code datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
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
                    public static IPropertyKey CVT3ByteCode => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.Cvt3ByteCode);
                    #endregion

                    #region [public] {static} (IPropertyKey) DetailedTimingMode: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the detailed timming mode datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
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
                    public static IPropertyKey DetailedTimingMode => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.DetailedTimingMode);
                    #endregion

                    #region [public] {static} (IPropertyKey) DisplayProductName: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the display product name datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
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
                    public static IPropertyKey DisplayProductName => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.DisplayProductName);
                    #endregion

                    #region [public] {static} (IPropertyKey) DisplayProductSerialNumber: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the display product serial number datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
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
                    public static IPropertyKey DisplayProductSerialNumber => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.DisplayProductSerialNumber);
                    #endregion

                    #region [public] {static} (IPropertyKey) DisplayRangeLimits: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the display range limit datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
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
                    public static IPropertyKey DisplayRangeLimits => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.DisplayRangeLimits);
                    #endregion

                    #region [public] {static} (IPropertyKey) DummyData: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the dummy data datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
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
                    public static IPropertyKey DummyData => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.DummyData);
                    #endregion

                    #region [public] {static} (IPropertyKey) EstablishedTimingsIII: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the established timmings III datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
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
                    public static IPropertyKey EstablishedTimingsIII => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.EstablishedTimingsIII);
                    #endregion

                    #region [public] {static} (IPropertyKey) ManufacturerSpecifiedData00: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the manufacturer specified data datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
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
                    public static IPropertyKey ManufacturerSpecifiedData00 => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.ManufacturerSpecifiedData00);
                    #endregion

                    #region [public] {static} (IPropertyKey) StandardTimingIdentifier: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Represents the standard timing identifier datablock descriptor.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownEdidSection.DataBlocks"/></description></item>
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
                    public static IPropertyKey StandardTimingIdentifier => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.StandardTimingIdentifier);
                    #endregion
                }
                #endregion

                #endregion
            }
            #endregion

            #region [public] {static} (class) ExtensionBlocks: Definition of keys in the 'ExtensionBlocks' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.ExtensionBlocks"/> section.
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.ExtensionBlocks"/></description></item>
                ///   <item><description>Property: <see cref="EdidExtensionBlocksProperty.Count"/></description></item>
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
                public static IPropertyKey Count => new PropertyKey(KnownEdidSection.ExtensionBlocks, EdidExtensionBlocksProperty.Count);
                #endregion

                #region [public] {static} (IPropertyKey) HasBlocks: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if has availables extension blocks.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.ExtensionBlocks"/></description></item>
                ///   <item><description>Property: <see cref="EdidExtensionBlocksProperty.HasBlocks"/></description></item>
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
                public static IPropertyKey HasBlocks => new PropertyKey(KnownEdidSection.ExtensionBlocks, EdidExtensionBlocksProperty.HasBlocks);
                #endregion
            }
            #endregion

            #region [public] {static} (class) CheckSum: Definition of keys in the 'CheckSum' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.CheckSum"/> section.
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
                ///   <item><description>Structure: <see cref="KnownEdidSection.CheckSum"/></description></item>
                ///   <item><description>Property: <see cref="EdidCheckSumProperty.Ok"/></description></item>
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
                public static IPropertyKey Ok => new PropertyKey(KnownEdidSection.CheckSum, EdidCheckSumProperty.Ok);
                #endregion

                #region [public] {static} (IPropertyKey) Value: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Contains checksum byte block value.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownEdidSection.CheckSum"/></description></item>
                ///   <item><description>Property: <see cref="EdidCheckSumProperty.Value"/></description></item>
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
                public static IPropertyKey Value => new PropertyKey(KnownEdidSection.CheckSum, EdidCheckSumProperty.Value);
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
            /// Definition of keys in the <see cref="KnownCeaSection.Information"/> section.
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
                ///   <item><description>Structure: <see cref="KnownCeaSection.Information"/></description></item>
                ///   <item><description>Property: <see cref="CeaInformation.Revision"/></description></item>
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
                public static IPropertyKey Revision => new PropertyKey(KnownCeaSection.Information, CeaInformation.Revision);
                #endregion

                #region [public] {static} (IPropertyKey) Implemented: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Implemented version.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownCeaSection.Information"/></description></item>
                ///   <item><description>Property: <see cref="CeaInformation.Implemented"/></description></item>
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
                public static IPropertyKey Implemented => new PropertyKey(KnownCeaSection.Information, CeaInformation.Implemented);
                #endregion
            }
            #endregion

            #region [public] {static} (class) MonitorSupport: Definition of keys in the 'MonitorSupport' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownCeaSection.MonitorSupport"/> section.
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
                ///   <item><description>Structure: <see cref="KnownCeaSection.MonitorSupport"/></description></item>
                ///   <item><description>Property: <see cref="CeaMonitorSupport.IsDvtUnderscan"/></description></item>
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
                public static IPropertyKey IsDvtUnderscan => new PropertyKey(KnownCeaSection.MonitorSupport, CeaMonitorSupport.IsDvtUnderscan);
                #endregion

                #region [public] {static} (IPropertyKey) BasicAudioSupported: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if basic audio is supported.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownCeaSection.MonitorSupport"/></description></item>
                ///   <item><description>Property: <see cref="CeaMonitorSupport.BasicAudioSupported"/></description></item>
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
                public static IPropertyKey BasicAudioSupported => new PropertyKey(KnownCeaSection.MonitorSupport, CeaMonitorSupport.BasicAudioSupported);
                #endregion

                #region [public] {static} (IPropertyKey) YCbCr444Supported: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if is supported the Ycbcr444.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownCeaSection.MonitorSupport"/></description></item>
                ///   <item><description>Property: <see cref="CeaMonitorSupport.YCbCr444Supported"/></description></item>
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
                public static IPropertyKey YCbCr444Supported => new PropertyKey(KnownCeaSection.MonitorSupport, CeaMonitorSupport.YCbCr444Supported);
                #endregion

                #region [public] {static} (IPropertyKey) YCbCr422Supported: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Indicates if is supported the Ycbcr422.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownCeaSection.MonitorSupport"/></description></item>
                ///   <item><description>Property: <see cref="CeaMonitorSupport.YCbCr422Supported"/></description></item>
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
                public static IPropertyKey YCbCr422Supported => new PropertyKey(KnownCeaSection.MonitorSupport, CeaMonitorSupport.YCbCr422Supported);
                #endregion  
            }
            #endregion

            #region [public] {static} (class) DetailedTiming: Definition of keys in the 'DetailedTimings' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownCeaSection.DetailedTiming"/> section.
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
                ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                ///   <item><description>Property: <see cref="CeaDetailedTiming.Timings"/></description></item>
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
                public static IPropertyKey Timings => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTiming.Timings);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.PixelClock"/></description></item>
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
                    public static IPropertyKey PixelClock => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.PixelClock, PropertyUnit.KHz);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.HorizontalResolution"/></description></item>
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
                    public static IPropertyKey HorizontalResolution => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.HorizontalResolution, PropertyUnit.Pixels);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.HorizontalBlanking"/></description></item>
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
                    public static IPropertyKey HorizontalBlanking => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.HorizontalBlanking, PropertyUnit.Pixels);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.VerticalLines"/></description></item>
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
                    public static IPropertyKey VerticalLines => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.VerticalLines, PropertyUnit.Lines);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.VerticalBlanking"/></description></item>
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
                    public static IPropertyKey VerticalBlanking => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.VerticalBlanking, PropertyUnit.Lines);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.HorizontalFrontPorch"/></description></item>
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
                    public static IPropertyKey HorizontalFrontPorch => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.HorizontalFrontPorch, PropertyUnit.Pixels);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.HorizontalSyncPulseWidth"/></description></item>
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
                    public static IPropertyKey HorizontalSyncPulseWidth => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.HorizontalSyncPulseWidth, PropertyUnit.Pixels);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.VerticalFrontPorch"/></description></item>
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
                    public static IPropertyKey VerticalFrontPorch => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.VerticalFrontPorch, PropertyUnit.Lines);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.VerticalSyncPulseWidth"/></description></item>
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
                    public static IPropertyKey VerticalSyncPulseWidth => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.VerticalSyncPulseWidth, PropertyUnit.Lines);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.HorizontalImageSize"/></description></item>
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
                    public static IPropertyKey HorizontalImageSize => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.HorizontalImageSize, PropertyUnit.mm);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.VerticalImageSize"/></description></item>
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
                    public static IPropertyKey VerticalImageSize => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.VerticalImageSize, PropertyUnit.mm);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.HorizontalBorder"/></description></item>
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
                    public static IPropertyKey HorizontalBorder => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.HorizontalBorder, PropertyUnit.Pixels);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.VerticalBorder"/></description></item>
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
                    public static IPropertyKey VerticalBorder => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.VerticalBorder, PropertyUnit.Pixels);
                    #endregion

                    #region [public] {static} (IPropertyKey) IsInterlaced: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Indicates if is interlaced.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.Interlaced"/></description></item>
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
                    public static IPropertyKey IsInterlaced => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.Interlaced);
                    #endregion

                    #region [public] {static} (IPropertyKey) StereoViewingSupport: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Stereo viewing support value.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.StereoViewingSupport"/></description></item>
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
                    public static IPropertyKey StereoViewingSupport => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.StereoViewingSupport);
                    #endregion

                    #region [public] {static} (IPropertyKey) SyncSignalType: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Sync signal type.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DetailedTiming"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDetailedTimingDescriptor.SyncSignalType"/></description></item>
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
                    public static IPropertyKey SyncSignalType => new PropertyKey(KnownCeaSection.DetailedTiming, CeaDetailedTimingDescriptor.SyncSignalType);
                    #endregion
                }
                #endregion

                #endregion
            }
            #endregion

            #region [public] {static} (class) DataBlock: Definition of keys in the 'DataBlockCollection' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownCeaSection.DataBlockCollection"/> section.
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDataBlockTags.Audio"/></description></item>
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
                    public static IPropertyKey Audio => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaDataBlockTags.Audio);
                    #endregion

                    #region [public] {static} (IPropertyKey) Extended: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Data Block Extended Tag.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDataBlockTags.Extended"/></description></item>
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
                    public static IPropertyKey Extended => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaDataBlockTags.Extended);
                    #endregion

                    #region [public] {static} (IPropertyKey) Reserved: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Data Block Reserved Tag.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDataBlockTags.Reserved"/></description></item>
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
                    public static IPropertyKey Reserved => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaDataBlockTags.Reserved);
                    #endregion

                    #region [public] {static} (IPropertyKey) Speaker: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>CEA Short Speaker Data Block (SKDB).</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDataBlockTags.Speaker"/></description></item>
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
                    public static IPropertyKey Speaker => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaDataBlockTags.Speaker);
                    #endregion

                    #region [public] {static} (IPropertyKey) Vendor: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>CEA Short Vendor Data Block (SRDB).</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDataBlockTags.Vendor"/></description></item>
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
                    public static IPropertyKey Vendor => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaDataBlockTags.Vendor);
                    #endregion

                    #region [public] {static} (IPropertyKey) VESA: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Data Block VESA Tag.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDataBlockTags.VESA"/></description></item>
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
                    public static IPropertyKey VESA => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaDataBlockTags.VESA);
                    #endregion

                    #region [public] {static} (IPropertyKey) Video: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>CEA Short Video Data Block (SVDB).</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaDataBlockTags.Video"/></description></item>
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
                    public static IPropertyKey Video => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaDataBlockTags.Video);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaAudioDataBlock.Descriptor"/></description></item>
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
                    public static IPropertyKey Descriptor => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaAudioDataBlock.Descriptor);
                    #endregion

                    #region [public] {static} (IPropertyKey) BitDepth: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Audio Bit Depth</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaAudioDataBlock.BitDepth"/></description></item>
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
                    public static IPropertyKey BitDepth => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaAudioDataBlock.BitDepth);
                    #endregion

                    #region [public] {static} (IPropertyKey) Channels: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Audio Channels</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaAudioDataBlock.Channels"/></description></item>
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
                    public static IPropertyKey Channels => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaAudioDataBlock.Channels);
                    #endregion

                    #region [public] {static} (IPropertyKey) Format: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Audio Format</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaAudioDataBlock.Format"/></description></item>
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
                    public static IPropertyKey Format => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaAudioDataBlock.Format);
                    #endregion

                    #region [public] {static} (IPropertyKey) MaxBitrate: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Audio Max Bitrate</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaAudioDataBlock.Format"/></description></item>
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
                    public static IPropertyKey MaxBitrate => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaAudioDataBlock.MaxBitrate);
                    #endregion

                    #region [public] {static} (IPropertyKey) SamplingFrequencies: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Audio Sampling Frequencies</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaAudioDataBlock.SamplingFrequencies"/></description></item>
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
                    public static IPropertyKey SamplingFrequencies => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaAudioDataBlock.SamplingFrequencies);
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
                        ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaExtendedColorimetryDataBlock.AdobeRGB"/></description></item>
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
                        public static IPropertyKey AdobeRGB => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaExtendedColorimetryDataBlock.AdobeRGB);
                        #endregion

                        #region [public] {static} (IPropertyKey) AdobeYCC601: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Adobe YCC601.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaExtendedColorimetryDataBlock.AdobeYCC601"/></description></item>
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
                        public static IPropertyKey AdobeYCC601 => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaExtendedColorimetryDataBlock.AdobeYCC601);
                        #endregion

                        #region [public] {static} (IPropertyKey) sYCC601: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>sYCC601.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaExtendedColorimetryDataBlock.sYCC601"/></description></item>
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
                        public static IPropertyKey sYCC601 => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaExtendedColorimetryDataBlock.sYCC601);
                        #endregion

                        #region [public] {static} (IPropertyKey) xvYCC709: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>xvYCC709.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaExtendedColorimetryDataBlock.xvYCC709"/></description></item>
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
                        public static IPropertyKey xvYCC709 => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaExtendedColorimetryDataBlock.xvYCC709);
                        #endregion

                        #region [public] {static} (IPropertyKey) xvYCC601: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>xvYCC601.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaExtendedColorimetryDataBlock.xvYCC601"/></description></item>
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
                        public static IPropertyKey xvYCC601 => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaExtendedColorimetryDataBlock.xvYCC601);
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
                        ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaExtendedVideoCapabilityDataBlock.CEOverscan"/></description></item>
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
                        public static IPropertyKey CEOverscan => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaExtendedVideoCapabilityDataBlock.CEOverscan);
                        #endregion

                        #region [public] {static} (IPropertyKey) ITOverscan: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>IT Overscan/Underscan.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaExtendedVideoCapabilityDataBlock.ITOverscan"/></description></item>
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
                        public static IPropertyKey ITOverscan => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaExtendedVideoCapabilityDataBlock.ITOverscan);
                        #endregion

                        #region [public] {static} (IPropertyKey) PTOverscan: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>PT Overscan Overscan/Underscan.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaExtendedVideoCapabilityDataBlock.PTOverscan"/></description></item>
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
                        public static IPropertyKey PTOverscan => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaExtendedVideoCapabilityDataBlock.PTOverscan);
                        #endregion

                        #region [public] {static} (IPropertyKey) QuantizationRangeRGB: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Quantization Range RGB.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaExtendedVideoCapabilityDataBlock.QuantizationRangeRGB"/></description></item>
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
                        public static IPropertyKey QuantizationRangeRGB => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaExtendedVideoCapabilityDataBlock.QuantizationRangeRGB);
                        #endregion

                        #region [public] {static} (IPropertyKey) QuantizationRangeYCC: Gets a value representing the key to retrieve the property value
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property value.</para>
                        /// <para>Quantization Range YCC.</para>
                        /// <para>
                        ///  <para><b>Key Composition</b></para>
                        ///  <list type="bullet">
                        ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                        ///   <item><description>Property: <see cref="CeaExtendedVideoCapabilityDataBlock.QuantizationRangeYCC"/></description></item>
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
                        public static IPropertyKey QuantizationRangeYCC => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaExtendedVideoCapabilityDataBlock.QuantizationRangeYCC);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaReservedDataBlock.Data"/></description></item>
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
                    public static IPropertyKey Data => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaReservedDataBlock.Data);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaSpeakerDataBlock.FrontLeftRightHigh"/></description></item>
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
                    public static IPropertyKey FrontLeftRightHigh => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaSpeakerDataBlock.FrontLeftRightHigh);
                    #endregion

                    #region [public] {static} (IPropertyKey) FrontLeftRightWide: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Front Left/Right Wide.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaSpeakerDataBlock.FrontLeftRightWide"/></description></item>
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
                    public static IPropertyKey FrontLeftRightWide => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaSpeakerDataBlock.FrontLeftRightWide);
                    #endregion

                    #region [public] {static} (IPropertyKey) RearLeftRightCenter: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Rear Left/Right Center.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaSpeakerDataBlock.RearLeftRightCenter"/></description></item>
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
                    public static IPropertyKey RearLeftRightCenter => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaSpeakerDataBlock.RearLeftRightCenter);
                    #endregion

                    #region [public] {static} (IPropertyKey) FrontLeftRightCenter: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Front Left/Right Center.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaSpeakerDataBlock.FrontLeftRightCenter"/></description></item>
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
                    public static IPropertyKey FrontLeftRightCenter => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaSpeakerDataBlock.FrontLeftRightCenter);
                    #endregion

                    #region [public] {static} (IPropertyKey) RearCenter: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Rear Center.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaSpeakerDataBlock.RearCenter"/></description></item>
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
                    public static IPropertyKey RearCenter => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaSpeakerDataBlock.RearCenter);
                    #endregion

                    #region [public] {static} (IPropertyKey) RearLeftRight: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Rear Left/Right.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaSpeakerDataBlock.RearLeftRight"/></description></item>
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
                    public static IPropertyKey RearLeftRight => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaSpeakerDataBlock.RearLeftRight);
                    #endregion

                    #region [public] {static} (IPropertyKey) FrontCenter: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Front Center.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaSpeakerDataBlock.FrontCenter"/></description></item>
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
                    public static IPropertyKey FrontCenter => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaSpeakerDataBlock.FrontCenter);
                    #endregion

                    #region [public] {static} (IPropertyKey) LFEChannel: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>LFE Channel.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaSpeakerDataBlock.LFEChannel"/></description></item>
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
                    public static IPropertyKey LFEChannel => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaSpeakerDataBlock.LFEChannel);
                    #endregion

                    #region [public] {static} (IPropertyKey) FrontLeftRight: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Front Left/Right.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaSpeakerDataBlock.FrontLeftRight"/></description></item>
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
                    public static IPropertyKey FrontLeftRight => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaSpeakerDataBlock.FrontLeftRight);
                    #endregion

                    #region [public] {static} (IPropertyKey) TopCenter: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Top Center.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaSpeakerDataBlock.TopCenter"/></description></item>
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
                    public static IPropertyKey TopCenter => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaSpeakerDataBlock.TopCenter);
                    #endregion

                    #region [public] {static} (IPropertyKey) FrontCenterHigh: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Front Center High.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaSpeakerDataBlock.FrontCenterHigh"/></description></item>
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
                    public static IPropertyKey FrontCenterHigh => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaSpeakerDataBlock.FrontCenterHigh);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaVendorDataBlock.IEEERegistrationIdentifier"/></description></item>
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
                    public static IPropertyKey IEEERegistrationIdentifier => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaVendorDataBlock.IEEERegistrationIdentifier);
                    #endregion

                    #region [public] {static} (IPropertyKey) PhysicalAddress: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Consumer Electronics Control (CEC) physical address.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaVendorDataBlock.PhysicalAddress"/></description></item>
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
                    public static IPropertyKey PhysicalAddress => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaVendorDataBlock.PhysicalAddress);
                    #endregion

                    #region [public] {static} (IPropertyKey) Flags: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Flags.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaVendorDataBlock.Flags"/></description></item>
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
                    public static IPropertyKey Flags => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaVendorDataBlock.Flags);
                    #endregion

                    #region [public] {static} (IPropertyKey) MaxClock: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Maximum TMDS clock.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaVendorDataBlock.MaxClock"/></description></item>
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
                    public static IPropertyKey MaxClock => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaVendorDataBlock.MaxClock);
                    #endregion

                    #region [public] {static} (IPropertyKey) VendorPayload: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Maximum TMDS clock.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaVendorDataBlock.VendorPayload"/></description></item>
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
                    public static IPropertyKey VendorPayload => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaVendorDataBlock.VendorPayload);
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
                    ///   <item><description>Structure: <see cref="KnownCeaSection.DataBlockCollection"/></description></item>
                    ///   <item><description>Property: <see cref="CeaVideoDataBlock.SupportedTimings"/></description></item>
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
                    public static IPropertyKey SupportedTimings => new PropertyKey(KnownCeaSection.DataBlockCollection, CeaVideoDataBlock.SupportedTimings);
                    #endregion
                }
                #endregion

                #endregion
            }
            #endregion

            #region [public] {static} (class) CheckSum: Definition of keys in the 'CheckSum' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownCeaSection.CheckSum"/> section.
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
                ///   <item><description>Structure: <see cref="KnownCeaSection.CheckSum"/></description></item>
                ///   <item><description>Property: <see cref="CeaCheckSum.Ok"/></description></item>
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
                public static IPropertyKey Ok => new PropertyKey(KnownCeaSection.CheckSum, CeaCheckSum.Ok);
                #endregion

                #region [public] {static} (IPropertyKey) Value: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Contains checksum byte block value.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownCeaSection.CheckSum"/></description></item>
                ///   <item><description>Property: <see cref="CeaCheckSum.Value"/></description></item>
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
                public static IPropertyKey Value => new PropertyKey(KnownCeaSection.CheckSum, CeaCheckSum.Value);
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
            /// Definition of keys in the <see cref="KnownDiSection.Information"/> section.
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
                ///   <item><description>Structure: <see cref="KnownDiSection.Information"/></description></item>
                ///   <item><description>Property: <see cref="DiInformation.VersionNumber"/></description></item>
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
                public static IPropertyKey VersionNumber => new PropertyKey(KnownDiSection.Information, DiInformation.VersionNumber);
                #endregion
            }
            #endregion

            #region [public] {static} (class) DigitalInterface: Definition of keys in the 'Digital Interface' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownDiSection.DigitalInterface"/> section.
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiDigitalInterface.SupportedDigitalInterface"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedDigitalInterface => new PropertyKey(KnownDiSection.DigitalInterface, DiDigitalInterface.SupportedDigitalInterface);
                #endregion

                #region [public] {static} (IPropertyKey) DataEnableSignalUsageAvailable: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Data Enable Signal Usage Available.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiDigitalInterface.DataEnableSignalUsageAvailable"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DataEnableSignalUsageAvailable => new PropertyKey(KnownDiSection.DigitalInterface, DiDigitalInterface.DataEnableSignalUsageAvailable);
                #endregion

                #region [public] {static} (IPropertyKey) DataEnableSignalHighOrLow: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Data Enable Signal High or Low.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiDigitalInterface.DataEnableSignalHighOrLow"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DataEnableSignalHighOrLow => new PropertyKey(KnownDiSection.DigitalInterface, DiDigitalInterface.DataEnableSignalHighOrLow);
                #endregion

                #region [public] {static} (IPropertyKey) EdgeOfShiftClock: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Edge of Shift Clock Usage.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiDigitalInterface.EdgeOfShiftClock"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey EdgeOfShiftClock => new PropertyKey(KnownDiSection.DigitalInterface, DiDigitalInterface.EdgeOfShiftClock);
                #endregion

                #region [public] {static} (IPropertyKey) HdcpSupport: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>HDCP Support.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiDigitalInterface.HdcpSupport"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey HdcpSupport => new PropertyKey(KnownDiSection.DigitalInterface, DiDigitalInterface.HdcpSupport);
                #endregion

                #region [public] {static} (IPropertyKey) DoubleClockingOfInputData: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Double Clocking Of Input Data.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiDigitalInterface.DoubleClockingOfInputData"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DoubleClockingOfInputData => new PropertyKey(KnownDiSection.DigitalInterface, DiDigitalInterface.DoubleClockingOfInputData);
                #endregion

                #region [public] {static} (IPropertyKey) SupportForPacketizedDigitalVideoSupport: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Support For Packetized Digital Video Support.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiDigitalInterface.SupportForPacketizedDigitalVideoSupport"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportForPacketizedDigitalVideoSupport => new PropertyKey(KnownDiSection.DigitalInterface, DiDigitalInterface.SupportForPacketizedDigitalVideoSupport);
                #endregion

                #region [public] {static} (IPropertyKey) DataFormats: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Data Formats.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiDigitalInterface.DataFormats"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DataFormats => new PropertyKey(KnownDiSection.DigitalInterface, DiDigitalInterface.DataFormats);
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiDigitalInterface.MinimumPixelClockFrequencyPerLink"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.MHz"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey MinimumPixelClockFrequencyPerLink => new PropertyKey(KnownDiSection.DigitalInterface, DiDigitalInterface.MinimumPixelClockFrequencyPerLink, PropertyUnit.MHz);
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiDigitalInterface.MaximumPixelClockFrequencyPerLink"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.MHz"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="int"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey MaximumPixelClockFrequencyPerLink => new PropertyKey(KnownDiSection.DigitalInterface, DiDigitalInterface.MaximumPixelClockFrequencyPerLink, PropertyUnit.MHz);
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DigitalInterface"/></description></item>
                ///   <item><description>Property: <see cref="DiDigitalInterface.CrossoverFrequency"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.MHz"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="int"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey CrossoverFrequency => new PropertyKey(KnownDiSection.DigitalInterface, DiDigitalInterface.CrossoverFrequency, PropertyUnit.MHz);
                #endregion
            }
            #endregion

            #region [public] {static} (class) DisplayDevice: Definition of keys in the 'Display Device' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownDiSection.DisplayDevice"/> section.
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayDevice.SubPixelLayout"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SubPixelLayout => new PropertyKey(KnownDiSection.DisplayDevice, DiDisplayDevice.SubPixelLayout);
                #endregion

                #region [public] {static} (IPropertyKey) SubPixelConfiguration: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Sub-Pixel Configuration.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayDevice.SubPixelConfiguration"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SubPixelConfiguration => new PropertyKey(KnownDiSection.DisplayDevice, DiDisplayDevice.SubPixelConfiguration);
                #endregion

                #region [public] {static} (IPropertyKey) SubPixelShape: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Sub-Pixel Shape.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayDevice.SubPixelShape"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SubPixelShape => new PropertyKey(KnownDiSection.DisplayDevice, DiDisplayDevice.SubPixelShape);
                #endregion

                #region [public] {static} (IPropertyKey) HorizontalDotPixelPitch: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Horizontal Dot/Pixel Pitch.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayDevice.HorizontalDotPixelPitch"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.mm"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey HorizontalDotPixelPitch => new PropertyKey(KnownDiSection.DisplayDevice, DiDisplayDevice.HorizontalDotPixelPitch, PropertyUnit.mm);
                #endregion

                #region [public] {static} (IPropertyKey) VerticalDotPixelPitch: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Vertical Dot/Pixel Pitch.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayDevice.VerticalDotPixelPitch"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.mm"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey VerticalDotPixelPitch => new PropertyKey(KnownDiSection.DisplayDevice, DiDisplayDevice.VerticalDotPixelPitch, PropertyUnit.mm);
                #endregion

                #region [public] {static} (IPropertyKey) FixedPixelFormat: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Fixed Pixel Format.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayDevice.FixedPixelFormat"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey FixedPixelFormat => new PropertyKey(KnownDiSection.DisplayDevice, DiDisplayDevice.FixedPixelFormat);
                #endregion

                #region [public] {static} (IPropertyKey) ViewDirection: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>View Direction.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayDevice.ViewDirection"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ViewDirection => new PropertyKey(KnownDiSection.DisplayDevice, DiDisplayDevice.ViewDirection);
                #endregion

                #region [public] {static} (IPropertyKey) DisplayBackground: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Display Background.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayDevice.DisplayBackground"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DisplayBackground => new PropertyKey(KnownDiSection.DisplayDevice, DiDisplayDevice.DisplayBackground);
                #endregion

                #region [public] {static} (IPropertyKey) PhysicalImplementation: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Physical Implementation.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayDevice.PhysicalImplementation"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey PhysicalImplementation => new PropertyKey(KnownDiSection.DisplayDevice, DiDisplayDevice.PhysicalImplementation);
                #endregion

                #region [public] {static} (IPropertyKey) DDC: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>DDC/CI.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayDevice"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayDevice.DDC"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DDC => new PropertyKey(KnownDiSection.DisplayDevice, DiDisplayDevice.DDC);
                #endregion
            }
            #endregion

            #region [public] {static} (class) DisplayCapabilitiesAndFeatureSupportSet: Definition of keys in the 'Display Capabilities & Feature Support Set' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/> section.
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.LegacyModes"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey LegacyModes => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.LegacyModes);
                #endregion

                #region [public] {static} (IPropertyKey) StereoVideo: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Stereo Video.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.StereoVideo"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey StereoVideo => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.StereoVideo);
                #endregion

                #region [public] {static} (IPropertyKey) ScalerOnBoard: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Scaler On Board.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.ScalerOnBoard"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ScalerOnBoard => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.ScalerOnBoard);
                #endregion

                #region [public] {static} (IPropertyKey) ImageCentering: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Image Centering.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.ImageCentering"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ImageCentering => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.ImageCentering);
                #endregion

                #region [public] {static} (IPropertyKey) ConditionalUpdate: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Conditional Update.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.ConditionalUpdate"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ConditionalUpdate => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.ConditionalUpdate);
                #endregion

                #region [public] {static} (IPropertyKey) InterlacedVideo: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Interlaced Video.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.InterlacedVideo"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey InterlacedVideo => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.InterlacedVideo);
                #endregion

                #region [public] {static} (IPropertyKey) FrameLock: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Frame Lock.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.FrameLock"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey FrameLock => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.FrameLock);
                #endregion

                #region [public] {static} (IPropertyKey) FrameRateConversion: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Frame Rate Conversion.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.FrameRateConversion"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey FrameRateConversion => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.FrameRateConversion);
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.VerticalFrequency"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Hz"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="int"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey VerticalFrequency => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.VerticalFrequency, PropertyUnit.Hz);
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.HorizontalFrequency"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Hz"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="int"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey HorizontalFrequency => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.HorizontalFrequency, PropertyUnit.Hz);
                #endregion

                #region [public] {static} (IPropertyKey) DisplayScanOrientationType: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Display/Scan Orientation Definition Type.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.DisplayScanOrientationType"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DisplayScanOrientationType => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.DisplayScanOrientationType);
                #endregion

                #region [public] {static} (IPropertyKey) ScreenOrientation: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Screen Orientation.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.ScreenOrientation"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ScreenOrientation => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.ScreenOrientation);
                #endregion

                #region [public] {static} (IPropertyKey) ZeroPixelLocation: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Zero Pixel Location.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.ZeroPixelLocation"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ZeroPixelLocation => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.ZeroPixelLocation);
                #endregion

                #region [public] {static} (IPropertyKey) ScanDirection: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Scan Direction.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.ScanDirection"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ScanDirection => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.ScanDirection);
                #endregion

                #region [public] {static} (IPropertyKey) StandaloneProjector: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Standalone Projector.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.StandaloneProjector"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey StandaloneProjector => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.StandaloneProjector);
                #endregion

                #region [public] {static} (IPropertyKey) DefaultColorLuminanceDecoding: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Default Color/Luminance Decoding.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.DefaultColorLuminanceDecoding"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey DefaultColorLuminanceDecoding => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.DefaultColorLuminanceDecoding);
                #endregion

                #region [public] {static} (IPropertyKey) PreferredColorLuminanceDecoder: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Preferred Color/Luminance Decoding.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.PreferredColorLuminanceDecoder"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey PreferredColorLuminanceDecoder => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.PreferredColorLuminanceDecoder);
                #endregion

                #region [public] {static} (IPropertyKey) ColorLuminanceDecodingCapabilities: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Color/Luminance Decoding Capabilities.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.ColorLuminanceDecodingCapabilities"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string[]"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey ColorLuminanceDecodingCapabilities => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.ColorLuminanceDecodingCapabilities);
                #endregion

                #region [public] {static} (IPropertyKey) Dithering: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Dithering.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.Dithering"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="bool"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Dithering => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.Dithering);
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0Blue"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedColorBitDepthSubChannel0Blue => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0Blue, PropertyUnit.Bits);
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Green"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedColorBitDepthSubChannel1Green => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Green, PropertyUnit.Bits);
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2Red"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedColorBitDepthSubChannel2Red => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2Red, PropertyUnit.Bits);
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0CbPb"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedColorBitDepthSubChannel0CbPb => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel0CbPb, PropertyUnit.Bits);
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Y"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedColorBitDepthSubChannel1Y => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel1Y, PropertyUnit.Bits);
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2CrPr"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.Bits"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey SupportedColorBitDepthSubChannel2CrPr => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.SupportedColorBitDepthSubChannel2CrPr, PropertyUnit.Bits);
                #endregion

                #region [public] {static} (IPropertyKey) AspectRatioConversionModes: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Aspect Ratio Conversion Modes.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.AspectRatioConversionModes"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey AspectRatioConversionModes => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.AspectRatioConversionModes);
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayCapabilitiesAndFeatureSupportSet.PacketizedDigitalVideoSupportInformation"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey PacketizedDigitalVideoSupportInformation => new PropertyKey(KnownDiSection.DisplayCapabilitiesAndFeatureSupportSet, DiDisplayCapabilitiesAndFeatureSupportSet.PacketizedDigitalVideoSupportInformation);
                #endregion
            }
            #endregion

            #region [public] {static} (class) UnusedBytes: Definition of keys in the 'Unused Bytes' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownDiSection.UnusedBytes"/> section.
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
                ///   <item><description>Structure: <see cref="KnownDiSection.UnusedBytes"/></description></item>
                ///   <item><description>Property: <see cref="DiUnusedBytes.Data"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Data => new PropertyKey(KnownDiSection.UnusedBytes, DiUnusedBytes.Data);
                #endregion
            }
            #endregion

            #region [public] {static} (class) AudioSupport: Definition of keys in the 'Audio Support' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownDiSection.AudioSupport"/> section.
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
                ///   <item><description>Structure: <see cref="KnownDiSection.AudioSupport"/></description></item>
                ///   <item><description>Property: <see cref="DiAudioSupport.Data"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="ReadOnlyCollection{T}"/> where <b>T</b> is <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Data => new PropertyKey(KnownDiSection.AudioSupport, DiUnusedBytes.Data);
                #endregion
            }
            #endregion

            #region [public] {static} (class) DisplayTransferCharacteristic: Definition of keys in the 'Display Transfer Characteristic' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownDiSection.DisplayTransferCharacteristic "/> section.
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
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayTransferCharacteristic"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayTransferCharacteristic.Status"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="string"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(KnownDiSection.DisplayTransferCharacteristic, DiDisplayTransferCharacteristic.Status);
                #endregion

                #region [public] {static} (IPropertyKey) NumberLuminanceEntries: Gets a value representing the key to retrieve the property value
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property value.</para>
                /// <para>Number of Luminance Entries.</para>
                /// <para>
                ///  <para><b>Key Composition</b></para>
                ///  <list type="bullet">
                ///   <item><description>Structure: <see cref="KnownDiSection.DisplayTransferCharacteristic"/></description></item>
                ///   <item><description>Property: <see cref="DiDisplayTransferCharacteristic.NumberLuminanceEntries"/></description></item>
                ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                ///  </list>
                /// </para>
                /// <para>
                ///  <para><b>Return Value</b></para>
                ///  <para>Type: <see cref="byte"/>.</para>
                /// </para>
                /// </summary>
                public static IPropertyKey NumberLuminanceEntries => new PropertyKey(KnownDiSection.DisplayTransferCharacteristic, DiDisplayTransferCharacteristic.NumberLuminanceEntries);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Miscellaneous: Definition of keys in the 'Miscellaneous Items' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownDiSection.Miscellaneous"/> section.
            /// </summary>
            public static class Miscellaneous
            {
                /// <summary>
                /// 
                /// </summary>
                public static class CheckSum
                {
                    #region [public] {static} (IPropertyKey) Ok: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Indicates if is a valid <see cref="DI"/> structure.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownDiSection.Miscellaneous"/></description></item>
                    ///   <item><description>Property: <see cref="DiMiscellaneous.CheckSum.Value"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="bool"/>.</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Ok => new PropertyKey(KnownCeaSection.CheckSum, CeaCheckSum.Ok);
                    #endregion

                    #region [public] {static} (IPropertyKey) Value: Gets a value representing the key to retrieve the property value
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property value.</para>
                    /// <para>Contains checksum byte block value.</para>
                    /// <para>
                    ///  <para><b>Key Composition</b></para>
                    ///  <list type="bullet">
                    ///   <item><description>Structure: <see cref="KnownDiSection.Miscellaneous"/></description></item>
                    ///   <item><description>Property: <see cref="DiMiscellaneous.CheckSum.Value"/></description></item>
                    ///   <item><description>Unit: <see cref="PropertyUnit.None"/></description></item>
                    ///  </list>
                    /// </para>
                    /// <para>
                    ///  <para><b>Return Value</b></para>
                    ///  <para>Type: <see cref="byte"/>.</para>
                    /// </para>
                    /// </summary>
                    public static IPropertyKey Value => new PropertyKey(KnownDiSection.Miscellaneous, DiMiscellaneous.CheckSum.Value);
                    #endregion
                }
            }
            #endregion
        }
        #endregion
    }
}
