using System;

namespace Practice_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 8;
            int cols = 8;

            Console.WriteLine("version_1");
            Console.WriteLine("using multidimensional array");
            int[,] numbers = new int[8, 8]
            {
                { 0, 1, 1, 1, 1, 1, 1, 1 },
                { 0, 0, 1, 1, 1, 1, 1, 1 },
                { 0, 0, 0, 1, 1, 1, 1, 1 },
                { 0, 0, 0, 0, 1, 1, 1, 1 },
                { 0, 0, 0, 0, 0, 1, 1, 1 },
                { 0, 0, 0, 0, 0, 0, 1, 1 },
                { 0, 0, 0, 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },

            };

            for (int i = 0; i < rows; i++)
            {
                //Console.Write($"Row {i + 1}: ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{numbers[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = rows - 1; i >= 0; i--)
            {
                //Console.Write($"Row {i + 1}: ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{numbers[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("using jagged array");
            int[][] jaggNumbers = new int[8][]
            {
                new int[] { 0, 1, 1, 1, 1, 1, 1, 1 },
                new int[] { 0, 0, 1, 1, 1, 1, 1, 1 },
                new int[] { 0, 0, 0, 1, 1, 1, 1, 1 },
                new int[] { 0, 0, 0, 0, 1, 1, 1, 1 },
                new int[] { 0, 0, 0, 0, 0, 1, 1, 1 },
                new int[] { 0, 0, 0, 0, 0, 0, 1, 1 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 1 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            for (int i = 0; i < rows; i++)
            {
                //Console.Write($"Row {i + 1}: ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{jaggNumbers[i][j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = rows - 1; i >= 0; i--)
            {
                //Console.Write($"Row {i + 1}: ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{jaggNumbers[i][j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------");

            Console.WriteLine("version_2");
            Console.WriteLine("using multidimensional array");
            int[,] nums = new int[8, 8];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    //Console.WriteLine($"{i} --- {j}");

                    if (j > i)
                    {
                        nums[i, j] = 1;
                    }
                    else
                    {
                        nums[i, j] = 0;
                    }
                    Console.Write($"{nums[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = rows - 1; i >= 0; i--)
            {
                for (int j = 0; j < cols; j++)
                {
                    //Console.Write($"{i} --- {j}");

                    if (j > i)
                    {
                        nums[i, j] = 1;
                    }
                    else
                    {
                        nums[i, j] = 0;
                    }
                    Console.Write($"{nums[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("using jagged array");

            int[][] jaggNums = new int[8][];

            for (int i = 0; i < rows; i++)
            {
                jaggNums[i] = new int[8];
                for (int j = 0; j < cols; j++)
                {
                    if (j > i)
                    {
                        jaggNums[i][j] = 1;
                    }
                    else
                    {
                        jaggNums[i][j] = 0;
                    }
                    Console.Write($"{nums[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = rows - 1; i >= 0; i--)
            {
                for (int j = 0; j < cols; j++)
                {
                    //Console.Write($"{i} --- {j}");

                    if (j > i)
                    {
                        jaggNums[i][j] = 1;
                    }
                    else
                    {
                        jaggNums[i][j] = 0;
                    }
                    Console.Write($"{nums[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
