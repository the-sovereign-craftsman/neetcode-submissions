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
    public TreeNode DeleteNode(TreeNode root, int key) {
        //binary search tree (woohoo)
        //find key node
        //replace val
        //replace original

        if (root == null) {
            return null;
        }

        if (key < root.val) {
            root.left = DeleteNode(root.left, key);
        }
        else if (key > root.val) {
            root.right = DeleteNode(root.right, key);
        }
        else {
            if (root.left == null) {
                return root.right;
            }
            else if (root.right == null) {
                return root.left;
            }
            else {
                var minNode = SearchForMin(root.right);
                root.val = minNode.val;
                root.right = DeleteNode(root.right, root.val);
            }
        }

        return root;
    }

    private TreeNode SearchForMin(TreeNode root) {
        var curr = root;
        while (curr != null && curr.left != null) {
            curr = curr.left;
        }

        return curr;
    }
}