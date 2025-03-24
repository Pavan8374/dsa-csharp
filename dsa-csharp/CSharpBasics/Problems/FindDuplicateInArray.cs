namespace dsa_csharp.CSharpBasics.Problems
{
    public class FindDuplicateInArray
    {
        //Find the duplicate number in an array where values are between 1 to n.

        public static void Find_Duplicate_In_Array(int[] nums)
        {
            if(nums == null || !nums.Any())
            {
                throw new ArgumentException("Array is empty!");
            }

            var maps = new HashSet<int>();

            foreach (var map in nums) 
            {
                if (!maps.Add(map))
                {
                    Console.WriteLine($"Duplicate value: {map} ");
                }
            }
        }

    }
}
