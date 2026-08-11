public class MinStack 
{
    public List<int> stack;
    public List<int> min;
    public MinStack() 
    {
        stack = new List<int>();
        min = new List<int>();
    }
    
    public void Push(int val) 
    {
        stack.Add(val);
        if(min.Count == 0 || val <= min[min.Count - 1])
        {
            min.Add(val);
        }
    }
    
    public void Pop() 
    {
        if(stack.Count > 0)
        {
            int val = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            if(val == min[min.Count - 1])
            {
                min.RemoveAt(min.Count - 1);
            }
        }
    }
    
    public int Top() 
    {
        if(stack.Count > 0)
        {
            return stack[stack.Count - 1];
        }
        return -1;
    }
    
    public int GetMin() 
    {
        if(min.Count > 0)
        {
            return min[min.Count - 1];
        }
        return -1;
    }
}
