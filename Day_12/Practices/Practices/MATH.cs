namespace Practices
{
    internal static class MATH
    {
        public static double POW(double number, double power, out STATUSES.Statuses status)
        {
            double result = 1;

            if (power < 0)
            {
                status = STATUSES.Statuses.PowMustBePositiveOrZero;
                return -1;
            }

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            status = STATUSES.Statuses.Success;

            return result;
        }

        public static double MIN(double firstNum, double secondNum, out STATUSES.Statuses status)
        {
            double min;
            if (firstNum < secondNum)
            {
                min = firstNum;
            }
            else if (secondNum < firstNum)
            {
                min = secondNum;
            }
            else
            {
                status = STATUSES.Statuses.IdenticalParameters;
                return -1;
            }

            status = STATUSES.Statuses.DifferentParameters;
            return min;
        }

        public static double MAX(double firstNum, double secondNum, out STATUSES.Statuses status)
        {
            double max;

            if (firstNum > secondNum)
            {
                max = firstNum;
            }
            else if (secondNum > firstNum)
            {
                max = secondNum;
            }
            else
            {
                status = STATUSES.Statuses.IdenticalParameters;
                return -1;
            }

            status = STATUSES.Statuses.DifferentParameters;
            return max;
        }
    }
}
