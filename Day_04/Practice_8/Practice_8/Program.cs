using System;

namespace Practice_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            long binaryValue = 0;
            int reminder;
            int baseValue = 1;
            while (userInput != 0)
            {
                reminder = userInput % 2;

                userInput /= 2;

                binaryValue += reminder * baseValue;

                baseValue *= 10;
            }
            Console.WriteLine($"decimal {userInput} in binary is {binaryValue}");

            //n     rem = n % 2     n /= 2      base    bin += rem * i          i *= 10   
            //13    13 % 2 = 1      13 / 2      1       0 + 1 * 1 = 1           1 * 10 = 10
            //6     6 % 2 = 0	    6 / 2 = 3	10	    1 + 0 * 10 = 1	        10 * 10 = 100
            //3     3 % 2 = 1	    3 / 2 = 1	100	    1 + 1 * 100 = 101	    100 * 10 = 1000
            //1     1 % 2 = 1	    1 / 2 = 0	1000	101 + 1 * 1000 = 1101	1000 * 10 = 10000
            //0     -               -                   -                       loop terminates
        }
    }
}
