using System;
using System.Collections.Generic;

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if (nums == null || nums.Length == 0) 
            return false;

        HashSet<int> seen = new HashSet<int>();
        foreach (int num in nums) {
            if (IsExit(seen, num)) {
                return true; // duplicate found
            }
            seen.Add(num);
        }
        return false; // no duplicates
    }

    // Optional helper (but not needed for LeetCode problem)
    public bool IsExit(HashSet<int> seen, int n) {
        return seen.Contains(n);
    }
}
