using System;

namespace CodingTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = "0123456789ABCDEF".ToCharArray();
            var order = 11;
            char[] output = Task3.CyclicSort(input, order);
            Console.WriteLine("[Task3_Basic] Output of 0123456789ABCDEF,if the order is 11 is: {0}", new string(output));
            Console.ReadKey();
        }
    }
}
