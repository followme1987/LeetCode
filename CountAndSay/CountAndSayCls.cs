namespace CountAndSay
{
    public class CountAndSayCls
    {
        public string CountAndSay(int n)
        {
            if (n == 1)
                return "1";

            var str = new string("1");
            var temp = "";
            var index = 2;

            while (index <= n)
            {
                var charArr = str.ToCharArray();
                var count = 0;
                var i = 0;
                var j = 0;
                while (j < charArr.Length)
                    if (charArr[j] == charArr[i])
                    {
                        count++;
                        j++;
                    }

                    else
                    {
                        temp += count + charArr[i].ToString();
                        count = 0;
                        i = j;
                    }

                temp += count + charArr[i].ToString();

                str = temp;
                temp = "";
                index++;
            }

            return str;
        }
    }
}