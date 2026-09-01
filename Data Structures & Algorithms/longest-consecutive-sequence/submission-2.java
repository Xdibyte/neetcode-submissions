class Solution {
    public int longestConsecutive(int[] nums) 
    {
        HashSet<Integer> numbers = new HashSet<Integer>();
        int maxcount = 0;
        for(int i = 0; i < nums.length; i++)
        {
            numbers.add(nums[i]);
        }
        for(Integer num : numbers)
        {
            if(!numbers.contains(num - 1))
            {
                Integer newnum = num - 1;
                int count = 0;
                while(numbers.contains(newnum + 1))
                {
                    newnum = newnum + 1;
                    count = count + 1;
                }
                maxcount = Math.max(count, maxcount);
                
            }
        }
        return maxcount;
    }
}
