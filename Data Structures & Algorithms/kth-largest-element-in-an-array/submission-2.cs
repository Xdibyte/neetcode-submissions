public class Solution {
    public int FindKthLargest(int[] nums, int k) 
    {
        for(int i = (nums.Length - 2) / 2; i >= 0; i--)
        {
            Heapify(nums, nums.Length, i);
        }
        int returnval = 0;
        int n = nums.Length;
        for(int i = 0; i < k; i++)
        {
            returnval = nums[0];
            nums[0] = nums[n - 1];
            Heapify(nums, n, 0);
            n = n - 1;
        }
        return returnval;

        void Heapify(int[] array, int n, int i)
        {
            int l = 2*i + 1;
            int r = 2*i + 2;
            while(l < n || r < n)
            {
                int largest = i;
                if(l < n && array[l] > array[largest])
                {
                    largest = l;
                }
                if(r < n && array[r] > array[largest])
                {
                    largest = r;
                }
                if(largest != i)
                {
                    int temp = array[i];
                    array[i] = array[largest];
                    array[largest] = temp;
                    i = largest;
                    l = 2*i + 1;
                    r = 2*i + 2;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
