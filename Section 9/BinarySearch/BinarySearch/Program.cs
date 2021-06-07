using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 3, 4, 5, 13, 20, 25, 40, 42, 44, 53};

            Console.WriteLine(AlgorithmBinarySearch.BinarySearch(array, 13));
        }
    }
}
