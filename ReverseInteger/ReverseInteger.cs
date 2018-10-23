using System;

namespace ReverseInteger
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            if (x <= int.MinValue || x >= int.MaxValue)
                return 0;

            var y = Math.Abs(x);

            var intCharArr = y.ToString().ToCharArray();

            var startIndex = 0;
            var endIndex = intCharArr.Length - 1;

            while (endIndex >= startIndex)
            {
                var temp = intCharArr[endIndex];
                intCharArr[endIndex] = intCharArr[startIndex];
                intCharArr[startIndex] = temp;

                endIndex--;
                startIndex++;
            }

            var resultString = new string(intCharArr);

            if (int.TryParse(resultString, out var resultInt)) return x < 0 ? 0 - resultInt : resultInt;

            return 0;
        }
    }
}