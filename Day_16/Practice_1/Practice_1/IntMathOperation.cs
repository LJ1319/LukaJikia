namespace Practice_1
{
    public class IntMathOperation : IMathOperation<int>
    {
        public int[] Nums { get; set; }
        public int Sum { get; private set; }

        public IntMathOperation(params int[] nums)
        {
            Nums = nums;
        }

        public int Addition(params int[] values)
        {
            values = Nums;

            for (int i = 0; i < values.Length; i++)
            {
                Sum += values[i];
            }

            return Sum;
        }

        public int Substraction(params int[] values)
        {
            values = Nums;

            for (int i = 0; i < values.Length; i++)
            {
                Sum -= values[i];
            }

            return Sum;
        }

        public int Multiplication(params int[] values)
        {
            values = Nums;
            Sum = 1;

            for (int i = 0; i < values.Length; i++)
            {
                Sum *= values[i];
            }

            return Sum;
        }
    }
}