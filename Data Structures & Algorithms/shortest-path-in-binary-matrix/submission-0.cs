public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        var myQ = new Queue<(int x, int y)>();
        var rowLength = grid.Length;
        var colLength = grid[0].Length;
        var visited = new HashSet<(int x, int y)>();
        var length = 1;

        if (grid[0][0] == 1) {
            return -1;
        }

        myQ.Enqueue((0, 0));

        var neighbors = new List<(int dx, int dy)>
        {
            (0, 1), (0, -1), (1, 0), (-1, 0),
            (-1, 1), (-1, -1), (1, 1), (1, -1)
        };

        while (myQ.Any()) { //outer loop while q has items
            var count = myQ.Count();
            for (var i = 0; i < count; i++) { //inner q size loop
                (int row, int col) = myQ.Dequeue();

                //end of grid
                if (row == rowLength - 1 && col == colLength - 1) {
                    return length;
                }

                foreach (var (dr, dc) in neighbors) {
                    var rdr = row + dr;
                    var cdc = col + dc;
                    if (Math.Min(rdr, cdc) < 0
                        || rdr >= rowLength
                        || cdc >= colLength
                        || visited.Contains((rdr, cdc))
                        || grid[rdr][cdc] == 1) 
                    {
                        continue;
                    }

                    myQ.Enqueue((rdr, cdc));
                    visited.Add((rdr, cdc));
                }
            }
            length += 1;
        }

        return -1;
    }
}

//matrix BFS
//neighbors will include all adjacent and diagonal cells