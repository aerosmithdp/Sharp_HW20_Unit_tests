using System;

namespace Sharp_HW20
{
    public class Calculator
    {
        public static double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        public static double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }
        public static double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }
        public static double Divide(double value1, double value2)
        {
            if (value2 == 0)
            {
                throw new DivideByZeroException("Cannot be divided by zero");
            }
            return value1 / value2;
        }
        public static double SquareRoot(double value1)
        {
            if (value1 < 0)
            {
                throw new ArgumentOutOfRangeException("Root can`t be not less than zero or equal to zero");
            }
            return Math.Sqrt(value1);
        }

    }
}
