namespace dsa_csharp.CSharpBasics.Problems
{
    public class ReverseAString
    {
        // Write a function to reverse a string without using built-in functions.

        public static void ReverseString()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            string result = BuiltInReverseString(input);
            string result2 = ReverseString(input);


            Console.WriteLine($"Here is the reversed input string: {result}");
            Console.WriteLine($"Here is the reversed input string: {result2}");
        }

        /// <summary>
        /// Reverse a string using builtin methods.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static string BuiltInReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Reverse a string without any inuilt methods.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static string ReverseString(string input)
        {
            char[] charArray = new char[input.Length];
            int forwardIndex = 0;
            int backwardIndex = input.Length - 1;

            while (backwardIndex >= 0)
            {
                charArray[forwardIndex] = input[backwardIndex];
                forwardIndex++;
                backwardIndex--;
            }

            return new string(charArray);
        }
    }
}
