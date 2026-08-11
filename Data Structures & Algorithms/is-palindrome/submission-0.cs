public class Solution {
    public bool IsPalindrome(string s) 
    {
        int l = 0;
        int r = s.Length - 1;
        s = s.ToLower();
        while(l < r)
        {
            if(!char.IsLetterOrDigit(s[l]))
            {
                l++;
                continue;
            }
            if(!char.IsLetter(s[r]))
            {
                r--;
                continue;
            }
            if(s[l] == s[r])
            {
                l++;
                r--;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
