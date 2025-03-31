namespace dsa_csharp.CSharpBasics.Problems
{
    public class TwoSumProblem
    {
        //Given an array and a target, return the indices of two numbers that sum up to the target.

        public static void Two_Sum(int[] nums, int target)
        {

            if (nums == null || !nums.Any())
                throw new ArgumentNullException("Array is empty");

            //[1,2,3,9] => [0,2], traget = 4

            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                //1: 3 = 4 - 1
                //2: 2 = 4 - 2
                //3: 1 = 4 - 3
                int complement = target - nums[i]; 

                // 1: 3 not in dictionary
                // 2: Another 2 not exists.
                // 3: 1 is existing
                if (map.ContainsKey(complement)) 
                {
                    // it will return indexs, one is we store the index as value of the key in dictionary,
                    // and another is throgh direcly from array index.
                    Console.WriteLine($"{map[complement]}, {i}"); 
                }

                //1. 1
                //2. 1,2
                
                map[nums[i]] = i;  //storing the index as key
            }

            if(!map.Any())
             Console.WriteLine($"-1, -1");
        }

    }
}
