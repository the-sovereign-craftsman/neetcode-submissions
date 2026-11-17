public class Solution {
    //backtracking with a stack
    //loop over nums to start
    //recurse and track what we've visited.
    private List<List<int>> _results = new List<List<int>>();
    private List<int> _current = new List<int>();

    public List<List<int>> Subsets(int[] nums) {
        Backtrack(nums, 0);
        return _results;
    }

    private void Backtrack(int[] nums, int i) {
        if (i == nums.Length) {
            _results.Add(_current.ToList());
            return;
        }

        _current.Add(nums[i]);

        Backtrack(nums, i + 1);

        _current.RemoveAt(_current.Count - 1);

        Backtrack(nums, i + 1);
    }
}
