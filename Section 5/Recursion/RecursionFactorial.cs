namespace Recursion
{
    public class RecursionFactorial
    {
        public static int Calc(int n)
        {
            if (n == 0)
                return 1;

            var factorial = n * Calc(n - 1);

            return factorial;
        }
    }
}