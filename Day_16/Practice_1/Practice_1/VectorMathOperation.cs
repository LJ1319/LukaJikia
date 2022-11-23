namespace Practice_1
{
    public class VectorMathOperation : IMathOperation<Vector>
    {
        public Vector[] Vectors { get; set; }

        public int Scalar { get; set; } 

        public VectorMathOperation(params Vector[] vectors)
        {
            for (int i = 0; i < vectors.Length; i++)
            {
                vectors[i] = new Vector();
            }
            Vectors = vectors;
        }

        public VectorMathOperation(int scalar, params Vector[] vectors)
        {
            for (int i = 0; i < vectors.Length; i++)
            {
                vectors[i] = new Vector();
            }

            Vectors = vectors;
            Scalar = scalar;
        }

        public Vector Addition(params Vector[] vectors)
        {
            Vector addVect = new Vector();
            for (int i = 0; i < vectors.Length; i++)
            {
                for (int j = 0; j < vectors.Length; j++)
                {
                    addVect = new Vector(Vectors[i].X + Vectors[j].X, Vectors[i].Y + Vectors[j].Y);
                }
                
            }

            return addVect;
        }


        public Vector Substraction(params Vector[] vectors)
        {
            Vector addVect = new Vector();
            for (int i = 0; i < vectors.Length; i++)
            {
                for (int j = 0; j < vectors.Length; j++)
                {
                    addVect = new Vector(Vectors[i].X - Vectors[j].X, Vectors[i].Y - Vectors[j].Y);
                }

            }

            return addVect;
        }

        public Vector Multiplication(params Vector[] vectors)
        {
            Vector addVect = new Vector();

            for (int i = 0; i < vectors.Length; i++)
            {
                addVect = new Vector(Vectors[i].X * Scalar, Vectors[i].Y * Scalar);
            }

            return addVect;
        }
    }
}