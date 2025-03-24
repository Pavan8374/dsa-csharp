namespace dsa_csharp.CSharpBasics.Problems
{
    public class PalindromeCheck
    {
        public static void Palindrome_Check()
        {
            Console.WriteLine("Enter input:");
            string input = Console.ReadLine();
            bool output = IsPalindrome(input);
            bool output2 = Is_Palindrome(input);
            Console.WriteLine(output);
            Console.WriteLine(output2);
        }

        /// <summary>
        /// Bult in
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static bool Is_Palindrome(string input) 
        {
            char[] chars = input.ToCharArray();

            Array.Reverse(chars);

            return new string(chars).Equals(input);
        }

        /// <summary>
        /// without any builtin methods.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        static bool IsPalindrome(string input)
        {
            //char[] chars = new char[input.Length];


            // ASASA:  TOTAL LENGTH = 5 => 5/2 = 2 NEED TO CHECK FOWARD INDEX 2 AND BACKWARD INDEX 2
            // ASAASA:  TOTAL LENGTH = 6 => 6/2 = 3

            int length = input.Length;
            if (length == 0 || length == 1) 
            {
                throw new ArgumentException("Input is empty or not meeting requirements!, please enter atleast 2 letters");
            }

            for (int i = 0; i < length/2; i++) 
            { 
                Console.WriteLine($"{input[i]} {input[length - i - 1]}");
                if(input[i] != input[length - i - 1])
                {
                    return false;
                }
            }
            return true;

        }

        // Explanation, extend in steps
        static bool Check(string input)
        {
            int length = input.Length; 

            for (int i = 0; i < length/2; i++) // ex: ASASA => length = 5, total iterations => 5/2 = 2
            {    
                
                // 0 => at index 0 is A = at index 4 is A
                // 1 => at index 1 is A = at index 3 is s

                if (input[i] != input[length - i - 1])
                {
                    return false;
                }
            }
            return true;

        }
    }
}
