using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class ListListNode
    {
        public int val;
        public ListListNode next;
        public ListListNode(int val = 0, ListListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public static class CreateSingleLinkedList
    {
        public static ListNode Create(List<int> intList) {
            ListNode head = null;
            ListNode mover = null;

            foreach (int i in intList)
            {
                if (head == null) { 
                    head = new ListNode(i);
                    mover = head;
                }
                else
                {
                    ListNode temp = new ListNode(i);
                    mover.next = temp;
                    mover = temp;
                }
            }
            return head;
        }
        public static void Print(List<int> intList)
        {
            ListNode head = Create(intList);
            ListNode mover = head;
            while (mover != null)
            {
                Console.WriteLine(mover.val);
                mover = mover.next;
            }
        }
        public static bool Find(List<int> intList, int k)
        {
            ListNode head = Create(intList);
            ListNode mover = head;
            while (mover != null)
            {
                if (mover.val == k)
                {
                    return true;
                }
                mover = mover.next;
            }
            return false;
        }

        public static int Count(List<int> intList)
        {
            ListNode head = Create(intList);
            ListNode mover = head;
            int count = 0;
            while (mover != null)
            {
                count+=1;
                mover = mover.next;
            }
            return count;
        }
    }
}
