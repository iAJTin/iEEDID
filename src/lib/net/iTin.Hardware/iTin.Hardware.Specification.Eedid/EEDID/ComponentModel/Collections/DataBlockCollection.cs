﻿
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

using iTin.Core.Helpers;

namespace iTin.Hardware.Specification.Eedid;

/// <summary>
/// Represents a collection of <see cref="DataBlock"/> objects from the <see cref="EEDID"/> specification.
/// </summary>
public sealed class DataBlockCollection : IList<DataBlock>
{
    #region private members

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly EEDID _parent;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly bool _readOnly;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly IList<DataBlock> _blocks;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly ICollection<KnownDataBlock> _keys;

    #endregion

    #region constructor/s

    /// <summary>
    /// Initializes a new instance of the class <see cref="DataBlockCollection" /> specifying the available blocks untreated and if they are read only.
    /// </summary>
    /// <param name="parent">Available blocks untreated.</param>
    /// <param name="readOnly"><b>true</b> if the collection should be read-only; <b>false</b> otherwise.</param>
    internal DataBlockCollection(EEDID parent, bool readOnly)
    {
        _parent = parent;
        _readOnly = readOnly;
        _keys = _parent.BlockTable.Keys.ToList();
        _blocks = _parent.BlockTable.Select(blockDictionaryEntry => new DataBlock(blockDictionaryEntry)).ToList();

        SetParentToItemBlockCollection();
    }

    #endregion

    #region interfaces

    #region IEnumerable

    /// <inheritdoc />
    /// <summary>
    /// Devuelve un enumerador que recorre en iteración una colección.
    /// </summary>
    /// <returns>
    /// Objeto <see cref="T:System.Collections.IEnumerator" /> que se puede utilizar para recorrer en iteración la colección.
    /// </returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return _blocks.GetEnumerator();

