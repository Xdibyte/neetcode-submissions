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
    public int KthSmallest(TreeNode root, int k) 
    {
        int count = 0;
        int returnval = 0;
        DFS(root);
        return returnval;
        void DFS(TreeNode node)
        {
            if(node == null)
            {
                return;
            }
            DFS(node.left);
            count++;
            if(count == k)
            {
                returnval = node.val;
            }
            DFS(node.right);
        }
    }
}
