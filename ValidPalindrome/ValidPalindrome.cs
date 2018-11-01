using System.Text;

namespace ValidPalindrome
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
                return true;

          //  s = s.Replace(" ", "");

            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                if (!(s[left] >= 'a' && s[left] <= 'z') && !(s[left] >= 'A' && s[left] <= 'Z') && !(s[left] >= '0' && s[left] <= '9'))
                {                   
                    left++;
                    continue;
                }

                if (!(s[right] >= 'a' && s[right] <= 'z') && !(s[right] >= 'A' && s[right] <= 'Z') && !(s[right] >= '0' && s[right] <= '9'))
                {                
                    right--;
                    continue;
                }
                   
                if (!s[left].ToString().ToLower().Equals(s[right].ToString().ToLower()))
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
