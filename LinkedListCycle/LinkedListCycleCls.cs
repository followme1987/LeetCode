using System;
using System.Collections.Generic;

namespace LinkedListCycle
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    public class LinkedListCycleCls
    {
        //public bool HasCycle(ListNode head)
        //{
        //    var set = new HashSet<ListNode>();

        //    while (head != null)
        //    {
        //        if (set.Contains(head))
        //            return true;
        //        set.Add(head);
        //        head = head.next;
        //    }

        //    return false;
        //}

        public bool HasCycle(ListNode head)
        {
            if (head?.next == null)
            {
                return false;
            }

            var slow = head;
            var fast = head.next;

            while (slow != fast)
            {
                if (fast?.next == null)
                    return false;

                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }
    }
}
