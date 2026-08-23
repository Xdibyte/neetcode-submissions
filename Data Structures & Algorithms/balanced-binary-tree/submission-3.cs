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
    public bool IsBalanced(TreeNode root) 
    {
        return GetHeight(root) != -1;

        int GetHeight(TreeNode node)
        {
            if(node == null)
            {
                return 0;
            }
            int leftheight = GetHeight(node.left);
            int rightheight = GetHeight(node.right);
            if(leftheight == -1 || rightheight == -1 || Math.Abs(leftheight - rightheight) > 1)
            {
                return -1;
            }
            return 1 + Math.Max(leftheight, rightheight);
        }     
    }
}
