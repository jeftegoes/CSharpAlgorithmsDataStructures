using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 10, 8, 14, 5, 12 };
            
            AlgorithmSelectionSort.Sort(array);
            AlgorithmSelectionSort.PrintArray(array);
        }
    }
}
