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
    private int _foundNodeValue = 0;
    private int _count = 0;
    public int KthSmallest(TreeNode root, int k) {
        //Depth first search, until we find the height of the tree aka minimum
        
        Search(root, k);

        return _foundNodeValue;
    }

    private void Search(TreeNode root, int k) {

        if (root == null) {
            return;
        }

        //search left
        //self
        //search right

        Search(root.left, k);
        
        _count++;
        if (_count == k) {
            _foundNodeValue = root.val;
        }

        Search(root.right, k);
    }
}
