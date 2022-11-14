namespace Practices
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a power: ");
            double power = Convert.ToDouble(Console.ReadLine());

            double result = MATH.POW(number, power, out STATUSES.Statuses powStatus);

            Console.WriteLine(powStatus);
            if (powStatus == STATUSES.Statuses.Success)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("-------------------------");

            Console.Write("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            STATUSES.Statuses minMaxStatus;
            double min = MATH.MIN(firstNumber, secondNumber, out minMaxStatus);

            double max = MATH.MAX(firstNumber, secondNumber, out minMaxStatus);

            Console.WriteLine(minMaxStatus);
            if (minMaxStatus == STATUSES.Statuses.DifferentParameters)
            {
                Console.WriteLine($"Min value is {min}");
                Console.WriteLine($"Max value is {max}");
            }
        }
    }
}