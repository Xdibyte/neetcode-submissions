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
        return DFS(root, float.NegativeInfinity, float.PositiveInfinity);
        bool DFS(TreeNode node, float min, float max)
        {
            if(node == null)
            {
                return true;
            }
            if(DFS(node.left, min, node.val) && DFS(node.right, node.val, max))
            {
                if(min < node.val && node.val < max)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
