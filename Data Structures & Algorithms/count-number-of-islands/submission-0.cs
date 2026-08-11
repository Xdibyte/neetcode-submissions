public class Solution {
    public int NumIslands(char[][] grid) 
    {
        HashSet<(int, int)> visited = new HashSet<(int, int)>();
        int noislands = 0;
        for(int i = 0; i < grid.Length; i++)
        {   
            for(int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1' && !visited.Contains((j, i)))
                {
                    noislands++;
                    DFS(j, i);
                }
            }
        }
        return noislands;

        void DFS(int x, int y)
        {
            if ((x < 0 || x >= grid[0].Length) || (y < 0 || y >=      grid.Length || grid[y][x] == '0' || visited.Contains((x,y))))
            {
                return;
            }
            visited.Add((x, y));
            DFS(x + 1, y);
            DFS(x - 1, y);
            DFS(x, y + 1);
            DFS(x, y - 1);
        }
    }
}
