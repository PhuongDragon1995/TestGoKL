using CodingTask2;
using NUnit.Framework;

namespace Test
{
    class Task2Test
    {
        [Test]
        public void CalculateAmortizationPaymentTest()
        {
            var input = "20160513123";
            var monthlyRepayment = Task2.GenerateReferenceNumber(input);
            Assert.True(monthlyRepayment == "201605131234");
        }

        [TestCase("", "")]
        [TestCase("24", "6")]
        [TestCase("999", "9")]
        [TestCase("1289", "2")]
        public void ReducingToSingleDigitTest(string input, string expected)
        {
            var output = Task2.ReducingToSingleDigit(input);
            Assert.True(expected == output);
        }
    }
}
