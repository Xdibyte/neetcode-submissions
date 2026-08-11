public class Solution 
{
    public int MaxArea(int[] heights) 
    {
        int l = 0;
        int r = heights.Length - 1;
        int maxamount = 0;
        while(l < r)
        {
            int b = r - l;
            int h = Math.Min(heights[l], heights[r]);
            int amount = b * h;
            if(b * h > maxamount)
            {
                maxamount = b * h;
            }
            if(heights[l] == h)
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
