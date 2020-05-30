using System;

namespace ReverseLinkedList
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int pVal)
        {
            val = pVal;
            next = null;
        }
    }

    class MainClass
    {
        public static ListNode Reverse(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode nextNodeOfHead = head.next;
            ListNode tmp = Reverse(head.next);
            nextNodeOfHead.next = head;
            head.next = null;
            return tmp;
        }

        public static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            ListNode p = head;
            while (p != null)
            {
                Console.Write(p.val + ", ");
                p = p.next;
            }
            Console.WriteLine("After reversing:");
            ListNode headRes = head = Reverse(head);
            p = headRes;
            while (p != null)
            {
                Console.Write(p.val + ", ");
                p = p.next;
            }

        }
    }
}
