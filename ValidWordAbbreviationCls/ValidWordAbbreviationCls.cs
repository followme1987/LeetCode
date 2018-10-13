using System.Text.RegularExpressions;

namespace ValidWordAbbreviation
{
    public class ValidWordAbbreviationCls
    {
        public bool ValidWordAbbreviation(string word, string abbr)
        {
            var numbers = Regex.Matches(abbr, @"(\d+)");

            foreach (var number in numbers)
            {
                var count = int.Parse(number.ToString());

                if (count == 0 || number.ToString().StartsWith("0") || count > word.Length)
                    return false;

                var replacement = "";

                for (var i = 0; i < count; i++) replacement += "-";

                abbr = abbr.Replace(number.ToString(), replacement);
            }

            if (word.Length != abbr.Length) return false;

            var wordArr = word.ToCharArray();
            var abbrArr = abbr.ToCharArray();

            for (var i = 0; i < abbrArr.Length; i++)
                if (!abbrArr[i].Equals('-'))
                    if (!abbrArr[i].Equals(wordArr[i]))
                        return false;

            return true;
        }
    }
}