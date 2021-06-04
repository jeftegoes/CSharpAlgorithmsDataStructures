using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 10, 8, 14, 5, 12 };
            AlgorithmInsertionSort.Sort(array);
            AlgorithmInsertionSort.Print(array);
        }
    }
}
