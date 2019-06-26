namespace CodingTask2
{
    public class Task2
    {
        public static string GenerateReferenceNumber(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;
            int a = 0, b = 0, c = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 3 == 0)
                {
                    a += int.Parse(input[i].ToString()) * 3;
                }
                else if (i % 3 == 1)
                {
                    b += int.Parse(input[i].ToString()) * 5;
                }
                else if (i % 3 == 2)
                {
                    c += int.Parse(input[i].ToString()) * 7;
                }
            }
            var s = a + b + c;
            var digit = ReducingToSingleDigit(s.ToString());
            return input + digit;
        }

        public static string ReducingToSingleDigit(string input)
        {
            var digit = 0;
            var length = input.Length;
            if (input.Length <= 1) return input;
            if (input.Length > 1)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    digit += int.Parse(input[i].ToString());
                }
            }
            return ReducingToSingleDigit(digit.ToString());
        }
    }
}
