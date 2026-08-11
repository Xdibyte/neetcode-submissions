public class Solution 
{
    public int MaxArea(int[] heights) 
    {
        int l = 0;
        int r = heights.Length - 1;
        int maxamount = 0;
        while(l < r)
        {
            int lh = heights[l];
            int b = r - l;
            int h = Math.Min(lh, heights[r]);
            if(b * h > maxamount)
            {
                maxamount = b * h;
            }
            if(lh == h)
            {
                l++;
            }
            else
            {
                r--;
            }
        }
        return maxamount;
    }
}
