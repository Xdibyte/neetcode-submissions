public class Solution {
    public int FindDuplicate(int[] nums) 
    {
        HashSet<int> visited = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(visited.Contains(nums[i]))
            {
                return nums[i];
            }
            visited.Add(nums[i]);
        }
        return -1;
    }
}
