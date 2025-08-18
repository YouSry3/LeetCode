

import java.util.HashMap;

class Solution {


    public int[] twoSum(int[] nums, int target) {
     HashMap<Integer, Integer> map = new HashMap<>(); // Store number and index

        for (int i = 0; i < nums.length; i++) {
            int complement = target - nums[i]; // Find the number needed

            if (map.containsKey(complement)) { 
                return new int[]{map.get(complement), i}; // Return indices if complement exists
            }

            map.put(nums[i], i); // Store current number and its index
        }

        return new int[]{};

    }
}