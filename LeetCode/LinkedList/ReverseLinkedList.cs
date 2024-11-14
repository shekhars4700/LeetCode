using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public static class ReverseLinkedList
    {
        public static ListNode ReverseList(ListNode head)
        {
            List<int> llValues = new List<int>();
            ListNode mover = head;
            ListNode newHead = null;
            while (mover != null)
            {
                llValues.Add(mover.val);
                mover = mover.next;
            }
            newHead = new ListNode();
            newHead.val = llValues[llValues.Count -1];
            mover = newHead;
            for (int i = llValues.Count - 2; i >= 0; i--) {
                ListNode node = new ListNode(llValues[i]);
                mover.next = node;
                mover = node;
            }

            ListNode start = newHead;
            while (start != null)
            {
                Console.WriteLine(start.val);
                start = start.next;
            }


            return newHead;
        }

        public static ListNode ReverseListV2(ListNode head)
        {
            List<int> llValues = new List<int>();
            if (head == null || head.next == null) { 
                   return head;
            }

            ListNode mover = head.next;
            ListNode nextElement = mover.next;
            head.next = null;
            mover.next = head;
            ListNode prev = mover;
            mover = nextElement;
           
            while (nextElement != null)
            {
                nextElement = mover?.next;
                mover.next = prev;
                prev = mover;
                mover = nextElement;
            }
            return prev;
        }
    }
}
