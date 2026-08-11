public class KthLargest
{
    int k;
    List<int> arr;
    public KthLargest(int k, int[] nums) 
    {
        this.k = k;
        arr = new List<int>(nums);
    }
    
    public int Add(int val) 
    {
        arr.Add(val);
        arr.Sort();
        return arr[arr.Count - k];
    }
}
