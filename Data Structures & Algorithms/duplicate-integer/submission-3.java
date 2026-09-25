class Solution {
    public boolean hasDuplicate(int[] nums) 
    {
        Set<Integer> duplicates = new HashSet<>();
        for(int num : nums)
        {
            if(duplicates.contains(num))
            {
                return true;
            }
            duplicates.add(num);
        }
        return false;
    }
}