// DESCRIPTION:
// Find the sum of all the multiples of 3 or 5 below chosen number

namespace Multiples_of_3_or_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) sum += i;
            }
            Console.WriteLine($"Sum is {sum}");
        }
    }
}