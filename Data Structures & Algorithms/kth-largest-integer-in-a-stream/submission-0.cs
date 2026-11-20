//kth largest = max heap
public class KthLargest {

    private PriorityQueue<int, int> _minHeap;
    private int _k = 0;

    public KthLargest(int k, int[] nums) {
        _k = k;
        _minHeap = new PriorityQueue<int, int>(nums.Select(x => (x, x)));

        while (_minHeap.Count > _k) {
            _minHeap.Dequeue();
        }
    }
    
    public int Add(int val) {
        if (_minHeap.Count < _k) {
            _minHeap.Enqueue(val, val);
        }
        else if (val > _minHeap.Peek()) {
            _minHeap.EnqueueDequeue(val, val);
        }

        return _minHeap.Peek();
    }
}
