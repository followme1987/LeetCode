namespace FlippingImage
{
    public class FlippingImage
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            for (var i = 0; i <= A.Length - 1; i++)
            {
                var x = 0;
                var y = A[i].Length - 1;

                if (A[i].Length % 2 != 0) A[i][y / 2] = 1 - A[i][y / 2];

                while (x < y)
                {
                    var temp = A[i][x];
                    A[i][x] = 1 - A[i][y];
                    A[i][y] = 1 - temp;


                    x++;
                    y--;
                }
            }

            return A;
        }
    }
}