        #region Version sin utilzar LINQ.
        //foreach (DataBlock obj in _blocks)
        //{
        //    yield return obj;
        //}
        #endregion
    }

    #endregion

    #region IList<DataBlock>

    /// <summary>
    /// Devuelve el índice del objeto <see cref="T:iTin.Hardware.Specification.Eedid.DataBlock" /> dentro de la colección.
    /// </summary>
    /// <param name="item">El item a buscar.</param>
    /// <returns>
    /// 	<para>Índice de base cero de la primera aparición de item en la totalidad de <see cref="T:iTin.Hardware.Specification.Eedid.DataBlockCollection" />, si se encuentra; en caso contrario, <b>-1</b>.</para>
    /// </returns>
    public int IndexOf(DataBlock item) => _blocks.IndexOf(item);

    /// <summary>
    /// Inserta un objeto <see cref="T:iTin.Hardware.Specification.Eedid.DataBlock" /> en la colección.
    /// </summary>
    /// <param name="index">Indice dónde se va insertar.</param>
    /// <param name="item">Item a insertar.</param>
    public void Insert(int index, DataBlock item)
    {
        if (_readOnly)
        {
            throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
        }

        _blocks.Insert(index, item);
    }

    /// <summary>
    /// Elimina el objeto <see cref="T:iTin.Hardware.Specification.Eedid.DataBlock" /> especificado de la colección.
    /// </summary>
    /// <param name="index">Índice del elemento a eliminar.</param>
    public void RemoveAt(int index)
    {
        if (_readOnly)
        {
            throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
        }
        _blocks.RemoveAt(index);
    }

    /// <summary>
    /// Obtiene o establece el objeto <see cref="T:iTin.Hardware.Specification.Eedid.DataBlock" /> especificado en el índice.
    /// </summary>
    /// <value>Índice del objeto</value>
    /// <returns>Objeto <see cref="T:iTin.Hardware.Specification.Eedid.DataBlock" /> especificado en el índice.</returns>
    /// <exception cref="T:System.NotSupportedException"> invalido</exception>
    public DataBlock this[int index]
    {
        get => _blocks[index];
        set
        {
            if (_readOnly)
            {
                throw new NotSupportedException();//enLocalizedMessages.DataBlockCollectionInsertReadOnly);
            }

            _blocks[index] = value;
        }
    }

    #endregion

    #region ICollection<DataBlock>

    /// <summary>
    /// Agregar un objeto <see cref="T:iTin.Hardware.Specification.Eedid.DataBlock" /> a la colección.
    /// </summary>
    /// <param name="item">Objeto <see cref="T:iTin.Hardware.Specification.Eedid.DataBlock" /> a agregar.</param>
    public void Add(DataBlock item)
    {
        if(_readOnly)
        {
            throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);               
        }

        _blocks.Add(item);
    }

    /// <summary>
    /// Quita todos los elementos de la colección.
    /// </summary>
    public void Clear()
    {
        if (_readOnly)
        {
            throw new NotSupportedException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
        }

        _blocks.Clear();
    }

    /// <summary>
    /// Determina si la colección contiene un objeto <see cref="T:iTin.Hardware.Specification.Eedid.DataBlock" /> específico.
    /// </summary>
    /// <param name="item">Objeto que se va a buscar en la colección.</param>
    /// <returns>
    /// 	<para><b>true</b> si el objeto <see cref="T:iTin.Hardware.Specification.Eedid.DataBlock" /> se encuentra en la colección; en caso contrario, <b>false</b>.</para>
    /// </returns>
    public bool Contains(DataBlock item) => _blocks.Contains(item);

    /// <summary>
    /// Copia los elementos a un objeto <see cref="T:System.Array" />, a partir de un índice determinado de la clase <see cref="T:System.Array" />.
    /// </summary>
    /// <param name="array"><see cref="T:System.Array" /> unidimensional que constituye el destino de los elementos copiados. Array debe tener una indización de base cero.</param>
    /// <param name="arrayIndex">Índice de base cero de array donde se comienza a copiar.</param>
    /// <exception cref="T:System.ArgumentNullException">El valor de <c>array</c> es null.</exception>
    public void CopyTo(DataBlock[] array, int arrayIndex)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        if (array.Length < arrayIndex + _blocks.Count)
        {
            throw new ArgumentException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly, "array");
        }

        for (int index = 0; index < _blocks.Count; index++)
        {
            array[index + arrayIndex] = _blocks[index];
        }
    }

    /// <summary>
    /// Obtiene el número de elementos incluidos en la colección.
    /// </summary>
    /// <value>
    /// 	<para>El número de elementos incluidos en la colección.</para>
    /// </value>
    public int Count => _blocks.Count;

    /// <summary>
    /// Obtiene un valor que indica si la colección es de sólo lectura.
    /// </summary>
    /// <value>
    /// 	<para>Tipo: <see cref="T:System.Boolean" /></para>
    /// 	<para><b>true</b> si la colección es de sólo lectura; en caso contrario, es <b>false</b>.</para>
    /// </value>
    public bool IsReadOnly => _readOnly;

    /// <summary>
    /// Quita la primera aparición de un objeto <see cref="T:iTin.Hardware.Specification.Eedid.DataBlock" /> específico de la colección.
    /// </summary>
    /// <param name="item">Objeto <see cref="T:iTin.Hardware.Specification.Eedid.DataBlock" /> que se va a quitar de la colección.</param>
    /// <returns>
    /// 	<para>Tipo: <see cref="T:System.Boolean" /></para>
    /// 	<para>
    ///       <b>true</b> si <c>item</c> se ha quitado correctamente de la colección; en caso contrario, es <b>false</b>.
    ///       Este método también devuelve <b>false</b> si no se encontró item en la colección.
    ///     </para>
    /// </returns>
    public bool Remove(DataBlock item)
    {
        if (_readOnly)
        {
            throw new InvalidOperationException(""); //enLocalizedMessages.DataBlockCollectionInsertReadOnly);
        }

        return _blocks.Remove(item);
    }

    #endregion

    #region IEnumerable<DataBlock>

    /// <inheritdoc />
    /// <summary>
    /// Devuelve un enumerador que recorre en iteración una colección.
    /// </summary>
    /// <returns>
    /// Objeto <see cref="T:System.Collections.IEnumerator" /> que se puede utilizar para recorrer en iteración la colección.
    /// </returns>
    public IEnumerator<DataBlock> GetEnumerator()
    {
        return _blocks.GetEnumerator();

        #region Version sin utilzar LINQ.
        //foreach (DataBlock obj in _blocks)
        //{
        //    yield return obj;
        //}
        #endregion
    }

    #endregion

    #endregion

    #region public properties

    /// <summary>
    /// Gets the element with the specified key.
    /// </summary>
    /// <value>
    /// A <see cref="DataBlock"/> element.
    /// </value>
    /// <remarks>
    /// If the element does not exist, <b>null</b> is returned.
    /// </remarks>
    /// <exception cref="InvalidEnumArgumentException">Specified block not exist</exception>
    public DataBlock this[KnownDataBlock valueKey]
    {
        get
        {
            var knownBlockValid = IsValidBlock(valueKey);
            if (!knownBlockValid)
            {
                throw new InvalidEnumArgumentException(nameof(valueKey), (int) valueKey, typeof (KnownDataBlock));
            }

            var blockIndex = IndexOf(valueKey);
            if (blockIndex != -1)
            {
                return this[blockIndex];
            }
            return null;
        }
    }

    /// <summary>
    /// Gets a list of the implemented blocks.
    /// </summary>
    /// <value>
    /// List of implemented blocks.
    /// </value>
    public ReadOnlyCollection<KnownDataBlock> ImplementedBlocks => _keys.ToList().AsReadOnly();

    /// <summary>
    /// Gets parent of this datablockcollection.
    /// </summary>
    /// <value>
    /// Parent of this instance.
    /// </value>
    public EEDID Parent => _parent;

    #endregion

    #region public methods

    /// <summary>
    /// Determines whether the element with the specified key is in the <see cref="DataBlockCollection"/> collection.
    /// </summary>
    /// <param name="valueKey">One of the <see cref="KnownDataBlock"/> values that represents the key of the <see cref="DataBlock"/> object to find.</param>
    /// <returns>
    /// <b>true</b> if the object <see cref="DataBlock"/> with the <c>valueKey</c> is in the collection <see cref="DataBlockCollection"/>; otherwise it is <b> false </b>.
    /// </returns>
    /// <exception cref="InvalidEnumArgumentException">Specified block is not valid.</exception>
    public bool Contains(KnownDataBlock valueKey)
    {
        var knownBlockValid = IsValidBlock(valueKey);
        if (!knownBlockValid)
        {
            throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(KnownDataBlock));
        }

        return _keys.Contains(valueKey);
    }

    /// <summary>
    /// Returns the index of the object with the specified key in the collection.
    /// </summary>
    /// <param name="valueKey">Uno de los valores de <see cref="KnownDataBlock"/> que representa la clave del objeto <see cref="DataBlock"/> que se va a buscar en <see cref="DataBlockCollection"/>.</param>
    /// <returns>
    /// Zero-based index of the first occurrence of item in the entire <see cref="DataBlockCollection"/>, if found; otherwise <b>-1</b>.
    /// </returns>
    /// <exception cref="InvalidEnumArgumentException">Specified block is not valid.</exception>
    public int IndexOf(KnownDataBlock valueKey)
    {
        var knownBlockValid = IsValidBlock(valueKey);
        if (!knownBlockValid)
        {
            throw new InvalidEnumArgumentException(nameof(valueKey), (int)valueKey, typeof(KnownDataBlock));
        }

        var block = _blocks.FirstOrDefault(item => item.Key == valueKey);

        return IndexOf(block);

        #region Version sin utilizar LINQ.
        //DataBlock block = null;
        //foreach (var item in _blocks)
        //{
        //    if (item.Key == valueKey)
        //    {
        //        block = item;
        //        break;
        //    }
        //}

        //return IndexOf(block);
        #endregion
    }

    #endregion

    #region public override methods

    /// <summary>
    /// Devuelve una cadena que representa al objeto <see cref="DataBlockCollection"/> actual.
    /// </summary>
    /// <returns>
    /// String representing the current <see cref="DataBlockCollection"/> object.
    /// </returns>
    /// <remarks>
    /// The <see cref="DataBlockCollection.ToString()"/> method returns a string that includes the number of available blocks.
    /// </remarks>   
    public override string ToString() => $"Count = {Count}";

    #endregion

    #region private static methods

    /// <summary>
    /// Determines if the specified key is a valid key from the <see cref="KnownDataBlock"/> enumeration.
    /// </summary>
    /// <param name="value">Key to check.</param>
    /// <returns>
    /// <b>true</b> if the value belongs to the enumeration <see cref="KnownDataBlock"/>; otherwise it is <b>false</b>.
    /// </returns>
    private static bool IsValidBlock(KnownDataBlock value) => SentinelHelper.IsEnumValid(value);

    #endregion

    #region private methods

    /// <summary>
    /// Set the parent to which each element belongs <see cref="DataBlock"/> with this <see cref="DataBlockCollection"/>.
    /// </summary>
    private void SetParentToItemBlockCollection()
    {
        foreach (var item in _blocks)
        {
            item.SetParent(this);
        }
    }

    #endregion
}
