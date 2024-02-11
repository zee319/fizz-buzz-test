using System;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
      
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenDivisibleByThreeShouldReturnFizz()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equals("Fizz", null);
        }

        [Test]
        public void WhenDivisibleByFiveShouldReturnBuzz()
        {
            // Arrange
            // Act
            // Assert
            Assert.Equals("Buzz", null);
        }

        [Test]
        public void WhenDivisibleByFiveAndThreeShouldReturnFizzBuzz()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equals("FizzBuzz", null);
        }
    }
}