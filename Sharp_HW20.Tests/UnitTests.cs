using System;
using Xunit;

namespace Sharp_HW20.Tests
{
    public class UnitTests
    {
        [InlineData(-1, 1, 0)]
        [InlineData(5, 10, 15)]
        [InlineData(5.5, 7.8, 13.3)]
        [Theory]
        public void AddTest(double a, double b, double expected)
        {
            double actual = Calculator.Add(a, b);
            Assert.Equal(expected, actual);
        }

        [InlineData(5, 5, 0)]
        [InlineData(9.5, 6.7, 2.8)]
        [InlineData(-5.5, -7.8, 2.3)]
        [Theory]
        public void SubtractTest(double a, double b, double expected)
        {
            double actual = Calculator.Subtract(a, b);
            Assert.Equal(expected, actual);
        }

        [InlineData(-1, 0, 0)]
        [InlineData(7.5, 8.3, 62.25000000000001)]
        [InlineData(-5.5, 9.6, -52.8)]
        [Theory]
        public void MultiplyTest(double a, double b, double expected)
        {
            double actual = Calculator.Multiply(a, b);
            Assert.Equal(expected, actual);
        }

        [InlineData(0, -1, -0)]
        [InlineData(-5.5, 2, -2.75)]
        [InlineData(-7.5, -2, 3.75)]
        [Theory]
        public void DivideTest(double a, double b, double expected)
        {
            double actual = Calculator.Divide(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideByZeroTest()
        {
            double a = 10;
            double b = 0;
            Action action = () => Calculator.Divide(a, b);
            Assert.Throws<DivideByZeroException>(action);
        }

        [InlineData(5, 2.23606797749979)]
        [InlineData(5.5, 2.345207879911715)]
        [Theory]
        public void SquareRootTest(double a, double expected)
        {
            double actual = Calculator.SquareRoot(a);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NegativeSquareRootTest()
        {
            double a = -10;
            Action action = () => Calculator.SquareRoot(a);
            Assert.Throws<ArgumentOutOfRangeException>(action);
        }

        //[Fact]
        //public void SquareRootFactTest()
        //{
        //    double a = 10;
        //    double expected = Math.Sqrt(a);
        //    Assert.Equal(expected, Calculator.SquareRoot(a));
        //}

    }
}
