using System;

namespace Practice_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array row size: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter array column size: ");
            int column = Convert.ToInt32(Console.ReadLine());

            int[,] userArray = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    userArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Here is matrix view of multidimensional array");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (j == column - 1 )
                    {
                        Console.Write($"{userArray[i, j]};");
                    }
                    else
                    {
                        Console.Write($"{userArray[i, j]}, ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
