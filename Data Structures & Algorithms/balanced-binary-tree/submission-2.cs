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
        bool isbalanced = true;
        GetHeight(root);
        return isbalanced;

        int GetHeight(TreeNode node)
        {
            if(node == null)
            {
                return 0;
            }
            if(isbalanced)
            {
                int leftheight = GetHeight(node.left);
                int rightheight = GetHeight(node.right);
                if(Math.Abs(leftheight - rightheight) <= 1)
                {
                    return 1 + Math.Max(leftheight, rightheight);
                }
                isbalanced = false;
            }
            return -1;
        }
    }
}
