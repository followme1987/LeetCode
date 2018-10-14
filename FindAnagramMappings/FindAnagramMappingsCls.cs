using System.Collections.Generic;
using System.Linq;

namespace FindAnagramMappings
{
    public class FindAnagramMappingsCls
    {
        public int[] AnagramMappings(int[] A, int[] B)
        {
            var result = new List<int>();
            var bList = B.ToList();

            for (var i = 0; i < A.Length; i++)
            for (var j = 0; j < B.Length; j++)
                if (A[i] == B[j])
                {
                    result.Add(j);
                    break;
                }

            return result.ToArray();
        }
    }
}