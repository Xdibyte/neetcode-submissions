public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        HashSet<char> substring = new HashSet<char>();
        int max = 0;
        int i = 0;
        int j = 0; 
        while(j < s.Length)
        {
            if(substring.Contains(s[j]))
            {
                substring.Remove(s[i]);
                i++;
            }
            else
            {
                substring.Add(s[j]);
                j++;
            }
            if(substring.Count > max)
            {
                max = substring.Count;
            }
        }
        return max;
    }
}
