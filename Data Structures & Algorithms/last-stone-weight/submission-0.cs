public class Solution {
    public int LastStoneWeight(int[] stones) 
    {
        List<int> listofstones = new List<int>(stones);
        while(listofstones.Count > 1)
        {
            listofstones.Sort();
            int x = listofstones[listofstones.Count - 1];
            int y = listofstones[listofstones.Count - 2];
            if(x == y)
            {
                listofstones.Remove(x);
                listofstones.Remove(y);
            }
            else
            {
                listofstones[listofstones.Count - 1] = x - y;
                listofstones.Remove(y);
            }
        }
        if(listofstones.Count > 0)
        {
            return listofstones[0];
        }
        else
        {
            return 0;
        }
    }
}
