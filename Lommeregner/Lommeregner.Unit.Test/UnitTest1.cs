using NUnit.Framework;

using System;
using Lommeregner;
namespace Lommeregner.Unit.Test
{
    [TestFixture]
    public class Tests
    { 
        private Calculator uut = new Calculator();

        [SetUp]
        public void Setup()
        {
           Calculator uut;
            
        }

        [TestCase(3, 3, 6)]
        [TestCase(4, -2, 2)]
        [TestCase(3.3, -4.4, -1.1)]
        public void Add_Test(double a, double b, double ExpectectedResult)
        {
            double result = uut.Add(a, b);
            Assert.That(result, Is.EqualTo(ExpectectedResult).Within(0.000003));
        }

        [TestCase(10, 5, 5)]
        [TestCase(-4,-4,0)]
        [TestCase(0.9,0.3,0.6)]
        public void Subtract_TestCases(double a, double b, double ExpectedResult)
        {
            double result = uut.Subtract(a, b);
            Assert.That(result, Is.EqualTo(ExpectedResult).Within(0.0001));
        }

        [TestCase(2, 3, 8)]
        [TestCase(0.5,0.7,0.61557)]
        [TestCase(5,0,1)]
        [TestCase(0,5,0)]
        public void Power_TestCases(double a, double b, double ExpectedResult)
        {
            double result = uut.Power(a, b);
            Assert.That(result, Is.EqualTo(ExpectedResult).Within(0.0001));
        }

        [TestCase(4, 4, 16)]
        [TestCase(-3, 7, -21)]
        [TestCase(2.5, 6, 15)]
        [TestCase(100, 100, 10000)]
        public void Multiply_Test(double a, double b, double ExpectedResult)
        {
            double result = uut.Multiply(a, b);
            Assert.That(result,Is.EqualTo(ExpectedResult).Within(0.0003));
        }
        [TestCase(8,2,4)]
        [TestCase(10,4,2.5)]
        [TestCase(10,0,0)]
        public void Divide_test(double a, double b, double ExpectedResult)
        {
            double result = uut.Divide(a, b);
            Assert.That(result,Is.EqualTo(ExpectedResult));
        }
    }
}