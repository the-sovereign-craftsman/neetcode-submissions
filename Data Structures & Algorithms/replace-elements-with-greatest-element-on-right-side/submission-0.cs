public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int rightMax = -1;
        
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            var newMax = Math.Max(rightMax, arr[i]);
            arr[i] = rightMax;
            rightMax = newMax;
        }

        return arr;
    }
}