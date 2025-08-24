public class Solution {
      public int MissingNumber(int[] nums)
        {
            int len = nums.Length;

            for (int number = 0; number <= len; number++)
            {
                bool found = false;
                for (int i = 0; i < len; i++)
                {
                    if (nums[i] == number)
                    {
                        found = true;
                        break; // no need to keep checking
                    }
                }

                if (!found)
                {
                    return number; // return immediately when missing number is found
                }
            }

            return -1; // should never reach here
        }
}