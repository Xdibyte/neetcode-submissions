/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public List<int> RightSideView(TreeNode root) 
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        List<int> output = new List<int>();
        if(root == null)
        {
            return output;
        }
        queue.Enqueue(root);
        while(queue.Count > 0)
        {
            int levelsize = queue.Count;
            for(int i = 0; i < levelsize; i++)
            {
                TreeNode current = queue.Dequeue();
                if(i == levelsize - 1)
                {
                    output.Add(current.val);
                }
                if(current.left != null)
                {
                    queue.Enqueue(current.left);
                }
                if(current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }
        }
        return output;
    }
}
