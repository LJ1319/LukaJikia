using System;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            TillTheNumberHead(num);
        }

        static void TillTheNumberHead(int num)
        {
            if (num < 1)
                return;
            else
                TillTheNumberHead(num - 1);

            Console.Write($"{num} ");
        }
    }
}
