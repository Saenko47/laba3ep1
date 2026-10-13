using laba3ep1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace laba3ep1
{
    internal class LightCalculator:ICalculator
    {
        private readonly Claculator _fullCalculator;

        public LightCalculator()
        {
            _fullCalculator = new Claculator();
        }

        public double Add(double a, double b)
        {
            // A + 0 = A або 0 + A = A
            if (a == 0) return b;
            if (b == 0) return a;

            // Більш складні операції передаємо FullCalculator
            return _fullCalculator.Add(a, b);
        }

        public double Subtract(double a, double b)
        {
            // A - 0 = A
            if (b == 0) return a;
            // 0 - A = -A
            if (a == 0) return -b;

            return _fullCalculator.Subtract(a, b);
        }

        public double Multiply(double a, double b)
        {
            // A * 0 = 0 або 0 * A = 0
            if (a == 0 || b == 0) return 0;

            return _fullCalculator.Multiply(a, b);
        }

        public double Divide(double a, double b)
        {
            // B = 0 -> виняток (exception)
            if (b == 0)
            {
                throw new DivideByZeroException("Exception: B cannot be 0");
            }

            // A / B = 0, якщо A = 0 і B != 0
            if (a == 0)
            {
                return 0;
            }

            return _fullCalculator.Divide(a, b);
        }
    }
}
