public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> duplicates = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(duplicates.Contains(nums[i]))
            {
                return true;
            }
            duplicates.Add(nums[i]);
        }
        return false;
    }
}