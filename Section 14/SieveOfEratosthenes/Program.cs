using System;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var number in Prime.Sieve(30))
            {
                Console.WriteLine(number);
            }
        }
    }
}
