public class BrowserHistory {

    private ListNode _current;

    public BrowserHistory(string homepage) {
        _current = new ListNode(homepage);
    }
    
    public void Visit(string url) {
        var newCurrent = new ListNode(url);
        _current.next = newCurrent;
        newCurrent.prev = _current;
        _current = newCurrent;
    }
    
    public string Back(int steps) {
        while (steps > 0) {
            if (_current.prev == null){
                return _current.val;
            }
            _current = _current.prev;
            steps--;
        }
        return _current.val;
    }
    
    public string Forward(int steps) {
        while (steps > 0){
            if (_current.next == null){
                return _current.val;
            }

            _current = _current.next;
            steps--;
        }
        return _current.val;
    }
}

public class ListNode {

    public ListNode(string value){
        val = value;
    }

    public string val;
    public ListNode next;
    public ListNode prev;
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */