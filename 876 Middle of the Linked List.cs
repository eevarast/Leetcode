/*
Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
/*
ListNode current = head; int length = 1;
            while (current.next != null)
            {
                current = current.next;
                length++;
            }
            int i = 0;
            current = head;
            
            while (i < length / 2)
            {
                current = current.next;
                i++;
            }

            return current;
 */

 // 80.83%
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode slow = head; ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
    }
}
