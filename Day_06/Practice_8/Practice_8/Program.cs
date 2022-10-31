using System;

namespace Practice_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DemonstrateNumber(GetNumber());
        }

        static int GetNumber()
        {
            Console.Write("Enter a positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Number must be positive");
                return 1;
            }

            return number;
        }

        static void DemonstrateNumber(int number)
        {
            int count = 0;
            Console.Write($"{number} = ");
            while (number != 0)
            {
                count++;
                number = (int)(number - number % Math.Pow(10, count));
                Console.Write($"{count} * 10^{count - 1} + ");
                //Console.WriteLine(number);
            }

        }
    }
}
