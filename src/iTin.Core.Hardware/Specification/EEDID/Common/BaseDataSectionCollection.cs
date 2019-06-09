
namespace iTin.Core.Hardware.Specification.Eedid
{    
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;

    /// <summary>
    /// Clase base que representa una colección de objetos <see cref="DataSection"/> de un <see cref="DataBlock"/> de un <see cref="KnownDataBlock"/>.
    /// </summary>
    [CLSCompliant(true)]
    public abstract class BaseDataSectionCollection : IList<DataSection>
    {
        #region Declaraciones
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly bool _readOnly;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly DataBlock _parent;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] 
        private readonly ICollection<Enum> _keys;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] 
        private readonly IList<DataSection> _sections;
        #endregion

        #region Constructor/es

            #region [protected] BaseDataSectionCollection(DataBlock): Inicializa una nueva instancia de la clase especificando el bloque sin tratar y si es de sólo lectura.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="BaseDataSectionCollection"/> especificando el bloque sin tratar y si es de sólo lectura.
            /// </summary>
            /// <param name="parent">Datos de un bloque sin tratar.</param>
            /// <param name="readOnly"><strong>true</strong> si la colección debe ser de sólo lectura; <strong>false</strong> en caso contrario.</param>
            protected BaseDataSectionCollection(DataBlock parent, bool readOnly)
            {
                if (parent == null) { throw new ArgumentNullException("parent"); }

                _parent = parent;
                _readOnly = readOnly;
                _keys = parent.SectionTable.Keys.ToList();
                _sections = _parent.SectionTable.Select(sectionDictionaryEntry => new DataSection(sectionDictionaryEntry)).ToList();

                SetParentToItemSectionCollection();
            }
            #endregion

        #endregion

        #region Propiedades

            #region [public] (ReadOnlyCollection<Enum>) ImplementedSections: Obtiene una lista con las secciones implementadas.
            /// <summary>
            /// Obtiene una lista con las secciones implementadas.
            /// </summary>
            /// <value>Lista de secciones implementadas.</value>
            public ReadOnlyCollection<Enum> ImplementedSections
            {
                get { return _keys.ToList().AsReadOnly(); }
            }
            #endregion

            #region [public] (DataBlock) Block: Obtiene un valor que representa el objeto al que pertence esta colección.
            /// <summary>
            /// Obtiene un valor que representa el objeto <see cref="DataBlock"/> al que pertence esta colección <see cref="BaseDataSectionCollection"/>
            /// </summary>
            /// <value>
            /// 	<para>Tipo: <see cref="DataBlock"/></para>
            /// 	<para>Objeto <see cref="DataBlock"/> al que pertence este <see cref="BaseDataSectionCollection"/>.</para>
            /// </value>
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            public DataBlock Block
            {
                get { return _parent; }
            }
            #endregion

        #endregion

        #region Interfaces

            #region Miembros de IEnumerable.

                #region [IEnumerator] IEnumerable.GetEnumerator(): Devuelve un enumerador que recorre en iteración una colección.
                /// <summary>
                /// Devuelve un enumerador que recorre en iteración una colección.
                /// </summary>
                /// <returns>
                /// Objeto <see cref="T:System.Collections.IEnumerator"/> que se puede utilizar para recorrer en iteración la colección.
                /// </returns>
                IEnumerator IEnumerable.GetEnumerator()
                {
                    return _sections.GetEnumerator();

                    #region Version sin utilzar LINQ.
                    //foreach (var obj in _sections)
                    //{
                    //    yield return obj;
                    //}
                    #endregion
                }
                #endregion

            #endregion

            #region Miembros de IList<DataSection>

                #region [public] (int) IndexOf(DataSection): Devuelve el índice del objeto DataSection dentro de la colección.
                /// <summary>
                /// Devuelve el índice del objeto <see cref="DataSection"/> dentro de la colección.
                /// </summary>
                /// <param name="item">El item a buscar.</param>
                /// <returns>
                /// 	<para>Tipo: <see cref="T:System.Int32"/></para>
                /// 	<para>Índice de base cero de la primera aparición del item en la colección, si se encuentra; en caso contrario, <strong>-1</strong>.</para>
                /// </returns>
                public int IndexOf(DataSection item)
                {
                    return _sections.IndexOf(item);
                }
                #endregion

                #region [public] (void) Insert(int, DataSection): Inserta un objeto DataSection en la colección.
                /// <summary>
                /// Inserta un objeto <see cref="DataSection"/> en la colección.
                /// </summary>
                /// <param name="index">Indice dónde se va insertar.</param>
                /// <param name="item">Item a insertar.</param>
                public void Insert(int index, DataSection item)
                {
                    if (_readOnly)
                    {

                        //switch ( System.Globalization )
                        throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
                    }
                    _sections.Insert(index, item);
                }
                #endregion

                #region [public] (void) RemoveAt(int): Elimina el objeto DataSection especificado de la colección.
                /// <summary>
                /// Elimina el objeto <see cref="DataSection"/> especificado de la colección.
                /// </summary>
                /// <param name="index">Índice del elemento a eliminar.</param>
                public void RemoveAt(int index)
                {
                    if (_readOnly)
                    {
                        throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
            }
                    _sections.RemoveAt(index);
                }
                #endregion

                #region [public] (DataSection) this[int]: Obtiene o establece el objeto DataSection especificado en el índice.
                /// <summary>
                /// Obtiene o establece el objeto <see cref="DataSection"/> especificado en el índice.
                /// </summary>
                /// <value>Índice del objeto</value>
                /// <returns>Objeto <see cref="DataSection"/> especificado en el índice.</returns>
                public DataSection this[int index]
                {
                    get
                    {
                        return _sections[index];
                    }
                    set
                    {
                        if (_readOnly)
                        {
                            throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
                }

                        _sections[index] = value;
                    }
                }
                #endregion

            #endregion

            #region Miembros de ICollection<DataSection>.

                /// <summary>
                /// Adds the specified item.
                /// </summary>
                /// <param name="item">The item.</param>
                public void Add(DataSection item)
                {
                    if (_readOnly)
                    {
                        throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
            }
                    _sections.Add(item);
                }

                /// <summary>
                /// Clears this instance.
                /// </summary>
                public void Clear()
                {
                    if (_readOnly)
                    {
                        throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
            }
                    _sections.Clear();
                }

                /// <summary>
                /// Determines whether [contains] [the specified item].
                /// </summary>
                /// <param name="item">The item.</param>
                /// <returns>
                /// 	<c>true</c> if [contains] [the specified item]; otherwise, <c>false</c>.
                /// </returns>
                public bool Contains(DataSection item)
                {
                    return _sections.Contains(item);
                }

                /// <summary>
                /// Copies to.
                /// </summary>
                /// <param name="array">The array.</param>
                /// <param name="arrayIndex">Index of the array.</param>
                public void CopyTo(DataSection[] array, int arrayIndex)
                {
                    if (array == null) { throw new ArgumentNullException("array"); }
                    if (array.Length < arrayIndex + _sections.Count)
                    {
                        throw new ArgumentException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly, "array");
            }

                    for (int index = 0; index < _sections.Count; index++)
                    {
                        array[index + arrayIndex] = _sections[index];
                    }
                }

                /// <summary>
                /// Gets the count.
                /// </summary>
                /// <value>The count.</value>
                public int Count
                {
                    get { return _sections.Count; }
                }

                /// <summary>
                /// Gets a value indicating whether this instance is read only.
                /// </summary>
                /// <value>
                /// 	<c>true</c> if this instance is read only; otherwise, <c>false</c>.
                /// </value>
                public bool IsReadOnly
                {
                    get { return _readOnly; }
                }

                /// <summary>
                /// Removes the specified item.
                /// </summary>
                /// <param name="item">The item.</param>
                /// <returns></returns>
                public bool Remove(DataSection item)
                {
                    if (_readOnly)
                    {
                        throw new InvalidOperationException("");//enLocalizedMessages.DataBlockCollectionInsertReadOnly);
                    }
                    return _sections.Remove(item);
                }

            #endregion

            #region Miembros de IEnumerable<DataSection>.

                #region [public] (IEnumerator<DataSection>) GetEnumerator(): Devuelve un enumerador que recorre en iteración una colección.
                /// <summary>
                /// Devuelve un enumerador que recorre en iteración una colección.
                /// </summary>
                /// <returns>
                /// Objeto <see cref="T:System.Collections.IEnumerator"/> que se puede utilizar para recorrer en iteración la colección.
                /// </returns>
                public IEnumerator<DataSection> GetEnumerator()
                {
                    return _sections.GetEnumerator();

                    #region Version sin utilzar LINQ.
                    //foreach (var obj in _sections)
                    //{
                    //    yield return obj;
                    //}
                    #endregion
                }
                #endregion

            #endregion

        #endregion

        #region Miembros protegidos

            #region Propiedades.

                #region [protected] (IList<DataSection>) Sections: Obtiene un valor que representa la lista de secciones.
                /// <summary>
                /// Obtiene un valor que representa la lista de secciones.
                /// </summary>
                /// <value>Lista de claves disponibles.</value>
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                protected IList<DataSection> Sections
                {
                    get { return _sections; }
                }
                #endregion

            #endregion
        
        #endregion

        #region Miembros privados

            #region [private] (void) SetParentToItemSectionCollection(): Establece el padre al que pertenece cada elemento de esta colección.
            /// <summary>
            /// Establece el padre al que pertenece cada elemento <see cref="DataSection"/> de esta colección.
            /// </summary>
            private void SetParentToItemSectionCollection()
            {
                foreach (var item in _sections)
                {
                    item.SetParent(this);
                }
            }
            #endregion

        #endregion
    }
}