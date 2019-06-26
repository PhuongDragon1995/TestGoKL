using System;

namespace CodingTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            var generatedReferenceNumber = string.Format("{0:#,0.####}", Task2.GenerateReferenceNumber("543215432154321"));
            Console.WriteLine("[Task2_Basic] The monthly repayment is: {0}", generatedReferenceNumber);
            Console.ReadKey();
        }
    }
}
