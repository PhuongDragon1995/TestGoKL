using System;

namespace TestForGoKL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input1:ABCDEFGHIJ");
            char[] input1 = "ABCDEFGHIJ".ToCharArray();
            char[] output1 = CyclicSort(input1, 7);
            Console.WriteLine("output1: " + new String(output1));
            char[] input2 = "0123456789ABCDEF".ToCharArray();
            Console.WriteLine("input2:0123456789ABCDEF");
            char[] output2 = CyclicSort(input2, 11);
            Console.WriteLine("output2: " + new String(output2));
            Console.ReadKey();
        }

        static char[] CyclicSort(char[] input, int order)
        {
            if (order < 1) return input;
            string string1 = "";
            int index = order;
            while (index > input.Length)
            {
                index = index - input.Length;
            }
            string string2 = new string(input);
            for (int i = 0; i < order; i++)
            {
                var character = string2[index - 1];
                string1 += character.ToString();
                string2 = string2.Remove(index - 1, 1);
                if (string2.Length == 0) break;
                index = index - 1 + order;
                while (index > string2.Length)
                {
                    index = index - string2.Length;
                }
            }
            return (string1 + string2).ToCharArray();
        }
    }
}
