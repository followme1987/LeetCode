using System.Collections.Generic;

namespace NestedListWeightSum
{
    public interface NestedInteger
    {
        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();


        IList<NestedInteger> GetList();
    }

    public class NestedListWeightSum
    {
        private int level = 1;
        private int result;

        public int DepthSum(IList<NestedInteger> nestedList)
        {
            for (var i = 0; i < nestedList.Count; i++)
                if (nestedList[i].IsInteger())
                {
                    result += level * nestedList[i].GetInteger();
                }
                else
                {
                    level++;
                    DepthSum(nestedList[i].GetList());
                    level--;
                }

            return result;
        }
    }
}