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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) 
    {
        if(root == null || subRoot == null)
        {
            return false;
        }
        if(IsSameTree(root, subRoot))
        {
            return true;
        }
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);

        bool IsSameTree(TreeNode node, TreeNode subnode)
        {
            if(node == null && subnode == null)
            {
                return true;
            }
            if(node == null || subnode == null)
            {
                return false;
            }
            if(node.val == subnode.val)
            {
                bool left = IsSameTree(node.left, subnode.left);
                bool right = IsSameTree(node.right, subnode.right);
                if(left && right)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
