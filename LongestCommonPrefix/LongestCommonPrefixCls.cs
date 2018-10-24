using System.Collections.Generic;

namespace LongestCommonPrefix
{
    public class LongestCommonPrefixCls
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";
            var firstStrCharArr = strs[0].ToCharArray();
            var resultCharList = new List<char>();

            for (var i = 0; i < firstStrCharArr.Length; i++)
            {
                var c = firstStrCharArr[i];

                for (var j = 1; j < strs.Length; j++)
                    if (i >= strs[j].Length || strs[j][i] != c)
                    {
                        if (resultCharList.Count == 0)
                            return "";
                        return new string(resultCharList.ToArray());
                    }

                resultCharList.Add(c);
            }

            return new string(resultCharList.ToArray());
        }
    }
}