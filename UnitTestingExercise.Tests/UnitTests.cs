using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var subTest = new UnitTestMethods();

            //Act
            var actual = subTest.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 10, 20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var multiTest = new UnitTestMethods();

            //Act
            var actual = multiTest.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var divTest = new UnitTestMethods();

            //Act
            var actual = divTest.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            var factTest1 = new UnitTestMethods();

            //Act
            var actual = factTest1.YourMethodName();

            //Assert
            Assert.Equal("Hello", actual);
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var factTest1 = new UnitTestMethods();
            //Act
            var actual = factTest1.YourMethodName2();
            //Assert
            Assert.Equal("World", actual);
        }
    }
}
