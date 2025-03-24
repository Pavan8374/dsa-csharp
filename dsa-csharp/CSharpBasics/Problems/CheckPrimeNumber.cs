using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dsa_csharp.CSharpBasics.Problems
{
    public class CheckPrimeNumber
    {
        //Write a function that returns true if a given number is prime.

        public static void CheckIfPrimeNumber()
        {
            Console.WriteLine("Enter a number: ");
            var input = Console.ReadLine();
            var result = IsPrimeNumber(int.Parse(input));
            if (result)
            {
                Console.WriteLine($"The number is prime number: {input}");
            }
            else
            {
                Console.WriteLine($"The number is not a prime number: {input}");
            }
        }

        static bool IsPrimeNumber(int number)
        {
            if (number < 0 || number == 1)
            {
                throw new ArgumentException("Number must be postive and greater than 1");
            }

            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            //for (int i = 3; i <= Math.Sqrt(number); i += 2)
            //{
            //    if (number % i == 0)
            //        return false;
            //}

            //For beginner level
            for (int i = 3; i <= number / 2; i += 2) // Skip even numbers after 2
            {
                if (number % i == 0)
                    return false; // If divisible, it's not prime
            }

            return true;

        }

    }
}
