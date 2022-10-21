using System;

namespace Practical_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            // ა - მესამე(temporary) ცვლადის დახმარებით
            int temp = a; // temp = 5
            a = b;        // a = 7
            b = temp;     // b = 5

            Console.WriteLine("a - using a temporary variable");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            a = 5;
            b = 7;

            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}");

            // ბ - მესამე ცვლადის გარეშე
            a += b;     // a = 5 + 7 = 12
            b = a - b;  // b = 12 - 7 = 5
            a -= b;

            Console.WriteLine("b - without a temporary variable");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            Console.ReadKey();

        }
    }
}
