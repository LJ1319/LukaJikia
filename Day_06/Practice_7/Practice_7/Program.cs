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

            Console.WriteLine("----------------------------------------");
            int[,] firtMatrix = PopulateMatrix(rows, columns);
            int[,] secondMatrix = PopulateMatrix(rows, columns);
            int[,] productMatrix = AddMatricies(firtMatrix, secondMatrix);

            PrintProducMatrix(productMatrix);
        }

        static int[,] PopulateMatrix(int rows, int columns)
        {
            int[,] userMatrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter integer for index {i},{j}: ");
                    userMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("----------------------------------------");

            return userMatrix;
        }

        static int[,] AddMatricies(int[,] firstUserMatrix, int[,] secondUserMatrix)
        {
            int rows = firstUserMatrix.GetLength(0);
            int columns = firstUserMatrix.GetLength(1);
            int[,] productMatrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    productMatrix[i, j] = firstUserMatrix[i, j] + secondUserMatrix[i, j];
                }
            }

            return productMatrix;
        }

        static void PrintProducMatrix(int[,] productMatrix)
        {
            int rows = productMatrix.GetLength(0);
            int columns = productMatrix.GetLength(1);

            Console.WriteLine("Here is sum of two matrices");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == columns - 1)
                    {
                        Console.Write($"{productMatrix[i, j]}");
                    }
                    else
                    {
                        Console.Write($"{productMatrix[i, j]}, ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
