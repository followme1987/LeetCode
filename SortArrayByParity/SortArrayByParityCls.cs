using System.Collections.Generic;
using System.Linq;

namespace SortArrayByParity
{
    public class SortArrayByParityCls
    {
        public int[] SortArrayByParity(int[] A)
        {
            var result = new LinkedList<int>();


            foreach (var a in A)
            {
                var linkedListNode = a % 2 == 0 ? result.AddFirst(a) : result.AddLast(a);
            }

            return result.ToArray();
        }
    }
}