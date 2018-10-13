namespace TransposeMatrix
{
    public class TransposeMatrix
    {
        public int[][] Transpose(int[][] A)
        {
            var count = A[0].Length;

            var result = new int[count][];

            for (var i = 0; i < count; i++)
            {
                result[i] = new int[A.Length];

                var newRow = new int[A.Length];

                for (var j = 0; j < A.Length; j++)
                    //better performance than result[i][j] = A[j][i]
                    newRow[j] = A[j][i];

                result[i] = newRow;
            }

            return result;
        }
    }
}