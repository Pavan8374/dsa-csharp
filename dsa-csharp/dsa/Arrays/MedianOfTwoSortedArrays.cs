namespace dsa_csharp.dsa.Arrays
{
    public class MedianOfTwoSortedArrays
    {
        //4.: https://leetcode.com/problems/median-of-two-sorted-arrays/
        //4. Median of Two Sorted Arrays
        //Given two sorted arrays nums1 and nums2 of size m and n respectively,
        //return the median of the two sorted arrays.   
        //The overall run time complexity should be O(log (m+n)).

        //ex:
        //Input: nums1 = [1,3], nums2 = [2]
        //Output: 2.00000
        //Explanation: merged array = [1,2,3] and median is 2.

        //using merging and sorting 
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            List<int> mergedList = new List<int>(nums1);
            mergedList.AddRange(nums2);

            var sortedArray = mergedList.OrderBy(num => num).ToList();
            var count = sortedArray.Count();

            double median = 0.0;
            if (count % 2 != 0)
            {
                //median = n/2 th term + 1  
                median = sortedArray[(count + 1) / 2 - 1];
            }

            else
            {
                // median = (n/2) th + ((n/2) + 1) th/ 2
                //since array index start from 0 we need to subtract -1 to the n/2 so we can get the exact term
                int mid = count / 2;
                int n_2 = sortedArray[mid - 1];
                int n_2Plus1 = sortedArray[mid  + 1 - 1];
                median =(n_2 + n_2Plus1) / 2.0;
            }
            return median;

        }

        //Using binary search
        public static double Find_MedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                return Find_MedianSortedArrays(nums2, nums1);

            int m = nums1.Length, n = nums2.Length;
            int left = 0, right = m;
        
            while (left <= right)
            {
                int i = (left + right) / 2;  // Partition index for nums1
                int j = (m + n + 1) / 2 - i;  // Partition index for nums2

                int maxLeft1 = (i == 0) ? int.MinValue : nums1[i - 1];
                int minRight1 = (i == m) ? int.MaxValue : nums1[i];

                int maxLeft2 = (j == 0) ? int.MinValue : nums2[j - 1];
                int minRight2 = (j == n) ? int.MaxValue : nums2[j];

                if (maxLeft1 <= minRight2 && maxLeft2 <= minRight1)
                {
                    if ((m + n) % 2 == 0)
                        return (Math.Max(maxLeft1, maxLeft2) + Math.Min(minRight1, minRight2)) / 2.0;
                    else
                        return Math.Max(maxLeft1, maxLeft2);
                }
                else if (maxLeft1 > minRight2)
                    right = i - 1;
                else
                    left = i + 1;
            }

            throw new ArgumentException("Input arrays are not sorted.");
        }


    }
}
