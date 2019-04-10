using System.Collections.Generic;

namespace GenerateParentheses
{
    public class GenerateParenthesesCls
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var resultList = new List<string>();

            if (n == 0)
                return resultList;

            Process(n, n, resultList, "");

            return resultList;
        }

        private static void Process(int notUsedLeft, int notUsedRight, ICollection<string> resultList, string resultString)
        {
            if (notUsedLeft > 0)
            {
                Process(notUsedLeft - 1, notUsedRight, resultList, resultString + "(");
            }

            if (notUsedRight > 0 && notUsedLeft < notUsedRight)
            {
                Process(notUsedLeft, notUsedRight - 1, resultList, resultString + ")");
            }


            if (notUsedLeft == 0 && notUsedRight == 0)
            {
                resultList.Add(resultString);
            }
        }
    }
}
