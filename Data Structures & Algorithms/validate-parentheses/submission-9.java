class Solution {
    public boolean isValid(String s) 
    {
        Map<Character, Character> brackets = Map.of 
        (
            ')','(',
            '}','{',
            ']','['
        );
        Deque<Character> stack = new ArrayDeque<>();
        for(int i = 0; i < s.length(); i++)
        {
            if(brackets.containsKey(s.charAt(i)))
            {
                if(stack.size() == 0 || stack.peek() != brackets.get(s.charAt(i)))
                {
                    return false;
                }
                stack.pop();
            }
            else
            {
                stack.push(s.charAt(i));
            }
        }
        if(stack.size() > 0)
        {
            return false;
        }
        return true;
    }
}
