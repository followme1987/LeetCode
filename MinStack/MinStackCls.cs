using System;

namespace MinStack
{
    public class MinStackCls
    {
        private int[] _stackArray;

        private int writeIndex;

        /** initialize your data structure here. */
        public MinStackCls()
        {
            _stackArray = new int[10];
        }

        public void Push(int x)
        {
            if (writeIndex == _stackArray.Length)
            {
                var extended = new int[_stackArray.Length + _stackArray.Length / 2];
                Array.Copy(_stackArray, extended, _stackArray.Length);
                _stackArray = extended;
            }

            _stackArray[writeIndex] = x;
            writeIndex++;
        }

        public void Pop()
        {
            if (writeIndex > 0)
                writeIndex--;
        }

        public int Top()
        {
            if (writeIndex > 0)
                return _stackArray[writeIndex - 1];
            return _stackArray[0];
        }

        public int GetMin()
        {
            if (writeIndex == 0)
                return _stackArray[0];

            var min = int.MaxValue;
            for (var i = 0; i <= writeIndex - 1; i++) min = Math.Min(_stackArray[i], min);

            return min;
        }
    }
}