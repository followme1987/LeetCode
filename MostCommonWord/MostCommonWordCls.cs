using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MostCommonWord
{
    public class MostCommonWordCls
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {    
            var subStrArr = paragraph.ToLower().Split(new []{' ', '!', '?', '\'', ',', ';', '.'}, StringSplitOptions.RemoveEmptyEntries);
            var dic = new Dictionary<string, int>();
            var set = new HashSet<string>(banned);
            var max = 0;
            var result = "";
            foreach (var subStr in subStrArr)
            {
                if (set.Contains(subStr))
                    continue;
                if (dic.ContainsKey(subStr))
                    dic[subStr]++;
                else
                    dic[subStr] = 1;

                if (dic[subStr] > max)
                {
                    max = dic[subStr];
                    result = subStr;
                }
            }

            
            return result;
        }
    }
}
