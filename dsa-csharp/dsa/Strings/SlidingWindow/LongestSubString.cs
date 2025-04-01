namespace dsa_csharp.dsa.Strings.SlidingWindow
{
    public class LongestSubString
    {
        public static int Longest_String(string s)
        {
            int left = 0, maxLength = 0;

            var set = new HashSet<char>();
            for(int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }
                set.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            return maxLength;
        }
    }
}
