public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> queue = new Queue<int>(students);
        Console.WriteLine(queue.Count);
        
        foreach (var s in students){
            //var newNode = new ListNode(s);
            //if (head == null){
                //head = newNode;
            //}
            //else {
                //head.next = new ListNode(s);
                //tail = head.next;
            //}
        }
        int currentSandwich = 0;
        int loopCount = 0;
        while (loopCount < queue.Count){
            if (queue.Peek() == sandwiches[currentSandwich]){
                //pop from both
                queue.Dequeue();
                currentSandwich++;
                loopCount = 0;
            }
            else {
                //move head to tail and move up new head
                queue.Enqueue(queue.Dequeue());
                loopCount++;
            }
        }

        return queue.Count;
    }
}

public class ListNode {
    public int val;
    public ListNode next;

    public ListNode(int value){
        val = value;
    }
}