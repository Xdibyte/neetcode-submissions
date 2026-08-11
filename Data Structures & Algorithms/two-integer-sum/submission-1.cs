public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> previous = new Dictionary<int, int>();
        int[] output = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            if(!previous.ContainsKey(nums[i]))
            {
                previous.Add(nums[i],i);
            }
            int d = target - nums[i];
            if(previous.TryGetValue(d,out int j))
            {
                output[0] = j;
                output[1] = i;
            }
        }
        return output;
    }
}
