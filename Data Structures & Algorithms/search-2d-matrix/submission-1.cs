public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        int i = 0;
        while(i < matrix.Length)
        {
            if(target >= matrix[i][0] && target <= matrix[i][matrix[0].Length - 1])
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
                return false;
            }
            else
            {
                i++;
            }
        }
        return false;
    }
}
