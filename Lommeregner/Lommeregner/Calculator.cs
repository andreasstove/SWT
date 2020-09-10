using System;
using System.Security.Cryptography.X509Certificates;

namespace Lommeregner
{
    public class Calculator
    {
        static void Main()
        {
            
            Console.WriteLine("Hello Thomas!");
        }

        public double Divide(double dividend, double divisor)
        {
            if (dividend == 0 || divisor == 0)
                return 0;
            else
            {
                Accumulator = dividend / divisor;
                return Accumulator;
            }
        }
        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double addend)
        {

            Accumulator += addend;
            return Accumulator;
        }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }


        public double Divide(double divisor)
        {
            if (divisor == 0)
                return 0;
            else
            {
                Accumulator /= divisor;
                return Accumulator;

            }
        }

        public double Power(double a, double b)
        {
            Accumulator = Math.Pow(a, b);
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }
        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }
        public double Multiply(double multiplier)
        {
            Accumulator *= multiplier;
            return Accumulator;
        }
        public double Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

    }

}

