namespace dsa_csharp.dsa.Easy
{
    // 9. Palindrome Number
    // https://leetcode.com/problems/palindrome-number/
    // Example 1: Input: x = 121, Output: true,  Explanation: 121 reads as 121 from left to right and from right to left
    internal class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            string s = x.ToString();
            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
