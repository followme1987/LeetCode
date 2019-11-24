using System.Collections.Generic;
using System.Linq;

namespace SortArrayByParity
{
    public class SortArrayByParityCls
    {
        public int[] SortArrayByParity(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                return new int[] { };
            }
            var j = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    j++;
                    var temp = A[j];
                    A[j] = A[i];
                    A[i] = temp;

                }
            }
            return A;
            //var result = new LinkedList<int>();


            //foreach (var a in A)
            //{
            //    var linkedListNode = a % 2 == 0 ? result.AddFirst(a) : result.AddLast(a);
            //}

            //return result.ToArray();
        }
    }
}