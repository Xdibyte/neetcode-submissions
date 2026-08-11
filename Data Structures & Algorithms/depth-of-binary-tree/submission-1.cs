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
    public int MaxDepth(TreeNode root) 
    {
        int grandtotal = 0;
        int depth = 1;
        MaxDepthHelper(root, depth);
        return grandtotal;
        void MaxDepthHelper(TreeNode root, int depth)
        {
            if(root == null)
            {
                return;
            }
            if(depth > grandtotal)
            {
                grandtotal = depth;
            }
            MaxDepthHelper(root.left, depth+1);
            MaxDepthHelper(root.right, depth+1);
        }
    }
}
