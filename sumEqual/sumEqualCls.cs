using System;

namespace SumEqual
{
    public class SumEqualCls
    {
        public int GetSumEqual(int[] input)
        {
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 1; i < input.Length; i++)
            {
                sumRight += input[i];
            }

            for (int i = 0, j = 1; j < input.Length; i++, j++)
            {
                sumLeft += input[i];
                sumRight -= input[j];
                if (sumLeft == sumRight)
                {
                    return input[i + 1];
                }
            }
            return -1;
        }
    }
}
