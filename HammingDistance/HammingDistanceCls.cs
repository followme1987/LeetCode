namespace HammingDistance
{
    public class HammingDistanceCls
    {
        public int HammingDistance(int x, int y)
        {
            var val = x ^ y;
            var dist = 0;
            while (val != 0)
            {
                dist++;
                val &= val - 1;
            }

            return dist;
        }
    }
}