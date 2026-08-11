public class Solution {
    public int EvalRPN(string[] tokens) 
    {
        Stack<int> stack = new Stack<int>();
        HashSet<string> operators = new HashSet<string>() {"+","-","*","/"};
        for(int i = 0; i < tokens.Length; i++)
        {
            if(operators.Contains(tokens[i]))
            {
                int num2 = stack.Pop();
                int num1 = stack.Pop();
                int res;
                if(tokens[i] == "+")
                {
                    res = num1 + num2;
                }
                else if(tokens[i] == "-")
                {
                    res = num1 - num2;
                }
                else if(tokens[i] == "*")
                {
                    res = num1 * num2;
                }
                else
                {
                    res = num1 / num2;
                }
                stack.Push(res);
            }
            else
            {
                stack.Push(int.Parse(tokens[i]));
            }
        }
        return stack.Pop();
    }
}
