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
    public TreeNode BuildTree(int[] preorder, int[] inorder) 
    {
        Dictionary<int, int> inord = new Dictionary<int, int>();
        for(int i = 0; i < inorder.Length; i++)
        {
            inord.Add(inorder[i], i);
        }
        int j = 0;
        return Construct(0, preorder.Length - 1);

        TreeNode Construct(int l, int r)
        {
            if(l > r)
            {
                j = j - 1;
                return null;
            }
            TreeNode node = new TreeNode();
            int c = j;
            node.val = preorder[c];
            j = j + 1;
            node.left = Construct(l, inord[preorder[c]] - 1);
            j = j + 1;
            node.right = Construct(inord[preorder[c]] + 1, r);
            return node;
        }
    }
}
