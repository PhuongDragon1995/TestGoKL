using System;

namespace CodingTask1
{
    public class Task1
    {
        public static double CalculateAmortizationPayment(double principalAmount, double ratePerPeriod, int loanPeriod)
        {
            var amortizationPayment = principalAmount * ratePerPeriod / (12 * 100) * Math.Pow(1 + (ratePerPeriod / (12 * 100)), loanPeriod * 12) / (Math.Pow(1 + ratePerPeriod / (12 * 100), loanPeriod * 12) - 1);
            return Math.Round(amortizationPayment, 2);
        }

        public static double CalculateLoanPeriod(double principalAmount, double ratePerPeriod, double amortization)
        {
            var x = amortization / (principalAmount * (ratePerPeriod / (12 * 100)));
            return Math.Round(Math.Log(x / (x - 1), 1 + ratePerPeriod / (12 * 100)) / 12, 2);
        }

        public static double CalculatePrincipalAmount(double amortization, double ratePerPeriod, double loanPeriod)
        {
            var principalAmount = amortization * (Math.Pow(1 + ratePerPeriod / (12 * 100), loanPeriod * 12) - 1) / (ratePerPeriod / (12 * 100) * Math.Pow(1 + (ratePerPeriod / (12 * 100)), loanPeriod * 12));
            return Math.Round(principalAmount, 2);
        }
    }
}
