using System.Collections.Generic;

namespace LongestCommonPrefix
{
    public class LongestCommonPrefixCls
    {
        public string LongestCommonPrefix(string[] strs)
        {

            var min = 0;
            while (strs.Length > 0)
            {
                foreach (var str in strs)
                {
                    if (str.Length == min || str[min] != strs[0][min]) return strs[0].Substring(0, min);
                }
                min++;
            }
            return "";
        }
    }
}