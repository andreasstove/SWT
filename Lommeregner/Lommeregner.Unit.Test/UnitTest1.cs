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
           /* var uut = new Calculator();
            
            double numberA = 5;
            double NumberB = 7;
            
            
            Assert.That(uut.Accumulator, Is.EqualTo(12));

        */
        }

        [TestCase(3, 3, 6)]
        [TestCase(4,-2,2)]
        public void Added_Test(double a, double b, double result)
        {
            Calculator uut = new Calculator();
            Assert.That(uut.Added(a,b),Is.EqualTo(result));
        }
    }
}