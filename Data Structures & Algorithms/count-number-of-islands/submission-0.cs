public class Solution {
    public int NumIslands(char[][] grid) {
        var count = 0;
        for (var r = 0; r < grid.Length; r++) {
            for (var c = 0; c < grid[0].Length; c++) {
                if (grid[r][c] == '1') {
                    count++;
                    Scan(grid, r, c);
                }
            }
        }

        return count;
    }

    public void Scan(char[][] grid, int r, int c) {
        var rowLength = grid.Length;
        var colLength = grid[0].Length;

        //base case
        if (Math.Min(r, c) < 0 
            || r >= rowLength
            || c >= colLength
            || grid[r][c] == '0')
        {
            return;
        }

        //do something
        grid[r][c] = '0';

        //recurse
        Scan(grid, r + 1, c);
        Scan(grid, r - 1, c);
        Scan(grid, r, c + 1);
        Scan(grid, r, c - 1);   
    }
}
