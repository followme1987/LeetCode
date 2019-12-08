using System;
using System.Collections.Generic;

namespace IntersectionOfTwoLinkedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class IntersectionOfTwoLinkedListsCls
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headB == null || headB == null)
            {
                return null;
            }

            ListNode currA = headA;
            ListNode currB = headB;
            while (currA != currB)
            {
                currA = currA == null ? headB : currA.next;
                currB = currB == null ? headA : currB.next;
            }
            return currA;
        }
    }
}
