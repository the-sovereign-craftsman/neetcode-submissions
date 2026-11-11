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
    public List<int> InorderTraversal(TreeNode root) {
        //inorder traversal. Vs pre-order and post-order
        //this involves going left, then self, then right

        var results = new List<int>();

        return TraverseTree(root, results); 
    }

    private List<int> TraverseTree(TreeNode root, List<int> results) {
        if (root == null) {
            return results;
        }

        TraverseTree(root.left, results);
        results.Add(root.val);
        TraverseTree(root.right, results);

        return results;
    }
}