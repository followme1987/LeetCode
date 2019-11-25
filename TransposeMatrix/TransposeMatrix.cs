namespace TransposeMatrix
{
    public class TransposeMatrix
    {
        public int[][] Transpose(int[][] A)
        {
            int[][] b = new int[A[0].Length][];
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (i == 0)
                    {
                        b[j] = new int[A.Length];
                    }
                    b[j][i] = A[i][j];
                }
            }
            return b;
        }
    }
}