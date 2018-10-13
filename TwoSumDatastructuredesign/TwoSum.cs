using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSumDatastructuredesign
{
    public class TwoSum
    {
        private readonly SortedDictionary<int, int> _dic;
        private int _max;
        private int _min;

        /** Initialize your data structure here. */
        public TwoSum()
        {
            _max = 0;
            _min = 0;
            _dic = new SortedDictionary<int, int>();
        }

        /** Add the number to an internal data structure.. */
        public void Add(int number)
        {
            if (_dic.ContainsKey(number))
                _dic[number]++;
            else
                _dic.Add(number, 1);
        }

        /** Find if there exists any pair of numbers which sum is equal to the value. */
        public bool Find(int value)
        {
            if (_dic.Count > 0 && (_dic.First().Key * 2 > value || _dic.Last().Key * 2 < value)) return false;
            foreach (var item in _dic)
            {
                if (item.Key > Math.Round((double) (value / 2), MidpointRounding.AwayFromZero)) break;

                var indexKey = value - item.Key;

                if (_dic.ContainsKey(indexKey))
                {
                    if (indexKey == item.Key)
                    {
                        if (item.Value > 1) return true;

                        continue;
                    }

                    return true;
                }
            }

            return false;
        }
    }
}