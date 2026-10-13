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
           
            if (a == 0) return b;
            if (b == 0) return a;

           
            return _fullCalculator.Add(a, b);
        }

        public double Subtract(double a, double b)
        {
            
            if (b == 0) return a;
           
            if (a == 0) return -b;

            return _fullCalculator.Subtract(a, b);
        }

        public double Multiply(double a, double b)
        {
            
            if (a == 0 || b == 0) return 0;

            return _fullCalculator.Multiply(a, b);
        }

        public double Divide(double a, double b)
        {
          
            if (b == 0)
            {
                throw new DivideByZeroException("Exception: B cannot be 0");
            }

            
            if (a == 0)
            {
                return 0;
            }

            return _fullCalculator.Divide(a, b);
        }
    }
}
