public class Solution {
    public int MaxArea(int[] heights) 
    {
        int l = 0;
        int r = heights.Length - 1;
        int max = 0;
        while(l < r)
        {
            int h = Math.Min(heights[l], heights[r]);
            int b = r - l;
            max = Math.Max(max, h * b);
            if(heights[l] > heights[r])
            {
                r--;
            }
            else
            {
                l++;
            }
        }
        return max;
    }
}
