public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        HashSet<int> visited = new HashSet<int>();
        int maxconsecutive = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            visited.Add(nums[i]);
        }
        foreach(int num in visited)
        {
            if(!visited.Contains(num - 1))
            {
                int newnum = num;
                int currentconsecutive = 1;
                while(visited.Contains(newnum + 1))
                {
                    currentconsecutive++;
                    newnum++;
                }
                if(currentconsecutive > maxconsecutive)
                {
                    maxconsecutive = currentconsecutive;
                }
            }
        }
        return maxconsecutive;
    }
}
