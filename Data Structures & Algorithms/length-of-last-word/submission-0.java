class Solution {
    public int lengthOfLastWord(String s) {
        int lengthOfWord = 0;
        boolean seenWord = false;
        for(int i = s.length() - 1; i >= 0; i--)
        {
            if(s.charAt(i) == ' ' && seenWord)
            {
                break;
            }
            else if(s.charAt(i) != ' ')
            {
                seenWord = true;
                lengthOfWord++;
            }
        }
        return lengthOfWord;
    }
}