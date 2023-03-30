using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calc = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var actual = calc.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,0)]//Add test data <-------
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:



            //Arrange

            var calc = new Calculator();

            //Act

            var actual = calc.Subtract(minuend, subtrhend);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,2,4)]//Add test data <-------
        public void Multiply(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var calc = new Calculator();

            //Act

            var actual = calc.Multiply(num1, num2);

            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,1)]//Add test data <-------
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange

            var calc = new Calculator();

            //Act

            var actual = calc.Divide(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

    }
}
