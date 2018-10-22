using System.Collections.Generic;


namespace MergeSortedArray
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            var queue = new System.Collections.Generic.Queue<int>();
            var index = 0;
            for (var i = 0; i < m + n; i++)
            {

                if (index < n)
                {
                    //第二数组当前值小于第一数组当前值
                    if (nums2[index] < nums1[i])
                    {
                        //如果queue不为空 并且queue值小于第二数组值，则写入queue 值 hold on 当前数组值
                        if (queue.Count > 0 && nums2[index] >= queue.Peek())
                        {
                            queue.Enqueue(nums1[i]);
                            nums1[i] = queue.Dequeue();
                        }
                        else
                        {
                            queue.Enqueue(nums1[i]);
                            nums1[i] = nums2[index];
                            index++;
                        }
                    }
                    else
                    {
                        if (i >= m)
                        {

                            if (queue.Count > 0)
                            {
                                if (queue.Peek() < nums2[index])
                                {
                                    nums1[i] = queue.Dequeue();
                                }
                                else
                                {
                                    nums1[i] = nums2[index];
                                    index++;
                                }

                            }
                            else
                            {
                                nums1[i] = nums2[index];
                                index++;
                            }
                        }
                        else
                        {
                            
                        }
                    }

                }
                else
                {
                    if (queue.Count > 0)
                    {
                        if (queue.Peek() < nums1[i])
                        {
                            queue.Enqueue(nums1[i]);
                            nums1[i] = queue.Dequeue();

                        }
                        else
                        {
                            nums1[i] = queue.Dequeue();
                        }


                    }
                }
            }
        }
    }
}
