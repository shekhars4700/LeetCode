using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public static class AddTwoLists
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(-1);
            ListNode curr = dummyHead;
            int carry = 0;
            int sum = 0;
            while (l1 != null || l2 != null) {
                if (l1 != null) { 
                    sum += l1.val;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                }
                sum += carry;
                carry = sum / 10;
                var node = new ListNode(sum % 10);
                curr.next = node;
                curr = curr.next;

                if (l1 != null) { 
                    l1= l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
                sum = 0;
            }

            if(carry > 0)
            {
                var node = new ListNode(carry);
                curr.next = node;
            }
            return dummyHead.next;
        }

    }
}
