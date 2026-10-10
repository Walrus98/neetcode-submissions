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

public class Solution {

    public ListNode RemoveNthFromEnd(ListNode head, int n) {

        ListNode current = head;

        int length = 0;
        while (current != null) {
            length++;
            current = current.next;
        }        

        current = head;
        ListNode prec = null;

        for (int i = 0; current != null; i++) {

            if (i == ((length) - n)) {
                if (prec == null) return head.next;
                prec.next = current.next;
            } else {
                prec = current;
            }
            current = current.next;
        }

        return head;       
    }
}
