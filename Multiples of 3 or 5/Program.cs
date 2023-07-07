// DESCRIPTION:
// Find the sum of all the multiples of 3 or 5 below 1000

namespace Multiples_of_3_or_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}