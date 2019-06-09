
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Definition of available keys for the <see cref="EEDID" /> specification of a monitor.
    /// </summary>
    public static class KnownEedidPropertiesDefinition
    {
        #region [public] {static} (class) Edid: Definition of keys in the 'EDID' block
        /// <summary>
        /// Definition of keys in the <see cref="KnownDataBlock.EDID" /> block.
        /// </summary>
        public static class Edid
        {
            #region [public] {static} (class) Header: Definition of keys in the 'Header' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.Header"/> section.
            /// </summary>
            public static class Header
            {
                #region [public] {static} (PropertyKey) Signature: Gets a value that represents the key to recover the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Header"/></para>
                /// <para>Property: <see cref="KnownEdidHeaderProperty.Signature"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="ReadOnlyCollection{Byte}" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.Header" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidHeaderProperty.Signature" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="ReadOnlyCollection{Byte}" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Signature => new PropertyKey(KnownEdidSection.Header, KnownEdidHeaderProperty.Signature);
                #endregion

                #region [public] {static} (PropertyKey) IsValid: Gets a value that represents the key to recover the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Header"/></para>
                /// <para>Property: <see cref="KnownEdidHeaderProperty.IsValid"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.Header" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidHeaderProperty.IsValid" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey IsValid => new PropertyKey(KnownEdidSection.Header, KnownEdidHeaderProperty.IsValid, PropertyUnit.None);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Vendor: Definition of keys in the 'Vendor and Product' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.Vendor"/> section.
            /// </summary>
            public static class Vendor
            {
                #region [public] {static} (PropertyKey) IdManufacturerName: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Vendor"/></para>
                /// <para>Property: <see cref="KnownEdidVendorProperty.IdManufacturerName"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.Vendor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidVendorProperty.IdManufacturerName" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey IdManufacturerName => new PropertyKey(KnownEdidSection.Vendor, KnownEdidVendorProperty.IdManufacturerName);
                #endregion

                #region [public] {static} (PropertyKey) IdProductCode: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Vendor"/></para>
                /// <para>Property: <see cref="KnownEdidVendorProperty.IdProductCode"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Int32" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.Vendor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidVendorProperty.IdProductCode" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Int32" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey IdProductCode => new PropertyKey(KnownEdidSection.Vendor, KnownEdidVendorProperty.IdProductCode);

                #endregion

                #region [public] {static} (PropertyKey) IdSerialNumber: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Vendor"/></para>
                /// <para>Property: <see cref="KnownEdidVendorProperty.IdSerialNumber"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Nullable{UInt32}" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.Vendor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidVendorProperty.IdSerialNumber" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Nullable{UInt32}" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey IdSerialNumber => new PropertyKey(KnownEdidSection.Vendor, KnownEdidVendorProperty.IdSerialNumber);
                #endregion

                #region [public] {static} (PropertyKey) WeekOfManufacture: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Vendor"/></para>
                /// <para>Property: <see cref="KnownEdidVendorProperty.WeekOfManufacture"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Nullable{Byte}" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.Vendor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidVendorProperty.WeekOfManufacture" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Nullable{Byte}" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey WeekOfManufacture => new PropertyKey(KnownEdidSection.Vendor, KnownEdidVendorProperty.WeekOfManufacture);
                #endregion

                #region [public] {static} (PropertyKey) ManufactureDate: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Vendor"/></para>
                /// <para>Property: <see cref="KnownEdidVendorProperty.ManufactureDate"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.Vendor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidVendorProperty.ManufactureDate" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Byte" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey ManufactureDate => new PropertyKey(KnownEdidSection.Vendor, KnownEdidVendorProperty.ManufactureDate);
                #endregion

                #region [public] {static} (PropertyKey) ModelYearStrategy: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Vendor"/></para>
                /// <para>Property: <see cref="KnownEdidVendorProperty.ModelYearStrategy"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:iTin.Core.Hardware.Specification.Eedid.KnownModelYearStrategy" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.Vendor" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidVendorProperty.ModelYearStrategy" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:iTin.Core.Hardware.Specification.Eedid.KnownModelYearStrategy" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey ModelYearStrategy => new PropertyKey(KnownEdidSection.Vendor, KnownEdidVendorProperty.ModelYearStrategy);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Version: Definition of keys in the 'Version and Revision' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.Version"/> section.
            /// </summary>
            public static class Version
            {
                #region [public] {static} (PropertyKey) Number: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Version"/></para>
                /// <para>Property: <see cref="KnownEdidVersionProperty.Version"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.Version" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidVersionProperty.Version" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Byte" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Number => new PropertyKey(KnownEdidSection.Version, KnownEdidVersionProperty.Version);
                #endregion

                #region [public] {static} (PropertyKey) Revision: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Version"/></para>
                /// <para>Property: <see cref="KnownEdidVersionProperty.Revision"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.Version" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidVersionProperty.Revision" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Byte" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Revision => new PropertyKey(KnownEdidSection.Version, KnownEdidVersionProperty.Revision);
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

                #region [public] {static} (PropertyKey) VideoInputDefinition: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.VideoInputDefinition"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.BasicDisplay" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidBasicDisplayProperty.VideoInputDefinition" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.String" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey VideoInputDefinition => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.VideoInputDefinition);
                #endregion

                #region [public] {static} (PropertyKey) HorizontalScreenSize: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.HorizontalScreenSize"/></para>
                /// <para>Unit: <see cref="PropertyUnit.cm"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.BasicDisplay" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidBasicDisplayProperty.HorizontalScreenSize" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.cm" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Byte" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey HorizontalScreenSize => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.HorizontalScreenSize, PropertyUnit.cm);
                #endregion

                #region [public] {static} (PropertyKey) VerticalScreenSize: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.VerticalScreenSize"/></para>
                /// <para>Unit: <see cref="PropertyUnit.cm"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.BasicDisplay" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidBasicDisplayProperty.VerticalScreenSize" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.cm" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Byte" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey VerticalScreenSize => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.VerticalScreenSize, PropertyUnit.cm);
                #endregion

                #region [public] {static} (PropertyKey) Gamma: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.Gamma"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Nullable{Byte}" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.BasicDisplay" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidBasicDisplayProperty.Gamma" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Nullable{Byte}" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Gamma => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.Gamma);
                #endregion

                #endregion


                #region nested classes

                #region [public] {static} (class) Analog: Definition of keys in the 'Analog' section
                /// <summary>
                /// Definition of keys in the <strong>Analog</strong> section.
                /// </summary>
                public static class Analog
                {
                    #region public readonly properties

                    #region [public] {static} (PropertyKey) SignalLevelStandard: Gets a value representing the key to retrieve the property
                    /// <summary>
                    /// <para>
                    /// Gets a value representing the key to retrieve the property.
                    /// </para>
                    /// <para>— Key Composition ——————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                    /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.AnalogSignalLevelStandard"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Return Value ———————————————— </para>
                    /// <para>Type: <see cref="T:System.String" /></para>
                    /// </summary>
                    /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                    /// <remarks><para>Key definition:</para>
                    /// <list type="table">
                    ///   <item>
                    ///     <term>Structure</term>
                    ///     <description>
                    ///       <see cref="KnownEdidSection.BasicDisplay" />
                    ///     </description>
                    ///   </item>
                    ///   <item>
                    ///     <term>Property</term>
                    ///     <description>
                    ///       <see cref="KnownEdidBasicDisplayProperty.AnalogSignalLevelStandard" />
                    ///     </description>
                    ///   </item>
                    ///   <item>
                    ///     <term>Unit</term>
                    ///     <description>
                    ///       <see cref="PropertyUnit.None" />
                    ///     </description>
                    ///   </item>
                    /// </list>
                    /// <para>Returns:</para>
                    /// <list type="table">
                    ///   <item>
                    ///     <term>Type</term>
                    ///     <description>
                    ///       <see cref="T:System.String" />
                    ///     </description>
                    ///   </item>
                    /// </list>
                    /// </remarks>
                    public static PropertyKey SignalLevelStandard => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.AnalogSignalLevelStandard);
                    #endregion

                    #region [public] {static} (PropertyKey) VideoSetup: Gets a value representing the key to retrieve the property
                    /// <summary>
                    /// <para>
                    /// Gets a value representing the key to retrieve the property.
                    /// </para>
                    /// <para>— Key Composition ——————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                    /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.AnalogVideoSetup"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Return Value ———————————————— </para>
                    /// <para>Type: <see cref="T:System.String" /></para>
                    /// </summary>
                    /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                    /// <remarks><para>Key definition:</para>
                    /// <list type="table">
                    ///   <item>
                    ///     <term>Structure</term>
                    ///     <description>
                    ///       <see cref="KnownEdidSection.BasicDisplay" />
                    ///     </description>
                    ///   </item>
                    ///   <item>
                    ///     <term>Property</term>
                    ///     <description>
                    ///       <see cref="KnownEdidBasicDisplayProperty.AnalogVideoSetup" />
                    ///     </description>
                    ///   </item>
                    ///   <item>
                    ///     <term>Unit</term>
                    ///     <description>
                    ///       <see cref="PropertyUnit.None" />
                    ///     </description>
                    ///   </item>
                    /// </list>
                    /// <para>Returns:</para>
                    /// <list type="table">
                    ///   <item>
                    ///     <term>Type</term>
                    ///     <description>
                    ///       <see cref="T:System.String" />
                    ///     </description>
                    ///   </item>
                    /// </list>
                    /// </remarks>
                    public static PropertyKey VideoSetup => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.AnalogVideoSetup);
                    #endregion

                    #region [public] {static} (PropertyKey) VerticalSyncSupported: Gets a value representing the key to retrieve the property
                    /// <summary>
                    /// <para>
                    /// Gets a value representing the key to retrieve the property.
                    /// </para>
                    /// <para>— Key Composition ——————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                    /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.AnalogVerticalSyncSupported"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Return Value ———————————————— </para>
                    /// <para>Type: <see cref="T:System.Boolean" /></para>
                    /// </summary>
                    /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                    /// <remarks><para>Key definition:</para>
                    /// <list type="table">
                    ///   <item>
                    ///     <term>Structure</term>
                    ///     <description>
                    ///       <see cref="KnownEdidSection.BasicDisplay" />
                    ///     </description>
                    ///   </item>
                    ///   <item>
                    ///     <term>Property</term>
                    ///     <description>
                    ///       <see cref="KnownEdidBasicDisplayProperty.AnalogVerticalSyncSupported" />
                    ///     </description>
                    ///   </item>
                    ///   <item>
                    ///     <term>Unit</term>
                    ///     <description>
                    ///       <see cref="PropertyUnit.None" />
                    ///     </description>
                    ///   </item>
                    /// </list>
                    /// <para>Returns:</para>
                    /// <list type="table">
                    ///   <item>
                    ///     <term>Type</term>
                    ///     <description>
                    ///       <see cref="T:System.Boolean" />
                    ///     </description>
                    ///   </item>
                    /// </list>
                    /// </remarks>
                    public static PropertyKey VerticalSyncSupported => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.AnalogVerticalSyncSupported);
                    #endregion

                    #region [public] {static} (PropertyKey) DisplayColorType: Gets a value representing the key to retrieve the property
                    /// <summary>
                    /// <para>
                    /// Gets a value representing the key to retrieve the property.
                    /// </para>
                    /// <para>— Key Composition ——————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                    /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.AnalogDisplayColorType"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Return Value ———————————————— </para>
                    /// <para>Type: <see cref="T:System.String" /></para>
                    /// </summary>
                    /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                    /// <remarks><para>Key definition:</para>
                    /// <list type="table">
                    ///   <item>
                    ///     <term>Structure</term>
                    ///     <description>
                    ///       <see cref="KnownEdidSection.BasicDisplay" />
                    ///     </description>
                    ///   </item>
                    ///   <item>
                    ///     <term>Property</term>
                    ///     <description>
                    ///       <see cref="KnownEdidBasicDisplayProperty.AnalogDisplayColorType" />
                    ///     </description>
                    ///   </item>
                    ///   <item>
                    ///     <term>Unit</term>
                    ///     <description>
                    ///       <see cref="PropertyUnit.None" />
                    ///     </description>
                    ///   </item>
                    /// </list>
                    /// <para>Returns:</para>
                    /// <list type="table">
                    ///   <item>
                    ///     <term>Type</term>
                    ///     <description>
                    ///       <see cref="T:System.String" />
                    ///     </description>
                    ///   </item>
                    /// </list>
                    /// </remarks>
                    public static PropertyKey DisplayColorType => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.AnalogDisplayColorType);
                    #endregion

                    #endregion


                    #region nested classes

                    #region [public] {static} (class) Syncrhonization: Definition of keys in the 'Syncrhonization Types' section
                    /// <summary>
                    /// Definition of keys in the <strong>Syncrhonization Types</strong> section.
                    /// </summary>
                    public static class Syncrhonization
                    {
                        #region [public] {static} (PropertyKey) SeparateSyncSupported: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>
                        /// Gets a value representing the key to retrieve the property.
                        /// </para>
                        /// <para>— Key Composition ——————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.AnalogSeparateSyncSupported"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Return Value ———————————————— </para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                        /// <remarks><para>Key definition:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Structure</term>
                        ///     <description>
                        ///       <see cref="KnownEdidSection.BasicDisplay" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Property</term>
                        ///     <description>
                        ///       <see cref="KnownEdidBasicDisplayProperty.AnalogSeparateSyncSupported" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Unit</term>
                        ///     <description>
                        ///       <see cref="PropertyUnit.None" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// <para>Returns:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Type</term>
                        ///     <description>
                        ///       <see cref="T:System.Boolean" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// </remarks>
                        public static PropertyKey SeparateSyncSupported => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.AnalogSeparateSyncSupported);
                        #endregion

                        #region [public] {static} (PropertyKey) CompositeSyncSignalHorizontalSupported: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>
                        /// Gets a value representing the key to retrieve the property.
                        /// </para>
                        /// <para>— Key Composition ——————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.AnalogCompositeSyncSignalHorizontalSupported"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Return Value ———————————————— </para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                        /// <remarks><para>Key definition:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Structure</term>
                        ///     <description>
                        ///       <see cref="KnownEdidSection.BasicDisplay" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Property</term>
                        ///     <description>
                        ///       <see cref="KnownEdidBasicDisplayProperty.AnalogCompositeSyncSignalHorizontalSupported" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Unit</term>
                        ///     <description>
                        ///       <see cref="PropertyUnit.None" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// <para>Returns:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Type</term>
                        ///     <description>
                        ///       <see cref="T:System.Boolean" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// </remarks>
                        public static PropertyKey CompositeSyncSignalHorizontalSupported => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.AnalogCompositeSyncSignalHorizontalSupported);
                        #endregion

                        #region [public] {static} (PropertyKey) CompositeSyncSignalGreenVideoSupported: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>
                        /// Gets a value representing the key to retrieve the property.
                        /// </para>
                        /// <para>— Key Composition ——————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.AnalogCompositeSyncSignalGreenVideoSupported"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Return Value ———————————————— </para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                        /// <remarks><para>Key definition:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Structure</term>
                        ///     <description>
                        ///       <see cref="KnownEdidSection.BasicDisplay" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Property</term>
                        ///     <description>
                        ///       <see cref="KnownEdidBasicDisplayProperty.AnalogCompositeSyncSignalGreenVideoSupported" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Unit</term>
                        ///     <description>
                        ///       <see cref="PropertyUnit.None" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// <para>Returns:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Type</term>
                        ///     <description>
                        ///       <see cref="T:System.Boolean" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// </remarks>
                        public static PropertyKey CompositeSyncSignalGreenVideoSupported => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.AnalogCompositeSyncSignalGreenVideoSupported);
                        #endregion
                    }
                    #endregion

                    #endregion
                }
                #endregion

                #region [public] {static} (class) Digital: Definition of keys in the 'Digital' section
                /// <summary>
                /// Definition of keys in the <strong>Digital</strong> section.
                /// </summary>
                public static class Digital
                {
                    #region [public] {static} (PropertyKey) ColorBitDepth: Gets a value representing the key to retrieve the property
                    /// <summary>
                    /// <para>
                    /// Gets a value representing the key to retrieve the property.
                    /// </para>
                    /// <para>— Key Composition ——————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                    /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.DigitalColorBitDepth"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Return Value ———————————————— </para>
                    /// <para>Type: <see cref="T:System.String" /></para>
                    /// </summary>
                    /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                    /// <remarks><para>Key definition:</para>
                    /// <list type="table">
                    ///   <item>
                    ///     <term>Structure</term>
                    ///     <description>
                    ///       <see cref="KnownEdidSection.BasicDisplay" />
                    ///     </description>
                    ///   </item>
                    ///   <item>
                    ///     <term>Property</term>
                    ///     <description>
                    ///       <see cref="KnownEdidBasicDisplayProperty.DigitalColorBitDepth" />
                    ///     </description>
                    ///   </item>
                    ///   <item>
                    ///     <term>Unit</term>
                    ///     <description>
                    ///       <see cref="PropertyUnit.None" />
                    ///     </description>
                    ///   </item>
                    /// </list>
                    /// <para>Returns:</para>
                    /// <list type="table">
                    ///   <item>
                    ///     <term>Type</term>
                    ///     <description>
                    ///       <see cref="T:System.String" />
                    ///     </description>
                    ///   </item>
                    /// </list>
                    /// </remarks>
                    public static PropertyKey ColorBitDepth => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.DigitalColorBitDepth);
                    #endregion

                    #region [public] {static} (PropertyKey) VideoInterface: Gets a value representing the key to retrieve the property
                    /// <summary>
                    /// <para>
                    /// Gets a value representing the key to retrieve the property.
                    /// </para>
                    /// <para>— Key Composition ——————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                    /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.DigitalVideoInterface"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Return Value ———————————————— </para>
                    /// <para>Type: <see cref="T:System.String" /></para>
                    /// </summary>
                    /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                    /// <remarks><para>Key definition:</para>
                    /// <list type="table">
                    ///   <item>
                    ///     <term>Structure</term>
                    ///     <description>
                    ///       <see cref="KnownEdidSection.BasicDisplay" />
                    ///     </description>
                    ///   </item>
                    ///   <item>
                    ///     <term>Property</term>
                    ///     <description>
                    ///       <see cref="KnownEdidBasicDisplayProperty.DigitalVideoInterface" />
                    ///     </description>
                    ///   </item>
                    ///   <item>
                    ///     <term>Unit</term>
                    ///     <description>
                    ///       <see cref="PropertyUnit.None" />
                    ///     </description>
                    ///   </item>
                    /// </list>
                    /// <para>Returns:</para>
                    /// <list type="table">
                    ///   <item>
                    ///     <term>Type</term>
                    ///     <description>
                    ///       <see cref="T:System.String" />
                    ///     </description>
                    ///   </item>
                    /// </list>
                    /// </remarks>
                    public static PropertyKey VideoInterface => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.DigitalVideoInterface);
                    #endregion

                    #region [public] {static} (PropertyKey) ColorEncodingFormat: Gets a value representing the key to retrieve the property
                    /// <summary>
                    /// <para>
                    /// Gets a value representing the key to retrieve the property.
                    /// </para>
                    /// <para>— Key Composition ——————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                    /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.DigitalColorEncodingFormat"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Return Value ———————————————— </para>
                    /// <para>Type: <see cref="T:System.String" /></para>
                    /// </summary>
                    /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                    /// <remarks><para>Key definition:</para>
                    /// <list type="table">
                    ///   <item>
                    ///     <term>Structure</term>
                    ///     <description>
                    ///       <see cref="KnownEdidSection.BasicDisplay" />
                    ///     </description>
                    ///   </item>
                    ///   <item>
                    ///     <term>Property</term>
                    ///     <description>
                    ///       <see cref="KnownEdidBasicDisplayProperty.DigitalColorEncodingFormat" />
                    ///     </description>
                    ///   </item>
                    ///   <item>
                    ///     <term>Unit</term>
                    ///     <description>
                    ///       <see cref="PropertyUnit.None" />
                    ///     </description>
                    ///   </item>
                    /// </list>
                    /// <para>Returns:</para>
                    /// <list type="table">
                    ///   <item>
                    ///     <term>Type</term>
                    ///     <description>
                    ///       <see cref="T:System.String" />
                    ///     </description>
                    ///   </item>
                    /// </list>
                    /// </remarks>
                    public static PropertyKey ColorEncodingFormat => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.DigitalColorEncodingFormat);
                    #endregion
                }
                #endregion

                #region [public] {static} (class) Features: Definition of keys in the 'Features' section
                /// <summary>
                /// Definition of keys in the <strong>Features</strong> section.
                /// </summary>
                public static class Features
                {
                    #region [public] {static} (class) Other: Definición de claves de la sección 'Other Features'
                    /// <summary>
                    /// Definición de claves de la sección <strong>Other Features</strong>.
                    /// </summary>
                    public static class Other
                    {
                        #region [public] {static} (PropertyKey) IsSrgbDefaultColorSpace: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>
                        /// Gets a value representing the key to retrieve the property.
                        /// </para>
                        /// <para>— Key Composition ——————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.SrgbDefaultColorSpace"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Return Value ———————————————— </para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                        /// <remarks><para>Key definition:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Structure</term>
                        ///     <description>
                        ///       <see cref="KnownEdidSection.BasicDisplay" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Property</term>
                        ///     <description>
                        ///       <see cref="KnownEdidBasicDisplayProperty.SrgbDefaultColorSpace" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Unit</term>
                        ///     <description>
                        ///       <see cref="PropertyUnit.None" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// <para>Returns:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Type</term>
                        ///     <description>
                        ///       <see cref="T:System.Boolean" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// </remarks>
                        public static PropertyKey IsSrgbDefaultColorSpace => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.SrgbDefaultColorSpace);
                        #endregion

                        #region [public] {static} (PropertyKey) IncludePreferredTimingMode: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>
                        /// Gets a value representing the key to retrieve the property.
                        /// </para>
                        /// <para>— Key Composition ——————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.PreferredTimingMode"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Return Value ———————————————— </para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                        /// <remarks><para>Key definition:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Structure</term>
                        ///     <description>
                        ///       <see cref="KnownEdidSection.BasicDisplay" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Property</term>
                        ///     <description>
                        ///       <see cref="KnownEdidBasicDisplayProperty.PreferredTimingMode" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Unit</term>
                        ///     <description>
                        ///       <see cref="PropertyUnit.None" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// <para>Returns:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Type</term>
                        ///     <description>
                        ///       <see cref="T:System.Boolean" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// </remarks>
                        public static PropertyKey IncludePreferredTimingMode => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.PreferredTimingMode);
                        #endregion

                        #region [public] {static} (PropertyKey) IsContinuousFrequency: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>
                        /// Gets a value representing the key to retrieve the property.
                        /// </para>
                        /// <para>— Key Composition ——————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.ContinuousFrequency"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Return Value ———————————————— </para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                        /// <remarks><para>Key definition:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Structure</term>
                        ///     <description>
                        ///       <see cref="KnownEdidSection.BasicDisplay" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Property</term>
                        ///     <description>
                        ///       <see cref="KnownEdidBasicDisplayProperty.ContinuousFrequency" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Unit</term>
                        ///     <description>
                        ///       <see cref="PropertyUnit.None" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// <para>Returns:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Type</term>
                        ///     <description>
                        ///       <see cref="T:System.Boolean" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// </remarks>
                        public static PropertyKey IsContinuousFrequency => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.ContinuousFrequency);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DisplayPowerManagement: Definición de claves de la sección 'Display Power Management'
                    /// <summary>
                    /// Definition of keys in the <strong>Display Power Management</strong> section.
                    /// </summary>
                    public static class DisplayPowerManagement
                    {
                        #region [public] {static} (PropertyKey) StandbyModeSupported: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>
                        /// Gets a value representing the key to retrieve the property.
                        /// </para>
                        /// <para>— Key Composition ——————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.StandbyModeSupported"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Return Value ———————————————— </para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                        /// <remarks><para>Key definition:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Structure</term>
                        ///     <description>
                        ///       <see cref="KnownEdidSection.BasicDisplay" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Property</term>
                        ///     <description>
                        ///       <see cref="KnownEdidBasicDisplayProperty.StandbyModeSupported" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Unit</term>
                        ///     <description>
                        ///       <see cref="PropertyUnit.None" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// <para>Returns:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Type</term>
                        ///     <description>
                        ///       <see cref="T:System.Boolean" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// </remarks>
                        public static PropertyKey StandbyModeSupported => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.StandbyModeSupported);
                        #endregion

                        #region [public] {static} (PropertyKey) SuspendModeSupported: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>
                        /// Gets a value representing the key to retrieve the property.
                        /// </para>
                        /// <para>— Key Composition ——————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.SuspendModeSupported"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Return Value ———————————————— </para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                        /// <remarks><para>Key definition:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Structure</term>
                        ///     <description>
                        ///       <see cref="KnownEdidSection.BasicDisplay" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Property</term>
                        ///     <description>
                        ///       <see cref="KnownEdidBasicDisplayProperty.SuspendModeSupported" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Unit</term>
                        ///     <description>
                        ///       <see cref="PropertyUnit.None" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// <para>Returns:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Type</term>
                        ///     <description>
                        ///       <see cref="T:System.Boolean" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// </remarks>
                        public static PropertyKey SuspendModeSupported => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.SuspendModeSupported);
                        #endregion

                        #region [public] {static} (PropertyKey) ActiveOffSupported: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>
                        /// Gets a value representing the key to retrieve the property.
                        /// </para>
                        /// <para>— Key Composition ——————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="KnownEdidBasicDisplayProperty.ActiveOffSupported"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Return Value ———————————————— </para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                        /// <remarks><para>Key definition:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Structure</term>
                        ///     <description>
                        ///       <see cref="KnownEdidSection.BasicDisplay" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Property</term>
                        ///     <description>
                        ///       <see cref="KnownEdidBasicDisplayProperty.ActiveOffSupported" />
                        ///     </description>
                        ///   </item>
                        ///   <item>
                        ///     <term>Unit</term>
                        ///     <description>
                        ///       <see cref="PropertyUnit.None" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// <para>Returns:</para>
                        /// <list type="table">
                        ///   <item>
                        ///     <term>Type</term>
                        ///     <description>
                        ///       <see cref="T:System.Boolean" />
                        ///     </description>
                        ///   </item>
                        /// </list>
                        /// </remarks>
                        public static PropertyKey ActiveOffSupported => new PropertyKey(KnownEdidSection.BasicDisplay, KnownEdidBasicDisplayProperty.ActiveOffSupported);
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
                #region [public] {static} (PropertyKey) Red: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.ColorCharacteristics"/></para>
                /// <para>Property: <see cref="KnownEdidColorCharacteristicsProperty.Red"/></para>
                /// <para>Unit: <see cref="PropertyUnit.Bits"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Drawing.PointF"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.ColorCharacteristics" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidColorCharacteristicsProperty.Red" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.Bits" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Drawing.PointF"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Red => new PropertyKey(KnownEdidSection.ColorCharacteristics, KnownEdidColorCharacteristicsProperty.Red);
                #endregion

                #region [public] {static} (PropertyKey) Green: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.ColorCharacteristics"/></para>
                /// <para>Property: <see cref="KnownEdidColorCharacteristicsProperty.Green"/></para>
                /// <para>Unit: <see cref="PropertyUnit.Bits"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Drawing.PointF"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.ColorCharacteristics" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidColorCharacteristicsProperty.Green" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.Bits" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Drawing.PointF"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Green => new PropertyKey(KnownEdidSection.ColorCharacteristics, KnownEdidColorCharacteristicsProperty.Green);
                #endregion

                #region [public] {static} (PropertyKey) Blue: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.ColorCharacteristics"/></para>
                /// <para>Property: <see cref="KnownEdidColorCharacteristicsProperty.Blue"/></para>
                /// <para>Unit: <see cref="PropertyUnit.Bits"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Drawing.PointF"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.ColorCharacteristics" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidColorCharacteristicsProperty.Blue" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.Bits" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Drawing.PointF"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Blue => new PropertyKey(KnownEdidSection.ColorCharacteristics, KnownEdidColorCharacteristicsProperty.Blue);
                #endregion

                #region [public] {static} (PropertyKey) White: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.ColorCharacteristics"/></para>
                /// <para>Property: <see cref="KnownEdidColorCharacteristicsProperty.White"/></para>
                /// <para>Unit: <see cref="PropertyUnit.Bits"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Drawing.PointF"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.ColorCharacteristics" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidColorCharacteristicsProperty.White" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.Bits" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Drawing.PointF"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey White => new PropertyKey(KnownEdidSection.ColorCharacteristics, KnownEdidColorCharacteristicsProperty.White);
                #endregion
            }
            #endregion

            #region [public] {static} (class) EstablishedTimings: Definition of keys in the 'Established Timings I, II' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.EstablishedTimings"/> section.
            /// </summary>
            public static class EstablishedTimings
            {
                #region [public] {static} (PropertyKey) Resolutions: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.EstablishedTimings"/></para>
                /// <para>Property: <see cref="KnownEdidEstablishedTimingsProperty.Resolutions"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="ReadOnlyCollection{MonitorResolutionInfo}"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.EstablishedTimings" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidEstablishedTimingsProperty.Resolutions" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="ReadOnlyCollection{MonitorResolutionInfo}"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Resolutions => new PropertyKey(KnownEdidSection.EstablishedTimings, KnownEdidEstablishedTimingsProperty.Resolutions);
                #endregion
            }
            #endregion

            #region [public] {static} (class) StandardTimings: Definition of keys in the 'Standard Timings 16 Bytes' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.StandardTimings"/> section.
            /// </summary>
            public static class StandardTimings
            {
                #region [public] {static} (PropertyKey) Timing1: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="KnownEdidStandardTimingProperty.Timing1"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.StandardTimings" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidStandardTimingProperty.Timing1" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="StandardTimingIdentifierDescriptorItem"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Timing1 => new PropertyKey(KnownEdidSection.StandardTimings, KnownEdidStandardTimingProperty.Timing1);
                #endregion

                #region [public] {static} (PropertyKey) Timing2: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="KnownEdidStandardTimingProperty.Timing2"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.StandardTimings" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidStandardTimingProperty.Timing2" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="StandardTimingIdentifierDescriptorItem"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Timing2 => new PropertyKey(KnownEdidSection.StandardTimings, KnownEdidStandardTimingProperty.Timing2);
                #endregion

                #region [public] {static} (PropertyKey) Timing3: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="KnownEdidStandardTimingProperty.Timing3"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.StandardTimings" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidStandardTimingProperty.Timing3" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="StandardTimingIdentifierDescriptorItem"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Timing3 => new PropertyKey(KnownEdidSection.StandardTimings, KnownEdidStandardTimingProperty.Timing3);
                #endregion

                #region [public] {static} (PropertyKey) Timing4: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="KnownEdidStandardTimingProperty.Timing4"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.StandardTimings" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidStandardTimingProperty.Timing4" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="StandardTimingIdentifierDescriptorItem"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Timing4 => new PropertyKey(KnownEdidSection.StandardTimings, KnownEdidStandardTimingProperty.Timing4);
                #endregion

                #region [public] {static} (PropertyKey) Timing5: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="KnownEdidStandardTimingProperty.Timing5"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.StandardTimings" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidStandardTimingProperty.Timing5" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="StandardTimingIdentifierDescriptorItem"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Timing5 => new PropertyKey(KnownEdidSection.StandardTimings, KnownEdidStandardTimingProperty.Timing5);
                #endregion

                #region [public] {static} (PropertyKey) Timing6: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="KnownEdidStandardTimingProperty.Timing6"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.StandardTimings" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidStandardTimingProperty.Timing6" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="StandardTimingIdentifierDescriptorItem"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Timing6 => new PropertyKey(KnownEdidSection.StandardTimings, KnownEdidStandardTimingProperty.Timing6);
                #endregion

                #region [public] {static} (PropertyKey) Timing7: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="KnownEdidStandardTimingProperty.Timing7"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.StandardTimings" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidStandardTimingProperty.Timing7" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="StandardTimingIdentifierDescriptorItem"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Timing7 => new PropertyKey(KnownEdidSection.StandardTimings, KnownEdidStandardTimingProperty.Timing7);
                #endregion

                #region [public] {static} (PropertyKey) Timing8: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="KnownEdidStandardTimingProperty.Timing8"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.StandardTimings" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidStandardTimingProperty.Timing8" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="StandardTimingIdentifierDescriptorItem"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Timing8 => new PropertyKey(KnownEdidSection.StandardTimings, KnownEdidStandardTimingProperty.Timing8);
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

                #region [public] {static} (PropertyKey) Descriptor1: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                /// <para>Property: <see cref="KnownEdidDataBlockProperty.Descriptor1"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="KeyValuePair{TKey, TValue}" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.DataBlocks" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidDataBlockProperty.Descriptor1" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="KeyValuePair{TKey, TValue}" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Descriptor1 => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockProperty.Descriptor1);
                #endregion

                #region [public] {static} (PropertyKey) Descriptor2: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                /// <para>Property: <see cref="KnownEdidDataBlockProperty.Descriptor2"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="KeyValuePair{TKey, TValue}" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.DataBlocks" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidDataBlockProperty.Descriptor2" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="KeyValuePair{TKey, TValue}" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Descriptor2 => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockProperty.Descriptor2);
                #endregion

                #region [public] {static} (PropertyKey) Descriptor3: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                /// <para>Property: <see cref="KnownEdidDataBlockProperty.Descriptor3"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="KeyValuePair{TKey, TValue}" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.DataBlocks" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidDataBlockProperty.Descriptor3" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="KeyValuePair{TKey, TValue}" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Descriptor3 => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockProperty.Descriptor3);
                #endregion

                #region [public] {static} (PropertyKey) Descriptor4: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                /// <para>Property: <see cref="KnownEdidDataBlockProperty.Descriptor4"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="KeyValuePair{TKey, TValue}" /></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.DataBlocks" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidDataBlockProperty.Descriptor4" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="KeyValuePair{TKey, TValue}" />
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Descriptor4 => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockProperty.Descriptor4);
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
                    /// Definition of keys in the <strong>DataBlock</strong> of <see cref="KnownEdidDataBlockDescriptor.AlphaNumericDataString" /> type.
                    /// </summary>
                    public static class AlphanumericDataString
                    {
                        #region [public] {static} (PropertyKey) Text: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.AlphaNumericDataString"/></para>
                        /// 	<para>Property: <see cref="KnownAlphanumericDataStringDescriptorProperty.Text"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.String"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Text => new PropertyKey(KnownEdidDataBlockDescriptor.AlphaNumericDataString, KnownAlphanumericDataStringDescriptorProperty.Text);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) ColorManagementData: Definition of keys in the 'DataBlocks' of 'ColorManagementData' type
                    /// <summary>
                    /// Definition of keys in the <strong>DataBlock</strong> of <see cref="KnownEdidDataBlockDescriptor.ColorManagementData" /> type.
                    /// </summary>
                    public static class ColorManagementData
                    {
                        #region public readonly properties

                        #region [public] {static} (PropertyKey) VersionNumber: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.ColorManagementData"/></para>
                        /// 	<para>Property: <see cref="KnownColorManagementDataDescriptorProperty.Version"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Byte"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey VersionNumber => new PropertyKey(KnownEdidDataBlockDescriptor.ColorManagementData, KnownColorManagementDataDescriptorProperty.Version);
                        #endregion

                        #region [public] {static} (PropertyKey) Red: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.ColorManagementData"/></para>
                        /// 	<para>Property: <see cref="KnownColorManagementDataDescriptorProperty.Red"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="KnownColorManagementDataDescriptorItemProperty"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Red => new PropertyKey(KnownEdidDataBlockDescriptor.ColorManagementData, KnownColorManagementDataDescriptorProperty.Red);
                        #endregion

                        #region [public] {static} (PropertyKey) Green: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.ColorManagementData"/></para>
                        /// 	<para>Property: <see cref="KnownColorManagementDataDescriptorProperty.Green"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="KnownColorManagementDataDescriptorItemProperty"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Green => new PropertyKey(KnownEdidDataBlockDescriptor.ColorManagementData, KnownColorManagementDataDescriptorProperty.Green);
                        #endregion

                        #region [public] {static} (PropertyKey) Blue: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.ColorManagementData"/></para>
                        /// 	<para>Property: <see cref="KnownColorManagementDataDescriptorProperty.Blue"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="KnownColorManagementDataDescriptorItemProperty"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Blue => new PropertyKey(KnownEdidDataBlockDescriptor.ColorManagementData, KnownColorManagementDataDescriptorProperty.Blue);
                        #endregion

                        #endregion


                        #region nested classes
                        /// <summary>
                        /// Definition of keys for an element of a block of type <see cref="KnownEdidDataBlockDescriptor.ColorManagementData" />.
                        /// </summary>
                        public static class Item
                        {
                            #region [public] {static} (PropertyKey) A2: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                            /// 	<para>— Composición ——————————————</para>
                            /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.ColorManagementData"/></para>
                            /// 	<para>Property: <see cref="KnownColorManagementDataDescriptorItemProperty.A2"/></para>
                            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                            /// 	<para>— Valor —————————————————— </para>
                            /// 	<para>Type: <see cref="T:System.Int32"/></para>
                            /// </summary>
                            /// <value>
                            /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                            /// 	<para>Clave de la propiedad.</para>
                            /// </value>
                            public static PropertyKey A2 => new PropertyKey(KnownEdidDataBlockDescriptor.ColorManagementData, KnownColorManagementDataDescriptorItemProperty.A2);
                            #endregion

                            #region [public] {static} (PropertyKey) A3: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                            /// 	<para>— Composición ——————————————</para>
                            /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.ColorManagementData"/></para>
                            /// 	<para>Property: <see cref="KnownColorManagementDataDescriptorItemProperty.A3"/></para>
                            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                            /// 	<para>— Valor —————————————————— </para>
                            /// 	<para>Type: <see cref="T:System.Int32"/></para>
                            /// </summary>
                            /// <value>
                            /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                            /// 	<para>Clave de la propiedad.</para>
                            /// </value>
                            public static PropertyKey A3 => new PropertyKey(KnownEdidDataBlockDescriptor.ColorManagementData, KnownColorManagementDataDescriptorItemProperty.A3);
                            #endregion
                        }
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) ColorPointData: Definición de claves para un 'DataBlock' de tipo 'ColorPointData'.
                    /// <summary>
                    /// Definition of keys in the <strong>DataBlock</strong> of <see cref="KnownEdidDataBlockDescriptor.ColorPointData" /> type.
                    /// </summary>
                    public static class ColorPointData
                    {
                        #region public readonly properties

                        #region [public] {static} (PropertyKey) Point1: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.ColorPointData"/></para>
                        /// 	<para>Property: <see cref="KnownColorPointDataDescriptorProperty.Point1"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="ColorPointDataDescriptorItem"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Point1 => new PropertyKey(KnownEdidDataBlockDescriptor.ColorPointData, KnownColorPointDataDescriptorProperty.Point1);
                        #endregion

                        #region [public] {static} (PropertyKey) Point2: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.ColorPointData"/></para>
                        /// 	<para>Property: <see cref="KnownColorPointDataDescriptorProperty.Point2"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="ColorPointDataDescriptorItem"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Point2 => new PropertyKey(KnownEdidDataBlockDescriptor.ColorPointData, KnownColorPointDataDescriptorProperty.Point2);
                        #endregion

                        #endregion


                        #region nested classes

                        #region [public] {static} (class) Item: Definición de claves para un elemento de un bloque de tipo 'ColorPointData'.
                        /// <summary>
                        /// Definición de claves para un elemento de un bloque de tipo <see cref="KnownEdidDataBlockDescriptor.ColorPointData"/>.
                        /// </summary>
                        public static class Item
                        {
                            #region [public] {static} (PropertyKey) Index: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                            /// 	<para>— Composición ——————————————</para>
                            /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.ColorPointData"/></para>
                            /// 	<para>Property: <see cref="KnownColorPointDataDescriptorItemProperty.Index"/></para>
                            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                            /// 	<para>— Valor —————————————————— </para>
                            /// 	<para>Type: <see cref="T:System.Byte"/></para>
                            /// </summary>
                            /// <value>
                            /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                            /// 	<para>Clave de la propiedad.</para>
                            /// </value>
                            public static PropertyKey Index => new PropertyKey(KnownEdidDataBlockDescriptor.ColorPointData, KnownColorPointDataDescriptorItemProperty.Index);
                            #endregion

                            #region [public] {static} (PropertyKey) White: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                            /// 	<para>— Composición ——————————————</para>
                            /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.ColorPointData"/></para>
                            /// 	<para>Property: <see cref="KnownColorPointDataDescriptorItemProperty.White"/></para>
                            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                            /// 	<para>— Valor —————————————————— </para>
                            /// 	<para>Type: <see cref="T:System.Drawing.PointF"/></para>
                            /// </summary>
                            /// <value>
                            /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                            /// 	<para>Clave de la propiedad.</para>
                            /// </value>
                            public static PropertyKey White => new PropertyKey(KnownEdidDataBlockDescriptor.ColorPointData, KnownColorPointDataDescriptorItemProperty.White);
                            #endregion

                            #region [public] {static} (PropertyKey) Gamma: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                            /// 	<para>— Composición ——————————————</para>
                            /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.ColorPointData"/></para>
                            /// 	<para>Property: <see cref="KnownColorPointDataDescriptorItemProperty.Gamma"/></para>
                            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                            /// 	<para>— Valor —————————————————— </para>
                            /// 	<para>Type: <see cref="T:System.Double"/>?</para>
                            /// </summary>
                            /// <value>
                            /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                            /// 	<para>Clave de la propiedad.</para>
                            /// </value>
                            public static PropertyKey Gamma => new PropertyKey(KnownEdidDataBlockDescriptor.ColorPointData, KnownColorPointDataDescriptorItemProperty.Gamma);
                            #endregion
                        }
                        #endregion

                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) CVT3ByteCode: Definición de claves para un 'DataBlock' de tipo 'CVT3ByteCode'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/>.
                    /// </summary>
                    public static class CVT3ByteCode
                    {
                        #region public readonly properties

                        #region [public] {static} (PropertyKey) VersionNumber: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                        /// 	<para>Property: <see cref="KnownCvt3ByteCodeDescriptorProperty.Version"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Byte"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey VersionNumber => new PropertyKey(KnownEdidDataBlockDescriptor.Cvt3ByteCode, KnownCvt3ByteCodeDescriptorProperty.Version);
                        #endregion

                        #region [public] {static} (PropertyKey) Priority1: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                        /// 	<para>Property: <see cref="KnownCvt3ByteCodeDescriptorProperty.Priority1"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="Cvt3ByteCodeDescriptorItem"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Priority1 => new PropertyKey(KnownEdidDataBlockDescriptor.Cvt3ByteCode, KnownCvt3ByteCodeDescriptorProperty.Priority1);
                        #endregion

                        #region [public] {static} (PropertyKey) Priority2: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                        /// 	<para>Property: <see cref="KnownCvt3ByteCodeDescriptorProperty.Priority2"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="Cvt3ByteCodeDescriptorItem"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Priority2 => new PropertyKey(KnownEdidDataBlockDescriptor.Cvt3ByteCode, KnownCvt3ByteCodeDescriptorProperty.Priority2);
                        #endregion

                        #region [public] {static} (PropertyKey) Priority3: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                        /// 	<para>Property: <see cref="KnownCvt3ByteCodeDescriptorProperty.Priority3"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="Cvt3ByteCodeDescriptorItem"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Priority3 => new PropertyKey(KnownEdidDataBlockDescriptor.Cvt3ByteCode, KnownCvt3ByteCodeDescriptorProperty.Priority3);
                        #endregion

                        #region [public] {static} (PropertyKey) Priority4: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                        /// 	<para>Property: <see cref="KnownCvt3ByteCodeDescriptorProperty.Priority4"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="Cvt3ByteCodeDescriptorItem"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Priority4 => new PropertyKey(KnownEdidDataBlockDescriptor.Cvt3ByteCode, KnownCvt3ByteCodeDescriptorProperty.Priority4);
                        #endregion

                        #endregion


                        #region nested classes
                        /// <summary>
                        /// Definición de claves para un elemento de un bloque de tipo <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/>.
                        /// </summary>
                        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
                        public static class Item
                        {
                            #region public readonly properties

                            #region [public] {static} (PropertyKey) AddressableVerticalLines: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                            /// 	<para>— Composición ——————————————</para>
                            /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                            /// 	<para>Property: <see cref="KnownCvt3ByteCodeDescriptorItemProperty.AddressableVerticalLines"/></para>
                            /// 	<para>Unit: <see cref="PropertyUnit.Lines"/></para>
                            /// 	<para>— Valor —————————————————— </para>
                            /// 	<para>Type: <see cref="T:System.Int32"/></para>
                            /// </summary>
                            /// <value>
                            /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                            /// 	<para>Clave de la propiedad.</para>
                            /// </value>
                            public static PropertyKey AddressableVerticalLines => new PropertyKey(KnownEdidDataBlockDescriptor.Cvt3ByteCode, KnownCvt3ByteCodeDescriptorItemProperty.AddressableVerticalLines, PropertyUnit.Lines);
                            #endregion

                            #region [public] {static} (PropertyKey) AspectRatio: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                            /// 	<para>— Composición ——————————————</para>
                            /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                            /// 	<para>Property: <see cref="KnownCvt3ByteCodeDescriptorItemProperty.AspectRatio"/></para>
                            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                            /// 	<para>— Valor —————————————————— </para>
                            /// 	<para>Type: <see cref="T:System.String"/></para>
                            /// </summary>
                            /// <value>
                            /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                            /// 	<para>Clave de la propiedad.</para>
                            /// </value>
                            public static PropertyKey AspectRatio => new PropertyKey(KnownEdidDataBlockDescriptor.Cvt3ByteCode, KnownCvt3ByteCodeDescriptorItemProperty.AspectRatio);
                            #endregion

                            #region [public] {static} (PropertyKey) PreferredVerticalRate: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                            /// 	<para>— Composición ——————————————</para>
                            /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                            /// 	<para>Property: <see cref="KnownCvt3ByteCodeDescriptorItemProperty.PreferredVerticalRate"/></para>
                            /// 	<para>Unit: <see cref="PropertyUnit.Hz"/></para>
                            /// 	<para>— Valor —————————————————— </para>
                            /// 	<para>Type: <see cref="T:System.Byte"/></para>
                            /// </summary>
                            /// <value>
                            /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                            /// 	<para>Clave de la propiedad.</para>
                            /// </value>
                            public static PropertyKey PreferredVerticalRate => new PropertyKey(KnownEdidDataBlockDescriptor.Cvt3ByteCode, KnownCvt3ByteCodeDescriptorItemProperty.PreferredVerticalRate, PropertyUnit.Hz);
                            #endregion

                            #endregion


                            #region nested classes

                            #region [public] {static} (class) SupportedVerticalRateAndBlanking: Definición de claves de la sección 'Supported Vertical Rate And Blanking Style'.
                            /// <summary>
                            /// Definición de claves de la sección <strong>Supported Vertical Rate And Blanking Style</strong>.
                            /// </summary>
                            public static class SupportedVerticalRateAndBlanking
                            {
                                #region [public] {static} (PropertyKey) IsSupported50HzWithStandardBlanking: Obtiene un valor que representa la clave para recuperar la propiedad.
                                /// <summary>
                                /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                                /// 	<para>— Composición ——————————————</para>
                                /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                                /// 	<para>Property: <see cref="KnownCvt3ByteCodeDescriptorItemProperty.IsSupported50HzWithStandardBlanking"/></para>
                                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// 	<para>— Valor —————————————————— </para>
                                /// 	<para>Type: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                /// <value>
                                /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                                /// 	<para>Clave de la propiedad.</para>
                                /// </value>
                                public static PropertyKey IsSupported50HzWithStandardBlanking => new PropertyKey(KnownEdidDataBlockDescriptor.Cvt3ByteCode, KnownCvt3ByteCodeDescriptorItemProperty.IsSupported50HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (PropertyKey) IsSupported60HzWithStandardBlanking: Obtiene un valor que representa la clave para recuperar la propiedad.
                                /// <summary>
                                /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                                /// 	<para>— Composición ——————————————</para>
                                /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                                /// 	<para>Property: <see cref="KnownCvt3ByteCodeDescriptorItemProperty.IsSupported60HzWithStandardBlanking"/></para>
                                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// 	<para>— Valor —————————————————— </para>
                                /// 	<para>Type: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                /// <value>
                                /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                                /// 	<para>Clave de la propiedad.</para>
                                /// </value>
                                public static PropertyKey IsSupported60HzWithStandardBlanking => new PropertyKey(KnownEdidDataBlockDescriptor.Cvt3ByteCode, KnownCvt3ByteCodeDescriptorItemProperty.IsSupported60HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (PropertyKey) IsSupported75HzWithStandardBlanking: Obtiene un valor que representa la clave para recuperar la propiedad.
                                /// <summary>
                                /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                                /// 	<para>— Composición ——————————————</para>
                                /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                                /// 	<para>Property: <see cref="KnownCvt3ByteCodeDescriptorItemProperty.IsSupported75HzWithStandardBlanking"/></para>
                                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// 	<para>— Valor —————————————————— </para>
                                /// 	<para>Type: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                /// <value>
                                /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                                /// 	<para>Clave de la propiedad.</para>
                                /// </value>
                                public static PropertyKey IsSupported75HzWithStandardBlanking => new PropertyKey(KnownEdidDataBlockDescriptor.Cvt3ByteCode, KnownCvt3ByteCodeDescriptorItemProperty.IsSupported75HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (PropertyKey) IsSupported85HzWithStandardBlanking: Obtiene un valor que representa la clave para recuperar la propiedad.
                                /// <summary>
                                /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                                /// 	<para>— Composición ——————————————</para>
                                /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                                /// 	<para>Property: <see cref="KnownCvt3ByteCodeDescriptorItemProperty.IsSupported85HzWithStandardBlanking"/></para>
                                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// 	<para>— Valor —————————————————— </para>
                                /// 	<para>Type: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                /// <value>
                                /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                                /// 	<para>Clave de la propiedad.</para>
                                /// </value>
                                public static PropertyKey IsSupported85HzWithStandardBlanking => new PropertyKey(KnownEdidDataBlockDescriptor.Cvt3ByteCode, KnownCvt3ByteCodeDescriptorItemProperty.IsSupported85HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (PropertyKey) IsSupported60HzWithReducedBlanking: Obtiene un valor que representa la clave para recuperar la propiedad.
                                /// <summary>
                                /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                                /// 	<para>— Composición ——————————————</para>
                                /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                                /// 	<para>Property: <see cref="KnownCvt3ByteCodeDescriptorItemProperty.IsSupported60HzWithReducedBlanking"/></para>
                                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// 	<para>— Valor —————————————————— </para>
                                /// 	<para>Type: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                /// <value>
                                /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                                /// 	<para>Clave de la propiedad.</para>
                                /// </value>
                                public static PropertyKey IsSupported60HzWithReducedBlanking => new PropertyKey(KnownEdidDataBlockDescriptor.Cvt3ByteCode, KnownCvt3ByteCodeDescriptorItemProperty.IsSupported60HzWithReducedBlanking);
                                #endregion
                            }
                            #endregion

                            #endregion
                        }
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DetailedTimingMode: Definición de claves para un 'DataBlock' de tipo 'DetailedTimingMode'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/>.
                    /// </summary>
                    public static class DetailedTimingMode
                    {
                        #region [public] {static} (PropertyKey) PixelClock: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.PixelClock"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.KHz"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey PixelClock => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.PixelClock, PropertyUnit.KHz);
                        #endregion

                        #region [public] {static} (PropertyKey) HorizontalResolution Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.HorizontalResolution"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.Pixels"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey HorizontalResolution => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.HorizontalResolution, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (PropertyKey) HorizontalBlanking Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.HorizontalBlanking"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.Pixels"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey HorizontalBlanking => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.HorizontalBlanking, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (PropertyKey) VerticalLines Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.VerticalLines"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.Lines"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey VerticalLines => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.VerticalLines, PropertyUnit.Lines);
                        #endregion

                        #region [public] {static} (PropertyKey) VerticalBlanking Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.VerticalBlanking"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.Lines"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey VerticalBlanking => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.VerticalBlanking, PropertyUnit.Lines);
                        #endregion

                        #region [public] {static} (PropertyKey) HorizontalFrontPorch Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.HorizontalFrontPorch"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.Pixels"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey HorizontalFrontPorch => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.HorizontalFrontPorch, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (PropertyKey) HorizontalSyncPulseWidth Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.HorizontalSyncPulseWidth"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.Pixels"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey HorizontalSyncPulseWidth => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.HorizontalSyncPulseWidth, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (PropertyKey) VerticalFrontPorch Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.VerticalFrontPorch"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.Lines"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey VerticalFrontPorch => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.VerticalFrontPorch, PropertyUnit.Lines);
                        #endregion

                        #region [public] {static} (PropertyKey) VerticalSyncPulseWidth Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.VerticalSyncPulseWidth"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.Lines"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey VerticalSyncPulseWidth => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.VerticalSyncPulseWidth, PropertyUnit.Lines);
                        #endregion

                        #region [public] {static} (PropertyKey) HorizontalImageSize Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.HorizontalImageSize"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.mm"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey HorizontalImageSize => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.HorizontalImageSize, PropertyUnit.mm);
                        #endregion

                        #region [public] {static} (PropertyKey) VerticalImageSize Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.VerticalImageSize"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.mm"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey VerticalImageSize => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.VerticalImageSize, PropertyUnit.mm);
                        #endregion

                        #region [public] {static} (PropertyKey) HorizontalBorder Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.HorizontalBorder"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.Pixels"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Byte"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey HorizontalBorder => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.HorizontalBorder, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (PropertyKey) VerticalBorder Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.VerticalBorder"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.Pixels"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Byte"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey VerticalBorder => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.VerticalBorder, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (PropertyKey) IsInterlaced Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.Interlaced"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Boolean"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey IsInterlaced => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.Interlaced);
                        #endregion

                        #region [public] {static} (PropertyKey) StereoViewingSupport Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.StereoViewingSupport"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.String"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey StereoViewingSupport => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.StereoViewingSupport);
                        #endregion

                        #region [public] {static} (PropertyKey) SyncSignalType Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// 	<para>Property: <see cref="KnownDetailedTimingModeDescriptorProperty.SyncSignalType"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.String"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey SyncSignalType => new PropertyKey(KnownEdidDataBlockDescriptor.DetailedTimingMode, KnownDetailedTimingModeDescriptorProperty.SyncSignalType);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DisplayProductName: Definición de claves para un 'DataBlock' de tipo 'DisplayProductName'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="KnownEdidDataBlockDescriptor.DisplayProductName"/>.
                    /// </summary>
                    public static class DisplayProductName
                    {
                        #region [public] {static} (PropertyKey) Text: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DisplayProductName"/></para>
                        /// 	<para>Property: <see cref="KnownDisplayProductNameDescriptorProperty.Text"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.String"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Text => new PropertyKey(KnownEdidDataBlockDescriptor.DisplayProductName, KnownDisplayProductNameDescriptorProperty.Text);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DisplayProductSerialNumber: Definición de claves para un 'DataBlock' de tipo 'DisplayProductSerialNumber'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="KnownEdidDataBlockDescriptor.DisplayProductSerialNumber"/>.
                    /// </summary>
                    public static class DisplayProductSerialNumber
                    {
                        #region [public] {static} (PropertyKey) Text: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DisplayProductSerialNumber"/></para>
                        /// 	<para>Property: <see cref="KnownDisplayProductSerialNumberDescriptorProperty.Text"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.String"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Text => new PropertyKey(KnownEdidDataBlockDescriptor.DisplayProductSerialNumber, KnownDisplayProductSerialNumberDescriptorProperty.Text);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DisplayRangeLimits: Definición de claves para un 'DataBlock' de tipo 'DisplayRangeLimits'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="KnownEdidDataBlockDescriptor.DisplayRangeLimits"/>.
                    /// </summary>
                    public static class DisplayRangeLimits
                    {
                        #region [public] {static} (PropertyKey) Text: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DisplayRangeLimits"/></para>
                        /// 	<para>Property: <see cref="KnownDisplayRangeLimitsDescriptorProperty.FaltanTodasLasClaves"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.String"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey FaltanTodasLasClaves => new PropertyKey(KnownEdidDataBlockDescriptor.DisplayRangeLimits, KnownDisplayRangeLimitsDescriptorProperty.FaltanTodasLasClaves);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DummyData: Definición de claves para un 'DataBlock' de tipo 'DummyData'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="KnownEdidDataBlockDescriptor.DummyData"/>.
                    /// </summary>
                    public static class DummyData
                    {
                        #region [public] {static} (PropertyKey) Data: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.DummyData"/></para>
                        /// 	<para>Property: <see cref="KnownDummyDataDescriptorProperty.Data"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="ReadOnlyCollection{Byte}"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Data => new PropertyKey(KnownEdidDataBlockDescriptor.DummyData, KnownDummyDataDescriptorProperty.Data);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) EstablishedTimingsIII: Definición de claves para un 'DataBlock' de tipo 'EstablishedTimingsIII'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="KnownEdidDataBlockDescriptor.EstablishedTimingsIII"/>.
                    /// </summary>
                    public static class EstablishedTimingsIII
                    {
                        #region [public] {static} (PropertyKey) Revision: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.EstablishedTimingsIII"/></para>
                        /// 	<para>Property: <see cref="KnownEstablishedTimingsIIIDescriptorProperty.Revision"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="T:System.Byte"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Revision => new PropertyKey(KnownEdidDataBlockDescriptor.EstablishedTimingsIII, KnownEstablishedTimingsIIIDescriptorProperty.Revision);
                        #endregion

                        #region [public] {static} (PropertyKey) Resolutions Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.EstablishedTimingsIII"/></para>
                        /// 	<para>Property: <see cref="KnownEstablishedTimingsIIIDescriptorProperty.Resolutions"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="ReadOnlyCollection{MonitorResolutionInfo}"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Resolutions => new PropertyKey(KnownEdidDataBlockDescriptor.EstablishedTimingsIII, KnownEstablishedTimingsIIIDescriptorProperty.Resolutions);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) ManufacturerSpecifiedData: Definición de claves para un 'DataBlock' de tipo 'ManufacturerSpecifiedData'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="KnownEdidDataBlockDescriptor.ManufacturerSpecifiedData"/>.
                    /// </summary>
                    public static class ManufacturerSpecifiedData
                    {
                        #region [public] {static} (PropertyKey) Text: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.ManufacturerSpecifiedData"/></para>
                        /// 	<para>Property: <see cref="KnownManufacturerSpecifiedDataDescriptorProperty.Data"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="ReadOnlyCollection{Byte}"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Data => new PropertyKey(KnownEdidDataBlockDescriptor.ManufacturerSpecifiedData, KnownManufacturerSpecifiedDataDescriptorProperty.Data);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) StandardTimingIdentifier: Definición de claves para un 'DataBlock' de tipo 'StandardTimingIdentifier'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="KnownEdidDataBlockDescriptor.StandardTimingIdentifier"/>.
                    /// </summary>
                    public static class StandardTimingIdentifier
                    {
                        #region [public] {static} (PropertyKey) Timing9: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.StandardTimingIdentifier"/></para>
                        /// 	<para>Property: <see cref="KnownStandardTimingIdentifierDescriptorProperty.Timing9"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Timing9 => new PropertyKey(KnownEdidDataBlockDescriptor.StandardTimingIdentifier, KnownStandardTimingIdentifierDescriptorProperty.Timing9);
                        #endregion

                        #region [public] {static} (PropertyKey) Timing10: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.StandardTimingIdentifier"/></para>
                        /// 	<para>Property: <see cref="KnownStandardTimingIdentifierDescriptorProperty.Timing10"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Timing10 => new PropertyKey(KnownEdidDataBlockDescriptor.StandardTimingIdentifier, KnownStandardTimingIdentifierDescriptorProperty.Timing10);
                        #endregion

                        #region [public] {static} (PropertyKey) Timing11: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.StandardTimingIdentifier"/></para>
                        /// 	<para>Property: <see cref="KnownStandardTimingIdentifierDescriptorProperty.Timing11"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Timing11 => new PropertyKey(KnownEdidDataBlockDescriptor.StandardTimingIdentifier, KnownStandardTimingIdentifierDescriptorProperty.Timing11);
                        #endregion

                        #region [public] {static} (PropertyKey) Timing12: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.StandardTimingIdentifier"/></para>
                        /// 	<para>Property: <see cref="KnownStandardTimingIdentifierDescriptorProperty.Timing12"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Timing12 => new PropertyKey(KnownEdidDataBlockDescriptor.StandardTimingIdentifier, KnownStandardTimingIdentifierDescriptorProperty.Timing12);
                        #endregion

                        #region [public] {static} (PropertyKey) Timing13: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.StandardTimingIdentifier"/></para>
                        /// 	<para>Property: <see cref="KnownStandardTimingIdentifierDescriptorProperty.Timing13"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Timing13 => new PropertyKey(KnownEdidDataBlockDescriptor.StandardTimingIdentifier, KnownStandardTimingIdentifierDescriptorProperty.Timing13);
                        #endregion

                        #region [public] {static} (PropertyKey) Timing14: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                        /// 	<para>— Composición ——————————————</para>
                        /// 	<para>Structure: <see cref="KnownEdidDataBlockDescriptor.StandardTimingIdentifier"/></para>
                        /// 	<para>Property: <see cref="KnownStandardTimingIdentifierDescriptorProperty.Timing14"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>— Valor —————————————————— </para>
                        /// 	<para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                        /// 	<para>Clave de la propiedad.</para>
                        /// </value>
                        public static PropertyKey Timing14 => new PropertyKey(KnownEdidDataBlockDescriptor.StandardTimingIdentifier, KnownStandardTimingIdentifierDescriptorProperty.Timing14);
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
                    #region [public] {static} (PropertyKey) AlphaNumericDataString: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                    /// 	<para>— Composición ——————————————</para>
                    /// 	<para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// 	<para>Property: <see cref="KnownEdidDataBlockDescriptor.AlphaNumericDataString"/></para>
                    /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// 	<para>— Valor —————————————————— </para>
                    /// 	<para>Type: <see cref="AlphaNumericDataStringDescriptor"/></para>
                    /// </summary>
                    /// <value>
                    /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                    /// 	<para>Clave de la propiedad.</para>
                    /// </value>
                    public static PropertyKey AlphaNumericDataString => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockDescriptor.AlphaNumericDataString);
                    #endregion

                    #region [public] {static} (PropertyKey) ColorManagementData: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                    /// 	<para>— Composición ——————————————</para>
                    /// 	<para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// 	<para>Property: <see cref="KnownEdidDataBlockDescriptor.ColorManagementData"/></para>
                    /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// 	<para>— Valor —————————————————— </para>
                    /// 	<para>Type: <see cref="ColorManagementDataDescriptor"/></para>
                    /// </summary>
                    /// <value>
                    /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                    /// 	<para>Clave de la propiedad.</para>
                    /// </value>
                    public static PropertyKey ColorManagementData => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockDescriptor.ColorManagementData);
                    #endregion

                    #region [public] {static} (PropertyKey) ColorPointData: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                    /// 	<para>— Composición ——————————————</para>
                    /// 	<para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// 	<para>Property: <see cref="KnownEdidDataBlockDescriptor.ColorPointData"/></para>
                    /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// 	<para>— Valor —————————————————— </para>
                    /// 	<para>Type: <see cref="ColorPointDataDescriptor"/></para>
                    /// </summary>
                    /// <value>
                    /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                    /// 	<para>Clave de la propiedad.</para>
                    /// </value>
                    public static PropertyKey ColorPointData => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockDescriptor.ColorPointData);
                    #endregion

                    #region [public] {static} (PropertyKey) CVT3ByteCode: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                    /// 	<para>— Composición ——————————————</para>
                    /// 	<para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// 	<para>Property: <see cref="KnownEdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                    /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// 	<para>— Valor —————————————————— </para>
                    /// 	<para>Type: <see cref="Cvt3ByteCodeDescriptor"/></para>
                    /// </summary>
                    /// <value>
                    /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                    /// 	<para>Clave de la propiedad.</para>
                    /// </value>
                    public static PropertyKey CVT3ByteCode => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockDescriptor.Cvt3ByteCode);
                    #endregion

                    #region [public] {static} (PropertyKey) DetailedTimingMode: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                    /// 	<para>— Composición ——————————————</para>
                    /// 	<para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// 	<para>Property: <see cref="KnownEdidDataBlockDescriptor.DetailedTimingMode"/></para>
                    /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// 	<para>— Valor —————————————————— </para>
                    /// 	<para>Type: <see cref="DetailedTimingModeDescriptor"/></para>
                    /// </summary>
                    /// <value>
                    /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                    /// 	<para>Clave de la propiedad.</para>
                    /// </value>
                    public static PropertyKey DetailedTimingMode => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockDescriptor.DetailedTimingMode);
                    #endregion

                    #region [public] {static} (PropertyKey) DisplayProductName: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                    /// 	<para>— Composición ——————————————</para>
                    /// 	<para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// 	<para>Property: <see cref="KnownEdidDataBlockDescriptor.DisplayProductName"/></para>
                    /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// 	<para>— Valor —————————————————— </para>
                    /// 	<para>Type: <see cref="DisplayProductNameDescriptor"/></para>
                    /// </summary>
                    /// <value>
                    /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                    /// 	<para>Clave de la propiedad.</para>
                    /// </value>
                    public static PropertyKey DisplayProductName => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockDescriptor.DisplayProductName);
                    #endregion

                    #region [public] {static} (PropertyKey) DisplayProductSerialNumber: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                    /// 	<para>— Composición ——————————————</para>
                    /// 	<para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// 	<para>Property: <see cref="KnownEdidDataBlockDescriptor.DisplayProductSerialNumber"/></para>
                    /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// 	<para>— Valor —————————————————— </para>
                    /// 	<para>Type: <see cref="DisplayProductSerialNumberDescriptor"/></para>
                    /// </summary>
                    /// <value>
                    /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                    /// 	<para>Clave de la propiedad.</para>
                    /// </value>
                    public static PropertyKey DisplayProductSerialNumber => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockDescriptor.DisplayProductSerialNumber);
                    #endregion

                    #region [public] {static} (PropertyKey) DisplayRangeLimits: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                    /// 	<para>— Composición ——————————————</para>
                    /// 	<para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// 	<para>Property: <see cref="KnownEdidDataBlockDescriptor.DisplayRangeLimits"/></para>
                    /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// 	<para>— Valor —————————————————— </para>
                    /// 	<para>Type: <see cref="DisplayRangeLimitsDescriptor"/></para>
                    /// </summary>
                    /// <value>
                    /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                    /// 	<para>Clave de la propiedad.</para>
                    /// </value>
                    public static PropertyKey DisplayRangeLimits => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockDescriptor.DisplayRangeLimits);
                    #endregion

                    #region [public] {static} (PropertyKey) DummyData: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                    /// 	<para>— Composición ——————————————</para>
                    /// 	<para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// 	<para>Property: <see cref="KnownEdidDataBlockDescriptor.DummyData"/></para>
                    /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// 	<para>— Valor —————————————————— </para>
                    /// 	<para>Type: <see cref="DummyDataDescriptor"/></para>
                    /// </summary>
                    /// <value>
                    /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                    /// 	<para>Clave de la propiedad.</para>
                    /// </value>
                    public static PropertyKey DummyData => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockDescriptor.DummyData);
                    #endregion

                    #region [public] {static} (PropertyKey) EstablishedTimingsIII: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                    /// 	<para>— Composición ——————————————</para>
                    /// 	<para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// 	<para>Property: <see cref="KnownEdidDataBlockDescriptor.EstablishedTimingsIII"/></para>
                    /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// 	<para>— Valor —————————————————— </para>
                    /// 	<para>Type: <see cref="EstablishedTimingsIIIDescriptor"/></para>
                    /// </summary>
                    /// <value>
                    /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                    /// 	<para>Clave de la propiedad.</para>
                    /// </value>
                    public static PropertyKey EstablishedTimingsIII => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockDescriptor.EstablishedTimingsIII);
                    #endregion

                    #region [public] {static} (PropertyKey) ManufacturerSpecifiedData: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                    /// 	<para>— Composición ——————————————</para>
                    /// 	<para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// 	<para>Property: <see cref="KnownEdidDataBlockDescriptor.ManufacturerSpecifiedData"/></para>
                    /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// 	<para>— Valor —————————————————— </para>
                    /// 	<para>Type: <see cref="ManufacturerSpecifiedDataDescriptor"/></para>
                    /// </summary>
                    /// <value>
                    /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                    /// 	<para>Clave de la propiedad.</para>
                    /// </value>
                    public static PropertyKey ManufacturerSpecifiedData => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockDescriptor.ManufacturerSpecifiedData);
                    #endregion

                    #region [public] {static} (PropertyKey) StandardTimingIdentifier: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                    /// 	<para>— Composición ——————————————</para>
                    /// 	<para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// 	<para>Property: <see cref="KnownEdidDataBlockDescriptor.StandardTimingIdentifier"/></para>
                    /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// 	<para>— Valor —————————————————— </para>
                    /// 	<para>Type: <see cref="StandardTimingIdentifierDescriptor"/></para>
                    /// </summary>
                    /// <value>
                    /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                    /// 	<para>Clave de la propiedad.</para>
                    /// </value>
                    public static PropertyKey StandardTimingIdentifier => new PropertyKey(KnownEdidSection.DataBlocks, KnownEdidDataBlockDescriptor.StandardTimingIdentifier);
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
                #region [public] {static} (PropertyKey) Count: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                /// 	<para>— Composición ——————————————</para>
                /// 	<para>Structure: <see cref="KnownEdidSection.ExtensionBlocks"/></para>
                /// 	<para>Property: <see cref="KnownEdidExtensionBlocksProperty.Count"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>— Valor —————————————————— </para>
                /// 	<para>Type: <see cref="T:System.Byte"/></para>
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                /// 	<para>Clave de la propiedad.</para>
                /// </value>
                public static PropertyKey Count => new PropertyKey(KnownEdidSection.ExtensionBlocks, KnownEdidExtensionBlocksProperty.Count);
                #endregion

                #region [public] {static} (PropertyKey) HasBlocks: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                /// 	<para>— Composición ——————————————</para>
                /// 	<para>Structure: <see cref="KnownEdidSection.ExtensionBlocks"/></para>
                /// 	<para>Property: <see cref="KnownEdidExtensionBlocksProperty.HasBlocks"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>— Valor —————————————————— </para>
                /// 	<para>Type: <see cref="T:System.Boolean"/></para>
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                /// 	<para>Clave de la propiedad.</para>
                /// </value>
                public static PropertyKey HasBlocks => new PropertyKey(KnownEdidSection.ExtensionBlocks, KnownEdidExtensionBlocksProperty.HasBlocks);
                #endregion
            }
            #endregion

            #region [public] {static} (class) CheckSum: Definition of keys in the 'CheckSum' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.CheckSum"/> section.
            /// </summary>
            public static class CheckSum
            {
                #region [public] {static} (PropertyKey) IsValid: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.CheckSum"/></para>
                /// <para>Property: <see cref="KnownEdidCheckSumProperty.IsValid"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownEdidSection.CheckSum" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownEdidCheckSumProperty.IsValid" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey IsValid => new PropertyKey(KnownEdidSection.CheckSum, KnownEdidCheckSumProperty.IsValid);
                #endregion
            }
            #endregion
        }
        #endregion

        #region [public] {static} (class) Cea: Definition of keys in the 'CEA' block
        /// <summary>
        /// Definition of keys in the <see cref="KnownDataBlock.CEA" /> block.
        /// </summary>
        public static class Cea
        {
            #region [public] {static} (class) Information: Definition of keys in the 'Information' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownCeaSection.Information"/> section.
            /// </summary>
            public static class Information
            {
                #region [public] {static} (PropertyKey) Revision: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                /// 	<para>— Composición ——————————————</para>
                /// 	<para>Structure: <see cref="KnownCeaSection.Information"/></para>
                /// 	<para>Property: <see cref="KnownCeaInformationProperty.Revision"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>— Valor —————————————————— </para>
                /// 	<para>Type: <see cref="T:System.String"/></para>
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                /// 	<para>Clave de la propiedad.</para>
                /// </value>
                public static PropertyKey Revision => new PropertyKey(KnownCeaSection.Information, KnownCeaInformationProperty.Revision);
                #endregion

                #region [public] {static} (PropertyKey) Implemented: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                /// 	<para>— Composición ——————————————</para>
                /// 	<para>Structure: <see cref="KnownCeaSection.Information"/></para>
                /// 	<para>Property: <see cref="KnownCeaInformationProperty.Implemented"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>— Valor —————————————————— </para>
                /// 	<para>Type: <see cref="T:System.String"/></para>
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                /// 	<para>Clave de la propiedad.</para>
                /// </value>
                public static PropertyKey Implemented => new PropertyKey(KnownCeaSection.Information, KnownCeaInformationProperty.Implemented);
                #endregion
            }
            #endregion

            #region [public] {static} (class) MonitorSupport: Definition of keys in the 'MonitorSupport' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownCeaSection.MonitorSupport"/> section.
            /// </summary>
            public static class MonitorSupport
            {
                #region [public] {static} (PropertyKey) IsDvtUnderscan: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                /// 	<para>— Composición ——————————————</para>
                /// 	<para>Structure: <see cref="KnownCeaSection.MonitorSupport"/></para>
                /// 	<para>Property: <see cref="KnownCeaMonitorSupportProperty.IsDvtUnderscan"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>— Valor —————————————————— </para>
                /// 	<para>Type: <see cref="T:System.Boolean"/></para>
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                /// 	<para>Clave de la propiedad.</para>
                /// </value>
                public static PropertyKey IsDvtUnderscan => new PropertyKey(KnownCeaSection.MonitorSupport, KnownCeaMonitorSupportProperty.IsDvtUnderscan);
                #endregion

                #region [public] {static} (PropertyKey) BasicAudioSupported: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                /// 	<para>— Composición ——————————————</para>
                /// 	<para>Structure: <see cref="KnownCeaSection.MonitorSupport"/></para>
                /// 	<para>Property: <see cref="KnownCeaMonitorSupportProperty.BasicAudioSupported"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>— Valor —————————————————— </para>
                /// 	<para>Type: <see cref="T:System.Boolean"/></para>
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                /// 	<para>Clave de la propiedad.</para>
                /// </value>
                public static PropertyKey BasicAudioSupported => new PropertyKey(KnownCeaSection.MonitorSupport, KnownCeaMonitorSupportProperty.BasicAudioSupported);
                #endregion

                #region [public] {static} (PropertyKey) YCbCr444Supported: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                /// 	<para>— Composición ——————————————</para>
                /// 	<para>Structure: <see cref="KnownCeaSection.MonitorSupport"/></para>
                /// 	<para>Property: <see cref="KnownCeaMonitorSupportProperty.YCbCr444Supported"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>— Valor —————————————————— </para>
                /// 	<para>Type: <see cref="T:System.Boolean"/></para>
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                /// 	<para>Clave de la propiedad.</para>
                /// </value>
                public static PropertyKey YCbCr444Supported => new PropertyKey(KnownCeaSection.MonitorSupport, KnownCeaMonitorSupportProperty.YCbCr444Supported);
                #endregion

                #region [public] {static} (PropertyKey) YCbCr422Supported: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                /// 	<para>— Composición ——————————————</para>
                /// 	<para>Structure: <see cref="KnownCeaSection.MonitorSupport"/></para>
                /// 	<para>Property: <see cref="KnownCeaMonitorSupportProperty.YCbCr422Supported"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>— Valor —————————————————— </para>
                /// 	<para>Type: <see cref="T:System.Boolean"/></para>
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                /// 	<para>Clave de la propiedad.</para>
                /// </value>
                public static PropertyKey YCbCr422Supported => new PropertyKey(KnownCeaSection.MonitorSupport, KnownCeaMonitorSupportProperty.YCbCr422Supported);
                #endregion  
            }
            #endregion

            #region [public] {static} (class) DetailedTiming: Definition of keys in the 'DetailedTimings' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownCeaSection.DetailedTiming"/> section.
            /// </summary>
            public static class DetailedTiming
            {
                #region [public] {static} (PropertyKey) Timings: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// 	<para>Obtiene un valor que representa la clave para recuperar la propiedad.</para>
                /// 	<para>— Composición ——————————————</para>
                /// 	<para>Structure: <see cref="KnownCeaSection.DetailedTiming"/></para>
                /// 	<para>Property: <see cref="KnownCeaDetailedTimingModeProperty.Timings"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>— Valor —————————————————— </para>
                /// 	<para>Type: <see cref="ReadOnlyCollection{DetailedTimingDescriptor}"/></para>
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                /// 	<para>Clave de la propiedad.</para>
                /// </value>
                public static PropertyKey Timings => new PropertyKey(KnownCeaSection.DetailedTiming, KnownCeaDetailedTimingModeProperty.Timings);
                #endregion
            }
            #endregion

            #region [public] {static} (class) CheckSum: Definition of keys in the 'CheckSum' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownCeaSection.CheckSum"/> section.
            /// </summary>
            public static class CheckSum
            {
                #region [public] {static} (PropertyKey) Ok: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="KnownCeaSection.CheckSum"/></para>
                /// <para>Property: <see cref="KnownCeaCheckSumProperty.Ok"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean"/></para>
                /// </summary>
                /// <value>A <see cref="T:iTin.Core.Hardware.ProperyKey" /> structure containing the property recovery key</value>
                /// <remarks><para>Key definition:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Structure</term>
                ///     <description>
                ///       <see cref="KnownCeaSection.CheckSum" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Property</term>
                ///     <description>
                ///       <see cref="KnownCeaCheckSumProperty.Ok" />
                ///     </description>
                ///   </item>
                ///   <item>
                ///     <term>Unit</term>
                ///     <description>
                ///       <see cref="PropertyUnit.None" />
                ///     </description>
                ///   </item>
                /// </list>
                /// <para>Returns:</para>
                /// <list type="table">
                ///   <item>
                ///     <term>Type</term>
                ///     <description>
                ///       <see cref="T:System.Boolean"/>
                ///     </description>
                ///   </item>
                /// </list>
                /// </remarks>
                public static PropertyKey Ok => new PropertyKey(KnownCeaSection.CheckSum, KnownCeaCheckSumProperty.Ok);
                #endregion
            }
            #endregion
        }
        #endregion
    }
}
