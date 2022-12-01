using System.Reflection.Metadata.Ecma335;

namespace Practice_1
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = new int[3] { 1, 2, 3 };
            IntMathOperation intMath = new IntMathOperation(nums);

            Console.WriteLine($"add: {intMath.Addition()}");
            Console.WriteLine($"sub: {intMath.Substraction()}");
            Console.WriteLine($"mult: {intMath.Multiplication()}");

            Vector[] vectors = new Vector[3];
            VectorMathOperation vectMath = new VectorMathOperation(vectors);

            for (int i = 0; i < vectors.Length; i++)
            {
                Console.WriteLine(vectMath.Vectors[i]);
                Console.WriteLine(vectMath.Addition(vectors));
                Console.WriteLine(vectMath.Substraction(vectors));
                Console.WriteLine(vectMath.Multiplication(vectors));
            }


            Matrix[,] matrices = new Matrix[2, 2];
            MatrixMathOperation matrixMath = new MatrixMathOperation(matrices);

            for (int i = 0; i < matrices.Length; i++)
            {
                Console.WriteLine(matrixMath.Matrices[i]);
                Console.WriteLine(matrixMath.Addition(matrices));
                Console.WriteLine(matrixMath.Substraction(matrices));
                Console.WriteLine(matrixMath.Multiplication(matrices));
            }
        }
    }
}