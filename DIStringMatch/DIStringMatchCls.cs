using System;

namespace DIStringMatch
{
    public class DIStringMatchCls
    {
        public int[] DiStringMatch(string S)
        {
            var count = S.Length;

            var result = new int[count + 1];

            var min = 0;
            var max = count;

            for (var i = 0; i < S.Length; i++)
            {
                if (S[i].Equals('I'))
                    result[i] = min++;
                else
                {
                    result[i] = max--;
                }
            }

            result[count] = min;

            return result;
        }      
    }
}
