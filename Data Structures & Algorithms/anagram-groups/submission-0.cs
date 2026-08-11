public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        Dictionary<string, int> visited = new Dictionary<string, int>();
        List<List<string>> output = new List<List<string>>();
        for(int i = 0; i < strs.Length; i++)
        {
            char[] characterarray = strs[i].ToCharArray();
            Array.Sort(characterarray);
            string temp = new string(characterarray);
            if(visited.TryGetValue(temp, out int j))
            {
                output[j].Add(strs[i]);
            }
            else
            {
                output.Add(new List<string>() {
                    strs[i]
                });
                visited.Add(temp, output.Count - 1);
            }
        }
        return output;
    }
}
