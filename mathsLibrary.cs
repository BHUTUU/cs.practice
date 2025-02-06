using System;
namespace MathLibrary
{
    public static class MathOperations
    {
        // Addition
        public static double Add(double a, double b)
        {
            return a + b;
        }
        // Subtraction
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        // Multiplication
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        // Division
        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }
        // Modulus (Remainder)
        public static double Modulus(double a, double b)
        {
            return a % b;
        }
        // Power
        public static double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }
        // Square Root
        public static double SquareRoot(double number)
        {
            if (number < 0)
                throw new ArgumentException("Cannot compute square root of a negative number.");
            return Math.Sqrt(number);
        }
    }
}

