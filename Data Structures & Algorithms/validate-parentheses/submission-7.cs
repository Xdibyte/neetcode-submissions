public class Solution {
    public bool IsValid(string s) 
    {
        Dictionary<char,char> brackets = new Dictionary<char,char>()
        {
            {')', '('},
            {'}', '{'},
            {']', '['},
        };
        Stack<char> stack = new Stack<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(brackets.ContainsKey(s[i]))
            {
                if(stack.Count > 0 && brackets[s[i]] == stack.Peek())
                {
                    stack.Pop();
                    continue;
                }
            }
            stack.Push(s[i]);
        }
        if(stack.Count > 0)
        {
            return false;
        }
        return true;
    }
}
