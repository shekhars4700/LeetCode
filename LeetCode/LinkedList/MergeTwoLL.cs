using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public static  class MergeTwoLL
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode();
            ListNode list1Mover = list1;
            ListNode list2Mover = list2;
            ListNode resultMover = null; 


            while (list1Mover != null && list2Mover !=null)
            {
                ListNode newNode = null;
                if (list1Mover.val <= list2Mover.val)
                {
                    var min = list1Mover.val;
                    newNode = new ListNode(val: min);
                    list1Mover = list1Mover.next;
                }
                else {
                    var min = list2Mover.val;
                    newNode = new ListNode(val: min);
                    list2Mover = list2Mover.next;
                }
                if (resultMover == null)
                {
                    result = newNode;
                    resultMover = result;
                }
                else
                {
                    resultMover.next = newNode;
                    resultMover = newNode;
                }
            }

            if (list1Mover != null) {

                while (list1Mover != null) {
                    resultMover.next = list1Mover;
                    resultMover = list1Mover;
                    list1Mover = list1Mover.next;
                }
            }
            else if (list2Mover != null)
            {
                while (list2Mover != null)
                {
                    resultMover.next = list2Mover;
                    resultMover = list2Mover;
                    list2Mover = list2Mover.next;
                }
            }

            return result;
        }
    }
}
