using System;
using System.Collections.Generic;

namespace GroupAnagrams
{
    public class GroupAnagramsCls
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            int[] prime = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103 };

            var resultList = new List<IList<string>>();

            var dic = new Dictionary<int, int>();

            foreach(var str in strs)
            {
                var key = 1;

                for(var i = 0; i < str.Length; i++)
                {
                    key *= prime[str[i] - 'a'];
                }

                List<string> list;

                if(dic.ContainsKey(key))
                {
                    resultList[dic[key]].Add(str);
                }
                else
                {
                    list = new List<string>
                    {
                        str
                    };

                    resultList.Add(list);

                    dic.Add(key, resultList.Count - 1);
                }
            }

            return resultList;
        }
    }
}
