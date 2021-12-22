using System;

namespace Sharp_HW20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value1;
            double value2;
            Console.Write("Input the ariphmetical sign: ");
            char sign = Console.ReadLine().Trim()[0];

            switch (sign)
            {
                case '+':
                    Console.Write("Enter first number: ");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Calculator.Add(value1, value2));
                    break;
                case '-':
                    Console.Write("Enter first number: ");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Calculator.Subtract(value1, value2));
                    break;
                case '*':
                    Console.Write("Enter first number: ");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Calculator.Multiply(value1, value2));
                    break;
                case '/':
                    Console.Write("Enter first number: ");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    value2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Calculator.Divide(value1, value2));
                    break;
                case '^':
                    Console.Write("Enter number: ");
                    value1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Calculator.SquareRoot(value1));
                    break;


            }
        }

    }
}
