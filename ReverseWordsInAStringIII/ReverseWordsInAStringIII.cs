using System;
using System.Data;
using System.Linq;
using System.Text;

namespace ReverseWordsInAStringIII
{
    public class ReverseWordsInAStringIII
    {
        public string ReverseWords(string s)
        {
            var subString = s.Split(' ');
            var resultStr = new StringBuilder();

            foreach (var str in subString)
            {
                var charArr = str.ToCharArray();

                var resultArr = new char[charArr.Length];

                var index = 0;

                for (var i = charArr.Length - 1; i >= 0; i--)
                {
                    resultArr[index] = charArr[i];
                    index++;
                }

                resultStr = resultStr.Append(new string(resultArr) + " ");
            }

            return resultStr.ToString().Trim();
        }
    }
}
