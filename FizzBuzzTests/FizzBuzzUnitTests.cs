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
            Assert.That("Fizz" == result);
        }

        [Test]
        public void WhenDivisibleByFiveShouldReturnBuzz()
        {
            int number = 10; 

            string result = fizzBuzzLogicService.GetFizzBuzz(number);

            Assert.That("Buzz" == result);
        }

        [Test]
        public void WhenDivisibleByFiveAndThreeShouldReturnFizzBuzz()
        {
           
            int number = 15; 
          
            string result = fizzBuzzLogicService.GetFizzBuzz(number);

            Assert.That("FizzBuzz" == result);
        }

        [Test]
        public void WhenNumberIsNotDivisibleByFiveOrThreeShouldReturnNumber()
        {
            int number = 11;

            string result = fizzBuzzLogicService.GetFizzBuzz(number);

            Assert.That("11" == result);
        }
    }
}