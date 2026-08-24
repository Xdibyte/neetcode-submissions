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
    public List<List<int>> LevelOrder(TreeNode root) 
    {
        List<List<int>> output = new List<List<int>>();
        if(root == null)
        {
            return output;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0)
        {
            int levelsize = queue.Count;
            output.Add(new List<int>());
            for(int i = 0; i < levelsize; i++)
            {
                TreeNode currentnode = queue.Dequeue();
                if(currentnode.left != null)
                {
                    queue.Enqueue(currentnode.left);
                }
                if(currentnode.right != null)
                {
                    queue.Enqueue(currentnode.right);
                }
                output[output.Count - 1].Add(currentnode.val);
            }
        }
        return output;
    }
}
