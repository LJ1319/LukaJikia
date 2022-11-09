using System;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1: ");
            int firstSide = Convert.ToInt32(Console.ReadLine());

            if (firstSide <= 0)
            {
                Console.WriteLine("Side must be greater than zero.");
                return;
            }

            Console.Write("Enter side 2: ");
            int secondSide = Convert.ToInt32(Console.ReadLine());

            if (secondSide <= 0)
            {
                Console.WriteLine("Side must be greater than zero.");
                return;
            }

            Console.Write("Enter side 3: ");
            int thirdSide = Convert.ToInt32(Console.ReadLine());

            if (thirdSide <= 0)
            {
                Console.WriteLine("Side must be greater than zero.");
                return;
            }

            Triangle triangle1 = new Triangle();
            triangle1.FirtSide = firstSide;
            triangle1.SecondSide = secondSide;
            triangle1.ThirdSide = thirdSide;

            if (IsValidTriangle(triangle1))
            {
                int perimeter = triangle1.Perimeter();
                Console.WriteLine($"Perimeter of the triangle is: {perimeter}");

                int area = triangle1.Area();
                Console.WriteLine($"Area of the triangle is: {area}");
            }
        }

        static bool IsValidTriangle(Triangle triangle)
        {
            if (triangle.FirtSide + triangle.SecondSide > triangle.ThirdSide &&
                triangle.FirtSide + triangle.ThirdSide > triangle.SecondSide &&
                triangle.SecondSide + triangle.ThirdSide > triangle.FirtSide
                )
            {
                triangle.IsValidTriangle = true;
                return true;
            }

            Console.WriteLine("It is not a valid triangle");

            return false;
        }
    }
}
