using System;

namespace Practical_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // according to https://en.wikipedia.org/wiki/Leap_year
            // leap year is an year
            // that is an integer multiple of 4
            // except for years evenly divisible by 100, but not by 400

            int year = 2000;
            bool leap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

            Console.WriteLine(leap);

            Console.ReadKey();
        }
    }
}
