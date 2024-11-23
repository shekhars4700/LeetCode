using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public static class LinkedListIntersection
    {
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var moverA = headA;
            var moverB = headB;
            while (moverA != moverB) {
                moverA = moverA.next;
                if (moverA == null) {
                    moverA = headB;
                }
                moverB = moverB.next;
                if (moverB == null)
                {
                    moverB = headA;
                }
            }
            return moverA;
        }
    }
}
