// DESCRIPTION:
// You get an array of numbers, return the sum of all of the positives ones.
// Note: if there is nothing to sum, the sum is default to 0.

using System.Threading.Channels;

namespace Sum_of_positive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];
            int sum = 0;

            foreach (int num in numbers)
            {
                numbers[num] = random.Next(-100, 100);
                Console.Write($"{numbers[num]}, ");

                if (numbers[num] > 0) sum += numbers[num];
            }
            Console.WriteLine($"Sum is {sum}");
        }
    }
}