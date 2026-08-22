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
    public int DiameterOfBinaryTree(TreeNode root) 
    {
        int maxd = 0;
        DFS(root);
        return maxd;
        int DFS(TreeNode node)
        {
            if(node == null)
            {
                return 0;
            }
            int leftheight = DFS(node.left);
            int rightheight = DFS(node.right);
            int d = leftheight + rightheight;
            maxd = Math.Max(maxd,d);
            return 1 + Math.Max(leftheight, rightheight);
        }
    }
}
