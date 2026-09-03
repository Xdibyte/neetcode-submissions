class Solution {
    public int findMaxConsecutiveOnes(int[] nums) 
    {
        int maxconsecutive = 0;
        int consecutive = 0;
        for(int i = 0; i < nums.length; i++)
        {
            if(nums[i] == 1)
            {
                consecutive++;
                maxconsecutive = Math.max(consecutive, maxconsecutive);
                continue;
            }
            consecutive = 0;
        }
        return maxconsecutive;
    }
}