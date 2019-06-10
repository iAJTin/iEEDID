
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Drawing;

    using Device.DeviceProperty;

    /// <summary>
    /// Returns a reference to the set of properties of the <see cref="KnownDataBlock.EDID" /> block of a monitor.
    /// </summary>
    public sealed class EdidProperties
    {
        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly EdidSectionsInformation _edidSections;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private HeaderProperties _header;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private VendorProperties _vendor;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private VersionProperties _version;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private BasicDisplayProperties _basicDisplay;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ColorCharacteristicsProperties _colorCharacteristics;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private EstablishedTimingsProperties _establishedTimings;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private StandardTimingsProperties _standardTimings;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataBlocksProperties _dataBlocks;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ExtensionBlocksProperties _extensionBlocks;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckSumProperties _checkSum;
        #endregion

        #region constructor/s

        #region [internal] EdidProperties(EdidSectionsInformation): Initialize a new instance of the class with the information of the 'EDID' sections
        /// <summary>
        /// Initialize a new instance of the <see cref="EdidProperties" /> class with the information of the <see cref="KnownDataBlock.EDID" /> sections.
        /// </summary>
        /// <param name="edidSections">Sections information <see cref="KnownDataBlock.EDID" /></param>
        internal EdidProperties(EdidSectionsInformation edidSections)
        {
            _edidSections = edidSections;
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (HeaderProperties) Header: Gets a reference to the set of properties in the 'Header' section of the 'EDID' block
        /// <summary>
        /// Gets a reference to the set of properties in the <see cref="KnownEdidSection.Header" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </summary>
        /// <value>
        /// Properties of the <see cref="KnownEdidSection.Header" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </value>
        public HeaderProperties Header
        {
            get
            {
                if (_header == null)
                {
                    _header = new HeaderProperties(_edidSections.HeaderSection);
                }

                return _header;
            }
        }
        #endregion

        #region [public] (VendorProperties) Vendor: Gets a reference to the set of properties in the 'Vendor' section of the 'EDID' block
        /// <summary>
        /// Gets a reference to the set of properties in the <see cref="KnownEdidSection.Vendor" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </summary>
        /// <value>
        /// Properties of the <see cref="KnownEdidSection.Vendor" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </value>
        public VendorProperties Vendor
        {
            get
            {
                if (_vendor == null)
                {
                    _vendor = new VendorProperties(_edidSections.VendorSection);
                }

                return _vendor;
            }
        }
        #endregion

        #region [public] (VersionProperties) Version: Gets a reference to the set of properties in the 'Version' section of the 'EDID' block
        /// <summary>
        /// Gets a reference to the set of properties in the <see cref="KnownEdidSection.Version" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </summary>
        /// <value>
        /// Properties of the <see cref="KnownEdidSection.Version" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </value>
        public VersionProperties Version
        {
            get
            {
                if (_version == null)
                {
                    _version = new VersionProperties(_edidSections.VersionSection);
                }

                return _version;
            }
        }
        #endregion

        #region [public] (BasicDisplayProperties) BasicDisplay: Gets a reference to the set of properties in the 'BasicDisplay' section of the 'EDID' block
        /// <summary>
        /// Gets a reference to the set of properties in the <see cref="KnownEdidSection.BasicDisplay" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </summary>
        /// <value>
        /// Properties of the <see cref="KnownEdidSection.BasicDisplay" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </value>
        public BasicDisplayProperties BasicDisplay
        {
            get
            {
                if (_basicDisplay == null)
                {
                    _basicDisplay = new BasicDisplayProperties(_edidSections.BasicDisplaySection);
                }

                return _basicDisplay;
            }
        }
        #endregion

        #region [public] (ColorCharacteristicsProperties) ColorCharacteristics: Gets a reference to the set of properties in the 'ColorCharacteristics' section of the 'EDID' block
        /// <summary>
        /// Gets a reference to the set of properties in the <see cref="KnownEdidSection.ColorCharacteristics" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </summary>
        /// <value>
        /// Properties of the <see cref="KnownEdidSection.ColorCharacteristics" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </value>
        public ColorCharacteristicsProperties ColorCharacteristics
        {
            get
            {
                if (_colorCharacteristics == null)
                {
                    _colorCharacteristics = new ColorCharacteristicsProperties(_edidSections.ColorCharacteristicsSection);
                }

                return _colorCharacteristics;
            }
        }
        #endregion

        #region [public] (EstablishedTimingsProperties) EstablishedTimings: Gets a reference to the set of properties in the 'EstablishedTimings' section of the 'EDID' block
        /// <summary>
        /// Gets a reference to the set of properties in the <see cref="KnownEdidSection.EstablishedTimings" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </summary>
        /// <value>
        /// Properties of the <see cref="KnownEdidSection.EstablishedTimings" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </value>
        public EstablishedTimingsProperties EstablishedTimings
        {
            get
            {
                if (_establishedTimings == null)
                {
                    _establishedTimings = new EstablishedTimingsProperties(_edidSections.EstablishedTimingsSection);
                }

                return _establishedTimings;
            }
        }
        #endregion

        #region [public] (StandardTimingsProperties) StandardTimings: Gets a reference to the set of properties in the 'StandardTimings' section of the 'EDID' block
        /// <summary>
        /// Gets a reference to the set of properties in the <see cref="KnownEdidSection.StandardTimings" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </summary>
        /// <value>
        /// Properties of the <see cref="KnownEdidSection.StandardTimings" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </value>
        public StandardTimingsProperties StandardTimmings
        {
            get
            {
                if (_standardTimings == null)
                {
                    _standardTimings = new StandardTimingsProperties(_edidSections.StandardTimingsSection);
                }

                return _standardTimings;
            }
        }
        #endregion

        #region [public] (DataBlocksProperties) DataBlocks: Gets a reference to the set of properties in the 'DataBlocks' section of the 'EDID' block
        /// <summary>
        /// Gets a reference to the set of properties in the <see cref="KnownEdidSection.DataBlocks" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </summary>
        /// <value>
        /// Properties of the <see cref="KnownEdidSection.DataBlocks" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </value>
        public DataBlocksProperties DataBlocks
        {
            get
            {
                if (_dataBlocks == null)
                {
                    _dataBlocks = new DataBlocksProperties(_edidSections.DataBlocksSection);
                }

                return _dataBlocks;
            }
        }
        #endregion

        #region [public] (ExtensionBlocksProperties) ExtensionBlocks: Gets a reference to the set of properties in the 'ExtensionBlocks' section of the 'EDID' block
        /// <summary>
        /// Gets a reference to the set of properties in the <see cref="KnownEdidSection.ExtensionBlocks" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </summary>
        /// <value>
        /// Properties of the <see cref="KnownEdidSection.ExtensionBlocks" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </value>
        public ExtensionBlocksProperties ExtensionBlocks
        {
            get
            {
                if (_extensionBlocks == null)
                {
                    _extensionBlocks = new ExtensionBlocksProperties(_edidSections.ExtensionBlocksSection);
                }

                return _extensionBlocks;
            }
        }
        #endregion

        #region [public] (CheckSumProperties) CheckSum: Gets a reference to the set of properties in the 'CheckSum' section of the 'EDID' block
        /// <summary>
        /// Gets a reference to the set of properties in the <see cref="KnownEdidSection.CheckSum" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </summary>
        /// <value>
        /// Properties of the <see cref="KnownEdidSection.CheckSum" /> section of the <see cref="KnownDataBlock.EDID" /> block.
        /// </value>
        public CheckSumProperties CheckSum
        {
            get
            {
                if (_checkSum == null)
                {
                    _checkSum = new CheckSumProperties(_edidSections.CheckSumSection);
                }

                return _checkSum;
            }
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current class
        /// <summary>
        /// Returns a <see cref="T:System.String" /> that represents the current class.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> representing the class <see cref="EdidProperties" /> current.
        /// </returns>
        /// <remarks>
        /// This method returns a <see cref="T:System.String" /> that contains the name of this block.
        /// </remarks>
        public override string ToString()
        {
            return $"Block={KnownDataBlock.EDID}";
        }
        #endregion

        #endregion


        #region nested classes

        #region [public] {sealed} (class) HeaderProperties: Conjunto de propiedades disponibles para la sección 'Header'.
        /// <summary>
        /// Conjunto de propiedades disponibles para la sección <see cref="KnownEdidSection.Header"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public sealed class HeaderProperties
        {
            #region Declaraciones
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private readonly DataSection _dataSection;
            #endregion

            #region Constructor/es

                #region [internal] EdidHeaderProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'Header'.
                /// <summary>
                /// Inicializa una nueva instancia de la <see cref="HeaderProperties"/> con la información de la sección <see cref="KnownEdidSection.Header"/>.
                /// </summary>
                /// <param name="dataSection">Información de la sección.</param>
                internal HeaderProperties(DataSection dataSection)
                {
                    _dataSection = dataSection;
                }
            #endregion

            #endregion

            #region Propiedades

            #region [public] (DeviceProperty<Byte>) Value: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
            /// <summary>
            /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
            /// 	<para>— Información de la propiedad</para>
            /// 	<para>Description: Número de versión de la especificación implementada en este monitor.</para>
            /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.Header.Signature"/></para>
            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
            /// 	<para>Value: <see cref="ReadOnlyCollection{Byte}"/></para>
            /// </summary>
            /// <value>
            /// Objeto fuertemente tipado que representa el valor de la propiedad.
            /// </value>
            [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
            public DeviceProperty<ReadOnlyCollection<byte>> Value => _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.Header.Signature) as DeviceProperty<ReadOnlyCollection<byte>>;
            #endregion

            #region [public] (DeviceProperty<Boolean>) IsValid: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
            /// <summary>
            /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
            /// 	<para>— Información de la propiedad</para>
            /// 	<para>Description: Número de revisión de la especificación implementada en este monitor.</para>
            /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.Header.IsValid"/></para>
            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
            /// 	<para>Value: <see cref="T:System.Boolean"/></para>
            /// </summary>
            /// <value>
            /// Objeto fuertemente tipado que representa el valor de la propiedad.
            /// </value>
            public DeviceProperty<bool> IsValid => _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.Header.IsValid) as DeviceProperty<bool>;
            #endregion

            #endregion

            #region Overrides

                #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                /// <summary>
                /// Devuelve una cadena que representa la clase <see cref="HeaderProperties"/> actual.
                /// </summary>
                /// <returns>
                /// 	<para>Tipo: <see cref="T:System.String"/></para>
                /// 	<para>Cadena que representa la clase <see cref="HeaderProperties"/> actual.</para>
                /// </returns>
                /// <remarks>
                /// Este método devuelve una cadena que contiene el nombre de la sección.
                /// </remarks>
                public override string ToString()
                {
                    return string.Format(CultureInfo.InvariantCulture, "Section = {0}", KnownEdidSection.Header);
                }
                #endregion

            #endregion
        }
        #endregion

        #region [public] {sealed} (class) VendorProperties: Conjunto de propiedades disponibles para la sección 'Vendor'.
        /// <summary>
        /// Conjunto de propiedades disponibles para la sección <see cref="KnownEdidSection.Vendor"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public sealed class VendorProperties
        {
            #region Declaraciones
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private readonly DataSection _dataSection;
            #endregion

            #region Constructor/es

                #region [internal] VendorProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'Vendor'.
                /// <summary>
                /// Inicializa una nueva instancia de la <see cref="VendorProperties"/> con la información de la sección <see cref="KnownEdidSection.Vendor"/>.
                /// </summary>
                /// <param name="dataSection">Información de la sección.</param>
                internal VendorProperties(DataSection dataSection)
                {
                    _dataSection = dataSection;
                }
                #endregion

            #endregion

            #region Propiedades

                #region [public] (DeviceProperty<String>) IdManufacturerName: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Cadena en formato ISA 3-character ID que representa el identificador del fabricante de este monitor.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.Vendor.IdManufacturerName"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="T:System.String"/></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                public DeviceProperty<String> IdManufacturerName
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.Vendor.IdManufacturerName) as DeviceProperty<String>; }
                }
                #endregion

                #region [public] (DeviceProperty<String>) IdProductCode: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Cadena que representa el código de producto asignado a este monitor.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.Vendor.IdProductCode"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="T:System.String"/></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
                public DeviceProperty<String> IdProductCode
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.Vendor.IdProductCode) as DeviceProperty<String>; }
                }
                #endregion

                #region [public] (DeviceProperty<UInt32?>) IdSerialNumber: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Número de serie de este monitor.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.Vendor.IdSerialNumber"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="T:System.UInt32"/>?</para>
                /// 	<para>Si esta característica no se encuentra disponible se devuelve <b>null</b></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
                public DeviceProperty<UInt32?> IdSerialNumber
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.Vendor.IdSerialNumber) as DeviceProperty<UInt32?>; }
                }
                #endregion

                #region [public] (DeviceProperty<Int32>) ManufactureDate: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Año de fabricación ó año del modelo.</para>
                /// 	<list type="table">
                /// 		<listheader>
                /// 			<term>Criterio</term>
                /// 			<description>Descripción</description>
                /// 		</listheader>
                /// 		<item>
                /// 			<term><strong>Año del modelo</strong></term>
                /// 			<description>Si el valor de la propiedad <see cref="WeekOfManufacture"/> es <strong>-1</strong>.</description>
                /// 		</item>
                /// 		<item>
                /// 			<term><strong>Año de fabricación</strong></term>
                /// 			<description>Si el valor de la propiedad <see cref="WeekOfManufacture"/> es mayor de cero.</description>
                /// 		</item>
                /// 	</list>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.Vendor.ManufactureDate"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="T:System.String"/></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                public DeviceProperty<Int32> ManufactureDate
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.Vendor.ManufactureDate) as DeviceProperty<Int32>; }
                }
                #endregion

                #region [public] (DeviceProperty<Int32?>) WeekOfManufacture: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Semana de fabricación de este monitor.</para>
                /// 	<para>Los posibles valores de esta propiedad son:</para>
                /// 	<list type="table">
                /// 		<listheader>
                /// 			<term>Valor</term>
                /// 			<description>Descripción</description>
                /// 		</listheader>
                /// 		<item>
                /// 			<term><strong>null</strong></term>
                /// 			<description>El valor no está disponible.</description>
                /// 		</item>
                /// 		<item>
                /// 			<term><strong>-1</strong></term>
                /// 			<description>Ver la propiedad <see cref="ManufactureDate"/>.</description>
                /// 		</item>
                /// 	</list>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.Vendor.ManufactureDate"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="T:System.String"/></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
                public DeviceProperty<Int32?> WeekOfManufacture
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.Vendor.WeekOfManufacture) as DeviceProperty<Int32?>; }
                }
                #endregion

            #endregion

            #region Overrides

                #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                /// <summary>
                /// Devuelve una cadena que representa la clase <see cref="VendorProperties"/> actual.
                /// </summary>
                /// <returns>
                /// 	<para>Tipo: <see cref="T:System.String"/></para>
                /// 	<para>Cadena que representa la clase <see cref="VendorProperties"/> actual.</para>
                /// </returns>
                /// <remarks>
                /// Este método devuelve una cadena que contiene el nombre de la sección.
                /// </remarks>
                public override string ToString()
                {
                    return string.Format(CultureInfo.InvariantCulture, "Section = {0}", KnownEdidSection.Vendor);
                }
                #endregion

            #endregion
        }
        #endregion

        #region [public] {sealed} (class) VersionProperties: Conjunto de propiedades disponibles para la sección 'Version'.
        /// <summary>
        /// Conjunto de propiedades disponibles para la sección <see cref="KnownEdidSection.Version"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public sealed class VersionProperties
        {
            #region Declaraciones
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private readonly DataSection _dataSection;
            #endregion

            #region Constructor/es

                #region [internal] VersionProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'Version'.
                /// <summary>
                /// Inicializa una nueva instancia de la <see cref="VersionProperties"/> con la información de la sección <see cref="KnownEdidSection.Version"/>.
                /// </summary>
                /// <param name="dataSection">Información de la sección.</param>
                internal VersionProperties(DataSection dataSection)
                {
                    _dataSection = dataSection;
                }
                #endregion

            #endregion

            #region Propiedades

                #region [public] (DeviceProperty<Byte>) Number: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Número de versión de la especificación implementada en este monitor.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.Version.Number"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="T:System.Byte"/></para>
                /// 	<para>Si está característica no se encuentra disponible se devuelve <b>null</b></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                public DeviceProperty<Byte> Number
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.Version.Number) as DeviceProperty<Byte>; }
                }
                #endregion

                #region [public] (DeviceProperty<Byte>) Revision: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Número de revisión de la especificación implementada en este monitor.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.Version.Revision"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="T:System.Byte"/></para>
                /// 	<para>Si está característica no se encuentra disponible se devuelve <b>null</b></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                public DeviceProperty<Byte> Revision
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.Version.Revision) as DeviceProperty<Byte>; }
                }
                #endregion

            #endregion

            #region Overrides

                #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                /// <summary>
                /// Devuelve una cadena que representa la clase <see cref="VersionProperties"/> actual.
                /// </summary>
                /// <returns>
                /// 	<para>Tipo: <see cref="T:System.String"/></para>
                /// 	<para>Cadena que representa la clase <see cref="VersionProperties"/> actual.</para>
                /// </returns>
                /// <remarks>
                /// Este método devuelve una cadena que contiene el nombre de la sección.
                /// </remarks>
                public override string ToString()
                {
                    return string.Format(CultureInfo.InvariantCulture, "Section = {0}", KnownEdidSection.Version);
                }
                #endregion

            #endregion
        }
        #endregion

        #region [public] {sealed} (class) BasicDisplayProperties: Conjunto de propiedades disponibles para la sección 'BasicDisplay'.
        /// <summary>
        /// Conjunto de propiedades disponibles para la sección <see cref="KnownEdidSection.BasicDisplay"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public sealed class BasicDisplayProperties
        {
            #region Clases anidadas

                #region [public] {sealed} (class) AnalogProperties: Conjunto de propiedades disponibles para la característica 'Analog'.
                /// <summary>
                /// Conjunto de propiedades disponibles para la característica 'Analog'.
                /// </summary>
                [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
                public sealed class AnalogProperties
                {
                    #region Clases anidadas

                        #region [public] {sealed} (class) SyncrhonizationProperties: Conjunto de propiedades disponibles para la característica 'Syncrhonization'.
                        /// <summary>
                        /// Conjunto de propiedades disponibles para la característica 'Syncrhonization'.
                        /// </summary>
                        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
                        public sealed class SyncrhonizationProperties
                        {
                            #region Declaraciones
                            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                            private readonly DataSection _dataSection;
                            #endregion

                            #region Constructor/es

                                #region [internal] SyncrhonizationProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'BasicDisplay'.
                                /// <summary>
                                /// Inicializa una nueva instancia de la <see cref="SyncrhonizationProperties"/> con la información de la sección <see cref="KnownEdidSection.BasicDisplay"/>.
                                /// </summary>
                                /// <param name="dataSection">Información de la sección.</param>
                                internal SyncrhonizationProperties(DataSection dataSection)
                                {
                                    _dataSection = dataSection;
                                }
                                #endregion

                            #endregion

                            #region Propiedades

                                #region [public] (DeviceProperty<Boolean>) SeparateSyncSupported: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                                /// <summary>
                                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                                /// 	<para>— Información de la propiedad</para>
                                /// 	<para>Description: Profundidad de color de este escritorio.</para>
                                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Analog.Syncrhonization.SeparateSyncSupported"/></para>
                                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// 	<para>Value: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                /// <value>
                                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                                /// </value>
                                public DeviceProperty<Boolean> SeparateSyncSupported
                                {
                                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Analog.Syncrhonization.SeparateSyncSupported) as DeviceProperty<Boolean>; }
                                }
                                #endregion

                                #region [public] (DeviceProperty<Boolean>) CompositeSyncSignalHorizontalSupported: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                                /// <summary>
                                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                                /// 	<para>— Información de la propiedad</para>
                                /// 	<para>Description: Profundidad de color de este escritorio.</para>
                                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Analog.Syncrhonization.CompositeSyncSignalHorizontalSupported"/></para>
                                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// 	<para>Value: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                /// <value>
                                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                                /// </value>
                                public DeviceProperty<Boolean> CompositeSyncSignalHorizontalSupported
                                {
                                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Analog.Syncrhonization.CompositeSyncSignalHorizontalSupported) as DeviceProperty<Boolean>; }
                                }
                                #endregion

                                #region [public] (DeviceProperty<Boolean>) CompositeSyncSignalGreenVideoSupported: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                                /// <summary>
                                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                                /// 	<para>— Información de la propiedad</para>
                                /// 	<para>Description: Profundidad de color de este escritorio.</para>
                                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Analog.Syncrhonization.CompositeSyncSignalGreenVideoSupported"/></para>
                                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// 	<para>Value: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                /// <value>
                                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                                /// </value>
                                public DeviceProperty<Boolean> CompositeSyncSignalGreenVideoSupported
                                {
                                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Analog.Syncrhonization.CompositeSyncSignalGreenVideoSupported) as DeviceProperty<Boolean>; }
                                }
                                #endregion

                            #endregion

                            #region Overrides

                                #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                                /// <summary>
                                /// Devuelve una cadena que representa la clase <see cref="SyncrhonizationProperties"/> actual.
                                /// </summary>
                                /// <returns>
                                /// 	<para>Tipo: <see cref="T:System.String"/></para>
                                /// 	<para>Cadena que representa la clase <see cref="SyncrhonizationProperties"/> actual.</para>
                                /// </returns>
                                /// <remarks>
                                /// Este método devuelve una cadena que contiene el nombre de la sección.
                                /// </remarks>
                                public override string ToString()
                                {
                                    return string.Format(CultureInfo.InvariantCulture, "Section = Syncrhonization");
                                }

                                #endregion

                            #endregion
                        }
                        #endregion

                    #endregion


                    #region Declaraciones
                    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                    private readonly DataSection _dataSection;

                    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                    private SyncrhonizationProperties _syncrhonization;
                    #endregion

                    #region Constructor/es

                        #region [internal] AnalogProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'BasicDisplay'.
                        /// <summary>
                        /// Inicializa una nueva instancia de la <see cref="AnalogProperties"/> con la información de la sección <see cref="KnownEdidSection.BasicDisplay"/>.
                        /// </summary>
                        /// <param name="dataSection">Información de la sección.</param>
                        internal AnalogProperties(DataSection dataSection)
                        {
                            _dataSection = dataSection;
                        }
                        #endregion

                    #endregion

                    #region Propiedades

                        #region [public] (DeviceProperty<String>) SignalLevelStandard: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                        /// 	<para>— Información de la propiedad</para>
                        /// 	<para>Description: Profundidad de color de este escritorio.</para>
                        /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Analog.SignalLevelStandard"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>Value: <see cref="T:System.String"/></para>
                        /// </summary>
                        /// <value>
                        /// Objeto fuertemente tipado que representa el valor de la propiedad.
                        /// </value>
                        public DeviceProperty<String> SignalLevelStandard
                        {
                            get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Analog.SignalLevelStandard) as DeviceProperty<String>; }
                        }
                        #endregion

                        #region [public] (DeviceProperty<String>) VideoSetup: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                        /// 	<para>— Información de la propiedad</para>
                        /// 	<para>Description: Profundidad de color de este escritorio.</para>
                        /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Analog.VideoSetup"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>Value: <see cref="T:System.String"/></para>
                        /// </summary>
                        /// <value>
                        /// Objeto fuertemente tipado que representa el valor de la propiedad.
                        /// </value>
                        public DeviceProperty<String> VideoSetup
                        {
                            get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Analog.VideoSetup) as DeviceProperty<String>; }
                        }
                        #endregion

                        #region [public] (DeviceProperty<Boolean>) VerticalSyncSupported: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                        /// 	<para>— Información de la propiedad</para>
                        /// 	<para>Description: Profundidad de color de este escritorio.</para>
                        /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Analog.VerticalSyncSupported"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>Value: <see cref="T:System.Boolean"/></para>
                        /// </summary>
                        /// <value>
                        /// Objeto fuertemente tipado que representa el valor de la propiedad.
                        /// </value>
                        public DeviceProperty<Boolean> VerticalSyncSupported
                        {
                            get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Analog.VerticalSyncSupported) as DeviceProperty<Boolean>; }
                        }
                        #endregion

                        #region [public] (DeviceProperty<String>) DisplayColorType: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                        /// 	<para>— Información de la propiedad</para>
                        /// 	<para>Description: Profundidad de color de este escritorio.</para>
                        /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Analog.DisplayColorType"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>Value: <see cref="T:System.Boolean"/></para>
                        /// </summary>
                        /// <value>
                        /// Objeto fuertemente tipado que representa el valor de la propiedad.
                        /// </value>
                        public DeviceProperty<String> DisplayColorType
                        {
                            get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Analog.DisplayColorType) as DeviceProperty<String>; }
                        }
                        #endregion

                        #region [public] (SyncrhonizationProperties) Syncrhonization: Obtiene una referencia al conjunto de propiedades de la característica 'Syncrhonization' de la sección 'Analog'.
                        /// <summary>
                        /// Obtiene una referencia al conjunto de propiedades de la característica 'Syncrhonization' de la característica 'Analog'.
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="SyncrhonizationProperties"/></para>
                        /// 	<para>Propiedades de la característica 'Syncrhonization'.</para>
                        /// </value>
                        public SyncrhonizationProperties Syncrhonization
                        {
                            get
                            {
                                if (_syncrhonization == null)
                                    _syncrhonization = new SyncrhonizationProperties(_dataSection);
                                return _syncrhonization;
                            }
                        }
                        #endregion

                    #endregion

                    #region Overrides

                        #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                        /// <summary>
                        /// Devuelve una cadena que representa la clase <see cref="AnalogProperties"/> actual.
                        /// </summary>
                        /// <returns>
                        /// 	<para>Tipo: <see cref="T:System.String"/></para>
                        /// 	<para>Cadena que representa la clase <see cref="AnalogProperties"/> actual.</para>
                        /// </returns>
                        /// <remarks>
                        /// Este método devuelve una cadena que contiene el nombre de la sección.
                        /// </remarks>
                        public override string ToString()
                        {
                            return string.Format(CultureInfo.InvariantCulture, "Section = Analog");
                        }
                        #endregion

                    #endregion
                }
                #endregion

                #region [public] {sealed} (class) DigitalProperties: Conjunto de propiedades disponibles para la característica 'Digital'.
                /// <summary>
                /// Conjunto de propiedades disponibles para la característica 'Digital'.
                /// </summary>
                [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
                public sealed class DigitalProperties
                {
                    #region Declaraciones.
                    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                    private readonly DataSection _dataSection;
                    #endregion

                    #region Constructor/es.

                        #region [internal] DigitalProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'BasicDisplay'.
                        /// <summary>
                        /// Inicializa una nueva instancia de la <see cref="DigitalProperties"/> con la información de la sección <see cref="KnownEdidSection.BasicDisplay"/>.
                        /// </summary>
                        /// <param name="dataSection">Información de la sección.</param>
                        internal DigitalProperties(DataSection dataSection)
                        {
                            _dataSection = dataSection;
                        }
                        #endregion

                    #endregion

                    #region Propiedades.

                        #region [public] (DeviceProperty<String>) ColorBitDepth: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                        /// 	<para>— Información de la propiedad</para>
                        /// 	<para>Description: Profundidad de color de este escritorio.</para>
                        /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Digital.ColorBitDepth"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>Value: <see cref="T:System.String"/></para>
                        /// 	<para>Si está característica no se encuentra disponible se devuelve <b>null</b></para>
                        /// </summary>
                        /// <value>
                        /// Objeto fuertemente tipado que representa el valor de la propiedad.
                        /// </value>
                        public DeviceProperty<String> ColorBitDepth
                        {
                            get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Digital.ColorBitDepth) as DeviceProperty<String>; }
                        }
                        #endregion

                        #region [public] (DeviceProperty<String>) VideoInterface: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                        /// 	<para>— Información de la propiedad</para>
                        /// 	<para>Description: Profundidad de color de este escritorio.</para>
                        /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Digital.VideoInterface"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>Value: <see cref="T:System.String"/></para>
                        /// 	<para>Si está característica no se encuentra disponible se devuelve <b>null</b></para>
                        /// </summary>
                        /// <value>
                        /// Objeto fuertemente tipado que representa el valor de la propiedad.
                        /// </value>
                        public DeviceProperty<String> VideoInterface
                        {
                            get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Digital.VideoInterface) as DeviceProperty<String>; }
                        }
                        #endregion

                        #region [public] (DeviceProperty<String>) ColorEncodingFormat: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                        /// <summary>
                        /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                        /// 	<para>— Información de la propiedad</para>
                        /// 	<para>Description: Profundidad de color de este escritorio.</para>
                        /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Digital.ColorEncodingFormat"/></para>
                        /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                        /// 	<para>Value: <see cref="T:System.String"/></para>
                        /// 	<para>Si está característica no se encuentra disponible se devuelve <b>null</b></para>
                        /// </summary>
                        /// <value>
                        /// Objeto fuertemente tipado que representa el valor de la propiedad.
                        /// </value>
                        public DeviceProperty<String> ColorEncodingFormat
                        {
                            get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Digital.ColorEncodingFormat) as DeviceProperty<String>; }
                        }
                        #endregion

                    #endregion

                    #region Overrides.

                        #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                        /// <summary>
                        /// Devuelve una cadena que representa la clase <see cref="DigitalProperties"/> actual.
                        /// </summary>
                        /// <returns>
                        /// 	<para>Tipo: <see cref="T:System.String"/></para>
                        /// 	<para>Cadena que representa la clase <see cref="DigitalProperties"/> actual.</para>
                        /// </returns>
                        /// <remarks>
                        /// Este método devuelve una cadena que contiene el nombre de la sección.
                        /// </remarks>
                        public override string ToString()
                        {
                            return string.Format(CultureInfo.InvariantCulture, "Section = Digital");
                        }

                        #endregion

                    #endregion
                }
                #endregion

                #region [public] {sealed} (class) FeaturesProperties: Conjunto de propiedades disponibles para la característica 'Features'.
                /// <summary>
                /// Conjunto de propiedades disponibles para la característica 'Features'.
                /// </summary>
                [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
                public sealed class FeaturesProperties
                {
                    #region Clases anidadas.

                        #region [public] {sealed} (class) OtherFeaturesProperties: Conjunto de propiedades disponibles para la característica 'OtherFeatures'.
                        /// <summary>
                        /// Conjunto de propiedades disponibles para la característica 'OtherFeatures'.
                        /// </summary>
                        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
                        public sealed class OtherFeaturesProperties
                        {
                            #region Declaraciones.
                            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                            private readonly DataSection _dataSection;
                            #endregion

                            #region Constructor/es.

                                #region [internal] OtherFeaturesProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'BasicDisplay'.
                                /// <summary>
                                /// Inicializa una nueva instancia de la <see cref="OtherFeaturesProperties"/> con la información de la sección <see cref="KnownEdidSection.BasicDisplay"/>.
                                /// </summary>
                                /// <param name="dataSection">Información de la sección.</param>
                                internal OtherFeaturesProperties(DataSection dataSection)
                                {
                                    _dataSection = dataSection;
                                }
                                #endregion

                            #endregion

                            #region Propiedades.

                                #region [public] (DeviceProperty<Boolean>) SRGBDefaultColorSpace: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                                /// <summary>
                                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                                /// 	<para>— Información de la propiedad</para>
                                /// 	<para>Description: Profundidad de color de este escritorio.</para>
                                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Features.Other.IsSrgbDefaultColorSpace"/></para>
                                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// 	<para>Value: <see cref="T:System.Boolean"/></para>
                                /// 	<para>Si está característica no se encuentra disponible se devuelve <b>null</b></para>
                                /// </summary>
                                /// <value>
                                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                                /// </value>
                                [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SRGB")]
                                public DeviceProperty<Boolean> SRGBDefaultColorSpace
                                {
                                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Features.Other.IsSrgbDefaultColorSpace) as DeviceProperty<Boolean>; }
                                }
                                #endregion

                                #region [public] (DeviceProperty<Boolean>) IncludePreferredTimingMode: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                                /// <summary>
                                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                                /// 	<para>— Información de la propiedad</para>
                                /// 	<para>Description: Profundidad de color de este escritorio.</para>
                                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Features.Other.IncludePreferredTimingMode"/></para>
                                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// 	<para>Value: <see cref="T:System.Boolean"/></para>
                                /// 	<para>Si está característica no se encuentra disponible se devuelve <b>null</b></para>
                                /// </summary>
                                /// <value>
                                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                                /// </value>
                                public DeviceProperty<Boolean> IncludePreferredTimingMode
                                {
                                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Features.Other.IncludePreferredTimingMode) as DeviceProperty<Boolean>; }
                                }
                                #endregion

                                #region [public] (DeviceProperty<Boolean>) ContinuousFrequency: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                                /// <summary>
                                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                                /// 	<para>— Información de la propiedad</para>
                                /// 	<para>Description: Profundidad de color de este escritorio.</para>
                                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Features.Other.IsContinuousFrequency"/></para>
                                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// 	<para>Value: <see cref="T:System.Boolean"/></para>
                                /// 	<para>Si está característica no se encuentra disponible se devuelve <b>null</b></para>
                                /// </summary>
                                /// <value>
                                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                                /// </value>
                                public DeviceProperty<Boolean> ContinuousFrequency
                                {
                                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Features.Other.IsContinuousFrequency) as DeviceProperty<Boolean>; }
                                }
                                #endregion

                            #endregion

                            #region Overrides.

                                #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                                /// <summary>
                                /// Devuelve una cadena que representa la clase <see cref="OtherFeaturesProperties"/> actual.
                                /// </summary>
                                /// <returns>
                                /// 	<para>Tipo: <see cref="T:System.String"/></para>
                                /// 	<para>Cadena que representa la clase <see cref="OtherFeaturesProperties"/> actual.</para>
                                /// </returns>
                                /// <remarks>
                                /// Este método devuelve una cadena que contiene el nombre de la sección.
                                /// </remarks>
                                public override string ToString()
                                {
                                    return string.Format(CultureInfo.InvariantCulture, "Section = OtherFeatures");
                                }
                                #endregion

                            #endregion
                        }
                        #endregion

                        #region [public] {sealed} (class) PowerManagementDisplayProperties: Conjunto de propiedades disponibles para la característica 'DisplayPowerManager'.
                        /// <summary>
                        /// Conjunto de propiedades disponibles para la característica 'DisplayPowerManager'.
                        /// </summary>
                        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
                        public sealed class PowerManagementDisplayProperties
                        {
                            #region Declaraciones.
                            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                            private readonly DataSection _dataSection;
                            #endregion

                            #region Constructor/es.

                                #region [internal] PowerManagementDisplayProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'BasicDisplay'.
                                /// <summary>
                                /// Inicializa una nueva instancia de la <see cref="PowerManagementDisplayProperties"/> con la información de la sección <see cref="KnownEdidSection.BasicDisplay"/>.
                                /// </summary>
                                /// <param name="dataSection">Información de la sección.</param>
                                internal PowerManagementDisplayProperties(DataSection dataSection)
                                {
                                    _dataSection = dataSection;
                                }
                                #endregion

                            #endregion

                            #region Propiedades.

                                #region [public] (DeviceProperty<Boolean>) StandbyModeSupported: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                                /// <summary>
                                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                                /// 	<para>— Información de la propiedad</para>
                                /// 	<para>Description: Profundidad de color de este escritorio.</para>
                                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Features.DisplayPowerManagement.StandbyModeSupported"/></para>
                                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// 	<para>Value: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                /// <value>
                                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                                /// </value>
                                public DeviceProperty<Boolean> StandbyModeSupported
                                {
                                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Features.DisplayPowerManagement.StandbyModeSupported) as DeviceProperty<Boolean>; }
                                }
                                #endregion

                                #region [public] (DeviceProperty<Boolean>) SuspendModeSupported: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                                /// <summary>
                                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                                /// 	<para>— Información de la propiedad</para>
                                /// 	<para>Description: Profundidad de color de este escritorio.</para>
                                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Features.DisplayPowerManagement.SuspendModeSupported"/></para>
                                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// 	<para>Value: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                /// <value>
                                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                                /// </value>
                                public DeviceProperty<Boolean> SuspendModeSupported
                                {
                                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Features.DisplayPowerManagement.SuspendModeSupported) as DeviceProperty<Boolean>; }
                                }
                                #endregion

                                #region [public] (DeviceProperty<Boolean>) ActiveOffSupported: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                                /// <summary>
                                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                                /// 	<para>— Información de la propiedad</para>
                                /// 	<para>Description: Profundidad de color de este escritorio.</para>
                                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Features.DisplayPowerManagement.ActiveOffSupported"/></para>
                                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                                /// 	<para>Value: <see cref="T:System.Boolean"/></para>
                                /// </summary>
                                /// <value>
                                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                                /// </value>
                                public DeviceProperty<Boolean> ActiveOffSupported
                                {
                                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Features.DisplayPowerManagement.ActiveOffSupported) as DeviceProperty<Boolean>; }
                                }
                                #endregion

                            #endregion

                            #region Overrides.

                                #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                                /// <summary>
                                /// Devuelve una cadena que representa la clase <see cref="PowerManagementDisplayProperties"/> actual.
                                /// </summary>
                                /// <returns>
                                /// 	<para>Tipo: <see cref="T:System.String"/></para>
                                /// 	<para>Cadena que representa la clase <see cref="PowerManagementDisplayProperties"/> actual.</para>
                                /// </returns>
                                /// <remarks>
                                /// Este método devuelve una cadena que contiene el nombre de la sección.
                                /// </remarks>
                                public override string ToString()
                                {
                                    return string.Format(CultureInfo.InvariantCulture, "Section = DisplayPowerManagement");
                                }
                                #endregion

                            #endregion
                        }
                        #endregion

                    #endregion


                    #region Declaraciones.
                    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                    private readonly DataSection _dataSection;

                    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                    private OtherFeaturesProperties _otherfeatures;

                    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                    private PowerManagementDisplayProperties _displayPowerManager;
                    #endregion

                    #region Constructor/es.

                        #region [internal] FeaturesProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'BasicDisplay'.
                        /// <summary>
                        /// Inicializa una nueva instancia de la <see cref="FeaturesProperties"/> con la información de la sección <see cref="KnownEdidSection.BasicDisplay"/>.
                        /// </summary>
                        /// <param name="dataSection">Información de la sección.</param>
                        internal FeaturesProperties(DataSection dataSection)
                        {
                            _dataSection = dataSection;
                        }
                        #endregion

                    #endregion

                    #region Propiedades.

                        #region [public] (PowerManagementDisplayProperties) DisplayPowerManager: Obtiene una referencia al conjunto de propiedades de la característica 'DisplayPowerManager' de la característica 'Features'.
                        /// <summary>
                        /// Obtiene una referencia al conjunto de propiedades de la característica 'DisplayPowerManager' de la característica 'Features'.
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="PowerManagementDisplayProperties"/></para>
                        /// 	<para>Propiedades de la característica 'DisplayPowerManager.</para>
                        /// </value>
                        public PowerManagementDisplayProperties DisplayPowerManager
                        {
                            get
                            {
                                if (_displayPowerManager == null)
                                    _displayPowerManager = new PowerManagementDisplayProperties(_dataSection);
                                return _displayPowerManager;
                            }
                        }
                        #endregion

                        #region [public] (OtherFeaturesProperties) Features: Obtiene una referencia al conjunto de propiedades de la característica 'OtherFeatures' de la característica 'Features'.
                        /// <summary>
                        /// Obtiene una referencia al conjunto de propiedades de la característica 'OtherFeatures' de la característica 'Features'.
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="OtherFeaturesProperties"/></para>
                        /// 	<para>Propiedades de la característica 'OtherFeatures'.</para>
                        /// </value>
                        public OtherFeaturesProperties Other
                        {
                            get
                            {
                                if (_otherfeatures == null)
                                    _otherfeatures = new OtherFeaturesProperties(_dataSection);
                                return _otherfeatures;
                            }
                        }
                        #endregion

                    #endregion

                    #region Overrides.

                        #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                        /// <summary>
                        /// Devuelve una cadena que representa la clase <see cref="FeaturesProperties"/> actual.
                        /// </summary>
                        /// <returns>
                        /// 	<para>Tipo: <see cref="T:System.String"/></para>
                        /// 	<para>Cadena que representa la clase <see cref="FeaturesProperties"/> actual.</para>
                        /// </returns>
                        /// <remarks>
                        /// Este método devuelve una cadena que contiene el nombre de la sección.
                        /// </remarks>
                        public override string ToString()
                        {
                            return string.Format(CultureInfo.InvariantCulture, "Section = Features");
                        }

                        #endregion

                    #endregion
                }
                #endregion

            #endregion


            #region Declaraciones
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private readonly DataSection _dataSection;

            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private FeaturesProperties _features;

            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private AnalogProperties _analog;

            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private DigitalProperties _digital;
            #endregion

            #region Constructor/es

                #region [internal] BasicDisplayProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'BasicDisplay'.
                /// <summary>
                /// Inicializa una nueva instancia de la <see cref="BasicDisplayProperties"/> con la información de la sección <see cref="KnownEdidSection.BasicDisplay"/>.
                /// </summary>
                /// <param name="dataSection">Información de la sección.</param>
                internal BasicDisplayProperties(DataSection dataSection)
                {
                    _dataSection = dataSection;
                }
                #endregion

            #endregion

            #region Propiedades

                #region [public] (DeviceProperty<String>) VideoInputDefinition: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Profundidad de color de este escritorio.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.VideoInputDefinition"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="T:System.String"/></para>
                /// 	<para>Si está característica no se encuentra disponible se devuelve <b>null</b></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                public DeviceProperty<String> VideoInputDefinition
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.VideoInputDefinition) as DeviceProperty<String>; }
                }
                #endregion

                #region [public] (DeviceProperty<Byte>) HorizontalScreenSize: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Profundidad de color de este escritorio.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.HorizontalScreenSize"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.cm"/></para>
                /// 	<para>Value: <see cref="T:System.Byte"/></para>
                /// 	<para>Si está característica no se encuentra disponible se devuelve <b>null</b></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                public DeviceProperty<Byte> HorizontalScreenSize
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.HorizontalScreenSize) as DeviceProperty<Byte>; }
                }
                #endregion

                #region [public] (DeviceProperty<Byte>) VerticalScreenSize: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Profundidad de color de este escritorio.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.VerticalScreenSize"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.cm"/></para>
                /// 	<para>Value: <see cref="T:System.Byte"/></para>
                /// 	<para>Si está característica no se encuentra disponible se devuelve <b>null</b></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                public DeviceProperty<Byte> VerticalScreenSize
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.VerticalScreenSize) as DeviceProperty<Byte>; }
                }
                #endregion

                #region [public] (DeviceProperty<Double>) Gamma: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Profundidad de color de este escritorio.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.BasicDisplay.Gamma"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.cm"/></para>
                /// 	<para>Value: <see cref="T:System.Double"/>?</para>
                /// 	<para>Si está característica no se encuentra disponible se devuelve <b>null</b></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
                public DeviceProperty<Double?> Gamma
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.BasicDisplay.Gamma) as DeviceProperty<Double?>; }
                }
                #endregion

                #region [public] (AnalogProperties) Analog: Obtiene una referencia al conjunto de propiedades de la característica 'Analog' de la sección 'BasicDisplay'.
                /// <summary>
                /// Obtiene una referencia al conjunto de propiedades de la característica 'Analog' de la sección <see cref="KnownEdidSection.BasicDisplay"/>.
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="AnalogProperties"/></para>
                /// 	<para>Propiedades de la característica 'Analog'.</para>
                /// </value>
                public AnalogProperties Analog
                {
                    get
                    {
                        if (_analog == null)
                        {
                            string videoInputDefinition = VideoInputDefinition.Value;
                            if (videoInputDefinition == "Analog")
                                _analog = new AnalogProperties(_dataSection);
                        }
                        return _analog;
                    }
                }
                #endregion

                #region [public] (DigitalProperties) Digital: Obtiene una referencia al conjunto de propiedades de la característica 'Digital' de la sección 'BasicDisplay'.
                /// <summary>
                /// Obtiene una referencia al conjunto de propiedades de la característica 'Digital' de la sección <see cref="KnownEdidSection.BasicDisplay"/>.
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="DigitalProperties"/></para>
                /// 	<para>Propiedades de la característica 'Digital'.</para>
                /// </value>
                public DigitalProperties Digital
                {
                    get
                    {
                        if (_digital == null)
                        {
                            string videoInputDefinition = VideoInputDefinition.Value;
                            if (videoInputDefinition == "Digital")
                                _digital = new DigitalProperties(_dataSection);
                        }
                        return _digital;
                    }
                }
                #endregion

                #region [public] (FeaturesProperties) Features: Obtiene una referencia al conjunto de propiedades de la característica 'Features' de la sección 'BasicDisplay'.
                /// <summary>
                /// Obtiene una referencia al conjunto de propiedades de la característica 'Features' de la sección <see cref="KnownEdidSection.BasicDisplay"/>.
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="FeaturesProperties"/></para>
                /// 	<para>Propiedades de la característica 'Features'.</para>
                /// </value>
                public FeaturesProperties Features
                {
                    get
                    {
                        if (_features == null)
                            _features = new FeaturesProperties(_dataSection);
                        return _features;
                    }
                }
                #endregion

            #endregion

            #region Overrides

                #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                /// <summary>
                /// Devuelve una cadena que representa la clase <see cref="BasicDisplayProperties"/> actual.
                /// </summary>
                /// <returns>
                /// 	<para>Tipo: <see cref="T:System.String"/></para>
                /// 	<para>Cadena que representa la clase <see cref="BasicDisplayProperties"/> actual.</para>
                /// </returns>
                /// <remarks>
                /// Este método devuelve una cadena que contiene el nombre de la sección.
                /// </remarks>
                public override string ToString()
                {
                    return string.Format(CultureInfo.InvariantCulture, "Section = {0}", KnownEdidSection.BasicDisplay);
                }
                #endregion

            #endregion
        }
        #endregion

        #region [public] {sealed} (class) ColorCharacteristicsProperties: Conjunto de propiedades disponibles para la sección 'ColorCharacteristics'.
        /// <summary>
        /// Conjunto de propiedades disponibles para la sección <see cref="KnownEdidSection.ColorCharacteristics"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public sealed class ColorCharacteristicsProperties
        {
            #region Declaraciones
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private readonly DataSection _dataSection;
            #endregion

            #region Constructor/es

                #region [internal] ColorCharacteristicsProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'ColorCharacteristics'.
                /// <summary>
                /// Inicializa una nueva instancia de la <see cref="ColorCharacteristicsProperties"/> con la información de la sección <see cref="KnownEdidSection.ColorCharacteristics"/>.
                /// </summary>
                /// <param name="dataSection">Información de la sección.</param>
                internal ColorCharacteristicsProperties(DataSection dataSection)
                {
                    _dataSection = dataSection;
                }
                #endregion

            #endregion

            #region Propiedades

                #region [public] (DeviceProperty<PointF>) Red: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Número de versión de la especificación implementada en este monitor.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.ColorCharacteristics.Red"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="T:System.Drawing.PointF"/></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                public DeviceProperty<PointF> Red
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.ColorCharacteristics.Red) as DeviceProperty<PointF>; }
                }
                #endregion

                #region [public] (DeviceProperty<PointF>) Green: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Número de versión de la especificación implementada en este monitor.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.ColorCharacteristics.Green"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="T:System.Drawing.PointF"/></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                public DeviceProperty<PointF> Green
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.ColorCharacteristics.Green) as DeviceProperty<PointF>; }
                }
                #endregion

                #region [public] (DeviceProperty<PointF>) Blue: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Número de versión de la especificación implementada en este monitor.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.ColorCharacteristics.Blue"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="T:System.Drawing.PointF"/></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                public DeviceProperty<PointF> Blue
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.ColorCharacteristics.Blue) as DeviceProperty<PointF>; }
                }
                #endregion

                #region [public] (DeviceProperty<PointF>) White: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Número de versión de la especificación implementada en este monitor.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.ColorCharacteristics.White"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="T:System.Drawing.PointF"/></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                public DeviceProperty<PointF> White
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.ColorCharacteristics.White) as DeviceProperty<PointF>; }
                }
                #endregion

            #endregion

            #region Overrides

                #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                /// <summary>
                /// Devuelve una cadena que representa la clase <see cref="ColorCharacteristicsProperties"/> actual.
                /// </summary>
                /// <returns>
                /// 	<para>Tipo: <see cref="T:System.String"/></para>
                /// 	<para>Cadena que representa la clase <see cref="ColorCharacteristicsProperties"/> actual.</para>
                /// </returns>
                /// <remarks>
                /// Este método devuelve una cadena que contiene el nombre de la sección.
                /// </remarks>
                public override string ToString()
                {
                    return string.Format(CultureInfo.InvariantCulture, "Section = {0}", KnownEdidSection.ColorCharacteristics);
                }
                #endregion

            #endregion
        }
        #endregion

        #region [public] {sealed} (class) EstablishedTimingsProperties: Conjunto de propiedades disponibles para la sección 'EstablishedTimings'.
        /// <summary>
        /// Conjunto de propiedades disponibles para la sección <see cref="KnownEdidSection.EstablishedTimings"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public sealed class EstablishedTimingsProperties
        {
            #region Declaraciones
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private readonly DataSection _dataSection;
            #endregion

            #region Constructor/es

                #region [internal] EstablishedTimingsProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'EstablishedTimings'.
                /// <summary>
                /// Inicializa una nueva instancia de la <see cref="EstablishedTimingsProperties"/> con la información de la sección <see cref="KnownEdidSection.EstablishedTimings"/>.
                /// </summary>
                /// <param name="dataSection">Información de la sección.</param>
                internal EstablishedTimingsProperties(DataSection dataSection)
                {
                    _dataSection = dataSection;
                }
                #endregion

            #endregion

            #region Propiedades

                #region [public] (DeviceProperty<ReadOnlyCollection<MonitorResolutionInfo>>) Resolutions: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Colección de modos preestablecidos en este monitor.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.EstablishedTimings.Resolutions"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="ReadOnlyCollection{MonitorResolutionInfo}"/></para>
                /// 	<para>Si esta característica no se encuentra disponible se devuelve <b>null</b></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
                public DeviceProperty<ReadOnlyCollection<MonitorResolutionInfo>> Resolutions
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.EstablishedTimings.Resolutions) as DeviceProperty<ReadOnlyCollection<MonitorResolutionInfo>>; }
                }
                #endregion

            #endregion

            #region Overrides

                #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                /// <summary>
                /// Devuelve una cadena que representa la clase <see cref="EstablishedTimingsProperties"/> actual.
                /// </summary>
                /// <returns>
                /// 	<para>Tipo: <see cref="T:System.String"/></para>
                /// 	<para>Cadena que representa la clase <see cref="EstablishedTimingsProperties"/> actual.</para>
                /// </returns>
                /// <remarks>
                /// Este método devuelve una cadena que contiene el nombre de la sección.
                /// </remarks>
                public override string ToString()
                {
                    return string.Format(CultureInfo.InvariantCulture, "Section = {0}", KnownEdidSection.EstablishedTimings);
                }
                #endregion

            #endregion
        }
        #endregion

        #region [public] {sealed} (class) StandardTimingsProperties: Conjunto de propiedades disponibles para la sección 'StandardTimings'.
        /// <summary>
        /// Conjunto de propiedades disponibles para la sección <see cref="KnownEdidSection.StandardTimings"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public sealed class StandardTimingsProperties
        {
            #region private readonly members
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private readonly DataSection _dataSection;
            #endregion

            #region constructor/s

            #region [internal] StandardTimingsProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'StandardTimings'.
            /// <summary>
            /// Inicializa una nueva instancia de la <see cref="StandardTimingsProperties"/> con la información de la sección <see cref="KnownEdidSection.StandardTimings"/>.
            /// </summary>
            /// <param name="dataSection">Información de la sección.</param>
            internal StandardTimingsProperties(DataSection dataSection)
            {
                _dataSection = dataSection;
            }
            #endregion

            #endregion

            #region public properties

            #region [public] (DeviceProperty<StandardTimingIdentifierDescriptorItem>) Timing1: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
            /// <summary>
            /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
            /// 	<para>— Información de la propiedad</para>
            /// 	<para>Description: Profundidad de color de este escritorio.</para>
            /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing1"/></para>
            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
            /// 	<para>Value: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
            /// </summary>
            /// <value>
            /// Objeto fuertemente tipado que representa el valor de la propiedad.
            /// </value>
            public DeviceProperty<StandardTimingIdentifierDescriptorItem> Timing1 => _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing1) as DeviceProperty<StandardTimingIdentifierDescriptorItem>;
            #endregion

            #region [public] (DeviceProperty<StandardTimingIdentifierDescriptorItem>) Timing2: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
            /// <summary>
            /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
            /// 	<para>— Información de la propiedad</para>
            /// 	<para>Description: Profundidad de color de este escritorio.</para>
            /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing2"/></para>
            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
            /// 	<para>Value: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
            /// </summary>
            /// <value>
            /// Objeto fuertemente tipado que representa el valor de la propiedad.
            /// </value>
            public DeviceProperty<StandardTimingIdentifierDescriptorItem> Timing2 => _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing2) as DeviceProperty<StandardTimingIdentifierDescriptorItem>;
            #endregion

            #region [public] (DeviceProperty<StandardTimingIdentifierDescriptorItem>) Timing3: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
            /// <summary>
            /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
            /// 	<para>— Información de la propiedad</para>
            /// 	<para>Description: Profundidad de color de este escritorio.</para>
            /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing3"/></para>
            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
            /// 	<para>Value: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
            /// </summary>
            /// <value>
            /// Objeto fuertemente tipado que representa el valor de la propiedad.
            /// </value>
            public DeviceProperty<StandardTimingIdentifierDescriptorItem> Timing3 => _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing3) as DeviceProperty<StandardTimingIdentifierDescriptorItem>;
            #endregion

            #region [public] (DeviceProperty<StandardTimingIdentifierDescriptorItem>) Timing4: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
            /// <summary>
            /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
            /// 	<para>— Información de la propiedad</para>
            /// 	<para>Description: Profundidad de color de este escritorio.</para>
            /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing4"/></para>
            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
            /// 	<para>Value: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
            /// </summary>
            /// <value>
            /// Objeto fuertemente tipado que representa el valor de la propiedad.
            /// </value>
            public DeviceProperty<StandardTimingIdentifierDescriptorItem> Timing4 => _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing4) as DeviceProperty<StandardTimingIdentifierDescriptorItem>;
            #endregion

            #region [public] (DeviceProperty<StandardTimingIdentifierDescriptorItem>) Timing5: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
            /// <summary>
            /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
            /// 	<para>— Información de la propiedad</para>
            /// 	<para>Description: Profundidad de color de este escritorio.</para>
            /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing5"/></para>
            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
            /// 	<para>Value: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
            /// </summary>
            /// <value>
            /// Objeto fuertemente tipado que representa el valor de la propiedad.
            /// </value>
            public DeviceProperty<StandardTimingIdentifierDescriptorItem> Timing5 => _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing5) as DeviceProperty<StandardTimingIdentifierDescriptorItem>;
            #endregion

            #region [public] (DeviceProperty<StandardTimingIdentifierDescriptorItem>) Timing6: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
            /// <summary>
            /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
            /// 	<para>— Información de la propiedad</para>
            /// 	<para>Description: Profundidad de color de este escritorio.</para>
            /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing6"/></para>
            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
            /// 	<para>Value: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
            /// </summary>
            /// <value>
            /// Objeto fuertemente tipado que representa el valor de la propiedad.
            /// </value>
            public DeviceProperty<StandardTimingIdentifierDescriptorItem> Timing6 => _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing6) as DeviceProperty<StandardTimingIdentifierDescriptorItem>;
            #endregion

            #region [public] (DeviceProperty<StandardTimingIdentifierDescriptorItem>) Timing7: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
            /// <summary>
            /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
            /// 	<para>— Información de la propiedad</para>
            /// 	<para>Description: Profundidad de color de este escritorio.</para>
            /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing7"/></para>
            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
            /// 	<para>Value: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
            /// </summary>
            /// <value>
            /// Objeto fuertemente tipado que representa el valor de la propiedad.
            /// </value>
            public DeviceProperty<StandardTimingIdentifierDescriptorItem> Timing7 => _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing7) as DeviceProperty<StandardTimingIdentifierDescriptorItem>;
            #endregion

            #region [public] (DeviceProperty<StandardTimingIdentifierDescriptorItem>) Timing8: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
            /// <summary>
            /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
            /// 	<para>— Información de la propiedad</para>
            /// 	<para>Description: Profundidad de color de este escritorio.</para>
            /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing8"/></para>
            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
            /// 	<para>Value: <see cref="StandardTimingIdentifierDescriptorItem"/></para>
            /// </summary>
            /// <value>
            /// Objeto fuertemente tipado que representa el valor de la propiedad.
            /// </value>
            public DeviceProperty<StandardTimingIdentifierDescriptorItem> Timing8 => _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.StandardTimings.Timing8) as DeviceProperty<StandardTimingIdentifierDescriptorItem>;
            #endregion

            #endregion

            #region public override methods

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
            /// <summary>
            /// Devuelve una cadena que representa la clase <see cref="StandardTimingsProperties"/> actual.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.String"/></para>
            /// 	<para>Cadena que representa la clase <see cref="StandardTimingsProperties"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// Este método devuelve una cadena que contiene el nombre de la sección.
            /// </remarks>
            public override string ToString()
                {
                    return string.Format(CultureInfo.InvariantCulture, "Section = {0}", KnownEdidSection.StandardTimings);
                }
                #endregion

            #endregion
        }
        #endregion

        #region [public] {sealed} (class) DataBlocksProperties: Conjunto de propiedades disponibles para la sección 'DataBlocks'.
        /// <summary>
        /// Conjunto de propiedades disponibles para la sección <see cref="KnownEdidSection.DataBlocks"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public sealed class DataBlocksProperties
        {
            #region Clases anidadas

                #region [public] {sealed} (class) DescriptorProperties: Conjunto de propiedades disponibles para un descriptor.
                /// <summary>
                /// Conjunto de propiedades disponibles para un descriptor.
                /// </summary>
                [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
                public sealed class DescriptorProperties
                {
                    #region Declaraciones
                    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                    private Hashtable _items;

                    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                    private readonly IDeviceProperty _descriptorDevice;
                    #endregion

                    #region Constructor/es

                        #region [internal] DescriptorProperties(IDeviceProperty): Inicializa una nueva instancia de la clase con la información del bloque.
                        /// <summary>
                        /// Inicializa una nueva instancia de la <see cref="DescriptorProperties"/> con la información del bloque.
                        /// </summary>
                        /// <param name="descriptorDevice">Información del descriptor.</param>
                        internal DescriptorProperties(IDeviceProperty descriptorDevice)
                        {
                            _descriptorDevice = descriptorDevice;
                        }
                        #endregion

                    #endregion

                    #region Propiedades

                    #region [public] (Hashtable) Items: Obtiene un valor que representa la colección de propiedades disponibles para este descriptor.
                    /// <summary>
                    /// Obtiene un valor que representa la colección de propiedades disponibles para este descriptor.
                    /// </summary>
                    /// <value>
                    /// Colección de propiedades.
                    /// </value>
                    public Hashtable Items
                    {
                        get
                        {
                            if (_items == null)
                            {
                                _items = new Hashtable();
                                _items = DevicePropertyHelper.GetDescriptorItemsFrom(PropertyKey, _descriptorDevice);
                            }
                            return _items;
                        }
                    }
                    #endregion

                    #region [public] (PropertyKey) PropertyKey: Obtiene un valor que representa el tipo de este bloque.
                    /// <summary>
                    /// Obtiene un valor que representa el tipo de este bloque.
                    /// </summary>
                    /// <value>
                    /// 	<para>Tipo: <see cref="PropertyKey"/></para>
                    /// 	<para>Tipo de este bloque.</para>
                    /// </value>
                    public PropertyKey PropertyKey
                    {
                        get { return _descriptorDevice.PropertyKey; }
                    }
                    #endregion

                    #endregion

                    #region Métodos

                        #region [public] (IDeviceProperty) GetProperty(PropertyKey): Obtiene un valor que representa la propiedad especificada por la clave.
                        /// <summary>
                        /// Obtiene un valor que representa la propiedad especificada por la clave.
                        /// </summary>
                        /// <value>
                        /// 	<para>Tipo: <see cref="IDeviceProperty"/></para>
                        /// 	<para>Interfaz que contiene la propiedad especificada.</para>
                        /// </value>
                        public IDeviceProperty GetProperty(PropertyKey key)
                        {
                            return DevicePropertyHelper.GetPropertyFrom(key, _descriptorDevice);
                        }
                        #endregion

                    #endregion

                    #region Overrides

                        #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                        /// <summary>
                        /// Devuelve una cadena que representa la clase <see cref="DescriptorProperties"/> actual.
                        /// </summary>
                        /// <returns>
                        /// 	<para>Tipo: <see cref="T:System.String"/></para>
                        /// 	<para>Cadena que representa la clase <see cref="DescriptorProperties"/> actual.</para>
                        /// </returns>
                        /// <remarks>
                        /// Este método devuelve una cadena que contiene el nombre del descriptor.
                        /// </remarks>
                        public override string ToString()
                        {
                            return string.Format(CultureInfo.InvariantCulture, "Descriptor = {0}", PropertyKey.PropertyId);
                        }
                        #endregion

                    #endregion
                }
                #endregion

            #endregion


            #region Declaraciones
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private readonly DataSection _dataSection;

            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private DescriptorProperties _descriptor1;

            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private DescriptorProperties _descriptor2;

            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private DescriptorProperties _descriptor3;

            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private DescriptorProperties _descriptor4;
            #endregion

            #region Constructor/es

                #region [internal] DataBlocksProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'DataBlocks'.
                /// <summary>
                /// Inicializa una nueva instancia de la <see cref="DataBlocksProperties"/> con la información de la sección <see cref="KnownEdidSection.DataBlocks"/>.
                /// </summary>
                /// <param name="dataSection">Información de la sección.</param>
                internal DataBlocksProperties(DataSection dataSection)
                {
                    _dataSection = dataSection;
                }
                #endregion

            #endregion

            #region Propiedades

                #region [public] (DescriptorProperties) Descriptor1: Obtiene un valor que representa al primer descriptor disponible.
                /// <summary>
                /// Obtiene un valor que representa al primer descriptor disponible.
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="DescriptorProperties"/></para>
                /// 	<para>Objeto que contiene la información del descriptor.</para>
                /// </value>
                public DescriptorProperties Descriptor1
                {
                    get
                    {
                        if (_descriptor1 == null)
                        {
                            DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>> rawDescriptor = Descriptor1DataBlock;
                            IDeviceProperty descriptorInformation = DevicePropertyHelper.GetDescriptorInformation(rawDescriptor);
                            _descriptor1 = new DescriptorProperties(descriptorInformation);
                        }
                        return _descriptor1;
                    }
                }
                #endregion

                #region [public] (DescriptorProperties) Descriptor2: Obtiene un valor que representa al segundo descriptor disponible.
                /// <summary>
                /// Obtiene un valor que representa al segundo descriptor disponible.
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="DescriptorProperties"/></para>
                /// 	<para>Objeto que contiene la información del descriptor.</para>
                /// </value>
                public DescriptorProperties Descriptor2
                {
                    get
                    {
                        if (_descriptor2 == null)
                        {
                            DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>> rawDescriptor = Descriptor2DataBlock;
                            IDeviceProperty descriptorInformation = DevicePropertyHelper.GetDescriptorInformation(rawDescriptor);
                            _descriptor2 = new DescriptorProperties(descriptorInformation);
                        }
                        return _descriptor2;
                    }
                }
                #endregion

                #region [public] (DescriptorProperties) Descriptor3: Obtiene un valor que representa al tercer descriptor disponible.
                /// <summary>
                /// Obtiene un valor que representa al tercer descriptor disponible.
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="DescriptorProperties"/></para>
                /// 	<para>Objeto que contiene la información del descriptor.</para>
                /// </value>
                public DescriptorProperties Descriptor3
                {
                    get
                    {
                        if (_descriptor3 == null)
                        {
                            DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>> rawDescriptor = Descriptor3DataBlock;
                            IDeviceProperty descriptorInformation = DevicePropertyHelper.GetDescriptorInformation(rawDescriptor);
                            _descriptor3 = new DescriptorProperties(descriptorInformation);
                        }
                        return _descriptor3;
                    }
                }
                #endregion

                #region [public] (DescriptorProperties) Descriptor4: Obtiene un valor que representa al cuarto descriptor disponible.
                /// <summary>
                /// Obtiene un valor que representa al cuarto descriptor disponible.
                /// </summary>
                /// <value>
                /// 	<para>Tipo: <see cref="DescriptorProperties"/></para>
                /// 	<para>Objeto que contiene la información del descriptor.</para>
                /// </value>
                public DescriptorProperties Descriptor4
                {
                    get
                    {
                        if (_descriptor4 == null)
                        {
                            DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>> rawDescriptor = Descriptor4DataBlock;
                            IDeviceProperty descriptorInformation = DevicePropertyHelper.GetDescriptorInformation(rawDescriptor);
                            _descriptor4 = new DescriptorProperties(descriptorInformation);
                        }
                        return _descriptor4;
                    }
                }
                #endregion

            #endregion

            #region Overrides

                #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                /// <summary>
                /// Devuelve una cadena que representa la clase <see cref="DataBlocksProperties"/> actual.
                /// </summary>
                /// <returns>
                /// 	<para>Tipo: <see cref="T:System.String"/></para>
                /// 	<para>Cadena que representa la clase <see cref="DataBlocksProperties"/> actual.</para>
                /// </returns>
                /// <remarks>
                /// Este método devuelve una cadena que contiene el nombre de la sección.
                /// </remarks>
                public override string ToString()
                {
                    return string.Format(CultureInfo.InvariantCulture, "Section = {0}", KnownEdidSection.DataBlocks);
                }
                #endregion

            #endregion

            #region Miembros privados

                #region [private] (DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>>) Descriptor1DataBlock: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Objeto que representa al contenido de la característica 'Preferred Timming Mode' de la sección 'Data blocks'.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor1"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="KeyValuePair{TKey, TValue}"/></para>
                ///     <para><strong>TKey:</strong> <see cref="PropertyKey"/>, <strong>TValue:</strong> <see cref="ReadOnlyCollection{Byte}"/> </para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
                private DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>> Descriptor1DataBlock
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor1) as DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>>; }
                }
                #endregion

                #region [private] (DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>>) Descriptor2DataBlock: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Objeto que representa al contenido de la característica 'Preferred Timming Mode' de la sección 'Data blocks'.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor2"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="KeyValuePair{TKey, TValue}"/></para>
                ///     <para><strong>TKey:</strong> <see cref="PropertyKey"/>, <strong>TValue:</strong> <see cref="ReadOnlyCollection{Byte}"/> </para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
                private DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>> Descriptor2DataBlock
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor2) as DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>>; }
                }
                #endregion

                #region [private] (DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>>) Descriptor3DataBlock: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Objeto que representa al contenido de la característica 'Preferred Timming Mode' de la sección 'Data blocks'.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor3"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="KeyValuePair{TKey, TValue}"/></para>
                ///     <para><strong>TKey:</strong> <see cref="PropertyKey"/>, <strong>TValue:</strong> <see cref="ReadOnlyCollection{Byte}"/> </para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
                private DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>> Descriptor3DataBlock
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor3) as DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>>; }
                }
                #endregion

                #region [private] (DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>>) Descriptor4DataBlock: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Objeto que representa al contenido de la característica 'Preferred Timming Mode' de la sección 'Data blocks'.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor4"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="KeyValuePair{TKey, TValue}"/></para>
                ///     <para><strong>TKey:</strong> <see cref="PropertyKey"/>, <strong>TValue:</strong> <see cref="ReadOnlyCollection{Byte}"/> </para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
                private DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>> Descriptor4DataBlock
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.DataBlock.Descriptor4) as DeviceProperty<KeyValuePair<PropertyKey, ReadOnlyCollection<Byte>>>; }
                }
                #endregion

            #endregion
        }
        #endregion

        #region [public] {sealed} (class) ExtensionBlocksProperties: Conjunto de propiedades disponibles para la sección 'ExtensionBlocks'.
        /// <summary>
        /// Conjunto de propiedades disponibles para la sección <see cref="KnownEdidSection.ExtensionBlocks"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public sealed class ExtensionBlocksProperties
        {
            #region Declaraciones
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private readonly DataSection _dataSection;
            #endregion

            #region Constructor/es

                #region [internal] ExtensionBlocksProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'ExtensionBlocks'.
                /// <summary>
                /// Inicializa una nueva instancia de la <see cref="ExtensionBlocksProperties"/> con la información de la sección <see cref="KnownEdidSection.ExtensionBlocks"/>.
                /// </summary>
                /// <param name="dataSection">Información de la sección.</param>
                internal ExtensionBlocksProperties(DataSection dataSection)
                {
                    _dataSection = dataSection;
                }
                #endregion

            #endregion

            #region Propiedades

                #region [public] (DeviceProperty<Byte>) Count: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Indica si existen bloques de extensión implementados.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.ExtensionBlocks.Count"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="T:System.Byte"/></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                public DeviceProperty<Byte> Count
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.ExtensionBlocks.Count) as DeviceProperty<Byte>; }
                }
                #endregion

                #region [public] (DeviceProperty<Boolean>) HasBlocks: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
                /// <summary>
                /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
                /// 	<para>— Información de la propiedad</para>
                /// 	<para>Description: Indica si existen bloques de extensión implementados.</para>
                /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.ExtensionBlocks.HasBlocks"/></para>
                /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
                /// 	<para>Value: <see cref="T:System.Boolean"/></para>
                /// </summary>
                /// <value>
                /// Objeto fuertemente tipado que representa el valor de la propiedad.
                /// </value>
                public DeviceProperty<Boolean> HasBlocks
                {
                    get { return _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.ExtensionBlocks.HasBlocks) as DeviceProperty<Boolean>; }
                }
                #endregion

            #endregion

            #region Overrides

                #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
                /// <summary>
                /// Devuelve una cadena que representa la clase <see cref="ExtensionBlocksProperties"/> actual.
                /// </summary>
                /// <returns>
                /// 	<para>Tipo: <see cref="T:System.String"/></para>
                /// 	<para>Cadena que representa la clase <see cref="ExtensionBlocksProperties"/> actual.</para>
                /// </returns>
                /// <remarks>
                /// Este método devuelve una cadena que contiene el nombre de la sección.
                /// </remarks>
                public override string ToString()
                {
                    return string.Format(CultureInfo.InvariantCulture, "Section = {0}", KnownEdidSection.ExtensionBlocks);
                }
                #endregion

            #endregion
        }
        #endregion

        #region [public] {sealed} (class) CheckSumProperties: Conjunto de propiedades disponibles para la sección 'CheckSum'.
        /// <summary>
        /// Conjunto de propiedades disponibles para la sección <see cref="KnownEdidSection.CheckSum"/>.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public sealed class CheckSumProperties
        {
            #region Declaraciones
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private readonly DataSection _dataSection;
            #endregion

            #region Constructor/es

            #region [internal] CheckSumProperties(DataSection): Inicializa una nueva instancia de la clase con la información de la sección 'CheckSum'.
            /// <summary>
            /// Inicializa una nueva instancia de la <see cref="CheckSumProperties"/> con la información de la sección <see cref="KnownEdidSection.CheckSum"/>.
            /// </summary>
            /// <param name="dataSection">Información de la sección.</param>
            internal CheckSumProperties(DataSection dataSection)
            {
                _dataSection = dataSection;
            }
            #endregion

            #endregion

            #region Propiedades

            #region [public] (DeviceProperty<bool>) IsValid: Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.
            /// <summary>
            /// 	<para>Obtiene un objeto fuertemente tipado que representa el valor de esta propiedad.</para>
            /// 	<para>— Información de la propiedad</para>
            /// 	<para>Description: Número de revisión de la especificación implementada en este monitor.</para>
            /// 	<para>Key: <see cref="KnownEedidPropertiesDefinition.Edid.CheckSum.IsValid"/></para>
            /// 	<para>Unit: <see cref="PropertyUnit.None"/></para>
            /// 	<para>Value: <see cref="T:System.Boolean"/></para>
            /// </summary>
            /// <value>
            /// Objeto fuertemente tipado que representa el valor de la propiedad.
            /// </value>
            public DeviceProperty<bool> IsValid => _dataSection.GetProperty(KnownEedidPropertiesDefinition.Edid.CheckSum.IsValid) as DeviceProperty<bool>;
            #endregion

            #endregion

            #region Overrides

            #region [public] {override} (string) ToString(): Devuelve una cadena que representa la clase actual.
            /// <summary>
            /// Devuelve una cadena que representa la clase <see cref="CheckSumProperties"/> actual.
            /// </summary>
            /// <returns>
            /// 	<para>Tipo: <see cref="T:System.String"/></para>
            /// 	<para>Cadena que representa la clase <see cref="CheckSumProperties"/> actual.</para>
            /// </returns>
            /// <remarks>
            /// Este método devuelve una cadena que contiene el nombre de la sección.
            /// </remarks>
            public override string ToString()
            {
                return string.Format(CultureInfo.InvariantCulture, "Section = {0}", KnownEdidSection.CheckSum);
            }
            #endregion

            #endregion
        }
        #endregion

        #endregion
    }
}
