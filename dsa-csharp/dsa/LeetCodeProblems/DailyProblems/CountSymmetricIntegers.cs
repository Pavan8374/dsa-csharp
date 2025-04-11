namespace dsa_csharp.dsa.LeetCodeProblems.DailyProblems
{
    // 2843. Count Symmetric Integers
    // https://leetcode.com/problems/count-symmetric-integers
    // Input: low = 1, high = 100
    // Output: 9
    // Explanation: There are 9 symmetric integers between 1 and 100:
    // 11, 22, 33, 44, 55, 66, 77, 88, and 99.
    public class CountSymmetricIntegers
    {
        public static int Count_Symmetric_Integers(int low, int high)
        {

            if (low < 1)
                throw new ArgumentException();

            int count = 0;
            for (int i = low; i <= high; i++)
            {

                string s = i.ToString();
                int len = s.Length;
                if (s.Length % 2 != 0)
                {
                    continue;
                }

                int half = len / 2;
                int leftSum = 0, rightSum = 0;

                for (int num = 0; num < half; num++)
                {

                    leftSum += s[num] - '0';
                    rightSum += s[num + half] - '0';
                }

                if (leftSum == rightSum)
                {
                    count++;
                }
            }
            return count;

        }
    }
}
