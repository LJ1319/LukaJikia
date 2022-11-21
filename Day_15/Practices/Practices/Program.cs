namespace Practices
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            int rows = 2;
            int cols = 2;

            Matrix matrix = new Matrix(rows, cols);

            Console.WriteLine("Enter matrix parameters: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{i} {j} = ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] scalar = (int[,])matrix;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{scalar[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------");

            Matrix matrix1 = new Matrix(rows, cols);

            Console.WriteLine("Enter matrix1 parameters: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{i} {j} = ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Matrix matrix2 = new Matrix(rows, cols);

            Console.WriteLine("Enter matrix2 parameters: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{i} {j} = ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] result = matrix1 + matrix2;
            Console.WriteLine("After addition: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{result[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("After substraction: ");
            result = matrix1 - matrix2;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{result[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("After multiplication: ");
            result = matrix1 * matrix2;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{result[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("after reversion: ");
            double[,] reversed = new double[2, 2];

            reversed = -matrix;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{reversed[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(matrix.ToString());
            Console.WriteLine(matrix1.Equals(matrix2));

            Console.WriteLine("--------------------------");

            Console.WriteLine("Enter sides of a first triangle...");
            Console.Write("Side A: ");
            double firstSideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side B: ");
            double firstSideB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side C: ");
            double firstSideC = Convert.ToDouble(Console.ReadLine());

            Triangle tr1 = new Triangle(firstSideA, firstSideB, firstSideC);

            Console.WriteLine("Enter sides of a second triangle...");
            Console.Write("Side A: ");
            double secondSideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side B: ");
            double secondSideB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side C: ");
            double secondSideC = Convert.ToDouble(Console.ReadLine());

            Triangle tr2 = new Triangle(secondSideA, secondSideB, secondSideC);

            Console.WriteLine(tr1 == tr2);
            Console.WriteLine(tr1 != tr2);
            Console.WriteLine(tr1 > tr2);
            Console.WriteLine(tr1 < tr2);

           
            double d = 3;
            tr1 = (Triangle)d;

            Triangle tr3 = new Triangle(3, 4, 5);
            tr3 = tr1 + tr2;
        }
    }
}