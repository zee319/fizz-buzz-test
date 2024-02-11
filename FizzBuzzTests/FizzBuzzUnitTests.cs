using System;
using FizzBuzzTest;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private FizzBuzzLogicService fizzBuzzLogicService;

        [SetUp]
        public void Setup()
        {
            fizzBuzzLogicService = new FizzBuzzLogicService();
        }

        [Test]
        public void WhenDivisibleByThreeShouldReturnFizz()
        {
            //Arrange
            int number = 6; 

            // Act
            string result = fizzBuzzLogicService.GetFizzBuzz(number);

            // Assert
            Assert.Equals("Fizz", result);
        }

        [Test]
        public void WhenDivisibleByFiveShouldReturnBuzz()
        {
            // Arrange
            int number = 10; 

            // Act
            string result = fizzBuzzLogicService.GetFizzBuzz(number);

            // Assert
            Assert.Equals("Buzz", result);
        }

        [Test]
        public void WhenDivisibleByFiveAndThreeShouldReturnFizzBuzz()
        {
            // Arrange
            int number = 15; 

            // Act
            string result = fizzBuzzLogicService.GetFizzBuzz(number);

            // Assert
            Assert.Equals("FizzBuzz", result);
        }
    }
}