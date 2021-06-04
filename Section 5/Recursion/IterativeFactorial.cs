namespace Recursion
{
    public class IterativeFactorial
    {
        public static int Calc(int number)
        {
            if (number == 0)
                return 1;

            var factorial = 1;

            for (var i = number; i > 1; i--)
            {
                factorial *= i;
            }
            
            return factorial;
        }
    }
}