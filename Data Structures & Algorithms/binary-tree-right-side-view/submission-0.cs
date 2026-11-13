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


//this is looking for the right most node in a given layer
public class Solution {
    public List<int> RightSideView(TreeNode root) {
        var results = new List<int>();
        var myQ = new Queue<TreeNode>();

        if (root != null) {
             myQ.Enqueue(root);
        }

        while (myQ.Count > 0) {
            var length = myQ.Count;
            var node = new TreeNode();
            for (var i = 0; i < length; i++){
                node = myQ.Dequeue();
                if (node.left != null) {
                    myQ.Enqueue(node.left);
                }
                if (node.right != null) {
                    myQ.Enqueue(node.right);
                }
            }
            results.Add(node.val);
        }

        return results;
    }
}
