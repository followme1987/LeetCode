using System.Linq;

namespace JewelsAndStones
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            var list = S.ToList();

            var arr = J.ToArray();

            var count = 0;

            foreach (var ch in arr)
            foreach (var item in list)
                if (ch.Equals(item))
                    count++;

            return count;
        }
    }
}