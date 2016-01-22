using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new CalculateSumOfTwoNumbersService();
            var request = new SumOfTwoNumbers
            {
                Value1 = 345,
                Value2 = 123
            };
            var response = service.Calculate(request);

            Assert.AreEqual(468, response.Result);
        }
    }
}
