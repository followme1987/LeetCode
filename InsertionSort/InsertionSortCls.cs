namespace InsertionSort
{
    public class InsertionSortCls
    {
        public int[] Sort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var j = i - 1;

                var value = array[i];

                for (; j >= 0; j--)
                {
                    if (value < array[j])
                    {
                        array[j + 1] = array[j];
                    }
                    else
                    {
                        break;
                    }
                }

                array[j + 1] = value;
            }

            return array;
        }
    }
}
