using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayNumbers = new int[] { 23, 41, 25, 54, 18, 14 };

            AlgorithmBubbleSort.Sort(arrayNumbers);

            foreach (var nb in arrayNumbers)
            {
                Console.Write($"{ nb } ");
            }
        }
    }
}
