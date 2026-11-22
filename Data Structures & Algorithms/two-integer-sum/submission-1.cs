public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numsDict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++) {
            if (!numsDict.ContainsKey(nums[i])) {
                numsDict.Add(nums[i], i);
            }

            var answer = target - nums[i];

            if (numsDict.ContainsKey(answer) && numsDict[answer] != i) {
                return new int[] {numsDict[answer], i};
            }
        }

        return new int[0];
    }
}
