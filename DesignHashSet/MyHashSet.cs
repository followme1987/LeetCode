using System.Collections.Generic;

namespace DesignHashSet
{
    public class MyHashSet
    {
        private readonly IList<int> _list;

        /** Initialize your data structure here. */
        public MyHashSet()
        {
            _list = new List<int>();
        }

        public void Add(int key)
        {
            if (!_list.Contains(key)) _list.Add(key);
        }

        public void Remove(int key)
        {
            if (_list.Contains(key)) _list.Remove(key);
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            return _list.Contains(key);
        }
    }
}