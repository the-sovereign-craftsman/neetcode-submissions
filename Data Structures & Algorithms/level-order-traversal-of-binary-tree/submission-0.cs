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
    public List<List<int>> LevelOrder(TreeNode root) {
        var outerList = new List<List<int>>();
        var myQ = new Queue<TreeNode>();
        
        if (root != null) {
            myQ.Enqueue(root);
        }
        

        while (myQ.Count > 0) {
            var innerList = new List<int>();
            var length = myQ.Count;
            for (var i = 0; i < length; i++) {
                var popped = myQ.Dequeue();
                innerList.Add(popped.val);
                if (popped.left != null) {
                    myQ.Enqueue(popped.left);
                }
                if (popped.right != null) {
                    myQ.Enqueue(popped.right);
                }
            }
            outerList.Add(innerList);
        }

        return outerList;
    }
}
