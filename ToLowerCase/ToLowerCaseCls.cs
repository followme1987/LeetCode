using System.Text;

namespace ToLowerCase
{
    public class ToLowerCaseCls
    {
        public string ToLowerCase(string str)
        {
            var chArr = str.ToCharArray();
            var strB = new StringBuilder();
            foreach (var ch in chArr)
                if (ch >= 65 && ch <= 90)
                    strB = strB.Append((char)(ch + 32));
                else
                    strB = strB.Append(ch);

            return strB.ToString();
        }
    }
}