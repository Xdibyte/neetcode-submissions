public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        HashSet<char> substring = new HashSet<char>();
        int max = 0;
        int i = 0;
        int j = 0; 
        while(j < s.Length)
        {
            char front = s[j];
            char back = s[i];
            if(substring.Contains(front))
            {
                substring.Remove(back);
                i++;
            }
            else
            {
                substring.Add(front);
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
