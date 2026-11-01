public class Solution {
    public bool IsValid(string s) {
        
        var openStack = new Stack<char>();

        var bracketHash = new Dictionary<char, char>{
            {'}', '{'},
            {')', '('},
            {']', '['}
        };

        foreach (var c in s)
        {
            if (c == '(' || c == '{' || c == '['){
                openStack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (openStack.Count <= 0)
                {
                    return false;
                }

                if (openStack.Peek() == bracketHash.GetValueOrDefault(c))
                {
                    openStack.Pop();
                }
                else {
                    return false;
                }
            }
        }

        return openStack.Count == 0;
    }
}
