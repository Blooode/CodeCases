// DESCRIPTION:
// Change value and color for a random number in the matrix.

namespace ConsoleTest
{
    internal class Program
    {
        static int count = 0;

        static void PrintMatrix(ref List<Number> matrix, Cursor cursor, int rowsAmount, int columnsAmount)
        {
            Console.Clear();
            Console.CursorTop = cursor.PosY;
            for (int i = 0; i < rowsAmount; i++)
            {
                Console.CursorLeft = cursor.PosX;

                for (int j = 0; j < columnsAmount; j++)
                {
                    Console.ForegroundColor = matrix[(columnsAmount - 1) * i + j + i].Color;
                    Console.Write($"{matrix[(columnsAmount - 1) * i + j + i].Value} ");
                }
                Console.WriteLine();
            }
            Console.Title = $"Amount of changes is {++count}";
        }

        static void ChooseAndChangeElement(ref List<Number> matrix, Cursor cursor, int rowsAmount, int columnsAmount)
        {
            Number tempNumber = matrix[new Random().Next(0, rowsAmount * columnsAmount)];
            tempNumber.Value = new Random().Next(1, 10);
            tempNumber.Color = (ConsoleColor)new Random().Next(1, 16);
            PrintMatrix(ref matrix, cursor, rowsAmount, columnsAmount);
        }

        static void CreatePrimaryMatrix(ref List<Number> matrix, Cursor cursor, int rowsAmount, int columnsAmount)
        {
            for (int i = 0; i < rowsAmount; i++)
            {
                Console.CursorLeft = cursor.PosX;

                for (int j = 0; j < columnsAmount; j++)
                {
                    matrix.Add(new Number(i, j, new Random().Next(1, 10), (ConsoleColor)new Random().Next(1, 16)));
                    Console.ForegroundColor = matrix[(columnsAmount - 1) * i + j + i].Color;
                    Console.Write($"{matrix[(columnsAmount - 1) * i + j + i].Value} ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        static int GetInput(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.Title = $"Changing of value and color";
            List<Number> matrix = new List<Number>();
            Console.ResetColor();
            Console.WriteLine("To finish the program press any button on your keyboard.");
            int rowsAmount = GetInput("Enter the number of rows: ");
            int columnsAmount = GetInput("Enter the number of columns: ");
            Cursor cursor = new Cursor();

            cursor.PosX = Console.WindowWidth / 2 - columnsAmount;
            cursor.PosY = Console.WindowHeight / 2 - rowsAmount;

            Console.CursorTop = cursor.PosY;
            CreatePrimaryMatrix(ref matrix, cursor, rowsAmount, columnsAmount);
            Thread.Sleep(1000);

            while (!Console.KeyAvailable)
            {
                ChooseAndChangeElement(ref matrix, cursor, rowsAmount, columnsAmount);
                Thread.Sleep(250);
            }
            Console.ResetColor();
        }
    }
}