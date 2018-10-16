namespace StringCompression
{
    public class StringCompression
    {
        public int Compress(char[] chars)
        {
            var index = 0;
            var count = 1;

            for (var i = 1; i < chars.Length; i++)
                if (chars[i].Equals(chars[index]))
                {
                    count++;
                }
                else
                {
                    if (count > 1)
                    {
                        var countArr = count.ToString().ToCharArray();

                        for (var j = 1; j <= countArr.Length; j++) chars[index + j] = countArr[j - 1];

                        index += countArr.Length;
                        chars[++index] = chars[i];
                        count = 1;
                    }
                    else
                    {
                        index++;
                        chars[index] = chars[i];
                    }
                }

            if (count > 1)
            {
                var countArr = count.ToString().ToCharArray();
                for (var j = 1; j <= countArr.Length; j++) chars[index + j] = countArr[j - 1];

                index += countArr.Length;
            }

            return ++index;
        }
    }
}