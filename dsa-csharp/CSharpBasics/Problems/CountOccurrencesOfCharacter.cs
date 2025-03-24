namespace dsa_csharp.CSharpBasics.Problems
{
    public class CountOccurrencesOfCharacter
    {
        //Write a function to count the occurrences of a given character in a string.

        public static void CountOccurence()
        {
            Console.WriteLine("Enter input: ");

            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("input is empty!");

            var result = ComputeOccurences(input);
            foreach (var occurence in result) 
            {
                Console.WriteLine($"Here is the occurences Key: {occurence.Key}: value: {occurence.Value}");
            }
        }

        static Dictionary<string, int> ComputeOccurences(string input)
        {
            var result = new Dictionary<string, int>();

            //foreach (char c in input) 
            //{
            //    string key = c.ToString();
           
            //    if (result.ContainsKey(key))
            //    {
            //        result[key]++;
            //    }
            //    else
            //    {

            //        result[key] = 1;
            //    }
            //}

            //More optimzed one for better performance.
            foreach (char c in input)
            {
                string key = c.ToString();
                result[key] = result.GetValueOrDefault(key) + 1;
            }

            return result;
        }
    }
}
