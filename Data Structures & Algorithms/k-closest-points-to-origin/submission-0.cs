public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        Array.Sort(points, (a, b) => 
        {
            int distA = a[0]*a[0] + a[1]*a[1];
            int distB = b[0]*b[0] + b[1]*b[1];
            return distA.CompareTo(distB);
        });

        return points[..k];
    }
}
