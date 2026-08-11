public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] output = new int[nums.Length];
        output[0] = 1;
        for(int i = 1; i < nums.Length; i++)
        {
            output[i] = nums[i - 1] * output[i - 1];
        }
        int product = 1;
        for(int i = nums.Length - 2; i >= 0; i--)
        {
            product = nums[i + 1] * product;
            output[i] *= product;
        }
        return output;
    }
}
