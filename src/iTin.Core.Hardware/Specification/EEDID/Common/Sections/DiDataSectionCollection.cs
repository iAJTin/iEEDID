﻿
using iTin.Core.Helpers;

namespace iTin.Core.Hardware.Specification.Eedid
{
    using System.ComponentModel;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Especialización de la clase <see cref="T:iTin.Core.Hardware.Specification.Eedid.BaseDataSectionCollection" /> que representa una colección de objetos <see cref="T:iTin.Core.Hardware.Specification.Eedid.DataSection" /> para un <see cref="T:iTin.Core.Hardware.Specification.Eedid.DataBlock" /> de tipo <see cref="F:iTin.Core.Hardware.Specification.Eedid.KnownDataBlock.DI" />.
    /// </summary>
    sealed class DiDataSectionCollection : BaseDataSectionCollection
    {
        #region constructor/s

        #region [internal] DiDataSectionCollection(): Inicializa una nueva instancia de la clase especificando los datos del bloque sin tratar.
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DiDataSectionCollection"/> especificando los datos del bloque sin tratar.
        /// </summary>
        /// <param name="datablock">Datos del bloque sin tratar.</param>
        internal DiDataSectionCollection(DataBlock datablock) : base(datablock, true)
        {                
        }
        #endregion

        #endregion

        #region public properties

        #region [public] (DataSection) this[KnownDiSection]: Obtiene la sección con la clave especificada.
        /// <summary>
        /// Obtiene la sección con la clave especificada.
        /// </summary>
        /// <value>
        /// 	<para>Tipo: <see cref="DataSection"/></para>
        /// 	<para>Objeto <see cref="DataSection"/> especificado mediante su clave.</para>
        /// </value>
        /// <remarks>
        /// Si el elemento no existe se devuelve <strong>null</strong>.
        /// </remarks>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public DataSection this[KnownDiSection valueKey]
        {
            get
            {
                var knownBlockValid = IsValidSection(valueKey);
                if (!knownBlockValid)
                {
                    throw new InvalidEnumArgumentException("valueKey", (int)valueKey, typeof(KnownDiSection));
                }

                var sectionIndex = IndexOf(valueKey);
                if (sectionIndex != -1)
                {
                    return this[sectionIndex];
                }

                return null;
            }
        }
        #endregion

        #endregion

        #region public methods

        #region [public] (bool) Contains(KnownDiSection): Determina si el elemento con la clave especificada se encuentra en la colección 'DiDataSectionCollection'.
        /// <summary>
        /// Determina si el elemento con la clave especificada se encuentra en la colección <see cref="DiDataSectionCollection"/>.
        /// </summary>
        /// <param name="valueKey">Uno de los valores de <see cref="KnownDiSection"/> que representa la clave del objeto <see cref="DataSection"/> a buscar.</param>
        /// <returns>
        /// 	<para><strong>true</strong> si el objeto <see cref="DataSection"/> con el <c>valueKey</c> se encuentra en la colección <see cref="DiDataSectionCollection"/>; de lo contrario, es <strong>false</strong>.</para>
        /// </returns>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public bool Contains(KnownDiSection valueKey)
        {
            var knownSectionValid = IsValidSection(valueKey);
            if (!knownSectionValid)
            {
                throw new InvalidEnumArgumentException("valueKey", (int)valueKey, typeof(KnownDiSection));
            }

            return ImplementedSections.Contains(valueKey);
        }
        #endregion

        #region [public] (int) IndexOf(KnownDiSection): Busca el objeto con la clave especificada y devuelve el índice de base cero de la primera aparición en toda la colección 'DiDataSectionCollection'.
        /// <summary>
        /// Busca el objeto con la clave especificada y devuelve el índice de base cero de la primera aparición en toda la colección <see cref="DiDataSectionCollection"/>.
        /// </summary>
        /// <param name="valueKey">Uno de los valores de <see cref="KnownDiSection"/> que representa la clave del objeto que se va a buscar en <see cref="DiDataSectionCollection"/>.</param>
        /// <returns>
        /// 	<para>Índice de base cero de la primera aparición de item en la totalidad de <see cref="DiDataSectionCollection"/>, si se encuentra; en caso contrario, <strong>-1</strong>.</para>
        /// </returns>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        public int IndexOf(KnownDiSection valueKey)
        {
            var knownSectionValid = IsValidSection(valueKey);
            if (!knownSectionValid)
            {
                throw new InvalidEnumArgumentException("valueKey", (int)valueKey, typeof(KnownDiSection));
            }

            var section = Sections.FirstOrDefault(item => (KnownDiSection) item.Key == valueKey);
            return IndexOf(section);

            #region Versión sin utilizar LINQ.
            //DataSection section = null;
            //foreach (var item in Sections)
            //{
            //    if ((KnownDiSection)item.Key == valueKey)
            //    {
            //        section = item;
            //        break;
            //    }
            //}

            //return IndexOf(section);
            #endregion
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (bool) IsValidSection(KnownDiSection): Determina si la clave especificada es una clave válida de la enumeración 'KnownDiSection'.
        /// <summary>
        /// Determina si la clave especificada es una clave válida de la enumeración <see cref="KnownDiSection"/>.
        /// </summary>
        /// <param name="value">Clave a comprobar.</param>
        /// <returns>
        /// 	<strong>true</strong> si el valor pertenece a la enumeración <see cref="KnownDiSection"/>; de lo contrario, es <strong>false</strong>.
        /// </returns>
        private static bool IsValidSection(KnownDiSection value)
        {
            return SentinelHelper.IsEnumValid(value); //ClientUtils.IsEnumValid((int)value, (int)KnownDiSection.Revision, (int)KnownDiSection.CheckSum));
        }
        #endregion

        #endregion
    }
}
