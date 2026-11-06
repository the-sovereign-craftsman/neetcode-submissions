public class MyStack {

    private Queue<int> _mainQueue;
    private Queue<int> _tempQueue;

    public MyStack() {
        _mainQueue = new Queue<int>();
        _tempQueue = new Queue<int>();
    }
    
    public void Push(int x) {
        _mainQueue.Enqueue(x);
    }
    
    public int Pop() {
        while (_mainQueue.Count > 1){
            _tempQueue.Enqueue(_mainQueue.Dequeue());
        }

        var top = _mainQueue.Dequeue();

        var swapQueue = _mainQueue;
        _mainQueue = _tempQueue;
        _tempQueue = swapQueue;

        return top;
    }
    
    public int Top() {
        var temp = 0;
        while (_mainQueue.Count > 0){
            temp = _mainQueue.Peek();
            _tempQueue.Enqueue(_mainQueue.Dequeue());
        }

        var swapQueue = _mainQueue;
        _mainQueue = _tempQueue;
        _tempQueue = swapQueue;

        return temp;
    }
    
    public bool Empty() {
        return _mainQueue.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */