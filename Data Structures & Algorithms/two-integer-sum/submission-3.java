class Solution {
    public int[] twoSum(int[] nums, int target) {
        HashMap<Integer, Integer> visited = new HashMap<Integer, Integer>();
        for(int i = 0; i < nums.length; i++)
        {
            int d = target - nums[i];
            if(visited.containsKey(d))
            {
                return new int[]
                {
                    visited.get(d), i
                };
            }
            visited.put(nums[i], i);
        }
        return new int[] { };
    }
}
