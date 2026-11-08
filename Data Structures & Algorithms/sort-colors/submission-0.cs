public class Solution {
    public void SortColors(int[] nums) {
        int[] count = {0, 0, 0};

        foreach (var num in nums){
            count[num] += 1;
        }

        int i = 0;
        for (var n = 0; n < count.Length; n++){
            for (var j = 0; j < count[n]; j++){
                nums[i] = n;
                i++;
            }
        }
    }
}