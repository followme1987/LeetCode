using System;

namespace MergeSortedArray
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //for (var i = m; i < m + n; i++) nums1[i] = nums2[i - m];
            //Array.Sort(nums1);

            var index = m + n - 1;

            if (m == 0 && n != 0)
            {
                nums1[0] = nums2[0];
            }
            while (n > 0)
            {
                if (m > 0 && nums2[n - 1] >= nums1[m - 1])
                {
                    nums1[index] = nums2[n - 1];
                    n--;

                }
                else
                {

                    if (m == 0)
                    {
                        nums1[index] = nums2[n - 1];
                        n--;

                    }
                    else
                    {
                        nums1[index] = nums1[m - 1];
                        m--;
                    }
                }

                index--;

            }

        }
    }
}