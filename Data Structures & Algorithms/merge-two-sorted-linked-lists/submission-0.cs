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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        ListNode temp = new ListNode();
        ListNode currentnode = temp;
        ListNode i = list1;
        ListNode j = list2;
        while(i != null && j != null)
        {
            if(i.val <= j.val)
            {
                currentnode.next = i;
                i = i.next;
            }
            else
            {
                currentnode.next = j;
                j = j.next;
            }
            currentnode = currentnode.next;
        }
        while(i != null)
        {
            currentnode.next = i;
            i = i.next;
            currentnode = currentnode.next;
        }
        while(j != null)
        {
            currentnode.next = j;
            j = j.next;
            currentnode = currentnode.next;
        }
        return temp.next;
    }
}