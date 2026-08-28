public class Solution {
    public int MaxArea(int[] heights) 
    {
        int l = 0;
        int r = heights.Length - 1;
        int max = 0;
        while(l < r)
        {
            int left = heights[l];
            int right = heights[r];
            int h = Math.Min(left, right);
            int b = r - l;
            max = Math.Max(max, h * b);
            if(left > right)
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
