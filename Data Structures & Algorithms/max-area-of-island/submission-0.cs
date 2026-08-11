public class Solution {
    public int MaxAreaOfIsland(int[][] grid) 
    {
        HashSet<(int, int)> visited = new HashSet<(int, int)>();
        int maxarea = 0;
        int currentarea = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1 && !visited.Contains((j,i)))
                {
                    currentarea = 0;
                    DFS(j, i);
                    if(currentarea > maxarea)
                    {
                        maxarea = currentarea;
                    }
                }
            }
        }
        return maxarea;

        void DFS(int x, int y)
        {
            if(OutOfBounds(x,y) || grid[y][x] == 0 ||   visited.Contains((x,y)))
            {
                return;
            }
            visited.Add((x,y));
            currentarea++;
            DFS(x + 1, y);
            DFS(x - 1, y);
            DFS(x, y + 1);
            DFS(x, y - 1);
        }

        bool OutOfBounds(int x, int y)
        {
            return x < 0 || x >= grid[0].Length || y < 0 || y >= grid.Length;
        }
    }
}
