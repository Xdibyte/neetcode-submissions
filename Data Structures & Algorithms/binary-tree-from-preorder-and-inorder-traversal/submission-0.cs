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
        if(preorder.Length == 0)
        {
            return null;
        }
        Dictionary<int, int> inord = new Dictionary<int, int>();
        for(int i = 0; i < inorder.Length; i++)
        {
            inord.Add(inorder[i], i);
        }
        int j = 0;
        return Construct(preorder[j], 0, preorder.Length - 1);

        TreeNode Construct(int current, int l, int h)
        {
            TreeNode node = new TreeNode();
            node.val = current;
            if(l <= inord[current] - 1)
            {
                node.left = Construct(preorder[++j], l , inord[current] - 1);
            }
            if(inord[current] + 1 <= h)
            {
                node.right = Construct(preorder[++j], inord[current] + 1, h);
            }
            return node;
        }
    }
}
