public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        Dictionary<string, int> visited = new Dictionary<string, int>();
        List<List<string>> output = new List<List<string>>();
        for(int i = 0; i < strs.Length; i++)
        {
            int[] frequencies = new int[26];
            for(int j = 0; j < strs[i].Length; j++)
            {
                int index = (int)(strs[i][j]) - 97;
                frequencies[index]++;
            }
            string key = string.Join(",", frequencies);
            if(visited.TryGetValue(key, out int k))
            {
                output[k].Add(strs[i]);
            }
            else
            {
                output.Add(new List<string>() { strs[i] });
                visited.Add(key, output.Count - 1);
            }
        }
        return output;
    }
}
