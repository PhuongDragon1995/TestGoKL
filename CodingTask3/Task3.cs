namespace CodingTask3
{
    public class Task3
    {
        public static char[] CyclicSort(char[] input, int order)
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
    }
}
