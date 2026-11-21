public class Solution {
    public int LastStoneWeight(int[] stones) {
        
        var heap = new PriorityQueue<int, int>(
            stones.Select(x => (x, x)),
            Comparer<int>.Create((a, b) => b.CompareTo(a))
        );

        while (heap.Count > 1) {
            var first = heap.Dequeue();
            var second = heap.Dequeue();

            var remaining = first - second;

            if (remaining > 0) {
                heap.Enqueue(remaining, remaining);
            }
        }

        return heap.Count == 1 ? heap.Peek() : 0;
    }
}
