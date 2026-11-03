public class MyLinkedList {

    private ListNode _dummyHead;
    private ListNode _dummyTail;
    private int _size = 0;

    public MyLinkedList() {
        _dummyHead = new ListNode(-1);
        _dummyTail = new ListNode(-1);
        _dummyHead.next = _dummyTail;
        _dummyTail.prev = _dummyHead;
        _size = 0;
    }
    
    public int Get(int index) {
        if (index < 0 || index >= _size){
            return -1;
        }
        
        return GetNodeAtIndex(index).val;
    }
    
    public void AddAtHead(int val) {
        var newNode = new ListNode(val);
        var next = _dummyHead.next;
        _dummyHead.next = newNode;
        newNode.prev = _dummyHead;
        newNode.next = next;
        next.prev = newNode;
        _size++;
    }
    
    public void AddAtTail(int val) {
        var newNode = new ListNode(val);
        var prev = _dummyTail.prev;
        prev.next = newNode;
        newNode.next = _dummyTail;
        newNode.prev = prev;
        _dummyTail.prev = newNode;
        _size++;
    }
    
    public void AddAtIndex(int index, int val) {
        if (index == 0){
            AddAtHead(val);
            return;
        }

        if (index == _size){
            AddAtTail(val);
            return;
        }

        if (index > _size || index < 0){
            return;
        }
        
        var target = GetNodeAtIndex(index);
        var prev = target.prev;

        var newNode = new ListNode(val);

        prev.next = newNode;
        target.prev = newNode;
        newNode.prev = prev;
        newNode.next = target;
        _size++;
    }
    
    public void DeleteAtIndex(int index) {
        if (index < 0 || index >= _size) {
            return;
        }

        var target = GetNodeAtIndex(index);
        var prev = target.prev;
        var next = target.next;

        prev.next = next;
        next.prev = prev;
        _size--;
    }

    private ListNode GetNodeAtIndex(int index) {
        //Console.WriteLine("Getting node at index " + index);
        ListNode curr = _dummyHead.next;
        for (var i = 0; i < index; i++) {
            curr = curr.next;
            //Console.WriteLine("At Node " + i + " Val is " + curr.val);
        }
        return curr;
    }
}

public class ListNode {
    public ListNode(int value) {
        val = value;
    }

    public int val;
    public ListNode next;
    public ListNode prev;
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */