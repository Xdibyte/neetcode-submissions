public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {
        Array.Sort(nums);
        List<List<int>> output = new List<List<int>>();
        for(int i = 0; i < nums.Length - 2; i++)
        {
            if(i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            int j = i + 1;
            int k = nums.Length - 1;
            while(j < k)
            {
                int sum = nums[i] + nums[j] + nums[k];
                if(sum == 0) 
                {
                    output.Add(new List<int>()
                    {
                        nums[i], nums[j], nums[k]
                    });
                    j++; 
                    k--;
                    while(j > 0 && j < k && nums[j] == nums[j - 1])
                    {
                        j++;
                    }
                    while(k > j && k < nums.Length - 1 && nums[k] == nums[k + 1])
                    {
                        k--;
                    }
                }
                else if(sum < 0) j++;
                else k--;
            }
        }
        return output;
    }
}
