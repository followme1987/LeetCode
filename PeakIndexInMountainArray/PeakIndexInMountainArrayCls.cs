namespace PeakIndexInMountainArray
{
    public class PeakIndexInMountainArrayCls
    {
        public int PeakIndexInMountainArray(int[] A)
        {
            for (var i = 0; i < A.Length; i++)
                if (A[i] > A[i + 1])
                    return i;

            return 0;
        }
    }
}