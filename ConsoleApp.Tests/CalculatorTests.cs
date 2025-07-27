using Xunit;
using ConsoleApp;

namespace ConsoleApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            var result = Calculator.Add(3, 4);
            Assert.Equal(7, result);
        }
    }
}