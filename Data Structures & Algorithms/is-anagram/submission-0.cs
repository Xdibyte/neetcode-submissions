public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length)
        {
            return false;
        }
        int[] frequencies = new int[26];
        for(int i = 0; i < s.Length; i++)
        {
            int j = (int)s[i] - 97;
            frequencies[j]++;
        }
        for(int i = 0; i < t.Length; i++)
        {
            int j = (int)t[i] - 97;
            frequencies[j]--;
        }
        for(int i = 0; i < 26; i++)
        {
            if(frequencies[i] != 0)
            {
                return false;
            }
        }
        return true;
    }
}
