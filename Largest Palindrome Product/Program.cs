// DESCRIPTION
// Find the largest palindrome made from the product of chosen positive multiples

using System.ComponentModel.DataAnnotations;

namespace Largest_Palindrome_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of multiples: ");
            int multiple;
            while (true)
            {
                try
                {
                    multiple = Convert.ToInt32(Console.ReadLine());
                    if (multiple < 0)
                    {
                        throw new Exception("Number is less than 0");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}. Enter the number above 0");
                    continue;
                }
            }
            int product = 0;
            int largestPalindrome = 1;

            for (int num1 = 1; num1 <= multiple; num1++)
            {
                for (int num2 = 1; num2 <= multiple; num2++)
                {
                    product = num1 * num2;
                    int count = 0;
                    int i;

                    for (i = 0; i < product.ToString().Length / 2; i++)
                    {
                        if (product.ToString()[i] == product.ToString()[product.ToString().Length - i - 1])
                        {
                            count++;
                        }
                    }
                    if (count == i && product > largestPalindrome) largestPalindrome = product;
                }
            }
            Console.WriteLine($"The largest palindrome product is {largestPalindrome}");
        }
    }
}