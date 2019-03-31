using System.Collections.Generic;

namespace ValidParentheses
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<int>();
            var dic = new Dictionary<char, char> { { ')', '(' }, { '}', '{' }, { ']', '[' } };

            if (s.Equals(""))
                return true;

            var charArr = s.ToCharArray();

            for (var i = 0; i < charArr.Length; i++)
            {
                if (dic.ContainsKey(charArr[i]))
                {
                    if (stack.Count == 0 || !stack.Pop().Equals(dic[charArr[i]]))
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(charArr[i]);
                }
            }

            return stack.Count == 0;
        }
    }
}