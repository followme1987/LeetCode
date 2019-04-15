using System.Collections.Generic;
using System.Linq;

namespace JewelsAndStones
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            var dic = new Dictionary<char, int>();

            foreach (var jewel in J)
            {
                if (!dic.ContainsKey(jewel))
                    dic.Add(jewel, 0);
            }

            foreach (var stone in S)
            {
                if (dic.ContainsKey(stone))
                {
                    dic[stone]++;
                }
            }

            var sum = 0;

            foreach (var d in dic)
            {
                sum += d.Value;
            }

            return sum;
        }
    }
}