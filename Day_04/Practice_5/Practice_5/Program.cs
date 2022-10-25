using System;

namespace Practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number of rows of Floyd's trianlge to be printed: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= userInput; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((i % 2) == (j % 2))
                    {
                        Console.Write("1 ");

                    } else
                    {
                        Console.Write("0 ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
