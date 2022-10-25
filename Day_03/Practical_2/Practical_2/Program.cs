using System;

namespace Practical_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstSide = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int secondSide = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int thirdSide = Convert.ToInt32(Console.ReadLine());

            if ((firstSide + secondSide) > thirdSide && (firstSide + thirdSide) > secondSide && (secondSide + thirdSide) > firstSide)
            {
                Console.WriteLine("This can be a triangle!");
            } else
            {
                Console.WriteLine("This can not be a triangle!");
            }
        }
    }
}
