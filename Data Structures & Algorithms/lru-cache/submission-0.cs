public class LRUCache {

    private Dictionary<int, ListNode> _cache;
    private ListNode _head;
    private ListNode _tail;
    private int _capacity;

    public LRUCache(int capacity) {
        _cache = new Dictionary<int, ListNode>(capacity);
        _head = new ListNode();
        _tail = new ListNode();
        _head.next = _tail;
        _tail.prev = _head;
        _capacity = capacity;
    }
    
    public int Get(int key) {
        if (!_cache.ContainsKey(key)) {
            return -1;
        }

        var node = _cache[key];
        Unlink(node);
        InsertAtHead(node);

        return node.val;
    }
    
    public void Put(int key, int value) {
        ListNode node;
        if (!_cache.ContainsKey(key)) {
            node = new ListNode(key, value);
            _cache.Add(key, node);
            InsertAtHead(node);
        }
        else {
            node = _cache[key];
            node.val = value;
            Unlink(node);
            InsertAtHead(node);
        }

        if (_cache.Count > _capacity) {
            var evictNode = _tail.prev;
            _cache.Remove(evictNode.key);
            Unlink(evictNode);
        }
    }

    private void InsertAtHead(ListNode node) {
        var next = _head.next;
        node.next = next;
        next.prev = node;
        _head.next = node;
        node.prev = _head;
    }

    private void Unlink(ListNode node) {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }
}

public class ListNode {
    public ListNode(int Key = 0, int Val = 0) {
        val = Val;
        key = Key;
    }

    public int val;
    public int key;
    public ListNode next;
    public ListNode prev;
}
