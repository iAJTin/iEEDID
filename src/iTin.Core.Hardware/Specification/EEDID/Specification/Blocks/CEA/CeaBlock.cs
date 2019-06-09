
namespace iTin.Core.Hardware.Specification.Eedid
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    // •——————————————————————————————————————————————•
    // | CEA BLOCK                                    |
    // |   · Extension Tag                            |
    // |   · Revision Number                          |
    // |   · Detailed Timming data begins (DTD)       |
    // |   · DTV Monitor supports / Preferred formats |
    // |   · CEA Data Blocks                          |
    // |     · CEA Short Video Data Block (SVDB)      |
    // |     · CEA Short Audio Data Block (SADB)      |
    // |     · CEA Short Speaker Data Block (SKDB)    |
    // |     · CEA Short Vendor Data Block (SRDB)     |
    // |   · CEA Data Timming Descriptors (DTD)       |
    // |     · Timing Descriptor 1                    |
    // |     ·   ...                                  |
    // |     ·   ...                                  |
    // |     · Timing Descriptor 4                    |
    // |   · Checksum                                 |
    // •——————————————————————————————————————————————•

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataBlock" /> que representa un bloque de tipo <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.CEA" /> de la especificación <see cref="T:iTin.Core.Hardware.Specification.EEDID" />.
    /// </summary> 
    internal class CeaBlock : BaseDataBlock
    {
        #region constructor/s

        #region [public] CeaBlock(ReadOnlyCollection<byte>): Inicializa una nueva instancia de la clase con los datos de esta sección sin tratar.
        /// <inheritdoc />
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.CeaBlock" /> con los datos de esta sección sin tratar.
        /// </summary>
        /// <param name="dataBlock">Datos sin tratar de este bloque.</param>
        /// <remarks>
        /// Crear bloque <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.CEA" /> que pertenece a la especificación <see cref="T:iTin.Core.Hardware.Specification.EEDID" />.
        /// </remarks>
        public CeaBlock(ReadOnlyCollection<byte> dataBlock) : base(dataBlock)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) InitDataSectionTable(Dictionary<Enum, ReadOnlyCollection<byte>>): Inicializar diccionario con los datos disponibles para las secciones de este bloque.
        /// <inheritdoc />
        /// <summary>
        /// Inicializar diccionario con los datos disponibles para las secciones de este bloque.
        /// </summary>
        /// <param name="dataSectionDictionary">Diccionario que contiene los datos disponibles para las secciones de este bloque.</param>
        protected override void InitDataSectionTable(Dictionary<Enum, ReadOnlyCollection<byte>> dataSectionDictionary)
        {
            var ceaDataArray = RawData.ToArray(); 

            var dataSectionArray = new byte[0x01];
            Array.Copy(ceaDataArray, 0x01, dataSectionArray, 0x00, 0x01);
            dataSectionDictionary.Add(KnownCeaSection.Information, new ReadOnlyCollection<byte>(dataSectionArray));

            if (ceaDataArray[0x01] != 0x01)
            {
                dataSectionArray = new byte[0x01];
                Array.Copy(ceaDataArray, 0x03, dataSectionArray, 0x00, 0x01);
                dataSectionDictionary.Add(KnownCeaSection.MonitorSupport, new ReadOnlyCollection<byte>(dataSectionArray));
            }

            var dataBlocks = GetDataBlocks(RawData);
            if (dataBlocks != null)
            {
                dataSectionDictionary.Add(KnownCeaSection.DataBlockCollection, dataBlocks);
            }

            var dataTimmings = GetDetailedTimingData(RawData);
            if (dataTimmings != null)
            {
                dataSectionDictionary.Add(KnownCeaSection.DetailedTiming, dataTimmings);
            }

            dataSectionDictionary.Add(KnownCeaSection.CheckSum, RawData);
        }
        #endregion

        #region [protected] {override} (void) InitSectionTable(Dictionary<Enum, BaseDataSection>): Inicializar diccionario con las secciones disponibles para este bloque.
        /// <inheritdoc />
        /// <summary>
        /// Inicializar diccionario con las secciones disponibles para este bloque.
        /// </summary>
        /// <param name="sectionDictionary">Diccionario que contiene las secciones disponibles para este bloque.</param>
        protected override void InitSectionTable(Dictionary<Enum, BaseDataSection> sectionDictionary)
        {
            sectionDictionary.Add(KnownCeaSection.Information, new InformationCeaSection(DataSectionTable[KnownCeaSection.Information]));

            if (DataSectionTable.ContainsKey(KnownCeaSection.MonitorSupport))
            {
                sectionDictionary.Add(KnownCeaSection.MonitorSupport, new MonitorSupportCeaSection(DataSectionTable[KnownCeaSection.MonitorSupport]));
            }

            if (DataSectionTable.ContainsKey(KnownCeaSection.DataBlockCollection))
            {
                sectionDictionary.Add(KnownCeaSection.DataBlockCollection, new DataBlockCollectionCeaSection(DataSectionTable[KnownCeaSection.DataBlockCollection]));
            }

            if (DataSectionTable.ContainsKey(KnownCeaSection.DetailedTiming))
            {
                sectionDictionary.Add(KnownCeaSection.DetailedTiming, new DetailedTimingsCeaSection(DataSectionTable[KnownCeaSection.DetailedTiming]));
            }

            if (DataSectionTable.ContainsKey(KnownCeaSection.CheckSum))
            {
                sectionDictionary.Add(KnownCeaSection.CheckSum, new CheckSumCeaSection(DataSectionTable[KnownCeaSection.CheckSum]));
            }
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (ReadOnlyCollection<byte>) GetDataBlocks(ReadOnlyCollection<byte>): Obtiene un array que contiene la estructura Data Block Collection de un bloque de tipo CEA sin procesar.
        /// <summary>
        /// Obtiene un array que contiene la estructura Data Block Collection de un bloque de tipo CEA sin procesar.
        /// </summary>
        /// <param name="ceaData">Array que contiene las estructuras del bloque CEA.</param>
        /// <returns>Array que contiene la estructura Data Block Collection de este bloque CEA sin procesar.</returns>
        private static ReadOnlyCollection<byte> GetDataBlocks(ReadOnlyCollection<byte> ceaData)
        {
            byte d = ceaData[0x02];

            if (d == 0x04)
            {
                return null;
            }

            var ceaDataArray = ceaData.ToArray();
            var dataBlocks = new byte[d - 4];
            Array.Copy(ceaDataArray, 0x04, dataBlocks, 0x00, d - 4);

            return new ReadOnlyCollection<byte>(dataBlocks);
        }
        #endregion

        #region [private] {static} (ReadOnlyCollection<byte>) GetDetailedTimingData(int, ReadOnlyCollection<byte>): Obtiene un array que contiene la estructura Detailed Timings Descriptors de un bloque de tipo CEA sin procesar.
        /// <summary>
        /// Obtiene un array que contiene la estructura <see cref="KnownCeaSection.DetailedTiming"/> de un bloque de tipo <see cref="KnownDataBlock.CEA"/> sin procesar.
        /// </summary>
        /// <param name="ceaData">Array que contiene las estructuras <see cref="KnownCeaSection.DetailedTiming"/> del bloque <see cref="KnownDataBlock.CEA"/>.</param>
        /// <returns>Array que contiene la estructura <see cref="KnownCeaSection.DetailedTiming"/> de este bloque <see cref="KnownDataBlock.CEA"/> sin procesar.</returns>
        private static ReadOnlyCollection<byte> GetDetailedTimingData(ReadOnlyCollection<byte> ceaData)
        {
            byte d = ceaData[0x02];
            int nativeFormats = ceaData[0x03] & 0x0f;

            if (d == 0)
            {
                return null;
            }

            var ceaDataArray = ceaData.ToArray();

            //int begin = d;
            //bool ok = true;
            //while (ok)
            //{
            //    if ((ceaDataArray[begin] == 0x00) && (ceaDataArray[begin+1]== 0x00))                    
            //        ok = false;
            //    else
            //        begin += 0x12;
            //}

            byte[] detailedTimingData;
            if (ceaData[0x01] == 0x01)
            {
                detailedTimingData = new byte[0x12 * 3];
                Array.Copy(ceaDataArray, d, detailedTimingData, 0x00, 0x12 * 3);
            }
            else
            {
                detailedTimingData = new byte[0x12 * nativeFormats];
                Array.Copy(ceaDataArray, d, detailedTimingData, 0x00, 0x12 * nativeFormats);                  
            }

            return new ReadOnlyCollection<byte>(detailedTimingData);
        }
        #endregion

        #endregion
    }
}
