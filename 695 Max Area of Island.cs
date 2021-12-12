/*
You are given an m x n binary matrix grid. An island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.) You may assume all four edges of the grid are surrounded by water.

The area of an island is the number of cells with a value 1 in the island.

Return the maximum area of an island in grid. If there is no island, return 0.
*/

// 41.36% 

public class Solution {
    public int MaxAreaOfIsland(int[][] grid)
        {
            if (grid == null) return 0;
            int count = 0, maxCount = 0;
            bool[,] visited = new bool[grid.Length, grid[0].Length];

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1) {
                        count = BFSarea(grid, i, j, visited);
                        if (maxCount < count) maxCount = count;
                        }
                }
            }
            
            return maxCount;
        }

        public int BFSarea(int[][] grid, int row, int col, bool[,] visited)
        {
            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((row, col));
            visited[row, col] = true;

            int area = 0;
            int[,] dir = new int[,] { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };

            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                area++;

                for (int i = 0; i < dir.GetLength(0); i++)
                {
                    int nextRow = curr.Item1 + dir[i, 0];
                    int nextCol = curr.Item2 + dir[i, 1];

                    if (nextRow >= 0 && nextRow < grid.Length && nextCol >= 0 && nextCol < grid[0].Length && !visited[nextRow, nextCol] && grid[nextRow][nextCol] == 1)
                    {
                        queue.Enqueue((nextRow, nextCol));
                        visited[nextRow, nextCol] = true;
                    }
                }
            }

            return area;
        }
}
