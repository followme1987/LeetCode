using System.Collections.Generic;

namespace MovingAveragefromDataStream
{
    public class MovingAverage
    {
        private readonly int _size;
        private readonly Queue<int> q;

        private double _sum;

        /** Initialize your data structure here. */
        public MovingAverage(int size)
        {
            _size = size;
            q = new Queue<int>();
            _sum = 0;
        }

        public double Next(int val)
        {
            q.Enqueue(val);
            _sum += val;

            if (q.Count > _size) _sum -= q.Dequeue();

            return _sum / q.Count;
        }
    }
}