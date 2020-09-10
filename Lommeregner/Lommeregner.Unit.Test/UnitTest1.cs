using NUnit.Framework;

using System;
using Lommeregner;
namespace Lommeregner.Unit.Test
{
    [TestFixture]
    public class Tests
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            var uut = new Calculator();
            
        }

        [TestCase(1,1,2)]
        [TestCase(-5,-3,-8)]
        public void Add_AddingTwoPositiveIntegers_NItemIsCorrect(double a, double b, double expectedResult)
        {
          
            
            double result = uut.Add(a, b);
            Assert.That(result,Is.EqualTo(expectedResult));



            
        }

        [Test]
        public void Add_AddingOnePositiveIntegerAndOneNegative_NItemIsCorrect()
        {
            var uut = new Calculator();

            uut.Add(7);
            uut.Add(-3);
            var expectedResult = 0 + 7 - 3;

            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult));


        }

        [TestCase(10, 5, 5)]
        [TestCase(-4,-4,0)]
        [TestCase(0.9,0.3,0.6)]
        public void Substract_TestCases(double a, double b, double result)
        {
            var uut = new Calculator();
            
            Assert.That(uut.Substract(a,b), Is.EqualTo(result).Within(0.0001));
        }

        [TestCase(2, 3, 8)]
        [TestCase(0.5,0.7,0.61557)]
        [TestCase(5,0,1)]
        [TestCase(0,5,0)]
        public void Power_TestCases(double a, double b, double result)
        {
            var uut = new Calculator();
            
            Assert.That(uut.Power(a,b), Is.EqualTo(result).Within(0.0001));
        }
        
        [TestCase(3, 3, 6)]
        [TestCase(4,-2,2)]
        [TestCase(3.3,-4.4,-1.1)]
        public void Add_Test(double a, double b, double result)
        {
            Calculator uut = new Calculator();
            Assert.That(uut.Add(a,b),Is.EqualTo(result).Within(0.000003));
        }

        [TestCase(4, 4, 16)]
        [TestCase(-3, 7, -21)]
        [TestCase(2.5, 6, 15)]
        [TestCase(100, 100, 10000)]
        public void Multiply_Test(double a, double b, double result)
        {
            Calculator uut = new Calculator();
            Assert.That(uut.Multiply(a,b),Is.EqualTo(result).Within(0.0003));
        }
    }
}