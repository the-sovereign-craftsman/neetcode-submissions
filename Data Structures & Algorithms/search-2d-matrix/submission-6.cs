public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        //naive solution is binary search rows first
        //Identify row and the binary search within row
        //More eloquent solution is consider indexes flattened, and convert to row, column using math. i / col = row. i % col = inded in row.

        //first find mid
        var l = 0;
        var r = matrix.Length * matrix[0].Length - 1;

        while (l <= r) {
            var m = l + (r - l) / 2;

            //convert m to matrix
            var row = m / matrix[0].Length;
            var i = m % matrix[0].Length;

            if (matrix[row][i] < target){
                l = m + 1;
            }
            else if (matrix[row][i] > target) {
                r = m - 1;
            }
            else {
                return true;
            }
        }

        return false;
    }
}
