using System;
using System.Collections.Generic;

namespace FloodFill
{
    public class FloodFillCls
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (newColor == image[sr][sc])
                return image;

            Fill(image, sr, sc, newColor, image[sr][sc]);

            return image;
        }

        private void Fill(int[][] image, int sr, int sc, int newColor, int startPointColor)
        {
            if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[0].Length || image[sr][sc] != startPointColor)
            {
                return;
            }
            image[sr][sc] = newColor;

            Fill(image, sr - 1, sc, newColor, startPointColor);
            Fill(image, sr + 1, sc, newColor, startPointColor);
            Fill(image, sr, sc + 1, newColor, startPointColor);
            Fill(image, sr, sc - 1, newColor, startPointColor);
        }
    }
}
