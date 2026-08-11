public class Solution {
    public int Search(int[] nums, int target) 
    {
        int l = 0;
        int h = nums.Length - 1;
        while(l <= h)
        {
            int m = (l + h) / 2;
            if(nums[m] == target)
            {
                return m;
            }
            else if(nums[m] > target)
            {
                h = m - 1;
            }
            else
            {
                l = m + 1;
            }
        }
        return -1;
    }
}
