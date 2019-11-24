using System;

namespace SquaresOfASortedArray
{
    public class SquaresOfASortedArrayCls
    {
        public int[] SortedSquares(int[] A)
        {
            var result = new int[A.Length];

            int i = 0, j = A.Length - 1;

            var current = A.Length - 1;

            while (current >= 0)
            {
                if (Math.Pow(A[j], 2) > Math.Pow(A[i], 2))
                {
                    result[current] = A[j] * A[j];
                    j--;
                }
                else
                {
                    result[current] = A[i] * A[i];
                    i++;
                }

                current--;
            }
            return result;
        }
    }
}
