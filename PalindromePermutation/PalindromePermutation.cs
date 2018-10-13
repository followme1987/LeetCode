using System.Collections.Generic;

namespace PalindromePermutation
{
    public class PalindromePermutation
    {
        public bool CanPermutePalindrome(string s)
        {
            var charArr = s.ToCharArray();
            var dic = new Dictionary<char, int>();

            foreach (var ch in charArr)
                if (dic.ContainsKey(ch))
                    dic[ch]++;
                else
                    dic[ch] = 1;

            var count = 0;
            foreach (var val in dic.Values)
            {
                if (val % 2 != 0) count++;

                if (count > 1)
                    return false;
            }

            return true;
        }
    }
}