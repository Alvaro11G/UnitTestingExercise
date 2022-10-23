using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int Add(int one, int two, int three)
        {
            return one + two + three;
            
        }

        // Create a Subtract method that passes 2 integers
            // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minued, int subtrahend)
        {
            return minued - subtrahend;
            
        }

        // Create a Multiply method that passes 2 integers
        public int Multiply(int factor1, int factor2)
        {
            return factor1 * factor2;
            
        }

        // Create a Divide method that passes 2 integers
        public int Divide(int dividend, int divisor)
        {
            return dividend / divisor;
            
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string YourMethodName()
        {
            return "Hello";
        }
        
        public string YourMethodName2()
        {
            return "World";
        }
    }
}
