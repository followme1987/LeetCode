using System.Collections.Generic;

namespace IsomorphicStrings
{
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            var dic = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++)
                if (dic.ContainsKey(s[i]))
                {
                    if (!dic[s[i]].Equals(t[i]))
                        return false;
                }
                else if (dic.ContainsValue(t[i]))
                {
                    return false;
                }
                else
                {
                    dic.Add(s[i], t[i]);
                }


            return true;
        }
    }
}