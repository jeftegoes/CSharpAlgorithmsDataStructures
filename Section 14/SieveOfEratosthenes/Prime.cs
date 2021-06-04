using System.Collections.Generic;

namespace SieveOfEratosthenes
{
    public class Prime
    {
        public static IEnumerable<int> Sieve(int max)
        {
            var composite = new bool[max + 1];

            for (var p = 2; p <= max; p++)
            {
                if (composite[p])
                    continue;

                yield return p;

                for (var i = p * p; i <= max; i += p)
                {
                    composite[i] = true;
                }
            }
        }
    }
}