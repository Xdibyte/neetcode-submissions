public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        int l = 0;
        int r = numbers.Length - 1;
        int[] output = new int[2];
        while(l < r)
        {
            if(numbers[l] + numbers[r] == target)
            {
                output[0] = l + 1;
                output[1] = r + 1;
                return output;
            }
            else if(numbers[l] + numbers[r] < target)
            {
                l++;
            }
            else
            {
                r--;
            }
        }
        return output;
    }
}
