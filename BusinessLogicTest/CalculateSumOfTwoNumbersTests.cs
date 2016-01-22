using BusinessLogic;
using Xunit;

namespace BusinessLogicTest
{
    public class CalculateSumOfTwoNumbersTests
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(2, 3, 5)]
        [InlineData(5, 8, 13)]
        [InlineData(100, 22, 122)]
        public void SumShouldBeCorrect(int inputValue1, int inputValue2, int expectedResult)
        {
            var service = new CalculateSumOfTwoNumbersService();
            var request = new SumOfTwoNumbers
            {
                Value1 = inputValue1,
                Value2 = inputValue2
            };
            var response = service.Calculate(request);

            Assert.Equal(expectedResult, response.Result);
        }
    }
}