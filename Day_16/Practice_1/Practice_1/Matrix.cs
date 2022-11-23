namespace Practice_1
{
    public class Matrix
    {
        private int[,] matrix = new int[2, 2];

        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Columns = cols;
        }

        public int Rows { get; set; }
        public int Columns { get; set; }

        public int this[int rowIndex, int colIndex]
        {
            get => matrix[rowIndex, colIndex];
            set => matrix[rowIndex, colIndex] = value;
        }

        public static int[,] operator +(Matrix matrix1, Matrix matrix2)
        {
            int[,] resultMatrix = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return resultMatrix;
        }

        public static int[,] operator -(Matrix matrix1, Matrix matrix2)
        {
            int[,] resultMatrix = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return resultMatrix;
        }

        public static int[,] operator *(Matrix matrix1, Matrix matrix2)
        {
            int[,] resultMatrix = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return resultMatrix;
        }

        public static implicit operator Matrix(int v)
        {
            throw new NotImplementedException();
        }
    }
}