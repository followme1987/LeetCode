using System;
using System.Collections.Generic;

namespace ValidAnagram
{
    public class ValidAnagramCls
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            var dic = new Dictionary<char, int>();
            var dic1 = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic[item] = 1;
                }
            }

            foreach (var item in t)
            {
                if (!dic.ContainsKey(item))
                {
                    return false;
                }
                if (dic1.ContainsKey(item))
                {
                    if (++dic1[item] > dic[item])
                    {
                        return false;
                    }
                }
                else
                {
                    dic1[item] = 1;
                }
            }

            return true;
        }
    }
}
