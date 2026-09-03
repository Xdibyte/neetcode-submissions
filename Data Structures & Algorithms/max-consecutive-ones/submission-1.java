class Solution {
    public int findMaxConsecutiveOnes(int[] nums) 
    {
        int maxConsecutive = 0;
        int consecutive = 0;
        for(int num : nums)
        {
            consecutive = num == 1 ? ++consecutive : 0;
            maxConsecutive = Math.max(consecutive, maxConsecutive);
        }
        return maxConsecutive;
    }
}