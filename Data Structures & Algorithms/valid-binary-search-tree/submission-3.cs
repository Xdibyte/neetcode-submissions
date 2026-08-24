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
    public bool IsValidBST(TreeNode root) 
    {
        return DFS(root, -1000000001, 1000000001);
        bool DFS(TreeNode node, int min, int max)
        {
            if(node == null)
            {
                return true;
            }
            if(min < node.val && node.val < max)
            {
                return DFS(node.left, min, node.val) && DFS(node.right, node.val, max);
            }
            return false;
        }
    }
}
