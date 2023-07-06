// DESCRIPTION:
// Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.

namespace Even_or_Odd
{
    internal class Program
    {
        static string EvenOrOdd(int number) => number % 2 == 0 ? "Even" : "Odd";

        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number {number} is {EvenOrOdd(number)}");
        }
    }
}