public class Solution {
    public int Search(int[] nums, int target) {
        //sorteddd array of unique nums and a target = binary search

        int l = 0;
        int r = nums.Length - 1;
        
        while (l <= r){
            int m = l + (r - l)/2;
            if (nums[m] < target){
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
