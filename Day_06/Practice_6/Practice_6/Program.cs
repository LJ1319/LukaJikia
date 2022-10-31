using System;

namespace Practice_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberOfCharacter(PopulateArray(), 'a');
        }

        static char[] PopulateArray()
        {
            Console.Write("Enter size of array: ");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            char[] userArr = new char[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"Enter character for index {i}: ");
                userArr[i] = Convert.ToChar(Console.ReadLine());
            }

            return userArr;
        }

        static int NumberOfCharacter(char[] userArr, char userChar)
        {
            if (!((userChar >= 'A' && userChar <= 'Z') || (userChar >= 'a' && userChar <= 'z')))
            {
                Console.WriteLine("Invalid input");
                return 1;
            }

            int count = 0;

            bool inArray = false;

            for (int i = 0; i < userArr.Length; i++)
            {
                if (userArr[i] == userChar)
                {
                    inArray = true;
                    count += 1;
                }
            }

            if (!inArray)
            {
                Console.WriteLine($"'{userChar}' ar gvxdevba masivshi");
                return 1;
            }

            Console.WriteLine($"'{userChar}' shegxvda {count}-jer");

            return count;
        }
    }
}
