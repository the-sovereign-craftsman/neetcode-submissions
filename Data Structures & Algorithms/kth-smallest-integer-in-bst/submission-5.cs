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
    public int KthSmallest(TreeNode root, int k) {
        //iteratively BTS search
        //we will use a stack as we traverse the tree
        //we will use a pointer for head and our loop condition will be pointer isn't null and stack isnt empty. We will have an inner loop for curr being null
        var minStack = new Stack<TreeNode>();
        var curr = root;
        while (curr != null || minStack.Count > 0){
            while (curr != null) {
                minStack.Push(curr);
                curr = curr.left;
            }
            var popped = minStack.Pop();
            //Console.WriteLine("popped: " + popped.val);
            k--;
            //Console.WriteLine("k: " + k);
            if (k == 0){
                return popped.val;
            }

            curr = popped.right;
        }

        return -1;
    }
}
