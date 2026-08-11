public class Solution {
    public bool IsValid(string s) 
    {
        Stack<char> stack = new Stack<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(stack.Count > 0)
            {
                char bracket = stack.Peek();
                if(bracket == '[' && s[i] == ']' || bracket == '(' && s[i] == ')' || bracket == '{' && s[i] == '}')
                {
                    stack.Pop();
                    continue;
                }
            }
            stack.Push(s[i]);
        }
        if(stack.Count == 0)
        {
            return true;
        }
        return false;
    }
}
