using System.Collections.Generic;

namespace ValidWordSquare
{
    public class ValidWordSquareCls
    {
        public bool ValidWordSquare(IList<string> words)
        {
            var matrix = new char[words.Count][];

            for (var i = 0; i < words.Count; i++)
            {
                var wordCharArr = words[i].ToCharArray();

                matrix[i] = wordCharArr;
            }

            for (var i = 0; i < matrix.Length; i++)
            for (var j = 0; j < matrix[i].Length; j++)
                if (j >= matrix.Length || i >= matrix[j].Length || !matrix[i][j].Equals(matrix[j][i]))
                    return false;

            return true;
        }
    }
}