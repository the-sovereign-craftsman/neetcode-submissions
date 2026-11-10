public class Solution {
    public int Search(int[] nums, int target) {
        //Binary search
        //split array in half each iteration
        //check target at m

        var l = 0;
        var r = nums.Length - 1;

        while (l <= r) {
            var m = l + (r - l) / 2;
            if (nums[m] < target) {
                l = m + 1;
            }
            else if (nums[m] > target) {
                r = m - 1;
            }
            else {
                return m;
            }
        }

        return -1;
    }
}
