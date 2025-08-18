public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) return 0;

        int left = 0; // sliding window start
        int maxLength = 0;
        Dictionary<char, int> seen = new Dictionary<char, int>();

        for (int right = 0; right < s.Length; right++) {
            char current = s[right];

            // If character already seen, move the left pointer
            if (seen.ContainsKey(current) && seen[current] >= left) {
                left = seen[current] + 1;
            }

            seen[current] = right; // update last seen index
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
