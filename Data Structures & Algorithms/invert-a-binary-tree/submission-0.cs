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

public class Solution 
{
    public TreeNode InvertTree(TreeNode root) 
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if(root == null)
        {
            return root;
        }
        queue.Enqueue(root);
        while(queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();
            TreeNode temp = current.left;
            current.left = current.right;
            current.right = temp;
            if(current.left != null)
            {
                queue.Enqueue(current.left);
            }
            if(current.right != null)
            {
                queue.Enqueue(current.right);
            }
        }
        return root;
    }
}
