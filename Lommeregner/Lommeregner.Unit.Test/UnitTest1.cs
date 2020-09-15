using NUnit.Framework;

using System;
using System.Reflection.Metadata.Ecma335;
using Lommeregner;
using NUnit.Framework.Constraints;
using System.Threading.Tasks;
using System.Xml;

namespace Lommeregner.Unit.Test
{
    [TestFixture]
    public class Tests
    { 
        private readonly Calculator _uut = new Calculator();

        [SetUp]
        public void Setup()
        {
           Calculator _uut;
            
        }

        [TestCase(4, 3, 7)]
        [TestCase(3, 2, 5)]
        [TestCase(4, -5, -1)]
        public void Accumulator_Test(double a, double b, double ExpectedResult)
        {
            _uut.Clear();
            _uut.Add(a);
            _uut.Add(b);
            double result = _uut.Accumulator;
            Assert.That(result, Is.EqualTo(ExpectedResult));
        }

        [TestCase(3, 3, 6)]
        [TestCase(4, -2, 2)]
        [TestCase(3.3, -4.4, -1.1)]
        public void Add_Test(double a, double b, double ExpectedResult)
        {
            double result = _uut.Add(a, b);
            Assert.That(result, Is.EqualTo(ExpectedResult).Within(0.000003));
        }

        [TestCase(3, 3, 3, 3, 12)]
        [TestCase(4, 4, 4, 4, 16)]
        [TestCase(-2.5, -3.5, -4.5, -5.5, -16)]
        public void Add_AccumulitorTest(double a, double b, double c, double d, double ExpectedResult)
        {
            _uut.Clear();
            _uut.Add(a);
            _uut.Add(b);
            _uut.Add(c);
            double result = _uut.Add(d);

            Assert.That(result, Is.EqualTo(ExpectedResult));
        }

        [TestCase(10, 5, 5)]
        [TestCase(-4,-4,0)]
        [TestCase(0.9,0.3,0.6)]
        public void Subtract_TestCases(double a, double b, double ExpectedResult)
        {
            double result = _uut.Subtract(a, b);
            Assert.That(result, Is.EqualTo(ExpectedResult).Within(0.0001));
        }
        [TestCase(3, 3, 3, 3, -12)]
        [TestCase(4, 4, 4, 4, -16)]
        [TestCase(-2.5, -3.5, -4.5, -5.5, 16)]
        public void Subtract_AccumulitorTest(double a, double b, double c, double d, double ExpectedResult)
        {
            _uut.Clear();
            _uut.Subtract(a);
            _uut.Subtract(b);
            _uut.Subtract(c);
            double result = _uut.Subtract(d);

            Assert.That(result, Is.EqualTo(ExpectedResult));
        }
        [TestCase(2, 3, 8)]
        [TestCase(0.5,0.7,0.61557)]
        [TestCase(5,0,1)]
        [TestCase(0,5,0)]
        [TestCase(2,-1.5,0.3535)]
        public void Power_TestCases(double a, double b, double ExpectedResult)
        {
            double result = _uut.Power(a, b);
            Assert.That(result, Is.EqualTo(ExpectedResult).Within(0.0001));
        }
        [Test]
        public void Power_NegativeGroundNumber_ExpectAException()
        {
            Assert.Throws<PowerToNegativeNumber>(() => _uut.Power(-2, 4));
            
        }
        [TestCase(2, 2,16)]
        [TestCase(4, 4,  65536)]
        [TestCase(-2.5, -3.5,430.538965)]
        public void Power_AccumulitorTest(double a, double b, double ExpectedResult)
        {
            _uut.Clear();
            _uut.Add(2);
            _uut.Power(a);
            double result =  _uut.Power(b);
          

            Assert.That(result, Is.EqualTo(ExpectedResult).Within(0.00001));
        }
        [TestCase(4, 4, 16)]
        [TestCase(-3, 7, -21)]
        [TestCase(2.5, 6, 15)]
        [TestCase(100, 100, 10000)]
        public void Multiply_Test(double a, double b, double ExpectedResult)
        {
            double result = _uut.Multiply(a, b);
            Assert.That(result,Is.EqualTo(ExpectedResult).Within(0.0003));
        }
        [TestCase(3, 3, 3, 3, 81)]
        [TestCase(4, 4, 4, 4, 256)]
        [TestCase(-2.5, -3.5, -4.5, -5.5, 216.5625)]
        public void Multiply_AccumulitorTest(double a, double b, double c, double d, double ExpectedResult)
        {
            _uut.Clear();
            _uut.Add(1);
            _uut.Multiply(a);
            _uut.Multiply(b);
            _uut.Multiply(c);
            double result = _uut.Multiply(d);

            Assert.That(result, Is.EqualTo(ExpectedResult));
        }
        [TestCase(8,2,4)]
        [TestCase(10,4,2.5)]
        [TestCase(10,2,5)]
        public void Divide_test(double a, double b, double ExpectedResult)
        {
            double result = _uut.Divide(a, b);
            Assert.That(result,Is.EqualTo(ExpectedResult));
        }

        [Test]
        public void Clear_TheAccumulatorsValueIsFive_SetAccumulatorToZero()
        {
            _uut.Add(3, 2);
            _uut.Clear();
            double result = _uut.Accumulator;
            double ExpectedResult = 0;
            Assert.That(result,Is.EqualTo(ExpectedResult));
        }

        [Test]
        public void Clear_TheAccumulatorsValueIsMinusFivePointFive_SetAccumulatorToZero()
        {
            _uut.Add(-3,2.5 );
            _uut.Clear();
            double result = _uut.Accumulator;
            double ExpectedResult = 0;
            Assert.That(result, Is.EqualTo(ExpectedResult));

        }

        [Test]
        public void Clear_TheAccumulatorsValueIsZero_SetAccumulatorToZero()
        {
            _uut.Clear();
            double result = _uut.Accumulator;
            double ExpectedResult = 0;
            Assert.That(result, Is.EqualTo(ExpectedResult));
        }

        [Test]
        public void Divide_DivideWithZero_ReturnException()
        {
            
           _uut.Clear();
           Assert.Throws<DividedByZero>(() => _uut.Divide(3,0));
          
        }

        [TestCase(2, 2,25)]
        [TestCase(4, 4,6.25)]
        [TestCase(-0.5, -0.5,400)]
        public void Divide_DicideAccumilator(double a, double b, double ExpectedResult)
        {
            _uut.Clear();
            _uut.Add(100);

            _uut.Divide(a);
            double result = _uut.Divide(b);
            Assert.That(result, Is.EqualTo(ExpectedResult).Within(0.0000001));
        }
    }
}