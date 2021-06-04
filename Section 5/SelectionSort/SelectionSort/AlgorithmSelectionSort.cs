using System;

namespace SelectionSort
{
    public class AlgorithmSelectionSort
    {
        public static void PrintArray(int[] array)
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
            for (var partIndex = array.Length -1; partIndex > 0 ; partIndex--)
            {
                var largestAt = 0;
                for (var i = 1; i <= partIndex; i++)
                {
                    if (array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                }

                Swap(array, largestAt, partIndex);
            }
        }
    }
}