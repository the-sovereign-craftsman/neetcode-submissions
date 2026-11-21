public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var minHeap = new PriorityQueue<int, int>(
            nums.Select(x => (x, x))
        );

        while (minHeap.Count > k) {
            minHeap.Dequeue();
        }

        return minHeap.Peek();
    }
}
