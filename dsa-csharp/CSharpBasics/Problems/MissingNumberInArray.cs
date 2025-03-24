namespace dsa_csharp.CSharpBasics.Problems
{
    public class MissingNumberInArray
    {
        //Find the missing number in an array of integers from 1 to n.

        public static void FindMissingNumber(int[] nums)
        {
            var hashSet = new HashSet<int>(nums);

            for (int i = 1; i < nums.Length; i++) 
            {
                if (!hashSet.Contains(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
