using CodingTask1;
using NUnit.Framework;

namespace Test
{
    class Task1Test
    {
        [Test]
        public void CalculateAmortizationPaymentTest()
        {
            var principalAmount = 500000;
            var ratePerPeriod = 4.45;
            var loanPeriod = 30;
            var monthlyRepayment = Task1.CalculateAmortizationPayment(0.9 * principalAmount, ratePerPeriod, loanPeriod);
            Assert.True(monthlyRepayment == 2266.73);
        }

        [Test]
        public void CalculateLoanPeriodTest()
        {
            var principalAmount = 500000;
            var ratePerPeriod = 4.65;
            var amortization = 2000;
            var loanPeriod = Task1.CalculateLoanPeriod(0.9 * principalAmount, ratePerPeriod, amortization);
            Assert.True(loanPeriod == 44.27);
        }

        [Test]
        public void CalculatePrincipalAmountTest()
        {
            var amortization = 2000;
            var ratePerPeriod = 4.65;
            var loanPeriod = 35;
            var loanAmountToBorrow = Task1.CalculatePrincipalAmount(amortization, ratePerPeriod, loanPeriod);
            Assert.True(loanAmountToBorrow == 414431.61);
        }
    }
}
