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
            Console.WriteLine(c);
            if (c == '(' || c == '{' || c == '['){
                openStack.Push(c);
                Console.WriteLine("pushing " + c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (openStack.Count <= 0)
                {
                    Console.WriteLine("openStack is 0 with closed c");
                    return false;
                }

                if (openStack.Peek() == bracketHash.GetValueOrDefault(c))
                {
                    Console.WriteLine("Peek equals C so pop");
                    openStack.Pop();
                }
                else {
                    return false;
                }
            }
        }
        Console.WriteLine("Count " + openStack.Count);
        return openStack.Count == 0;
    }
}
