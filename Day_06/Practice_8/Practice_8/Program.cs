using System;

namespace Practice_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RepresentateNumber(GetNumber());
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

        static void RepresentateNumber(int number)
        {
            int count = 0;
            int rem;
            int temp = number;
            Console.Write($"{number} = ");
            while (temp > 0)
            {
                count++;

                rem = temp % 10;
                temp /= 10;

                number = (int)(number - number % Math.Pow(10, count));

                if (temp == 0)
                {
                    Console.Write($"{rem} * 10^{count - 1}");
                }
                else
                {
                    Console.Write($"{rem} * 10^{count - 1} + ");
                }
            }
        }
    }
}
