using CalculatorLib;

namespace CalculatorLibUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdding2And2()
        {
            //Arange(Varibales - Input & out Output)
            double a = 2;
            double b = 2;
            double expected = 4;

            Calculator calculator = new();

            double actual = calculator.Add(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdding3And2()
        {
            //arrange
            double a = 3;
            double b = 2;
            double expected = 5;
            Calculator calculator = new();

            //act 
            double actual = calculator.Add(a, b);

            Assert.Equal(expected, actual);
        }
    }
}