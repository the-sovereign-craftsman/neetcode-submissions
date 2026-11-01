public class MinStack {

    Stack<int> _minStack;
    Stack<int> _smallestValStack;
    int _lastSmallestVal;

    public MinStack() {
        _minStack = new Stack<int>();
        _smallestValStack = new Stack<int>();
        _lastSmallestVal = Int32.MaxValue;
    }
    
    public void Push(int val) {
        _minStack.Push(val);
        _lastSmallestVal = Math.Min(_lastSmallestVal, val);
        _smallestValStack.Push(_lastSmallestVal);
    }
    
    public void Pop() {
        _minStack.Pop();
        _smallestValStack.Pop();
        
        if (_smallestValStack.Count > 0)
        {
            _lastSmallestVal = _smallestValStack.Peek();
        }
        else
        {
            _lastSmallestVal = Int32.MaxValue;
        }
        
    }
    
    public int Top() {
        return _minStack.Peek();
    }
    
    public int GetMin() {
        return _smallestValStack.Peek();
    }
}
