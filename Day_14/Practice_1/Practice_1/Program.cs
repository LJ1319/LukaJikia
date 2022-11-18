namespace Practice_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Triangle Cordinates: ");
            int triAX = Convert.ToInt32(Console.ReadLine());
            int triAY = Convert.ToInt32(Console.ReadLine());
            int triBX = Convert.ToInt32(Console.ReadLine());
            int triBY = Convert.ToInt32(Console.ReadLine());
            int triCX = Convert.ToInt32(Console.ReadLine());
            int triCY = Convert.ToInt32(Console.ReadLine());
            Triangle triangle1 = new Triangle(triAX, triAY, triBX, triBY, triCX, triCY);

            Console.WriteLine("Enter Rectangle Cordinates: ");
            int quadAX = Convert.ToInt32(Console.ReadLine());
            int quadAY = Convert.ToInt32(Console.ReadLine());
            int quadBX = Convert.ToInt32(Console.ReadLine());
            int quadBY = Convert.ToInt32(Console.ReadLine());
            int quadCX = Convert.ToInt32(Console.ReadLine());
            int quadCY = Convert.ToInt32(Console.ReadLine());
            int quadDX = Convert.ToInt32(Console.ReadLine());
            int quadDY = Convert.ToInt32(Console.ReadLine());
            Rectangle quad1 = new Rectangle(quadAX, quadAY, quadBX, quadBY, quadCX, quadCY, quadDX, quadDY);

            Console.WriteLine("Enter Circle Center and Circle Point Cordinates: ");
            int centerPointX = Convert.ToInt32(Console.ReadLine());
            int centerPointY = Convert.ToInt32(Console.ReadLine());
            int circlePointX = Convert.ToInt32(Console.ReadLine());
            int circlePointY = Convert.ToInt32(Console.ReadLine());
            Circle circle1 = new Circle(centerPointX, centerPointY, circlePointX, circlePointY);

            Shape[] shapes = new Shape[3];
            shapes[0] = triangle1;
            shapes[1] = quad1;
            shapes[2] = circle1;

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Perimeter = {shape.Perimeter()}");
                Console.WriteLine($"Area = {shape.Area()}");
            }
        }
    }
}