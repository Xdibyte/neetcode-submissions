public class Solution {

    public string Encode(IList<string> strs) 
    {
        StringBuilder encoded = new StringBuilder();
        for(int i = 0; i < strs.Count; i++)
        {
            string length = strs[i].Length.ToString();
            encoded.Append(length + "#" + strs[i]);
        }
        return encoded.ToString();
    }

    public List<string> Decode(string s) 
    {
        List<string> decoded = new List<string>();
        int i = 0;
        while(i < s.Length)
        {
            int l = i;
            while(l < s.Length && char.IsDigit(s[l]))
            {
                l++;
            }
            int newl = int.Parse(s.Substring(i, l - i));
            i = l + 1;
            decoded.Add(s.Substring(i, newl));
            i = i + newl;
        }
        return decoded;
    }
}
