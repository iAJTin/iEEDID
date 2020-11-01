
namespace iTin.Hardware.Specification.Eedid
{
     using System;
     using System.Collections.Generic;
     using System.Collections.ObjectModel;
     using System.Linq;

    // CEA Section: Detailed Timings Descriptors Information
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name                      Lenght      Description                                         |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// Specialization of the <see cref="BaseDataSection"/> class.<br/>
    /// Represents the <see cref="KnownCeaSection.DetailedTiming"/> section of this block <see cref="KnownDataBlock.CEA"/>.
    /// </summary> 
    internal sealed class DetailedTimingsCeaSection : BaseDataSection
    {
        #region constructor/s

        #region [public] DetailedTimingsCeaSection(ReadOnlyCollection<byte>): Initializes a new instance of the class with the data from this raw section
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedTimingsCeaSection"/> class with the data from this raw section.
        /// </summary>
        /// <param name="sectionData">Data from this section untreated.</param>
        public DetailedTimingsCeaSection(ReadOnlyCollection<byte> sectionData) : base(sectionData)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(SectionPropertiesTable): Populates the property collection for this section
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this section.
        /// </summary>
        /// <param name="properties">Collection of properties of this section.</param>
        protected override void PopulateProperties(SectionPropertiesTable properties)
        {
            var sectionProperties = new List<SectionPropertiesTable>();
            var timings = GetTimings(RawData);
            foreach (var timing in timings)
            {
                sectionProperties.Add(timing.Properties);
            }

            properties.Add(EedidProperty.Cea.DetailedTiming.Timings, sectionProperties);
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (ReadOnlyCollection<DetailedTimingDescriptor>) GetTimings(ReadOnlyCollection<byte>): Gets the timings
        /// <summary>
        /// Gets the timings.
        /// </summary>
        /// <param name="rawData">The raw data.</param>
        /// <returns>
        /// Timings collection
        /// </returns>
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

        #region [private] {static} (IEnumerable<ReadOnlyCollection<byte>>) ToDataTimmingCollection(ReadOnlyCollection<byte>): Gets the collection of Data Timmings Descriptors available in this CEA block
        /// <summary>
        /// Gets the collection of Data Timmings Descriptors available in this CEA block.
        /// </summary>
        /// <param name="dataTimmings">Array with Data Timmings Descriptors data.</param>
        /// <returns>
        /// Collection of Data Timmings Descriptors.
        /// </returns>
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
