public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        for(int i = 0; i < matrix.Length; i++)
        {
            int l = 0;
            int h = matrix[0].Length - 1;
            while(l <= h)
            {
                int m = (l + h) / 2;
                if(matrix[i][m] == target)
                {
                    return true;
                }
                else if(matrix[i][m] < target)
                {
                    l = m + 1;
                }
                else
                {
                    h = m - 1;
                }
            }
        }
        return false;
    }
}
