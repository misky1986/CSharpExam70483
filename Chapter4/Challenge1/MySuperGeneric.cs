using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Chapter4.Challenge1
{
    public class MySuperGeneric<T> : IList<T>
    {
        private readonly IList<T> _mySuperGenericList = new List<T>();

        #region Implementation of IEnumerable<T>           
        public IEnumerator<T> GetEnumerator()
        {
            foreach(var item in _mySuperGenericList)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion

        #region Implementation of ICollection<T>      

        public int Count
        {
            get { return this._mySuperGenericList.Count; }
        }

        public bool IsReadOnly
        {
            get { return this._mySuperGenericList.IsReadOnly; }
        }

        public void Add(T data)
        {
            this._mySuperGenericList.Add(data);
        }

        public void Clear()
        {
            this._mySuperGenericList.Clear();
        }

        public bool Contains(T item)
        {
            return this._mySuperGenericList.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this._mySuperGenericList.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return this._mySuperGenericList.Remove(item);
        }
        #endregion

        #region Implementation of IList<T>

        public T this[int index]
        {
            get { return this._mySuperGenericList[index]; }
            set { this._mySuperGenericList[index] = value; }
        }

        public int IndexOf(T item)
        {
            return this._mySuperGenericList.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            this._mySuperGenericList.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            this._mySuperGenericList.RemoveAt(index);
        }
        
        #endregion
    }
}
