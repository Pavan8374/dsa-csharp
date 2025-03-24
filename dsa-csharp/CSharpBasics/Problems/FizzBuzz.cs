namespace dsa_csharp.CSharpBasics.Problems
{
    public class FizzBuzz
    {
        public static void Fizz_Buzz()
        {
            Console.WriteLine("Enter any number: ");

            var input = Console.ReadLine();

            int i = int.Parse(input);

            if(i == 0 || i == 1 || i == 2)
            {
                throw new Exception("Invalid input");
            }

            if (i % 3 == 0) 
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else
                {
                    Console.WriteLine("Fizz");
                }
            }
            
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
        }
    }
}
