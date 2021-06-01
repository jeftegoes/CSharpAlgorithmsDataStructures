namespace BubbleSort
{
    public class AlgorithmBubbleSort
    {
        public static void Swap(int[] array, int i, int j)
        {
            var temp = 0;

            if (i == j)
                return;

            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void Sort(int[] array)
        {
            for (var partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for (var i = 0; i < partIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }
    }
}