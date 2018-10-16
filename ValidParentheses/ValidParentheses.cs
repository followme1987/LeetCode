using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    public class ValidParentheses
    {
        int resultValue = 0;

        public bool IsValid(string s)
        {
            //"[([]])"
            var dic = new Dictionary<char, int> {{'(', 1}, {'{', 2}, {'[', 3}, {')', -1}, {'}', -2}, {']', -3}};

            var charArr = s.ToCharArray();

            if (charArr.Length > 0 && dic[charArr[0]] < 0)
                return false;

           
            for (var i = 0; i < charArr.Length; i++)
            {
                resultValue += dic[charArr[i]];
                
                if (resultValue < 0)
                    return false;

                if (i > 0)
                {
                    //if (charArr[i] < 0 && charArr[i - 1] > 0 && charArr[i] + charArr[i - 1] == 0)
                    //{
                    //    var removeIndex = i - 1;
                    //    s = s.Remove(removeIndex).Remove(i);

                    //    IsValid(s);
                    //}

                    if (dic[charArr[i]] < 0 && dic[charArr[i - 1]] > 0 && dic[charArr[i]] + dic[charArr[i - 1]] != 0)
                    {
                        return false;
                    }
                    else if(dic[charArr[i]] < 0 && dic[charArr[i - 1]] > 0 && dic[charArr[i]] + dic[charArr[i - 1]] == 0)
                    {
                        var removeIndex = i - 1;
                        s = s.Remove(removeIndex).Remove(i);

                        IsValid(s);
                    }

                   
                }
              
            }

            return resultValue == 0;
        }
    }
}
