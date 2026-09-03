class Solution {
    public int appendCharacters(String s, String t) 
    {
        int i = 0;
        int j = 0; 
        while(i < s.length())
        {
            if(j < t.length() && s.charAt(i) == t.charAt(j))
            {
                j++;
            }
            i++;
        }
        int returnval = 0;
        while(j < t.length())
        {
            j++;
            returnval++;
        }
        return returnval;
    }
}