namespace Practices
{
    internal partial class Program
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

            public static implicit operator int[,](Matrix matrix)
            {
                int[,] scalar = new int[2, 2];
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        scalar[i, j] = matrix[i, j] * 2;
                    }
                }

                return scalar;
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

            public static double[,] operator -(Matrix matrix)
            {
                double[,] reversed = new double[2, 2];

                //double det = 1 / matrix[0, 0] * matrix[2, 2] - matrix[1, 1] * matrix[0, 1];
                //int[,] ajjaged = new int[2, 2];

                //ajjaged[0, 0] = matrix[2, 2];
                //ajjaged[0, 1] = -matrix[0, 1];
                //ajjaged[1, 1] = -matrix[1, 1];
                //ajjaged[2, 2] = matrix[0, 0];

                //for (int i = 0; i < 2; i++)
                //{
                //    for (int j = 0; j < 2; j++)
                //    {
                //        reversed[i, j] = ajjaged[i,j] * det;
                //    }
                //}

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        reversed[i, j] = -matrix[i, j];
                    }
                }

                return reversed;
            }

            public override bool Equals(object? obj)
            {
                Matrix matrix = (Matrix)obj;
                return matrix.Rows == this.Rows && matrix.Columns == this.Columns;
            }


            public override string? ToString()
            {
                return $"rows: {Rows} columns: {Columns}"; 
            }
        }
    }
}