namespace dsa_csharp.dsa.Arrays
{
    //2873. Maximum Value of an Ordered Triplet I
    //https://leetcode.com/problems/maximum-value-of-an-ordered-triplet-i

    //You are given a 0-indexed integer array nums.
    //Return the maximum value over all triplets of indices (i, j, k) such that i < j < k.
    //If all such triplets have a negative value, return 0.
    //The value of a triplet of indices (i, j, k) is equal to (nums[i] - nums[j]) * nums[k].

    //Example: Input: nums = [12,6,1,2,7], Output: 77, 
    // The value of the triplet (0, 2, 4) is (nums[0] - nums[2]) * nums[4] = 77.
    public class OrderedTripletI
    {
        public static long MaximumTripletValue(int[] nums)
        {

            int n = nums.Length;
            if (n < 3) return 0;

            // Step 1: Prefix max array for max nums[i] before j

            int[] prefixMax = new int[n];
            prefixMax[0] = nums[0];

            for (int i = 1; i < n; i++)  //iterating from  2nd element to the last element
            {
                prefixMax[i] = Math.Max(prefixMax[i], nums[i]);  
            }

            // Step 2: Suffix max array for max nums[k] after j
            int[] suffixMax = new int[n];   
            suffixMax[n-1] = nums[n-1];   //set the index last element

            for (int k = n-2; k >= 0; k--)  //iterating from last 2nd element to the first element
            {
                suffixMax[k] = Math.Max(suffixMax[k + 1], nums[k]);
            }

            // Step 3: Iterate over j and calculate maximum triplet value

            long maxTripletValue = 0;

            for (int j = 1; j < n - 1; j++)
            {
                int maxI = prefixMax[j - 1]; // Best nums[i] before j
                int maxK = suffixMax[j + 1]; // Best nums[k] after j
                long value = (long)(maxI - nums[j]) * maxK;
                maxTripletValue = Math.Max(maxTripletValue, value);
            }
            return maxTripletValue;
        }
    }
}
