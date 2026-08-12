public class Solution {
    public int[][] KClosest(int[][] points, int k) 
    {
        PriorityQueue<int[], double> distances = new PriorityQueue<int[], double>();
        int[][] output = new int[k][];
        for(int i = 0; i < points.Length; i++)
        {
            double sqrx = Math.Pow((double)points[i][0],2);
            double sqry = Math.Pow((double)points[i][1],2);
            double distance = sqrx + sqry;
            distances.Enqueue(points[i], distance);
        }
        for(int i = 0; i < k; i++)
        {
            output[i] = distances.Dequeue();
        }
        return output;
    }
}
