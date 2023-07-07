// DESCRIPTION
// The largest prime factor of chosen number

namespace Largest_Prime_Factor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            long number = Convert.ToInt64(Console.ReadLine());
            long primeFactor = 2;
            Console.WriteLine("Prime factors: ");

            while (number != 1)
            {
                if (number % primeFactor == 0)
                {
                    number /= primeFactor;
                    Console.Write($"{primeFactor}, ");
                }
                else primeFactor++;
            }
            Console.WriteLine($"the largest prime factor is {primeFactor}");
        }
    }
}