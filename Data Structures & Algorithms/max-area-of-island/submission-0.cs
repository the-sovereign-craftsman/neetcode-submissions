public class Solution {
    private int _maxArea = 0;
    private int _count = 0;
    public int MaxAreaOfIsland(int[][] grid) {
        for (var r = 0; r < grid.Length; r++) {
            for (var c = 0; c < grid[r].Length; c++) {
                if (grid[r][c] == 1) {
                    Scan(grid, r, c);
                    _maxArea = Math.Max(_maxArea, _count);
                    _count = 0;
                }
            }
        }

        return _maxArea;
    }

    private void Scan(int[][] grid, int r, int c) {
        var rowLength = grid.Length;
        var colLength = grid[0].Length;
        
        //base case
        if (Math.Min(r, c) < 0
            || r >= rowLength
            || c >= colLength
            || grid[r][c] == 0) 
        {
            return;
        }

        //do something
        _count++;
        grid[r][c] = 0;

        //recurse
        Scan(grid, r + 1, c);
        Scan(grid, r - 1, c);
        Scan(grid, r, c + 1);
        Scan(grid, r, c - 1);
    }
}
