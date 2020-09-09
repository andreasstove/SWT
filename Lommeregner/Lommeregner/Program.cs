using System;

namespace Lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Thomas!");
        }
        public double Add(double a, double b)
        {
            double c;
            c = a + b;
            return c;
        }
        public double Subtract(double a, double b)
        {
            double c;
            c = a - b;
            return c;
        }
        public double Multiply(double a, double b)
        {
            double c;
            c = a * b;
            return c;
        }
        public double Power(double x, double exp)
        {
            double c;
            c = Math.Pow(x, exp);
            return c;
        }

    }

}

