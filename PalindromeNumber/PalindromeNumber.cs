using System;
using System.Linq;

namespace PalindromeNumber
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {

            if (x < 0)
                return false;
            if (x < 10)
                return true;

            var str = x.ToString();
            var index = (str.Length + 1) / 2;
            var count = str.Length - index;
            var strArr = str.ToCharArray(index, count);

            Array.Reverse(strArr);

            var newStr = new string(strArr);
            str = new string(str.ToCharArray(), 0, count);
            return str.Equals(newStr);
        }
    }
}
