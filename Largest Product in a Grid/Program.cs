// DESCRIPTION:
// Find the four adjacent digits in the grid that have the greatest product

using System.Numerics;

namespace Largest_Product_in_a_Grid
{
    internal class Program
    {
        static int SearchingTheLargestProduct(int[,] numbers)
        {
            int max = 0;

            int maxHor = SearchingHorizontal(numbers);
            int maxVert = SearchingVertical(numbers);
            int maxDiag = SearchingDiagonal(numbers);

            if (max < maxHor) max = maxHor;
            if (max < maxVert) max = maxVert;
            if (max < maxDiag) max = maxDiag;

            return max;
        }

        static int SearchingDiagonalLeftToRight(int[,] numbers)
        {
            int largest = 0;

            for (int vert = 0; vert < numbers.Length / 20 - 3; vert++)
            {
                for (int hor = 0; hor < numbers.Length / 20 - 3; hor++)
                {
                    int temp = 1;
                    int count = 0;
                    while (count < 4)
                    {
                        temp *= numbers[vert + count, hor + count];
                        count++;
                    }
                    if (temp > largest) largest = temp;
                }
            }
            return largest;
        }

        static int SearchingDiagonalRightToLeft(int[,] numbers)
        {
            int largest = 0;

            for (int vert = 0; vert < numbers.Length / 20 - 3; vert++)
            {
                for (int hor = 19; hor > 2; hor--)
                {
                    int temp = 1;
                    int count = 0;
                    while (count < 4)
                    {
                        temp *= numbers[vert + count, hor - count];
                        count++;
                    }
                    if (temp > largest) largest = temp;
                }
            }
            return largest;
        }

        static int SearchingDiagonal(int[,] numbers)
        {
            int largestLeftToRight = SearchingDiagonalLeftToRight(numbers);
            int largestRightToLeft = SearchingDiagonalRightToLeft(numbers);

            int largest = largestLeftToRight > largestRightToLeft ? largestLeftToRight : largestRightToLeft;

            return largest;
        }

        static int SearchingVertical(int[,] numbers)
        {
            int largest = 0;

            for (int hor = 0; hor < numbers.Length / 20; hor++)
            {
                for (int shift = 0; shift < 17; shift++)
                {
                    int temp = 1;

                    for (int vert = 0 + shift; vert < 4 + shift; vert++)
                    {
                        temp *= numbers[vert, hor];
                    }
                    if (temp > largest) largest = temp;
                }
            }
            return largest;
        }

        static int SearchingHorizontal(int[,] numbers)
        {
            int largest = 0;

            for (int vert = 0; vert < numbers.Length / 20; vert++)
            {
                for (int shift = 0; shift < 17; shift++)
                {
                    int temp = 1;

                    for (int hor = 0 + shift; hor < 4 + shift; hor++)
                    {
                        temp *= numbers[vert, hor];
                    }
                    if (temp > largest)
                    {
                        largest = temp;
                    }
                }
            }
            return largest;
        }

        static void PrintingTheGrid(int number, int hor, int length)
        {
            if (hor == length - 1)
            {
                if (number < 10) Console.WriteLine($"0{number}");
                else Console.WriteLine(number);
            }
            else
            {
                if (number < 10) Console.Write($"0{number} ");
                else Console.Write($"{number} ");
            }
        }

        static void Main(string[] args)
        {
            int[,] numbers = new int[20, 20];
            Random random = new Random();
            int vert = 0;
            int hor = 0;

            for (vert = 0; vert < numbers.Length / 20; vert++)
            {
                for (hor = 0; hor < numbers.Length / 20; hor++)
                {
                    numbers[vert, hor] = random.Next(0, 100);
                    PrintingTheGrid(numbers[vert, hor], hor, numbers.Length / 20);
                }
            }
            int max = SearchingTheLargestProduct(numbers);
            Console.WriteLine($"The largest is {max}");
        }
    }
}
