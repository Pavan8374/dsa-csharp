namespace dsa_csharp.CSharpBasics.Problems
{
    public class FindFactorial
    {

        //Write a recursive function to calculate the factorial of a number.
        public static void Find_Factorial()
        {
            Console.WriteLine("Enter input number: ");

            var input = Console.ReadLine();

            int i = int.Parse(input);
            Console.WriteLine($"{Factorial(i)}");

        }

        static int Factorial(int input) 
        {
            //example: 3 =>  3 * 2 * 1 = 6, 4 => 4 * 3 * 2 * 1 = 24;

            if (input <= 1)
                return 1;
            else
                return input * Factorial(input - 1);

        }
    }
}
