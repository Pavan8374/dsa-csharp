namespace dsa_csharp.CSharpBasics.Problems
{
    public class RemoveDuplicatesFromAnArray
    {
        //Remove duplicate values from an integer array and return the distinct elements.
        public static void RemoveDuplicates(int[] nums)
        {
            var result = RemoveDuplicateFromArray(nums);
            foreach (int i in result) 
            {
                Console.WriteLine(i);
            }
        }

        static int[] RemoveDuplicateFromArray(int[] nums)
        {
            //if (nums == null || !nums.Any())
            //    throw new ArgumentException("Array is empty!");

            //var result = new Dictionary<int, int>();

            //foreach (int i in nums) 
            //{
            //    if (result.ContainsKey(i))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        result[i] = 1;
            //    }
            //}
            //return result.Keys.ToArray();

            //Optimized version

            var result = new HashSet<int>(nums); // HashSet automatically removes duplicates

            return result.ToArray();
        }
    }
}
