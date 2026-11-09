public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        //sorted array with a target = binary search
        //first binary search and identify the row. 
        //second binary search the row itself

        var l = 0;
        var r = matrix.Length - 1;
        var rowLength = matrix[0].Length;

        int[] targetRow = new int[0]; 

        while (l <= r){
            var m = l + (r - l) / 2;
            Console.WriteLine("m = " + m);
            if (target > matrix[m][rowLength - 1]){
                Console.WriteLine("Row is higher");
                //row is higher
                l = m + 1;
            }
            else if (target < matrix[m][0]) {
                Console.WriteLine("Row is lower");
                //row is lower
                r = m - 1;
            }
            else {
                //we found the row
                Console.WriteLine("We found the target row");
                targetRow = matrix[m];
                break;
            }
        }

        Console.WriteLine("targetRow length " + targetRow.Length);
        foreach (var n in targetRow){
            Console.WriteLine("item in row = " + n);
        }

        if (targetRow.Length == 0){
            return false;
        }

        l = 0;
        r = targetRow.Length;

        while (l <= r){
            var m = l + (r - l) / 2;
            if (targetRow[m] < target){
                l = m + 1;
            }
            else if (targetRow[m] > target){
                r = m - 1;
            }
            else {
                return true;
            }
        }

        return false;
    }
}
