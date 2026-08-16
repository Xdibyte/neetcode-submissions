public class Solution {
    public bool CheckInclusion(string s1, string s2) 
    {
        if(s1.Length > s2.Length)
        {
            return false;
        }
        int[] freq = new int[26];
        int[] window = new int[26];
        for(int i = 0; i < s1.Length; i++)
        {
            int j = (int)s1[i] - 97;
            freq[j]++;
        }
        for(int i = 0; i < s1.Length; i++)
        {
            int j = (int)s2[i] - 97;
            window[j]++;
        }
        int b = 0; 
        int f = s1.Length - 1;
        while(f < s2.Length)
        {
            bool returnval = true;
            for(int i = 0; i < 26; i++)
            {
                if(freq[i] != window[i])
                {
                    returnval = false;
                    break;
                }
            }
            if(returnval)
            {
                return true;
            }
            if(f < s2.Length - 1)
            {
                f++;
                int j = (int)s2[f] - 97;
                window[j]++;
                j = (int)s2[b] - 97;
                window[j]--;
                b++;
            }
            else
            {
                break;
            }
        }
        return false;
    }
}
