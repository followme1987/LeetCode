using System;

namespace ReverseLinkedList
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class ReverseLinkedListCls
    {
        //public ListNode ReverseList(ListNode head)
        //{
        //    var current = head;
        //    ListNode previous = null;

        //    while (current != null)
        //    {
        //        var temp = current.next;
        //        current.next = previous;
        //        previous = current;
        //        current = temp;
        //    }

        //    return previous;
        //}

        public ListNode ReverseList(ListNode head)
        {
            if (head?.next == null) return head;
            var p = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return p;
        }
    }
}
