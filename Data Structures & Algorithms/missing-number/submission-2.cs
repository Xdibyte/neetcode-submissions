public class Solution {
    public int MissingNumber(int[] nums) 
    {
        int n = nums.Length;
        int psum = (n * (n + 1 ))/2;
        int asum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            asum += nums[i];
        }   
        return psum - asum;
    }
}
