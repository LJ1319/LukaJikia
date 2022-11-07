using System;

namespace Practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter power: ");
            int power = Convert.ToInt32(Console.ReadLine());

            int result = PowerOfNumber(num, power);
            Console.WriteLine(result);
        }

        static int PowerOfNumber(int num, int power)
        {
            if (power == 0)
                return 1;
            return num * PowerOfNumber(num, power - 1);
        }
    }
}
