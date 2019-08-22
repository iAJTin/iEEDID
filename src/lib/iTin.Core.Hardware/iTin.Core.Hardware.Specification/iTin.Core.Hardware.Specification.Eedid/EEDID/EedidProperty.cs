
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Definition of available keys for the <see cref="EEDID" /> specification of a monitor.
    /// </summary>
    public static class EedidProperty
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
                #region [public] {static} (IPropertyKey) Signature: Gets a value that represents the key to recover the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Header"/></para>
                /// <para>Property: <see cref="EdidHeaderProperty.Signature"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="ReadOnlyCollection{Byte}" /></para>
                /// </summary>
                public static IPropertyKey Signature => new PropertyKey(KnownEdidSection.Header, EdidHeaderProperty.Signature);
                #endregion

                #region [public] {static} (IPropertyKey) IsValid: Gets a value that represents the key to recover the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Header"/></para>
                /// <para>Property: <see cref="EdidHeaderProperty.IsValid"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey IsValid => new PropertyKey(KnownEdidSection.Header, EdidHeaderProperty.IsValid, PropertyUnit.None);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Vendor: Definition of keys in the 'Vendor and Product' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownEdidSection.Vendor"/> section.
            /// </summary>
            public static class Vendor
            {
                #region [public] {static} (IPropertyKey) IdManufacturerName: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Vendor"/></para>
                /// <para>Property: <see cref="EdidVendorProperty.IdManufacturerName"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey IdManufacturerName => new PropertyKey(KnownEdidSection.Vendor, EdidVendorProperty.IdManufacturerName);
                #endregion

                #region [public] {static} (IPropertyKey) IdProductCode: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Vendor"/></para>
                /// <para>Property: <see cref="EdidVendorProperty.IdProductCode"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Int32" /></para>
                /// </summary>
                public static IPropertyKey IdProductCode => new PropertyKey(KnownEdidSection.Vendor, EdidVendorProperty.IdProductCode);
                #endregion

                #region [public] {static} (IPropertyKey) IdSerialNumber: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Vendor"/></para>
                /// <para>Property: <see cref="EdidVendorProperty.IdSerialNumber"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Nullable{UInt32}" /></para>
                /// </summary>
                public static IPropertyKey IdSerialNumber => new PropertyKey(KnownEdidSection.Vendor, EdidVendorProperty.IdSerialNumber);
                #endregion

                #region [public] {static} (IPropertyKey) WeekOfManufacture: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Vendor"/></para>
                /// <para>Property: <see cref="EdidVendorProperty.WeekOfManufacture"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Nullable{Byte}" /></para>
                /// </summary>
                public static IPropertyKey WeekOfManufacture => new PropertyKey(KnownEdidSection.Vendor, EdidVendorProperty.WeekOfManufacture);
                #endregion

                #region [public] {static} (IPropertyKey) ManufactureDate: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Vendor"/></para>
                /// <para>Property: <see cref="EdidVendorProperty.ManufactureDate"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                public static IPropertyKey ManufactureDate => new PropertyKey(KnownEdidSection.Vendor, EdidVendorProperty.ManufactureDate);
                #endregion

                #region [public] {static} (IPropertyKey) ModelYearStrategy: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Vendor"/></para>
                /// <para>Property: <see cref="EdidVendorProperty.ModelYearStrategy"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:iTin.Core.Hardware.Specification.Eedid.KnownModelYearStrategy" /></para>
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
                #region [public] {static} (IPropertyKey) Number: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Vendor"/></para>
                /// <para>Property: <see cref="EdidVersionProperty.Version"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                public static IPropertyKey Number => new PropertyKey(KnownEdidSection.Version, EdidVersionProperty.Version);
                #endregion

                #region [public] {static} (IPropertyKey) Revision: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.Version"/></para>
                /// <para>Property: <see cref="EdidVersionProperty.Revision"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
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

                #region [public] {static} (IPropertyKey) VideoInputDefinition: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                /// <para>Property: <see cref="EdidBasicDisplayProperty.VideoInputDefinition"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey VideoInputDefinition => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.VideoInputDefinition);
                #endregion

                #region [public] {static} (IPropertyKey) HorizontalScreenSize: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                /// <para>Property: <see cref="EdidBasicDisplayProperty.HorizontalScreenSize"/></para>
                /// <para>Unit: <see cref="PropertyUnit.cm"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                public static IPropertyKey HorizontalScreenSize => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.HorizontalScreenSize, PropertyUnit.cm);
                #endregion

                #region [public] {static} (IPropertyKey) VerticalScreenSize: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                /// <para>Property: <see cref="EdidBasicDisplayProperty.VerticalScreenSize"/></para>
                /// <para>Unit: <see cref="PropertyUnit.cm"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                public static IPropertyKey VerticalScreenSize => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.VerticalScreenSize, PropertyUnit.cm);
                #endregion

                #region [public] {static} (IPropertyKey) Gamma: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                /// <para>Property: <see cref="EdidBasicDisplayProperty.Gamma"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Nullable{Byte}" /></para>
                /// </summary>
                public static IPropertyKey Gamma => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.Gamma);
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

                    #region [public] {static} (IPropertyKey) SignalLevelStandard: Gets a value representing the key to retrieve the property
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                    /// <para>Property: <see cref="EdidBasicDisplayProperty.AnalogSignalLevelStandard"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="T:System.String" /></para>
                    /// </summary>
                    public static IPropertyKey SignalLevelStandard => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.AnalogSignalLevelStandard);
                    #endregion

                    #region [public] {static} (IPropertyKey) VideoSetup: Gets a value representing the key to retrieve the property
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                    /// <para>Property: <see cref="EdidBasicDisplayProperty.AnalogVideoSetup"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="T:System.String" /></para>
                    /// </summary>
                    public static IPropertyKey VideoSetup => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.AnalogVideoSetup);
                    #endregion

                    #region [public] {static} (IPropertyKey) VerticalSyncSupported: Gets a value representing the key to retrieve the property
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                    /// <para>Property: <see cref="EdidBasicDisplayProperty.AnalogVerticalSyncSupported"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="T:System.Boolean" /></para>
                    /// </summary>
                    public static IPropertyKey VerticalSyncSupported => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.AnalogVerticalSyncSupported);
                    #endregion

                    #region [public] {static} (IPropertyKey) DisplayColorType: Gets a value representing the key to retrieve the property
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                    /// <para>Property: <see cref="EdidBasicDisplayProperty.AnalogDisplayColorType"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="T:System.String" /></para>
                    /// </summary>
                    public static IPropertyKey DisplayColorType => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.AnalogDisplayColorType);
                    #endregion

                    #endregion


                    #region nested classes

                    #region [public] {static} (class) Syncrhonization: Definition of keys in the 'Syncrhonization Types' section
                    /// <summary>
                    /// Definition of keys in the <strong>Syncrhonization Types</strong> section.
                    /// </summary>
                    public static class Syncrhonization
                    {
                        #region [public] {static} (IPropertyKey) SeparateSyncSupported: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="EdidBasicDisplayProperty.AnalogSeparateSyncSupported"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        public static IPropertyKey SeparateSyncSupported => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.AnalogSeparateSyncSupported);
                        #endregion

                        #region [public] {static} (IPropertyKey) CompositeSyncSignalHorizontalSupported: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="EdidBasicDisplayProperty.AnalogCompositeSyncSignalHorizontalSupported"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        public static IPropertyKey CompositeSyncSignalHorizontalSupported => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.AnalogCompositeSyncSignalHorizontalSupported);
                        #endregion

                        #region [public] {static} (IPropertyKey) CompositeSyncSignalGreenVideoSupported: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="EdidBasicDisplayProperty.AnalogCompositeSyncSignalGreenVideoSupported"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
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
                /// Definition of keys in the <strong>Digital</strong> section.
                /// </summary>
                public static class Digital
                {
                    #region [public] {static} (IPropertyKey) ColorBitDepth: Gets a value representing the key to retrieve the property
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                    /// <para>Property: <see cref="EdidBasicDisplayProperty.DigitalColorBitDepth"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="T:System.String" /></para>
                    /// </summary>
                    public static IPropertyKey ColorBitDepth => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.DigitalColorBitDepth);
                    #endregion

                    #region [public] {static} (IPropertyKey) VideoInterface: Gets a value representing the key to retrieve the property
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                    /// <para>Property: <see cref="EdidBasicDisplayProperty.DigitalVideoInterface"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="T:System.String" /></para>
                    /// </summary>
                    public static IPropertyKey VideoInterface => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.DigitalVideoInterface);
                    #endregion

                    #region [public] {static} (IPropertyKey) ColorEncodingFormat: Gets a value representing the key to retrieve the property
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                    /// <para>Property: <see cref="EdidBasicDisplayProperty.DigitalColorEncodingFormat"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="T:System.String" /></para>
                    /// </summary>
                    public static IPropertyKey ColorEncodingFormat => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.DigitalColorEncodingFormat);
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
                        #region [public] {static} (IPropertyKey) IsSrgbDefaultColorSpace: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="EdidBasicDisplayProperty.SrgbDefaultColorSpace"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        public static IPropertyKey IsSrgbDefaultColorSpace => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.SrgbDefaultColorSpace);
                        #endregion

                        #region [public] {static} (IPropertyKey) IncludePreferredTimingMode: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="EdidBasicDisplayProperty.PreferredTimingMode"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        public static IPropertyKey IncludePreferredTimingMode => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.PreferredTimingMode);
                        #endregion

                        #region [public] {static} (IPropertyKey) IsContinuousFrequency: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="EdidBasicDisplayProperty.ContinuousFrequency"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        public static IPropertyKey IsContinuousFrequency => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.ContinuousFrequency);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DisplayPowerManagement: Definición de claves de la sección 'Display Power Management'
                    /// <summary>
                    /// Definition of keys in the <strong>Display Power Management</strong> section.
                    /// </summary>
                    public static class DisplayPowerManagement
                    {
                        #region [public] {static} (IPropertyKey) StandbyModeSupported: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="EdidBasicDisplayProperty.StandbyModeSupported"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        public static IPropertyKey StandbyModeSupported => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.StandbyModeSupported);
                        #endregion

                        #region [public] {static} (IPropertyKey) SuspendModeSupported: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="EdidBasicDisplayProperty.SuspendModeSupported"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
                        /// </summary>
                        public static IPropertyKey SuspendModeSupported => new PropertyKey(KnownEdidSection.BasicDisplay, EdidBasicDisplayProperty.SuspendModeSupported);
                        #endregion

                        #region [public] {static} (IPropertyKey) ActiveOffSupported: Gets a value representing the key to retrieve the property
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="KnownEdidSection.BasicDisplay"/></para>
                        /// <para>Property: <see cref="EdidBasicDisplayProperty.ActiveOffSupported"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Boolean" /></para>
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
                #region [public] {static} (IPropertyKey) Red: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.ColorCharacteristics"/></para>
                /// <para>Property: <see cref="EdidColorCharacteristicsProperty.Red"/></para>
                /// <para>Unit: <see cref="PropertyUnit.Bits"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Drawing.PointF"/></para>
                /// </summary>
                public static IPropertyKey Red => new PropertyKey(KnownEdidSection.ColorCharacteristics, EdidColorCharacteristicsProperty.Red);
                #endregion

                #region [public] {static} (IPropertyKey) Green: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.ColorCharacteristics"/></para>
                /// <para>Property: <see cref="EdidColorCharacteristicsProperty.Green"/></para>
                /// <para>Unit: <see cref="PropertyUnit.Bits"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Drawing.PointF"/></para>
                /// </summary>
                public static IPropertyKey Green => new PropertyKey(KnownEdidSection.ColorCharacteristics, EdidColorCharacteristicsProperty.Green);
                #endregion

                #region [public] {static} (IPropertyKey) Blue: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.ColorCharacteristics"/></para>
                /// <para>Property: <see cref="EdidColorCharacteristicsProperty.Blue"/></para>
                /// <para>Unit: <see cref="PropertyUnit.Bits"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Drawing.PointF"/></para>
                /// </summary>
                public static IPropertyKey Blue => new PropertyKey(KnownEdidSection.ColorCharacteristics, EdidColorCharacteristicsProperty.Blue);
                #endregion

                #region [public] {static} (IPropertyKey) White: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.ColorCharacteristics"/></para>
                /// <para>Property: <see cref="EdidColorCharacteristicsProperty.White"/></para>
                /// <para>Unit: <see cref="PropertyUnit.Bits"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Drawing.PointF"/></para>
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
                #region [public] {static} (IPropertyKey) Resolutions: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.EstablishedTimings"/></para>
                /// <para>Property: <see cref="EdidEstablishedTimingsProperty.Resolutions"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="ReadOnlyCollection{MonitorResolutionInfo}"/></para>
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
                #region [public] {static} (IPropertyKey) Timing1: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="EdidStandardTimingProperty.Timing1"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                public static IPropertyKey Timing1 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing1);
                #endregion

                #region [public] {static} (IPropertyKey) Timing2: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="EdidStandardTimingProperty.Timing2"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                public static IPropertyKey Timing2 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing2);
                #endregion

                #region [public] {static} (IPropertyKey) Timing3: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="EdidStandardTimingProperty.Timing3"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                public static IPropertyKey Timing3 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing3);
                #endregion

                #region [public] {static} (IPropertyKey) Timing4: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="EdidStandardTimingProperty.Timing4"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                public static IPropertyKey Timing4 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing4);
                #endregion

                #region [public] {static} (IPropertyKey) Timing5: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="EdidStandardTimingProperty.Timing5"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                public static IPropertyKey Timing5 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing5);
                #endregion

                #region [public] {static} (IPropertyKey) Timing6: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="EdidStandardTimingProperty.Timing6"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                public static IPropertyKey Timing6 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing6);
                #endregion

                #region [public] {static} (IPropertyKey) Timing7: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="EdidStandardTimingProperty.Timing7"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                /// </summary>
                public static IPropertyKey Timing7 => new PropertyKey(KnownEdidSection.StandardTimings, EdidStandardTimingProperty.Timing7);
                #endregion

                #region [public] {static} (IPropertyKey) Timing8: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.StandardTimings"/></para>
                /// <para>Property: <see cref="EdidStandardTimingProperty.Timing8"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
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

                #region [public] {static} (IPropertyKey) Descriptor1: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                /// <para>Property: <see cref="EdidDataBlockProperty.Descriptor1"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="KeyValuePair{TKey, TValue}" /></para>
                /// </summary>
                public static IPropertyKey Descriptor1 => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockProperty.Descriptor1);
                #endregion

                #region [public] {static} (IPropertyKey) Descriptor2: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                /// <para>Property: <see cref="EdidDataBlockProperty.Descriptor2"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="KeyValuePair{TKey, TValue}" /></para>
                /// </summary>
                public static IPropertyKey Descriptor2 => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockProperty.Descriptor2);
                #endregion

                #region [public] {static} (IPropertyKey) Descriptor3: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                /// <para>Property: <see cref="EdidDataBlockProperty.Descriptor3"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="KeyValuePair{TKey, TValue}" /></para>
                /// </summary>
                public static IPropertyKey Descriptor3 => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockProperty.Descriptor3);
                #endregion

                #region [public] {static} (IPropertyKey) Descriptor4: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                /// <para>Property: <see cref="EdidDataBlockProperty.Descriptor4"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="KeyValuePair{TKey, TValue}" /></para>
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
                    /// Definition of keys in the <strong>DataBlock</strong> of <see cref="EdidDataBlockDescriptor.AlphaNumericDataString" /> type.
                    /// </summary>
                    public static class AlphanumericDataString
                    {
                        #region [public] {static} (IPropertyKey) Text: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.AlphaNumericDataString"/></para>
                        /// <para>Property: <see cref="AlphanumericDataStringDescriptorProperty.Text"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Valor —————————————————— </para>
                        /// <para>Type: <see cref="T:System.String"/></para>
                        /// </summary>
                        public static IPropertyKey Data => new PropertyKey(EdidDataBlockDescriptor.AlphaNumericDataString, AlphanumericDataStringDescriptorProperty.Text);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) ColorManagementData: Definition of keys in the 'DataBlocks' of 'ColorManagementData' type
                    /// <summary>
                    /// Definition of keys in the <strong>DataBlock</strong> of <see cref="EdidDataBlockDescriptor.ColorManagementData" /> type.
                    /// </summary>
                    public static class ColorManagementData
                    {
                        #region public readonly properties

                        #region [public] {static} (IPropertyKey) VersionNumber: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></para>
                        /// <para>Property: <see cref="ColorManagementDataDescriptorProperty.Version"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Byte"/></para>
                        /// </summary>
                        public static IPropertyKey VersionNumber => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, ColorManagementDataDescriptorProperty.Version);
                        #endregion

                        #region [public] {static} (IPropertyKey) Red: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></para>
                        /// <para>Property: <see cref="ColorManagementDataDescriptorProperty.Red"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="ColorManagementDataDescriptorItemProperty"/></para>
                        /// </summary>
                        public static IPropertyKey Red => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, ColorManagementDataDescriptorProperty.Red);
                        #endregion

                        #region [public] {static} (IPropertyKey) Green: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></para>
                        /// <para>Property: <see cref="ColorManagementDataDescriptorProperty.Green"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="ColorManagementDataDescriptorItemProperty"/></para>
                        /// </summary>
                        public static IPropertyKey Green => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, ColorManagementDataDescriptorProperty.Green);
                        #endregion

                        #region [public] {static} (IPropertyKey) Blue: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        ///	<para>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></para>
                        ///	<para>Property: <see cref="ColorManagementDataDescriptorProperty.Blue"/></para>
                        ///	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        ///	<para>Type: <see cref="ColorManagementDataDescriptorItemProperty"/></para>
                        /// </summary>
                        public static IPropertyKey Blue => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, ColorManagementDataDescriptorProperty.Blue);
                        #endregion

                        #endregion


                        #region nested classes
                        /// <summary>
                        /// Definition of keys for an element of a block of type <see cref="EdidDataBlockDescriptor.ColorManagementData" />.
                        /// </summary>
                        public static class Item
                        {
                            #region [public] {static} (IPropertyKey) A2: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property.</para>
                            /// <para>— Key Composition —————————————————</para>
                            /// <para>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></para>
                            /// <para>Property: <see cref="ColorManagementDataDescriptorItemProperty.A2"/></para>
                            /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                            /// <para>— Value ——————————————————————</para>
                            /// <para>Type: <see cref="T:System.Int32"/></para>
                            /// </summary>
                            public static IPropertyKey A2 => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, ColorManagementDataDescriptorItemProperty.A2);
                            #endregion

                            #region [public] {static} (IPropertyKey) A3: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property.</para>
                            /// <para>— Key Composition —————————————————</para>
                            ///	<para>Structure: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></para>
                            ///	<para>Property: <see cref="ColorManagementDataDescriptorItemProperty.A3"/></para>
                            ///	<para>Unit: <see cref="PropertyUnit.None"/></para>
                            /// <para>— Value ——————————————————————</para>
                            ///	<para>Type: <see cref="T:System.Int32"/></para>
                            /// </summary>
                            public static IPropertyKey A3 => new PropertyKey(EdidDataBlockDescriptor.ColorManagementData, ColorManagementDataDescriptorItemProperty.A3);
                            #endregion
                        }
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) ColorPointData: Definición de claves para un 'DataBlock' de tipo 'ColorPointData'.
                    /// <summary>
                    /// Definition of keys in the <strong>DataBlock</strong> of <see cref="EdidDataBlockDescriptor.ColorPointData" /> type.
                    /// </summary>
                    public static class ColorPointData
                    {
                        #region public readonly properties

                        #region [public] {static} (IPropertyKey) Point1: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.ColorPointData"/></para>
                        /// <para>Property: <see cref="ColorPointDataDescriptorProperty.Point1"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="ColorPointDataDescriptorItem"/></para>
                        /// </summary>
                        public static IPropertyKey Point1 => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, ColorPointDataDescriptorProperty.Point1);
                        #endregion

                        #region [public] {static} (IPropertyKey) Point2: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.ColorPointData"/></para>
                        /// <para>Property: <see cref="ColorPointDataDescriptorProperty.Point2"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="ColorPointDataDescriptorItem"/></para>
                        /// </summary>
                        public static IPropertyKey Point2 => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, ColorPointDataDescriptorProperty.Point2);
                        #endregion

                        #endregion


                        #region nested classes

                        #region [public] {static} (class) Item: Definición de claves para un elemento de un bloque de tipo 'ColorPointData'.
                        /// <summary>
                        /// Definición de claves para un elemento de un bloque de tipo <see cref="EdidDataBlockDescriptor.ColorPointData"/>.
                        /// </summary>
                        public static class Item
                        {
                            #region [public] {static} (IPropertyKey) Index: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property.</para>
                            /// <para>— Key Composition —————————————————</para>
                            /// <para>Structure: <see cref="EdidDataBlockDescriptor.ColorPointData"/></para>
                            /// <para>Property: <see cref="ColorPointDataDescriptorItemProperty.Index"/></para>
                            /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                            /// <para>— Value ——————————————————————</para>
                            /// <para>Type: <see cref="T:System.Byte"/></para>
                            /// </summary>
                            public static IPropertyKey Index => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, ColorPointDataDescriptorItemProperty.Index);
                            #endregion

                            #region [public] {static} (IPropertyKey) White: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property.</para>
                            /// <para>— Key Composition —————————————————</para>
                            /// <para>Structure: <see cref="EdidDataBlockDescriptor.ColorPointData"/></para>
                            /// <para>Property: <see cref="ColorPointDataDescriptorItemProperty.White"/></para>
                            /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                            /// <para>— Value ——————————————————————</para>
                            /// <para>Type: <see cref="T:System.Drawing.PointF"/></para>
                            /// </summary>
                            public static IPropertyKey White => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, ColorPointDataDescriptorItemProperty.White);
                            #endregion

                            #region [public] {static} (IPropertyKey) Gamma: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property.</para>
                            /// <para>— Key Composition —————————————————</para>
                            /// <para>Structure: <see cref="EdidDataBlockDescriptor.ColorPointData"/></para>
                            /// <para>Property: <see cref="ColorPointDataDescriptorItemProperty.Gamma"/></para>
                            /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                            /// <para>— Value ——————————————————————</para>
                            /// <para>Type: <see cref="T:System.Double"/>?</para>
                            /// </summary>
                            public static IPropertyKey Gamma => new PropertyKey(EdidDataBlockDescriptor.ColorPointData, ColorPointDataDescriptorItemProperty.Gamma);
                            #endregion
                        }
                        #endregion

                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) Cvt3ByteCode: Definición de claves para un 'DataBlock' de tipo 'CVT3ByteCode'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/>.
                    /// </summary>
                    public static class Cvt3ByteCode
                    {
                        #region public readonly properties

                        #region [public] {static} (IPropertyKey) VersionNumber: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                        /// <para>Property: <see cref="Cvt3ByteCodeDescriptorProperty.Version"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Byte"/></para>
                        /// </summary>
                        public static IPropertyKey VersionNumber => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorProperty.Version);
                        #endregion

                        #region [public] {static} (IPropertyKey) Priority1: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                        /// <para>Property: <see cref="Cvt3ByteCodeDescriptorProperty.Priority1"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="Cvt3ByteCodeDescriptorItem"/></para>
                        /// </summary>
                        public static IPropertyKey Priority1 => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorProperty.Priority1);
                        #endregion

                        #region [public] {static} (IPropertyKey) Priority2: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                        /// <para>Property: <see cref="Cvt3ByteCodeDescriptorProperty.Priority2"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        ///	<para>Type: <see cref="Cvt3ByteCodeDescriptorItem"/></para>
                        /// </summary>
                        public static IPropertyKey Priority2 => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorProperty.Priority2);
                        #endregion

                        #region [public] {static} (IPropertyKey) Priority3: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                        /// <para>Property: <see cref="Cvt3ByteCodeDescriptorProperty.Priority3"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="Cvt3ByteCodeDescriptorItem"/></para>
                        /// </summary>
                        public static IPropertyKey Priority3 => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorProperty.Priority3);
                        #endregion

                        #region [public] {static} (IPropertyKey) Priority4: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                        /// <para>Property: <see cref="Cvt3ByteCodeDescriptorProperty.Priority4"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="Cvt3ByteCodeDescriptorItem"/></para>
                        /// </summary>
                        public static IPropertyKey Priority4 => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorProperty.Priority4);
                        #endregion

                        #endregion


                        #region nested classes
                        /// <summary>
                        /// Definición de claves para un elemento de un bloque de tipo <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/>.
                        /// </summary>
                        public static class Item
                        {
                            #region public readonly properties

                            #region [public] {static} (IPropertyKey) AddressableVerticalLines: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property.</para>
                            /// <para>— Key Composition —————————————————</para>
                            /// <para>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                            /// <para>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.AddressableVerticalLines"/></para>
                            /// <para>Unit: <see cref="PropertyUnit.Lines"/></para>
                            /// <para>— Value ——————————————————————</para>
                            /// <para>Type: <see cref="T:System.Int32"/></para>
                            /// </summary>
                            public static IPropertyKey AddressableVerticalLines => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.AddressableVerticalLines, PropertyUnit.Lines);
                            #endregion

                            #region [public] {static} (IPropertyKey) AspectRatio: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property.</para>
                            /// <para>— Key Composition —————————————————</para>
                            /// <para>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                            /// <para>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.AspectRatio"/></para>
                            /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                            /// <para>— Value ——————————————————————</para>
                            /// <para>Type: <see cref="T:System.String"/></para>
                            /// </summary>
                            public static IPropertyKey AspectRatio => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.AspectRatio);
                            #endregion

                            #region [public] {static} (IPropertyKey) PreferredVerticalRate: Obtiene un valor que representa la clave para recuperar la propiedad.
                            /// <summary>
                            /// <para>Gets a value representing the key to retrieve the property.</para>
                            /// <para>— Key Composition —————————————————</para>
                            /// <para>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                            /// <para>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.PreferredVerticalRate"/></para>
                            /// <para>Unit: <see cref="PropertyUnit.Hz"/></para>
                            /// <para>— Value ——————————————————————</para>
                            /// <para>Type: <see cref="T:System.Byte"/></para>
                            /// </summary>
                            public static IPropertyKey PreferredVerticalRate => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.PreferredVerticalRate, PropertyUnit.Hz);
                            #endregion

                            #endregion


                            #region nested classes

                            #region [public] {static} (class) SupportedVerticalRateAndBlanking: Definición de claves de la sección 'Supported Vertical Rate And Blanking Style'.
                            /// <summary>
                            /// Definición de claves de la sección <strong>Supported Vertical Rate And Blanking Style</strong>.
                            /// </summary>
                            public static class SupportedVerticalRateAndBlanking
                            {
                                #region [public] {static} (IPropertyKey) IsSupported50HzWithStandardBlanking: Obtiene un valor que representa la clave para recuperar la propiedad.
                                /// <summary>
                                /// <para>Gets a value representing the key to retrieve the property.</para>
                                /// <para>— Key Composition —————————————————</para>
                                /// <para>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                                /// <para>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.IsSupported50HzWithStandardBlanking"/></para>
                                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// <para>— Value ——————————————————————</para>
                                /// <para>Type: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                public static IPropertyKey IsSupported50HzWithStandardBlanking => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.IsSupported50HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (IPropertyKey) IsSupported60HzWithStandardBlanking: Obtiene un valor que representa la clave para recuperar la propiedad.
                                /// <summary>
                                /// <para>Gets a value representing the key to retrieve the property.</para>
                                /// <para>— Key Composition —————————————————</para>
                                /// <para>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                                /// <para>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.IsSupported60HzWithStandardBlanking"/></para>
                                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// <para>— Value ——————————————————————</para>
                                /// <para>Type: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                public static IPropertyKey IsSupported60HzWithStandardBlanking => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.IsSupported60HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (IPropertyKey) IsSupported75HzWithStandardBlanking: Obtiene un valor que representa la clave para recuperar la propiedad.
                                /// <summary>
                                /// <para>Gets a value representing the key to retrieve the property.</para>
                                /// <para>— Key Composition —————————————————</para>
                                /// <para>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                                /// <para>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.IsSupported75HzWithStandardBlanking"/></para>
                                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// <para>— Value ——————————————————————</para>
                                /// <para>Type: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                public static IPropertyKey IsSupported75HzWithStandardBlanking => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.IsSupported75HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (IPropertyKey) IsSupported85HzWithStandardBlanking: Obtiene un valor que representa la clave para recuperar la propiedad.
                                /// <summary>
                                /// <para>Gets a value representing the key to retrieve the property.</para>
                                /// <para>— Key Composition —————————————————</para>
                                /// <para>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                                /// <para>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.IsSupported85HzWithStandardBlanking"/></para>
                                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// <para>— Value ——————————————————————</para>
                                /// <para>Type: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                public static IPropertyKey IsSupported85HzWithStandardBlanking => new PropertyKey(EdidDataBlockDescriptor.Cvt3ByteCode, Cvt3ByteCodeDescriptorItemProperty.IsSupported85HzWithStandardBlanking);
                                #endregion

                                #region [public] {static} (IPropertyKey) IsSupported60HzWithReducedBlanking: Obtiene un valor que representa la clave para recuperar la propiedad.
                                /// <summary>
                                /// <para>Gets a value representing the key to retrieve the property.</para>
                                /// <para>— Key Composition —————————————————</para>
                                /// <para>Structure: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                                /// <para>Property: <see cref="Cvt3ByteCodeDescriptorItemProperty.IsSupported60HzWithReducedBlanking"/></para>
                                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// <para>— Value ——————————————————————</para>
                                /// <para>Type: <see cref="T:System.Boolean"/></para>
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

                    #region [public] {static} (class) DetailedTimingMode: Definición de claves para un 'DataBlock' de tipo 'DetailedTimingMode'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/>.
                    /// </summary>
                    public static class DetailedTimingMode
                    {
                        #region [public] {static} (IPropertyKey) PixelClock: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// <para>Property: <see cref="DetailedTimingModeDescriptorProperty.PixelClock"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.KHz"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey PixelClock => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.PixelClock, PropertyUnit.KHz);
                        #endregion

                        #region [public] {static} (IPropertyKey) HorizontalResolution Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// <para>Property: <see cref="DetailedTimingModeDescriptorProperty.HorizontalResolution"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.Pixels"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey HorizontalResolution => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.HorizontalResolution, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (IPropertyKey) HorizontalBlanking Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// <para>Property: <see cref="DetailedTimingModeDescriptorProperty.HorizontalBlanking"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.Pixels"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey HorizontalBlanking => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.HorizontalBlanking, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (IPropertyKey) VerticalLines Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// <para>Property: <see cref="DetailedTimingModeDescriptorProperty.VerticalLines"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.Lines"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey VerticalLines => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.VerticalLines, PropertyUnit.Lines);
                        #endregion

                        #region [public] {static} (IPropertyKey) VerticalBlanking Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// <para>Property: <see cref="DetailedTimingModeDescriptorProperty.VerticalBlanking"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.Lines"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey VerticalBlanking => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.VerticalBlanking, PropertyUnit.Lines);
                        #endregion

                        #region [public] {static} (IPropertyKey) HorizontalFrontPorch Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// <para>Property: <see cref="DetailedTimingModeDescriptorProperty.HorizontalFrontPorch"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.Pixels"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey HorizontalFrontPorch => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.HorizontalFrontPorch, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (IPropertyKey) HorizontalSyncPulseWidth Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// <para>Property: <see cref="DetailedTimingModeDescriptorProperty.HorizontalSyncPulseWidth"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.Pixels"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey HorizontalSyncPulseWidth => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.HorizontalSyncPulseWidth, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (IPropertyKey) VerticalFrontPorch Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// <para>Property: <see cref="DetailedTimingModeDescriptorProperty.VerticalFrontPorch"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.Lines"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey VerticalFrontPorch => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.VerticalFrontPorch, PropertyUnit.Lines);
                        #endregion

                        #region [public] {static} (IPropertyKey) VerticalSyncPulseWidth Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// <para>Property: <see cref="DetailedTimingModeDescriptorProperty.VerticalSyncPulseWidth"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.Lines"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey VerticalSyncPulseWidth => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.VerticalSyncPulseWidth, PropertyUnit.Lines);
                        #endregion

                        #region [public] {static} (IPropertyKey) HorizontalImageSize Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// <para>Property: <see cref="DetailedTimingModeDescriptorProperty.HorizontalImageSize"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.mm"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey HorizontalImageSize => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.HorizontalImageSize, PropertyUnit.mm);
                        #endregion

                        #region [public] {static} (IPropertyKey) VerticalImageSize Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        ///	<para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        ///	<para>Property: <see cref="DetailedTimingModeDescriptorProperty.VerticalImageSize"/></para>
                        ///	<para>Unit: <see cref="PropertyUnit.mm"/></para>
                        /// <para>— Value ——————————————————————</para>
                        ///	<para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey VerticalImageSize => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.VerticalImageSize, PropertyUnit.mm);
                        #endregion

                        #region [public] {static} (IPropertyKey) HorizontalBorder Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// <para>Property: <see cref="DetailedTimingModeDescriptorProperty.HorizontalBorder"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.Pixels"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Byte"/></para>
                        /// </summary>
                        public static IPropertyKey HorizontalBorder => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.HorizontalBorder, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (IPropertyKey) VerticalBorder Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// <para>Property: <see cref="DetailedTimingModeDescriptorProperty.VerticalBorder"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.Lines"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Byte"/></para>
                        /// </summary>
                        public static IPropertyKey VerticalBorder => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.VerticalBorder, PropertyUnit.Pixels);
                        #endregion

                        #region [public] {static} (IPropertyKey) IsInterlaced Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// <para>Property: <see cref="DetailedTimingModeDescriptorProperty.Interlaced"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Boolean"/></para>
                        /// </summary>
                        public static IPropertyKey IsInterlaced => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.Interlaced);
                        #endregion

                        #region [public] {static} (IPropertyKey) StereoViewingSupport Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        ///	<para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        ///	<para>Property: <see cref="DetailedTimingModeDescriptorProperty.StereoViewingSupport"/></para>
                        ///	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        ///	<para>Type: <see cref="T:System.String"/></para>
                        /// </summary>
                        public static IPropertyKey StereoViewingSupport => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.StereoViewingSupport);
                        #endregion

                        #region [public] {static} (IPropertyKey) SyncSignalType Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                        /// <para>Property: <see cref="DetailedTimingModeDescriptorProperty.SyncSignalType"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.String"/></para>
                        /// </summary>
                        public static IPropertyKey SyncSignalType => new PropertyKey(EdidDataBlockDescriptor.DetailedTimingMode, DetailedTimingModeDescriptorProperty.SyncSignalType);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DisplayProductName: Definición de claves para un 'DataBlock' de tipo 'DisplayProductName'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="EdidDataBlockDescriptor.DisplayProductName"/>.
                    /// </summary>
                    public static class DisplayProductName
                    {
                        #region [public] {static} (IPropertyKey) Text: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DisplayProductName"/></para>
                        /// <para>Property: <see cref="DisplayProductNameDescriptorProperty.Text"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.String"/></para>
                        /// </summary>
                        public static IPropertyKey Data => new PropertyKey(EdidDataBlockDescriptor.DisplayProductName, DisplayProductNameDescriptorProperty.Text);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DisplayProductSerialNumber: Definición de claves para un 'DataBlock' de tipo 'DisplayProductSerialNumber'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="EdidDataBlockDescriptor.DisplayProductSerialNumber"/>.
                    /// </summary>
                    public static class DisplayProductSerialNumber
                    {
                        #region [public] {static} (IPropertyKey) Text: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        ///	<para>Structure: <see cref="EdidDataBlockDescriptor.DisplayProductSerialNumber"/></para>
                        ///	<para>Property: <see cref="DisplayProductSerialNumberDescriptorProperty.Text"/></para>
                        ///	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        ///	<para>Type: <see cref="T:System.String"/></para>
                        /// </summary>
                        public static IPropertyKey Data => new PropertyKey(EdidDataBlockDescriptor.DisplayProductSerialNumber, DisplayProductSerialNumberDescriptorProperty.Text);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DisplayRangeLimits: Definición de claves para un 'DataBlock' de tipo 'DisplayRangeLimits'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/>.
                    /// </summary>
                    public static class DisplayRangeLimits
                    {
                        #region [public] {static} (IPropertyKey) MinimumVerticalRate: 
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/></para>
                        /// <para>Property: <see cref="DisplayRangeLimitsDescriptorProperty.MinimumVerticalRate"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.Hz"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey MinimumVerticalRate => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, DisplayRangeLimitsDescriptorProperty.MinimumVerticalRate, PropertyUnit.Hz);
                        #endregion

                        #region [public] {static} (IPropertyKey) MaximumVerticalRate: 
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/></para>
                        /// <para>Property: <see cref="DisplayRangeLimitsDescriptorProperty.MaximumVerticalRate"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.Hz"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey MaximumVerticalRate => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, DisplayRangeLimitsDescriptorProperty.MaximumVerticalRate, PropertyUnit.Hz);
                        #endregion

                        #region [public] {static} (IPropertyKey) MinimumHorizontalRate: 
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/></para>
                        /// <para>Property: <see cref="DisplayRangeLimitsDescriptorProperty.MinimumHorizontalRate"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.Hz"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey MinimumHorizontalRate => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, DisplayRangeLimitsDescriptorProperty.MinimumHorizontalRate, PropertyUnit.Hz);
                        #endregion

                        #region [public] {static} (IPropertyKey) MaximumHorizontalRate: 
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/></para>
                        /// <para>Property: <see cref="DisplayRangeLimitsDescriptorProperty.MaximumHorizontalRate"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.Hz"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey MaximumHorizontalRate => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, DisplayRangeLimitsDescriptorProperty.MaximumHorizontalRate, PropertyUnit.Hz);
                        #endregion

                        #region [public] {static} (IPropertyKey) MaximumPixelClock: 
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/></para>
                        /// <para>Property: <see cref="DisplayRangeLimitsDescriptorProperty.MaximumPixelClock"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.MHz"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Int32"/></para>
                        /// </summary>
                        public static IPropertyKey MaximumPixelClock => new PropertyKey(EdidDataBlockDescriptor.DisplayRangeLimits, DisplayRangeLimitsDescriptorProperty.MaximumPixelClock, PropertyUnit.MHz);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) DummyData: Definición de claves para un 'DataBlock' de tipo 'DummyData'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="EdidDataBlockDescriptor.DummyData"/>.
                    /// </summary>
                    public static class DummyData
                    {
                        #region [public] {static} (IPropertyKey) OriginalData: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DummyData"/></para>
                        /// <para>Property: <see cref="DummyDataDescriptorProperty.OriginalData"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.String"/></para>
                        /// </summary>
                        public static IPropertyKey OriginalData => new PropertyKey(EdidDataBlockDescriptor.DummyData, DummyDataDescriptorProperty.OriginalData);
                        #endregion

                        #region [public] {static} (IPropertyKey) PrintableData: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.DummyData"/></para>
                        /// <para>Property: <see cref="DummyDataDescriptorProperty.PrintableData"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.String"/></para>
                        /// </summary>
                        public static IPropertyKey PrintableData => new PropertyKey(EdidDataBlockDescriptor.DummyData, DummyDataDescriptorProperty.PrintableData);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) EstablishedTimingsIII: Definición de claves para un 'DataBlock' de tipo 'EstablishedTimingsIII'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="EdidDataBlockDescriptor.EstablishedTimingsIII"/>.
                    /// </summary>
                    public static class EstablishedTimingsIII
                    {
                        #region [public] {static} (IPropertyKey) Revision: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.EstablishedTimingsIII"/></para>
                        /// <para>Property: <see cref="EstablishedTimingsIIIDescriptorProperty.Revision"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="T:System.Byte"/></para>
                        /// </summary>
                        public static IPropertyKey Revision => new PropertyKey(EdidDataBlockDescriptor.EstablishedTimingsIII, EstablishedTimingsIIIDescriptorProperty.Revision);
                        #endregion

                        #region [public] {static} (IPropertyKey) Resolutions Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.EstablishedTimingsIII"/></para>
                        /// <para>Property: <see cref="EstablishedTimingsIIIDescriptorProperty.Resolutions"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="ReadOnlyCollection{MonitorResolutionInfo}"/></para>
                        /// </summary>
                        public static IPropertyKey Resolutions => new PropertyKey(EdidDataBlockDescriptor.EstablishedTimingsIII, EstablishedTimingsIIIDescriptorProperty.Resolutions);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) ManufacturerSpecifiedData: Definición de claves para un 'DataBlock' de tipo 'ManufacturerSpecifiedData'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="EdidDataBlockDescriptor.ManufacturerSpecifiedData"/>.
                    /// </summary>
                    public static class ManufacturerSpecifiedData
                    {
                        #region [public] {static} (IPropertyKey) Text: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        ///	<para>Structure: <see cref="EdidDataBlockDescriptor.ManufacturerSpecifiedData"/></para>
                        ///	<para>Property: <see cref="ManufacturerSpecifiedDataDescriptorProperty.Data"/></para>
                        ///	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        ///	<para>Type: <see cref="ReadOnlyCollection{Byte}"/></para>
                        /// </summary>
                        public static IPropertyKey Data => new PropertyKey(EdidDataBlockDescriptor.ManufacturerSpecifiedData, ManufacturerSpecifiedDataDescriptorProperty.Data);
                        #endregion
                    }
                    #endregion

                    #region [public] {static} (class) StandardTimingIdentifier: Definición de claves para un 'DataBlock' de tipo 'StandardTimingIdentifier'.
                    /// <summary>
                    /// Definición de claves para un '<strong>DataBlock</strong>' de tipo <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/>.
                    /// </summary>
                    public static class StandardTimingIdentifier
                    {
                        #region [public] {static} (IPropertyKey) Timing9: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></para>
                        /// <para>Property: <see cref="StandardTimingIdentifierDescriptorProperty.Timing9"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                        /// </summary>
                        public static IPropertyKey Timing9 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, StandardTimingIdentifierDescriptorProperty.Timing9);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing10: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></para>
                        /// <para>Property: <see cref="StandardTimingIdentifierDescriptorProperty.Timing10"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                        /// </summary>
                        public static IPropertyKey Timing10 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, StandardTimingIdentifierDescriptorProperty.Timing10);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing11: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></para>
                        /// <para>Property: <see cref="StandardTimingIdentifierDescriptorProperty.Timing11"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                        /// </summary>
                        public static IPropertyKey Timing11 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, StandardTimingIdentifierDescriptorProperty.Timing11);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing12: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></para>
                        /// <para>Property: <see cref="StandardTimingIdentifierDescriptorProperty.Timing12"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                        /// </summary>
                        public static IPropertyKey Timing12 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, StandardTimingIdentifierDescriptorProperty.Timing12);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing13: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></para>
                        /// <para>Property: <see cref="StandardTimingIdentifierDescriptorProperty.Timing13"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
                        /// </summary>
                        public static IPropertyKey Timing13 => new PropertyKey(EdidDataBlockDescriptor.StandardTimingIdentifier, StandardTimingIdentifierDescriptorProperty.Timing13);
                        #endregion

                        #region [public] {static} (IPropertyKey) Timing14: Obtiene un valor que representa la clave para recuperar la propiedad.
                        /// <summary>
                        /// <para>Gets a value representing the key to retrieve the property.</para>
                        /// <para>— Key Composition —————————————————</para>
                        /// <para>Structure: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></para>
                        /// <para>Property: <see cref="StandardTimingIdentifierDescriptorProperty.Timing14"/></para>
                        /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// <para>— Value ——————————————————————</para>
                        /// <para>Type: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
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
                    #region [public] {static} (IPropertyKey) AlphaNumericDataString: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// <para>Property: <see cref="EdidDataBlockDescriptor.AlphaNumericDataString"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="AlphaNumericDataStringDescriptor"/></para>
                    /// </summary>
                    public static IPropertyKey AlphaNumericDataString => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.AlphaNumericDataString);
                    #endregion

                    #region [public] {static} (IPropertyKey) ColorManagementData: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// <para>Property: <see cref="EdidDataBlockDescriptor.ColorManagementData"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="ColorManagementDataDescriptor"/></para>
                    /// </summary>
                    public static IPropertyKey ColorManagementData => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.ColorManagementData);
                    #endregion

                    #region [public] {static} (IPropertyKey) ColorPointData: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// <para>Property: <see cref="EdidDataBlockDescriptor.ColorPointData"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="ColorPointDataDescriptor"/></para>
                    /// </summary>
                    public static IPropertyKey ColorPointData => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.ColorPointData);
                    #endregion

                    #region [public] {static} (IPropertyKey) CVT3ByteCode: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// <para>Property: <see cref="EdidDataBlockDescriptor.Cvt3ByteCode"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="Cvt3ByteCodeDescriptor"/></para>
                    /// </summary>
                    public static IPropertyKey CVT3ByteCode => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.Cvt3ByteCode);
                    #endregion

                    #region [public] {static} (IPropertyKey) DetailedTimingMode: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// <para>Property: <see cref="EdidDataBlockDescriptor.DetailedTimingMode"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="DetailedTimingModeDescriptor"/></para>
                    /// </summary>
                    public static IPropertyKey DetailedTimingMode => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.DetailedTimingMode);
                    #endregion

                    #region [public] {static} (IPropertyKey) DisplayProductName: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// <para>Property: <see cref="EdidDataBlockDescriptor.DisplayProductName"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="DisplayProductNameDescriptor"/></para>
                    /// </summary>
                    public static IPropertyKey DisplayProductName => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.DisplayProductName);
                    #endregion

                    #region [public] {static} (IPropertyKey) DisplayProductSerialNumber: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// <para>Property: <see cref="EdidDataBlockDescriptor.DisplayProductSerialNumber"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="DisplayProductSerialNumberDescriptor"/></para>
                    /// </summary>
                    public static IPropertyKey DisplayProductSerialNumber => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.DisplayProductSerialNumber);
                    #endregion

                    #region [public] {static} (IPropertyKey) DisplayRangeLimits: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// <para>Property: <see cref="EdidDataBlockDescriptor.DisplayRangeLimits"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="DisplayRangeLimitsDescriptor"/></para>
                    /// </summary>
                    public static IPropertyKey DisplayRangeLimits => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.DisplayRangeLimits);
                    #endregion

                    #region [public] {static} (IPropertyKey) DummyData: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// <para>Property: <see cref="EdidDataBlockDescriptor.DummyData"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="DummyDataDescriptor"/></para>
                    /// </summary>
                    public static IPropertyKey DummyData => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.DummyData);
                    #endregion

                    #region [public] {static} (IPropertyKey) EstablishedTimingsIII: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// <para>Property: <see cref="EdidDataBlockDescriptor.EstablishedTimingsIII"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="EstablishedTimingsIIIDescriptor"/></para>
                    /// </summary>
                    public static IPropertyKey EstablishedTimingsIII => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.EstablishedTimingsIII);
                    #endregion

                    #region [public] {static} (IPropertyKey) ManufacturerSpecifiedData: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// <para>Property: <see cref="EdidDataBlockDescriptor.ManufacturerSpecifiedData"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="ManufacturerSpecifiedDataDescriptor"/></para>
                    /// </summary>
                    public static IPropertyKey ManufacturerSpecifiedData => new PropertyKey(KnownEdidSection.DataBlocks, EdidDataBlockDescriptor.ManufacturerSpecifiedData);
                    #endregion

                    #region [public] {static} (IPropertyKey) StandardTimingIdentifier: Obtiene un valor que representa la clave para recuperar la propiedad.
                    /// <summary>
                    /// <para>Gets a value representing the key to retrieve the property.</para>
                    /// <para>— Key Composition —————————————————</para>
                    /// <para>Structure: <see cref="KnownEdidSection.DataBlocks"/></para>
                    /// <para>Property: <see cref="EdidDataBlockDescriptor.StandardTimingIdentifier"/></para>
                    /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                    /// <para>— Value ——————————————————————</para>
                    /// <para>Type: <see cref="StandardTimingIdentifierDescriptor"/></para>
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
                #region [public] {static} (IPropertyKey) Count: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.ExtensionBlocks"/></para>
                /// <para>Property: <see cref="EdidExtensionBlocksProperty.Count"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Byte"/></para>
                /// </summary>
                public static IPropertyKey Count => new PropertyKey(KnownEdidSection.ExtensionBlocks, EdidExtensionBlocksProperty.Count);
                #endregion

                #region [public] {static} (IPropertyKey) HasBlocks: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                ///	<para>Structure: <see cref="KnownEdidSection.ExtensionBlocks"/></para>
                ///	<para>Property: <see cref="EdidExtensionBlocksProperty.HasBlocks"/></para>
                ///	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                ///	<para>Type: <see cref="T:System.Boolean"/></para>
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
                #region [public] {static} (IPropertyKey) OK: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownEdidSection.CheckSum"/></para>
                /// <para>Property: <see cref="EdidCheckSumProperty.Ok"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Boolean"/></para>
                /// </summary>
                public static IPropertyKey Ok => new PropertyKey(KnownEdidSection.CheckSum, EdidCheckSumProperty.Ok);
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
                #region [public] {static} (IPropertyKey) Revision: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownCeaSection.Information"/></para>
                /// <para>Property: <see cref="KnownCeaInformationProperty.Revision"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String"/></para>
                /// </summary>
                public static IPropertyKey Revision => new PropertyKey(KnownCeaSection.Information, KnownCeaInformationProperty.Revision);
                #endregion

                #region [public] {static} (IPropertyKey) Implemented: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownCeaSection.Information"/></para>
                /// <para>Property: <see cref="KnownCeaInformationProperty.Implemented"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String"/></para>
                /// </summary>
                public static IPropertyKey Implemented => new PropertyKey(KnownCeaSection.Information, KnownCeaInformationProperty.Implemented);
                #endregion
            }
            #endregion

            #region [public] {static} (class) MonitorSupport: Definition of keys in the 'MonitorSupport' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownCeaSection.MonitorSupport"/> section.
            /// </summary>
            public static class MonitorSupport
            {
                #region [public] {static} (IPropertyKey) IsDvtUnderscan: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownCeaSection.MonitorSupport"/></para>
                /// <para>Property: <see cref="KnownCeaMonitorSupportProperty.IsDvtUnderscan"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Boolean"/></para>
                /// </summary>
                public static IPropertyKey IsDvtUnderscan => new PropertyKey(KnownCeaSection.MonitorSupport, KnownCeaMonitorSupportProperty.IsDvtUnderscan);
                #endregion

                #region [public] {static} (IPropertyKey) BasicAudioSupported: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownCeaSection.MonitorSupport"/></para>
                /// <para>Property: <see cref="KnownCeaMonitorSupportProperty.BasicAudioSupported"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Boolean"/></para>
                /// </summary>
                public static IPropertyKey BasicAudioSupported => new PropertyKey(KnownCeaSection.MonitorSupport, KnownCeaMonitorSupportProperty.BasicAudioSupported);
                #endregion

                #region [public] {static} (IPropertyKey) YCbCr444Supported: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownCeaSection.MonitorSupport"/></para>
                /// <para>Property: <see cref="KnownCeaMonitorSupportProperty.YCbCr444Supported"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Boolean"/></para>
                /// </summary>
                public static IPropertyKey YCbCr444Supported => new PropertyKey(KnownCeaSection.MonitorSupport, KnownCeaMonitorSupportProperty.YCbCr444Supported);
                #endregion

                #region [public] {static} (IPropertyKey) YCbCr422Supported: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownCeaSection.MonitorSupport"/></para>
                /// <para>Property: <see cref="KnownCeaMonitorSupportProperty.YCbCr422Supported"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Boolean"/></para>
                /// </summary>
                public static IPropertyKey YCbCr422Supported => new PropertyKey(KnownCeaSection.MonitorSupport, KnownCeaMonitorSupportProperty.YCbCr422Supported);
                #endregion  
            }
            #endregion

            #region [public] {static} (class) DetailedTiming: Definition of keys in the 'DetailedTimings' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownCeaSection.DetailedTiming"/> section.
            /// </summary>
            public static class DetailedTiming
            {
                #region [public] {static} (IPropertyKey) Timings: Obtiene un valor que representa la clave para recuperar la propiedad.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownCeaSection.DetailedTiming"/></para>
                /// <para>Property: <see cref="KnownCeaDetailedTimingModeProperty.Timings"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="ReadOnlyCollection{DetailedTimingDescriptor}"/></para>
                /// </summary>
                public static IPropertyKey Timings => new PropertyKey(KnownCeaSection.DetailedTiming, KnownCeaDetailedTimingModeProperty.Timings);
                #endregion
            }
            #endregion

            #region [public] {static} (class) CheckSum: Definition of keys in the 'CheckSum' section
            /// <summary>
            /// Definition of keys in the <see cref="KnownCeaSection.CheckSum"/> section.
            /// </summary>
            public static class CheckSum
            {
                #region [public] {static} (IPropertyKey) Ok: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="KnownCeaSection.CheckSum"/></para>
                /// <para>Property: <see cref="KnownCeaCheckSumProperty.Ok"/></para>
                /// <para>Unit: <see cref="PropertyUnit.None"/></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Boolean"/></para>
                /// </summary>
                public static IPropertyKey Ok => new PropertyKey(KnownCeaSection.CheckSum, KnownCeaCheckSumProperty.Ok);
                #endregion
            }
            #endregion
        }
        #endregion
    }
}
