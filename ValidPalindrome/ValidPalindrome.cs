using System;
using System.Collections.Generic;

namespace ValidPalindrome
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
                return true;

         
            s = s.Replace(" ", "");

            var strList = new List<char>();
            for (var i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 97 && s[i] <= 122) || (s[i] >= 65 && s[i] <= 90))
                {
                    strList.Add(s[i]);
                }
            }

            var left = 0;
            var right = 0;
            if (strList.Count % 2 != 0)
            {
                var midIndex = strList.Count / 2;

                left = midIndex - 1;
                right = midIndex + 1;
               
            }
            else
            {
                left = strList.Count / 2 - 1;
                right = strList.Count / 2;
          
            }

            while (left >= 0 && right <= strList.Count - 1)
            { 
                if (!strList[left].ToString().ToLower().Equals(strList[right].ToString().ToLower()))
                    return false;

                left--;
                right++;
            }

            return true;
        }
    }
}
