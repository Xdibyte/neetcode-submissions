class Solution {
    public int scoreOfString(String s) 
    {
        int total = 0;
        for(int i = 0; i < s.length() - 1; i++)
        {
            int num1 = (int)(s.charAt(i));
            int num2 = (int)(s.charAt(i + 1));
            total += Math.abs(num1 - num2);
        }
        return total;
    }
}