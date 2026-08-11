public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int, int> frequencies = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(frequencies.ContainsKey(nums[i]))
            {
                frequencies[nums[i]]++;
            }
            else
            {
                frequencies.Add(nums[i], 0);
            }
        }
        List<int>[] buckets = new List<int>[nums.Length];
        foreach(int key in frequencies.Keys)
        {
            if(buckets[frequencies[key]] == null)
            {
                buckets[frequencies[key]] = new List<int>();
            }
            buckets[frequencies[key]].Add(key);
        }
        int[] output = new int[k];
        int counter = k - 1;
        for(int i = buckets.Length - 1; i >= 0; i--)
        {
            if(buckets[i] == null)
            {
                continue;
            }
            else
            {
                for(int j = 0; j < buckets[i].Count; j++)
                {
                    output[counter] = buckets[i][j];
                    counter--;
                    if(counter < 0)
                    {
                        return output;
                    }
                }
            }
        }
        return output;
    }
}
