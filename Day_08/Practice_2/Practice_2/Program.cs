using System;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = SumOfIntegers(num);
            Console.WriteLine(sum);
        }

        static int SumOfIntegers(int num)
        {
            if (num <= 1)
                return 1;
            else
                return num + SumOfIntegers(num - 1);
        }
    }
}
