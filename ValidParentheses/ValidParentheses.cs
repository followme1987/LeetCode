using System.Collections.Generic;

namespace ValidParentheses
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<int>();
            var dic = new Dictionary<char, int> {{'(', 1}, {'{', 2}, {'[', 3}, {')', -1}, {'}', -2}, {']', -3}};

            if (s.Equals(""))
                return true;

            var charArr = s.ToCharArray();

            for (var i = 0; i < charArr.Length; i++)
                if (dic[charArr[i]] > 0)
                {
                    stack.Push(dic[charArr[i]]);
                }
                else
                {
                    if (stack.Count == 0 || dic[charArr[i]] + stack.Pop() != 0)
                        return false;
                }

            return stack.Count == 0;
        }
    }
}