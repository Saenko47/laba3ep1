using laba3ep1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace laba3ep1
{
    internal class Claculator: ICalculator
    {

        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Exception: Division by zero (B = 0)");
            return a / b;
        }
    }
}
