// DESCRIPTION:
// Find the chosen number of adjacent digits in the chosen number of random digits that have the greatest product

namespace Largest_Product_in_a_Series
{
    internal class Program
    {
        static void GetLargestProduct(string number, int countOfMultiples, out long largest)
        {
            largest = 0;

            for (int i = 0; i < number.Length - countOfMultiples + 1; i++)
            {
                long temp = 1;

                for (int j = 0 + i; j < countOfMultiples + i; j++)
                {
                    int nowDigit = Convert.ToInt32(number[j]);
                    temp *= Convert.ToInt32(number[j]) - 48;
                }
                if (temp > largest) largest = temp;
            }
        }

        static string GenerateNumber(int countOfDigits)
        {
            Random random = new Random();
            string number = string.Empty;

            for (int i = 0; i < countOfDigits; i++)
            {
                number += random.Next(0, 10);
            }

            return number;
        }

        static void Main(string[] args)
        {
            long largest = 0;
            Console.Write("Enter the count of digits: ");
            int countOfDigits = Convert.ToInt32(Console.ReadLine());

            string number = GenerateNumber(countOfDigits);
            Console.WriteLine(number);

            Console.Write("Enter the count of multiples: ");
            int countOfMultiples = Convert.ToInt32(Console.ReadLine());

            GetLargestProduct(number, countOfMultiples, out largest);
            Console.WriteLine($"The largest product is {largest}");
        }
    }
}
