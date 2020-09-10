using NUnit.Framework;

using System;
using Lommeregner;
namespace Lommeregner.Unit.Test
{
    [TestFixture]
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
            var uut = new Calculator();
        }

        [Test]
        public void Add_AddingTwoPositiveIntegers_NItemIsCorrect()
        {
            //Arrange
            var uut = new Calculator();


            //Act
            double numberA = 3;

            var testResult = uut.Add(numberA);

            var expectedResult = numberA;

            //Assert
            Assert.That(testResult, Is.EqualTo(expectedResult));
            Assert.Pass();
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
        public void Substracted_TestCases(double a, double b, double result)
        {
            var uut = new Calculator();
            
            Assert.That(uut.Substracted(a,b), Is.EqualTo(result).Within(0.0001));
        }

        [TestCase(2, 3, 8)]
        [TestCase(0.5,0.7,0.61557)]
        [TestCase(5,0,1)]
        [TestCase(0,5,0)]
        public void Exponed_TestCases(double a, double b, double result)
        {
            var uut = new Calculator();
            
            Assert.That(uut.Exponed(a,b), Is.EqualTo(result).Within(0.0001));
        }

        





    }
}