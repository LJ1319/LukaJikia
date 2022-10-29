using System;

namespace Practice_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array row size: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter array column size: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] firstMatrix = new int[rows, columns];
            Console.WriteLine("Fill first matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            int[,] secondMatrix = new int[rows, columns];
            Console.WriteLine("Fill second matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Here is sum of two matrices");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == columns - 1)
                    {
                        Console.Write($"{firstMatrix[i, j] + secondMatrix[i, j]};");
                    }
                    else
                    {
                        Console.Write($"{firstMatrix[i, j] + secondMatrix[i, j]}, ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
