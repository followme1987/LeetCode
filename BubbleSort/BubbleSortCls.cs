namespace BubbleSort
{
    public class BubbleSortCls
    {
        public int[] Sort(int[] array)
        {
            var arrayLength = array.Length;

            for (var i = 0; i < arrayLength; i++)
            {
                //if there is a swap happened
                var flag = false;

                for (var j = 0; j < arrayLength - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        flag = true;
                    }
                }

                if (!flag)
                    break;
            }

            return array;
        }
    }
}
