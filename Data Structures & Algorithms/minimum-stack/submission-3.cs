public class MinStack {
    //get min is the key because we will need to track the min at each level with 2 stacks

    private Stack<int> _mainStack;
    private Stack<int> _minStack;

    public MinStack() {
        _mainStack = new Stack<int>();
        _minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        _mainStack.Push(val);

        if (_minStack.Count > 0) {
            _minStack.Push(Math.Min(_minStack.Peek(), val));
        }
        else {
            _minStack.Push(val);
        }
        
    }
    
    public void Pop() {
        _mainStack.Pop();
        _minStack.Pop();
    }
    
    public int Top() {
        return _mainStack.Peek();
    }
    
    public int GetMin() {
        return _minStack.Peek();
    }
}
