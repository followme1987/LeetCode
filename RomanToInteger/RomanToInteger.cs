using System.Collections.Generic;

namespace RomanToInteger
{
    public class RomanToInteger
    {
        private readonly Dictionary<char, int> dic = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public int RomanToInt(string s)
        {
            var sum = 0;

            for (var i = 0; i < s.Length; i++)
                if (i < s.Length - 1 && s[i].Equals('I') && s[i + 1].Equals('V'))
                {
                    sum += 4;
                    i++;
                }

                else if (i < s.Length - 1 && s[i].Equals('I') && s[i + 1].Equals('X'))
                {
                    sum += 9;
                    i++;
                }

                else if (i < s.Length - 1 && s[i].Equals('X') && s[i + 1].Equals('L'))
                {
                    sum += 40;
                    i++;
                }
                else if (i < s.Length - 1 && s[i].Equals('X') && s[i + 1].Equals('C'))
                {
                    sum += 90;
                    i++;
                }
                else if (i < s.Length - 1 && s[i].Equals('C') && s[i + 1].Equals('D'))
                {
                    sum += 400;
                    i++;
                }
                else if (i < s.Length - 1 && s[i].Equals('C') && s[i + 1].Equals('M'))
                {
                    sum += 900;
                    i++;
                }
                else
                {
                    sum += dic[s[i]];
                }

            return sum;
        }
    }
}