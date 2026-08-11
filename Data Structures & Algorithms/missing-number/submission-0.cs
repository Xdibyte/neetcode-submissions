public class Solution {
    public int MissingNumber(int[] nums) 
    {
        int psum = (nums.Length * (nums.Length + 1 ))/2;
        int asum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            asum += nums[i];
        }   
        return psum - asum;
    }
}
