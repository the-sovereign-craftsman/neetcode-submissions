public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numsDict = new Dictionary<int, int>();

        foreach (var num in nums) {
            if (!numsDict.ContainsKey(num)) {
                numsDict.Add(num, 1);
            }
            else {
                return true;
            }
        }

        return false;
    }
}