
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    using Helpers.Enumerations;

    // EDID Section: Established Timings I & II Information.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Established Timings I     BYTE        7 6 5 4 3 2 1 0                                     |
    // |                                                    1 _ _ _ _ _ _ _ 720 x 400 @ 70Hz - IBM, VGA         |
    // |                                                    _ 1 _ _ _ _ _ _ 720 x 400 @ 88Hz - IBM, XGA2        |
    // |                                                    _ _ 1 _ _ _ _ _ 640 x 480 @ 60Hz - IBM, VGA         |
    // |                                                    _ _ _ 1 _ _ _ _ 640 x 480 @ 67Hz - Apple, Mac II    |
    // |                                                    _ _ _ _ 1 _ _ _ 640 x 480 @ 72Hz - VESA             |
    // |                                                    _ _ _ _ _ 1 _ _ 640 x 480 @ 75Hz - VESA             |
    // |                                                    _ _ _ _ _ _ 1 _ 800 x 600 @ 56Hz - VESA             |
    // |                                                    _ _ _ _ _ _ _ 1 800 x 600 @ 60Hz - VESA             |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Established Timings II    BYTE        7 6 5 4 3 2 1 0                                     |
    // |                                                    1 _ _ _ _ _ _ _ 800 x  600 @ 72Hz - VESA            |
    // |                                                    _ 1 _ _ _ _ _ _ 800 x  600 @ 75Hz - VESA            |
    // |                                                    _ _ 1 _ _ _ _ _ 832 x  624 @ 75Hz - Apple, Mac II   |
    // |                                                    _ _ _ 1 _ _ _ _ 1024 x  768 @ 87Hz - IBM Interlaced |
    // |                                                    _ _ _ _ 1 _ _ _ 1024 x  768 @ 60Hz - VESA           |
    // |                                                    _ _ _ _ _ 1 _ _ 1024 x  768 @ 70Hz - VESA           |
    // |                                                    _ _ _ _ _ _ 1 _ 1024 x  768 @ 75Hz - VESA           |
    // |                                                    _ _ _ _ _ _ _ 1 1280 x 1024 @ 75Hz - VESA           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 02h          Manufacturer's Timings    BYTE        7 6 5 4 3 2 1 0                                     |
    // |                                                    1 _ _ _ _ _ _ _ 1152 x 870 @ 75Hz - Apple, Mac II   |
    // |                                                                                                        |
    // |                                                    bits 06:00 - Reserved all set to 00h                |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> class that represents the <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownEdidSection.EstablishedTimings" /> section of this block <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.EDID" />.
    /// </summary> 
    sealed class EstablishedTimingsEdidSection : BaseDataSection
    {
        #region constructor/s

        #region [public] EstablishedTimingsEdidSection(ReadOnlyCollection<byte>): Initialize a new instance of the class with the data in this section untreated
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Eedid.EstablishedTimingsEdidSection" /> class with the data in this section untreated.
        /// </summary>
        /// <param name="sectionData">Unprocessed data in this section</param>
        public EstablishedTimingsEdidSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region private readonly properties

        #region [private] (byte) EstablishedTimingsI: Obtiene un valor que representa al campo 'Established Timings I'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Established Timings I</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte EstablishedTimingsI
        {
            get
            {
                byte establishedTimingsI = RawData[0x00];
                return establishedTimingsI;
            }
        }
        #endregion

        #region [private] (bool) Is720x400x70: Obtiene un valor que representa la característica '720 x 400 @ 70 Hz, IBM, VGA' del campo 'Established Timing I'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>720 x 400 @ 70 Hz, IBM, VGA</c>' del campo '<c>Established Timing I</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is720x400x70
        {
            get
            {
                byte establishedTimingsI = EstablishedTimingsI;
                bool is720x400x70 = establishedTimingsI.CheckBit(Bits.Bit07);

                return is720x400x70;
            }
        }
        #endregion

        #region [private] (bool) Is720x400x88: Obtiene un valor que representa la característica '720 x 400 @ 88 Hz, IBM, XGA2' del campo 'Established Timing I'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>720 x 400 @ 88 Hz, IBM, XGA2</c>' del campo '<c>Established Timing I</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is720x400x88
        {
            get
            {
                byte establishedTimingsI = EstablishedTimingsI;
                bool is720x400x88 = establishedTimingsI.CheckBit(Bits.Bit06);

                return is720x400x88;
            }
        }
        #endregion

        #region [private] (bool) Is640x480x60: Obtiene un valor que representa la característica '640 x 480 @ 60 Hz, IBM, VGA' del campo 'Established Timing I'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>640 x 480 @ 60 Hz, IBM, VGA</c>' del campo '<c>Established Timing I</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is640x480x60
        {
            get
            {
                byte establishedTimingsI = EstablishedTimingsI;
                bool is640x480x60 = establishedTimingsI.CheckBit(Bits.Bit05);

                return is640x480x60;
            }
        }
        #endregion

        #region [private] (bool) Is640x480x67: Obtiene un valor que representa la característica '640 x 480 @ 67 Hz, Apple, Mac II' del campo 'Established Timing I'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>640 x 480 @ 67 Hz, Apple, Mac II</c>' del campo '<c>Established Timing I</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is640x480x67
        {
            get
            {
                byte establishedTimingsI = EstablishedTimingsI;
                bool is640x480x67 = establishedTimingsI.CheckBit(Bits.Bit04);

                return is640x480x67;
            }
        }
        #endregion

        #region [private] (bool) Is640x480x72: Obtiene un valor que representa la característica '640 x 480 @ 72 Hz, VESA' del campo 'Established Timing I'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>640 x 480 @ 72 Hz, VESA</c>' del campo '<c>Established Timing I</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is640x480x72
        {
            get
            {
                byte establishedTimingsI = EstablishedTimingsI;
                bool is640x480x72 = establishedTimingsI.CheckBit(Bits.Bit03);

                return is640x480x72;
            }
        }
        #endregion

        #region [private] (bool) Is640x480x75: Obtiene un valor que representa la característica '640 x 480 @ 75 Hz, VESA' del campo 'Established Timing I'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>640 x 480 @ 75 Hz, VESA</c>' del campo '<c>Established Timing I</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is640x480x75
        {
            get
            {
                byte establishedTimingsI = EstablishedTimingsI;
                bool is640x480x75 = establishedTimingsI.CheckBit(Bits.Bit02);

                return is640x480x75;
            }
        }
        #endregion

        #region [private] (bool) Is800x600x56: Obtiene un valor que representa la característica '800 x 600 @ 56 Hz, VESA' del campo 'Established Timing I'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>800 x 600 @ 56 Hz, VESA</c>' del campo '<c>Established Timing I</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is800x600x56
        {
            get
            {
                byte establishedTimingsI = EstablishedTimingsI;
                bool is800x600x56 = establishedTimingsI.CheckBit(Bits.Bit01);

                return is800x600x56;
            }
        }
        #endregion

        #region [private] (bool) Is800x600x60: Obtiene un valor que representa la característica '800 x 600 @ 60 Hz, VESA' del campo 'Established Timing I'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>800 x 600 @ 60 Hz, VESA</c>' del campo '<c>Established Timing I</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is800x600x60
        {
            get
            {
                byte establishedTimingsI = EstablishedTimingsI;
                bool is800x600x60 = establishedTimingsI.CheckBit(Bits.Bit00);

                return is800x600x60;
            }
        }
        #endregion


        #region [private] (byte) EstablishedTimingsII: Obtiene un valor que representa al campo 'Established Timings II'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Established Timings II</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte EstablishedTimingsII
        {
            get
            {
                byte establishedTimingsII = RawData[0x01];
                return establishedTimingsII;
            }
        }
        #endregion

        #region [private] (bool) Is800x600x72: Obtiene un valor que representa la característica '800 x 600 @ 72 Hz, VESA' del campo 'Established Timing II'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>800 x 600 @ 72 Hz, VESA</c>' del campo '<c>Established Timing II</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is800x600x72
        {
            get
            {
                byte establishedTimingsII = EstablishedTimingsII;
                bool is800x600x72 = establishedTimingsII.CheckBit(Bits.Bit07);

                return is800x600x72;
            }
        }
        #endregion

        #region [private] (bool) Is800x600x75: Obtiene un valor que representa la característica '800 x 600 @ 75 Hz, VESA' del campo 'Established Timing II'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>800 x 600 @ 75 Hz, VESA</c>' del campo '<c>Established Timing II</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is800x600x75
        {
            get
            {
                byte establishedTimingsII = EstablishedTimingsII;
                bool is800x600x75 = establishedTimingsII.CheckBit(Bits.Bit06);

                return is800x600x75;
            }
        }
        #endregion

        #region [private] (bool) Is832x624x75: Obtiene un valor que representa la característica '832 x 624 @ 75 Hz, Apple, Mac II' del campo 'Established Timing II'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>832 x 624 @ 75 Hz, Apple, Mac II</c>' del campo '<c>Established Timing II</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is832x624x75
        {
            get
            {
                byte establishedTimingsII = EstablishedTimingsII;
                bool is832x624x75 = establishedTimingsII.CheckBit(Bits.Bit05);

                return is832x624x75;
            }
        }
        #endregion

        #region [private] (bool) Is1024x768x87I: Obtiene un valor que representa la característica '1024 x 768 @ 87 Hz, IBM, Interlaced' del campo 'Established Timing II'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>1024 x 768 @ 87 Hz, IBM, Interlaced</c>' del campo '<c>Established Timing II</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1024x768x87I
        {
            get
            {
                byte establishedTimingsII = EstablishedTimingsII;
                bool is1024x768x87I = establishedTimingsII.CheckBit(Bits.Bit04);

                return is1024x768x87I;
            }
        }
        #endregion

        #region [private] (bool) Is1024x768x60  Obtiene un valor que representa la característica '1024 x 768 @ 60 Hz, VESA' del campo 'Established Timing II'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>1024 x 768 @ 60 Hz, VESA</c>' del campo '<c>Established Timing II</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1024x768x60
        {
            get
            {
                byte establishedTimingsII = EstablishedTimingsII;
                bool is1024x768x60 = establishedTimingsII.CheckBit(Bits.Bit03);

                return is1024x768x60;
            }
        }
        #endregion

        #region [private] (bool) Is1024x768x70  Obtiene un valor que representa la característica '1024 x 768 @ 70 Hz, VESA' del campo 'Established Timing II'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>1024 x 768 @ 70 Hz, VESA</c>' del campo '<c>Established Timing II</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1024x768x70
        {
            get
            {
                byte establishedTimingsII = EstablishedTimingsII;
                bool is1024x768x70 = establishedTimingsII.CheckBit(Bits.Bit02);

                return is1024x768x70;
            }
        }
        #endregion

        #region [private] (bool) Is1024x768x75  Obtiene un valor que representa la característica '1024 x 768 @ 75 Hz, VESA' del campo 'Established Timing II'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>1024 x 768 @ 75 Hz, VESA</c>' del campo '<c>Established Timing II</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1024x768x75
        {
            get
            {
                byte establishedTimingsII = EstablishedTimingsII;
                bool is1024x768x75 = establishedTimingsII.CheckBit(Bits.Bit01);

                return is1024x768x75;
            }
        }
        #endregion

        #region [private] (bool) Is1280x1024x75  Obtiene un valor que representa la característica '1280 x 1024 @ 75 Hz, VESA' del campo 'Established Timing II'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>1280 x 1024 @ 75 Hz, VESA</c>' del campo '<c>Established Timing II</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1280x1024x75
        {
            get
            {
                byte establishedTimingsII = EstablishedTimingsII;
                bool is1280x1024x75 = establishedTimingsII.CheckBit(Bits.Bit00);

                return is1280x1024x75;
            }
        }
        #endregion


        #region [private] (byte) ManufacturerTimings: Obtiene un valor que representa al campo 'Manufacturer's Timings'.
        /// <summary>
        /// Obtiene un valor que representa al campo '<c>Manufacturer's Timings</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Byte"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte ManufacturerTimings
        {
            get
            {
                byte manufacturerTimings = RawData[0x02];
                return manufacturerTimings;
            }
        }
        #endregion

        #region [private] (bool) Is1152x870x75: Obtiene un valor que representa la característica '1152 x 870 @ 75 Hz, Apple, Mac II' del campo 'Manufacturer's Timings'.
        /// <summary>
        /// Obtiene un valor que representa la característica '<c>1152 x 870 @ 75 Hz, Apple, Mac II</c>' del campo '<c>Established Timing II</c>'.
        /// </summary>
        /// <value>
        ///   <para>Tipo: <see cref="T:System.Boolean"/></para>
        ///   <para>Valor de la propiedad.</para>
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool Is1152x870x75
        {
            get
            {
                byte manufacturerTimings = ManufacturerTimings;
                bool is1152x870x75 = manufacturerTimings.CheckBit(Bits.Bit07);

                return is1152x870x75;
            }
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Returns a value that represents the value of the specified property
        /// <inheritdoc />
        /// <summary>
        /// Returns a value that represents the value of the specified property.
        /// </summary>
        /// <param name="propertyKey">Property key to be obtained.</param>
        /// <returns>
        /// Property value.
        /// </returns>
        protected override object GetValueTypedProperty(PropertyKey propertyKey)
        {
            object value = null;
            var propertyId = (KnownEdidEstablishedTimingsProperty)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x00] - [Resolutions] - [ReadOnlyCollection<MonitorResolutionInfo>]
                case KnownEdidEstablishedTimingsProperty.Resolutions:
                    value = GetResolutionCollection();
                    break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(Hashtable): Populates the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="items">Collection of properties of this structure</param>
        protected override void Parse(Hashtable items)
        {
            #region validate parameter/s
            base.Parse(items);
            #endregion

            #region items
            items.Add(KnownEedidPropertiesDefinition.Edid.EstablishedTimings.Resolutions, GetResolutionCollection());
            #endregion
        }
        #endregion

        #endregion


        #region EDID 1.4 Specification

        #region [private] (ReadOnlyCollection<MonitorResolutionInfo>) GetResolutionCollection(): Returns an object that represents a collection of available resolutions
        /// <summary>
        /// Returns an object that represents a collection of available resolutions.
        /// </summary>
        /// <returns>
        /// Collection of available resolutions.
        /// </returns>
        private ReadOnlyCollection<MonitorResolutionInfo> GetResolutionCollection()
        {
            var items = new List<MonitorResolutionInfo>();

            if (Is640x480x60)
            {
                items.Add(new MonitorResolutionInfo(640, 480, 60));
            }

            if (Is640x480x67)
            {
                items.Add(new MonitorResolutionInfo(640, 480, 67));
            }

            if (Is640x480x72)
            {
                items.Add(new MonitorResolutionInfo(640, 480, 72));
            }

            if (Is640x480x75)
            {
                items.Add(new MonitorResolutionInfo(640, 480, 75));
            }

            if (Is720x400x70)
            {
                items.Add(new MonitorResolutionInfo(720, 400, 70));
            }

            if (Is720x400x88)
            {
                items.Add(new MonitorResolutionInfo(720, 400, 88));
            }

            if (Is800x600x56)
            {
                items.Add(new MonitorResolutionInfo(800, 600, 56));
            }

            if (Is800x600x60)
            {
                items.Add(new MonitorResolutionInfo(800, 600, 60));
            }

            if (Is800x600x72)
            {
                items.Add(new MonitorResolutionInfo(800, 600, 72));
            }

            if (Is800x600x75)
            {
                items.Add(new MonitorResolutionInfo(800, 600, 75));
            }

            if (Is832x624x75)
            {
                items.Add(new MonitorResolutionInfo(832, 624, 75));
            }

            if (Is1024x768x60)
            {
                items.Add(new MonitorResolutionInfo(1024, 768, 60));
            }

            if (Is1024x768x70)
            {
                items.Add(new MonitorResolutionInfo(1024, 768, 70));
            }

            if (Is1024x768x75)
            {
                items.Add(new MonitorResolutionInfo(1024, 768, 75));
            }

            if (Is1024x768x87I)
            {
                items.Add(new MonitorResolutionInfo(1024, 768, 87, true, false));
            }

            if (Is1024x768x60)
            {
                items.Add(new MonitorResolutionInfo(1024, 768, 60));
            }

            if (Is1024x768x60)
            {
                items.Add(new MonitorResolutionInfo(1024, 768, 60));
            }

            if (Is1152x870x75)
            {
                items.Add(new MonitorResolutionInfo(1152, 870, 75));
            }

            if (Is1280x1024x75)
            {
                items.Add(new MonitorResolutionInfo(1280, 1024, 75));
            }

            return items.AsReadOnly();
        }
        #endregion

        #endregion
    }
}
