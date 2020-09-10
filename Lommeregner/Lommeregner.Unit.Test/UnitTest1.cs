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

        [TestCase(3,2,5)]
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
        public void Add_AddingOneNegativeIntegerAndOnePositiveInteger_NItemIsCorrect()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}