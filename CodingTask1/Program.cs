using System;

namespace CodingTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            var monthlyRepayment = string.Format("{0:#,0.####}", Task1.CalculateAmortizationPayment(0.9 * 500000, 4.65, 30));
            Console.WriteLine("[Task1_Basic] The monthly repayment is: {0}", monthlyRepayment);
            var loanPeriod = string.Format("{0:#,0.####}", Task1.CalculateLoanPeriod(0.9 * 500000, 4.65, 2000));
            Console.WriteLine("[Task1_Advance1] The loan period is :{0}", loanPeriod);
            var loanAmountToBorrow = string.Format("{0:#,0.####}", Task1.CalculatePrincipalAmount(2000, 4.65, 35));
            Console.WriteLine("[Task1_Advance2] The loan amount to borrow is :{0}", loanAmountToBorrow);
            Console.ReadKey();
        }
    }
}
