
namespace iTin.Core.Hardware.Specification.Eedid
{
     using System;
     using System.Collections;
     using System.Collections.Generic;
     using System.Collections.ObjectModel;
     using System.Diagnostics.CodeAnalysis;
     using System.Linq;

    // CEA Section: Detailed Timings Descriptors Information
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSection" /> que representa la sección <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownCeaSection.DetailedTiming" /> de este bloque <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.CEA" />.
    /// </summary> 
    sealed class DetailedTimingsCeaSection : BaseDataSection
    {
        #region constructor/s

        #region [public] DetailedTimingsCeaSection(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de esta sección sin tratar.
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DetailedTimingsCeaSection"/> con los datos de esta sección sin tratar.
        /// </summary>
        /// <param name="sectionData">Datos de esta sección sin tratar.</param>
        public DetailedTimingsCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (object) GetValueTypedProperty(PropertyKey): Obtiene un valor que representa el valor de la propiedad especificada.
        /// <inheritdoc />
        /// <summary>
        /// Obtiene un valor que representa el valor de la propiedad especificada.
        /// </summary>
        /// <param name="propertyKey">Clave de la propiedad a obtener.</param>
        /// <returns></returns>
        protected override object GetValueTypedProperty(PropertyKey propertyKey)
        {
            object value = null;
            var propertyId = (KnownCeaDetailedTimingModeProperty)propertyKey.PropertyId;

            switch (propertyId)
            {
                #region [0x00] - [Timings] - [ReadOnlyCollection<DetailedTimingModeDescriptor>]
                case KnownCeaDetailedTimingModeProperty.Timings:
                    value = GetTimings(RawData);
                    break;
                #endregion
            }

            return value;
        }
        #endregion

        #region [protected] {override} (void) Parse(Hashtable): Obtiene la colección de items de esta sección.
        /// <inheritdoc />
        /// <summary>
        /// Obtiene la colección de items de esta sección.
        /// </summary>
        /// <param name="items">Colección de items de esta sección.</param>
        [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
        protected override void Parse(Hashtable items)
        {
            #region Comprobar parámetro/s.
            base.Parse(items);
            #endregion

            #region Diccionario de propiedades (PropertyKey / Value).
            items.Add(KnownEedidPropertiesDefinition.Cea.DetailedTiming.Timings, GetTimings(RawData));
            #endregion
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (ReadOnlyCollection<DetailedTimingDescriptor>) GetTimings(ReadOnlyCollection<byte>): 
        /// <summary>
        /// Gets the timings.
        /// </summary>
        /// <param name="rawData">The raw data.</param>
        /// <returns></returns>
        private static ReadOnlyCollection<DetailedTimingModeDescriptor> GetTimings(ReadOnlyCollection<byte> rawData)
        {
            IEnumerable<ReadOnlyCollection<byte>> dataTimmingCollection = ToDataTimmingCollection(rawData);

            var timings = 
                (from timmingDataItem in dataTimmingCollection
                 let valid = IsValidDataTimming(timmingDataItem)
                 where valid
                 select timmingDataItem)
                .Select(timmingDataItem => new DetailedTimingModeDescriptor(timmingDataItem))
                .ToList();

            return timings.AsReadOnly();
        }
        #endregion

        #region [private] {static} (IEnumerable<ReadOnlyCollection<byte>>) ToDataTimmingCollection(ReadOnlyCollection<byte>): Obtiene la colección de Data Timmings Descriptors disponibles en este bloque CEA.
        /// <summary>
        /// Obtiene la colección de Data Timmings Descriptors disponibles en este bloque CEA.
        /// </summary>
        /// <param name="dataTimmings">Array con los datos Data Timmings Descriptors.</param>
        /// <returns></returns>
        private static IEnumerable<ReadOnlyCollection<byte>> ToDataTimmingCollection(ReadOnlyCollection<byte> dataTimmings)
        {
            var dataTimmingsArray = dataTimmings.ToArray();

            var dataTimmingCollection = new List<ReadOnlyCollection<byte>>();
            for (int i = 0; i < dataTimmings.Count; i += 0x12)
            {
                var dataTimmingArray = new byte[0x12];

                Array.Copy(dataTimmingsArray, i, dataTimmingArray, 0x00, 0x12);
                dataTimmingCollection.Add(new ReadOnlyCollection<byte>(dataTimmingArray));
            }

            return dataTimmingCollection;
        }
        #endregion

        #region [private] {static} (bool) IsValidDataTimming(ReadOnlyCollection<byte>): Obtiene un valor que indica si el Data Timming Descriptor especificado es válido.
        /// <summary>
        /// Obtiene un valor que indica si el Data Timming Descriptor especificado es válido.
        /// </summary>
        /// <param name="dataTimming">Data Timming Descriptor.</param>
        /// <returns></returns>
        private static bool IsValidDataTimming(ReadOnlyCollection<byte> dataTimming) => !((dataTimming[0x00] == 0x00) & (dataTimming[0x01] == 0x00));
        #endregion

        #endregion
    }
}
