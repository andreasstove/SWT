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

        public double Added(double a, double b)
        {
            double c = a + b;
            return c;
        }

        public double Substracted(double a, double b)
        {
            double c = a - b;
            return c;
        }


        public double divided(double a, double b)
        {
            if (a == 0 || b == 0)
                return 0;
            else
            {
                double c = a / b;
                return c;
            }
        }

        public double Exponed(double a, double b)
        {
            double c = Math.Pow(a, b);
            return c;
        }

        public double multiply(double a, double b)
        {
            double c = a * b;
            return c;
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

