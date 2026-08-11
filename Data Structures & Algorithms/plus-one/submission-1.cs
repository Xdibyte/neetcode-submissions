public class Solution {
    public int[] PlusOne(int[] digits) 
    {
        List<int> list = new List<int>(digits);
        int i = list.Count - 1;
        while(true)
        {
            if(i >= 0)
            {
                list[i] = list[i] + 1;
                if(list[i] > 9)
                {
                    list[i] = 0;
                    i--;
                    continue;
                }
                break;
            }
            else
            {
                list.Insert(0, 1);
                break;
            }
        }
        return list.ToArray();
    }
}
