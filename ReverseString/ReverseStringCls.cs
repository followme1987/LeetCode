namespace ReverseString
{
    public class ReverseStringCls
    {
        public string ReverseString(string s)
        {
            var charArr = s.ToCharArray();
            var resultArr = new char[charArr.Length];
            var index = 0;
            for (var i = charArr.Length - 1; i >= 0; i--)
            {
                resultArr[index] = charArr[i];

                index++;
            }

            return new string(resultArr);
        }
    }
}