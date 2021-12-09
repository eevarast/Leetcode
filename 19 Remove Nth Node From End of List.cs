/* Given the head of a linked list, remove the nth node from the end of the list and return its head. */

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
 
 // 88.44%
 
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
         ListNode current = head; int length = 1;

            //get length
            while (current.next != null)
            {
                current = current.next;
                length++;
            }
        
        if (length == 1) return null;

            current = head;

            if (n != 1)
            {
                //head
                if (length == n)
                {
                    return head.next;
                }
                //middle
                else
                {
                    int i = 1;

                    while (i < length - n)
                    {
                        current = current.next;
                        i++;
                    }
                    current.next = current.next.next;
                    return head;
                }
            }
            //tail
            else
            {
                int i = 1;
                while (i < length - 1)
                {
                    current = current.next;
                    i++;
                }
                current.next = null;
                return head;
            }
        }
    }
