using System.Collections.Generic;
using System.Text;

namespace UniqueMorseCodeWords
{
    public class UniqueMorseCodeWords
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] morseStr =
            {
                ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--",
                "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
            };
            var sourceDic = new Dictionary<byte, string>();
            var resultSet = new HashSet<string>();
            byte a = 97;
            foreach (var str in morseStr) sourceDic.Add(a++, str);
            foreach (var word in words)
            {
                var chArr = word.ToCharArray();
                var strBuilder = new StringBuilder();
                foreach (var ch in chArr)
                {
                    var chByte = (byte) ch;
                    var morse = sourceDic[chByte];
                    strBuilder = strBuilder.Append(morse);
                }

                resultSet.Add(strBuilder.ToString());
            }

            return resultSet.Count;
        }
    }
}