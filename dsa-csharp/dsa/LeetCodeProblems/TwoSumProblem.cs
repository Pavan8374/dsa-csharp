namespace dsa_csharp.dsa.LeetCodeProblems
{
    public class TwoSumProblem
    {

        //Link: https://leetcode.com/problems/two-sum/

        //Given an array and a target, return the indices of two numbers that sum up to the target.

        public static int[] Two_Sum(int[] nums, int target)
        {
            if (nums == null || !nums.Any())
                throw new ArgumentNullException("Array is empty");

            var maps = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var num1 = target - nums[i];
                if (maps.ContainsKey(num1))
                {
                    return [i, maps[num1]];
                }
                maps[nums[i]] = i;
            }
            return [-1, -1];
        }
    }
}
