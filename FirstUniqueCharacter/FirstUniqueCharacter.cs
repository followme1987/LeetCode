using System.Collections.Generic;

namespace FirstUniqueCharacter
{
    public class FirstUniqueCharacter
    {
        public int FirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;
            var dic = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++)
                if (dic.ContainsKey(s[i]))
                    dic[s[i]]++;
                else
                    dic[s[i]] = 1;

            foreach (var d in dic)
                if (d.Value == 1)
                    return s.IndexOf(d.Key);

            return -1;
        }
    }
}