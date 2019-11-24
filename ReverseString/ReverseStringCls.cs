namespace ReverseString
{
    public class ReverseStringCls
    {
        //public string ReverseString(string s)
        //{
        //    //var charArr = s.ToCharArray();
        //    //var resultArr = new char[charArr.Length];
        //    //var index = 0;
        //    //for (var i = charArr.Length - 1; i >= 0; i--)
        //    //{
        //    //    resultArr[index] = charArr[i];

        //    //    index++;
        //    //}

        //    //return new string(resultArr);
        //    var i = 0;
        //    var j = s.Length - 1;
        //    var result = new char[s.Length];
        //    while (i < j)
        //    {
        //        result[i] = s[j];
        //        result[j] = s[i];
        //        i++;
        //        j--;

        //    }
        //    if (s.Length % 2 != 0)
        //    {
        //        result[i] = s[i];
        //    }
        //    return new string(result);
        //}

        public void ReverseString(char[] s)
        {
            var i = 0;
            var j = s.Length - 1;
            while (i < j)
            {
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                i++;
                j--;
            }
        }
    }
}