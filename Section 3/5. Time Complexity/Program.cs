using System;
using System.Diagnostics;
using System.Linq;

namespace TimeComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = In.ReadIntsAsync("Data/4Kints.txt").ToArray();

            if (ints.Length == 0) {
                return;
            }

            var watch = new Stopwatch();
            watch.Start();

            var triplets = ThreeSum.Count(ints);

            watch.Stop();

            Console.WriteLine($"The number of \"Zero-sum\" triplets: { triplets }");
            Console.WriteLine($"Time taken: { watch.Elapsed }");
        }
    }
}
