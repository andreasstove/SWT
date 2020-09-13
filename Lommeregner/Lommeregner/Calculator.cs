using System;
using System.Security.Cryptography.X509Certificates;

namespace Lommeregner
{
    public class Calculator
    {
        static void Main()
        {
           // Calculator calc = new Calculator();
            //calc.Divide(3, 0);
            Console.WriteLine("Hello Thomas!");
            
        }

        public double Divide(double dividend, double divisor)
        {
            if (dividend == 0 || divisor == 0)
                throw new DividedByZero();
            else
            {
                Accumulator = dividend / divisor;
                return Accumulator;
            }
            //try
            //{

            //    Accumulator = dividend / divisor;
            //    throw new DivideByZeroException();
            //    //return Accumulator;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Division by zero.");

            //}

            //return Accumulator;
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
                throw new DivideByZeroException();
            else
            {
                Accumulator /= divisor;
                return Accumulator;

            }
        }

        public double Power(double a, double b)
        {
            if (a < 0)
                throw  new PowerToNegativeNumber();
            else
            {
                Accumulator = Math.Pow(a, b);
                return Accumulator;
            }
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
    public class DividedByZero : Exception
    {
        public DividedByZero() { Console.WriteLine("Du må ikke dele med 0"); }

    }

    public class PowerToNegativeNumber : Exception
    {
        public PowerToNegativeNumber() {Console.WriteLine("Maskinen kan ikke håndtere et negativt grundtaltal");
        }
    }

}

