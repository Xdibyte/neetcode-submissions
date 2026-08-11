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
    public ListNode ReverseList(ListNode head) 
    {
        ListNode p = null;
        ListNode c = head;
        while(c != null)
        {
            ListNode n = c.next;
            c.next = p;
            p = c;
            c = n;
        }
        head = p;
        return head;
    }
}
