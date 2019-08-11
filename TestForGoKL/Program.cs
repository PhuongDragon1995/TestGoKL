using System;
using System.Collections.Generic;
using System.Linq;

namespace TestForGoKL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input1:ABCDEFGHIJ");
            char[] input1 = "ABCDE".ToCharArray();
            char[] output1 = CyclicSort(input1, 3);
            Console.WriteLine("output1: " + new String(output1));
            char[] input2 = "0123456789ABCDEF".ToCharArray();
            Console.WriteLine("input2:0123456789ABCDEF");
            char[] output2 = CyclicSort(input2, 11);
            Console.WriteLine("output2: " + new String(output2));
            //  BeforeCyclicSort("GDBACFJEHI".ToCharArray(), 7);
            var a = CalculateAmortizationPayment(0.9 * 500000, 4.445, 30);
            var b = CalculateLoanPeriod(0.9 * 500000, 4.65, 2000);
            var c = CalculatePrincipalAmount(2000, 4.65, 35);
            var d = GeneratedReferenceNumber("20160513123");
            Console.ReadKey();
        }

        static char[] CyclicSort(char[] input, int order)
        {
            if (order < 1 || input == null) return input;
            string leftString = "";
            int index = order;
            while (index > input.Length)
            {
                index = index - input.Length;
            }
            string rightString = new string(input);
            for (int i = 0; i < order; i++)
            {
                var character = rightString[index - 1];
                leftString += character.ToString();
                rightString = rightString.Remove(index - 1, 1);
                if (rightString.Length == 0) break;
                index = index - 1 + order;
                while (index > rightString.Length)
                {
                    index = index - rightString.Length;
                }
            }
            return (leftString + rightString).ToCharArray();
        }

        static double CalculateAmortizationPayment(double principalAmount, double ratePerPeriod, int loanPeriod)
        {
            return principalAmount * ratePerPeriod / (12 * 100) * Math.Pow(1 + (ratePerPeriod / (12 * 100)), loanPeriod * 12) / (Math.Pow(1 + ratePerPeriod / (12 * 100), loanPeriod * 12) - 1);

        }

        static double CalculateLoanPeriod(double principalAmount, double ratePerPeriod, double amortization)
        {
            var x = amortization / (principalAmount * (ratePerPeriod / (12 * 100)));
            return Math.Log(x / (x - 1), 1 + ratePerPeriod / (12 * 100)) / 12;
        }

        static double CalculatePrincipalAmount(double amortization, double ratePerPeriod, double loanPeriod)
        {
            return amortization * (Math.Pow(1 + ratePerPeriod / (12 * 100), loanPeriod * 12) - 1) / (ratePerPeriod / (12 * 100) * Math.Pow(1 + (ratePerPeriod / (12 * 100)), loanPeriod * 12));
        }

        static string GeneratedReferenceNumber(string input)
        {
            if (String.IsNullOrWhiteSpace(input)) return String.Empty;
            int a = 0, b = 0, c = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 3 == 0)
                {
                    a += Int32.Parse(input[i].ToString()) * 3;
                }
                else if (i % 3 == 1)
                {
                    b += Int32.Parse(input[i].ToString()) * 5;
                }
                else if (i % 3 == 2)
                {
                    c += Int32.Parse(input[i].ToString()) * 7;
                }
            }
            var s = a + b + c;
            var digit = ReducingToSingleDigit(s.ToString());
            return input + digit;
        }

        private static string ReducingToSingleDigit(string input)
        {
            var digit = 0;
            var length = input.Length;
            if (input.Length <= 1) return input;
            if (input.Length > 1)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    digit += Int32.Parse(input[i].ToString());
                }
            }
            return ReducingToSingleDigit(digit.ToString());
        }
    }
}
