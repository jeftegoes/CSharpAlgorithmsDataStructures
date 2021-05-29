namespace TimeComplexity
{
    public class ThreeSum
    {
        public static int Count(int[] a)
        {
            var n = a.Length;

            if (n == 0)
            {
                return n;
            }

            var counter = 0;

            for (var i = 0; i < n; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    for (var k = j + 1; k < n; k++)
                    {
                        if (a[i] + a[j] + a[k] == 0)
                        {
                            counter++;
                        }
                    }
                }
            }

            return counter;
        }
    }
}