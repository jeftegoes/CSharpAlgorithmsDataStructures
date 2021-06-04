using System;

namespace InsertionSort
{
    public class AlgorithmInsertionSort
    {
        public static void Print(int[] array)
        {
            foreach (var number in array)
            {
                Console.Write($"{ number } ");
            }
        }

        public static void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;

            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void Sort(int[] array)
        {

            for (var partIndex = 1; partIndex < array.Length; partIndex++)
            {
                var curUnsorted = array[partIndex];

                var i = 0;

                for (i = partIndex; i > 0 && array[i - 1] > curUnsorted; i--)
                {
                    array[i] = array[i - 1];
                }

                array[i] = curUnsorted;
            }
        }
    }
}