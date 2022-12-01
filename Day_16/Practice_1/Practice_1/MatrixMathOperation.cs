namespace Practice_1
{
    public class MatrixMathOperation : IMathOperation<Matrix>
    {
        public Matrix[] Matrices { get; set; }

        public MatrixMathOperation(params Matrix[] matrices)
        {
            for (int i = 0; i < matrices.Length; i++)
            {
                matrices[i] = new Matrix(2, 2);
            }
            Matrices = matrices;
        }

        public Matrix[,] Addition(params Matrix[] matrices)
        {
            Matrix[,] resultMatrix = new Matrix[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resultMatrix[i, j] = matrices[0][i, j] + matrices[1][i, j];
                }
            }

            return resultMatrix;
        }

       
        public Matrix[,] Substraction(params Matrix[] matrices)
        {
            Matrix[,] resultMatrix = new Matrix[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resultMatrix[i, j] = matrices[0][i, j] + matrices[1][i, j];
                }
            }

            return resultMatrix;
        }

        public Matrix[,] Multiplication(params Matrix[] matrices)
        {
            Matrix[,] resultMatrix = new Matrix[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        resultMatrix[i, j] += matrices[0][i, k] + matrices[1][k, j];
                    }
                }
            }

            return resultMatrix;
        }

    }
}