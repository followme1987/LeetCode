using System.Collections.Generic;

namespace SetMatrixZeroes
{
    public class SetMatrixZeroesCls
    {
        public void SetZeroes(int[][] matrix)
        {
            var rowSet = new HashSet<int>();

            var columnSet = new HashSet<int>();

            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rowSet.Add(i);

                        columnSet.Add(j);
                    }
                }
            }

            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[0].Length; j++)
                {
                    if (rowSet.Contains(i) || columnSet.Contains(j))
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
    }
}
