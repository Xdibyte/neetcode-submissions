class Solution {
    public boolean isAnagram(String s, String t) 
    {
        if(s.length() != t.length())
        {
            return false;
        }
        int[] frequencies = new int[26];
        for(int i = 0; i < s.length(); i++)
        {
            frequencies[(int)(s.charAt(i)) - 97]++;
        }
        for(int i = 0; i < t.length(); i++)
        {
            frequencies[(int)(t.charAt(i)) - 97]--;
        }
        for(int i = 0; i < 25; i++)
        {
            if(frequencies[i] != 0)
            {
                return false;
            }
        }
        return true;
    }
}
