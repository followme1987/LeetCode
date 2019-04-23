using System;

namespace SquaresOfASortedArray
{
    public class SquaresOfASortedArrayCls
    {
        public int[] SortedSquares(int[] A)
        {
            for (var i = 0; i < A.Length; i++)
            {
                A[i] *= A[i];
            }

            Array.Sort(A);

            return A;
        }
    }
}
