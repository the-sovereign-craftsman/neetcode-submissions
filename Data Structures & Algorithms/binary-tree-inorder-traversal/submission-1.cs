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
    private List<int> _results = new List<int>();
    public List<int> InorderTraversal(TreeNode root) {
        //Depth first search - inorder traversal - iteratively
        //traversal of linked lists iteratively involves pointers
        //Is there a data structure we can use to transmogrify the linked list so that we can traverse the tree without needing to keep reference to the nodes.
        //Stacks!!
        //Two while loops. One for curr not null and stack not empty
        //Inner while loop for cull not null

        var myStack = new Stack<TreeNode>();

        var curr = root;

        while (curr != null || myStack.Count > 0) {
            while (curr != null) {
                myStack.Push(curr);
                curr = curr.left;
            }
            var popped = myStack.Pop();
            _results.Add(popped.val);
            curr = popped.right;
        }

        return _results;
    }
}